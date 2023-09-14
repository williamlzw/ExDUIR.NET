using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class LoadingWindow
    {
        static private ExSkin skin;
        static private ExMosaicLoading loading1;
        static private ExWin10Loading loading2;
        static private ExWin10Loading loading3;
        static public void CreateLoadingWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试加载动画", 0, 0, 300, 250,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                loading1 = new ExMosaicLoading(skin, "", 50, 50, 50, 50);
                loading1.ColorBackground = Util.ExRGB(255, 10, 10);//动画点颜色，只能提供RGB色

                loading2 = new ExWin10Loading(skin, "加载中，请稍后", 150, 30, 100, 80);
                loading3 = new ExWin10Loading(skin, "正在读取数据，请稍后", 50, 150, 200, 60, OBJECT_STYLE_VISIBLE | LOADING_STYLE_LINE);
                loading3.ColorBackground = Util.ExRGB(100, 236, 255);//动画点颜色，只能提供RGB色
                skin.Visible = true;
            }
        }
    }
}
