using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Utility
{
    class ExImageList : IDisposable
    {
        protected nint m_hImgList;

        public nint handle => m_hImgList;

        public ExImageList(int nWidth, int nHeight)
        {
            ExAPI._imglist_create(nWidth, nHeight);
        }

        public ExImageList(nint hImgList)
        {
            m_hImgList = hImgList;
        }

        public void Dispose()
        {
            ExAPI._imglist_destroy(m_hImgList);
            m_hImgList = nint.Zero;
        }

        public nint Add(byte[] lpImage, int cbImage, nint nIndexInsert)
        {
            return ExAPI._imglist_add(m_hImgList, lpImage, cbImage, nIndexInsert);
        }

        public nint AddImage(ExImage image, nint nIndexInsert)
        {
            return ExAPI._imglist_addimage(m_hImgList, image.handle, nIndexInsert);
        }

        public int Count
        {
            get
            {
                return ExAPI._imglist_count(m_hImgList);
            }
        }

        public bool Del(nint nIndex)
        {
            return ExAPI._imglist_del(m_hImgList, nIndex);
        }

        public bool Draw(nint nIndex, ExCanvas canvas, int nLeft, int nTop, int nRight, int nBottom, int nAlpha)
        {
            return ExAPI._imglist_draw(m_hImgList, nIndex, canvas.handle, nLeft, nTop, nRight, nBottom, nAlpha);
        }

        public ExImage Get(nint nIndex)
        {
            return new ExImage((int)ExAPI._imglist_get(m_hImgList, nIndex));
        }

        public bool Set(nint nIndex, byte[] lpImage, int cbImage)
        {
            return ExAPI._imglist_set(m_hImgList, nIndex, lpImage, cbImage);
        }

        public bool SetImage(nint nIndex, ExImage image)
        {
            return ExAPI._imglist_setimage(m_hImgList, nIndex, image.handle);
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
