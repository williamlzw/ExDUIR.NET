using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using System;
using static ExDuiR.NET.Native.ExConst;
using System.Drawing;

namespace ExDuiRTest
{
    public class TestCustomCtrl : ExControl
    {
        private static ExObjClassProcDelegate s_pfnObjClassProc = new ExObjClassProcDelegate(
            (IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData) =>
        {
            ExControl Obj = new ExControl(hObj);
            switch (uMsg)
            {
                case 15: //WM_PAINT
                    {
                        ExPaintStruct ps;
                        Obj.BeginPaint(out ps);
                        ExCanvas canvas = new ExCanvas(ps.hCanvas);
                        canvas.Clear(Color.Yellow.ToArgb());
                        Obj.EndPaint(ref ps);
                    }
                    break;
                default:
                    return CallDefProc(hWnd, hObj, uMsg, wParam, lParam);
            }
            return IntPtr.Zero;
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
