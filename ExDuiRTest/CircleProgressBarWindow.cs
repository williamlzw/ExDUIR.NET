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
    class CircleProgressBarWindow
    {
        static private ExSkin skin;
        static private ExCircleProgressBar circleprogressbar;
        static private ExCircleProgressBar circleprogressbar2;
        static private ExObjProcDelegate objProc;

        static public void CreateCircleProgressBarWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试环形进度条", 0, 0, 400, 500,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnCircleProgressBarProc);

                circleprogressbar = new ExCircleProgressBar(skin, "", 50, 100, 100, 100);
                circleprogressbar.Range = 100;
                circleprogressbar.LineCap = 0;
                circleprogressbar.LineHeight = 16;
                circleprogressbar.ColorTextNormal = Util.ExRGB2ARGB(16777215, 255);
                circleprogressbar.ObjProc = Marshal.GetFunctionPointerForDelegate(objProc);
                circleprogressbar.Timer = 50;

                circleprogressbar2 = new ExCircleProgressBar(skin, "", 180, 100, 200, 200);
                circleprogressbar2.Range = 100;
                circleprogressbar2.LineCap = 1;
                circleprogressbar2.LineHeight = 40;
                circleprogressbar2.ColorTextNormal = Util.ExRGB2ARGB(16777215, 255);
                circleprogressbar2.BackgroundColor = Util.ExARGB(30, 130, 100, 255);
                circleprogressbar2.ForegroundColor = Util.ExARGB(100, 130, 30, 255);
                circleprogressbar2.Font = new ExFont("MicroSoft Yahei", 30, 0);
                circleprogressbar2.ObjProc = Marshal.GetFunctionPointerForDelegate(objProc);
                circleprogressbar2.Timer = 50;

                skin.Visible = true;
            }
        }

        static private IntPtr OnCircleProgressBarProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_TIMER)
            {
                ExCircleProgressBar curent = new ExCircleProgressBar(hObj);
                var pos = curent.Pos;
                var range = curent.Range;
                curent.Pos = pos + new Random().Next(1, 10);
                curent.Invalidate();
                if(range == pos)
                {
                    curent.Timer = 0;
                }
            }
            return IntPtr.Zero;
        }
    }
}
