using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class TemplateListView
    {
        struct ListViewItem
        {
            public string title;
            public string text;
            public string btnTitle;
        }

        static private ExSkin skin;
        static private ExTemplateListView templatelistview;
        static private ExGroupBox groupbox;
        static private ExObjProcDelegate listviewProc;
        static private ExObjEventProcDelegate buttonProc;
        static private List<ListViewItem> items;

        static public void CreateTemplateListView(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试模板列表", 0, 0, 800, 600,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                groupbox = new ExGroupBox(skin, "分组框", 10, 40, 780, 550);
                buttonProc = new ExObjEventProcDelegate(OnTemplateListViewItemBtnClick);
                listviewProc = new ExObjProcDelegate(OnTemplateListViewProc);
                items = new List<ListViewItem>();
                for(int i = 0; i < 20; i++)
                {
                    items.Add(new ListViewItem
                    {
                        title = "标签一" + i.ToString(),
                        text = "标签二" + i.ToString(),
                        btnTitle = "按钮" + i.ToString()
                    });
                }
                templatelistview = new ExTemplateListView(groupbox, "", 20, 10, 650, 520, EOS_VISIBLE | EOS_HSCROLL | EOS_VSCROLL | ELVS_ITEMTRACKING, -1, -1, 0, default, listviewProc);
                templatelistview.ItemCount = items.Count;
                templatelistview.ItemHoverColor = Util.ExRGB2ARGB(15066083, 200);
                templatelistview.ItemSelectColor = Util.ExRGB2ARGB(124123, 250);

                skin.Visible = true;
            }
        }

        static private IntPtr OnTemplateListViewItemBtnClick(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            var obj = new ExControl(hObj);
            if(obj.NodeID == 3)
            {
                var item = new ExListItem(obj.Parent.handle);
                var index =  (int)item.GetLong(0);//获得表项当前代表的索引
                if(index > 0 && index <= items.Count)
                {
                    items.RemoveAt(index - 1);
                    Console.WriteLine($"按钮点击删除本行,索引:{index -1}");
                    item.SendMessage(WM_PAINT, IntPtr.Zero, (IntPtr)1);
                }
            }
            if(nCode == NM_DBLCLK)
            {
                Console.WriteLine($"表项双击,索引:{wParam}");
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnTemplateListViewProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_NOTIFY)
            {
                var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                if(ni.hObjFrom == hObj)
                {
                    if(ni.nCode == NM_CALCSIZE)//设置表项尺寸事件 默认为列表框宽度/一行文字的高度
                    {
                        Marshal.WriteInt32(ni.lParam + 4, 60); //偏移0为宽度,4为高度
                        Marshal.WriteInt32(ni.lParam + 12, 0);//纵间距
                        Marshal.WriteInt32(pResult, 1);
                        return (IntPtr)1;
                    }
                    else if(ni.nCode == LVN_ITEMSELECTD)//ni->wParam:当前选中索引   ni->lParam:上次选中索引  索引从1开始
                    {
                        Console.WriteLine($"表项选中改变,当前选中索引:{ni.wParam},上次选中索引:{ni.lParam}");
                    }
                    else if(ni.nCode == LVN_ITEMSELECTC)//ni->wParam:当前选中索引   ni->lParam:上次选中索引  索引从1开始
                    {
                        Console.WriteLine($"表项取消选中,当前选中索引:{ni.wParam},上次选中索引:{ni.lParam}");
                    }
                    else if (ni.nCode == LVN_ITEMCHANGED)//ni->wParam:当前选中索引   ni->lParam:上次选中索引  索引从1开始
                    {
                        Console.WriteLine($"现行选中项被改变,当前选中索引:{ni.wParam},上次选中索引:{ni.lParam}");
                    }
                    else if (ni.nCode == LVN_ITEMRCLICK)//ni->wParam:当前选中索引   ni->lParam:当前选中数目
                    {
                        Console.WriteLine($"表项被右击,当前选中索引:{ni.wParam},当前选中数目:{ni.lParam}");
                    }
                    else if (ni.nCode == LVN_ITEMDCLICK)//ni->wParam:当前选中索引   ni->lParam:上次选中索引  索引从1开始
                    {
                        Console.WriteLine($"表项被双击,当前选中索引:{ni.wParam},上次选中索引:{ni.lParam}");
                    }
                }
            }
            else if(uMsg == TLVM_ITEM_CREATED)
            {
                var obj = new ExControl((int)lParam);
                var obj1 = new ExStatic(obj, "", 0, 6, 128, 28, -1, -1, DT_CENTER | DT_VCENTER);
                obj1.NodeID = 1;
                var obj2 = new ExStatic(obj, "", 130, 6, 358, 28, -1, -1, DT_CENTER | DT_VCENTER);
                obj2.NodeID = 2;
                var obj3 = new ExButton(obj, "", 555, 11, 50, 20, -1, -1);
                obj3.NodeID = 3;
                obj3.HandleEvent(NM_CLICK, buttonProc);
                Marshal.WriteInt32(pResult, 1);
                return (IntPtr)1;
            }
            else if(uMsg == TLVM_ITEM_FILL)
            {
                var index = (int)wParam;
                if(index > 0 && index <= items.Count)
                {
                    var obj = new ExControl((int)lParam);
                    var obj1 = obj.GetObjFromNodeID(1);
                    
                    if (obj1 != null)
                    {
                        obj1.Text = "TEST";
                    }
                    var obj2 = obj.GetObjFromNodeID(2);
                    if (obj2 != null)
                    {
                        obj2.Text = items[index - 1].text;
                    }
                    var obj3 = obj.GetObjFromNodeID(3);
                    if (obj3 != null)
                    {
                        obj3.Text = items[index - 1].btnTitle;
                    }
                }
            }
            return IntPtr.Zero;
        }
    }
}
