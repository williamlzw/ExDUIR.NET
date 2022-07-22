namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExTemplateListView : ExControl
    {
        public ExTemplateListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TemplateListView", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "TemplateListView";
    }
}
