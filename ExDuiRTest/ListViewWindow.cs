using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class ListViewWindow
    {
        class LISTVIEW_ITEM
        {
            public string text { get; set; }
            public int color { get; set; }
            public int depth { get; set; }
        }
        static private ExSkin skin;
        static private ExListView listview;
        static private ExObjProcDelegate listviewProc;
        static private ExObjProcDelegate scrollbarProc;
        static private List<LISTVIEW_ITEM> listviewItemInfo;
        const int SBM_SETVISIBLE = 56212;

        static public void CreateListViewWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试列表框", 0, 0, 200, 200,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                listviewProc = new ExObjProcDelegate(OnListViewProc);
                listview = new ExListView(skin, "", 30, 30, 150, 150, EOS_VISIBLE | ELVS_VERTICALLIST | EOS_VSCROLL, EOS_EX_COMPOSITED, -1, 0, default, listviewProc);
                listview.ColorBackground = Util.ExRGBA(120, 255, 240, 150);
                listviewItemInfo = new List<LISTVIEW_ITEM>();
                Random rn = new Random();
                for (int i = 0; i < 100; i++)
                {
                    LISTVIEW_ITEM info = new LISTVIEW_ITEM();
                    info.text = "列表项" + i.ToString();
                    info.depth = i % 5;

                    info.color = Util.ExRGB2ARGB(rn.Next(13777215, 16777215), 255);
                    listviewItemInfo.Add(info);
                }
                listview.SetItemCount(listviewItemInfo.Count);
                //取出列表框内部滚动条
                var scroll = new ExScrollBar(listview.GetScrollControl(SB_VERT));
                
                scrollbarProc = new ExObjProcDelegate(OnScrollBarMsg);
                //改变内部滚动条回调
                scroll.ObjProc = Marshal.GetFunctionPointerForDelegate(scrollbarProc);
                //隐藏滚动条
                scroll.PostMessage(SBM_SETVISIBLE, IntPtr.Zero, IntPtr.Zero);
                
                skin.Visible = true;
            }
        }

        static public IntPtr OnScrollBarMsg(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            //实例化滚动条
            var obj = new ExScrollBar(hObj);
            if (uMsg == WM_MOUSEHOVER)
            {
                //显示滚动条
                obj.PostMessage(SBM_SETVISIBLE, IntPtr.Zero, (IntPtr)1);
            }
            else if (uMsg == WM_MOUSELEAVE)
            {
                //隐藏滚动条
                obj.PostMessage(SBM_SETVISIBLE, IntPtr.Zero, IntPtr.Zero);
            }
            else if (uMsg == SBM_SETVISIBLE)
            {
                obj.Alpha = ((int)lParam != 0 ? 255 : 0);
                obj.Invalidate();
            }
            return IntPtr.Zero;
        }

        static public IntPtr OnListViewProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_NOTIFY)
            {
                var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                if (hObj == ni.hObjFrom)
                {
                    if (ni.nCode == NM_CALCSIZE)
                    {
                        //改变项目高度, ni.lParam是ExListViewInfo结构体
                        Marshal.WriteInt32(ni.lParam + 4, 40);
                        return (IntPtr)1;
                    }
                    else if (ni.nCode == NM_CUSTOMDRAW)
                    {
                        var cd = Util.IntPtrToStructure<ExCustomDraw>(ni.lParam);
                        var canvas = new ExCanvas(cd.hCanvas);
                        int color = 0;
                        if ((cd.dwState & STATE_SELECT) == STATE_SELECT)
                        {
                            color = Util.ExRGB2ARGB(16777215, 255);
                        }
                        else if ((cd.dwState & STATE_HOVER) == STATE_HOVER)
                        {
                            color = Util.ExRGB2ARGB(16777215, 150);
                        }
                        if (color != 0)
                        {
                            var brush = new ExBrush(color);
                            canvas.FillRect(brush, cd.nLeft, cd.nTop, cd.nRight, cd.nBottom);
                            brush.Dispose();
                        }
                        //实例化列表框项目
                        ExListItem item = new ExListItem(hObj);
                        canvas.DrawText(item.Font, listviewItemInfo[cd.iItem - 1].color, listviewItemInfo[cd.iItem - 1].text, -1, DT_SINGLELINE | DT_VCENTER, cd.nLeft + listviewItemInfo[cd.iItem - 1].depth * 5, cd.nTop, cd.nRight, cd.nBottom);
                        return (IntPtr)1;
                    }
                    else if (ni.nCode == LVN_ITEMCHANGED)
                    {
                        Console.WriteLine($"改变选中ID:{ni.idFrom},新选中项:{ni.wParam},旧选中项:{ni.lParam}");
                    }
                }
            }
            return IntPtr.Zero;
        }
    }
}
