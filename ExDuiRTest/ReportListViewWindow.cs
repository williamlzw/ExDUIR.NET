using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System.Runtime.InteropServices;
using System;

namespace ExDuiRTest
{
    static class ReportListViewWindow
    {
        static private ExSkin skin;
        static private ExReportListView reportlistview;
        static private ExImageList imglist;
        static private ExObjEventProcDelegate itemChangeProc;
        static private ExObjEventProcDelegate columnClickProc;
        static private ExObjEventProcDelegate itemCheckProc;
        static private ExObjEventProcDelegate buttonClickProc;
        static private ExButton button;
        static public void CreateReportListViewWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试报表列表", 0, 0, 400, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                reportlistview = new ExReportListView(skin, "", 25, 50, 350, 250, OBJECT_STYLE_BORDER | OBJECT_STYLE_VISIBLE | OBJECT_STYLE_HSCROLL | OBJECT_STYLE_VSCROLL | REPORTLISTVIEW_STYLE_EDIT | REPORTLISTVIEW_STYLE_DRAWVERTICALLINE);
                reportlistview.ColorBackground = Util.ExRGB2ARGB(16777215, 100);
                reportlistview.ColorBorder = Util.ExRGBA(120, 120, 120, 255);
                reportlistview.ColorListViewHead = Util.ExRGB2ARGB(16777215, 100);
                reportlistview.ColorTextHover = Util.ExRGB2ARGB(12632256, 100);
                imglist = new ExImageList(30, 30);
                var img = new ExImage(Properties.Resources.close);
                imglist.AddImage(img, 0);
                reportlistview.SetImageList(imglist);

                itemChangeProc = new ExObjEventProcDelegate(OnReportListViewItemChange);
                columnClickProc = new ExObjEventProcDelegate(OnReportListViewColumnClick);
                itemCheckProc = new ExObjEventProcDelegate(OnReportListViewItemChecked);
                buttonClickProc = new ExObjEventProcDelegate(OnReportListViewButtonEvent);

                ExReportListColumnInfo col1 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("第一列"),
                    nWidth = 60,
                    crText = Util.ExRGB2ARGB(255, 255),
                    dwStyle = REPORTLISTVIEW_HEADER_STYLE_DEFAULT,
                    dwTextFormat = DT_LEFT
                };
                reportlistview.SetColumn(col1);

                ExReportListColumnInfo col2 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("固定列宽"),
                    nWidth = 110,
                    crText = Util.ExRGB2ARGB(16711680, 255),
                    dwStyle = REPORTLISTVIEW_HEADER_STYLE_LOCKWIDTH,
                    dwTextFormat = DT_LEFT
                };
                reportlistview.SetColumn(col2);

                ExReportListColumnInfo col3 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("居中可点击"),
                    nWidth = 110,
                    crText = Util.ExRGB2ARGB(65535, 255),
                    dwStyle = REPORTLISTVIEW_HEADER_STYLE_CLICKABLE | REPORTLISTVIEW_HEADER_STYLE_COLOUR,
                    dwTextFormat = DT_CENTER | DT_VCENTER,
                    crBkg = Util.ExRGBA(120, 230, 180, 255)
                };
                reportlistview.SetColumn(col3);

                ExReportListColumnInfo col4 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("可排序"),
                    nWidth = 60,
                    crText = Util.ExRGB2ARGB(16777215, 255),
                    dwStyle = REPORTLISTVIEW_HEADER_STYLE_CLICKABLE | REPORTLISTVIEW_HEADER_STYLE_SORTABLE,
                    dwTextFormat = DT_RIGHT | DT_VCENTER
                };
                reportlistview.SetColumn(col4);
                Random rn = new Random();
                for(int i = 1; i <= 1000; i++)
                {
                    ExReportListRowInfo row = new ExReportListRowInfo
                    {
                        lParam = (IntPtr)(i + 1)
                    };
                    var rowIndex = reportlistview.SetRow(row);
                    ExReportListItemInfo item1 = new ExReportListItemInfo
                    {
                        nImageIndex = i,
                        dwStyle = (i % 3 == 0 ? REPORTLISTVIEW_LINESTYLE_CHECKBOX | REPORTLISTVIEW_LINESTYLE_CHECKBOX_CHECK | REPORTLISTVIEW_LINESTYLE_ROWCOLOUR : 0),
                        iRow = rowIndex,
                        crRowBkg = Util.ExRGBA(31, 100, 200, 255)
                    };
                    reportlistview.SetItem(item1);

                    ExReportListCellInfo cell1 = new ExReportListCellInfo
                    {
                        iCol = 1,
                        iRow = i,
                        pwzText = Marshal.StringToHGlobalUni("第" + i.ToString() + "项"),
                        cellStyle = 0
                    };
                    reportlistview.SetCell(cell1);

                    ExReportListCellInfo cell2 = new ExReportListCellInfo
                    {
                        iCol = 2,
                        iRow = i,
                        pwzText = Marshal.StringToHGlobalUni("第二列"),
                        cellStyle = REPORTLISTVIEW_CELLSTYLE_CELLCOLOUR,
                        cellBkgCr = Util.ExRGBA(130,130,25,255)
                    };
                    reportlistview.SetCell(cell2);

                    ExReportListCellInfo cell3 = new ExReportListCellInfo
                    {
                        iCol = 3,
                        iRow = i,
                        pwzText = Marshal.StringToHGlobalUni("第三列"),
                        cellStyle = REPORTLISTVIEW_CELLSTYLE_CELLTEXTCOLOUR,
                        cellTextCr = Util.ExRGBA(130, 25, 130, 255)
                    };
                    reportlistview.SetCell(cell3);

                    ExReportListCellInfo cell4 = new ExReportListCellInfo
                    {
                        iCol = 4,
                        iRow = i,
                        pwzText = Marshal.StringToHGlobalUni(rn.Next(0, 1000).ToString()),
                        cellStyle = REPORTLISTVIEW_CELLSTYLE_CELLFONT,
                        cellFont = new ExFont("微软雅黑", 20, 0).handle
                    };
                    reportlistview.SetCell(cell4);
                }
                reportlistview.Update();
                reportlistview.HandleEvent(LISTVIEW_EVENT_ITEMCHANGED, itemChangeProc);
                reportlistview.HandleEvent(REPORTLISTVIEW_EVENT_COLUMNCLICK, columnClickProc);
                reportlistview.HandleEvent(REPORTLISTVIEW_EVENT_CHECK, itemCheckProc);

                button = new ExButton(skin, "删除列", 20, 330, 100, 30);
                button.HandleEvent(NM_CLICK, buttonClickProc);

                skin.Visible = true;
            }
        }

        static private IntPtr OnReportListViewItemChange(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == LISTVIEW_EVENT_ITEMCHANGED)
            {
                Console.WriteLine($"你选择了第" + ((int)wParam).ToString() + "项");
            }
            return default;
        }

        static private IntPtr OnReportListViewColumnClick(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == REPORTLISTVIEW_EVENT_COLUMNCLICK)
            {
                Console.WriteLine($"你选择了第" + ((int)wParam).ToString() + "列表头");
            }
            return default;
        }

        static private IntPtr OnReportListViewItemChecked(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == REPORTLISTVIEW_EVENT_CHECK)
            {
                Console.WriteLine($"第" + ((int)wParam).ToString() + "项选择框状态发生变化,选中状态：" + ((int)lParam).ToString());
            }
            return default;
        }

        static private IntPtr OnReportListViewButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            reportlistview.SendMessage(LISTVIEW_MESSAGE_DELETECOLUMN, (IntPtr)1, (IntPtr)2);
            return default;
        }
    }
}
