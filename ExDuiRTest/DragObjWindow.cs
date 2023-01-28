using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;


namespace ExDuiRTest
{
    static class DragObjWindow
    {
        static private ExSkin skin;
        static private ExStatic label1;
        static private ExStatic label2;
        static private ExObjProcDelegate objProc;
        static public void CreateDragObjWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试拖动组件", 0, 0, 500, 500,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnDragMsgProc);
                label1 = new ExStatic(skin, "可拖动组件1", 25, 35, 250, 250, EOS_VISIBLE | EOS_BORDER, EOS_EX_FOCUSABLE, DT_SINGLELINE | DT_VCENTER | DT_CENTER, 0, default, objProc);
                label1.ColorBackground = Util.ExRGB2ARGB(255, 100);
                label2 = new ExStatic(label1, "可拖动组件2", 25, 35, 150, 150, EOS_VISIBLE | EOS_BORDER, EOS_EX_FOCUSABLE, DT_SINGLELINE | DT_VCENTER | DT_CENTER, 0, default, objProc);
                label2.ColorBackground = Util.ExRGB2ARGB(16722680, 100);

                skin.Visible = true;
            }
        }

        static private IntPtr OnDragMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            var obj = new ExControl(hObj);
            if(uMsg == WM_LBUTTONDOWN)
            {
                obj.UserData = lParam;
                obj.SetUIState(STATE_DOWN, false, false);
            }
            else if(uMsg == WM_LBUTTONUP)
            {
                obj.UserData = IntPtr.Zero;
                obj.SetUIState(STATE_DOWN, true, false);
            }
            else if(uMsg == WM_MOUSEMOVE)
            {
                if((obj.UIState & STATE_DOWN)== STATE_DOWN)
                {
                    var userdata = obj.UserData;
                    if(userdata != IntPtr.Zero)
                    {
                        //获取按下位置
                        ExPoint ptOrg = new ExPoint()
                        {
                            x = Util.GET_X_LPARAM(userdata),
                            y = Util.GET_Y_LPARAM(userdata)
                        };
                        //获取当前鼠标位置
                        ExPoint pt = new ExPoint()
                        {
                            x = Util.GET_X_LPARAM(lParam),
                            y = Util.GET_Y_LPARAM(lParam)
                        };
                        var parent = obj.Parent;
                        var rcObj = obj.Rect;
                        ExRect rcParent = new ExRect();
                        if (parent != null)
                        {
                            rcParent = parent.Rect;
                        }
                        else
                        {
                            var skin = ExSkin.FromWindow(hWnd);
                            rcParent = skin.ClientRect;
                        }
                        var x = rcObj.nLeft + pt.x - ptOrg.x;
                        var y = rcObj.nTop + pt.y - ptOrg.y;
                        if (x <= 0)
                        {
                            x = 0;
                        }
                        if (x > rcParent.nRight - rcParent.nLeft - (rcObj.nRight - rcObj.nLeft))
                        {
                            x = rcParent.nRight - rcParent.nLeft - (rcObj.nRight - rcObj.nLeft);
                        }
                        if (y <= 0)
                        {
                            y = 0;
                        }
                        if (y > rcParent.nBottom - rcParent.nTop - (rcObj.nBottom - rcObj.nTop))
                        {
                            y = rcParent.nBottom - rcParent.nTop - (rcObj.nBottom - rcObj.nTop);
                        }
                        obj.SetPos(x, y, 0, 0, IntPtr.Zero, SWP_NOSIZE | SWP_NOZORDER | SWP_NOACTIVATE);
                    }
                }
            }
            return IntPtr.Zero;
        }
    }
}
