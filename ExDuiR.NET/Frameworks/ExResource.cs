using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExResource : IDisposable
    {
        protected nint m_hRes;

        public nint handle => m_hRes;

        public ExResource(string lpwzFile)
        {
            m_hRes = (nint)ExAPI.Ex_ResLoadFromFile(lpwzFile);
        }

        public ExResource(byte[] lpData, nint dwDataLen)
        {
            m_hRes = (nint)ExAPI.Ex_ResLoadFromMemory(lpData, dwDataLen);
        }

        public void Dispose()
        {
            ExAPI.Ex_ResFree(m_hRes);
            m_hRes = nint.Zero;
        }

        public bool GetFile(string lpwzPath, out byte[] lpFile, out nint dwFileLen)
        {
            return ExAPI.Ex_ResGetFile(m_hRes, lpwzPath, out lpFile, out dwFileLen);
        }

        public bool GetFileFromAtom(int atomPath, out byte[] lpFile, out nint dwFileLen)
        {
            return ExAPI.Ex_ResGetFileFromAtom(m_hRes, atomPath, out lpFile, out dwFileLen);
        }

        static public void Pack(string root, string file, bool fSubDir, char byteHeader, bool bPntBits)
        {
            ExAPI._res_pack(root, file, fSubDir, byteHeader, bPntBits);
        }
    }
}
