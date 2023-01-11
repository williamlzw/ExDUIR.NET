using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class ComboBoxWindow
    {
        static private ExSkin skin;
        static private ExComboBox combobox;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExButton button4;
        static private ExButton button5;
        static private ExButton button6;
        static private ExButton button7;

        static private ExObjEventProcDelegate buttonProc;

        static public void CreateComboBoxWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试组合框", 0, 0, 450, 300,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                combobox = new ExComboBox(skin, "测试组合框", 10, 30, 200, 30, EOS_VISIBLE | ECS_ALLOWEDIT);
                combobox.AddString("英文字母abc");
                combobox.AddString("数字123");
                combobox.AddString("中文");
                combobox.AddString("特殊字符[！（）");

                button1 = new ExButton(skin, "添加项目", 230, 30, 100, 30, -1);
                button2 = new ExButton(skin, "插入项目", 230, 70, 100, 30, -1);
                button3 = new ExButton(skin, "取内容", 230, 110, 100, 30, -1);
                button4 = new ExButton(skin, "置内容", 340, 30, 100, 30, -1);
                button5 = new ExButton(skin, "清空表项", 340, 70, 100, 30, -1);
                button6 = new ExButton(skin, "弹出列表", 340, 110, 100, 30, -1);
                button7 = new ExButton(skin, "删除项目", 230, 150, 100, 30, -1);

                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                button1.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_CLICK, buttonProc);
                button3.HandleEvent(NM_CLICK, buttonProc);
                button4.HandleEvent(NM_CLICK, buttonProc);
                button5.HandleEvent(NM_CLICK, buttonProc);
                button6.HandleEvent(NM_CLICK, buttonProc);
                button7.HandleEvent(NM_CLICK, buttonProc);

                skin.Visible = true;
            }
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(hObj == button1.handle)
            {
                combobox.AddString("测试添加");
            }
            else if (hObj == button2.handle)
            {
                combobox.InsertString(2, "插入项目");
            }
            else if (hObj == button3.handle)
            {
                Console.WriteLine(combobox.Text);
            }
            else if (hObj == button4.handle)
            {
                combobox.Text = "置内容";
            }
            else if (hObj == button5.handle)
            {
                combobox.ResetContent();
            }
            else if (hObj == button6.handle)
            {
                combobox.DropDown = true;
            }
            else if (hObj == button7.handle)
            {
                combobox.DeleteString(2);
            }
            return IntPtr.Zero;
        }
    }
}
