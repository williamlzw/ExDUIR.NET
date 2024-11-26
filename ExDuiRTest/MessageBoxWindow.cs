using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiRTest
{
    static class MessageBoxWindow
    {
        static ExWndProcDelegate wndProc;
        static public void CreateMessageBoxWindow(ExSkin pOwner)
        {
            if (ExMessageBox.Show(pOwner, "确定或者取消", "信息框1", MB_OKCANCEL | MB_ICONQUESTION, MESSAGEBOX_FLAG_CENTEWINDOW | MESSAGEBOX_FLAG_WINDOWICON) == IDOK)//用户点击按钮才会关闭,继承父窗口背景
            {
                Console.WriteLine("按下确定按钮");
            }

            if (ExMessageBox.Show(pOwner, "重试或者取消", "信息框2", MB_RETRYCANCEL | MB_ICONQUESTION, MESSAGEBOX_FLAG_CENTEWINDOW | MESSAGEBOX_FLAG_WINDOWICON) == IDRETRY)
            {
                Console.WriteLine("按下重试按钮");
            }

            if (ExMessageBox.Show(pOwner, "是或者否或者取消", "信息框3", MB_YESNOCANCEL | MB_ICONQUESTION, MESSAGEBOX_FLAG_CENTEWINDOW | MESSAGEBOX_FLAG_WINDOWICON) == IDCANCEL)
            {
                Console.WriteLine("按下取消按钮");
            }

            wndProc = new ExWndProcDelegate(OnWndProc);
            bool check = true;
            if (ExMessageBox.ShowEx(pOwner, "是或者否", "信息框4", MB_YESNO | MB_ICONQUESTION, "", ref check, 10000, MESSAGEBOX_FLAG_CENTEWINDOW | MESSAGEBOX_FLAG_NOINHERITBKG | MESSAGEBOX_FLAG_WINDOWICON, wndProc) == IDYES)//不继承父窗口背景,超时自动关闭，可以修改信息框标题颜色等等
            {
                Console.WriteLine("按下是按钮");
            }
        }

        static private IntPtr OnWndProc(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr lpResult)
        {
            if (uMsg == WM_NOTIFY)
            {
                var ni = Util.IntPtrToStructure<ExNMHDR>(lParam);
                if (ni.nCode == NM_INTDLG)
                {
                    var nskin = new ExSkin(hExDui);
                    nskin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                    //改变标题栏标题组件颜色
                    var caption = nskin.Caption;
                    //标题栏窗口风格就是标题栏子组件的ID,类似关闭，最大化，最小化按钮也可以这样获取
                    var title = caption.GetObjFromID(WINDOW_STYLE_TITLE);
                    title.ColorTextNormal = Util.ExARGB(120, 230, 21, 255);
                }
            }
            return IntPtr.Zero;
        }
    }
}
