using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class ProgressBarWindow
    {
        static private ExSkin skin;
        static private ExProgressBar progressbar;
        static private ExObjProcDelegate objProc;

        static public void CreateProgressBarWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试进度条", 0, 0, 400, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                progressbar = new ExProgressBar(skin, "", 50, 100, 300, 20);
                objProc = new ExObjProcDelegate(OnProgressBarProc);
                progressbar.ObjProc = Marshal.GetFunctionPointerForDelegate(objProc);
                progressbar.ColorTextNormal = Util.ExRGB2ARGB(16777215, 255);
                progressbar.Radius = 10;
                progressbar.Range = 255;
                progressbar.Timer = 50;
                skin.Visible = true;
            }
        }

        static private IntPtr OnProgressBarProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_TIMER)
            {
                var pos = progressbar.Pos;
                var range = progressbar.Range;
                Random rn = new Random();
                progressbar.Pos = pos + rn.Next(1, 20);
                progressbar.Invalidate();
                if(range == pos)
                {
                    progressbar.Timer = 0;
                    ExMessageBox.Show(progressbar, "加载完毕", "提示", MB_OK, MESSAGEBOX_FLAG_CENTEWINDOW);
                }
            }
            return IntPtr.Zero;
        }
    }
}
