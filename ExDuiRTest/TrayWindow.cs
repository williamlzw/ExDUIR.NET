using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class TrayWindow
    {
        static private ExSkin skin;
        static private ExButton button;
        static private ExStatic label;
        static private ExWndProcDelegate wndProc;
        static private ExObjEventProcDelegate buttonProc;
        static public void CreateTrayWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWndMsgProc); 
            skin = new ExSkin(pOwner, null, "测试托盘", 0, 0, 250, 150,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                button = new ExButton(skin, "设置托盘", 50, 30, 120, 30);
                button.HandleEvent(NM_CLICK, buttonProc);
                label = new ExStatic(skin, "右击托盘图标可以弹出托盘", 10, 70, 200, 30, -1);

                skin.Visible = true;
            }
        }

        static public IntPtr OnWndMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_NOTIFY)
            {
                var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                if(ni.nCode == NM_TRAYICON)
                {
                    var type = (Int16)Util.LOWORD((uint)ni.lParam);
                    if(type == WM_RBUTTONDOWN)//右键按下托盘图标
                    {
                        skin.PopupTrayIcon("弹出托盘内容", "弹出托盘标题", NIIF_INFO);
                    }
                }
            }
            return IntPtr.Zero;
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            skin.SetTrayIcon(Properties.Resources.icon1, "ExDuiR");
            return IntPtr.Zero;
        }
    }
}
