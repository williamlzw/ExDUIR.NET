using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;
using ExDuiR.NET.Native;

namespace ExDuiR.NET.Frameworks.Utility
{
    static public class Util
    {
        static public T IntPtrToStructure<T>(IntPtr ptr)
        {
            object structure = null;
            int size = Marshal.SizeOf(typeof(T));
            try
            {
                structure = Marshal.PtrToStructure(ptr, typeof(T));
            }
            finally
            {
            }
            return (T)structure;
        }

        static public void FloatToIntPtr(IntPtr ptr, float value)
        {
            Marshal.Copy(new float[] { value }, 0, ptr, 1);
        }

        static public float IntPtrToFloat(IntPtr ptr)
        {
            float[] temp = new float[1];
            Marshal.Copy(ptr, temp, 0, 1);
            return temp[0];
        }

        static public double IntPtrToDouble(IntPtr ptr)
        {
            long longValue = Marshal.ReadInt64(ptr);
            double doubleValue = BitConverter.Int64BitsToDouble(longValue);
            return doubleValue;
        }

        static public void DoubleToIntPtr(IntPtr ptr, double value)
        {
            Marshal.Copy(new double[] { value }, 0, ptr, 1);
        }

        static public T ByteToStructure<T>(byte[] dataBuffer)
        {
            object structure = null;
            int size = Marshal.SizeOf(typeof(T));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(dataBuffer, 0, allocIntPtr, size);
                structure = Marshal.PtrToStructure(allocIntPtr, typeof(T));
            }
            finally
            {
                Marshal.FreeHGlobal(allocIntPtr);
            }
            return (T)structure;
        }

        static public IntPtr IntPtrToBitmap(IntPtr dataBuffer, int len)
        {
            byte[] data = new byte[len];
            Marshal.Copy(dataBuffer, data, 0, len);
            IntPtr hBitmap = IntPtr.Zero;
            ExAPI.Ex_LoadBitMapFromMemory(data, (IntPtr)len, ref hBitmap);
            return hBitmap;
        }

        static public IntPtr ByteToBitmap(byte[] dataBuffer)
        {
            IntPtr hBitmap = IntPtr.Zero;
            ExAPI.Ex_LoadBitMapFromMemory(dataBuffer, (IntPtr)dataBuffer.Length, ref hBitmap);
            return hBitmap;
        }

        static public byte[] BitmapToByte(System.Drawing.Bitmap Bitmap)
        {
            MemoryStream ms = null;
            try
            {
                ms = new MemoryStream();
                Bitmap.Save(ms, Bitmap.RawFormat);
                byte[] byteImage = new Byte[ms.Length];
                byteImage = ms.ToArray();
                return byteImage;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            finally
            {
                ms.Close();
            }
        }

        static public byte[] IconToByte(System.Drawing.Icon bitmap)
        {
            // 1.先将BitMap转成内存流
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bitmap.Save(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            // 2.再将内存流转成byte[]并返回
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            ms.Dispose();
            return bytes;
        }

        public static int MAKELONG(uint lowPart, uint highPart)
        {
            return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        }

        public static ushort MAKEWORD(byte a, byte b)
        {
            return (ushort)(((short)b << 8) | a);
        }

        public static int GET_X_LPARAM(IntPtr value)
        {
            return (int)(short)((uint)value & 0xFFFF);
        }
        public static int GET_Y_LPARAM(IntPtr value)
        {
            return (int)(short)((uint)value >> 16);
        }
        public static ushort LOWORD(uint value)
        {
            return (ushort)(value & 0xFFFF);
        }
        public static ushort HIWORD(uint value)
        {
            return (ushort)(value >> 16);
        }
        public static byte LOWBYTE(int value)
        {
            return (byte)(value & 0xFF);
        }
        public static byte HIGHBYTE(int value)
        {
            return (byte)(value >> 8);
        }

        public static float GetDpi()
        {
            var dc = WinAPI.GetDC(IntPtr.Zero);
            float dpi = (float)WinAPI.GetDeviceCaps(dc, 88) / 96;
            WinAPI.ReleaseDC(IntPtr.Zero, dc);
            return dpi;
        }

        public static int ExGetR(int argb)
        {
            return LOWBYTE((argb >> 16));
        }

        public static int ExGetG(int argb)
        {
            return LOWBYTE((argb >> 8));
        }

        public static int ExGetB(int argb)
        {
            return LOWBYTE(argb);
        }

        public static int ExGetA(int argb)
        {
            return LOWBYTE((argb >> 24));
        }

        public static int ExRGB(int red, int green, int blue)
        {
            return (blue) | (green << 8) | (red << 16);
        }

        public static int ExARGB(int red, int green, int blue, int alpha)
        {
            return (ExRGB(red, green, blue) | (alpha << 24));
        }

        public static int ExRGB2ARGB(int rgb, int alpha)
        {
            return (ExGetB(rgb) | (ExGetG(rgb) << 8) | (ExGetR(rgb) << 16) | (alpha << 24));
        }

        /// <summary>
        /// 从数据获取句柄
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="type">图标类型,取值 IMAGE_BITMAP或IMAGE_ICON或IMAGE_CURSOR</param>
        /// <returns></returns>
        public static IntPtr ExLoadImage(byte[] data, int type)
        {
            return ExAPI.Ex_LoadImageFromMemory(data, (IntPtr)data.Length, type, 0);
        }
    }
}
