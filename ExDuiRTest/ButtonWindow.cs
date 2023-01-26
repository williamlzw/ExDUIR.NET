using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class ButtonWindow
    {
        static private ExSkin skin;
        static private ExButton[] buttons;
        static private ExSwitch[] switchs;
        static private ExObjEventProcDelegate objEvent;
        static private ExObjProcDelegate objProc;

        static public void CreateButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试按钮开关", 0, 0, 300, 200,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnButtonMsgProc);
                buttons = new ExButton[6];
                buttons[0] = new ExButton(skin, "禁用自身", 10, 30, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[1] = new ExButton(skin, "解除按钮1禁用", 10, 70, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[2] = new ExButton(skin, "改动自身文本", 10, 110, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[3] = new ExButton(skin, "取按钮1文本", 10, 150, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[4] = new ExButton(skin, "重画按钮1", 150, 30, 120, 30, -1, EOS_EX_FOCUSABLE | EOS_EX_CUSTOMDRAW | EOS_EX_COMPOSITED, DT_VCENTER | DT_CENTER);
                buttons[5] = new ExButton(skin, "重画按钮2", 150, 70, 120, 30, -1,
                    EOS_EX_FOCUSABLE | EOS_EX_CUSTOMDRAW | EOS_EX_COMPOSITED, DT_VCENTER | DT_CENTER, 0, default, objProc);
                objEvent = new ExObjEventProcDelegate(OnButtonEventProc);
                foreach (var button in buttons)
                {
                    button.HandleEvent(NM_CLICK, objEvent);
                }
                buttons[4].HandleEvent(NM_CUSTOMDRAW, objEvent);

                switchs = new ExSwitch[2];
                switchs[0] = new ExSwitch(skin, "已开启|已关闭", 150, 110, 80, 30);
                switchs[1] = new ExSwitch(skin, "", 150, 150, 60, 30);
                switchs[1].Check = true;
                ExObjProps props = new ExObjProps()
                {
                    crBkgNormal = Util.ExRGBA(255, 255, 255, 100),
                    crBkgDownOrChecked = Util.ExRGBA(200, 50, 100, 100),
                    crBorderNormal = Util.ExRGBA(255, 255, 255, 255),
                    radius = 15,
                    strokeWidth = 1
                };
                switchs[1].Props = props;
                switchs[1].HandleEvent(NM_CHECK, objEvent);
                skin.Visible = true;
            }
        }

        static public IntPtr OnButtonMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_ERASEBKGND)
            {
                ExPaintStruct ps = Util.IntPtrToStructure<ExPaintStruct>(lParam);
                int crBkg;
                if ((ps.dwState & STATE_DOWN) == STATE_DOWN)
                {
                    crBkg = Util.ExRGBA(255, 0, 0, 51);
                }
                else if ((ps.dwState & STATE_HOVER) == STATE_HOVER)
                {
                    crBkg = Util.ExRGBA(255, 168, 255, 51);
                }
                else
                {
                    crBkg = Util.ExRGBA(255, 255, 255, 51);
                }
                ExBrush hBrush = new ExBrush(crBkg);
                ExCanvas hCanvas = new ExCanvas(ps.hCanvas);
                hCanvas.FillRect(hBrush, 0, 0, ps.rcPaint.nRight, ps.rcPaint.nBottom);
                hBrush.Dispose();
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (hObj == buttons[0].handle)
            {
                buttons[0].Enable = false;
                buttons[0].SetPadding(0, 20, 5, 5, 5);
            }
            else if (hObj == buttons[1].handle)
            {
                buttons[0].Enable = true;
            }
            else if (hObj == buttons[2].handle)
            {
                buttons[2].Text = "自身文本被改动";
            }
            else if (hObj == buttons[3].handle)
            {
                buttons[3].Text = "按钮1文本:" + buttons[0].Text;
            }
            else if (hObj == buttons[4].handle)
            {
                if (nCode == NM_CUSTOMDRAW)
                {
                    ExPaintStruct ps = Util.IntPtrToStructure<ExPaintStruct>(lParam);
                    int crBkg;
                    if ((ps.dwState & STATE_DOWN) != 0)
                    {
                        crBkg = Util.ExRGBA(255, 0, 0, 51);
                    }
                    else if ((ps.dwState & STATE_HOVER) != 0)
                    {
                        crBkg = Util.ExRGBA(255, 168, 255, 51);
                    }
                    else
                    {
                        crBkg = Util.ExRGBA(255, 255, 255, 51);
                    }
                    ExBrush hBrush = new ExBrush(crBkg);
                    ExCanvas hCanvas = new ExCanvas(ps.hCanvas);
                    hCanvas.FillRect(hBrush, 0, 0, ps.rcPaint.nRight, ps.rcPaint.nBottom);
                    hBrush.Dispose();
                }
                return (IntPtr)1;
            }
            else if (hObj == switchs[1].handle)
            {
                if (wParam != IntPtr.Zero)
                {
                    ExMessageBox.Show(skin, "开启", "取开关状态", MB_USERICON, EMBF_CENTEWINDOW);
                }
                else
                {
                    ExMessageBox.Show(skin, "关闭", "取开关状态", MB_ICONWARNING, EMBF_CENTEWINDOW);
                }
            }
            return IntPtr.Zero;
        }
    }
}
