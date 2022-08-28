using ExDuiR.NET.Native;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExListButton : ExControl
    {
        public ExListButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ListButton", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExListButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ListButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }

        public new string ClassName => "ListButton";
    }
}
