using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class CustomBackgroundWindow
    {
        static private ExSkin skin;
        static private ExSysButton sysbutton;

        static public void CreateCustomBackgroundWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "", 0, 0, 175, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_MOVEABLE | WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                var bitmap = Properties.Resources.custombkg;
                ExRect rc = new ExRect
                {
                    nLeft = 45,
                    nTop = 40,
                    nRight = 15,
                    nBottom = 15
                };
                skin.SetBackgroundImage(bitmap, 0, 0, BACKGROUND_REPEAT_ZOOM, rc, BACKGROUND_FLAG_DEFAULT, 220, true);

                sysbutton = new ExSysButton(skin, "", 140, 8, 30, 30, OBJECT_STYLE_VISIBLE | WINDOW_STYLE_BUTTON_CLOSE, OBJECT_STYLE_EX_TOPMOST);
                skin.Visible = true;
            }
        }
    }
}
