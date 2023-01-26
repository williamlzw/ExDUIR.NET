using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class SliderBarWindow
    {
        static private ExSkin skin;
        static private ExSliderBar sliderbar1;
        static private ExSliderBar sliderbar2;
        static private ExSliderBar sliderbar3;
        static private ExSliderBar sliderbar4;
        static private ExObjEventProcDelegate objProc;
        static private ExStatic label;
        static public void CreateSliderBarWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试滑块条", 0, 0, 400, 200,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                objProc = new ExObjEventProcDelegate(OnSliderBarPosChangeEvent);
                sliderbar1 = new ExSliderBar(skin, "", 80, 50, 250, 20);
                sliderbar1.ColorBackground = Util.ExRGBA(100, 36, 255, 250);
                sliderbar1.HandleEvent(SBN_VALUE, objProc);

                sliderbar2 = new ExSliderBar(skin, "", 50, 60, 20, 100, EOS_VISIBLE | ESBS_VERTICAL);
                sliderbar2.ColorBackground = Util.ExRGBA(100, 236, 255, 250);
                sliderbar2.HandleEvent(SBN_VALUE, objProc);
                sliderbar2.BlockDirection = 1;

                sliderbar3 = new ExSliderBar(skin, "", 350, 60, 20, 100, EOS_VISIBLE | ESBS_VERTICAL);
                sliderbar3.ColorBackground = Util.ExRGBA(100, 136, 255, 250);
                sliderbar3.HandleEvent(SBN_VALUE, objProc);
                sliderbar3.ColorTextNormal = Util.ExRGBA(255, 255, 255, 125);
                sliderbar3.ColorTextChecked = Util.ExRGBA(200, 16, 25, 250);

                sliderbar4 = new ExSliderBar(skin, "", 80, 150, 250, 20, -1);
                sliderbar4.ColorBackground = Util.ExRGBA(0, 136, 255, 250);
                sliderbar4.HandleEvent(SBN_VALUE, objProc);
                sliderbar4.BlockDirection = 1;

                label = new ExStatic(skin, "滑块条,当前值是：", 80, 80, 300, 30, -1);
                skin.Visible = true;
            }
        }

        static private IntPtr OnSliderBarPosChangeEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            label.Text = "滑块条,当前值是：" + lParam.ToString();
            return IntPtr.Zero;
        }
    }
}
