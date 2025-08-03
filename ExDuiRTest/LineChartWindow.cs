using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;
using ExDuiR.NET.Frameworks.Graphics;

namespace ExDuiRTest
{
    class LineChartWindow
    {
        static private ExSkin skin;
        static private ExLineChart linechart;
        static private ExObjProcDelegate objProc;

        static public void CreateLineChartWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试折线图", 0, 0, 700, 500,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnLineChartMsgProc);
                linechart = new ExLineChart(skin, "", 50, 50, 600, 300, pfnObjProc: objProc);
                linechart.SetForegroundColorFill = Util.ExARGB(80, 85, 205, 200);
                linechart.SetForegroundColorDraw = Util.ExARGB(100, 200, 100, 255);

                linechart.Timer = 500;

                skin.Visible = true;
            }
        }

        static public IntPtr OnLineChartMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_TIMER)
            {
                var y = new Random().Next() % 30 + 30;
                linechart.SetValue = y;
                linechart.Invalidate();
            }
            return IntPtr.Zero;
        }
    }
}