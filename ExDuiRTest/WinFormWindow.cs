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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DemoForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "DemoForm";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.ResumeLayout(false);

        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class WinFormWindow
    {
        static private ExSkin skin;
        static private ExButton button;
        static private DemoForm form = new DemoForm();

        static public void CreateWinFormWindow(ExSkin pOwner)
        {
            skin = new ExSkin(form.Handle, WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_SIZEABLE | WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON, IntPtr.Zero);
            skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
            //ExDuiR组件也能创建在winform窗口,但是注意winform窗口的winform组件被skin覆盖看不见。
            button = new ExButton(skin, "测试按钮", 30, 30, 100, 30);
            skin.Visible = true;
        }
    }
}
