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
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                colorpicker = new ExColorPicker(skin, "", 50, 50, 80, 30);
                colorpicker.ColorBackground = Util.ExRGB2ARGB(0, 255);
                objEvent = new ExObjEventProcDelegate(OnColorPickerButtonEvent);
                colorpicker.HandleEvent(CPN_COLORCHANGE, objEvent);
                skin.Visible = true;
            }
        }

        static public IntPtr OnColorPickerButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == CPN_COLORCHANGE)
            {
                Console.WriteLine($"颜色已更改:{lParam}");
            }
            return IntPtr.Zero;
        }
    }
}
