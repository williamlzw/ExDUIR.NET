using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using ExDuiR.NET.Frameworks.Graphics;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class SVGWindow
    {
        static private ExSkin skin;
        static private ExWndProcDelegate wndProc;
        static public void CreateSVGWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWndMsgProc);
            skin = new ExSkin(pOwner, null, "自定义字体和SVG测试", 0, 0, 800, 600,
            WINDOW_STYLE_MOVEABLE | WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_NOSHADOW | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_TITLE, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
 
                skin.Visible = true;
            }
        }

        static private IntPtr OnWndMsgProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_ERASEBKGND)
            {
                var canvas = new ExCanvas((int)wParam);
                canvas.Clear(Util.ExARGB(150, 150, 150, 255));
                var font = new ExFont("res/文道灵飞小楷.ttf", 64);
                canvas.DrawText(font, Util.ExARGB(200, 0, 200, 200), "我是测试文本", -1, -1, 20, 450, 450, 530);

                font.Dispose();
                ExSvg svg1 = new ExSvg("res/niu1.svg");
                canvas.DrawSvg(svg1.handle, 50, 50, 150, 150);
                var data = Properties.Resources.niu1;
                var ptr = Marshal.AllocHGlobal(data.Length);
                Marshal.Copy(data, 0, ptr, data.Length);
                ExSvg svg2 = new ExSvg(ptr);
                canvas.DrawSvg(svg2.handle, 250, 50, 150, 150);

                ExSvg svg3 = new ExSvg("res/niu.svg");
                canvas.DrawSvg(svg3.handle, 250, 250, 150, 200);
                svg1.Dispose();
                svg2.Dispose();
                svg3.Dispose();
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }
    }
}
