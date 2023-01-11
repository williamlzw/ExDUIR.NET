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
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_BUTTON_MAX | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_SIZEABLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                layout = new ExLinearLayout(skin);
                layout.Direction = ELP_DIRECTION_H;//设置布局方向为水平
                layout.Dalign = ELP_LINEAR_DALIGN_CENTER;//设置布局方向对齐方式为居中

                label1 = new ExStatic(skin, "容器1", 0, 0, 200, 300, -1);
                label1.SetColor(COLOR_EX_BACKGROUND, Util.ExRGB2ARGB(255, 100), true);
                layout.SetAlign(label1, ELCP_LINEAR_ALIGN_CENTER);//设置居中于父
                layout.SetMarginRight(label1, 10);//设置右边10像素间隔

                label2 = new ExStatic(skin, "容器2", 0, 0, 400, 200, -1);
                label2.SetColor(COLOR_EX_BACKGROUND, Util.ExRGB2ARGB(16711680, 100), true);
                layout.SetAlign(label2, ELCP_LINEAR_ALIGN_CENTER);//设置居中于父
                layout.SetMarginRight(label2, 10);//设置右边10像素间隔

                label3 = new ExStatic(skin, "容器3", 0, 0, 100, 100, -1);
                label3.SetColor(COLOR_EX_BACKGROUND, Util.ExRGB2ARGB(65280, 100), true);
                layout.SetAlign(label3, ELCP_LINEAR_ALIGN_CENTER);//设置居中于父

                skin.SetLayout(layout);
                skin.Visible = true;
            }
        }
    }
}
