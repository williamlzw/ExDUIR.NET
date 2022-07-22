namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExListView : ExControl
    {
        public ExListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ListView", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "ListView";
    }
}
