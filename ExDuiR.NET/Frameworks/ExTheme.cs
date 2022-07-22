using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    class ExTheme : IDisposable
    {
        protected int m_hTheme;
        protected int _color;

        public int handle => m_hTheme;

        public ExTheme(string lptszFile, byte[] lpKey, nint dwKeyLen, bool bDefault)
        {
            m_hTheme = ExAPI.Ex_ThemeLoadFromFile(lptszFile, lpKey, dwKeyLen, bDefault);
        }

        public ExTheme(byte[] lpData, nint dwDataLen, byte[] lpKey, nint dwKeyLen, bool bDefault)
        {
            m_hTheme = ExAPI.Ex_ThemeLoadFromMemory(lpData, dwDataLen, lpKey, dwKeyLen, bDefault);
        }

        public void Dispose()
        {
            ExAPI.Ex_ThemeFree(m_hTheme);
            m_hTheme = 0;
        }

        public bool DrawControl(ExCanvas canvas, float dstLeft, float dstTop, float dstRight, float dstBottom, int atomClass, int atomSrcRect, int dwAlpha)
        {
            return ExAPI.Ex_ThemeDrawControl(m_hTheme, canvas.handle, dstLeft, dstTop, dstRight, dstBottom, atomClass, atomSrcRect, dwAlpha);
        }

        public bool DrawControlEx(ExCanvas canvas, float dstLeft, float dstTop, float dstRight, float dstBottom, int atomClass, int atomSrcRect, int atomBackgroundRepeat, int atomBackgroundPositon, int atomBackgroundGrid, int atomBackgroundFlags, int dwAlpha)
        {
            return ExAPI.Ex_ThemeDrawControlEx(m_hTheme, canvas.handle, dstLeft, dstTop, dstRight, dstBottom, atomClass, atomSrcRect, atomBackgroundRepeat, atomBackgroundPositon, atomBackgroundGrid, atomBackgroundFlags, dwAlpha);
        }

        public int GetColor(int nIndex)
        {
            return ExAPI.Ex_ThemeGetColor(m_hTheme, nIndex);
        }

        public nint GetValuePtr(int atomClass, int atomProp)
        {
            nint ptr = ExAPI.Ex_ThemeGetValuePtr(m_hTheme, atomClass, atomProp);
            return ptr;
        }
    }
}
