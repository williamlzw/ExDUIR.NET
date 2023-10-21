using ExDuiR.NET.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExRegion : IDisposable
    {
        protected IntPtr m_hRgn;

        public IntPtr handle => m_hRgn;

        public ExRegion(ExPath path)
        {
            m_hRgn = (IntPtr)ExAPI._rgn_createfrompath(path.handle);
        }

        public ExRegion(IntPtr hRegion)
        {
            m_hRgn = hRegion;
        }

        public ExRegion(float left, float top, float right, float bottom)
        {
            m_hRgn = (IntPtr)ExAPI._rgn_createfromrect(left, top, right, bottom);
        }

        public ExRegion(float left, float top, float right, float bottom, float radiusX, float radiusY)
        {
            m_hRgn = (IntPtr)ExAPI._rgn_createfromroundrect(left, top, right, bottom, radiusX, radiusY);
        }

        public void Dispose()
        {
            ExAPI._rgn_destroy(m_hRgn);
            m_hRgn = IntPtr.Zero;
        }

        public ExRegion Combine(ExRegion RgnDst,int nCombineMode,int dstOffsetX,int dstOffsetY)
        {
            var ret = ExAPI._rgn_combine(m_hRgn, RgnDst.m_hRgn, nCombineMode, dstOffsetX, dstOffsetY);
            return new ExRegion(ret);
        }

        public bool GetLines(ref List<ExPointF> points, ref int pointsCount)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExPointF)));
            var ret = ExAPI._rgn_getlines(m_hRgn, ref ptr, ref pointsCount);
            for (int i = 0; i < pointsCount; i++)
            {
                IntPtr targetPtrX = IntPtr.Add(ptr, i * 8);
                float x = Marshal.PtrToStructure<float>(targetPtrX);
                IntPtr targetPtrY = IntPtr.Add(ptr, i * 8 + 4);
                float y = Marshal.PtrToStructure<float>(targetPtrY);
                ExPointF point = new ExPointF(x, y);
                points.Add(point);
            }
            Marshal.FreeHGlobal(ptr);
            return ret;
        }

        public bool HitTest(float x, float y)
        {
            return ExAPI._rgn_hittest(m_hRgn, x, y);
        }

        public bool HitTest2(ExRegion region, ref int retRelation)
        {
            return ExAPI._rgn_hittest2(m_hRgn, region.handle, out retRelation);
        }

        public ExRectF Bounds
        {
            get
            {
                ExRectF lpBounds = new ExRectF();
                ExAPI._rgn_getbounds(m_hRgn, ref lpBounds);
                return lpBounds;
            }
        }
    }
}
