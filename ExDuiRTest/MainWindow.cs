using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;


namespace ExDuiRTest
{
    static class MainWindow
    {
        static private ExApp theApp;
        static private ExSkin skin;
        static private ExButton[] buttons;

        static public void CreateMainWindow()
        {
            //读入主题包
            var theme = Properties.Resources.Default;
            theApp = new ExApp(theme);
            skin = new ExSkin(null, null, "ExDUIR演示,项目地址：https://gitee.com/william_lzw/ExDUIR", 0, 0, 600, 600,
            EWS_MAINWINDOW | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_BUTTON_MAX | EWS_MOVEABLE | EWS_CENTERWINDOW |
            EWS_ESCEXIT | EWS_TITLE | EWS_SIZEABLE | EWS_HASICON | EWS_NOSHADOW, 0, 0, 0, MainWndProc);
            if (skin.Validate)
            {
                var bitmap = Properties.Resources.editbkg;
                byte[] img = Util.BitmapToByte(bitmap);
                skin.SetBackgroundImage(img, 0, 0, 0, 0, 0, 255, true);
                buttons = new ExButton[4];
                buttons[0] = new ExButton(skin, "测试按钮开关", 10, 30, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[1] = new ExButton(skin, "测试标签", 10, 70, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[2] = new ExButton(skin, "测试单选复选框", 10, 110, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[3] = new ExButton(skin, "测试编辑框", 10, 150, 100, 30, -1, -1, DT_VCENTER | DT_CENTER);
                TestCustomCtrl.RegisterControl();
                TestCustomCtrl custom = new TestCustomCtrl(skin, "test", 360, 110, 50, 50);
                for(int i = 0; i< 4; i++)
                {
                    buttons[i].HandleEvent(NM_CLICK, MainButtonEventProc);
                }
                skin.Visible = true;
                theApp.Run();
            }
        }

        static private bool MainButtonEventProc(int hObj, int nID, int nCode, nint wParam, nint lParam)
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
            return false;
        }

        static private bool MainWndProc(nint hWnd, int hExDui, int uMsg, nint wParam, nint lParam, nint pResult)
        {
            if (uMsg == WM_CREATE)
            {

  
            }
            return false;
        }
    }

    static class ButtonWindow
    {
        static private ExSkin skin;
        static private ExButton[] buttons;
        static private ExSwitch[] switchs;

        static public void CreateButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试按钮开关", 0, 0, 300, 200,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                
                var color = Util.ExRGBA(150, 150, 150, 255);
                skin.SetLong(EWL_CRBKG, (nint)color);
                buttons = new ExButton[6];
                buttons[0] = new ExButton(skin, "禁用自身", 10, 30, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[1] = new ExButton(skin, "解除按钮1禁用", 10, 70, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[2] = new ExButton(skin, "改动自身文本", 10, 110, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[3] = new ExButton(skin, "取按钮1文本", 10, 150, 120, 30, -1, -1, DT_VCENTER | DT_CENTER);
                buttons[4] = new ExButton(skin, "重画按钮1", 150, 30, 120, 30, -1, EOS_EX_FOCUSABLE | EOS_EX_CUSTOMDRAW | EOS_EX_COMPOSITED, DT_VCENTER | DT_CENTER);
                buttons[5] = new ExButton(skin, "重画按钮2", 150, 70, 120, 30, -1,
                    EOS_EX_FOCUSABLE | EOS_EX_CUSTOMDRAW | EOS_EX_COMPOSITED, DT_VCENTER | DT_CENTER, 0, OnButtonMsgProc);

                foreach (var button in buttons)
                {
                    button.HandleEvent(NM_CLICK, OnButtonEventProc);
                }
                buttons[4].HandleEvent(NM_CUSTOMDRAW, OnButtonEventProc);

                switchs = new ExSwitch[2];
                switchs[0] = new ExSwitch(skin, "已开启|已关闭", 150, 110, 80, 30);
                switchs[1] = new ExSwitch(skin, "", 150, 150, 60, 30);
                switchs[1].Check = true;
                ExObjProps props = new ExObjProps();
                
                props.crBkgNormal = Util.ExRGBA(255, 255, 255, 100);
                props.crBkgDownOrChecked = Util.ExRGBA(200, 50, 100, 100);
                props.crBorderNormal = Util.ExRGBA(255, 255, 255, 255);
                props.radius = 15;
                props.strokeWidth = 1;
                switchs[1].SetProps(props);
                switchs[1].HandleEvent(NM_CHECK, OnButtonEventProc);
                skin.Visible = true;
            }
        }

        static public bool OnButtonMsgProc(nint hWnd, int hObj, int uMsg, nint wParam, nint lParam, nint pResult)
        {
            if (uMsg == WM_ERASEBKGND)
            {
                ExPaintStruct ps = Util.IntPtrToStructure<ExPaintStruct>(lParam);
                int crBkg;
                if ((ps.dwState & STATE_DOWN) == STATE_DOWN)
                {
                   
                    crBkg = Util.ExRGBA(255, 0, 0, 51);
                    
                }
                else if ((ps.dwState & STATE_HOVER) == STATE_HOVER)
                {
                    crBkg = Util.ExRGBA(255, 168, 255, 51);
                }
                else
                {
                    crBkg = Util.ExRGBA(255, 255, 255, 51);
                }
                ExBrush hBrush = new ExBrush(crBkg);
                ExCanvas hCanvas = new ExCanvas(ps.hCanvas);
                hCanvas.FillRect(hBrush, 0, 0, ps.rcPaint.nRight, ps.rcPaint.nBottom);
                hBrush.Dispose();     
                return true;
            }

            return false;
        }

        static public bool OnButtonEventProc(int hObj, int nID, int nCode, nint wParam, nint lParam)
        {

            if (hObj == buttons[0].handle)
            {
                buttons[0].Enable = false;
                buttons[0].SetPadding(0, 20, 5, 5, 5);
            }
            else if (hObj == buttons[1].handle)
            {
                buttons[0].Enable = true;
            }
            else if (hObj == buttons[2].handle)
            {
                buttons[2].Text = "自身文本被改动";
            }
            else if (hObj == buttons[3].handle)
            {
                buttons[3].Text = "按钮1文本:" + buttons[0].Text;
            }
            else if (hObj == buttons[4].handle)
            {
                if (nCode == NM_CUSTOMDRAW)
                {
                    ExPaintStruct ps = Util.IntPtrToStructure<ExPaintStruct>(lParam);
                    int crBkg;
                    if ((ps.dwState & STATE_DOWN) != 0)
                    {
                        crBkg = Util.ExRGBA(255, 0, 0, 51);
                    }
                    else if ((ps.dwState & STATE_HOVER) != 0)
                    {
                        crBkg = Util.ExRGBA(255, 168, 255, 51);
                    }
                    else
                    {
                        crBkg = Util.ExRGBA(255, 255, 255, 51);
                    }
                    ExBrush hBrush = new ExBrush(crBkg);
                    ExCanvas hCanvas = new ExCanvas(ps.hCanvas);
                    hCanvas.FillRect(hBrush, 0, 0, ps.rcPaint.nRight, ps.rcPaint.nBottom);
                    hBrush.Dispose();
                }
                return true;
            }
            else if (hObj == switchs[1].handle)
            {
                if (wParam != 0)
                {
                    ExMessageBox.Show(skin, "开启", "取开关状态", MB_USERICON, EMBF_CENTEWINDOW);
                }
                else
                {
                    ExMessageBox.Show(skin, "关闭", "取开关状态", MB_ICONWARNING, EMBF_CENTEWINDOW);
                }
            }
           
            return false;
        }
    }

    static class LabelWindow
    {
        static private ExSkin skin;
        static private ExStatic label;
        static private ExStatic label2;
        static public void CreateLabelWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试标签", 0, 0, 200, 250,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                var color = Util.ExRGBA(150, 150, 150, 255);
                skin.SetLong(EWL_CRBKG, (nint)color);
                byte[] img = File.ReadAllBytes(".\\Res\\Loading.gif");
                label = new ExStatic(skin, img, 10, 30, 180, 150);
                label.SetRadius(10, 10, 15, 10, true);
                label.GetBackgroundImage(out ExBackgroundImageInfo bkgInfo);
                var rc = label.Rect;
                label2 = new ExStatic(skin, "标签可以填充动画,支持PNG,GIF,JPG,BMP格式,标签可以自动换行", 10, 190, 180, 90, DT_WORDBREAK);
                label2.SetFont("宋体", 14, FS_BOLD, false);
                label2.SetColor(COLOR_EX_TEXT_NORMAL, Util.ExRGBA(133, 33, 53, 255), true);
               
                Console.WriteLine(string.Format("标签矩形:{0},{1}", rc.nRight, rc.nBottom));
                Console.WriteLine(string.Format("背景信息:{0},{1},{2},{3},{4},{5},{6}", bkgInfo.nCurFrame, bkgInfo.x, bkgInfo.y, bkgInfo.nAlpha, bkgInfo.dwRepeat, bkgInfo.hImage, bkgInfo.nMaxFrame));
                skin.Visible = true;
            }
        }
    }

