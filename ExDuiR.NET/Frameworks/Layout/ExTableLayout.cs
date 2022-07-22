using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExTableLayout : ExBaseLayout
    {
        public ExTableLayout(ExControl objBind)
            : base(ELT_TABLE, objBind)
        {
        }

        public ExTableLayout(int hLayout)
            : base(hLayout)
        {
        }

        public bool SetInfo(int[] aRowHeight, int cRows, int[] aCellWidth, int cCells)
        {
            return ExAPI._layout_table_setinfo(m_hLayout, aRowHeight, cRows, aCellWidth, cCells);
        }
    }
}
