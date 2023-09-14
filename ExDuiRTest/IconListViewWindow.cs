using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class IconListViewWindow
    {
        static private ExSkin skin;
        static private ExIconListView iconListView;
        static private ExImageList imglist;

        static public void CreateIconListViewWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试图标列表", 0, 0, 500, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                iconListView = new ExIconListView(skin, "", 25, 50, 400, 225, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_HSCROLL | OBJECT_STYLE_VSCROLL | ICONLISTVIEW_STYLE_BUTTON);
                imglist = new ExImageList(36, 36);
                imglist.AddImage(new ExImage(Properties.Resources.close), 0);
                imglist.AddImage(new ExImage(Properties.Resources.closehover), 0);
                imglist.AddImage(new ExImage(Properties.Resources.closeban), 0);
                iconListView.SetImageList(imglist);
                for(int i = 1; i<= 1000; i++)
                {
                    ExIconListViewItemInfo info = new ExIconListViewItemInfo
                    {
                        nIndex = i,
                        pwzText = Marshal.StringToHGlobalUni("第" + i.ToString() +"项"),
                        nImageIndex = i % 3,
                    };
                    if(info.nImageIndex == 0)
                    {
                        info.nImageIndex = 3;
                    }
                    iconListView.SetItem(info);
                }
                iconListView.Update();

                skin.Visible = true;
            }
        }
    }
}
