using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class TableLayoutWindow
    {
        static private ExSkin skin;
        static private ExTableLayout layout;

        static public void CreateTableLayoutWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试表格布局", 0, 0, 400, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_BUTTON_MAX | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                layout = new ExTableLayout(skin);
                layout.PaddingLeft = 10;
                layout.PaddingTop = 30;
                layout.PaddingRight = 10;
                layout.PaddingBottom = 10;
                layout.SetInfo(new int[] { 50, -30, 75, -20 }, 4, new int[] { 100, 75, -50 }, 3);
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        var label = new ExStatic(skin, i.ToString() + "行," + j.ToString() + "列", 0, 0, 200, 150, -1);
                        label.ColorBackground = Util.ExRGB2ARGB(255, 100);
                        layout.SetRow(label, i);
                        layout.SetCell(label, j);
                    }
                }
                var label2 = new ExStatic(skin, "(2,1)[占2行]", 0, 0, 200, 150, -1);
                label2.ColorBackground = Util.ExRGB2ARGB(65535, 150);
                layout.SetCell(label2, 2);
                layout.SetRow(label2, 1);
                layout.SetRowSpan(label2, 2);//设置跨行数

                var label3 = new ExStatic(skin, "(1,3)[占3列2行]", 0, 0, 200, 150, -1);
                label3.ColorBackground = Util.ExRGB2ARGB(16711935, 150);
                layout.SetCell(label3, 1);
                layout.SetRow(label3, 3);
                layout.SetRowSpan(label3, 2);//设置跨行数
                layout.SetCellSpan(label3, 3);//设置跨列数

                skin.SetLayout(layout);
                skin.Visible = true;
            }
        }
    }
}
