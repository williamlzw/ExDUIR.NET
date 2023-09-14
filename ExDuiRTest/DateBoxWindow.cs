using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Data;

namespace ExDuiRTest
{
    static class DateBoxWindow
    {
        static private ExSkin skin;
        static private ExDateBox datebox;
        static private ExObjEventProcDelegate objProc;

        static public void CreateDateBoxWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试日期框", 0, 0, 250, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                datebox = new ExDateBox(skin, "", 50, 80, 150, 30);
                datebox.ColorBackground = -1;
                datebox.ColorTextNormal = Util.ExRGB2ARGB(16711680, 255);
                objProc = new ExObjEventProcDelegate(OnButtonEventProc);
                datebox.HandleEvent(DATEBOX_EVENT_DATETIME, objProc);
                skin.Visible = true;
            }
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == DATEBOX_EVENT_DATETIME)
            {
                var dt = Util.IntPtrToStructure<ExDateTimeInfo>(lParam);
                Console.WriteLine($"日期已更改,{dt.Year},{dt.Mon},{dt.Mday},{dt.Wday}");
            }
            return IntPtr.Zero;
        }
    }
}
