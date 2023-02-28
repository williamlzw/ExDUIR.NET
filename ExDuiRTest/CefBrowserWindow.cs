using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;


namespace ExDuiRTest
{
    public class CefBrowserWindow
    {
        static private ExSkin skin;
        static private ExWndProcDelegate wndProc;
        static private CefChromeBrowser browser;


        static public void CreateCefBrowserWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWndProc);
            skin = new ExSkin(pOwner, null, "测试浏览框", 0, 0, 800, 600,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_BUTTON_MAX | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_SIZEABLE | EWS_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                CefChromeBrowser.RegisterControl();
                browser = new CefChromeBrowser(skin, "", 30, 30, 700, 500);
                browser.Load("www.bing.com");
                skin.Visible = true;
            }
        }

        static private IntPtr OnWndProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr lpResult)
        {
            if(uMsg == WM_SIZE)
            {
                if(browser!=null)
                {
                    var dpi = Util.GetDpi();
                    browser.Move(50, 50, (int)(Util.LOWORD((uint)lParam)/dpi)-100, (int)(Util.HIWORD((uint)lParam) / dpi) - 100);
                }
            }
            return IntPtr.Zero;
        }

    }

}
