using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks
{
    public class ExWindow
    {
        public static int RegisterClass(string sClassName)
        {
            return ExAPI.Ex_WndRegisterClass(sClassName, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
        }
        public static int RegisterClass(string sClassName, IntPtr hIcon, IntPtr hIconSmall, IntPtr hCursor)
        {
            return ExAPI.Ex_WndRegisterClass(sClassName, hIcon, hIconSmall, hCursor);
        }

        public static IntPtr Create(IntPtr hWndParent, string sClassName, string sWindowName, int x, int y, int nWidth, int nHeight, int dwStyle = 0, int dwStyleEx = 0)
        {
            return ExAPI.Ex_WndCreate(hWndParent, sClassName, sWindowName, x, y, nWidth, nHeight, dwStyle, dwStyleEx);
        }

        public static void Center(IntPtr hWnd,IntPtr hWndFrom,bool fFullScreen = false)
        {
            ExAPI.Ex_WndCenterFrom(hWnd, hWndFrom, fFullScreen);
        }



        protected IntPtr m_hWnd;
        public IntPtr WindowHandle { get => m_hWnd; }
    }
}
