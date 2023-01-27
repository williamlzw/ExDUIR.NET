using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Utility
{
    public class ExImageList : IDisposable
    {
        protected IntPtr m_hImgList;

        public IntPtr handle => m_hImgList;

        public ExImageList(int nWidth, int nHeight)
        {
            m_hImgList = ExAPI._imglist_create(nWidth, nHeight);
        }

        public ExImageList(IntPtr hImgList)
        {
            m_hImgList = hImgList;
        }

        public void Dispose()
        {
            ExAPI._imglist_destroy(m_hImgList);
            m_hImgList = IntPtr.Zero;
        }

        public int Add(byte[] lpImage, int cbImage, int nIndex)
        {
            return (int)ExAPI._imglist_add(m_hImgList, lpImage, (IntPtr)cbImage, (IntPtr)nIndex);
        }

        public int AddImage(ExImage image, int nIndex)
        {
            return (int)ExAPI._imglist_addimage(m_hImgList, image.handle, (IntPtr)nIndex);
        }

        public int Count
        {
            get
            {
                return ExAPI._imglist_count(m_hImgList);
            }
        }

        public bool Del(int nIndex)
        {
            return ExAPI._imglist_del(m_hImgList, (IntPtr)nIndex);
        }

        public bool Draw(int nIndex, ExCanvas canvas, int nLeft, int nTop, int nRight, int nBottom, int nAlpha)
        {
            return ExAPI._imglist_draw(m_hImgList, (IntPtr)nIndex, canvas.handle, nLeft, nTop, nRight, nBottom, nAlpha);
        }

        public ExImage Get(int nIndex)
        {
            return new ExImage((int)ExAPI._imglist_get(m_hImgList, (IntPtr)nIndex));
        }

        public bool Set(int nIndex, byte[] lpImage, int cbImage)
        {
            return ExAPI._imglist_set(m_hImgList, (IntPtr)nIndex, lpImage, (IntPtr)cbImage);
        }

        public bool SetImage(int nIndex, ExImage image)
        {
            return ExAPI._imglist_setimage(m_hImgList, (IntPtr)nIndex, image.handle);
        }

        public int Width
        {
            get
            {
                int width = 0, tmp = 0;
                ExAPI._imglist_size(m_hImgList, out width, out tmp);
                return width;
            }
        }

        public int Height
        {
            get
            {
                int height = 0, tmp = 0;
                ExAPI._imglist_size(m_hImgList, out tmp, out height);
                return height;
            }
        }
    }
}
