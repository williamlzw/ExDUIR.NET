using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class GroupBoxWindow
    {
        static private ExSkin skin;
        static private ExGroupBox groupbox;

        static public void CreateGroupBoxWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试分组框", 0, 0, 400, 300,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                groupbox = new ExGroupBox(skin, "分组框", 30, 30, 230, 230);
                groupbox.ColorTextNormal = Util.ExRGBA(255, 255, 255, 255);
                groupbox.ColorBorder = Util.ExRGBA(55, 0, 250, 255);
                groupbox.TextOffset = 50;
                groupbox.Radius = 30;
                groupbox.StrokeWidth = 3;
                skin.Visible = true;
            }
        }
    }
}