    static class CheckButtonWindow
    {
        static private ExSkin skin;
        static private ExCheckButton checkButton1;
        static private ExCheckButtonEx checkButtonex1;
        static private ExRadioButton radiobutton1;
        static private ExRadioButton radiobutton2;
        static private ExRadioButtonEx radiobuttonex1;
        static private ExRadioButtonEx radiobuttonex2;
        static private ExCheckBox checkbox1;

        static public void CreateCheckButtonWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试单选框复选框", 0, 0, 300, 250,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {

                var color = Util.ExRGBA(150, 150, 150, 255);
                skin.SetLong(EWL_CRBKG, (nint)color);
                checkButton1 = new ExCheckButton(skin, "复选框", 10, 30, 60, 20);
                radiobutton1 = new ExRadioButton(skin, "单选框1", 10, 60, 80, 20);
                radiobutton2 = new ExRadioButton(skin, "单选框2", 100, 60, 80, 20);
                checkButtonex1 = new ExCheckButtonEx(skin, "三态选择框", 10, 90, 120, 20);
                checkButtonex1.SetCheck(2);
                radiobuttonex1 = new ExRadioButtonEx(skin, "扩展单选框1", 10, 120, 100, 20);
                radiobuttonex2 = new ExRadioButtonEx(skin, "扩展单选框2", 100, 120, 100, 20);
                checkbox1 = new ExCheckBox(skin, "记住账号", 10, 150, 100, 30);
                checkbox1.Check = true;
                checkbox1.HandleEvent(NM_CHECK, OnCheckButtonEventProc);

