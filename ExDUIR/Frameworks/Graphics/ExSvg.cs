using ExDuiR.NET.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExSvg : IDisposable
    {
        protected int m_hSvg;

        public int handle => m_hSvg;

        public ExSvg(IntPtr data)
        {
            ExAPI._svg_create(data, out m_hSvg);
        }

        public ExSvg(string file)
        {
            ExAPI._svg_createfromfile(file, out m_hSvg);
        }

        public void Dispose()
        {
            ExAPI._svg_destroy(m_hSvg);
            m_hSvg = 0;
        }

        public void SetElementFillColor(string id, int color)
        {
            ExAPI._svg_setelementfillcolor(m_hSvg, id, color);
        }

        public void SetElementStrokeColor(string id, int color, float strokeWidth = 0.0f)
        {
            ExAPI._svg_setelementstrokecolor(m_hSvg, id, color, strokeWidth);
        }
    }
}
