using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks
{
    public class ExWindow
    {
        public static int RegisterClass(string sClassName)
        {
            return ExAPI.Ex_WndRegisterClass(sClassName, 0, 0, 0);
        }
        public static int RegisterClass(string sClassName, nint hIcon, nint hIconSmall, nint hCursor)
        {
            return ExAPI.Ex_WndRegisterClass(sClassName, hIcon, hIconSmall, hCursor);
        }

        public static nint Create(nint hWndParent, string sClassName, string sWindowName, int x, int y, int nWidth, int nHeight, int dwStyle = 0, int dwStyleEx = 0)
        {
            return ExAPI.Ex_WndCreate(hWndParent, sClassName, sWindowName, x, y, nWidth, nHeight, dwStyle, dwStyleEx);
        }

        public static void Center(nint hWnd,nint hWndFrom,bool fFullScreen = false)
        {
            ExAPI.Ex_WndCenterFrom(hWnd, hWndFrom, fFullScreen);
        }



        protected nint m_hWnd;
        public nint WindowHandle { get => m_hWnd; }
    }
}
