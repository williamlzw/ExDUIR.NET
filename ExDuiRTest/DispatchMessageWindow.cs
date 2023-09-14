using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class DispatchMessageWindow
    {
        static private ExSkin skin;
        static private ExObjProcDelegate objSideProc;
        static private ExObjProcDelegate objParentProc;
        static private ExObjProcDelegate objMsgProc;
        static private ExObjEventProcDelegate objEventProc;
        static private ExWndProcDelegate wndProc;
        static private ExStatic label1;
        static private ExStatic label2;
        static private ExStatic label3;
        static private ExButton button;
 
        static public void CreateDispatchMessageWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnEventWndMsgProc);
            skin = new ExSkin(pOwner, null, "测试事件分发", 0, 0, 400, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                /*消息(WM_/XXM_)分发的流程是：
	            控件产生消息->控件类回调函数->控件回调函数->默认控件回调函数(在此部分消息会产生事件)
	            事件(NM_/XXN_)分发的流程是：
	            控件产生事件->JS回调函数->控件自身收到WM_NOTIFY->控件直接父控件收到WM_NOTIFY->控件间接父控件从内而外逐层收到WM_NOTIFY消息(需启用消息冒泡)->所属窗口收到WM_NOTIFY消息
	            消息和事件在分发途中均可拦截,HandEvent*/
                objSideProc = new ExObjProcDelegate(OnSideButtonMsgProc);
                objParentProc = new ExObjProcDelegate(OnParentButtonMsgProc);
                objMsgProc = new ExObjProcDelegate(OnEventButtonMsgProc);
                objEventProc = new ExObjEventProcDelegate(OnEventButtonEvent);

                label1 = new ExStatic(skin, "按钮外间接父控件", 25, 35, 350, 250, -1, -1, DT_SINGLELINE, 0, default, objSideProc);
                label1.ColorBackground = Util.ExRGB2ARGB(65535, 100);

                label2 = new ExStatic(label1, "按钮内间接父控件", 10, 20, 330, 200, -1, -1, DT_SINGLELINE, 0, default, objSideProc);
                label2.ColorBackground = Util.ExRGBA(100, 100, 100, 100);

                label3 = new ExStatic(label2, "按钮直接父控件", 10, 20, 330, 200, -1, -1, DT_SINGLELINE, 0, default, objParentProc);
                label3.ColorBackground = Util.ExRGBA(26, 100, 12, 100);

                button = new ExButton(label3, "按钮", 10, 20, 200, 100, -1, -1, -1, 1001, default, objMsgProc);
                button.HandleEvent(NM_CLICK, objEventProc);
                button.EnableEventBubble = true;// 启用控件的事件冒泡，事件冒泡是指事件将根据父控件逐层传递至窗口

                skin.Visible = true;
            }
        }

        static private IntPtr OnEventButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == NM_CLICK)
            {
                ExMessageBox.Show(new ExControl(hObj), "按钮收到了独立的单击事件", "");
            }
            return IntPtr.Zero;
        }
        static private IntPtr OnEventWndMsgProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_NOTIFY)
            {
                if((int)wParam == 1001)
                {
                    var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                    if (ni.nCode == NM_CLICK)
                    {
                        ExMessageBox.Show(new ExSkin(hExDui), "按钮所属窗口收到了单击事件", "");
                    }
                }
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnEventButtonMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_EX_LCLICK)//左键单击消息,拦截这条则不会触发任何事件
            {
                ExMessageBox.Show(new ExControl(hObj), "按钮收到了单击消息", "");
            }
            else if(uMsg == WM_NOTIFY)
            {
                var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                if(ni.hObjFrom == hObj)
                {
                    if(ni.nCode == NM_CLICK)
                    {
                        ExMessageBox.Show(new ExControl(hObj), "按钮收到了单击事件", "");
                    }
                }
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnParentButtonMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_NOTIFY)
            {
                if ((int)wParam == 1001)//wParam表示事件对象的ID，1001最里层按钮
                {
                    var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                    if (ni.nCode == NM_CLICK)
                    {
                        var obj = new ExControl(hObj);
                        if(ExMessageBox.Show(obj, "按钮直接父控件收到了单击事件，是否拦截？", "", MB_YESNO) == IDYES)
                        {
                            Marshal.WriteInt32(pResult, 1);//返回值置1(真)表示拦截
                            return (IntPtr)1;//函数返回值表示是否使用返回值,lpResult才是真正的返回值
                        }
                    }
                }
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnSideButtonMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_NOTIFY)
            {
                if((int)wParam == 1001)//wParam表示事件对象的ID，1001最里层按钮
                {
                    var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                    if(ni.nCode == NM_CLICK)
                    {
                        var obj = new ExControl(hObj);
                        ExMessageBox.Show(skin, obj.Text, "收到了单击事件");
                    }
                }
            }
            return IntPtr.Zero;
        }
    }
}
