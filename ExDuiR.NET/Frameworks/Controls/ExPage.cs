namespace ExDuiR.NET.Frameworks.Controls
{
    class ExPage : ExControl
    {
        ExPage(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Page", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "Page";
    }
}
