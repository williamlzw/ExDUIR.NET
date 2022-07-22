namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExProgressBar : ExControl
    {
        public ExProgressBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Progress", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "Progress";
    }
}
