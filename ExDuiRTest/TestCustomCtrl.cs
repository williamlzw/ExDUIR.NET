using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Drawing;
using CefSharp;
using CefSharp.OffScreen;
using System.Runtime.InteropServices;
using ExDuiR.NET.Frameworks.Utility;
using CefSharp.Structs;
using System.Security.Policy;
using Newtonsoft.Json;
using System.Linq;
using System.Text;

namespace ExDuiRTest
{
    /// <summary>
    /// 扩展组件演示,继承自ExControl
    /// </summary>
    public class TestCustomCtrl : ExControl
    {
        private static ExObjClassProcDelegate s_pfnObjClassProc = new ExObjClassProcDelegate(
            (IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData) =>
        {
            ExControl Obj = new ExControl(hObj);
            switch (uMsg)
            {
                case WM_PAINT:
                    {
                        //开始绘制与EndPaint配套调用
                        Obj.BeginPaint(out var ps);
                        ExCanvas canvas = new ExCanvas(ps.hCanvas);
                        canvas.Clear(Color.Yellow.ToArgb());
                        //结束绘制
                        Obj.EndPaint(ref ps);
                        break;
                    }
                default:
                    break;
            }
            //组件默认回调
            return CallDefProc(hWnd, hObj, uMsg, wParam, lParam);
        });

        public static int RegisterControl()
        {
            return ExAPI.Ex_ObjRegister("TestCustomCtrl", EOS_VISIBLE, EOS_EX_FOCUSABLE, 0, 0, IntPtr.Zero, 0, s_pfnObjClassProc);
        }

        public TestCustomCtrl(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight)
           : base(pOwner, "TestCustomCtrl", sText, x, y, nWidth, nHeight)
        {

        }
        public new string ClassName => "TestCustomCtrl";
    }

