using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class ButtonExWindow
    {
        static private ExSkin skin;
        static private ExButtonEx button1;
        static private ExButtonEx button2;
        static private ExButtonEx button3;
        static private ExButtonEx button4;
        static private ExButtonEx button5;
        static private ExButtonEx button6;
        static private ExButtonEx button7;
        static private ExButtonEx button8;
        static private ExButtonEx button9;
        static private ExButtonEx button10;

        static public void CreateButtonExWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试扩展", 0, 0, 300, 300,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                button1 = new ExButtonEx(skin, "☏直角纯色按钮", 50, 50, 100, 30);
                ExObjProps props1 = new ExObjProps
                {
                    crBkgNormal = Util.ExRGBA(76, 175, 80, 225),
                    crBkgHover = Util.ExRGBA(76, 175, 80, 250),
                    crBkgDownOrChecked = Util.ExRGBA(76, 175, 80, 200)
                };
                button1.Props = props1;

                button2 = new ExButtonEx(skin, "点击进入 👉", 50, 100, 100, 30);
                ExObjProps props2 = new ExObjProps
                {
                    crBkgNormal = Util.ExRGB2ARGB(7037666, 255),
                    crBkgHover = Util.ExRGB2ARGB(6182117, 255),
                    crBkgDownOrChecked = Util.ExRGB2ARGB(4865258, 255),
                    radius = 15
                };
                button2.Props = props2;

                button3 = new ExButtonEx(skin, "Metro按钮☪", 50, 150, 100, 30);
                ExObjProps props3 = new ExObjProps
                {
                    crBkgNormal = Util.ExRGBA(130, 130, 130, 255),
                    crBkgHover = Util.ExRGBA(130, 130, 130, 235),
                    crBkgDownOrChecked = Util.ExRGBA(200, 200, 200, 100),
                    crBorderNormal = Util.ExRGBA(130, 130, 130, 255),
                    crBorderHover = Util.ExRGBA(0, 0, 0, 135),
                    crBorderDownOrChecked = Util.ExRGBA(0, 0, 0, 150),
                    strokeWidth = 2
                };
                button3.Props = props3;

                button4 = new ExButtonEx(skin, "图标在左", 50, 200, 100, 30);
                ExObjProps props4 = new ExObjProps
                {
                    crBkgNormal = Util.ExRGB2ARGB(10066176, 255),
                    crBkgHover = Util.ExRGB2ARGB(10066176, 220),
                    crBkgDownOrChecked = Util.ExRGB2ARGB(10066176, 200),
                    crBorderNormal = Util.ExRGBA(130, 130, 130, 255)
                };
                button4.Props = props4;
                button4.SetFont("楷体", 16);
                ExImage img = new ExImage(Properties.Resources.connect);
                button4.Icon = img;

                button5 = new ExButtonEx(skin, "", 50, 250, 100, 30);
                var buttonnormal = new ExImage(Properties.Resources.buttonnormal);
                var buttonhover = new ExImage(Properties.Resources.buttonhover);
                var buttondown = new ExImage(Properties.Resources.buttondown);
                ExImageInfo info = new ExImageInfo
                {
                    imgNormal = (IntPtr)buttonnormal.handle,
                    imgHover = (IntPtr)buttonhover.handle,
                    imgDownOrChecked = (IntPtr)buttondown.handle
                };
                button5.ImageInfo = info;

                button6 = new ExButtonEx(skin, "背景按钮", 180, 50, 100, 30);
                button6.ColorTextNormal = Util.ExRGB2ARGB(65535, 180);
                button6.ColorTextHover = Util.ExRGB2ARGB(65535, 255);
                button6.ColorTextDown = Util.ExRGB2ARGB(65535, 255);
                var buttonnormal2 = new ExImage(Properties.Resources.button2normal);
                var buttonhover2 = new ExImage(Properties.Resources.button2hover);
                var buttondown2 = new ExImage(Properties.Resources.button2down);
                ExImageInfo info2 = new ExImageInfo
                {
                    imgNormal = (IntPtr)buttonnormal2.handle,
                    imgHover = (IntPtr)buttonhover2.handle,
                    imgDownOrChecked = (IntPtr)buttondown2.handle
                };
                button6.ImageInfo = info2;

                button7 = new ExButtonEx(skin, "渐变按钮🔊", 180, 100, 100, 30);
                ExObjProps props7 = new ExObjProps
                {
                    crBkgBegin = Util.ExRGBA(0, 173, 241, 255),
                    crBkgEnd = Util.ExRGBA(100, 25, 129, 255),
                    strokeWidth = 2
                };
                button7.Props = props7;
                button7.SetFont("楷体", 16);

                button8 = new ExButtonEx(skin, "线框按钮", 180, 150, 100, 30);
                ExObjProps props8 = new ExObjProps
                {
                    crBorderBegin = Util.ExRGBA(227, 34, 103, 255),
                    crBorderEnd = Util.ExRGB2ARGB(16746496, 255),
                    strokeWidth = 2
                };
                button8.Props = props8;
                button8.SetFont("楷体", 16);
                button8.ColorTextNormal = Util.ExRGB2ARGB(65535, 180);
                button8.ColorTextHover = Util.ExRGB2ARGB(65535, 255);
                button8.ColorTextDown = Util.ExRGB2ARGB(65535, 255);

                button9 = new ExButtonEx(skin, "图标在上", 180, 200, 100, 40);
                ExObjProps props9 = new ExObjProps
                {
                    crBkgBegin = Util.ExRGB2ARGB(10061616, 255),
                    crBkgEnd = Util.ExRGB2ARGB(10061616, 220),
                    crBkgDownOrChecked = Util.ExRGB2ARGB(10061616, 200),
                    nIconPosition = 2
                };
                button9.Props = props9;
                button9.SetFont("楷体", 16);
                var icon = new ExImage(Properties.Resources.icon);
                button9.Icon = icon;

                button10 = new ExButtonEx(skin, "图标在右", 180, 250, 100, 30);
                ExObjProps props10 = new ExObjProps
                {
                    crBkgNormal = Util.ExRGBA(255, 255, 255, 50),
                    crBkgHover = Util.ExRGBA(255, 255, 255, 80),
                    crBkgDownOrChecked = Util.ExRGBA(255, 255, 255, 100),
                    crBorderNormal = Util.ExRGBA(0, 0, 0, 150),
                    crBorderHover = Util.ExRGBA(0, 0, 0, 180),
                    crBorderDownOrChecked = Util.ExRGBA(0, 0, 0, 200),
                    strokeWidth = 1,
                    nIconPosition = 1,
                    radius = 7
                };
                button10.Props = props10;
                button10.SetFont("楷体", 16);
                var icon2 = new ExImage(Properties.Resources.icon2);
                button10.Icon = icon2;

                skin.Visible = true;
            }
        }
    }
}
