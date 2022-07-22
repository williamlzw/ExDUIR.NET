namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExRadioButton : ExControl
    {
        public ExRadioButton(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "Radiobutton", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public new string ClassName => "RadioButton";
    }

    public class ExRadioButtonEx : ExControl
    {
        public ExRadioButtonEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "RadiobuttonEx", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public new string ClassName => "RadioButtonEx";
    }
}