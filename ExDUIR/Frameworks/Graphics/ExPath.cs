using ExDuiR.NET.Native;
using System;
using System.Security.Cryptography;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExPath : IDisposable
    {
        protected int m_hPath;

        public int handle => m_hPath;

        public ExPath()
        {
            ExAPI._path_create(1, out m_hPath);
        }

        public ExPath(int hPath)
        {
            m_hPath = hPath;
        }

        public void Dispose()
        {
            ExAPI._path_destroy(m_hPath);
            m_hPath = 0;
        }

        public bool AddArc(float x1, float y1, float x2, float y2, float radiusX, float radiusY, bool fClockwise)
        {
            return ExAPI._path_addarc(m_hPath, x1, y1, x2, y2, radiusX, radiusY, fClockwise);
        }

        public bool AddArc2(float x, float y, float width, float height, float startAngle, float sweepAngle)
        {
            return ExAPI._path_addarc2(m_hPath, x, y, width, height, startAngle, sweepAngle);
        }

        public bool AddArc3(float x, float y, float radiusX, float radiusY, float startAngle, float sweepAngle, bool fClockwise, bool barcSize)
        {
            return ExAPI._path_addarc3(m_hPath, x, y, radiusX, radiusY, startAngle, sweepAngle, fClockwise, barcSize);
        }

        public bool AddLine(float x1, float y1, float x2, float y2)
        {
            return ExAPI._path_addline(m_hPath, x1, y1, x2, y2);
        }

        public bool AddRect(float left, float top, float right, float bottom)
        {
            return ExAPI._path_addrect(m_hPath, left, top, right, bottom);
        }

        public bool AddRoundedRect(float left, float top, float right, float bottom, float radiusTopLeft, float radiusTopRight, float radiusBottomLeft, float radiusBottomRight)
        {
            return ExAPI._path_addroundedrect(m_hPath, left, top, right, bottom, radiusTopLeft, radiusTopRight, radiusBottomLeft, radiusBottomRight);
        }

        public bool BeginFigure()
        {
            return ExAPI._path_beginfigure(m_hPath);
        }

        public bool BeginFigue(float x, float y)
        {
            return ExAPI._path_beginfigure2(m_hPath, x, y);
        }

        public bool BeginFigue(float x, float y, int figureBegin)
        {
            return ExAPI._path_beginfigure3(m_hPath, x, y, figureBegin);
        }

        public bool Close()
        {
            return ExAPI._path_close(m_hPath);
        }

        public bool EndFigure(bool fCloseFigure)
        {
            return ExAPI._path_endfigure(m_hPath, fCloseFigure);
        }

        public ExRectF Bounds
        {
            get
            {
                ExRectF lpBounds = new ExRectF();
                ExAPI._path_getbounds(m_hPath, ref lpBounds);
                return lpBounds;
            }
        }

        public bool HitTest(float x, float y)
        {
            return ExAPI._path_hittest(m_hPath, x, y);
        }

        public bool Open()
        {
            return ExAPI._path_open(m_hPath);
        }

        public bool Reset()
        {
            return ExAPI._path_reset(m_hPath);
        }

        public bool AddBezier(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            return ExAPI._path_addbezier(m_hPath, x1, y1, x2, y2, x3, y3);
        }
    }
}
