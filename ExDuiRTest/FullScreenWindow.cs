using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class FullScreenWindow
    {
        static private ExSkin skin;
        static private ExWndProcDelegate wndProc;

        static public void CreateFullScreenWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnFullScreenWndMsgProc);
            skin = new ExSkin(pOwner, null, "测试全屏,最大化,置顶,不可移动改变大小,只能右上角关闭", 0, 0, 200, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_MOVEABLE | WINDOW_STYLE_TITLE | WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_FULLSCREEN | WINDOW_STYLE_NOSHADOW | WINDOW_STYLE_BUTTON_CLOSE, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                //最大化
                WinAPI.PostMessage(skin.Hwnd, 274, (IntPtr)61488, IntPtr.Zero);
                //置顶
                WinAPI.SetWindowPos(skin.Hwnd, (IntPtr)(-1), 0, 0, 0, 0, 3);
                skin.Visible = true;
            }
        }

        static private IntPtr OnFullScreenWndMsgProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_NCLBUTTONDBLCLK)
            {
                // 禁用标题栏双击最大化消息
                return (IntPtr)1;
            }
            else if(uMsg == WM_NCLBUTTONDOWN)
            {
                // 禁用标题栏鼠标按下拖动消息
                if ((int)wParam == HTCAPTION)
                {
                    return (IntPtr)1;
                }
            }
            return IntPtr.Zero;
        }
    }
}