                skin.Visible = true;
            }
        }

        static public bool OnCheckButtonEventProc(int hObj, int nID, int nCode, nint wParam, nint lParam)
        {
            if (wParam != 0)
            {
                bool check = true;
                ExMessageBox.ShowEx(skin, "选中了", "取CheckButton状态", MB_USERICON, "不再提示", ref check, 10, EMBF_CENTEWINDOW);
            }
            else
            {
                ExMessageBox.Show(skin, "取消选中啦", "取CheckButton状态", MB_ICONWARNING, EMBF_CENTEWINDOW);
            }
            return false;
        }
    }

    static class EditWindow
    {
        static private ExSkin skin;
        static private ExEdit edit1;
        static private ExEdit edit2;
        static private ExEdit edit3;
        static private ExEdit edit4;
        static private ExEdit edit5;
        static private ExEdit edit6;
        static private ExEdit edit7;
        static public void CreateEditWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试编辑框", 0, 0, 850, 350,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                var color = Util.ExRGBA(150, 150, 150, 255);
                skin.SetLong(EWL_CRBKG, (nint)color);
                edit1 = new ExEdit(skin, "背景图片编辑框", 10, 30, 150, 30, EOS_VISIBLE | EES_HIDESELECTION, EOS_EX_FOCUSABLE | EOS_EX_COMPOSITED | EOS_EX_CUSTOMDRAW, DT_VCENTER);
                var bitmap = Properties.Resources.editbkg;
                byte[] data = Util.BitmapToByte(bitmap);
                edit1.SetBackgroundImage(data, 0, 0, 0, nint.Zero, 0, 255, true);
                edit2 = new ExEdit(skin, "测试密码输入编辑框", 10, 70, 150, 30, EOS_VISIBLE | EES_USEPASSWORD, EOS_EX_FOCUSABLE | EOS_EX_COMPOSITED, DT_SINGLELINE);
                edit3 = new ExEdit(skin, "测试数值输入编辑框", 10, 110, 150, 30, EOS_VISIBLE | EES_NUMERICINPUT, EOS_EX_FOCUSABLE | EOS_EX_COMPOSITED, DT_SINGLELINE);
                edit4 = new ExEdit(skin, "测试只读编辑框", 10, 150, 150, 30, EOS_VISIBLE | EES_READONLY, EOS_EX_FOCUSABLE | EOS_EX_COMPOSITED, DT_SINGLELINE);
                edit5 = new ExEdit(skin, "测试透明圆角编辑框", 10, 190, 150, 30, EOS_VISIBLE | EES_HIDESELECTION, EOS_EX_FOCUSABLE | EOS_EX_COMPOSITED | EOS_EX_TABSTOP | EOS_EX_CUSTOMDRAW, DT_VCENTER);
                edit5.SetFont("微软雅黑", 16, FS_UNDERLINE, false);
                
                edit5.SetColor(COLOR_EX_BACKGROUND, Util.ExRGBA(200, 120, 130, 100), false);
                edit5.SetColor(COLOR_EX_TEXT_NORMAL, Util.ExRGBA(23, 115, 1, 100), false);
                edit5.SetRadius(10, 10, 10, 0, false);
                edit6 = new ExEdit(skin, "测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框", 10, 230, 150, 100, EOS_VISIBLE | EOS_VSCROLL, EOS_EX_FOCUSABLE | EOS_EX_COMPOSITED, DT_VCENTER);
                edit7 = new ExEdit(skin, "测试透明圆角编辑框", 180, 30, 300, 300, EOS_VISIBLE | EOS_VSCROLL | EOS_HSCROLL | EES_RICHTEXT | EES_PARSEURL | EES_ALLOWTAB | EES_NEWLINE, EOS_EX_FOCUSABLE, DT_LEFT | DT_TOP);
                var rtf = Properties.Resources.testrtf;
                byte[] rtfdata = System.Text.Encoding.UTF8.GetBytes(rtf.ToCharArray());
                //byte[] rtfdata = File.ReadAllBytes(".\\res\\test.rtf");
                //edit7.LoadRtf(rtfdata);
               // edit7.HandleEvent(NM_EN_SELCHANGE, OnEditNotifyEventProc);
                //edit7.HandleEvent(NM_EN_LINK, OnEditNotifyEventProc);
                skin.Visible = true;
            }
        }

        static public bool OnEditNotifyEventProc(int hObj, int nID, int nCode, nint wParam, nint lParam)
        {

            return false;
        }
    }

    static class Program
    {
        static void Main()
        {
            MainWindow.CreateMainWindow();
        }
    }
}