using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;
using System.Drawing;
using CefSharp;
using CefSharp.OffScreen;
using System.Runtime.InteropServices;
using ExDuiR.NET.Frameworks.Utility;
using Newtonsoft.Json;
using System.Text;


namespace ExDuiRTest
{
    /// <summary>
    /// 扩展组件演示,继承自ExControl
    /// </summary>
    public class TestCustomCtrl : ExControl
    {
        public class TestStruct
        {
            public string str;
            public object obj;
        }

        private const int CustomCtrl_MESSAGE_GET_STRUCT = 100000;
        private const int CustomCtrl_MESSAGE_SET_STRUCT = 100001;
        private const int CustomCtrl_MESSAGE_GET_PARAM = 100002;
        private const int CustomCtrl_MESSAGE_SET_PARAM = 100003;

        public TestStruct Struct
        {
            get
            {
                var ptr = this.SendMessage(CustomCtrl_MESSAGE_GET_STRUCT);
                GCHandle gcHandle = GCHandle.FromIntPtr(ptr);
                TestStruct obj = (TestStruct)gcHandle.Target;
                return obj;
            }
            set
            {
                GCHandle gcHandle = GCHandle.Alloc(value);
                IntPtr ptr = GCHandle.ToIntPtr(gcHandle);
                this.SendMessage(CustomCtrl_MESSAGE_SET_STRUCT, IntPtr.Zero, ptr);
            }
        }

        /// <summary>
        /// c#类成员属性
        /// </summary>
        public int Param
        {
            get
            {
                return (int)this.SendMessage(CustomCtrl_MESSAGE_GET_PARAM);
            }
            set
            {
                this.SendMessage(CustomCtrl_MESSAGE_SET_PARAM, IntPtr.Zero, (IntPtr)value);
            }
        }

        private static ExObjClassProcDelegate s_pfnObjClassProc = new ExObjClassProcDelegate(
            (IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData) =>
            {
                ExControl Obj = new ExControl(hObj);
                switch (uMsg)
                {
                    case WM_CREATE:
                        {
                            Obj.InitPropList(3);
                            break;
                        }
                    case WM_PAINT:
                        {
                            //开始绘制与EndPaint配套调用
                            Obj.BeginPaint(out var ps);
                            ExCanvas canvas = new ExCanvas(ps.hCanvas);
                            var brush = new ExBrush(Util.ExARGB(255, 0, 0, 255));
                            canvas.Clear(Color.Yellow.ToArgb());
                            canvas.DrawText(Obj.Font, brush, Obj.Text, -1, DT_CENTER | DT_VCENTER, ps.rcPaint.nLeft, ps.rcPaint.nTop, ps.rcPaint.nRight, ps.rcPaint.nBottom);
                            //结束绘制
                            Obj.EndPaint(ref ps);
                            brush.Dispose();
                            break;
                        }
                    case CustomCtrl_MESSAGE_SET_STRUCT:
                        {
                            Obj.SetProp((IntPtr)0, lParam);
                            break;
                        }
                    case CustomCtrl_MESSAGE_GET_STRUCT:
                        {
                            return Obj.GetProp((IntPtr)0);
                        }
                    case CustomCtrl_MESSAGE_SET_PARAM:
                        {
                            Obj.SetProp((IntPtr)1, lParam);
                            break;
                        }
                    case CustomCtrl_MESSAGE_GET_PARAM:
                        {
                            return Obj.GetProp((IntPtr)1);
                        }
                    default:
                        break;
                }
                //组件默认回调
                return CallDefProc(hWnd, hObj, uMsg, wParam, lParam);
            });

        public static int RegisterControl()
        {
            return ExAPI.Ex_ObjRegister("TestCustomCtrl", OBJECT_STYLE_VISIBLE, OBJECT_STYLE_EX_FOCUSABLE, 0, 0, IntPtr.Zero, 0, s_pfnObjClassProc);
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
                    Obj.EnableIME = true;
                }
                else if (uMsg == WM_DESTROY)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        if (Obj.UserData != IntPtr.Zero)
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
                        var dpi = Util.GetDpi();
                        extend.Size = new System.Drawing.Size(Util.LOWORD((uint)lParam), Util.HIWORD((uint)lParam));
                        //host.WasResized();
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
                else if (uMsg == WM_KEYDOWN || uMsg == WM_SYSKEYDOWN || uMsg == WM_KEYUP || uMsg == WM_SYSKEYUP || uMsg == WM_CHAR || uMsg == WM_SYSCHAR)
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
                else if(uMsg == WM_IME_COMPOSITION)
                {
                    if (Obj.LParam != IntPtr.Zero)
                    {
                        GCHandle gcHandle = GCHandle.FromIntPtr(Obj.LParam);
                        ChromiumWebBrowser extend = (ChromiumWebBrowser)gcHandle.Target;
                        var host = extend.GetBrowserHost();
                       
                        //host.
                    }
                }
                return CallDefProc(hWnd, hObj, uMsg, wParam, lParam);
            });

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
            return ExAPI.Ex_ObjRegister("CefChromeBrowser", OBJECT_STYLE_VISIBLE, OBJECT_STYLE_EX_FOCUSABLE, 0, 0, IntPtr.Zero, 0, s_pfnObjClassProc);
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
            browser = new ChromiumWebBrowser("home.html");
            var dpi = Util.GetDpi();
            browser.Size = new System.Drawing.Size((int)(nWidth * dpi), (int)(nHeight * dpi));
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
            if (browser != null && browser.IsBrowserInitialized)
            {
                browser.GetMainFrame().LoadUrl(url);
            }
        }

        public void LoadHtml(string html)
        {
            if (browser != null && browser.IsBrowserInitialized)
            {
                browser.GetMainFrame().LoadHtml(html);
            }
        }

        public void GoForward()
        {
            if (browser != null && browser.IsBrowserInitialized)
            {
                browser.Forward();
            }
        }

        public void Back()
        {
            if (browser != null && browser.IsBrowserInitialized)
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
            if (browser != null && browser.IsBrowserInitialized)
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
}
