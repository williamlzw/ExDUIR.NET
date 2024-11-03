using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using CefSharp;
using Newtonsoft.Json;
using CefSharp.OffScreen;

namespace ExDuiRTest
{
    public class CefBrowserWindow
    {
        static private ExSkin skin;
        static private ExWndProcDelegate wndProc;
        static private CefChromeBrowser browserObj;

        static public void CreateCefBrowserWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWndProc);
            skin = new ExSkin(pOwner, null, "测试CEF浏览框", 0, 0, 800, 600,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_BUTTON_MAX | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                CefChromeBrowser.RegisterControl();
                browserObj = new CefChromeBrowser(skin, "", 30, 30, 700, 500);
                //延时等待加载完毕
                System.Threading.Thread.Sleep(1000);
                //演示js调用c#代码,要在Load html前注册方法
                browserObj.RegisterFun("TestJsEvent", new TestJsEvent());
                var str = Properties.Resources.cef;
                //browserObj.LoadHtml(str);
                browserObj.Load("www.baidu.com");

                //直接调用js
                string javascript = "test2();";
                browserObj.Execute(javascript);
                skin.Visible = true;
            }
        }

        static private IntPtr OnWndProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr lpResult)
        {
            if (uMsg == WM_SIZE)
            {
                if (browserObj != null)
                {
                    var dpi = Util.GetDpi();
                    browserObj.Move(50, 50, (int)(Util.LOWORD((uint)lParam) / dpi) - 100, (int)(Util.HIWORD((uint)lParam) / dpi) - 100);
                }
            }
            return IntPtr.Zero;
        }
    }

    /// <summary>
    /// 演示自定义Js事件
    /// </summary>
    public class TestJsEvent : IJsEvent
    {
        public void Execute(string jsonStr, IJavascriptCallback success, IJavascriptCallback error)
        {
            Dictionary<string, object> resultParam = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStr);
            if (resultParam.Keys.Contains("message", StringComparer.OrdinalIgnoreCase))
            {
                string message = resultParam.First(x => x.Key.Equals("message", StringComparison.OrdinalIgnoreCase)).Value.ToString();
                bool ret = true;
                if (ret)
                {
                    var obj = new
                    {
                        code = 0,
                        message = message
                    };
                    success.ExecuteAsync(JsonConvert.SerializeObject(obj));
                    ExMessageBox.Show(message, "js传进来的值");
                }
                else
                {
                    var obj = new
                    {
                        code = 1,
                        message = "call error"
                    };
                    error.ExecuteAsync(JsonConvert.SerializeObject(obj));
                }
            }
        }
    }
}
