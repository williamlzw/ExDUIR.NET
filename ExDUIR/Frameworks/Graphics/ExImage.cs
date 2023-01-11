using ExDuiR.NET.Native;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExImage : IDisposable
    {
        protected int m_hImg;

        public int handle => m_hImg;

        public int Height
        {
            get
            {
                return ExAPI._img_height(m_hImg);
            }
        }

        public int Width
        {
            get
            {
                return ExAPI._img_width(m_hImg);
            }
        }

        public ExImage(int width, int height)
        {
            ExAPI._img_create(width, height, out m_hImg);
        }

        public ExImage(ExCanvas canvas)
        {
            ExAPI._img_createfromcanvas(canvas.handle, out m_hImg);
        }

        public ExImage(string wzFilename)
        {
            ExAPI._img_createfromfile(wzFilename, out m_hImg);
        }

        public ExImage(IntPtr hBitmap, IntPtr hPalette, bool fPreAlpha)
        {
            ExAPI._img_createfromhbitmap(hBitmap, hPalette, fPreAlpha, out m_hImg);
        }

        public ExImage(System.Drawing.Bitmap bitmap)
        {
            var data = Utility.Util.BitmapToByte(bitmap);
            ExAPI._img_createfrommemory(data, (IntPtr)data.Length, out m_hImg);
        }

        public ExImage(System.Drawing.Icon icon)
        {
            var data = Utility.Util.IconToByte(icon);
            ExAPI._img_createfrommemory(data, (IntPtr)data.Length, out m_hImg);
        }

        public ExImage(IntPtr hIcon)
        {
            ExAPI._img_createfromhicon(hIcon, out m_hImg);
        }

        public ExImage(int hImg)
        {
            m_hImg = hImg;
        }

        public ExImage(byte[] lpData, int dwLen)
        {
            ExAPI._img_createfrommemory(lpData, (IntPtr)dwLen, out m_hImg);
        }

        public ExImage(ExResource res, int atomPath)
        {
            ExAPI._img_createfromres(res.handle, atomPath, out m_hImg);
        }

        public ExImage(IStream lpStream)
        {
            ExAPI._img_createfromstream(lpStream, out m_hImg);
        }

        public void Dispose()
        {
            ExAPI._img_destroy(m_hImg);
            m_hImg = 0;
        }

        public bool Copy(out int dsgImg)
        {
            return ExAPI._img_copy(m_hImg, out dsgImg);
        }

        public bool Copy(int x, int y, int width, int height, out int dsgImg)
        {
            return ExAPI._img_copyrect(m_hImg, x, y, width, height, out dsgImg);
        }

        public int FrameCount
        {
            get
            {
                ExAPI._img_getframecount(m_hImg, out int nFrameCount);
                return nFrameCount;
            }
        }

        public bool GetFrameDelay(int[] lpDelayAry, out int nFrames)
        {
            return ExAPI._img_getframedelay(m_hImg, lpDelayAry, out nFrames);
        }

        public bool GetPixel(int x, int y, out int color)
        {
            return ExAPI._img_getpixel(m_hImg, x, y, out color);
        }

        public bool GetSize(out int lpWidth, out int lpHeight)
        {
            return ExAPI._img_getsize(m_hImg, out lpWidth, out lpHeight);
        }

        public bool Lock(ExRect RectL, int flags, int PixelFormat, ref ExBitmapData lpLockedBitmapData)
        {
            return ExAPI._img_lock(m_hImg, RectL, flags, PixelFormat, ref lpLockedBitmapData);
        }

        public bool RotateFlip(int rfType, out ExImage dstImg)
        {
            var ans = 0;
            var ret = ExAPI._img_rotateflip(m_hImg, rfType, out ans);
            dstImg = new ExImage(ans);
            return ret;
        }

        public bool Scale(int dstWidth, int dstHeight, out ExImage dstImg)
        {
            var ans = 0;
            var ret = ExAPI._img_scale(m_hImg, dstWidth, dstHeight, out ans);
            dstImg = new ExImage(ans);
            return ret;
        }

        public bool SelectActiveFrame(int nIndex)
        {
            return ExAPI._img_selectactiveframe(m_hImg, nIndex);
        }

        public bool SetPixel(int x, int y, int color)
        {
            return ExAPI._img_setpixel(m_hImg, x, y, color);
        }

        public bool Unlock(ref ExBitmapData lpLockedBitmapData)
        {
            return ExAPI._img_unlock(m_hImg, ref lpLockedBitmapData);
        }

        public void SaveToFile(string lpWzFile)
        {
            ExAPI._img_savetofile(m_hImg, lpWzFile);
        }

        public void SaveToMemory(IntPtr lpBuffer)
        {
            ExAPI._img_savetomemory(m_hImg, lpBuffer);
        }
    }
}
