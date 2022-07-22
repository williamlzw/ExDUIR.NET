using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExRelativateLayout : ExBaseLayout
    {
        public ExRelativateLayout(ExControl objBind)
            : base(ELT_RELATIVE, objBind)
        {
        }

        public ExRelativateLayout(int hLayout)
            : base(hLayout)
        {
        }
    }
}
