using System;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExDuiRTest
{
    public class DemoForm:Form
    {
        public DemoForm()
        {
            this.Text = "绑定winform窗口,渲染ExDuiR组件";
            this.Size = new System.Drawing.Size(500, 500);
            //以下这句必须,无边框风格
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }

    public class WinFormWindow
    {
        static private ExSkin skin;
        static private ExButton button;
        static private DemoForm form = new DemoForm();

        static public void CreateWinFormWindow(ExSkin pOwner)
        {
            skin = new ExSkin(form.Handle, EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_SIZEABLE | EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON, IntPtr.Zero);
            skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
            //ExDuiR组件也能创建在winform窗口,但是注意winform窗口的winform组件被skin覆盖看不见。
            button = new ExButton(skin, "测试按钮", 30, 30, 100, 30);
            skin.Visible = true;
        }
    }
}
