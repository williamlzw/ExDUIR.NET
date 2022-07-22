using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExEasing
    {
        protected nint m_hEasing;

        public nint handle => m_hEasing;

        public ExEasing(int dwType, nint pEasingContext, int dwMode, nint pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, nint param1, nint param2, nint param3, nint param4)
        {
            m_hEasing = (nint)ExAPI._easing_create(dwType, pEasingContext, dwMode, pContext, nTotalTime, nInterval, nState, nStart, nStop,  param1, param2, param3, param4);
        }

        public ExEasing(nint hEasing)
        {
            m_hEasing = hEasing;
        }

        public void CurveFree(nint pCurveInfo)
        {
             ExAPI._easing_curve_free(pCurveInfo);
        }

        public nint CurveLoad(byte[] lpCurveInfo,int cbCurveInfo)
        {
            return ExAPI._easing_curve_load(lpCurveInfo, cbCurveInfo);
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
