using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExEasing
    {
        protected IntPtr m_hEasing;

        public IntPtr handle => m_hEasing;

        public ExEasing(int dwType, IntPtr pEasingContext, int dwMode, IntPtr pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, IntPtr param1 = default, IntPtr param2 = default, IntPtr param3 = default, IntPtr param4 = default)
        {
            m_hEasing = ExAPI._easing_create(dwType, pEasingContext, dwMode, pContext, nTotalTime, nInterval, nState, nStart, nStop,  param1, param2, param3, param4);
        }

        public ExEasing(int dwType, IntPtr pEasingContext, int dwMode, ExEasingProcDelegate pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, IntPtr param1 = default, IntPtr param2 = default, IntPtr param3 = default, IntPtr param4 = default)
        {
            m_hEasing = ExAPI._easing_create(dwType, pEasingContext, dwMode, pContext, nTotalTime, nInterval, nState, nStart, nStop, param1, param2, param3, param4);
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
