using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class MediaPlayWindow
    {
        static private ExSkin skin;
        static private ExMediaPlay mediaplay;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExButton button4;
        static private ExButton button5;
        static private ExObjEventProcDelegate buttonProc;

        static public void CreateMediaPlayWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试媒体播放器", 0, 0, 800, 600,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                button1 = new ExButton(skin, "播放", 50, 560, 100, 30);
                button2 = new ExButton(skin, "暂停", 160, 560, 100, 30);
                button3 = new ExButton(skin, "继续", 270, 560, 100, 30);
                button4 = new ExButton(skin, "停止", 380, 560, 100, 30);
                button5 = new ExButton(skin, "置位置", 490, 560, 100, 30);
                mediaplay = new ExMediaPlay(skin, "", 50, 50, 700, 500);
                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                button1.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_CLICK, buttonProc);
                button3.HandleEvent(NM_CLICK, buttonProc);
                button4.HandleEvent(NM_CLICK, buttonProc);
                button5.HandleEvent(NM_CLICK, buttonProc);
                skin.Visible = true;
            }
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(hObj == button1.handle)
            {
                mediaplay.StartPlay = "res/test.mp4";
            }
            else if(hObj == button2.handle)
            {
                mediaplay.PausePlay = true;
            }
            else if (hObj == button3.handle)
            {
                mediaplay.PausePlay = false;
            }
            else if (hObj == button4.handle)
            {
                mediaplay.StopPlay = true;
            }
            else if (hObj == button5.handle)
            {
                mediaplay.PlayPosition = 20;
            }
            return IntPtr.Zero;
        }
    }
}
