using System;
using System.Runtime.InteropServices;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExSwitch : ExControl
    {
        public ExSwitch(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Switch", sTitle, x, y, nWidth, nHeight)
        {
        }

        public bool Check
        {
            set => this.SendMessage(BM_SETCHECK, (nint)1, 0);
            get => Convert.ToBoolean(this.SendMessage(BM_GETCHECK, 0, 0));
        }

        public void SetProps(ExObjProps props)
        {
            int size = Marshal.SizeOf(typeof(ExObjProps));
            nint allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(props, allocIntPtr, false);
            var ret = this.SendMessage(WM_EX_PROPS, 0, allocIntPtr);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        public new string ClassName => "Switch";
    }
}
