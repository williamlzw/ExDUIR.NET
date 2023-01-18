using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class ListButtonWindow
    {
        static private ExSkin skin;
        static private ExMenuBar menubar;
        static private ExMenuBar menubar2;
        static private ExToolBar toolbar;
        static private ExStatusBar statusbar;
        static private ExImageList imglist;
        static private ExObjProcDelegate listButtonProc;
        static private ExWndProcDelegate listButtonWndProc;
        static private ExObjEventProcDelegate listButtonEventProc;
        static public void CreateListButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试列表按钮", 0, 0, 480, 200,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);

                Dictionary<string, List<string>> itemInfo = new Dictionary<string, List<string>>();
                //分隔条用"-"
                itemInfo.Add("文件(&F)", new List<string> { "新建(&N)", "打开(&O)", "保存(&S)", "-", "退出(&E)" });
                itemInfo.Add("编辑(&E)", new List<string> { "剪切(&T)", "复制(&C)", "粘贴(&P)", "-", "撤销(&U)", "重做(&R)" });
                //快捷键和标题之间用\t
                itemInfo.Add("选项(&O)", new List<string> { "设置(&S)\tCtrl+S" });
                itemInfo.Add("帮助(&H)", new List<string> { "关于(&A)", "文档(&D)", "Git" });

                List<string> subItem2Str = new List<string> { "https://gitee.com/william_lzw/ExDUIR", "https://github.com/williamlzw/ExDUIR" };
                List<string> enableItemKey = new List<string> { "粘贴(&P)", "撤销(&U)", "重做(&R)" };
                List<string> subItemKey = new List<string> { "Git" };
                //创建主菜单
                var mainMenu = new MainMenu();
                foreach (var index in itemInfo)
                {
                    //创建一级菜单
                    var menuItem = new MenuItem();
                    menuItem.Name = index.Key;
                    foreach (var itemIndex in index.Value)
                    {
                        //添加一级菜单项目
                        var subItem = new MenuItem(itemIndex);
                        if (enableItemKey.Contains(itemIndex))
                        {
                            //禁用项目
                            subItem.Enabled = false;
                        }
                        if (subItemKey.Contains(itemIndex))
                        {
                            //添加二级菜单
                            foreach (var subItem2Index in subItem2Str)
                            {
                                //添加二级菜单项目
                                var subItem2 = new MenuItem(subItem2Index);
                                //一级菜单项目添加二级菜单条目
                                subItem.MenuItems.Add(subItem2);
                            }
                        }
                        menuItem.MenuItems.Add(subItem);
                    }
                    //一级菜单加入主菜单
                    mainMenu.MenuItems.Add(menuItem);
                }

                menubar = new ExMenuBar(skin, "", 0, 30, 220, 22);
                menubar.ColorTextNormal = Util.ExRGB2ARGB(0, 255);
                menubar.ColorTextHover = Util.ExRGB2ARGB(16774117, 255);
                menubar.ColorTextDown = Util.ExRGB2ARGB(16765337, 255);

                listButtonProc = new ExObjProcDelegate(OnListButtonMsgProc);
                listButtonWndProc = new ExWndProcDelegate(OnListButtonWndProc);
                menubar2 = new ExMenuBar(skin, "", 0, 60, 220, 22, -1, -1, -1, 0, IntPtr.Zero, listButtonProc);
                menubar2.ColorBackground = Util.ExRGBA(110, 120, 55, 255);//改变菜单按钮背景色
                menubar2.ColorTextNormal = Util.ExRGBA(255, 255, 255, 255);//改变菜单按钮字体正常色
                menubar2.ColorTextHover = Util.ExRGBA(255, 255, 255, 55);//改变菜单按钮字体热点色
                menubar2.ColorTextDown = Util.ExRGBA(255, 255, 255, 100);//改变菜单按钮字体按下色

                //列表按钮插入一级菜单句柄
                foreach (MenuItem index in mainMenu.MenuItems)
                {
                    ExListButtonItemInfo item1info = new ExListButtonItemInfo()
                    {
                        wzText = Marshal.StringToHGlobalUni(index.Name),
                        nMenu = index.Handle
                    };

                    //把一级菜单句柄加入列表按钮
                    menubar.InsertItem(item1info);
                    menubar2.InsertItem(item1info);
                }

                var bitmap = Properties.Resources.icon;
                ExImage image = new ExImage(bitmap);
                image.Scale(24, 24, out var smallImg);
                IntPtr smallImgData = Marshal.AllocHGlobal(24 * 24 * 4);
                smallImg.SaveToMemory(smallImgData);
                var hBitmap = Util.IntPtrToBitmap(smallImgData, 24 * 24 * 4);
                WinAPI.MENUITEMINFO minfo = new WinAPI.MENUITEMINFO();
                minfo.cbSize = Marshal.SizeOf(minfo);
                minfo.fMask = 128;
                var ret = WinAPI.GetMenuItemInfo(mainMenu.MenuItems[3].Handle, 2, true, ref minfo);
                if (minfo.hbmpItem != IntPtr.Zero)
                {
                    WinAPI.DeleteObject(minfo.hbmpItem);
                }
                minfo.hbmpItem = hBitmap;
                ret = WinAPI.SetMenuItemInfo(mainMenu.MenuItems[3].Handle, 2, true, ref minfo);
                smallImg.Dispose();
                image.Dispose();

                toolbar = new ExToolBar(skin, "", 0, 90, 400, 22);
                toolbar.ColorTextNormal = Util.ExRGB2ARGB(0, 255);
                toolbar.ColorTextHover = Util.ExRGB2ARGB(16774117, 255);
                toolbar.ColorTextDown = Util.ExRGB2ARGB(16765337, 255);

                imglist = new ExImageList(18, 18);
                ExImage image2 = new ExImage(bitmap);
                var nImageIndex = imglist.AddImage(image2, 0);
                toolbar.SetImageList(imglist);
                ExListButtonItemInfo item1info2 = new ExListButtonItemInfo()
                {
                    nType = 1,
                    nImage = nImageIndex,
                    wzText = IntPtr.Zero,
                    wzTips = Marshal.StringToHGlobalUni("普通按钮1")
                };
                toolbar.InsertItem(item1info2);
                item1info2.nType = 1;
                item1info2.nImage = 0;
                item1info2.wzText = Marshal.StringToHGlobalUni("普通按钮不带图标");
                item1info2.wzTips = Marshal.StringToHGlobalUni("普通按钮不带图标");
                toolbar.InsertItem(item1info2);
                item1info2.nType = 2;
                item1info2.nImage = nImageIndex;
                item1info2.wzText = IntPtr.Zero;
                item1info2.wzTips = Marshal.StringToHGlobalUni("选择按钮");
                toolbar.InsertItem(item1info2);
                item1info2.nType = 2;
                item1info2.nImage = 0;
                item1info2.wzText = Marshal.StringToHGlobalUni("选择按钮不带图标");
                item1info2.wzTips = Marshal.StringToHGlobalUni("选择按钮不带图标");
                toolbar.InsertItem(item1info2);
                item1info2.nType = 0;
                item1info2.nImage = 0;
                item1info2.wzText = IntPtr.Zero;
                item1info2.wzTips = IntPtr.Zero;
                item1info2.dwState = STATE_NORMAL;
                toolbar.InsertItem(item1info2);
                item1info2.nType = 1;
                item1info2.nImage = nImageIndex;
                item1info2.wzText = Marshal.StringToHGlobalUni("禁用按钮带图标");
                item1info2.wzTips = Marshal.StringToHGlobalUni("禁用按钮带图标");
                item1info2.dwState = STATE_DISABLE;
                toolbar.InsertItem(item1info2);

                listButtonEventProc = new ExObjEventProcDelegate(OnListButtonEvent);
                toolbar.HandleEvent(LBN_CLICK, listButtonEventProc);
                toolbar.HandleEvent(LBN_CHECK, listButtonEventProc);


                statusbar = new ExStatusBar(skin, "", 0, 120, 300, 22);
                statusbar.ColorBackground = Util.ExRGB2ARGB(12557930, 255);
                statusbar.ColorBorder = Util.ExRGBA(255, 255, 255, 255);
                statusbar.ColorTextNormal = Util.ExRGBA(255, 255, 255, 255);

                ExListButtonItemInfo item1info3 = new ExListButtonItemInfo();
                item1info3.nWidth = 100;
                item1info3.iTextFormat = DT_LEFT;
                item1info3.wzText = Marshal.StringToHGlobalUni("左对齐");
                statusbar.InsertItem(item1info3);
                item1info3.nWidth = 100;
                item1info3.iTextFormat = DT_CENTER;
                item1info3.wzText = Marshal.StringToHGlobalUni("居中");
                statusbar.InsertItem(item1info3);
                item1info3.nWidth = 100;
                item1info3.iTextFormat = DT_RIGHT;
                item1info3.nIndex = 2;
                item1info3.wzText = Marshal.StringToHGlobalUni("右对齐");
                statusbar.InsertItem(item1info3);
                skin.Visible = true;
            }
        }

        static private IntPtr OnListButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode == LBN_CLICK)
            {
                Console.WriteLine($"点击项目索引:{wParam}");
            }
            else if (nCode == LBN_CHECK)
            {
                Console.WriteLine($"选择项目索引:{wParam},状态:{lParam}");
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnListButtonWndProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr lpResult)
        {
            if (uMsg == WM_NOTIFY)
            {
                var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                if (ni.nCode == NM_CREATE)
                {
                    var menubar = new ExMenuBar(ni.hObjFrom);
                    menubar.ColorTextNormal = Util.ExRGBA(210, 120, 55, 255);//改变菜单项目字体正常颜色
                    menubar.ColorTextHover = Util.ExRGB2ARGB(16711680, 255);//改变菜单项目字体悬浮颜色
                    menubar.ColorBackground = Util.ExRGBA(110, 120, 55, 255);//改变菜单项目背景颜色
                }
            }
            else if (uMsg == MN_SELECTITEM && (int)wParam == -1)//恢复正常状态
            {
                WinAPI.GetCursorPos(out var point);
                var currentWnd = WinAPI.WindowFromPoint(point);
                WinAPI.ScreenToClient(currentWnd, ref point);
                var obj = skin.GetObjFromPoint(point.x, point.y, (int)currentWnd);
                var menuBar = new ExMenuBar(obj.handle);
                menuBar.PostMessage(LBM_SELECTITEM, IntPtr.Zero, IntPtr.Zero);
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnListButtonMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr lpResult)
        {
            if (uMsg == LBM_DOWNITEM)
            {
                var rcWindow = skin.WindowRect;
                ExMenuBar button = new ExMenuBar(hObj);
                var rcObj = button.WindowRect;
                button.TrackPopupMenu(lParam, 1, rcWindow.nLeft + rcObj.nLeft + (int)wParam, rcWindow.nTop + rcObj.nBottom, IntPtr.Zero, listButtonWndProc, EMNF_NOSHADOW);
                Marshal.WriteInt32(lpResult, 1);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }
    }
}
