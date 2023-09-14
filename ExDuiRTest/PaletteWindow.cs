using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class PaletteWindow
    {
        static private ExSkin skin;
        static private ExPalette palette;
        static private ExObjEventProcDelegate objProc;

        static public void CreatePaletteWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试调色板", 0, 0, 400, 250,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                palette = new ExPalette(skin, "", 50, 50, 300, 150);
                objProc = new ExObjEventProcDelegate(OnPaletteEvent);
                palette.HandleEvent(PALETTE_EVENT_MOUSEMOVE, objProc);
                skin.Visible = true;
            }
        }

        static public IntPtr OnPaletteEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == PALETTE_EVENT_MOUSEMOVE)
            {
                skin.BackgroundColor = Util.ExRGB2ARGB((int)wParam, 255);
            }
            return IntPtr.Zero;
        }
    }
}
