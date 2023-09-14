using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class CustomRedrawWindow
    {
        static private ExSkin skin;
        static private ExSysButton sysbutton;
        static private ExWndProcDelegate wndProc;

        static public void CreateCustomRedrawWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWinMsgProc);
            skin = new ExSkin(pOwner, null, "", 0, 0, 300, 200,
            WINDOW_STYLE_MOVEABLE | WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                sysbutton = new ExSysButton(skin, "", (300 - 32) / 2, (200 - 32) / 2, 32, 32, OBJECT_STYLE_VISIBLE | WINDOW_STYLE_BUTTON_CLOSE, OBJECT_STYLE_EX_TOPMOST);

                skin.Visible = true;
            }
        }

        static private IntPtr OnWinMsgProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_ERASEBKGND) //wParam画布句柄, LOWORD(lParam)为宽度,HIWORD(lParam)为高度
            {
                var canvas = new ExCanvas((int)wParam);
                canvas.AntiAlias = true;
                var rc = skin.ClientRect;
                float[] arrStopPts = new float[] { 0, Util.ExRGBA(10, 127, 213, 220), 1, Util.ExRGBA(200, 10, 10, 220) };
                var brush = new ExBrush(0, 0, rc.nRight, rc.nBottom, arrStopPts, 2);
                canvas.FillEllipse(brush, Util.LOWORD((uint)lParam) / 2, Util.HIWORD((uint)lParam) / 2, Util.LOWORD((uint)lParam) / 2 - 2, Util.HIWORD((uint)lParam) / 2 - 2);
                brush.Dispose();
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }
    }
}
