using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Windows.Forms;
using static ExDuiR.NET.Native.WinAPI;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class ModalWindow
    {
        static private ExSkin skin;
        static private ExButton button;
        static private ExObjEventProcDelegate objEventProc;
        static private ExSkin skinIndex;
        static private DlgWndProcDelegate dlgProc;

        static public void CreateModalWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试模态窗口", 0, 0, 400, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                objEventProc = new ExObjEventProcDelegate(OnButtonEventProc);
                dlgProc = new DlgWndProcDelegate(OnDialgWndProc);
                button = new ExButton(skin, "弹出模态对话框", 50, 50, 300, 100);
                button.HandleEvent(NM_CLICK, objEventProc);
                skin.Visible = true;
            }
        }

        static private bool OnDialgWndProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            if(uMsg == WM_INITDIALOG)
            {
                WinAPI.MoveWindow(hWnd, 0, 0, 300, 200, false);
                WinAPI.SetWindowText(hWnd, "我是模态对话框 我在的时候别的窗口不能动");
                skinIndex = new ExSkin(hWnd, WINDOW_STYLE_TITLE | WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_MOVEABLE | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_ESCEXIT | WINDOW_STYLE_CENTERWINDOW, IntPtr.Zero);
                if (skinIndex.Validate)
                {
                    var edit = new ExEdit(skinIndex, "", 20, 50, 250, 30, -1, -1, -1);
                    edit.SetBanner("编辑框输入文字正常", Util.ExRGB2ARGB(8421504, 200));
                    skinIndex.BackgroundColor = Util.ExRGB2ARGB(16711680, 220);
                    skinIndex.Visible = true;
                }
            }
            return false;
        }

        static private IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            DLGTEMPLATE dlg = new DLGTEMPLATE();
            dlg.dwExtendedStyle = 65792;
            dlg.x = 0;
            dlg.y = 0;
            dlg.cx = 200;
            dlg.cy = 200;
            dlg.style = -2067267516;
            dlg.cdit = 0;
            var ret = WinAPI.DialogBoxIndirectParam(WinAPI.GetModuleHandle(null), ref dlg, skin.Hwnd, dlgProc, 0);
            Console.WriteLine(ret);
            return IntPtr.Zero;
        }
    }
}
