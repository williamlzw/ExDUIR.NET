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
        static public void CreateMessageBoxWindow(ExSkin pOwner)
        {
            ExMessageBox.Show(pOwner, "内容", "标题", MB_YESNO | MB_ICONQUESTION, EMBF_CENTEWINDOW);
        }
    }
}
