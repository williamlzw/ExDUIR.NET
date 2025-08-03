using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;
using ExDuiR.NET.Frameworks.Graphics;

namespace ExDuiRTest
{
    class WaveProgressBarWindow
    {
        static private ExSkin skin;
        static private ExWaveProgressBar waveprogressbar;

        static public void CreateWaveProgressBarWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试水波进度条", 0, 0, 600, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);

                waveprogressbar = new ExWaveProgressBar(skin, "", 20, 50, 560, 220);
                waveprogressbar.Pos = 40;
                waveprogressbar.WaveWidth = 210;
                waveprogressbar.WaveHeight = 30;
                waveprogressbar.LeftX = -210;
                waveprogressbar.ColorTextNormal = Util.ExRGB2ARGB(16777215, 255);
                waveprogressbar.BackgroundColor = Util.ExARGB(230, 231, 232, 255);
                waveprogressbar.ForegroundColor = Util.ExARGB(30, 159, 255, 200);
                waveprogressbar.Font = new ExFont("MicroSoft Yahei", 30, 0);
                waveprogressbar.SetRadius(10, 10, 10, 10, false);
                waveprogressbar.Timer = 100;

                skin.Visible = true;
            }
        }
    }
}

