using System;
using static ExDuiR.NET.Native.ExConst;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExCheckBox : ExControl
    {
        public ExCheckBox(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckBox", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }

        public bool Check
        {
            set => this.SendMessage(BM_SETCHECK, (nint)1, 0);
            get => Convert.ToBoolean(this.SendMessage(BM_GETCHECK, 0, 0));
        }
        public new string ClassName => "CheckBox";
    }
}