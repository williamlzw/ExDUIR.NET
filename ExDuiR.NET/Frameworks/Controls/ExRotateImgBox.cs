using ExDuiR.NET.Native;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExRotateImgBox : ExControl
    {
        public ExRotateImgBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "RotateImgBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExRotateImgBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "RotateImgBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }

        public new string ClassName => "RotateImgBox";
    }
}
