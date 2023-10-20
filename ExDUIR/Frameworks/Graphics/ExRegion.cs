using ExDuiR.NET.Native;
using System;

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

        public bool GetLines(ExtractPathLinePROCDelegate proc1, ExtractPathCubicPROCDelegate proc2)
        {
            return ExAPI._rgn_getlines(m_hRgn, proc1, proc2);
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
