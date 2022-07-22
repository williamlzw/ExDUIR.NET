using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExPageLayout : ExBaseLayout
    {
        public ExPageLayout(ExControl objBind)
            : base(ELT_PAGE, objBind)
        {
        }

        public ExPageLayout(int hLayout)
            : base(hLayout)
        {
        }
    }
}
