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
        public static extern nint GetModuleHandle(string wzModule);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "IsWindow")]
        public static extern bool IsWindow(nint hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "IsWindowVisible")]
        public static extern bool IsWindowVisible(nint hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "IsWindowEnable")]
        public static extern bool IsWindowEnable(nint hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "EnableWindow")]
        public static extern bool EnableWindow(nint hWnd,bool fEnable);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "MoveWindow")]
        public static extern bool MoveWindow(nint hWnd, int x, int y, int nWidth, int nHeight, bool fRedraw);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "SendMessageW")]
        public static extern nint SendMessage(nint hWnd, int uMsg, nint wParam, nint lParam);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "PostMessageW")]
        public static extern bool PostMessage(nint hWnd, int uMsg, nint wParam, nint lParam);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "SetWindowPos")]
        public static extern bool SetWindowPos(nint hWnd, nint hWndInsertAfter, int x, int y, int nWidth, int nHeight, int dwFlags);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "SetWindowTextW")]
        public static extern bool SetWindowText(nint hWnd, string sText);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "GetWindowTextW")]
        public static extern bool GetWindowText(nint hWnd, StringBuilder sText, int cchText);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "GetWindowTextLengthW")]
        public static extern int GetWindowTextLength(nint hWnd);

    }
}
