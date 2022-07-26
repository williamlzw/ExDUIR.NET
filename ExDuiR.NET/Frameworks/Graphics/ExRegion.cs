﻿using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExRegion : IDisposable
    {
        protected nint m_hRgn;

        public nint handle => m_hRgn;

        public ExRegion(ExPath path)
        {
            m_hRgn = (nint)ExAPI._rgn_createfrompath(path.handle);
        }

        public ExRegion(nint hRegion)
        {
            m_hRgn = hRegion;
        }

        public ExRegion(float left, float top, float right, float bottom)
        {
            m_hRgn = (nint)ExAPI._rgn_createfromrect(left, top, right, bottom);
        }

        public ExRegion(float left, float top, float right, float bottom, float radiusX, float radiusY)
        {
            m_hRgn = (nint)ExAPI._rgn_createfromroundrect(left, top, right, bottom, radiusX, radiusY);
        }

        public void Dispose()
        {
            ExAPI._rgn_destroy(m_hRgn);
            m_hRgn = 0;
        }

        public nint Combine(ExRegion RgnDst,int nCombineMode,int dstOffsetX,int dstOffsetY)
        {
            return ExAPI._rgn_combine(m_hRgn, RgnDst.m_hRgn, nCombineMode, dstOffsetX, dstOffsetY);
        }

        public bool HitTest(float x, float y)
        {
            return ExAPI._rgn_hittest(m_hRgn, x, y);
        }
    }
}
