using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExEasing
    {
        protected IntPtr m_hEasing;

        public IntPtr handle => m_hEasing;

        public ExEasing(int dwType, IntPtr pEasingContext, int dwMode, IntPtr pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4)
        {
            m_hEasing = (IntPtr)ExAPI._easing_create(dwType, pEasingContext, dwMode, pContext, nTotalTime, nInterval, nState, nStart, nStop,  param1, param2, param3, param4);
        }

        public ExEasing(IntPtr hEasing)
        {
            m_hEasing = hEasing;
        }

        public int State
        {
            get
            {
                return ExAPI._easing_getstate(m_hEasing);
            }
            set
            {
                ExAPI._easing_setstate(m_hEasing, value);
            }
        }
    }
}
