namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExTreeView : ExControl
    {
        public ExTreeView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TreeView", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "TreeView";
    }
}
