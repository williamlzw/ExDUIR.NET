using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class TitleBarWindow
    {
        static private ExSkin skin;
        static private ExTitleBar titlebar1;
        static private ExTitleBar titlebar2;
        static private ExTitleBar titlebar3;
        static private ExTitleBar titlebar4;

        static public void CreateTitleBarWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试标题框", 0, 0, 400, 200,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                titlebar1 = new ExTitleBar(skin, "标题框1", 30, 50, 300, 20);
                titlebar1.ColorBackground = -1;
                titlebar1.ColorTextNormal = Util.ExRGB2ARGB(0, 255);
                titlebar2 = new ExTitleBar(skin, "标题框2", 30, 80, 300, 20);
                titlebar2.ColorBackground = Util.ExRGB2ARGB(16711680, 255);
                titlebar2.ColorTextNormal = Util.ExRGB2ARGB(255, 255);
                titlebar3 = new ExTitleBar(skin, "标题框3", 30, 110, 300, 20);
                titlebar3.ColorBackground = Util.ExRGB2ARGB(255, 255);
                titlebar3.ColorTextNormal = Util.ExRGB2ARGB(16711680, 255);
                titlebar4 = new ExTitleBar(skin, "标题框4", 30, 140, 300, 20);
                titlebar4.ColorBackground = Util.ExRGB2ARGB(0, 255);
                titlebar4.ColorTextNormal = -1;
                skin.Visible = true;
            }
        }
    }
}
