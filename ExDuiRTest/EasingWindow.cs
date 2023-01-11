using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class EasingWindow
    {
        static private ExSkin skin;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExButton button4;
        static private ExEasing easing;

        static private ExObjEventProcDelegate buttonProc;
        static private ExWndProcDelegate wndProc;

        static public void CreateEasingWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWinMsgProc);
            skin = new ExSkin(pOwner, null, "测试缓动窗口", 0, 0, 400, 300,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW, 0, 0, IntPtr.Zero, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                button1 = new ExButton(skin, "点击动一次", 10, 40, 120, 50, -1);
                button2 = new ExButton(skin, "来回", 10, 100, 120, 50, -1);
                button3 = new ExButton(skin, "点击动/停", 10, 160, 120, 50, -1);
                button4 = new ExButton(skin, "点击窗口动", 10, 220, 120, 50, -1);
                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);

                easing = new ExEasing(ET_InOutCirc, IntPtr.Zero, ES_CYCLE | ES_BACKANDFORTH | ES_THREAD | ES_DISPATCHNOTIFY, (IntPtr)(button3.handle), 200, 20, EES_PAUSE, 150, 300);
                button1.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_EASING, buttonProc);
                button3.HandleEvent(NM_CLICK, buttonProc);
                button3.HandleEvent(NM_EASING, buttonProc);
                button3.HandleEvent(NM_DESTROY, buttonProc);
                button4.HandleEvent(NM_CLICK, buttonProc);
                AniShow(true);
            }
        }

        static private void AniShow(bool show)
        {
            int alpha = 255;
            var mode = ES_REVERSE;
            if (show)
            {
                alpha = 0;
                mode = 0;
            }
            skin.BackgroundColor = Util.ExRGBA(150, 150, 150, alpha);
            skin.Alpha = alpha;
            skin.Visible = true;
            var rc = skin.WindowRect;
            var easing0 = new ExEasing(ET_InOutQuint, IntPtr.Zero, ES_SINGLE | ES_CALLFUNCTION | mode, OnAniEasing, 500, 20, EES_PLAY, 0, 1, (IntPtr)rc.nLeft, IntPtr.Zero, (IntPtr)(rc.nTop - 100), (IntPtr)100);
            if (show)
            {
                skin.Visible = true;
            }
            else
            {
                skin.Visible = false;
            }
        }

        static private IntPtr OnAniEasing(IntPtr pEasing, double nProgress, double nCurrent, IntPtr pContext, int nTimeSurplus, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4)
        {
            int index = (int)(nCurrent * 255);
            skin.BackgroundColor = Util.ExRGBA(150, 150, 150, index);
            skin.Alpha = index;
            skin.SetPos((int)((int)param1 + (int)param2 * nCurrent), (int)((int)param3 + (int)param4 * nCurrent), 0, 0, IntPtr.Zero, SWP_NOSIZE | SWP_NOACTIVATE | SWP_NOZORDER);
            return IntPtr.Zero;
        }

        static private IntPtr OnButtonEasing(IntPtr pEasing, double nProgress, double nCurrent, IntPtr pContext, int nTimeSurplus, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4)
        {
            button1.SetPos(0, 0, (int)nCurrent, 50, IntPtr.Zero, SWP_NOMOVE | SWP_NOZORDER);
            return IntPtr.Zero;
        }

        static private IntPtr OnButtonEasing4(IntPtr pEasing, double nProgress, double nCurrent, IntPtr pContext, int nTimeSurplus, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4)
        {
            var rc = skin.WindowRect;
            skin.Move(rc.nLeft, rc.nTop, (int)nCurrent, rc.nBottom - rc.nTop, true);
            return IntPtr.Zero;
        }

        static private IntPtr OnWinMsgProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_CLOSE)
            {
                AniShow(false);
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (hObj == button1.handle)
            {
                if (nCode == NM_CLICK)
                {
                    var easing1 = new ExEasing(ET_InOutCubic, IntPtr.Zero, ES_SINGLE | ES_THREAD | ES_CALLFUNCTION, OnButtonEasing, 200, 20, EES_PLAY, 150, 300, (IntPtr)hObj);
                }
            }
            else if (hObj == button2.handle)
            {
                if (nCode == NM_CLICK)
                {
                    var easing2 = new ExEasing(ET_InOutCubic, IntPtr.Zero, Util.MAKELONG(ES_MANYTIMES | ES_BACKANDFORTH | ES_THREAD | ES_DISPATCHNOTIFY, 10 * 2), (IntPtr)hObj, 150, 20, EES_PLAY, 150, 300);
                }
                else if (nCode == NM_EASING)
                {
                    var info = Util.IntPtrToStructure<ExEasingInfo>(lParam);
                    button2.SetPos(0, 0, (int)info.nCurrent, 50, IntPtr.Zero, SWP_NOMOVE | SWP_NOZORDER);
                }
            }
            else if (hObj == button3.handle)
            {
                if (nCode == NM_CLICK)
                {
                    if (easing.State == EES_PAUSE)
                    {
                        easing.State = EES_PLAY;
                    }
                    else
                    {
                        easing.State = EES_PAUSE;
                    }
                }
                else if (nCode == NM_DESTROY)
                {
                    easing.State = EES_STOP;
                }
                else if (nCode == NM_EASING)
                {
                    var info = Util.IntPtrToStructure<ExEasingInfo>(lParam);
                    button3.SetPos(0, 0, (int)info.nCurrent, 50, IntPtr.Zero, SWP_NOMOVE | SWP_NOZORDER);
                }
            }
            else if (hObj == button4.handle)
            {
                if (nCode == NM_CLICK)
                {
                    var easing4 = new ExEasing(ET_InOutCubic, IntPtr.Zero, Util.MAKELONG(ES_MANYTIMES | ES_BACKANDFORTH | ES_CALLFUNCTION, 4), OnButtonEasing4, 400, 25, EES_PLAY, 400, 150);
                }
            }
            return IntPtr.Zero;
        }
    }
}
