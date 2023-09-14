using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class ColorPickerWindow
    {
        static private ExSkin skin;
        static private ExColorPicker colorpicker;
        static private ExObjEventProcDelegate objEvent;

        static public void CreateColorPickerWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试颜色选择器", 0, 0, 250, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                colorpicker = new ExColorPicker(skin, "", 50, 50, 80, 30);
                colorpicker.ColorBackground = Util.ExRGB2ARGB(0, 255);
                objEvent = new ExObjEventProcDelegate(OnColorPickerButtonEvent);
                colorpicker.HandleEvent(COLORPICKER_EVENT_COLORCHANGE, objEvent);
                skin.Visible = true;
            }
        }

        static public IntPtr OnColorPickerButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == COLORPICKER_EVENT_COLORCHANGE)
            {
                Console.WriteLine($"颜色已更改:{lParam}");
            }
            return IntPtr.Zero;
        }
    }
}
