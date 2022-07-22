using ExDuiR.NET.Native;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExButton : ExControl
    {
        public ExButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Button", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle=-1, int dwStyleEx=-1, int dwTextFormat=-1, int nID=0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Button", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }

        public new string ClassName => "Button";
    }
}
