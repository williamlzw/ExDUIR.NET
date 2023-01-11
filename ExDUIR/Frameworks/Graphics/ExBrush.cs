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

        /// <summary>
        /// 创建线性渐变画刷
        /// </summary>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="xEnd"></param>
        /// <param name="yEnd"></param>
        /// <param name="crBegin">起点颜色ARGB</param>
        /// <param name="crEnd">终点颜色ARGB</param>
        public ExBrush(int xStart, int yStart, int xEnd, int yEnd, int crBegin, int crEnd)
        {
            m_hBrush = ExAPI._brush_createlinear(xStart, yStart, xEnd, yEnd, crBegin, crEnd);
        }

        /// <summary>
        /// 创建线性渐变画刷2
        /// </summary>
        /// <param name="xStart">起点X</param>
        /// <param name="yStart">起点Y</param>
        /// <param name="xEnd">终点X</param>
        /// <param name="yEnd">终点Y</param>
        /// <param name="arrStopPts">两个点位置和颜色数据,只能两个{位置(0-1.0),颜色(ARGB),位置(0-1.0),颜色(ARGB)}这样传参</param>
        /// <param name="cStopPts">点个数，只能两个传2</param>
        public ExBrush(int xStart, int yStart, int xEnd, int yEnd, float[,] arrStopPts, int cStopPts)
        {
            m_hBrush = ExAPI._brush_createlinear_ex(xStart, yStart, xEnd, yEnd, arrStopPts, cStopPts);
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
