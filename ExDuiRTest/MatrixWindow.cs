using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System.Runtime.InteropServices;
using System;

namespace ExDuiRTest
{
    public class MatrixWindow
    {
        static private ExSkin skin;
        static private ExStatic label;
        static private ExObjProcDelegate objProc;

        static public void CreateMatrixWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试矩阵", 0, 0, 400, 400,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnMatrixMsgProc);
                label = new ExStatic(skin, "", 50, 50, 200, 250, -1, EOS_EX_FOCUSABLE, DT_VCENTER, 0, default, objProc);
                label.ColorBackground = Util.ExRGBA(180, 230, 22, 255);
                skin.Visible = true;
            }
        }

        static private IntPtr OnMatrixMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_CREATE)
            {
                ExControl Obj = new ExControl(hObj);
                Obj.LParam = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Double)));
                Util.DoubleToIntPtr(Obj.LParam, 0);
            }
            else if (uMsg == WM_DESTROY)
            {
                ExControl Obj = new ExControl(hObj);
                Marshal.FreeHGlobal(Obj.LParam);
            }
            else if (uMsg == WM_PAINT)
            {
                ExControl Obj = new ExControl(hObj);
                Obj.BeginPaint(out var ps);
                ExCanvas canvas = new ExCanvas(ps.hCanvas);
                canvas.Clear(Util.ExRGB2ARGB(16777215, 100));
                var value = Util.IntPtrToDouble(Obj.LParam);
                double nCurrent =  (double)(value / 100);
                ExMatrix ms = new ExMatrix();
                ms.Translate(((float)ps.nWidth / 2), ((float)ps.nHeight / 2));
                ms.Rotate((float)(nCurrent * 90));
                ms.Scale(1 + (float)(nCurrent * 0.25), 1 + (float)(nCurrent * 0.25));
                ms.Translate(((float)-ps.nWidth / 2), ((float)-ps.nHeight / 2));
                canvas.TransForm = ms;
                ExBrush brush = new ExBrush(Obj.ColorBackground);
                //Console.WriteLine($"ColorBackground:{((float)ps.nWidth / 2)},{((float)ps.nHeight / 2)}");
                canvas.FillEllipse(brush, ((float)ps.nWidth / 2), ((float)ps.nHeight / 2), 75, 50);
                brush.Dispose();
                canvas.SetTransFormNull();
                ms.Dispose();
                Obj.EndPaint(ref ps);
                Marshal.WriteInt32(pResult, 1);
                return (IntPtr)1;
            }
            else if(uMsg == WM_EX_EASING)
            {
                ExControl Obj = new ExControl(hObj);
                var es = Util.IntPtrToStructure<ExEasingInfo>(lParam);
                if(es.nProgress == 1)//如果进度=1则表示缓动结束
                {
                    Obj.UserData = IntPtr.Zero;
                }
                Util.DoubleToIntPtr(Obj.LParam, es.nCurrent);
                Obj.Invalidate();
            }
            else if (uMsg == WM_MOUSEHOVER)
            {
                ExControl Obj = new ExControl(hObj);
                var easing = new ExEasing(ET_OutElastic, IntPtr.Zero, ES_SINGLE | ES_THREAD | ES_DISPATCHNOTIFY, (IntPtr)hObj, 500, 20, EES_PLAY, 0, 100);
                var old = Obj.UserData;
                Obj.UserData = easing.handle;
                
                if ((int)old != 0)//如果前一个缓动未结束,则停止前面的缓动
                {
                    var oldeasing = new ExEasing(old);
                    oldeasing.State = EES_STOP;
                }
                Obj.SetUIState(STATE_HOVER, false, false);//设置悬浮状态
            }
            else if (uMsg == WM_MOUSELEAVE)
            {
                ExControl Obj = new ExControl(hObj);
                var easing = new ExEasing(ET_OutElastic, IntPtr.Zero, ES_SINGLE | ES_THREAD | ES_DISPATCHNOTIFY | ES_REVERSE, (IntPtr)hObj, 500, 20, EES_PLAY, 0, 100);
                var old = Obj.UserData;
                Obj.UserData = easing.handle;
                if ((int)old != 0)//如果前一个缓动未结束,则停止前面的缓动
                {
                    var oldeasing = new ExEasing(old);
                    oldeasing.State = EES_STOP;
                }
                Obj.SetUIState(STATE_HOVER, true, false);//删除悬浮状态
            }
            return IntPtr.Zero;
        }
    }
}
