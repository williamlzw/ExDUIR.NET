using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Graphics
{
    public class ExMatrix : IDisposable
    {
        protected nint m_hMatrix;

        public nint handle => m_hMatrix;

        public ExMatrix()
        {
            m_hMatrix = (nint)ExAPI._matrix_create();
        }

        public ExMatrix(nint hMatrix)
        {
            m_hMatrix = hMatrix;
        }

        public void Dispose()
        {
            ExAPI._matrix_destroy(m_hMatrix);
            m_hMatrix = 0;
        }

        public bool Reset()
        {
            return ExAPI._matrix_reset(m_hMatrix);
        }

        public bool Rotate(float fAngle)
        {
            return ExAPI._matrix_rotate(m_hMatrix, fAngle);
        }

        public bool Scale(float scaleX, float scaleY)
        {
            return ExAPI._matrix_scale(m_hMatrix, scaleX, scaleY);
        }

        public bool Translate(float offsetX, float offsetY)
        {
            return ExAPI._matrix_translate(m_hMatrix, offsetX, offsetY);
        }
    }
}
