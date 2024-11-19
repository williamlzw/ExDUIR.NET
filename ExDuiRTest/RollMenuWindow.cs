using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;
using ExDuiR.NET.Frameworks.Graphics;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class RollMenuWindow
    {
        static private ExSkin skin;
        static private ExRollMenu rollmenu;
        static private ExObjEventProcDelegate rollmenuProc;
        static private ExObjEventProcDelegate buttonProc;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExButton button4;
        static private ExButton button5;
        static private ExButton button6;
        static private ExWndProcDelegate wndProc;
        static private ExImageList imglist;
        static public void CreateRollMenuWindow(ExSkin pOwner)
        {
            wndProc = new ExWndProcDelegate(OnWndMsgProc);
            skin = new ExSkin(pOwner, null, "测试卷帘菜单", 0, 0, 500, 500,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW, 0, 0, default, wndProc);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                rollmenu = new ExRollMenu(skin, "", 30, 50, 220, 400);
                
                rollmenuProc = new ExObjEventProcDelegate(OnRollMenuEvent);
                rollmenu.HandleEvent(ROLLMENU_EVENT_CLICK, rollmenuProc);
                button1 = new ExButton(skin, "删除分组", 280, 150, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                button2 = new ExButton(skin, "删除子项", 280, 200, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                button3 = new ExButton(skin, "展开分组", 280, 250, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                button4 = new ExButton(skin, "收缩分组", 280, 300, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                button5 = new ExButton(skin, "取现行选中子项", 280, 350, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                button6 = new ExButton(skin, "置现行选中子项", 280, 400, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttonProc = new ExObjEventProcDelegate(OnRollMenuBtnEvent);
                button1.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_CLICK, buttonProc);
                button3.HandleEvent(NM_CLICK, buttonProc);
                button4.HandleEvent(NM_CLICK, buttonProc);
                button5.HandleEvent(NM_CLICK, buttonProc);
                button6.HandleEvent(NM_CLICK, buttonProc);
                imglist = new ExImageList(32, 32);
                var accountIndex = imglist.AddImage(new ExImage(Properties.Resources.account), 0);
                var videoIndex = imglist.AddImage(new ExImage(Properties.Resources.video), 0);
                var infoIndex = imglist.AddImage(new ExImage(Properties.Resources.info), 0);
                var fansIndex = imglist.AddImage(new ExImage(Properties.Resources.fans), 0);
                var authorizationIndex = imglist.AddImage(new ExImage(Properties.Resources.authorization), 0);
                List<int> emoji = new List<int>();

                var index1 = imglist.AddImage(new ExImage(Properties.Resources.nav1), 0);
                emoji.Add(index1);
                var index2 = imglist.AddImage(new ExImage(Properties.Resources.nav2), 0);
                emoji.Add(index2);
                var index3 = imglist.AddImage(new ExImage(Properties.Resources.nav3), 0);
                emoji.Add(index3);
                var index4 = imglist.AddImage(new ExImage(Properties.Resources.nav4), 0);
                emoji.Add(index4);
                ExRollMenuGroup rollmenugroup1 = new ExRollMenuGroup
                {
                    title = Marshal.StringToHGlobalUni("账号信息"),
                    stateIcon = new ExRollMenuStateIcon
                    {
                        eicon = imglist.Get(accountIndex).handle,
                        sicon = imglist.Get(accountIndex).handle,
                        rc = new ExRect{ nLeft = 40, nTop = 4, nRight= 72, nBottom = 36 }
                    }
                };
                rollmenu.AddGroup(0, rollmenugroup1);

                ExRollMenuGroup rollmenugroup2 = new ExRollMenuGroup
                {
                    title = Marshal.StringToHGlobalUni("视频管理"),
                    stateIcon = new ExRollMenuStateIcon
                    {
                        eicon = imglist.Get(videoIndex).handle,
                        sicon = imglist.Get(videoIndex).handle,
                        rc = new ExRect { nLeft = 40, nTop = 4, nRight = 72, nBottom = 36 }
                    }
                };
                var groupVideoIndex = rollmenu.AddGroup(0, rollmenugroup2);
                ExRollMenuItem rollmenuitem1 = new ExRollMenuItem
                {
                    title = Marshal.StringToHGlobalUni("视频权限"),
                    stateIcon = new ExRollMenuStateIcon
                    {
                        eicon = imglist.Get(authorizationIndex).handle,
                        sicon = imglist.Get(authorizationIndex).handle,
                        rc = new ExRect { nLeft = 55, nTop = 0, nRight = 83, nBottom = 28 }
                    }
                };
                rollmenu.AddItem(groupVideoIndex, rollmenuitem1);

                ExRollMenuItem rollmenuitem2 = new ExRollMenuItem
                {
                    title = Marshal.StringToHGlobalUni("视频列表"),
                };
                rollmenu.AddItem(groupVideoIndex, rollmenuitem2);

                ExRollMenuGroup rollmenugroup3 = new ExRollMenuGroup
                {
                    title = Marshal.StringToHGlobalUni("数据分析"),
                    stateIcon = new ExRollMenuStateIcon
                    {
                        eicon = imglist.Get(infoIndex).handle,
                        sicon = imglist.Get(infoIndex).handle,
                        rc = new ExRect { nLeft = 40, nTop = 4, nRight = 72, nBottom = 36 }
                    }
                };
                rollmenu.AddGroup(0, rollmenugroup3);

                ExRollMenuGroup rollmenugroup4 = new ExRollMenuGroup
                {
                    title = Marshal.StringToHGlobalUni("粉丝画像分析"),
                    stateIcon = new ExRollMenuStateIcon
                    {
                        eicon = imglist.Get(fansIndex).handle,
                        sicon = imglist.Get(fansIndex).handle,
                        rc = new ExRect { nLeft = 40, nTop = 4, nRight = 72, nBottom = 36 }
                    }
                };
                var groupFansIndex = rollmenu.AddGroup(0, rollmenugroup4);
                Random rnd = new Random();  
                for(int i = 0; i < 20; i++)
                {
                    ExRollMenuItem rollmenuitem = new ExRollMenuItem
                    {
                        title = Marshal.StringToHGlobalUni("粉丝_" + (i + 1).ToString()),
                        extraIcon = new ExRollMenuExtraIcon
                        {
                            icon = imglist.Get(emoji[rnd.Next(0, 3)]).handle,
                            rc = new ExRect { nLeft = 160, nTop = 2, nRight = 188, nBottom = 30 }
                        }
                    };
                    rollmenu.AddItem(groupFansIndex, rollmenuitem);
                }

                skin.Visible = true;
            }
        }
        static private IntPtr OnWndMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if(uMsg == WM_CLOSE)
            {
                imglist.Dispose();
            }
            return IntPtr.Zero;
        }
        static public IntPtr OnRollMenuBtnEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(hObj == button1.handle)
            {
                rollmenu.DelGroup(3);
            }
            else if (hObj == button2.handle)
            {
                rollmenu.DelItem(4, 2);
            }
            else if (hObj == button3.handle)
            {
                rollmenu.SetExpand(2, true);
            }
            else if (hObj == button4.handle)
            {
                rollmenu.SetExpand(2, false);
            }
            else if (hObj == button5.handle)
            {
                int group = 0;
                int item = 0;
                rollmenu.GetSel(ref group, ref item);
                Console.WriteLine($"所在分组:{group},选中子项:{item}");
            }
            else if (hObj == button6.handle)
            {
                rollmenu.SetSel(4, 2);
            }
            return IntPtr.Zero;
        }

        static public IntPtr OnRollMenuEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == ROLLMENU_EVENT_CLICK)
            {
                Console.WriteLine($"RollMenu单击子项,子项:{wParam},所在分组:{lParam}");
            }
            return IntPtr.Zero;
        }
    }
}
