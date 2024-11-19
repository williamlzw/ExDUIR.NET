using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class LabelWindow
    {
        static private ExSkin skin;
        static private ExStatic label;
        static private ExStatic label2;
        static public void CreateLabelWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试标签", 0, 0, 200, 250,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                var bitmap = Properties.Resources.Loading;
                label = new ExStatic(skin, bitmap, 10, 30, 180, 150);
                label.SetRadius(10, 10, 15, 10, true);
                label.GetBackgroundImage(out ExBackgroundImageInfo bkgInfo);
                var rc = label.Rect;
                label2 = new ExStatic(skin, "标签可以填充动画,支持PNG,GIF,JPG,BMP格式,标签可以自动换行", 10, 190, 180, 90, DT_WORDBREAK);
                label2.SetFont("宋体", 14, FONT_STYLE_BOLD, false);
                label2.ColorTextNormal = Util.ExARGB(133, 33, 53, 255);

                Console.WriteLine(string.Format("标签矩形:{0},{1}", rc.nRight, rc.nBottom));
                Console.WriteLine(string.Format("背景信息:{0},{1},{2},{3},{4},{5},{6}", bkgInfo.nCurFrame, bkgInfo.x, bkgInfo.y, bkgInfo.nAlpha, bkgInfo.dwRepeat, bkgInfo.hImage, bkgInfo.nMaxFrame));
                
                skin.Visible = true;
            }
        }
    }
}
