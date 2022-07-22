namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExSysButton : ExControl
    {
        public ExSysButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "SysButton", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "SysButton";
    }
}
