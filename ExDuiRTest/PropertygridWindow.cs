using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class PropertygridWindow
    {
        static private ExSkin skin;
        static private ExPropertyGrid propertygrid;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExObjEventProcDelegate buttonProc;
        static private ExObjEventProcDelegate propertygridProc;

        static public void CreatePropertygridWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试属性框", 0, 0, 500, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                propertygrid = new ExPropertyGrid(skin, "属性框", 50, 50, 300, 300, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_VSCROLL, -1, DT_LEFT);
                propertygrid.ColorBackground = Util.ExRGB2ARGB(14737632, 255);
                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                propertygridProc = new ExObjEventProcDelegate(OnPropertyGridEvent);
                propertygrid.HandleEvent(PROPERTYGRID_EVENT_ITEMVALUECHANGE, propertygridProc);  
                button1 = new ExButton(skin, "取表项内容", 380, 70, 100, 30);
                button2 = new ExButton(skin, "置表项内容", 380, 120, 100, 30);
                button3 = new ExButton(skin, "修改组件大小", 380, 170, 100, 30);
                button1.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_CLICK, buttonProc);
                button3.HandleEvent(NM_CLICK, buttonProc);

                ExPropergridItemInfo item1 = new ExPropergridItemInfo
                {
                    title = Marshal.StringToHGlobalUni("小组A")
                };
                propertygrid.AddItem(PROPERTYGRID_OBJTYPE_GROUP, item1);

                ExPropergridItemInfoCombobox combobox1 = new ExPropergridItemInfoCombobox
                {
                    text = Marshal.StringToHGlobalUni("表项1-1")
                };
                ExPropergridItemInfoCombobox combobox2 = new ExPropergridItemInfoCombobox
                {
                    text = Marshal.StringToHGlobalUni("表项1-2")
                };
                ExPropergridItemInfo item2 = new ExPropergridItemInfo
                {
                    title = Marshal.StringToHGlobalUni("组合框一")
                };

                item2.textCombobox[0] = combobox1;
                item2.textCombobox[1] = combobox2;
                item2.comboboxNum = 2;
                propertygrid.AddItem(PROPERTYGRID_OBJTYPE_COMBOBOX, item2);

                ExPropergridItemInfo item3 = new ExPropergridItemInfo
                {
                    title = Marshal.StringToHGlobalUni("颜色"),
                    text = Marshal.StringToHGlobalUni(Util.ExRGB2ARGB(167549,255).ToString())
                };
                propertygrid.AddItem(PROPERTYGRID_OBJTYPE_COLORPICKER, item3);

                ExPropergridItemInfo item4 = new ExPropergridItemInfo
                {
                    title = Marshal.StringToHGlobalUni("日期"),
                    text = Marshal.StringToHGlobalUni(DateTime.Now.ToString("yyyy-M-dd"))
                };
                propertygrid.AddItem(PROPERTYGRID_OBJTYPE_DATEBOX, item4);
                List<string> titles = new List<string> { "普通编辑框", "数字输入编辑框", "字母输入编辑框", "字母数字编辑框", "只读编辑框" };
                List<string> texts = new List<string> { "中文123abc", "1234567890", "aA", "aA123", "测试只读" };
                List<int> editStyles = new List<int> { 0, 1, 2, 3, 4, 5 };
                for (int i = 0; i < 5; i++)
                {
                    ExPropergridItemInfo item = new ExPropergridItemInfo
                    {
                        title = Marshal.StringToHGlobalUni(titles[i]),
                        text = Marshal.StringToHGlobalUni(texts[i]),
                        editStyle = editStyles[i]
                    };
                    propertygrid.AddItem(PROPERTYGRID_OBJTYPE_EDIT, item);
                }

                ExPropergridItemInfo item5 = new ExPropergridItemInfo
                {
                    title = Marshal.StringToHGlobalUni("小组B")
                };
                propertygrid.AddItem(PROPERTYGRID_OBJTYPE_GROUP, item5);
                for (int i = 0; i < 4; i++)
                {
                    ExPropergridItemInfo item = new ExPropergridItemInfo
                    {
                        title = Marshal.StringToHGlobalUni("名称" + (i + 1).ToString()),
                        text = Marshal.StringToHGlobalUni("值" + (i + 1).ToString()),
                    };
                    propertygrid.AddItem(PROPERTYGRID_OBJTYPE_EDIT, item);
                }
                skin.Visible = true;
            }
        }
        static public IntPtr OnPropertyGridEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            var itemInfo = Util.IntPtrToStructure<ExPropergridChangeItemInfo>(lParam);
            Console.WriteLine($"属性框值改变,对应行索引:{wParam},改变后值:{itemInfo.text},改变类型:{itemInfo.type}");
            return IntPtr.Zero;
        }
        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == NM_CLICK)
            {
                if(hObj == button1.handle)
                {
                    var ret = propertygrid.GetItemValue("名称2");
                    Console.WriteLine($"名称2 对应值{ret}");
                }
                else if (hObj == button2.handle)
                {
                    propertygrid.SetItemValue("名称2","新数值123");
                }
                else if (hObj == button3.handle)
                {
                    propertygrid.Move(20, 30, 350, 360);
                }
            }
            return IntPtr.Zero;
        }
    }
}
