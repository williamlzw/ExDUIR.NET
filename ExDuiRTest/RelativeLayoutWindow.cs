using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class RelativeLayoutWindow
    {
        static private ExSkin skin;
        static private ExRelativateLayout layout;
        static private ExStatic label1;
        static private ExStatic label2;
        static private ExStatic label3;
        static private ExStatic label4;
        static private ExStatic label5;
        static private ExStatic label6;
        static public void CreateRelativeLayoutWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试相对布局", 0, 0, 600, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_BUTTON_MAX | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                layout = new ExRelativateLayout(skin);
                layout.PaddingLeft = 10;
                layout.PaddingTop = 25;
                layout.PaddingRight = 10;
                layout.PaddingBottom = 10;
 
                label1 = new ExStatic(skin, "控件A：父容器的左下角", 0, 0, 200, 150, DT_VCENTER);
                label1.ColorBackground = Util.ExARGB(255, 0, 0, 100);
                layout.SetLeftAlignOf(label1, -1);//左侧与父容器对齐
                layout.SetBottomAlignOf(label1, -1);//底边与父容器对齐

                label2 = new ExStatic(skin, "控件B：父容器居中顶部", 0, 0, 200, 150, DT_VCENTER);
                label2.ColorBackground = Util.ExRGB2ARGB(16711680, 100);
                layout.SetTopAlignOf(label2, -1);//顶部与父容器对齐
                layout.SetCenterParentHorizontal(label2, true);//水平居中于父容器

                label3 = new ExStatic(skin, "控件C：右侧与A对齐,宽度150,在A和B之间", 0, 0, 150, 150, DT_VCENTER);
                label3.ColorBackground = Util.ExRGB2ARGB(65280, 100);
                layout.SetTopOf(label3, label1);//在A控件顶部
                layout.SetBottomOf(label3, label2);//在B控件底部
                layout.SetRightAlignOf(label3, label1);//在B右侧对齐于A控件

                label4 = new ExStatic(skin, "控件D：高度100,在A和父控件右边界之间,在父容器底部", 0, 0, 150, 100, DT_VCENTER);
                label4.ColorBackground = Util.ExRGB2ARGB(16754943, 100);
                layout.SetRightOf(label4, label1);//在A控件右边
                layout.SetBottomAlignOf(label4, -1);//底部对齐于父容器
                layout.SetRightAlignOf(label4, -1);//右侧对齐于父容器

                label5 = new ExStatic(skin, "控件E：与D同宽,在D和B之间", 0, 0, 150, 100, DT_VCENTER);
                label5.ColorBackground = Util.ExRGB2ARGB(8445952, 100);
                layout.SetTopOf(label5, label4);//在D顶部
                layout.SetBottomOf(label5, label2);//在B底部
                layout.SetLeftAlignOf(label5, label4);//左侧对齐于D
                layout.SetRightAlignOf(label5, label4);//右侧对齐于D

                label6 = new ExStatic(skin, "控件F：150宽度,垂直方向对齐于DE,右对齐于DE", 0, 0, 150, 100, DT_VCENTER);
                label6.ColorBackground = Util.ExRGB2ARGB(16777215, 100);
                layout.SetTopAlignOf(label6, label5);//顶部对齐于E
                layout.SetBottomAlignOf(label6, label4);//底部对齐于D
                layout.SetRightAlignOf(label6, label4);//右对齐于D

                skin.SetLayout(layout);
                skin.Visible = true;
            }
        }
    }
}
