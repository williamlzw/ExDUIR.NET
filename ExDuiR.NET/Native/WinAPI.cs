using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ExDuiR.NET.Native
{
    public class WinAPI
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct LogFont
        {
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string lfFaceName;
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "GetModuleHandleW")]
        public static extern IntPtr GetModuleHandle(string wzModule);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "IsWindow")]
        public static extern bool IsWindow(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "IsWindowVisible")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "IsWindowEnabled")]
        public static extern bool IsWindowEnabled(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "EnableWindow")]
        public static extern bool EnableWindow(IntPtr hWnd,bool fEnable);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "MoveWindow")]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool fRedraw);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "PostMessageW")]
        public static extern bool PostMessage(IntPtr hWnd, int uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "SetWindowPos")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int nWidth, int nHeight, int dwFlags);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "SetWindowTextW")]
        public static extern bool SetWindowText(IntPtr hWnd, string sText);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "GetWindowTextW")]
        public static extern bool GetWindowText(IntPtr hWnd, StringBuilder sText, int cchText);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "GetWindowTextLengthW")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

    }
}
