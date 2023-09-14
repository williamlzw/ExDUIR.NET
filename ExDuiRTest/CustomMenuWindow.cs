using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace ExDuiRTest
{
    static class CustomMenuWindow
    {
        static private ExSkin skin;
        static private ExButton button;
        static private ExObjEventProcDelegate buttonProc;
        static private ExWndProcDelegate wndProc;
        static private ContextMenu menu;
        static private ExObjProcDelegate buttonMsgProc;

        static public void CreateCustomMenuWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试扩展菜单", 0, 0, 300, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                button = new ExButton(skin, "弹出菜单", 50, 50, 100, 30);
                wndProc = new ExWndProcDelegate(OnMenuWndMsgProc);
                buttonProc = new ExObjEventProcDelegate(OnButtonEvent);
                buttonMsgProc = new ExObjProcDelegate(OnMenuBtnMsgProc);
                button.HandleEvent(NM_CLICK, buttonProc);
                //创建主菜单
                menu = new ContextMenu();
                var menuItem1 = new MenuItem()
                {
                    Text = "Item 1",
                    Checked = true
                };
                
                menu.MenuItems.Add(menuItem1);
                var menuItem2 = new MenuItem()
                {
                    Text = "Disabled Item",
                    Enabled = false
                };
                menu.MenuItems.Add(menuItem2);

                var menuItem3 = new MenuItem()
                {
                    Text = "-",
                };
                menu.MenuItems.Add(menuItem3);

                var menuItem4 = new MenuItem()
                {
                    Text = "More",
                };
                
                var subitem = new MenuItem()
                {
                    Text = "SubItem 1",
                };
                menuItem4.MenuItems.Add(subitem);

                menu.MenuItems.Add(menuItem4);

                skin.Visible = true;
            }
        }

        static private IntPtr OnMenuBtnMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_PAINT)
            {
                ExControl Obj = new ExControl(hObj);
                Obj.BeginPaint(out var ps);
                ExCanvas canvas = new ExCanvas(ps.hCanvas);
                if ((ps.dwState & STATE_DOWN) == STATE_DOWN)
                {
                    canvas.Clear(Util.ExRGB2ARGB(0, 50));
                }
                else if ((ps.dwState & STATE_HOVER) == STATE_HOVER)
                {
                    canvas.Clear(Util.ExRGB2ARGB(0, 20));
                }
                else
                {
                    canvas.Clear(Util.ExRGB2ARGB(0, 0));
                }
                canvas.CalcTextSize(Obj.Font, Obj.Text, -1, ps.dwTextFormat, IntPtr.Zero, ps.nWidth, ps.nHeight, out var nWidthText, out var nHeightText);
                var hImg = (int)Obj.LParam;
                int nWidthIcon = 0;
                int nHeightIcon = 0;
                if (hImg !=0)
                {
                    var image = new ExImage(hImg);
                    image.GetSize(out nWidthIcon, out nHeightIcon);
                    canvas.DrawImage(image, (ps.nWidth - nWidthIcon) / 2, (ps.nHeight - nHeightIcon - nHeightText - 3) / 2, 255);

                }

                canvas.DrawText(Obj.Font, new ExBrush(Obj.ColorTextNormal), Obj.Text, -1, ps.dwTextFormat | DT_CENTER | DT_VCENTER, (ps.nWidth - nWidthText) / 2, (ps.nHeight - nHeightIcon - nHeightText - 3) / 2 + nHeightIcon + 3, (ps.nWidth + nWidthText) / 2, (ps.nHeight - nHeightIcon - nHeightText - 3) / 2 + nHeightIcon + 3 + nHeightText);

                Obj.EndPaint(ref ps);
                Marshal.WriteInt32(pResult, 1);
                return (IntPtr)1;
            }
            else if(uMsg == WM_EX_LCLICK)
            {
                ExControl obj = new ExControl(hObj);
                Console.WriteLine($"点击按钮id：{obj.ID}");
                WinAPI.EndMenu();
                Marshal.WriteInt32(pResult, 1);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnMenuItemMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_ERASEBKGND)
            {
                if((int)Marshal.ReadInt64(lParam, 0) == (int)wParam)
                {
                    var ps = Util.IntPtrToStructure<ExPaintStruct>(lParam);
                    var canvas = new ExCanvas(ps.hCanvas);
                    if (ps.nHeight > 10)
                    {
                        if((ps.dwState & STATE_HOVER) == STATE_HOVER)
                        {
                            canvas.Clear(Util.ExRGB2ARGB(16711680, 100));
                        }
                        else
                        {
                            canvas.Clear(0);
                        }
                        Marshal.WriteInt32(pResult, 1);
                        return (IntPtr)1;
                    }
                }
            }
            else if(uMsg == WM_EX_LCLICK)
            {
                ExControl obj = new ExControl(hObj);
                var text = obj.Text;
                Console.WriteLine($"菜单项目text:{text}");
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnMenuWndMsgProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_INITMENUPOPUP)
            {
                ExRect rc = new ExRect();
                var objproc = new ExObjProcDelegate(OnMenuItemMsgProc);
                if(wParam == menu.Handle)//主菜单
                {
                    WinAPI.SetProp(hWnd, "IsMainMenu", (IntPtr)1);
                    WinAPI.GetWindowRect(hWnd, out rc);
                    WinAPI.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, (int)ExAPI.Ex_Scale(rc.nRight - rc.nLeft + 10), (int)ExAPI.Ex_Scale(rc.nBottom - rc.nTop + 10 + 108), SWP_NOMOVE | SWP_NOZORDER | SWP_NOACTIVATE);
                    rc.nRight = rc.nRight - rc.nLeft - (int)ExAPI.Ex_Scale(10);
                    rc.nBottom = rc.nBottom - rc.nTop - (int)ExAPI.Ex_Scale(10) + (int)ExAPI.Ex_Scale(108);
                    rc.nLeft = (int)ExAPI.Ex_Scale(6);
                    rc.nTop = 40;

                    var btn1 = new ExImage(Properties.Resources.btn1);
                    var button1 = new ExButton(new ExSkin(hExDui), "消息", rc.nLeft, rc.nTop, (int)(rc.nRight * 0.333), (int)ExAPI.Ex_Scale(70), -1, -1, -1, 100, (IntPtr)btn1.handle, buttonMsgProc);
                    var btn2 = new ExImage(Properties.Resources.btn2);
                    var button2 = new ExButton(new ExSkin(hExDui), "收藏", (int)(rc.nLeft + rc.nRight*0.333), rc.nTop, (int)(rc.nRight * 0.333), (int)ExAPI.Ex_Scale(70), -1, -1, -1, 101, (IntPtr)btn2.handle, buttonMsgProc);
                    var btn3 = new ExImage(Properties.Resources.btn3);
                    var button3 = new ExButton(new ExSkin(hExDui), "文件", (int)(rc.nLeft + rc.nRight * 0.666), rc.nTop, (int)(rc.nRight * 0.333), (int)ExAPI.Ex_Scale(70), -1, -1, -1, 102, (IntPtr)btn3.handle, buttonMsgProc);
                    var icondata = Util.BitmapToByte(Properties.Resources.Icon3);
                    var label = new ExStatic(new ExSkin(hExDui), icondata, 0, 0, 45, 38, -1, OBJECT_STYLE_EX_TRANSPARENT | OBJECT_STYLE_EX_TOPMOST);
                    rc.nTop = rc.nTop + (int)ExAPI.Ex_Scale(75);
                    rc.nBottom = rc.nBottom - (int)ExAPI.Ex_Scale(75);
                }
                else
                {
                    //子菜单
                    WinAPI.SetProp(hWnd, "IsMainMenu", IntPtr.Zero);
                    WinAPI.GetWindowRect(hWnd, out rc);
                    WinAPI.SetWindowPos(hWnd, IntPtr.Zero, 0, 0, (int)ExAPI.Ex_Scale(rc.nRight - rc.nLeft + 10), (int)ExAPI.Ex_Scale(rc.nBottom - rc.nTop + 10), SWP_NOMOVE | SWP_NOZORDER | SWP_NOACTIVATE);
                    rc.nRight = rc.nRight - rc.nLeft - (int)ExAPI.Ex_Scale(10);
                    rc.nBottom = rc.nBottom - rc.nTop - (int)ExAPI.Ex_Scale(10);
                    rc.nLeft = (int)ExAPI.Ex_Scale(6);
                    rc.nTop = (int)ExAPI.Ex_Scale(8);
                }
                var nskin = new ExSkin(hExDui);
                var find = nskin.Find(null, "Item", null);
                int t = rc.nTop;
                while (find != null)
                {
                    var rcObj = find.Client;
                    find.Move(rc.nLeft, t, rc.nRight, rcObj.nBottom - rcObj.nTop, true);
                    find.ColorTextNormal = Util.ExRGB2ARGB(0, 255);
                    find.ObjProc = Marshal.GetFunctionPointerForDelegate(objproc);
                    t = t + rcObj.nBottom - rcObj.nTop;
                    find = find.GetObj(GW_HWNDNEXT);
                }
            }
            else if(uMsg == WM_ERASEBKGND)
            {
                var canvas = new ExCanvas((int)wParam);
                canvas.Clear(0);
                if((int)WinAPI.GetProp(hWnd, "IsMainMenu") != 0)
                {
                    var img = new ExImage(Properties.Resources.Main);
                    canvas.DrawImage(img, 0, 0, Util.LOWORD((uint)lParam), Util.HIWORD((uint)lParam), 0, 0, 68, 68, 46, 42, 13, 12, 0, 230);
                    img.Dispose();
                }
                else
                {
                    var img = new ExImage(Properties.Resources.Sub);
                    canvas.DrawImage(img, 0, 0, Util.LOWORD((uint)lParam), Util.HIWORD((uint)lParam), 0, 0, 24, 24, 8, 9, 10, 10, 0, 230);
                    img.Dispose();
                }
                Marshal.WriteInt32(pResult, 1);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(hObj == button.handle)
            {
                WinAPI.GetCursorPos(out var pt);
                button.TrackPopupMenu(menu.Handle, 0, pt.x, pt.y, (IntPtr)hObj, wndProc, MENU_FLAG_NOSHADOW);
            }
            return IntPtr.Zero;
        }
    }
}
