namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExComboBox : ExControl
    {
        public ExComboBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ComboBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "ComboBox";
    }
}
