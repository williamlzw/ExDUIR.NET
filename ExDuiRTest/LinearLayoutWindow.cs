using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class LinearLayoutWindow
    {
        static private ExSkin skin;
        static private ExLinearLayout layout;
        static private ExStatic label1;
        static private ExStatic label2;
        static private ExStatic label3;
        static public void CreateLinearLayoutWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试线性布局", 0, 0, 600, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_BUTTON_MAX | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                layout = new ExLinearLayout(skin);
                layout.Direction = LAYOUT_PROP_DIRECTION_H;//设置布局方向为水平
                layout.Dalign = LAYOUT_PROP_LINEAR_DALIGN_CENTER;//设置布局方向对齐方式为居中

                label1 = new ExStatic(skin, "容器1", 0, 0, 200, 300, -1);
                label1.ColorBackground = Util.ExRGB2ARGB(255, 100);
                layout.SetAlign(label1, LAYOUT_SUBPROP_LINEAR_ALIGN_CENTER);//设置居中于父
                layout.SetMarginRight(label1, 10);//设置右边10像素间隔

                label2 = new ExStatic(skin, "容器2", 0, 0, 400, 200, -1);
                label2.ColorBackground = Util.ExRGB2ARGB(16711680, 100);
                layout.SetAlign(label2, LAYOUT_SUBPROP_LINEAR_ALIGN_CENTER);//设置居中于父
                layout.SetMarginRight(label2, 10);//设置右边10像素间隔

                label3 = new ExStatic(skin, "容器3", 0, 0, 100, 100, -1);
                label3.ColorBackground = Util.ExRGB2ARGB(65280, 100);
                layout.SetAlign(label3, LAYOUT_SUBPROP_LINEAR_ALIGN_CENTER);//设置居中于父

                skin.SetLayout(layout);
                skin.Visible = true;
            }
        }
    }
}
