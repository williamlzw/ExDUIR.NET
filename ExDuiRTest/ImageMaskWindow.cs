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
    static class ImageMaskWindow
    {
        static private ExSkin skin;
        static private ExStatic label;
        static private ExObjProcDelegate objProc;

        static public void CreateImageMaskWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试蒙板", 0, 0, 300, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGB2ARGB(16711680, 255);
                objProc = new ExObjProcDelegate(OnLabelMsgProc);
                label = new ExStatic(skin, "", 50, 50, 200, 200, -1, -1, -1, 0, IntPtr.Zero, objProc);
                skin.Visible = true;
            }
        }

        static public IntPtr OnLabelMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_ERASEBKGND)
            {
                var data1 = Properties.Resources.mask4;
                var image1 = new ExImage(data1);
                var data2 = Properties.Resources.mask1;
                var image2 = new ExImage(data2);

                image1.Mask(image2, 0, false, out var image3);
                var canvas = new ExCanvas((int)wParam);
                canvas.DrawImageRect(image3, 0, 0, 200, 200, 255);
                Marshal.WriteInt32(pResult, 1);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }
    }
}
