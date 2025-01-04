using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks
{
    public class ExResource : IDisposable
    {
        protected IntPtr m_hRes;

        public IntPtr handle => m_hRes;

        public ExResource(string lpwzFile)
        {
            m_hRes = (IntPtr)ExAPI.Ex_ResLoadFromFile(lpwzFile);
        }

        public ExResource(byte[] lpData, IntPtr dwDataLen)
        {
            m_hRes = (IntPtr)ExAPI.Ex_ResLoadFromMemory(lpData, dwDataLen);
        }

        public void Dispose()
        {
            ExAPI.Ex_ResFree(m_hRes);
            m_hRes = IntPtr.Zero;
        }

        public bool GetFile(string lpwzPath, out IntPtr lpFile, out IntPtr dwFileLen)
        {
            return ExAPI.Ex_ResGetFile(m_hRes, lpwzPath, out lpFile, out dwFileLen);
        }

        public bool GetFileFromAtom(int atomPath, out IntPtr lpFile, out IntPtr dwFileLen)
        {
            return ExAPI.Ex_ResGetFileFromAtom(m_hRes, atomPath, out lpFile, out dwFileLen);
        }
    }
}
