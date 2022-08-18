using System;
using static ExDuiR.NET.Native.ExConst;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExCheckButton : ExControl
    {
        public ExCheckButton(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckButton", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public new string ClassName => "CheckButton";
    }

    public class ExCheckButtonEx : ExControl
    {
        public ExCheckButtonEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckButtonEx", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }

        public void SetCheck(int type)
        {
            this.SendMessage(BM_SETCHECK, (nint)type, 0);
        }
        public new string ClassName => "CheckButtonEx";
    }
}