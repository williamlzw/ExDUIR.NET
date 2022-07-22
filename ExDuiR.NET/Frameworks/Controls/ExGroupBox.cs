namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExGroupBox : ExControl
    {
        public ExGroupBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "GroupBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "GroupBox";
    }
}
