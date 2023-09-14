using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class RotateImageWindow
    {
        static private ExSkin skin;
        static private ExRotateImageBox imagebox;

        static public void CreateRotateImageWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试旋转图片框", 0, 0, 200, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                var bitmap = Properties.Resources.nav1;
                //加入OBJECT_STYLE_EX_FOCUSABLE风格鼠标移入停止旋转，不加入此风格一直旋转
                imagebox = new ExRotateImageBox(skin, bitmap, 50, 50, 100, 100, -1, OBJECT_STYLE_EX_FOCUSABLE);
                imagebox.SetRadius(30, 30, 30, 30, true);
                skin.Visible = true;
            }
        }
    }
}
