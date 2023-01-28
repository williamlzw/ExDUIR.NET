﻿using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Windows.Forms;

namespace ExDuiRTest
{
    static class MBBrowserWindow
    {
        static private ExSkin skin;
        static private ExMiniblinkBrowser mbbrowser;
        static private ExButton button;
        static private ExObjEventProcDelegate buttonProc;
        static private ExWndProcDelegate wndProc;

        static public void CreateMBBrowserWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWndMsgProc);
            skin = new ExSkin(pOwner, null, "测试miniblink浏览框", 0, 0, 800, 600,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                ExMiniblinkBrowser.Initialize("", "miniblink_4975_x32.dll");
                mbbrowser = new ExMiniblinkBrowser(skin, "", 50, 50, 700, 500);
                mbbrowser.LoadUrl = "file:///J:/ExduiR/msvc/test/res/MP4.html";//注意,本地路径带#符号不支持

                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                button = new ExButton(skin, "播放", 50, 550, 100, 30);
                button.HandleEvent(NM_CLICK, buttonProc);
                skin.Visible = true;
            }
        }

        static public IntPtr OnWndMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_SIZE)
            {
                if(mbbrowser != null)
                {
                    var width = Util.GET_X_LPARAM(lParam) - 100;
                    var height = Util.GET_Y_LPARAM(lParam) - 100;
                    mbbrowser.Move(50, 50, width, height);
                }
            }
            return IntPtr.Zero;
        }
        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            mbbrowser.RunJS = "https://media.w3.org/2010/05/sintel/trailer.mp4";
            return IntPtr.Zero;
        }
    }
}
