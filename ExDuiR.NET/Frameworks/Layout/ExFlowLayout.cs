using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExFlowLayout : ExBaseLayout
    {
        public ExFlowLayout(ExControl objBind)
            : base(ELT_FLOW, objBind)
        {
        }

        public ExFlowLayout(int hLayout)
            : base(hLayout)
        {
        }
    }
}
