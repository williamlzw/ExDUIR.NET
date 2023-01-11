using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class MainWindow
    {
        static private ExApp theApp;
        static private ExSkin skin;
        static private List<ExButton> buttons;
        static private ExObjEventProcDelegate buttonEventProc;
        static public void CreateMainWindow()
        {
            //读入主题包
            var theme = Properties.Resources.Default;
            //初始化引擎,必须
            theApp = new ExApp(theme);
            //创建窗口皮肤,必须
            skin = new ExSkin(null, null, "ExDUIR演示,项目地址：https://gitee.com/william_lzw/ExDUIR", 0, 0, 600, 600,
            EWS_MAINWINDOW | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_BUTTON_MAX | EWS_MOVEABLE | EWS_CENTERWINDOW |
            EWS_ESCEXIT | EWS_TITLE | EWS_SIZEABLE | EWS_HASICON | EWS_NOSHADOW, 0, 0, IntPtr.Zero, MainWndProc);
            if (skin.Validate)
            {
                var bitmap = Properties.Resources.editbkg;
                //设置窗口背景图片
                skin.SetBackgroundImage(bitmap, 0, 0, 0, default, 0, 255, true);
                buttons = new List<ExButton>();
                buttons.Add(new ExButton(skin, "测试按钮开关", 10, 30, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试标签", 10, 70, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试单选复选框", 10, 110, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试编辑框", 10, 150, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试列表框", 10, 190, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试列表按钮", 10, 230, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试自定义背景", 10, 270, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试选项卡", 10, 310, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试分组框", 10, 350, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试绝对布局", 10, 390, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试相对布局", 10, 430, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试线性布局", 10, 470, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试流式布局", 10, 510, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试表格布局", 10, 550, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试组合框", 120, 30, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试缓动窗口", 120, 70, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试异形窗口", 120, 110, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试信息框", 120, 150, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));
                buttons.Add(new ExButton(skin, "测试自定义组件", 120, 190, 100, 30, -1, -1, DT_VCENTER | DT_CENTER));

                //类成员保存委托,不会被垃圾回收
                buttonEventProc = new ExObjEventProcDelegate(MainButtonEventProc);
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].HandleEvent(NM_CLICK, buttonEventProc);
                }
                //设置窗口可视,必须
                skin.Visible = true;
                //引擎消息循环,必须
                theApp.Run();
            }
        }


        static private IntPtr MainButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (hObj == buttons[0].handle)
            {
                ButtonWindow.CreateButtonWindow(skin);
            }
            else if (hObj == buttons[1].handle)
            {
                LabelWindow.CreateLabelWindow(skin);
            }
            else if (hObj == buttons[2].handle)
            {
                CheckButtonWindow.CreateCheckButtonWindow(skin);
            }
            else if (hObj == buttons[3].handle)
            {
                EditWindow.CreateEditWindow(skin);
            }
            else if (hObj == buttons[4].handle)
            {
                ListViewWindow.CreateListViewWindow(skin);
            }
            else if (hObj == buttons[5].handle)
            {
                ListButtonWindow.CreateListButtonWindow(skin);
            }
            else if (hObj == buttons[6].handle)
            {
                CustomBackgroundWindow.CreateCustomBackgroundWindow(skin);
            }
            else if (hObj == buttons[7].handle)
            {
                NavButtonWindow.CreateNavButtonWindow(skin);
            }
            else if (hObj == buttons[8].handle)
            {
                GroupBoxWindow.CreateGroupBoxWindow(skin);
            }
            else if (hObj == buttons[9].handle)
            {
                AbsoluteLayoutWindow.CreateAbsoluteLayoutWindow(skin);
            }
            else if (hObj == buttons[10].handle)
            {
                RelativeLayoutWindow.CreateRelativeLayoutWindow(skin);
            }
            else if (hObj == buttons[11].handle)
            {
                LinearLayoutWindow.CreateLinearLayoutWindow(skin);
            }
            else if (hObj == buttons[12].handle)
            {
                FlowLayoutWindow.CreateFlowLayoutWindow(skin);
            }
            else if (hObj == buttons[13].handle)
            {
                TableLayoutWindow.CreateTableLayoutWindow(skin);
            }
            else if (hObj == buttons[14].handle)
            {
                ComboBoxWindow.CreateComboBoxWindow(skin);
            }
            else if (hObj == buttons[15].handle)
            {
                EasingWindow.CreateEasingWindow(skin);
            }
            else if (hObj == buttons[16].handle)
            {
                CustomRedrawWindow.CreateCustomRedrawWindow(skin);
            }
            else if (hObj == buttons[17].handle)
            {
                MessageBoxWindow.CreateMessageBoxWindow(skin);
            }
            else if (hObj == buttons[18].handle)
            {
                CustomCtrlWindow.CreateCustomCtrlWindow(skin);
            }
            return IntPtr.Zero;
        }

        static private IntPtr MainWndProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_CREATE)
            {
            }
            return IntPtr.Zero;
        }
    }
}