    public class CefChromeBrowser : ExControl
    {
        private static ExObjClassProcDelegate s_pfnObjClassProc = new ExObjClassProcDelegate(
            (IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData) =>
            {
                ExControl Obj = new ExControl(hObj);
                if (uMsg == WM_CREATE)
                {

                }
                else if (uMsg == WM_DESTROY)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        if(Obj.UserData != IntPtr.Zero)
                        {
                            var img = new ExImage((int)Obj.UserData);
                            img.Dispose();
                        }
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        extend.Dispose();
                        gcHandle.Free();
                        Obj.LParam = IntPtr.Zero;
                    }
                }
                else if (uMsg == WM_PAINT)
                {
                    //开始绘制与EndPaint配套调用
                    Obj.BeginPaint(out var ps);
                    ExCanvas canvas = new ExCanvas(ps.hCanvas);
                    if (Obj.UserData != IntPtr.Zero)
                    {
                        var img = new ExImage((int)Obj.UserData);
                        canvas.DrawImageRect(img, ps.rcPaint.nLeft, ps.rcPaint.nTop, ps.rcPaint.nRight, ps.rcPaint.nBottom, 255);
                        img.Dispose();
                        Obj.UserData = IntPtr.Zero;
                    }
                    //结束绘制
                    Obj.EndPaint(ref ps);
                }
                else if (uMsg >= WM_MOUSEMOVE && uMsg <= WM_MBUTTONDBLCLK)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        var eventa = new MouseEvent(Util.LOWORD((uint)lParam), Util.HIWORD((uint)lParam), GetMouseEventFlags((int)wParam));
                        if (uMsg == WM_MOUSEMOVE)
                        {
                            host.SendMouseMoveEvent(eventa, false);
                        }
                        else
                        {
                            if (uMsg == WM_LBUTTONDOWN)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Left, false, 1);
                            }
                            else if (uMsg == WM_LBUTTONUP)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Left, true, 1);
                            }
                            else if (uMsg == WM_LBUTTONDBLCLK)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Left, false, 2);
                            }
                            if (uMsg == WM_RBUTTONDOWN)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Right, false, 1);
                            }
                            else if (uMsg == WM_RBUTTONUP)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Right, true, 1);
                            }
                            else if (uMsg == WM_RBUTTONDBLCLK)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Right, false, 2);
                            }
                            if (uMsg == WM_MBUTTONDOWN)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Middle, false, 1);
                            }
                            else if (uMsg == WM_MBUTTONUP)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Middle, true, 1);
                            }
                            else if (uMsg == WM_MBUTTONDBLCLK)
                            {
                                host.SendMouseClickEvent(eventa, MouseButtonType.Middle, false, 2);
                            }
                        }

                    }
                }
                else if (uMsg == WM_SIZE)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        extend.Size = new System.Drawing.Size(Util.LOWORD((uint)lParam), Util.HIWORD((uint)lParam));
                        host.WasResized();
                    }
                }
                else if (uMsg == WM_SETFOCUS)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();

                        host.SendFocusEvent(true);
                    }
                }
                else if (uMsg == WM_KILLFOCUS)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        host.SendFocusEvent(false);
                    }
                }
                else if (uMsg == WM_MOUSEWHEEL)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        int delta = (short)((long)wParam >> 16);
                        var eventb = new MouseEvent(Util.LOWORD((uint)lParam), Util.HIWORD((uint)lParam), CefEventFlags.None);
                        host.SendMouseWheelEvent(eventb, IsKeyDown(VK_SHIFT) ? delta : 0, IsKeyDown(VK_SHIFT) ? 0 : delta);
                    }
                }
                else if (uMsg == WM_KEYDOWN || uMsg == WM_SYSKEYDOWN || uMsg == WM_KEYUP || uMsg == WM_SYSKEYUP || uMsg == WM_CHAR || uMsg == WM_SYSCHAR || uMsg == WM_IME_CHAR)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        var eventa = GetKeyEvent(uMsg, wParam, lParam);
                        host.SendKeyEvent(eventa);
                    }
                }
                else if (uMsg == WM_IME_COMPOSITION)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        OnIMEComposition(host, hWnd, (int)lParam);
                    }
                }
                else if (uMsg == WM_IME_SETCONTEXT)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                        OnImeSetContext(host, hWnd, uMsg, (int)wParam, (int)lParam);
                    }
                }
                else if (uMsg == WM_IME_ENDCOMPOSITION)
                {

                }
                return CallDefProc(hWnd, hObj, uMsg, wParam, lParam);
            });

        private static void OnImeSetContext(IBrowserHost host, IntPtr hWnd, int uMsg, int wParam, int lParam)
        {
            var hIMC = ImeNative.ImmGetContext(hWnd);
            ImeNative.GetCaretPos(out var point);
            var compositionPotision = new ImeNative.COMPOSITIONFORM
            {
                dwStyle = (int)ImeNative.CFS_POINT,
                ptCurrentPos = new ImeNative.POINT(point.X, point.Y),
                rcArea = new ImeNative.RECT(0, 0, 0, 0)
            };
            ImeNative.ImmSetCompositionWindow(hIMC, ref compositionPotision);
            ImeNative.ImmReleaseContext(hWnd, hIMC);
        }

        private static void OnIMEComposition(IBrowserHost host, IntPtr hWnd, int lParam)
        {
            string text = string.Empty;
            if (ImeHandler.GetResult(hWnd, (uint)lParam, out text))
            {
                host.ImeCommitText(text, new Range(int.MaxValue, int.MaxValue), 0);
                host.ImeSetComposition(text, new CompositionUnderline[0], new Range(int.MaxValue, int.MaxValue), new Range(0, 0));
                host.ImeFinishComposingText(false);
            }
            else
            {
                var underlines = new List<CompositionUnderline>();
                int compositionStart = 0;
                if (ImeHandler.GetComposition(hWnd, (uint)lParam, underlines, ref compositionStart, out text))
                {
                    host.ImeSetComposition(text, underlines.ToArray(), new Range(int.MaxValue, int.MaxValue), new Range(compositionStart + underlines.Count, compositionStart + underlines.Count));

                }
                else
                {
                    host.ImeCancelComposition();
                }
            }
        }

        private static KeyEvent GetKeyEvent(int uMsg, IntPtr wParam, IntPtr lParam)
        {
            var eventa = new KeyEvent();
            eventa.WindowsKeyCode = (int)wParam;
            eventa.NativeKeyCode = (int)(long)lParam;
            eventa.IsSystemKey = (uMsg == WM_SYSCHAR || uMsg == WM_SYSKEYDOWN || uMsg == WM_SYSKEYUP);
            if (uMsg == WM_KEYDOWN || uMsg == WM_SYSKEYDOWN)
            {
                eventa.Type = KeyEventType.RawKeyDown;
            }
            else if (uMsg == WM_KEYUP || uMsg == WM_SYSKEYUP)
            {
                eventa.Type = KeyEventType.KeyUp;
            }
            else
            {
                eventa.Type = KeyEventType.Char;
            }
            eventa.Modifiers = GetKeyBoardEvent(wParam, lParam);
            return eventa;
        }

        private static CefEventFlags GetKeyBoardEvent(IntPtr wParam, IntPtr lParam)
        {
            CefEventFlags ret = CefEventFlags.None;
            if (IsKeyDown(VK_SHIFT))
            {
                ret |= CefEventFlags.ShiftDown;
            }
            if (IsKeyDown(VK_CONTROL))
            {
                ret |= CefEventFlags.ControlDown;
            }
            if (IsKeyDown(VK_MENU))
            {
                ret |= CefEventFlags.AltDown;
            }
            if ((WinAPI.GetKeyState(VK_NUMLOCK) & 1) != 0)
            {
                ret |= CefEventFlags.NumLockOn;
            }
            if ((WinAPI.GetKeyState(VK_CAPITAL) & 1) != 0)
            {
                ret |= CefEventFlags.CapsLockOn;
            }
            switch ((int)wParam)
            {
                case VK_RETURN:
                    {
                        if ((((int)(long)lParam >> 16) & KF_EXTENDED) != 0)
                        {
                            ret |= CefEventFlags.IsKeyPad;
                        }
                        break;
                    }
                case VK_INSERT:
                case VK_DELETE:
                case VK_HOME:
                case VK_END:
                case VK_PRIOR:
                case VK_NEXT:
                case VK_UP:
                case VK_DOWN:
                case VK_LEFT:
                case VK_RIGHT:
                    {
                        if ((((int)(long)lParam >> 16) & KF_EXTENDED) == 0)
                        {
                            ret |= CefEventFlags.IsKeyPad;
                        }
                        break;
                    }
                case VK_NUMLOCK:
                case VK_NUMPAD0:
                case VK_NUMPAD1:
                case VK_NUMPAD2:
                case VK_NUMPAD3:
                case VK_NUMPAD4:
                case VK_NUMPAD5:
                case VK_NUMPAD6:
                case VK_NUMPAD7:
                case VK_NUMPAD8:
                case VK_NUMPAD9:
                case VK_DIVIDE:
                case VK_MULTIPLY:
                case VK_SUBTRACT:
                case VK_ADD:
                case VK_DECIMAL:
                case VK_CLEAR:
                    {
                        ret |= CefEventFlags.IsKeyPad;
                        break;
                    }
                case VK_SHIFT:
                    {
                        if (IsKeyDown(VK_LSHIFT))
                        {
                            ret |= CefEventFlags.IsLeft;
                        }
                        else if (IsKeyDown(VK_RSHIFT))
                        {
                            ret |= CefEventFlags.IsRight;
                        }
                        break;
                    }
                case VK_CONTROL:
                    {
                        if (IsKeyDown(VK_LCONTROL))
                        {
                            ret |= CefEventFlags.IsLeft;
                        }
                        else if (IsKeyDown(VK_RCONTROL))
                        {
                            ret |= CefEventFlags.IsRight;
                        }
                        break;
                    }
                case VK_MENU:
                    {
                        if (IsKeyDown(VK_LMENU))
                        {
                            ret |= CefEventFlags.IsLeft;
                        }
                        else if (IsKeyDown(VK_RMENU))
                        {
                            ret |= CefEventFlags.IsRight;
                        }
                        break;
                    }
                case VK_LWIN:
                    {
                        ret |= CefEventFlags.IsLeft;
                        break;
                    }
                case VK_RWIN:
                    {
                        ret |= CefEventFlags.IsRight;
                        break;
                    }
            }
            return ret;
        }

        private static CefEventFlags GetMouseEventFlags(int wParam)
        {
            CefEventFlags ret = CefEventFlags.None;
            if ((wParam & MK_CONTROL) == MK_CONTROL)
            {
                ret |= CefEventFlags.ControlDown;
            }
            if ((wParam & MK_SHIFT) == MK_SHIFT)
            {
                ret |= CefEventFlags.ShiftDown;
            }
            if (IsKeyDown(VK_MENU))
            {
                ret |= CefEventFlags.AltDown;
            }
            if ((wParam & MK_LBUTTON) == MK_LBUTTON)
            {
                ret |= CefEventFlags.LeftMouseButton;
            }
            if ((wParam & MK_MBUTTON) == MK_MBUTTON)
            {
                ret |= CefEventFlags.MiddleMouseButton;
            }
            if ((wParam & MK_RBUTTON) == MK_RBUTTON)
            {
                ret |= CefEventFlags.RightMouseButton;
            }
            if ((WinAPI.GetKeyState(VK_NUMLOCK) & 1) != 0)
            {
                ret |= CefEventFlags.NumLockOn;
            }
            if ((WinAPI.GetKeyState(VK_CAPITAL) & 1) != 0)
            {
                ret |= CefEventFlags.CapsLockOn;
            }
            return ret;
        }

        private static bool IsKeyDown(int wParam)
        {
            return (WinAPI.GetKeyState(wParam) & 0x8000) != 0;
        }

        public static int RegisterControl()
        {
            return ExAPI.Ex_ObjRegister("CefChromeBrowser", EOS_VISIBLE, EOS_EX_FOCUSABLE, 0, 0, IntPtr.Zero, 0, s_pfnObjClassProc);
        }

        /// <summary>
        /// 只能调用一次
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void Initialize()
        {
            CefSettings settings = new CefSettings();
            var success = Cef.Initialize(settings);
            if (!success)
            {
                throw new Exception("Unable to initialize CEF, check the log file.");
            }
        }

        /// <summary>
        /// 只能调用一次
        /// </summary>
        public static void UnInitialize()
        {
            Cef.Shutdown();
        }

        public CefChromeBrowser(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight)
           : base(pOwner, "CefChromeBrowser", sText, x, y, nWidth, nHeight)
        {
            browser = new ChromiumWebBrowser();
            browser.Size = new System.Drawing.Size(nWidth, nHeight);
            eventHandler = new JsEventHandler();
            browser.JavascriptObjectRepository.Register("CefChromeBrowser", eventHandler, false, BindingOptions.DefaultBinder);
            browser.FrameLoadEnd += (t, s) =>
            {
                
                StringBuilder sb = new StringBuilder();
                sb.Append("(function(){").Append("CefSharp.BindObjectAsync('CefChromeBrowser');").Append("})();");
                browser.GetMainFrame().EvaluateScriptAsync(sb.ToString());
                browser.Paint += (k, e) =>
                {
                    var img = new ExImage(e.Width, e.Height, e.BufferHandle);
                    this.UserData = (IntPtr)img.handle;
                    GCHandle gcHandle = GCHandle.Alloc(browser);
                    IntPtr ptr = GCHandle.ToIntPtr(gcHandle);
                    this.LParam = ptr;
                    if (this.Validate)
                    {
                        this.Invalidate();
                    }
                };
            };
        }

        public void Load(string url)
        {
            if(browser != null && browser.IsBrowserInitialized)
            {
                browser.GetMainFrame().LoadUrl(url);
            }
        }

        public void GoForward()
        {
            if (browser != null)
            {
                browser.Forward();
            }  
        }

        public void Back()
        {
            if (browser != null)
            {
                browser.Back();
            }
        }

        /// <summary>
        /// 直接调用js脚本
        /// </summary>
        /// <param name="javascript"></param>
        public void Execute(string javascript)
        {
            if (browser != null)
            {
                browser.ExecuteScriptAsync(javascript);
            }   
        }

        /// <summary>
        /// 添加注册方法
        /// </summary>
        /// <param name="funName">方法名,js代码里方法名与其相同</param>
        /// <param name="eventfun">JS事件类</param>
        public void RegisterFun(string funName, IJsEvent eventfun)
        {
            eventHandler.RegisterFun(funName, eventfun);
        }

        public void UnRegisterFun(string funName)
        {
            eventHandler.UnRegisterFun(funName);
        }

        private JsEventHandler eventHandler;
        private ChromiumWebBrowser browser;
        public new string ClassName => "CefChromeBrowser";
    }

    public class JsEventHandler
    {
        private Dictionary<string, IJsEvent> dic = new Dictionary<string, IJsEvent>();
        public JsEventHandler()
        {
        }
        public void RegisterFun(string funName, IJsEvent eventfun)
        {
            dic.Add(funName, eventfun);
        }

        public void UnRegisterFun(string funName)
        {
            dic.Remove(funName);
        }

        public void Execute(string funName, string jsonStr, IJavascriptCallback success, IJavascriptCallback error)
        {
            if (dic.ContainsKey(funName))
            {
                dic[funName].Execute(jsonStr, success, error);
            }
            else
            {
                var obj = new
                {
                    code = 1,
                    message = String.Format("Not Found Event:{0}", funName)
                };
                error.ExecuteAsync(JsonConvert.SerializeObject(obj));
            }
        }
    }

    public interface IJsEvent
    {
        void Execute(string jsonStr, IJavascriptCallback success, IJavascriptCallback error);
    }

    public static class ImeNative
    {
        internal const uint GCS_RESULTSTR = 0x0800;
        internal const uint GCS_COMPSTR = 0x0008;
        internal const uint GCS_COMPATTR = 0x0010;
        internal const uint GCS_CURSORPOS = 0x0080;
        internal const uint GCS_COMPCLAUSE = 0x0020;

        internal const uint CPS_CANCEL = 0x0004;
        internal const uint CS_NOMOVECARET = 0x4000;
        internal const uint NI_COMPOSITIONSTR = 0x0015;

        internal const uint ATTR_INPUT = 0x00;
        internal const uint ATTR_TARGET_CONVERTED = 0x01;
        internal const uint ATTR_TARGET_NOTCONVERTED = 0x03;

        internal const uint ISC_SHOWUICOMPOSITIONWINDOW = 0x80000000;

        internal const uint CFS_DEFAULT = 0x0000;
        internal const uint CFS_RECT = 0x0001;
        internal const uint CFS_POINT = 0x0002;
        internal const uint CFS_FORCE_POSITION = 0x0020;
        internal const uint CFS_CANDIDATEPOS = 0x0040;
        internal const uint CFS_EXCLUDE = 0x0080;

        internal const uint LANG_JAPANESE = 0x11;
        internal const uint LANG_CHINESE = 0x04;
        internal const uint LANG_KOREAN = 0x12;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COMPOSITIONFORM
        {
            public int dwStyle;
            public POINT ptCurrentPos;
            public RECT rcArea;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CANDIDATEFORM
        {
            public int dwIndex;
            public int dwStyle;
            public POINT ptCurrentPos;
            public RECT rcArea;
        }

        [DllImport("imm32.dll")]
        internal static extern IntPtr ImmCreateContext();

        [DllImport("imm32.dll")]
        internal static extern IntPtr ImmAssociateContext(IntPtr hWnd, IntPtr hIMC);

        [DllImport("imm32.dll")]
        internal static extern bool ImmDestroyContext(IntPtr hIMC);

        [DllImport("imm32.dll")]
        internal static extern IntPtr ImmGetContext(IntPtr hWnd);

        [DllImport("Imm32.dll")]
        internal static extern bool ImmReleaseContext(IntPtr hWnd, IntPtr hIMC);

        [DllImport("Imm32.dll")]
        internal static extern bool ImmNotifyIME(IntPtr hIMC, uint action, uint index, uint value);

        [DllImport("imm32.dll", CharSet = CharSet.Unicode)]
        internal static extern uint ImmGetCompositionString(IntPtr hIMC, uint dwIndex, byte[] lpBuf, uint dwBufLen);

        [DllImport("imm32.dll")]
        internal static extern int ImmSetCompositionWindow(IntPtr hIMC, ref COMPOSITIONFORM lpCompForm);

        [DllImport("imm32.dll")]
        public static extern int ImmSetCandidateWindow(IntPtr hIMC, [MarshalAs(UnmanagedType.Struct)] ref CANDIDATEFORM lpCandidateForm);

        [DllImport("user32.dll")]
        internal static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32.dll")]
        internal static extern bool DestroyCaret();

        [DllImport("user32.dll")]
        internal static extern bool SetCaretPos(int x, int y);

        [DllImport("user32.dll")]
        internal static extern bool GetCaretPos(out POINT point);

        [DllImport("user32.dll")]
        internal static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        internal static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        internal static extern IntPtr SetFocus(IntPtr hWnd);
    }

    public static class ImeHandler
    {
        // Black SkColor value for underline.
        public static uint ColorUNDERLINE = 0xFF000000;
        // Transparent SkColor value for background.
        public static uint ColorBKCOLOR = 0x00000000;

        public static bool GetResult(IntPtr hwnd, uint lParam, out string text)
        {
            var hIMC = ImeNative.ImmGetContext(hwnd);

            var ret = GetString(hIMC, lParam, ImeNative.GCS_RESULTSTR, out text);

            ImeNative.ImmReleaseContext(hwnd, hIMC);

            return ret;
        }

        public static bool GetComposition(IntPtr hwnd, uint lParam, List<CompositionUnderline> underlines, ref int compositionStart, out string text)
        {
            var hIMC = ImeNative.ImmGetContext(hwnd);

            bool ret = GetString(hIMC, lParam, ImeNative.GCS_COMPSTR, out text);
            if (ret)
            {
                GetCompositionInfo(hwnd, lParam, text, underlines, ref compositionStart);
            }

            ImeNative.ImmReleaseContext(hwnd, hIMC);

            return ret;
        }

        private static bool GetString(IntPtr hIMC, uint lParam, uint type, out string text)
        {
            text = string.Empty;

            if (!IsParam(lParam, type))
            {
                return false;
            }

            var strLen = ImeNative.ImmGetCompositionString(hIMC, type, null, 0);
            if (strLen <= 0)
            {
                return false;
            }

            // buffer contains char (2 bytes)
            byte[] buffer = new byte[strLen];
            ImeNative.ImmGetCompositionString(hIMC, type, buffer, strLen);
            text = System.Text.Encoding.Unicode.GetString(buffer);

            return true;
        }

        private static void GetCompositionInfo(IntPtr hwnd, uint lParam, string text, List<CompositionUnderline> underlines, ref int compositionStart)
        {
            var hIMC = ImeNative.ImmGetContext(hwnd);

            underlines.Clear();

            byte[] attributes = null;
            int targetStart = text.Length;
            int targetEnd = text.Length;
            if (IsParam(lParam, ImeNative.GCS_COMPATTR))
            {
                attributes = GetCompositionSelectionRange(hIMC, ref targetStart, ref targetEnd);
            }

            // Retrieve the selection range information. If CS_NOMOVECARET is specified
            // it means the cursor should not be moved and we therefore place the caret at
            // the beginning of the composition string. Otherwise we should honour the
            // GCS_CURSORPOS value if it's available.
            if (!IsParam(lParam, ImeNative.CS_NOMOVECARET) && IsParam(lParam, ImeNative.GCS_CURSORPOS))
            {
                // IMM32 does not support non-zero-width selection in a composition. So
                // always use the caret position as selection range.
                int cursor = (int)ImeNative.ImmGetCompositionString(hIMC, ImeNative.GCS_CURSORPOS, null, 0);
                compositionStart = cursor;
            }
            else
            {
                compositionStart = 0;
            }

            if (attributes != null &&
                // character before
                ((compositionStart > 0 && (compositionStart - 1) < attributes.Length && attributes[compositionStart - 1] == ImeNative.ATTR_INPUT)
                ||
                // character after
                (compositionStart >= 0 && compositionStart < attributes.Length && attributes[compositionStart] == ImeNative.ATTR_INPUT)))
            {
                // as MS does with their ime implementation we should only use the GCS_CURSORPOS if the character
                // before or after is new input.
                // https://referencesource.microsoft.com/#PresentationFramework/src/Framework/System/windows/Documents/ImmComposition.cs,1079
            }
            else
            {
                compositionStart = text.Length;
            }

            if (IsParam(lParam, ImeNative.GCS_COMPCLAUSE))
            {
                GetCompositionUnderlines(hIMC, targetStart, targetEnd, underlines);
            }

            if (underlines.Count == 0)
            {
                var range = new Range();

                bool thick = false;

                if (targetStart > 0)
                {
                    range = new Range(0, targetStart);
                }

                if (targetEnd > targetStart)
                {
                    range = new Range(targetStart, targetEnd);
                    thick = true;
                }

                if (targetEnd < text.Length)
                {
                    range = new Range(targetEnd, text.Length);
                }

                underlines.Add(new CompositionUnderline(range, ColorUNDERLINE, ColorBKCOLOR, thick));
            }

            ImeNative.ImmReleaseContext(hwnd, hIMC);
        }

        private static void GetCompositionUnderlines(IntPtr hIMC, int targetStart, int targetEnd, List<CompositionUnderline> underlines)
        {
            var clauseSize = ImeNative.ImmGetCompositionString(hIMC, ImeNative.GCS_COMPCLAUSE, null, 0);
            if (clauseSize <= 0)
            {
                return;
            }

            int clauseLength = (int)clauseSize / sizeof(Int32);

            // buffer contains 32 bytes (4 bytes) array
            var clauseData = new byte[(int)clauseSize];
            ImeNative.ImmGetCompositionString(hIMC, ImeNative.GCS_COMPCLAUSE, clauseData, clauseSize);

            var clauseLength_1 = clauseLength - 1;
            for (int i = 0; i < clauseLength_1; i++)
            {
                int from = BitConverter.ToInt32(clauseData, i * sizeof(Int32));
                int to = BitConverter.ToInt32(clauseData, (i + 1) * sizeof(Int32));

                var range = new Range(from, to);
                bool thick = (range.From >= targetStart && range.To <= targetEnd);

                underlines.Add(new CompositionUnderline(range, ColorUNDERLINE, ColorBKCOLOR, thick));
            }
        }

        private static byte[] GetCompositionSelectionRange(IntPtr hIMC, ref int targetStart, ref int targetEnd)
        {
            var attributeSize = ImeNative.ImmGetCompositionString(hIMC, ImeNative.GCS_COMPATTR, null, 0);
            if (attributeSize <= 0)
            {
                return null;
            }

            int start = 0;
            int end = 0;

            // Buffer contains 8bit array
            var attributeData = new byte[attributeSize];
            ImeNative.ImmGetCompositionString(hIMC, ImeNative.GCS_COMPATTR, attributeData, attributeSize);

            for (start = 0; start < attributeSize; ++start)
            {
                if (IsSelectionAttribute(attributeData[start]))
                {
                    break;
                }
            }

            for (end = start; end < attributeSize; ++end)
            {
                if (!IsSelectionAttribute(attributeData[end]))
                {
                    break;
                }
            }

            targetStart = start;
            targetEnd = end;
            return attributeData;
        }

        private static bool IsSelectionAttribute(byte attribute)
        {
            return (attribute == ImeNative.ATTR_TARGET_CONVERTED || attribute == ImeNative.ATTR_TARGET_NOTCONVERTED);
        }

        private static bool IsParam(uint lParam, uint type)
        {
            return (lParam & type) == type;
        }
    }
}
