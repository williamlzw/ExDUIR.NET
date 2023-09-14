using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class CustomCtrlWindow
    {
        static private ExSkin skin;

        static public void CreateCustomCtrlWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试自定义组件", 0, 0, 200, 150,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                //注册自定义组件
                TestCustomCtrl.RegisterControl();
                //创建自定义组件
                TestCustomCtrl custom = new TestCustomCtrl(skin, "test", 50, 50, 50, 50);

                skin.Visible = true;
            }
        }
    }
}
