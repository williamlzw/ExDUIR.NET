using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExBrush : IDisposable
    {
        protected IntPtr m_hBrush;
        protected int _color;

        public IntPtr handle => m_hBrush;

        public ExBrush(int Color)
        {
            m_hBrush = ExAPI._brush_create(Color);
            _color = Color;
        }

        public ExBrush(ExCanvas canvas)
        {
            m_hBrush = ExAPI._brush_createfromcanvas(canvas.handle);
        }

        public ExBrush(ExImage img)
        {
            m_hBrush = ExAPI._brush_createfromimg(img.handle);
        }

        public ExBrush(IntPtr hBrush)
        {
            m_hBrush = hBrush;
        }

        public int Color
        {
            get
            {
                return _color;
            }
            set
            {
                ExAPI._brush_setcolor(m_hBrush, value);
            }
        }

        public ExMatrix TransFrom
        {
            set
            {
                ExAPI._brush_settransform(m_hBrush, value.handle);
            }
        }

        public void Dispose()
        {
            ExAPI._brush_destroy(m_hBrush);
            m_hBrush = IntPtr.Zero;
        }
    }
}
