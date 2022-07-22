using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExLinearLayout : ExBaseLayout
    {
        public ExLinearLayout(ExControl objBind)
            : base(ELT_LINEAR, objBind)
        {
        }

        public ExLinearLayout(int hLayout)
            : base(hLayout)
        {
        }
    }
}
