using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace DemoProject
{
    static class LoginWindow
    {
        static private ExApp theApp;
        static private ExSkin skin;
        static private ExWndProcDelegate wndProc;
        static private ExObjProcDelegate editProc;
        static private ExStatic bkg;
        static private ExObjProcDelegate bkgProc;

        static private ExEasing iconEasing;
        static private ExStatic icon;
        static private ExObjProcDelegate iconProc;

        static private ExStatic container;
        static private ExObjProcDelegate containerProc;

        static private ExEditEx edit1;
        static private ExEditEx edit2;
        static private ExButtonEx button1;

        static public void CreateLoginWindow()
        {
            //读入主题包
            var theme = Properties.Resources.Default;
            //初始化引擎,必须。开启DPI缩放,渲染全部菜单(二级子菜单改背景色需启用此风格)
            theApp = new ExApp(theme, ENGINE_FLAG_DPI_ENABLE | ENGINE_FLAG_MENU_ALL);
            //创建窗口皮肤,必须
            wndProc = new ExWndProcDelegate(OnWndMsgProc);
            skin = new ExSkin(null, null, "测试客户端", 0, 0, 1440, 900,
            WINDOW_STYLE_MAINWINDOW | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(0, 0, 0, 255);
                bkgProc = new ExObjProcDelegate(OnBkgProc);
                iconProc = new ExObjProcDelegate(OnIconProc);
                containerProc = new ExObjProcDelegate(OnContainerProc);
                bkg = new ExStatic(skin, "", 0, 0, 975, 900, -1, -1, -1, 0, default, bkgProc);
                icon = new ExStatic(skin, "", 0, 0, 1440, 900, -1, -1, -1, 0, default, iconProc);
                iconEasing = new ExEasing(EASING_TYPE_OUTBOUNCE, IntPtr.Zero, Util.MAKELONG(EASING_MODE_MANYTIMES | EASING_MODE_DISPATCHNOTIFY | EASING_MODE_THREAD, 2), (IntPtr)icon.handle, 80, 1, EASING_STATE_PLAY, 0, 100);

                container = new ExStatic(skin, "", 0, 80, 1440, 900, -1, -1, -1, 0, default, containerProc);
               
                editProc = new ExObjProcDelegate(OnEditMsgProc);
                edit1 = new ExEditEx(container, "", 1048, 420, 320, 40, -1, OBJECT_STYLE_EX_CUSTOMDRAW | OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_TABSTOP, -1, 0, default);
                edit1.SetFont("Microsoft Yahei", 14);
                edit1.ColorTextNormal = Util.ExRGBA(255, 255, 255, 255);
                edit1.SetBanner("请输入账号", Util.ExRGBA(255, 255, 255, 100));
                edit1.Props = new ExObjProps
                {
                    crBkgNormal = Util.ExRGBA(70, 70, 70, 255),
                    crBorderHover = Util.ExRGBA(255, 255, 255, 255),
                    crBorderDownOrChecked = Util.ExRGBA(255, 255, 255, 255),
                    radius = 0,
                    strokeWidth = 1,
                    nIconPosition = 0
                };
                edit1.Icon = new ExImage(Properties.Resources.icon_contacts_normal);

                edit2 = new ExEditEx(container, "", 1048, 476, 320, 40, OBJECT_STYLE_VISIBLE | EDIT_STYLE_USEPASSWORD, OBJECT_STYLE_EX_CUSTOMDRAW | OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_TABSTOP, -1, 0, default);
                edit2.SetFont("Microsoft Yahei", 14);
                edit2.ColorTextNormal = Util.ExRGBA(255, 255, 255, 255);
                edit2.SetBanner("请输入密码", Util.ExRGBA(255, 255, 255, 100));
                edit2.Props = new ExObjProps
                {
                    crBkgNormal = Util.ExRGBA(70, 70, 70, 255),
                    crBorderHover = Util.ExRGBA(255, 255, 255, 255),
                    crBorderDownOrChecked = Util.ExRGBA(255, 255, 255, 255),
                    radius = 0,
                    strokeWidth = 1,
                    nIconPosition = 0
                };
                edit2.Icon = new ExImage(Properties.Resources.psw_normal);
                button1 = new ExButtonEx(container, "", 1320, 530, 55, 55);
                ExImageInfo info1 = new ExImageInfo
                {
                    imgNormal = new ExImage(Properties.Resources.loginnormal).handle,
                    imgHover = new ExImage(Properties.Resources.loginhover).handle,
                    imgDownOrChecked = new ExImage(Properties.Resources.loginnormal).handle
                };
                button1.ImageInfo = info1;
                container.Alpha = 0;
                skin.Visible = true;
                theApp.Run();
            }
        }

        static private IntPtr OnContainerProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            var obj = new ExControl(hObj);
            if (uMsg == WM_EX_EASING)
            {
                var es = Util.IntPtrToStructure<ExEasingInfo>(lParam);
                obj.Move(OBJECT_POSITION_DEFAULT, (int)(ExAPI.Ex_Scale(80) - es.nCurrent / 100 * ExAPI.Ex_Scale(80)), OBJECT_POSITION_DEFAULT, OBJECT_POSITION_DEFAULT, true);
                obj.Alpha = (int)(es.nCurrent / 100 * 255);
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnIconProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            var obj = new ExControl(hObj);
            if (uMsg == WM_EX_EASING)
            {
                var es = Util.IntPtrToStructure<ExEasingInfo>(lParam);
                if (es.nProgress == 1 && es.nTimesSurplus == 1)
                {
                    var easing = new ExEasing(EASING_TYPE_LINEAR, IntPtr.Zero, EASING_MODE_SINGLE | EASING_MODE_DISPATCHNOTIFY | EASING_MODE_THREAD, (IntPtr)bkg.handle, 20, 1, EASING_STATE_PLAY, 0, 100);
                }
                if (es.nProgress == 1 && es.nTimesSurplus == 0)
                {
                    var easing = new ExEasing(EASING_TYPE_LINEAR, IntPtr.Zero, EASING_MODE_SINGLE | EASING_MODE_DISPATCHNOTIFY | EASING_MODE_THREAD, (IntPtr)container.handle, 20, 1, EASING_STATE_PLAY, 0, 100);
                }
                var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExEasingInfo)));
                Marshal.StructureToPtr(es, ptr, false);
                obj.LParam = ptr;
                obj.Invalidate();
            }
            else if (uMsg == WM_PAINT)
            {
                obj.BeginPaint(out var ps);
                var ptr = obj.LParam;
                double p = 0;
                if (ptr != IntPtr.Zero)
                {
                    var es = (ExEasingInfo)Marshal.PtrToStructure(ptr, typeof(ExEasingInfo));
                    p = es.nCurrent / 100;
                    Marshal.FreeHGlobal(ptr);
                    var img = new ExImage(Properties.Resources.icon);
                    var canvas = new ExCanvas(ps.hCanvas);
                    if (es.nTimesSurplus == 1)
                    {
                        var mx = new ExMatrix();
                        mx.Translate((float)(ps.nWidth * p / 2), (float)(ps.nHeight / 2));
                        mx.Rotate((float)(p * 360));
                        mx.Translate(-(float)(ps.nWidth * p / 2), -(float)(ps.nHeight / 2));
                        canvas.TransForm = mx;
                        var X = (ps.rcPaint.nRight * p - ExAPI.Ex_Scale(80)) / 2;
                        var Y = (ps.rcPaint.nBottom - ExAPI.Ex_Scale(80)) / 2;
                        canvas.DrawImageRect(img, (float)X, (float)Y, (float)X + ExAPI.Ex_Scale(80), (float)Y + ExAPI.Ex_Scale(80), 255);
                        canvas.SetTransFormNull();
                        mx.Dispose();
                    }
                    else
                    {
                        var X = (ps.rcPaint.nRight  - ExAPI.Ex_Scale(80)) / 2 + ExAPI.Ex_Scale((float)(480 * p));
                        var Y = (ps.rcPaint.nBottom - ExAPI.Ex_Scale(80)) / 2 - ExAPI.Ex_Scale((float)(100 * p));
                        canvas.DrawImageRect(img, (float)X, (float)Y, (float)X + ExAPI.Ex_Scale(80), (float)Y + ExAPI.Ex_Scale(80), 255);
                    }
                    img.Dispose();
                }
                obj.EndPaint(ref ps);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnBkgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            var obj = new ExControl(hObj);
            if(uMsg == WM_EX_EASING)
            {
                var es = Util.IntPtrToStructure<ExEasingInfo>(lParam);
                if(es.nProgress == 1)
                {
                    obj.UserData = IntPtr.Zero;
                }
                var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExEasingInfo)));
                Marshal.StructureToPtr(es, ptr, false);
                obj.LParam = ptr;
                obj.Invalidate();
            }
            else if(uMsg == WM_PAINT)
            {
                obj.BeginPaint(out var ps);
                var ptr = obj.LParam;
                double p = 0;
                if(ptr != IntPtr.Zero)
                {
                    var es = (ExEasingInfo)Marshal.PtrToStructure(ptr, typeof(ExEasingInfo));
                    p = es.nCurrent / 100;
                    Marshal.FreeHGlobal(ptr);
                }
                var img = new ExImage(Properties.Resources.douyinbkg);
                var canvas = new ExCanvas(ps.hCanvas);
                canvas.DrawImageRect(img, 0, 0, ps.rcPaint.nRight, ps.rcPaint.nBottom, (int)(255 * p));
                img.Dispose();
                obj.EndPaint(ref ps);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnEditMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            return IntPtr.Zero;
        }

        static private IntPtr OnWndMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_ERASEBKGND)
            {
                var canvas = new ExCanvas((int)wParam);
                canvas.FillRect(Util.ExRGBA(255, 255, 255, 255), 0, 0, ExAPI.Ex_Scale(976), ExAPI.Ex_Scale(900));
                canvas.FillRect(Util.ExRGBA(5, 97, 221, 255), ExAPI.Ex_Scale(975), 0, ExAPI.Ex_Scale(1440), ExAPI.Ex_Scale(900));
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }
    }
}
