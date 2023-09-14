using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;

using System;

namespace ExDuiRTest
{
    static class AbsoluteLayoutWindow
    {
        static private ExSkin skin;
        static private ExAbsoluteLayout layout;
        static private ExStatic label1;
        static private ExStatic label2;
        static private ExStatic label3;
        static private ExStatic label4;

        static public void CreateAbsoluteLayoutWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试绝对布局", 0, 0, 450, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_BUTTON_MAX | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                layout = new ExAbsoluteLayout(skin);
                label1 = new ExStatic(skin, "固定在右下角50,50的位置，不变大小", 0, 0, 200, 100, DT_CENTER | DT_VCENTER);
                label1.ColorBackground = Util.ExRGB2ARGB(255, 100);
                layout.SetRightPX(label1, 50);//设置距离右边为50像素
                layout.SetBottomPX(label1, 50);//设置距离底边为50像素

                label2 = new ExStatic(skin, "固定在左下角50,50的位置，宽度为40%,高度为50", 0, 0, 200, 100, DT_CENTER | DT_VCENTER);
                label2.ColorBackground = Util.ExRGB2ARGB(0, 100);
                layout.SetLeftPX(label2, 50);//设置距离左边为50像素
                layout.SetBottomPX(label2, 50);//设置距离底边为50像素
                layout.SetWidthPS(label2, 40);//设置宽度40%, 注意单位是PS（百分比）
                layout.SetHeightPS(label2, 50);//设置高度50%

                label3 = new ExStatic(skin, "距离四边均为20%", 0, 0, 200, 100, DT_CENTER | DT_VCENTER);
                label3.ColorBackground = Util.ExRGB2ARGB(16711680, 100);
                layout.SetLeftPS(label3, 20);//设置左边20%
                layout.SetTopPS(label3, 20);//设置顶边20%
                layout.SetRightPS(label3, 20);//设置顶边20%
                layout.SetBottomPS(label3, 20);//设置顶边20%

                label4 = new ExStatic(skin, "居中于窗口,宽度为窗口的30%,高度为100像素", 0, 0, 200, 100, DT_CENTER | DT_TOP);
                label4.ColorBackground = Util.ExRGB2ARGB(65280, 100);
                layout.SetLeftPS(label4, 50);//设置左边50%
                layout.SetTopPS(label4, 50);//设置顶边50%
                layout.SetWidthPS(label4, 30);//设置宽度30%
                layout.SetHeightPX(label4, 100);//设置高度100像素
                layout.SetHorizontalOffsetPS(label4, -50);// 水平偏移控件 - 50 % 的控件宽度 注意单位是OBJ_PS（控件尺寸的百分比）
                layout.SetVerticalOffsetPS(label4, -50);//水平偏移控件-50%的控件高度 注意单位是OBJ_PS（控件尺寸的百分比）

                skin.SetLayout(layout);
                skin.Visible = true;
            }
        }
    }
}
