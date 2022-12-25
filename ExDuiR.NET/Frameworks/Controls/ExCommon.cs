using System;
using ExDuiR.NET.Native;
using System.IO;
using System.Runtime.InteropServices;
using static ExDuiR.NET.Native.ExConst;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExStatic : ExControl
    {
        public ExStatic(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "Static", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {

        }
        public ExStatic(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Static", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExStatic(IExBaseUIEle pOwner, byte[] pImageData, int x, int y, int nWidth, int nHeight)
            : base(pOwner, "Static", null, x, y, nWidth, nHeight)
        {
            SetBackgroundImage(pImageData, 0, 0, 0, IntPtr.Zero, 1, 255, true);
        }
        public ExStatic(int hObj) : base(hObj)
        {
        }
        public ExStatic(ExControl parent) : base(parent)
        {
        }

        public new string ClassName => "Static";
    }
    public class ExButton : ExControl
    {
        public ExButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Button", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Button", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExButton(int hObj) : base(hObj)
        {
        }
        public ExButton(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "Button";
    }

    public class ExButtonEx : ExControl
    {
        public ExButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ButtonEx", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ButtonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExButtonEx(int hObj) : base(hObj)
        {
        }
        public ExButtonEx(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ButtonEx";
    }

    public class ExCalendar : ExControl
    {
        public ExCalendar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Calendar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExCalendar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Calendar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExCalendar(int hObj) : base(hObj)
        {
        }
        public ExCalendar(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "Calendar";
    }

    public class ExCarousel : ExControl
    {
        public ExCarousel(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Carousel", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExCarousel(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Carousel", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExCarousel(int hObj) : base(hObj)
        {
        }
        public ExCarousel(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "Carousel";
    }
    public class ExCheckBox : ExControl
    {
        public ExCheckBox(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckBox", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExCheckBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CheckBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExCheckBox(int hObj) : base(hObj)
        {
        }
        public ExCheckBox(ExControl parent) : base(parent)
        {
        }
        public bool Check
        {
            set => this.SendMessage(BM_SETCHECK, (IntPtr)1, IntPtr.Zero);
            get => Convert.ToBoolean(this.SendMessage(BM_GETCHECK, IntPtr.Zero, IntPtr.Zero));
        }
        public new string ClassName => "CheckBox";
    }

    public class ExCheckButton : ExControl
    {
        public ExCheckButton(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckButton", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExCheckButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CheckButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExCheckButton(int hObj) : base(hObj)
        {
        }
        public ExCheckButton(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "CheckButton";
    }

    public class ExCheckButtonEx : ExControl
    {
        public ExCheckButtonEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckButtonEx", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExCheckButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CheckButtonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExCheckButtonEx(int hObj) : base(hObj)
        {
        }
        public ExCheckButtonEx(ExControl parent) : base(parent)
        {
        }
        public void SetCheck(int type)
        {
            this.SendMessage(BM_SETCHECK, (IntPtr)type, IntPtr.Zero);
        }
        public new string ClassName => "CheckButtonEx";
    }

    public class ExChromium : ExControl
    {
        public ExChromium(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "CefBrowser", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExChromium(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CefBrowser", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExChromium(int hObj) : base(hObj)
        {
        }
        public ExChromium(ExControl parent) : base(parent)
        {
        }
        public static void Initialize(string libPath)
        {
            ExAPI.Ex_ObjCefBrowserInitialize(IntPtr.Zero, libPath, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 0, null);
        }

        public new string ClassName => "CefBrowser";
    }

    public class ExColorPicker : ExControl
    {
        public ExColorPicker(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ColorPicker", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExColorPicker(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ColorPicker", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExColorPicker(int hObj) : base(hObj)
        {
        }
        public ExColorPicker(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ColorPicker";
    }

    public class ExComboBox : ExControl
    {
        public ExComboBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ComboBox", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExComboBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ComboBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExComboBox(int hObj) : base(hObj)
        {
        }
        public ExComboBox(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ComboBox";
    }

    public class ExDateBox : ExControl
    {
        public ExDateBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "DateBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExDateBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "DateBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExDateBox(int hObj) : base(hObj)
        {
        }
        public ExDateBox(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "DateBox";
    }

    public class ExDrawingBoard : ExControl
    {
        public ExDrawingBoard(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "DrawingBoard", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExDrawingBoard(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "DrawingBoard", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExDrawingBoard(int hObj) : base(hObj)
        {
        }
        public ExDrawingBoard(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "DrawingBoard";
    }

    public class ExEdit : ExControl
    {
        public ExEdit(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1)
           : base(pOwner, "Edit", sText, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat)
        {

        }
        public ExEdit(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Edit", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExEdit(int hObj) : base(hObj)
        {
        }
        public ExEdit(ExControl parent) : base(parent)
        {
        }
        /// <summary>
        /// 加载rtf文件
        /// </summary>
        /// <param name="data"></param>
        public void LoadRtf(byte[] data)
        {
            IntPtr allocIntPtr = Marshal.AllocHGlobal(data.Length);
            try
            {
                Marshal.Copy(data, 0, allocIntPtr, data.Length);
                this.SendMessage(EM_LOAD_RTF, (IntPtr)data.Length, allocIntPtr);
            }
            finally
            {
                Marshal.FreeHGlobal(allocIntPtr);
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        public void SelectAll()
        {
            ExCharRange charRange = new ExCharRange();
            charRange.cpMin = 0;
            charRange.cpMax = -1;
            int size = Marshal.SizeOf(typeof(ExCharRange));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(charRange, allocIntPtr, false);
            this.SendMessage(EM_EXSETSEL, IntPtr.Zero, allocIntPtr);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        public void CancelSelect()
        {
            this.SendMessage(EM_SETSEL, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 置选择
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void Select(int start, int end)
        {
            this.SendMessage(EM_SETSEL, (IntPtr)start, (IntPtr)end);
        }

        /// <summary>
        /// 撤销
        /// </summary>
        public void Undo()
        {
            this.SendMessage(EM_UNDO, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 重做
        /// </summary>
        public void Redo()
        {
            this.SendMessage(EM_REDO, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 复制
        /// </summary>
        public void Copy()
        {
            this.SendMessage(WM_COPY, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 剪切
        /// </summary>
        public void Cut()
        {
            this.SendMessage(WM_CUT, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 粘贴
        /// </summary>
        public void Paste()
        {
            this.SendMessage(WM_PASTE, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 删除
        /// </summary>
        public void Clear()
        {
            this.SendMessage(WM_CLEAR, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 取行数
        /// </summary>
        public IntPtr GetLineCount()
        {
            return this.SendMessage(EM_GETLINECOUNT, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 寻找选择文本
        /// </summary>
        public void FindText(string find)
        {
            ExTextRange textRange = new ExTextRange();
            textRange.chrg.cpMin = Utility.Util.HIWORD(Convert.ToUInt32(this.SendMessage(EM_GETLINECOUNT, IntPtr.Zero, IntPtr.Zero)));
            textRange.chrg.cpMax = -1;
            textRange.pwzText = Marshal.StringToHGlobalAnsi(find);
            int size = Marshal.SizeOf(typeof(ExTextRange));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(textRange, allocIntPtr, false);
            textRange.chrg.cpMin = Convert.ToInt32(this.SendMessage(EM_FINDTEXTW, (IntPtr)1, allocIntPtr));
            if (textRange.chrg.cpMin != -1)
            {
                textRange.chrg.cpMax = textRange.chrg.cpMin + Marshal.SizeOf(textRange.pwzText);
            }
            this.SendMessage(EM_SETSEL, (IntPtr)textRange.chrg.cpMin, (IntPtr)textRange.chrg.cpMax);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        /// <summary>
        /// 替换选择文本
        /// </summary>
        public void ReplaceText(string replace)
        {
            ExSetTextEx textformat = new ExSetTextEx();
            textformat.flags = 2;
            textformat.codePage = 1200;
            int size = Marshal.SizeOf(typeof(ExSetTextEx));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(textformat, allocIntPtr, false);
            IntPtr strPtr = Marshal.StringToHGlobalUni(replace);
            this.SendMessage(EM_SETSEL, allocIntPtr, strPtr);
            Marshal.FreeHGlobal(allocIntPtr);
            Marshal.FreeHGlobal(strPtr);
        }

        /// <summary>
        /// 置选中行段落左对齐
        /// </summary>
        public void AlignLeft()
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_ALIGNMENT, 0, 0, 0, 0, PFA_LEFT);
        }

        /// <summary>
        /// 置选中行段落右对齐
        /// </summary>
        public void AlignRight()
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_ALIGNMENT, 0, 0, 0, 0, PFA_RIGHT);
        }

        /// <summary>
        /// 置选中行段落居中对齐
        /// </summary>
        public void AlignCenter()
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_ALIGNMENT, 0, 0, 0, 0, PFA_CENTER);
        }

        /// <summary>
        /// 置选中段落首行缩进
        /// </summary>
        public void SetSelParStartIndentation(int size)
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_STARTINDENT, 0, size, 0, 0, 0);
        }

        /// <summary>
        /// 置选中段落右侧缩进
        /// </summary>
        public void SetSelParRightIndentation(int size)
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_RIGHTINDENT, 0, 0, size, 0, 0);
        }

        /// <summary>
        /// 置选中段落非首行缩进
        /// </summary>
        public void SetSelParOffset(int size)
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_OFFSET, 0, 0, 0, size, 0);
        }

        /// <summary>
        /// 置选中段落项目符号
        /// </summary>
        public void SetSelParNumbering(ushort type)
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_NUMBERING, type, 0, 0, 0, 0);
        }

        /// <summary>
        /// 置选中行文本颜色
        /// </summary>
        public void SetSelCharColor(int crText)
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_COLOR, crText, "", 0, 0, false, false, false, false, false);
        }

        /// <summary>
        /// 置选中行加粗
        /// </summary>
        public void SetSelCharBold()
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_BOLD, 0, "", 0, 0, true, false, false, false, false);
        }

        /// <summary>
        /// 置选中行倾斜
        /// </summary>
        public void SetSelCharItalic()
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_ITALIC, 0, "", 0, 0, false, true, false, false, false);
        }

        /// <summary>
        /// 置选中行下划线
        /// </summary>
        public void SetSelCharUnderLine()
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_UNDERLINE, 0, "", 0, 0, false, false, true, false, false);
        }

        /// <summary>
        /// 置选中行删除线
        /// </summary>
        public void SetSelCharStrikeOut()
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_STRIKEOUT, 0, "", 0, 0, false, false, false, true, false);
        }

        /// <summary>
        /// 置选中行超链接
        /// </summary>
        public void SetSelCharLink()
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_LINK, 0, "", 0, 0, false, false, false, false, true);
        }

        /// <summary>
        /// 置选中行字体
        /// </summary>
        public void SetSelCharFont(string fontName, int size)
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_FACE | CFM_SIZE, 0, fontName, size, 0, false, false, false, false, false);
        }

        public new string ClassName => "Edit";
    }

    public class ExEditEx : ExControl
    {
        public ExEditEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1)
           : base(pOwner, "EditEx", sText, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat)
        {

        }
        public ExEditEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "EditEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExEditEx(int hObj) : base(hObj)
        {
        }
        public ExEditEx(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "EditEx";
    }

    public class ExGroupBox : ExControl
    {
        public ExGroupBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "GroupBox", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExGroupBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "GroupBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExGroupBox(int hObj) : base(hObj)
        {
        }
        public ExGroupBox(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "GroupBox";
    }

    public class ExIconListView : ExControl
    {
        public ExIconListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "IconListView", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExIconListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "IconListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExIconListView(int hObj) : base(hObj)
        {
        }
        public ExIconListView(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "IconListView";
    }

    public class ExListButton : ExControl
    {
        public ExListButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ListButton", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExListButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ListButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExListButton(int hObj) : base(hObj)
        {
        }
        public ExListButton(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ListButton";
    }

    public class ExListItem : ExControl
    {
        public ExListItem(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "LISTITEM", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExListItem(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "LISTITEM", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExListItem(int hObj) : base(hObj)
        {
        }
        public ExListItem(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "LISTITEM";
    }

    public class ExListView : ExControl
    {
        public ExListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ListView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExListView(int hObj) : base(hObj)
        {
        }
        public ExListView(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ListView";
    }

    public class ExNavButton : ExControl
    {
        public ExNavButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "NavButtonEx", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExNavButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "NavButtonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExNavButton(int hObj) : base(hObj)
        {
        }
        public ExNavButton(ExControl parent) : base(parent)
        {
        }

        public new string ClassName => "NavButtonEx";
    }

    class ExPage : ExControl
    {
        public ExPage(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Page", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExPage(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Page", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExPage(int hObj) : base(hObj)
        {
        }
        public ExPage(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "Page";
    }

    public class ExPalette : ExControl
    {
        public ExPalette(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Palette", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExPalette(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Palette", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExPalette(int hObj) : base(hObj)
        {
        }
        public ExPalette(ExControl parent) : base(parent)
        {
        }

        public new string ClassName => "Palette";
    }

    public class ExProgressBar : ExControl
    {
        public ExProgressBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Progress", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExProgressBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Progress", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExProgressBar(int hObj) : base(hObj)
        {
        }
        public ExProgressBar(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "Progress";
    }

    public class ExPropertyGrid : ExControl
    {
        public ExPropertyGrid(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "PropertyGrid", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExPropertyGrid(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "PropertyGrid", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExPropertyGrid(int hObj) : base(hObj)
        {
        }
        public ExPropertyGrid(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "PropertyGrid";
    }

    public class ExRadioButton : ExControl
    {
        public ExRadioButton(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "Radiobutton", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExRadioButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Radiobutton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExRadioButton(int hObj) : base(hObj)
        {
        }
        public ExRadioButton(ExControl parent) : base(parent)
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
        public ExRadioButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "RadiobuttonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExRadioButtonEx(int hObj) : base(hObj)
        {
        }
        public ExRadioButtonEx(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "RadioButtonEx";
    }

    public class ExReportListView : ExControl
    {
        public ExReportListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ReportListView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExReportListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ReportListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExReportListView(int hObj) : base(hObj)
        {
        }
        public ExReportListView(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ReportListView";
    }
    public class ExRotateImgBox : ExControl
    {
        public ExRotateImgBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "RotateImgBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExRotateImgBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "RotateImgBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExRotateImgBox(int hObj) : base(hObj)
        {
        }
        public ExRotateImgBox(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "RotateImgBox";
    }

    public class ExScoreButton : ExControl
    {
        public ExScoreButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ScoreButton", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExScoreButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ScoreButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExScoreButton(int hObj) : base(hObj)
        {
        }
        public ExScoreButton(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "ScoreButton";
    }

    public class ExScrollBar : ExControl
    {
        public ExScrollBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ScrollBar", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExScrollBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ScrollBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExScrollBar(int hObj) : base(hObj)
        {
        }
        public ExScrollBar(ExControl parent) : base(parent)
        {
        }
        public bool ScrollEnable(int wSB, int wArrows)
        {
            return ExAPI.Ex_ObjScrollEnable(m_hObj, wSB, wArrows);
        }

        public IntPtr GetControl(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetControl(m_hObj, nBar);
        }

        public bool GetInfo(int fnBar, out int lpnMin, out int lpnMax, out int lpnPos, out int lpnTrackPos)
        {
            return ExAPI.Ex_ObjScrollGetInfo(m_hObj, fnBar, out lpnMin, out lpnMax, out lpnPos, out lpnTrackPos);
        }

        public int GetPos(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetPos(m_hObj, nBar);
        }

        public bool GetRange(int nBar, out int lpnMinPos, out int lpnMaxPos)
        {
            return ExAPI.Ex_ObjScrollGetRange(m_hObj, nBar, out lpnMinPos, out lpnMaxPos);
        }

        public int GetTrackPos(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetTrackPos(m_hObj, nBar);
        }

        public int SetInfo(int fnBar, int fMask, int nMin, int nMax, int nPage, int nPos, bool fRedraw)
        {
            return ExAPI.Ex_ObjScrollSetInfo(m_hObj, fnBar, fMask, nMin, nMax, nPage, nPos, fRedraw);
        }

        public int SetPos(int nBar, int nPos, bool bRedraw)
        {
            return ExAPI.Ex_ObjScrollSetPos(m_hObj, nBar, nPos, bRedraw);
        }

        public bool SetRange(int nBar, int nMin, int nMax, bool bRedraw)
        {
            return ExAPI.Ex_ObjScrollSetRange(m_hObj, nBar, nMin, nMax, bRedraw);
        }

        public bool ScrollShow(int wBar, bool fShow)
        {
            return ExAPI.Ex_ObjScrollShow(m_hObj, wBar, fShow);
        }
        public new string ClassName => "ScrollBar";
    }

    public class ExSoliderBar : ExControl
    {
        public ExSoliderBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "SoliderBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExSoliderBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "SoliderBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExSoliderBar(int hObj) : base(hObj)
        {
        }
        public ExSoliderBar(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "SoliderBar";
    }

    public class ExSwitch : ExControl
    {
        public ExSwitch(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Switch", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExSwitch(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Switch", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExSwitch(int hObj) : base(hObj)
        {
        }
        public ExSwitch(ExControl parent) : base(parent)
        {
        }
        public bool Check
        {
            set => this.SendMessage(BM_SETCHECK, (IntPtr)1, IntPtr.Zero);
            get => Convert.ToBoolean(this.SendMessage(BM_GETCHECK, IntPtr.Zero, IntPtr.Zero));
        }

        public void SetProps(ExObjProps props)
        {
            int size = Marshal.SizeOf(typeof(ExObjProps));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(props, allocIntPtr, false);
            var ret = this.SendMessage(WM_EX_PROPS, IntPtr.Zero, allocIntPtr);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        public new string ClassName => "Switch";
    }

    public class ExSysButton : ExControl
    {
        public ExSysButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle, int dwStyleEx)
            : base(oParent, "SysButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx)
        {
        }
        public ExSysButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "SysButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExSysButton(int hObj) : base(hObj)
        {
        }
        public ExSysButton(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "SysButton";
    }

    public class ExTemplateListView : ExControl
    {
        public ExTemplateListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TListView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExTemplateListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "TListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExTemplateListView(int hObj) : base(hObj)
        {
        }
        public ExTemplateListView(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "TListView";
    }

    public class ExTreeView : ExControl
    {
        public ExTreeView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TreeView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExTreeView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "TreeView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExTreeView(int hObj) : base(hObj)
        {
        }
        public ExTreeView(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "TreeView";
    }

    public class ExMiniblinkBrowser : ExControl
    {
        public ExMiniblinkBrowser(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "MbBrowser", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExMiniblinkBrowser(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "MbBrowser", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, 0, pfnObjProc)
        {
        }
        public ExMiniblinkBrowser(int hObj) : base(hObj)
        {
        }
        public ExMiniblinkBrowser(ExControl parent) : base(parent)
        {
        }
        public static bool Initialize(string libPath, string dllPath)
        {
            return ExAPI.Ex_ObjMiniblinkBrowserInitialize(libPath, dllPath);
        }
        public new string ClassName => "MbBrowser";
    }
}
