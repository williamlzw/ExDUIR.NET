using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Drawing;

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
                        ExPaintStruct ps;
                        //开始绘制与EndPaint配套调用
                        Obj.BeginPaint(out ps);
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
}
