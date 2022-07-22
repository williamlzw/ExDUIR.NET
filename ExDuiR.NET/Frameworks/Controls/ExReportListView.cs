namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExReportListView : ExControl
    {
        public ExReportListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ReportListView", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "ReportListView";
    }
}
