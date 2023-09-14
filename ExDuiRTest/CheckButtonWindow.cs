using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class CheckButtonWindow
    {
        static private ExSkin skin;
        static private ExCheckButton checkButton1;
        static private ExCheckButtonEx checkButtonex1;
        static private ExRadioButton radiobutton1;
        static private ExRadioButton radiobutton2;
        static private ExRadioButtonEx radiobuttonex1;
        static private ExRadioButtonEx radiobuttonex2;
        static private ExCheckBox checkbox1;

        static public void CreateCheckButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试单选框复选框", 0, 0, 300, 250,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                checkButton1 = new ExCheckButton(skin, "复选框", 10, 30, 60, 20, -1);
                radiobutton1 = new ExRadioButton(skin, "单选框1", 10, 60, 80, 20, -1);
                radiobutton2 = new ExRadioButton(skin, "单选框2", 100, 60, 80, 20, -1);
                checkButtonex1 = new ExCheckButtonEx(skin, "扩展复选框", 10, 90, 120, 20, -1);
                checkButtonex1.SetCheck(2);
                radiobuttonex1 = new ExRadioButtonEx(skin, "扩展单选框1", 10, 120, 100, 20, -1);
                radiobuttonex2 = new ExRadioButtonEx(skin, "扩展单选框2", 100, 120, 100, 20, -1);
                checkbox1 = new ExCheckBox(skin, "记住账号", 10, 150, 100, 30, -1);
                checkbox1.Check = true;
                checkbox1.HandleEvent(NM_CHECK, OnCheckButtonEventProc);

                skin.Visible = true;
            }
        }

        static public IntPtr OnCheckButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (wParam != IntPtr.Zero)
            {
                bool check = true;
                ExMessageBox.ShowEx(skin, "选中了", "取CheckButton状态", MB_USERICON, "不再提示", ref check, 10, MESSAGEBOX_FLAG_CENTEWINDOW);
            }
            else
            {
                ExMessageBox.Show(skin, "取消选中啦", "取CheckButton状态", MB_ICONWARNING, MESSAGEBOX_FLAG_CENTEWINDOW);
            }
            return IntPtr.Zero;
        }
    }
}
