using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using ExDuiR.NET.Frameworks.Graphics;

namespace ExDuiRTest
{
    static class NchitTestWindow
    {
        static private ExSkin skin;
        static private ExStatic label;
        static private ExObjProcDelegate objProc;
        static public void CreateNchitTestWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试限制通知区域", 0, 0, 400, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnNchitTestButtonMsgProc);
                label = new ExStatic(skin, "鼠标只能在红色区域里响应", 50, 50, 300, 100, -1, OBJECT_STYLE_EX_FOCUSABLE, DT_CENTER | DT_VCENTER | DT_SINGLELINE, 0, default, objProc);


                skin.Visible = true;
            }
        }

        static private IntPtr OnNchitTestButtonMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_NCHITTEST)
            {
                var x = Util.GET_X_LPARAM(lParam);
                var y = Util.GET_Y_LPARAM(lParam);
                if ((x>=20 && x<=60 && y>=20 && y<=60) == false)
                {
                    return (IntPtr)HTTRANSPARENT;
                } 
            }
            else if(uMsg == WM_ERASEBKGND)//wParam画布句柄
            {
                var rc = label.Rect;
                var brush = new ExBrush(Util.ExRGB2ARGB(16746496, 255));
                var canvas = new ExCanvas((int)wParam);
                canvas.FillRect(brush, 0, 0, rc.nRight , rc.nBottom);
                brush.Color = Util.ExRGB2ARGB(255, 255);
                canvas.FillRect(brush, 20, 20, 60, 60);
                brush.Dispose();
                return (IntPtr)1;
            }
            else if(uMsg == WM_LBUTTONDOWN)
            {
                Console.WriteLine("被按下");
            }
            else if(uMsg == WM_LBUTTONUP)
            {
                Console.WriteLine("被放开");
            }
            return IntPtr.Zero;
        }
    }
}
