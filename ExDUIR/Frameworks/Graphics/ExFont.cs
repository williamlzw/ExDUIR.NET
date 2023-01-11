using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExFont : IDisposable
    {
        protected int m_hFont;

        public int handle => m_hFont;

        public ExFont()
        {
            m_hFont = ExAPI._font_create();
        }

        public ExFont(string fontFace,int dwFontSize,int dwFontStyle)
        {
            m_hFont = ExAPI._font_createfromfamily(fontFace, dwFontSize, dwFontStyle);
        }

        public ExFont(ref WinAPI.LogFont lpLogFont)
        {
            m_hFont = ExAPI._font_createfromlogfont(ref lpLogFont);
        }

        public ExFont(int hFont)
        {
            m_hFont = hFont;
        }

        public void Dispose()
        {
            ExAPI._font_destroy(m_hFont);
            m_hFont = 0;
        }

        public IntPtr Context
        {
            get
            {
                return ExAPI._font_getcontext(m_hFont);
            }
        }

        public WinAPI.LogFont LogFont
        {
            get
            {
                WinAPI.LogFont lpLogFont = new WinAPI.LogFont();
                ExAPI._font_getlogfont(m_hFont, ref lpLogFont);
                return lpLogFont;
            }
        }
    }
}
