using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using Newtonsoft.Json;

namespace ExDuiRTest
{
    static class CustomCtrlWindow
    {
        static private ExSkin skin;
        static private ExObjEventProcDelegate objEvent;
        static private TestCustomCtrl custom1;
        static private TestCustomCtrl custom2;

        static public void CreateCustomCtrlWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试自定义组件", 0, 0, 200, 250,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                objEvent = new ExObjEventProcDelegate(OnButtonEventProc);
                //注册自定义组件
                TestCustomCtrl.RegisterControl();
                //创建自定义组件
                custom1 = new TestCustomCtrl(skin, "点击我看输出", 50, 50, 100, 50);
                custom1.Param = 1;
                custom1.Struct = new TestCustomCtrl.TestStruct
                {
                    str = "结构1",
                    obj = JsonConvert.DeserializeObject("{value:'我是结构1'}")
                };
                custom2 = new TestCustomCtrl(skin, "点击我看输出", 50, 150, 100, 50);
                custom2.Param = 2;
                custom2.Struct = new TestCustomCtrl.TestStruct
                {
                    str = "结构2",
                    obj = JsonConvert.DeserializeObject("{value:'我是结构2'}")
                };
                custom1.HandleEvent(NM_CLICK, objEvent);
                custom2.HandleEvent(NM_CLICK, objEvent);

                skin.Visible = true;
            }
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (hObj == custom1.handle)
            {
                Console.WriteLine(custom1.Param);
                Console.WriteLine($"{custom1.Struct.str}, {JsonConvert.SerializeObject(custom1.Struct.obj)}");
            }
            else if (hObj == custom2.handle)
            {
                Console.WriteLine(custom2.Param);
                Console.WriteLine($"{custom2.Struct.str}, {JsonConvert.SerializeObject(custom2.Struct.obj)}");
            }
            return IntPtr.Zero;
        }
    }
}
