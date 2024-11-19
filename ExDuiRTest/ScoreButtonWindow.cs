using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using ExDuiR.NET.Frameworks.Graphics;

namespace ExDuiRTest
{
    static class ScoreButtonWindow
    {
        static private ExSkin skin;
        static private ExScoreButton scorebutton;
        static private ExObjEventProcDelegate objEvent;

        static public void CreateScoreButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试打分按钮", 0, 0, 300, 100,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                var img1 = new ExImage(Properties.Resources.star_normal);
                var img2 = new ExImage(Properties.Resources.star_hover);
                objEvent = new ExObjEventProcDelegate(OnScoreButtonCheckEvent);
                for (int i = 0; i < 5; i++)
                {
                    scorebutton = new ExScoreButton(skin, "", 20 + i * 45, 40, 40, 40);
                    scorebutton.SetImage(0, img1);
                    scorebutton.SetImage(1, img2);
                    scorebutton.LParam = (IntPtr)(i+1);
                    scorebutton.HandleEvent(NM_CHECK, objEvent);
                }
                skin.Visible = true;
            }
        }

        static public IntPtr OnScoreButtonCheckEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == NM_CHECK)
            {
                if(lParam != IntPtr.Zero)
                {
                    var obj = new ExControl(hObj);
                    var index = (int)obj.LParam;
                    Console.WriteLine($"选择分数:{index}");
                }
            }
            return IntPtr.Zero;
        }
    }
}
