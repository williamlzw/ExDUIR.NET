using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Diagnostics;
using ExDuiR.NET.Frameworks.Graphics;

namespace ExDuiRTest
{
    static class DrawingBoardWindow
    {
        static private ExSkin skin;
        static private ExDrawingBoard drawingboard;
        static private ExSwitch switch1;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExButton button4;
        static private ExObjEventProcDelegate objProc;
        static private ExObjEventProcDelegate switchProc;

        static public void CreateDrawingBoardWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试鼠标绘制板", 0, 0, 680, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                drawingboard = new ExDrawingBoard(skin, "", 30, 30, 500, 350);
                objProc = new ExObjEventProcDelegate(OnButtonEventProc);
                switchProc = new ExObjEventProcDelegate(OnDrawingBoardSwitchEvent);
                switch1 = new ExSwitch(skin, "画笔|橡皮擦", 550, 30, 100, 30);
                switch1.Check = true;
                switch1.HandleEvent(NM_CHECK, switchProc);

                button1 = new ExButton(skin, "清空绘制板", 550, 70, 100, 30);
                button2 = new ExButton(skin, "改变画刷大小", 550, 110, 100, 30);
                button3 = new ExButton(skin, "改变画刷颜色", 550, 150, 100, 30);
                button4 = new ExButton(skin, "保存到图片", 550, 190, 100, 30);
                button1.HandleEvent(NM_CLICK, objProc);
                button2.HandleEvent(NM_CLICK, objProc);
                button3.HandleEvent(NM_CLICK, objProc);
                button4.HandleEvent(NM_CLICK, objProc);

                skin.Visible = true;
            }
        }

        static public IntPtr OnDrawingBoardSwitchEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == NM_CHECK)
            {
                if(wParam!=IntPtr.Zero)
                {
                    drawingboard.PenType = 0;
                }
                else
                {
                    drawingboard.PenType = 1;
                }
            }
            return IntPtr.Zero;
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == NM_CLICK)
            {
                if(hObj == button1.handle)
                {
                    drawingboard.Clear();
                }
                else if(hObj == button2.handle)
                {
                    drawingboard.PenWidth = 5;
                }
                else if (hObj == button3.handle)
                {
                    drawingboard.PenColor = Util.ExRGBA(255, 0, 0, 255);
                }
                else if (hObj == button4.handle)
                {
                    var canvas = drawingboard.Canvas;
                    var image = new ExImage(canvas);
                    image.SaveToFile("d:/save_drawingboard.png");
                    image.Dispose();
                }
            }
            return IntPtr.Zero;
        }
    }
}
