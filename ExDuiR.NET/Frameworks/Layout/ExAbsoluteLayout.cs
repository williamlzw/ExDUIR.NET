using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExAbsoluteLayout : ExBaseLayout
    {
        public ExAbsoluteLayout(ExControl objBind)
            : base(ELT_ABSOLUTE, objBind)
        {
        }

        public ExAbsoluteLayout(int hLayout)
            : base(hLayout)
        {
        }

        public bool Lock(ExControl obj, int tLeft, int tTop, int tRight, int tBottom, int tWidth, int tHeight)
        {
            return ExAPI._layout_absolute_lock(m_hLayout, obj.handle, tLeft, tTop, tRight, tBottom, tWidth, tHeight);
        }

        public bool SetEdge(ExControl obj, int dwEdge, int dwType, nint nValue)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, dwEdge, dwType, nValue);
        }
    }
}
