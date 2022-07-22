using System;

namespace ExDuiR.NET.Frameworks
{
    public class ExException : Exception
    {
        private int m_nErrCode;

        public ExException(int nErrCode = -1, string sMsg = null, Exception inner = null)
            : base(sMsg, inner)
        {
            m_nErrCode = nErrCode;
        }

        public int ErrorCode { get => m_nErrCode; }
    }
}
