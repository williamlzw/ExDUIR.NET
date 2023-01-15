using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class NavButtonWindow
    {
        static private ExSkin skin;
        static private ExNavButton navButton1;
        static private ExNavButton navButton2;
        static private ExNavButton navButton3;
        static private ExNavButton navButton4;
        static private ExObjEventProcDelegate buttonProc;
        static private ExPage pageContainer;
        static private ExPageLayout layout;
        static private List<ExStatic> pages;

        static public void CreateNavButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试选项卡", 0, 0, 800, 600,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGB2ARGB(0, 255);
                navButton1 = new ExNavButton(skin, "", 20, 40, 80, 80);
                navButton2 = new ExNavButton(skin, "", 105, 40, 80, 80);
                navButton3 = new ExNavButton(skin, "", 190, 40, 80, 80);
                navButton4 = new ExNavButton(skin, "", 275, 40, 80, 80);
                var icon1 = new ExImage(Properties.Resources.nav1);
                var icon2 = new ExImage(Properties.Resources.nav2);
                var icon3 = new ExImage(Properties.Resources.nav3);
                var icon4 = new ExImage(Properties.Resources.nav4);
                var navbkg1 = new ExImage(Properties.Resources.navbkg1);
                var navbkg2 = new ExImage(Properties.Resources.navbkg2);

                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                navButton1.SetIcon(icon1);
                navButton1.SetImage(1, navbkg1);
                navButton1.SetImage(2, navbkg2);
                navButton1.LParam = (IntPtr)1;
                navButton2.SetIcon(icon2);
                navButton2.SetImage(1, navbkg1);
                navButton2.SetImage(2, navbkg2);
                navButton2.LParam = (IntPtr)2;
                navButton3.SetIcon(icon3);
                navButton3.SetImage(1, navbkg1);
                navButton3.SetImage(2, navbkg2);
                navButton3.LParam = (IntPtr)3;
                navButton4.SetIcon(icon4);
                navButton4.SetImage(1, navbkg1);
                navButton4.SetImage(2, navbkg2);
                navButton4.LParam = (IntPtr)4;

                navButton1.HandleEvent(NM_CHECK, buttonProc);
                navButton2.HandleEvent(NM_CHECK, buttonProc);
                navButton3.HandleEvent(NM_CHECK, buttonProc);
                navButton4.HandleEvent(NM_CHECK, buttonProc);
               
                pageContainer = new ExPage(skin, "", 20, 120, 760, 460);
                layout = new ExPageLayout(pageContainer);
                pages = new List<ExStatic>();
                Random rn = new Random();
                for(int i = 0; i < 4; i++)
                {
                    pages.Add(new ExStatic(pageContainer, "页面" + i.ToString(), 0, 0, 760, 460, DT_CENTER | DT_VCENTER));
                    pages[i].SetFont("宋体", 40);
                    pages[i].ColorBackground = Util.ExRGB2ARGB(rn.Next(0, 16777215), 255);
                    pages[i].ColorTextNormal = Util.ExRGB2ARGB(16777215, 255);
                    layout.AddChild(pages[i]);
                }
                pageContainer.SetLayout(layout);
                layout.Current = 1;
                navButton1.Check = true;

                skin.Visible = true;
            }
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(lParam != IntPtr.Zero)
            {
                if (hObj == navButton1.handle)
                {
                    layout.Current = (int)navButton1.LParam;
                    Console.WriteLine(layout.Current);
                }
                else if (hObj == navButton2.handle)
                {
                    layout.Current = (int)navButton2.LParam;
                }
                else if (hObj == navButton3.handle)
                {
                    layout.Current = (int)navButton3.LParam;
                }
                else if (hObj == navButton4.handle)
                {
                    layout.Current = (int)navButton4.LParam;
                }
                layout.Update();
            }
            return IntPtr.Zero;
        }
    }
}
