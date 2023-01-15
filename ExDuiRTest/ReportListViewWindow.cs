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
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                reportlistview = new ExReportListView(skin, "", 25, 50, 350, 250, EOS_BORDER | EOS_VISIBLE | EOS_HSCROLL | EOS_VSCROLL);
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
                    dwStyle = ERLV_CS_DEFAULT,
                    dwTextFormat = DT_LEFT
                };
                reportlistview.SetColumn(col1);

                ExReportListColumnInfo col2 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("固定列宽"),
                    nWidth = 110,
                    crText = Util.ExRGB2ARGB(16711680, 255),
                    dwStyle = ERLV_CS_LOCKWIDTH,
                    dwTextFormat = DT_LEFT
                };
                reportlistview.SetColumn(col2);

                ExReportListColumnInfo col3 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("居中可点击"),
                    nWidth = 110,
                    crText = Util.ExRGB2ARGB(65535, 255),
                    dwStyle = ERLV_CS_CLICKABLE,
                    dwTextFormat = DT_CENTER | DT_VCENTER
                };
                reportlistview.SetColumn(col3);

                ExReportListColumnInfo col4 = new ExReportListColumnInfo
                {
                    pwzText = Marshal.StringToHGlobalUni("可排序"),
                    nWidth = 60,
                    crText = Util.ExRGB2ARGB(16777215, 255),
                    dwStyle = ERLV_CS_CLICKABLE | ERLV_CS_SORTABLE,
                    dwTextFormat = DT_RIGHT | DT_VCENTER
                };
                reportlistview.SetColumn(col4);
                Random rn = new Random();
                for(int i = 1; i<=1000; i++)
                {
                    ExReportListRowInfo row = new ExReportListRowInfo
                    {
                        lParam = (IntPtr)(i + 1)
                    };
                    var rowIndex = reportlistview.SetRow(row);
                    ExReportListItemInfo item1 = new ExReportListItemInfo
                    {
                        nImageIndex = i,
                        dwStyle = (i % 3 == 0 ? ERLV_RS_CHECKBOX | ERLV_RS_CHECKBOX_CHECK : 0),
                        iRow = rowIndex,
                        iCol = 1,
                        pwzText = Marshal.StringToHGlobalUni("第" + i.ToString() + "项")
                    };
                    reportlistview.SetItem(item1);

                    ExReportListItemInfo item2 = new ExReportListItemInfo
                    {
                        nImageIndex = i,
                        dwStyle = (i % 3 == 0 ? ERLV_RS_CHECKBOX | ERLV_RS_CHECKBOX_CHECK : 0),
                        iRow = rowIndex,
                        iCol = 2,
                        pwzText = Marshal.StringToHGlobalUni("第二列")
                    };
                    reportlistview.SetItem(item2);

                    ExReportListItemInfo item3 = new ExReportListItemInfo
                    {
                        nImageIndex = i,
                        dwStyle = (i % 3 == 0 ? ERLV_RS_CHECKBOX | ERLV_RS_CHECKBOX_CHECK : 0),
                        iRow = rowIndex,
                        iCol = 3,
                        pwzText = Marshal.StringToHGlobalUni("第三列")
                    };
                    reportlistview.SetItem(item3);

                    ExReportListItemInfo item4 = new ExReportListItemInfo
                    {
                        nImageIndex = i,
                        dwStyle = (i % 3 == 0 ? ERLV_RS_CHECKBOX | ERLV_RS_CHECKBOX_CHECK : 0),
                        iRow = rowIndex,
                        iCol = 4,
                        pwzText = Marshal.StringToHGlobalUni(rn.Next(0, 1000).ToString())
                    };
                    reportlistview.SetItem(item4);
                }
                reportlistview.Update();
                reportlistview.HandleEvent(LVN_ITEMCHANGED, itemChangeProc);
                reportlistview.HandleEvent(RLVN_COLUMNCLICK, columnClickProc);
                reportlistview.HandleEvent(RLVN_CHECK, itemCheckProc);

                button = new ExButton(skin, "删除列", 20, 330, 100, 30);
                button.HandleEvent(NM_CLICK, buttonClickProc);

                skin.Visible = true;
            }
        }

        static private IntPtr OnReportListViewItemChange(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == LVN_ITEMCHANGED)
            {
                Console.WriteLine($"你选择了第" + ((int)wParam).ToString() + "项");
            }
            return default;
        }

        static private IntPtr OnReportListViewColumnClick(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == RLVN_COLUMNCLICK)
            {
                Console.WriteLine($"你选择了第" + ((int)wParam).ToString() + "列表头");
            }
            return default;
        }

        static private IntPtr OnReportListViewItemChecked(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == RLVN_CHECK)
            {
                Console.WriteLine($"第" + ((int)wParam).ToString() + "项选择框状态发生变化,选中状态：" + ((int)lParam).ToString());
            }
            return default;
        }

        static private IntPtr OnReportListViewButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            reportlistview.SendMessage(LVM_DELETECOLUMN, (IntPtr)1, (IntPtr)2);
            return default;
        }
    }
}
