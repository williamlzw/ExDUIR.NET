using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class FlowLayoutWindow
    {
        static private ExSkin skin;
        static private ExFlowLayout layout;
        static private List<ExStatic> labels;
        static public void CreateFlowLayoutWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试流式布局", 0, 0, 600, 400,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_BUTTON_MAX | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_SIZEABLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                layout = new ExFlowLayout(skin);
                layout.Direction = ELP_DIRECTION_V;
                layout.PaddingLeft = 30;
                layout.PaddingTop = 30;
                layout.PaddingRight = 30;
                layout.PaddingBottom = 30;

                labels = new List<ExStatic>();
                Random rn = new Random();
                for(int i = 0; i < 20; i++)
                {
                    labels.Add(new ExStatic(skin, "test", 0, 0, rn.Next(50, 150), rn.Next(50, 150), -1));
                    labels[i].SetColor(COLOR_EX_BACKGROUND, Util.ExRGB2ARGB(255, 100), true);
                    layout.SetMarginRight(labels[i], 10);
                    layout.SetMarginBottom(labels[i], 10);
                    if(i % 10 == 0)
                    {
                        layout.SetNewLine(labels[i], true);
                    }
                }

                skin.SetLayout(layout);
                skin.Visible = true;
            }
        }
    }
}
