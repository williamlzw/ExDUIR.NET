using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using ExDuiR.NET.Frameworks.Utility;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace ExDuiR.NET.Frameworks.Controls
{
    /// <summary>
    /// 基础组件,可创建标签
    /// </summary>
    public class ExStatic : ExControl
    {
        public ExStatic(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "Static", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {

        }

        public ExStatic(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Static", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }

        public ExStatic(IExBaseUIEle pOwner, byte[] pImageData, int x, int y, int nWidth, int nHeight)
            : base(pOwner, "Static", null, x, y, nWidth, nHeight)
        {
            SetBackgroundImage(pImageData, 0, 0, 0, default, 1, 255, true);
        }

        public ExStatic(IExBaseUIEle pOwner, byte[] pImageData, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(pOwner, "Static", null, x, y, nWidth, nHeight, dwStyle, dwStyleEx, -1, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
            SetBackgroundImage(pImageData, 0, 0, 0, default, 1, 255, true);
        }

        public ExStatic(IExBaseUIEle pOwner, System.Drawing.Bitmap bitmap, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
           : base(pOwner, "Static", null, x, y, nWidth, nHeight, dwStyle, dwStyleEx, -1, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
            byte[] img = Util.BitmapToByte(bitmap);
            SetBackgroundImage(img, 0, 0, 0, default, 1, 255, true);
        }

        public ExStatic(int hObj) : base(hObj)
        {
        }

        public ExStatic(ExControl parent) : base(parent)
        {
        }

        public new string ClassName => "Static";
    }

    /// <summary>
    /// 按钮
    /// </summary>
    public class ExButton : ExControl
    {
        public ExButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Button", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Button", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 扩展按钮
    /// </summary>
    public class ExButtonEx : ExControl
    {
        public ExButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ButtonEx", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ButtonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExButtonEx(int hObj) : base(hObj)
        {
        }
        public ExButtonEx(ExControl parent) : base(parent)
        {
        }
        public ExObjProps Props
        {
            set
            {
                var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExObjProps)));
                Marshal.StructureToPtr(value, ptr, true);
                this.SendMessage(WM_EX_PROPS, IntPtr.Zero, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }
        public ExImageInfo ImageInfo
        {
            set
            {
                var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExImageInfo)));
                Marshal.StructureToPtr(value, ptr, true);
                this.SendMessage(BM_SETIMAGE, IntPtr.Zero, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }
        public ExImage Icon
        {
            set
            {
                this.SendMessage(WM_SETICON, IntPtr.Zero, (IntPtr)value.handle);
            }
        }
        public new string ClassName => "ButtonEx";
    }

    /// <summary>
    /// 日历
    /// </summary>
    public class ExCalendar : ExControl
    {
        public ExCalendar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Calendar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExCalendar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Calendar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 轮播
    /// </summary>
    public class ExCarousel : ExControl
    {
        public ExCarousel(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Carousel", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExCarousel(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Carousel", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExCarousel(int hObj) : base(hObj)
        {
        }
        public ExCarousel(ExControl parent) : base(parent)
        {
        }
        public  void SetSize(int width, int height)
        {
            this.SendMessage(CM_SIZE, (IntPtr)500, (IntPtr)500);
        }
        /// <summary>
        /// 添加轮播图片
        /// </summary>
        /// <param name="image"></param>
        public void AddImage(ExImage image)
        {
            this.SendMessage(CM_ADDIMG, IntPtr.Zero, (IntPtr)image.handle);
        }
        public new string ClassName => "Carousel";
    }

    /// <summary>
    /// 选择框
    /// </summary>
    public class ExCheckBox : ExControl
    {
        public ExCheckBox(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckBox", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExCheckBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CheckBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 复选框
    /// </summary>
    public class ExCheckButton : ExControl
    {
        public ExCheckButton(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckButton", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExCheckButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0,  IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CheckButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 扩展复选框
    /// </summary>
    public class ExCheckButtonEx : ExControl
    {
        public ExCheckButtonEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "CheckButtonEx", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExCheckButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CheckButtonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// cef3浏览框
    /// </summary>
    public class ExChromium : ExControl
    {
        public ExChromium(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "CefBrowser", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExChromium(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "CefBrowser", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 颜色选择器
    /// </summary>
    public class ExColorPicker : ExControl
    {
        public ExColorPicker(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ColorPicker", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExColorPicker(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ColorPicker", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 组合框
    /// </summary>
    public class ExComboBox : ExControl
    {
        public ExComboBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ComboBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExComboBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ComboBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }

        public ExComboBox(int hObj) : base(hObj)
        {
        }

        public ExComboBox(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 添加项目到尾部
        /// </summary>
        /// <param name="text"></param>
        public void AddString(string text)
        {
            this.SendMessage(CB_ADDSTRING, default, Marshal.StringToHGlobalUni(text));
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="index">索引</param>
        public void DeleteString(int index)
        {
            this.SendMessage(CB_DELETESTRING, (IntPtr)index, default);
        }

        /// <summary>
        /// 插入文本
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="text">内容</param>
        public void InsertString(int index, string text)
        {
            this.SendMessage(CB_INSERTSTRING, (IntPtr)index, Marshal.StringToHGlobalUni(text));
        }

        /// <summary>
        /// 寻找文本
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="text">寻找内容</param>
        public bool FindString(int index, string text)
        {
            return (int)this.SendMessage(CB_FINDSTRING, (IntPtr)index, Marshal.StringToHGlobalUni(text)) == 1;
        }

        /// <summary>
        /// 重置内容
        /// </summary>
        public void ResetContent()
        {
            this.SendMessage(CB_RESETCONTENT, default, default);
        }

        /// <summary>
        /// 显示下拉列表
        /// </summary>
        public bool DropDown
        {
            set
            {
                this.SendMessage(CB_SHOWDROPDOWN, (IntPtr)Convert.ToInt32(value), default);
            }
        }

        /// <summary>
        /// 取项目数
        /// </summary>
        public int Count
        {
            get
            {
                return (int)this.SendMessage(CB_GETCOUNT, default, default);
            }
        }

        /// <summary>
        /// 置/取当前选中项
        /// </summary>
        public int Cursel
        {
            get
            {
                return (int)this.SendMessage(CB_GETCURSEL, default, default);
            }
            set
            {
                this.SendMessage(CB_SETCURSEL, (IntPtr)value, default);
            }
        }


        /// <summary>
        /// 取下拉列表宽度
        /// </summary>
        public int DropppedWidth
        {
            get
            {
                return (int)this.SendMessage(CB_GETDROPPEDWIDTH, default, default);
            }
            set
            {
                this.SendMessage(CB_SETDROPPEDWIDTH, (IntPtr)value, default);
            }
        }

        /// <summary>
        /// 置/取项目高度
        /// </summary>
        public int ItemHeight
        {
            get
            {
                return (int)this.SendMessage(CB_GETITEMHEIGHT, default, default);
            }
            set
            {
                this.SendMessage(CB_SETITEMHEIGHT, (IntPtr)(-1), (IntPtr)value);
            }
        }

        /// <summary>
        /// 置/取项目可视数量
        /// </summary>
        public int MinVisible
        {
            get
            {
                return (int)this.SendMessage(CB_GETMINVISIBLE, default, default);
            }
            set
            {
                this.SendMessage(CB_SETMINVISIBLE, (IntPtr)value, default);
            }
        }

        public new string ClassName => "ComboBox";
    }

    /// <summary>
    /// 日期框
    /// </summary>
    public class ExDateBox : ExControl
    {
        public ExDateBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "DateBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExDateBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "DateBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 鼠标绘制板
    /// </summary>
    public class ExDrawingBoard : ExControl
    {
        public ExDrawingBoard(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "DrawingBoard", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExDrawingBoard(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "DrawingBoard", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExDrawingBoard(int hObj) : base(hObj)
        {
        }
        public ExDrawingBoard(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 清空画板
        /// </summary>
        public void Clear()
        {
            this.SendMessage(DBM_CLEAR, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 设置画笔宽度
        /// </summary>
        public int PenWidth
        {
            set
            {
                this.SendMessage(DBM_SETPENWIDTH, IntPtr.Zero, (IntPtr)value);
            }
        }

        /// <summary>
        /// 设置画笔ARGB颜色
        /// </summary>
        public int PenColor
        {
            set
            {
                this.SendMessage(DBM_SETPENCOLOR, IntPtr.Zero, (IntPtr)value);
            }
        }

        /// <summary>
        /// 设置画笔类型 0画笔, 1橡皮
        /// </summary>
        public int PenType
        {
            set
            {
                this.SendMessage(DBM_SETPENTYPE, IntPtr.Zero, (IntPtr)value);
            }
        }
        public new string ClassName => "DrawingBoard";
    }

    /// <summary>
    /// 编辑框
    /// </summary>
    public class ExEdit : ExControl
    {
        public ExEdit(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1)
           : base(pOwner, "Edit", sText, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat)
        {

        }
        public ExEdit(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Edit", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExEdit(int hObj) : base(hObj)
        {
        }
        public ExEdit(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 设置提示文本
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public void SetBanner(string text, int color)
        {
            this.SendMessage(EM_SETCUEBANNER, (IntPtr)color, Marshal.StringToHGlobalUni(text));
        }

        /// <summary>
        /// 添加文本并置指针到末尾
        /// </summary>
        /// <param name="text"></param>
        public void AddText(string text)
        {
            var ptr = Marshal.StringToHGlobalAuto(text);
            this.SendMessage(EM_SETSEL, (IntPtr)(-1), (IntPtr)(-1));
            this.SendMessage(EM_REPLACESEL, (IntPtr)(-1), ptr);
            Marshal.FreeHGlobal(ptr);
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
            Marshal.StructureToPtr(charRange, allocIntPtr, true);
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
        public int GetLineCount()
        {
            return (int)this.SendMessage(EM_GETLINECOUNT, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 寻找选择文本
        /// </summary>
        public void FindText(string find)
        {
            ExTextRange textRange = new ExTextRange();
            textRange.chrg.cpMin = Utility.Util.HIWORD((uint)(this.SendMessage(EM_GETSEL, IntPtr.Zero, IntPtr.Zero)));
            textRange.chrg.cpMax = -1;
            textRange.pwzText = Marshal.StringToHGlobalUni(find);
            int size = Marshal.SizeOf(typeof(ExTextRange));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(textRange, allocIntPtr, true);
            textRange.chrg.cpMin = (int)(this.SendMessage(EM_FINDTEXTW, (IntPtr)1, allocIntPtr));
            if (textRange.chrg.cpMin != -1)
            {
                textRange.chrg.cpMax = textRange.chrg.cpMin + find.Length;
            }
            this.SendMessage(EM_SETSEL, (IntPtr)textRange.chrg.cpMin, (IntPtr)textRange.chrg.cpMax);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        /// <summary>
        /// 取选择链接文本
        /// </summary>
        /// <param name="enlink">富文本NM_EN_LINK通知lParam参数转换</param>
        /// <returns>返回链接文本内容</returns>
        public string GetLinkText(ExEnLink enlink)
        {
            ExTextRange textRange = new ExTextRange
            {
                chrg = new ExCharRange
                {
                    cpMax = enlink.chrg.cpMax,
                    cpMin = enlink.chrg.cpMin
                },
                pwzText = Marshal.AllocHGlobal((enlink.chrg.cpMax - enlink.chrg.cpMin + 2) * 2)
             };
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(textRange));
            Marshal.StructureToPtr<ExTextRange>(textRange, ptr, true);
            this.SendMessage(EM_GETTEXTRANGE, IntPtr.Zero, ptr);
            string retStr = Marshal.PtrToStringUni(textRange.pwzText);
            Marshal.FreeHGlobal(ptr);
            Marshal.FreeHGlobal(textRange.pwzText);
            return retStr;
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
            Marshal.StructureToPtr(textformat, allocIntPtr, true);
            IntPtr strPtr = Marshal.StringToHGlobalUni(replace);
            this.SendMessage(EM_SETTEXTEX, allocIntPtr, strPtr);
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

    /// <summary>
    /// 扩展编辑框
    /// </summary>
    public class ExEditEx : ExControl
    {
        public ExEditEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1)
           : base(pOwner, "EditEx", sText, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat)
        {

        }
        public ExEditEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "EditEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExEditEx(int hObj) : base(hObj)
        {
        }
        public ExEditEx(ExControl parent) : base(parent)
        {
        }

        public ExObjProps Props
        {
            set
            {
                var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExObjProps)));
                Marshal.StructureToPtr(value, ptr, true);
                this.SendMessage(WM_EX_PROPS, IntPtr.Zero, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        /// <summary>
        /// 设置图标
        /// </summary>
        /// <param name="img"></param>
        public ExImage Icon
        {
            set
            {
                this.SendMessage(WM_SETICON, IntPtr.Zero, (IntPtr)value.handle);
            }
        }

        /// <summary>
        /// 添加文本并置指针到末尾
        /// </summary>
        /// <param name="text"></param>
        public void AddText(string text)
        {
            var ptr = Marshal.StringToHGlobalAuto(text);
            this.SendMessage(EM_SETSEL, (IntPtr)(-1), (IntPtr)(-1));
            this.SendMessage(EM_REPLACESEL, (IntPtr)(-1), ptr);
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// 设置提示文本
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public void SetBanner(string text, int color)
        {
            this.SendMessage(EM_SETCUEBANNER, (IntPtr)color, Marshal.StringToHGlobalUni(text));
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
            Marshal.StructureToPtr(charRange, allocIntPtr, true);
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
        public int GetLineCount()
        {
            return (int)this.SendMessage(EM_GETLINECOUNT, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 寻找选择文本
        /// </summary>
        public void FindText(string find)
        {
            ExTextRange textRange = new ExTextRange();
            textRange.chrg.cpMin = Utility.Util.HIWORD((uint)(this.SendMessage(EM_GETSEL, IntPtr.Zero, IntPtr.Zero)));
            textRange.chrg.cpMax = -1;
            textRange.pwzText = Marshal.StringToHGlobalUni(find);
            int size = Marshal.SizeOf(typeof(ExTextRange));
            IntPtr allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(textRange, allocIntPtr, true);
            textRange.chrg.cpMin = (int)(this.SendMessage(EM_FINDTEXTW, (IntPtr)1, allocIntPtr));
            if (textRange.chrg.cpMin != -1)
            {
                textRange.chrg.cpMax = textRange.chrg.cpMin + find.Length;
            }
            this.SendMessage(EM_SETSEL, (IntPtr)textRange.chrg.cpMin, (IntPtr)textRange.chrg.cpMax);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        /// <summary>
        /// 取选择链接文本
        /// </summary>
        /// <param name="enlink">富文本NM_EN_LINK通知lParam参数转换</param>
        /// <returns>返回链接文本内容</returns>
        public string GetLinkText(ExEnLink enlink)
        {
            ExTextRange textRange = new ExTextRange
            {
                chrg = new ExCharRange
                {
                    cpMax = enlink.chrg.cpMax,
                    cpMin = enlink.chrg.cpMin
                },
                pwzText = Marshal.AllocHGlobal((enlink.chrg.cpMax - enlink.chrg.cpMin + 2) * 2)
            };
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(textRange));
            Marshal.StructureToPtr<ExTextRange>(textRange, ptr, true);
            this.SendMessage(EM_GETTEXTRANGE, IntPtr.Zero, ptr);
            string retStr = Marshal.PtrToStringUni(textRange.pwzText);
            Marshal.FreeHGlobal(ptr);
            Marshal.FreeHGlobal(textRange.pwzText);
            return retStr;
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
            Marshal.StructureToPtr(textformat, allocIntPtr, true);
            IntPtr strPtr = Marshal.StringToHGlobalUni(replace);
            this.SendMessage(EM_SETTEXTEX, allocIntPtr, strPtr);
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
        public new string ClassName => "EditEx";
    }

    /// <summary>
    /// 分组框
    /// </summary>
    public class ExGroupBox : ExControl
    {
        public ExGroupBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "GroupBox", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExGroupBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "GroupBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExGroupBox(int hObj) : base(hObj)
        {
        }
        public ExGroupBox(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 标题文本水平偏移
        /// </summary>
        public int TextOffset
        {
            set
            {
                this.SetLong(GROUPBOX_TEXT_OFFSET, (IntPtr)value);
            }
            get
            {
                return (int)this.GetLong(GROUPBOX_TEXT_OFFSET);
            }
        }

        /// <summary>
        /// 线框圆角度
        /// </summary>
        public int Radius
        {
            set
            {
                this.SetLong(GROUPBOX_RADIUS, (IntPtr)value);
            }
            get
            {
                return (int)this.GetLong(GROUPBOX_RADIUS);
            }
        }

        /// <summary>
        /// 线宽
        /// </summary>
        public int StrokeWidth
        {
            set
            {
                this.SetLong(GROUPBOX_STROKEWIDTH, (IntPtr)value);
            }
            get
            {
                return (int)this.GetLong(GROUPBOX_STROKEWIDTH);
            }
        }
        public new string ClassName => "GroupBox";
    }

    /// <summary>
    /// 图标列表框
    /// </summary>
    public class ExIconListView : ExControl
    {
        public ExIconListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "IconListView", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExIconListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "IconListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExIconListView(int hObj) : base(hObj)
        {
        }
        public ExIconListView(ExControl parent) : base(parent)
        {
        }
        public void SetImageSize(int width, int height)
        {
            this.SendMessage(ILVM_SETITEMSIZE, default, (IntPtr)Util.MAKELONG((uint)width, (uint)height));
        }
        public int SetItem(ExIconListViewItemInfo info)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExIconListViewItemInfo)));
            Marshal.StructureToPtr(info, ptr, true);
            var ret = (int)this.SendMessage(LVM_INSERTITEM, IntPtr.Zero, ptr);
            Marshal.FreeHGlobal(ptr);
            return ret;
        }
        public void Update()
        {
            this.SendMessage(LVM_UPDATE);
        }
        public new string ClassName => "IconListView";
    }

    /// <summary>
    /// 列表框项目
    /// </summary>
    public class ExListItem : ExControl
    {
        public ExListItem(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "LISTITEM", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExListItem(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "LISTITEM", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 列表框
    /// </summary>
    public class ExListView : ExControl
    {
        public ExListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ListView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExListView(int hObj) : base(hObj)
        {
        }
        public ExListView(ExControl parent) : base(parent)
        {
        }

        public void ClearAll()
        {
            this.SendMessage(LVM_DELETEALLITEMS, IntPtr.Zero, IntPtr.Zero);
        }

        public int ItemSelect
        {
            set
            {
                this.SendMessage(LVM_SETSELECTIONMARK, (IntPtr)1, (IntPtr)value);
            }
            get
            {
                return (int)this.SendMessage(LVM_GETSELECTIONMARK, IntPtr.Zero, IntPtr.Zero);
            }
        }

        public int ItemCount
        {
            set
            {
                this.SendMessage(LVM_SETITEMCOUNT, (IntPtr)value, (IntPtr)value);
            }
        }
        public new string ClassName => "ListView";
    }

    /// <summary>
    /// 导航按钮
    /// </summary>
    public class ExNavButton : ExControl
    {
        public ExNavButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "NavButtonEx", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExNavButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "NavButtonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExNavButton(int hObj) : base(hObj)
        {
        }
        public ExNavButton(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 置图标
        /// </summary>
        /// <param name="image"></param>
        public void SetIcon(ExImage image)
        {
            this.SendMessage(WM_SETICON, IntPtr.Zero, (IntPtr)image.handle);
        }

        /// <summary>
        /// 置/取消选中,  1选中 0取消选中
        /// </summary>
        /// <returns></returns>
        public bool Check
        {
            set
            {
                this.SendMessage(BM_SETCHECK, (IntPtr)1, (IntPtr)Convert.ToInt32(value));
            }
        }

        /// <summary>
        /// 置图片
        /// </summary>
        /// <param name="type">1 悬浮状态 2按下状态</param>
        /// <param name="image"></param>
        public void SetImage(int type, ExImage image)
        {
            this.SendMessage(BM_SETIMAGE, (IntPtr)type, (IntPtr)image.handle);
        }
        public new string ClassName => "NavButtonEx";
    }

    /// <summary>
    /// 页面
    /// </summary>
    public class ExPage : ExControl
    {
        public ExPage(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Page", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExPage(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Page", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 颜色板
    /// </summary>
    public class ExPalette : ExControl
    {
        public ExPalette(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Palette", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExPalette(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Palette", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 进度条
    /// </summary>
    public class ExProgressBar : ExControl
    {
        public ExProgressBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ProgressBar", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExProgressBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ProgressBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExProgressBar(int hObj) : base(hObj)
        {
        }
        public ExProgressBar(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 设置进度条圆角度
        /// </summary>
        public int Radius
        {
            set
            {
                this.SendMessage(PBM_SETRADIUS, (IntPtr)value, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 设置进度条背景颜色
        /// </summary>
        public int ColorBackground
        {
            set
            {
                this.SendMessage(PBM_SETBKCOLOR, (IntPtr)value, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 设置进度条前景色
        /// </summary>
        public int ColorFont
        {
            set
            {
                this.SendMessage(PBM_SETBARCOLOR, (IntPtr)value, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 取/设置进度条位置
        /// </summary>
        public int Pos
        {
            set
            {
                this.SendMessage(PBM_SETPOS, (IntPtr)value, IntPtr.Zero);
            }
            get
            {
                return (int)this.SendMessage(PBM_GETPOS, IntPtr.Zero, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 取/设置进度条范围
        /// </summary>
        public int Range
        {
            set
            {
                this.SendMessage(PBM_SETRANGE, (IntPtr)value, IntPtr.Zero);
            }
            get
            {
                return (int)this.SendMessage(PBM_GETRANGE, IntPtr.Zero, IntPtr.Zero);
            }
        }
        public new string ClassName => "ProgressBar";
    }

    /// <summary>
    /// 属性框
    /// </summary>
    public class ExPropertyGrid : ExControl
    {
        public ExPropertyGrid(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "PropertyGrid", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExPropertyGrid(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "PropertyGrid", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExPropertyGrid(int hObj) : base(hObj)
        {
        }
        public ExPropertyGrid(ExControl parent) : base(parent)
        {
        }
        public string GetItemValue(string itemName)
        {
            var ret = this.SendMessage(PGM_GETITEMVALUE, IntPtr.Zero, Marshal.StringToHGlobalUni(itemName));
            if(ret != IntPtr.Zero)
            {
                return Marshal.PtrToStringUni(ret);
            }
            return "";
        }

        public void SetItemValue(string itemName, string ItemValue)
        {
            this.SendMessage(PGM_SETITEMVALUE, Marshal.StringToHGlobalUni(ItemValue), Marshal.StringToHGlobalUni(itemName));
        }

        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="type">组件类型 PGT_OBJ_</param>
        /// <param name="info"></param>
        public void AddItem(int type, ExPropergridItemInfo info)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExPropergridItemInfo)));
            Marshal.StructureToPtr(info, ptr, false);
            this.SendMessage(PGM_ADDITEM, (IntPtr)type, ptr);
            Marshal.FreeHGlobal(ptr);
        }

        public new string ClassName => "PropertyGrid";
    }

    /// <summary>
    /// 单选框
    /// </summary>
    public class ExRadioButton : ExControl
    {
        public ExRadioButton(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "Radiobutton", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExRadioButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Radiobutton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 扩展单选框
    /// </summary>
    public class ExRadioButtonEx : ExControl
    {
        public ExRadioButtonEx(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwTextFormat = -1)
            : base(pOwner, "RadiobuttonEx", sText, x, y, nWidth, nHeight, -1, -1, dwTextFormat)
        {
        }
        public ExRadioButtonEx(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "RadiobuttonEx", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 报表列表框
    /// </summary>
    public class ExReportListView : ExControl
    {
        public ExReportListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ReportListView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExReportListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ReportListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExReportListView(int hObj) : base(hObj)
        {
        }
        public ExReportListView(ExControl parent) : base(parent)
        {
        }

        public int ItemSelect
        {
            get
            {
                return (int)this.SendMessage(LVM_GETSELECTIONMARK, IntPtr.Zero, IntPtr.Zero);
            }
            set
            {
                this.SendMessage(LVM_SETSELECTIONMARK, (IntPtr)1, (IntPtr)value);
            }
        }

        public void ClearAll()
        {
            this.SendMessage(LVM_DELETEALLITEMS, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 取/置表头背景色
        /// </summary>
        public int ColorListViewHead
        {
            get
            {
                return ExAPI.Ex_ObjGetColor(m_hObj, COLOR_EX_RLV_HEAD);
            }
            set
            {
                ExAPI.Ex_ObjSetColor(m_hObj, COLOR_EX_RLV_HEAD, value, true);
            }
        }

        /// <summary>
        /// 设置列信息
        /// </summary>
        /// <param name="colInfo"></param>
        public void SetColumn(ExReportListColumnInfo colInfo)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExReportListColumnInfo)));
            Marshal.StructureToPtr(colInfo, ptr, true);
            this.SendMessage(LVM_INSERTCOLUMN, IntPtr.Zero, ptr);
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// 设置行信息,返回索引
        /// </summary>
        /// <param name="rowInfo"></param>
        public int SetRow(ExReportListRowInfo rowInfo)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExReportListRowInfo)));
            Marshal.StructureToPtr(rowInfo, ptr, true);
            var ret = (int)this.SendMessage(LVM_INSERTITEM, IntPtr.Zero, ptr);
            Marshal.FreeHGlobal(ptr);
            return ret;
        }

        /// <summary>
        /// 设置表项
        /// </summary>
        /// <param name="itemInfo"></param>
        public void SetItem(ExReportListItemInfo itemInfo)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExReportListItemInfo)));
            Marshal.StructureToPtr(itemInfo, ptr, true);
            this.SendMessage(LVM_SETITEM, IntPtr.Zero, ptr);
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// 设置单元格
        /// </summary>
        /// <param name="cellInfo"></param>
        public void SetCell(ExReportListCellInfo cellInfo)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExReportListCellInfo)));
            Marshal.StructureToPtr(cellInfo, ptr, true);
            this.SendMessage(LVM_SETCELL, IntPtr.Zero, ptr);
            Marshal.FreeHGlobal(ptr);
        }
        public void Update()
        {
            this.SendMessage(LVM_UPDATE);
        }
        public new string ClassName => "ReportListView";
    }

    /// <summary>
    /// 旋转图片框
    /// </summary>
    public class ExRotateImageBox : ExControl
    {
        public ExRotateImageBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "RotateImageBox", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExRotateImageBox(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "RotateImageBox", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExRotateImageBox(IExBaseUIEle pOwner, byte[] pImageData, int x, int y, int nWidth, int nHeight)
            : base(pOwner, "RotateImageBox", null, x, y, nWidth, nHeight)
        {
            SetBackgroundImage(pImageData, 0, 0, 0, default, 1, 255, true);
        }

        public ExRotateImageBox(IExBaseUIEle pOwner, byte[] pImageData, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(pOwner, "RotateImageBox", null, x, y, nWidth, nHeight, dwStyle, dwStyleEx, -1, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
            SetBackgroundImage(pImageData, 0, 0, 0, default, 1, 255, true);
        }

        public ExRotateImageBox(IExBaseUIEle pOwner, System.Drawing.Bitmap bitmap, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
           : base(pOwner, "RotateImageBox", null, x, y, nWidth, nHeight, dwStyle, dwStyleEx, -1, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
            byte[] img = Util.BitmapToByte(bitmap);
            SetBackgroundImage(img, 0, 0, 0, default, 1, 255, true);
        }
        public ExRotateImageBox(int hObj) : base(hObj)
        {
        }
        public ExRotateImageBox(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "RotateImageBox";
    }

    /// <summary>
    /// 分数按钮
    /// </summary>
    public class ExScoreButton : ExControl
    {
        public ExScoreButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ScoreButton", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExScoreButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ScoreButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExScoreButton(int hObj) : base(hObj)
        {
        }
        public ExScoreButton(ExControl parent) : base(parent)
        {
        }
        /// <summary>
        /// 置图片
        /// </summary>
        /// <param name="type">1 悬浮状态 2按下状态</param>
        /// <param name="image"></param>
        public void SetImage(int type, ExImage image)
        {
            this.SendMessage(BM_SETIMAGE, (IntPtr)type, (IntPtr)image.handle);
        }
        public new string ClassName => "ScoreButton";
    }

    /// <summary>
    /// 滚动条
    /// </summary>
    public class ExScrollBar : ExControl
    {
        public ExScrollBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ScrollBar", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExScrollBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ScrollBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExScrollBar(int hObj) : base(hObj)
        {
        }
        public ExScrollBar(ExControl parent) : base(parent)
        {
        }

        public new string ClassName => "ScrollBar";
    }

    /// <summary>
    /// 滑块条
    /// </summary>
    public class ExSliderBar : ExControl
    {
        public ExSliderBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "SliderBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExSliderBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "SliderBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExSliderBar(int hObj) : base(hObj)
        {
        }
        public ExSliderBar(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 滑块滑动方向 1，横向风格（从右往左）|纵向风格（从下往上）
        /// </summary>
        public int BlockDirection
        {
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, SBL_BLOCK_POINT, (IntPtr)value);
            }
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, SBL_BLOCK_POINT);
            }
        }
        public new string ClassName => "SliderBar";
    }

    /// <summary>
    /// 开关
    /// </summary>
    public class ExSwitch : ExControl
    {
        public ExSwitch(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Switch", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExSwitch(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Switch", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

        public ExObjProps Props
        {
            set
            {
                var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExObjProps)));
                Marshal.StructureToPtr(value, ptr, true);
                this.SendMessage(WM_EX_PROPS, IntPtr.Zero, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        public new string ClassName => "Switch";
    }

    /// <summary>
    /// 标题栏按钮
    /// </summary>
    public class ExSysButton : ExControl
    {
        public ExSysButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle, int dwStyleEx)
            : base(oParent, "SysButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx)
        {
        }
        public ExSysButton(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "SysButton", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
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

    /// <summary>
    /// 模板列表框
    /// </summary>
    public class ExTemplateListView : ExControl
    {
        public ExTemplateListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TListView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExTemplateListView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "TListView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExTemplateListView(int hObj) : base(hObj)
        {
        }
        public ExTemplateListView(ExControl parent) : base(parent)
        {
        }
        public int ItemCount
        {
            set
            {
                this.SendMessage(LVM_SETITEMCOUNT, (IntPtr)value, (IntPtr)value);
            }
        }

        /// <summary>
        /// 表项悬浮色
        /// </summary>
        public int ItemHoverColor
        {
            set
            {
                this.SendMessage(TLVM_SET_ITEM_HOVERCOLOR, IntPtr.Zero, (IntPtr)value);
            }
        }

        public int ItemSelectColor
        {
            set
            {
                this.SendMessage(TLVM_SET_ITEM_SELECTCOLOR, IntPtr.Zero, (IntPtr)value);
            }
        }

        public new string ClassName => "TListView";
    }

    /// <summary>
    /// 树形框
    /// </summary>
    public class ExTreeView : ExControl
    {
        public ExTreeView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TreeView", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExTreeView(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "TreeView", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExTreeView(int hObj) : base(hObj)
        {
        }
        public ExTreeView(ExControl parent) : base(parent)
        {
        }
        public IntPtr InsertItem(ExTreeViewInsertInfo info)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExTreeViewInsertInfo)));
            Marshal.StructureToPtr(info, ptr, true);
            var ret = this.SendMessage(TVM_INSERTITEM, IntPtr.Zero, ptr);
            Marshal.FreeHGlobal(ptr);
            return ret;
        }
        public void Update()
        {
            this.SendMessage(TVM_UPDATE);
        }
        public new string ClassName => "TreeView";
    }

    /// <summary>
    /// Miniblink浏览框
    /// </summary>
    public class ExMiniblinkBrowser : ExControl
    {
        public ExMiniblinkBrowser(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "MbBrowser", sTitle, x, y, nWidth, nHeight)
        {
        }
        public ExMiniblinkBrowser(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "MbBrowser", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExMiniblinkBrowser(int hObj) : base(hObj)
        {
        }
        public ExMiniblinkBrowser(ExControl parent) : base(parent)
        {
        }
        public static bool Initialize(IntPtr libPath, IntPtr dllPath)
        {
            return ExAPI.Ex_ObjMiniblinkBrowserInitialize(libPath, dllPath);
        }
        /// <summary>
        /// 加载url,可以是网址或本地html
        /// </summary>
        public string LoadUrl
        {
            set
            {
                this.SendMessage(MBBM_LOAD, IntPtr.Zero, Marshal.StringToHGlobalUni(value));
            }
        }

        /// <summary>
        /// 执行js
        /// </summary>
        public string RunJS
        {
            set
            {
                this.SendMessage(MBBM_JS, IntPtr.Zero, Marshal.StringToHGlobalUni(value));
            }
        }
        public new string ClassName => "MbBrowser";
    }

    /// <summary>
    /// 菜单条
    /// </summary>
    public class ExMenuBar : ExControl
    {
        public ExMenuBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "MenuBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExMenuBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "MenuBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExMenuBar(int hObj) : base(hObj)
        {
        }
        public ExMenuBar(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 插入项目
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        public IntPtr InsertItem(ExListButtonItemInfo itemInfo)
        {
            IntPtr intptr = Marshal.AllocHGlobal(Marshal.SizeOf(itemInfo));
            Marshal.StructureToPtr(itemInfo, intptr, true);
            var ret = this.SendMessage(LVM_INSERTITEM, (IntPtr)1, intptr);
            Marshal.FreeHGlobal(intptr);
            return ret;
        }
        public new string ClassName => "MenuBar";
    }

    /// <summary>
    /// 工具条
    /// </summary>
    public class ExToolBar : ExControl
    {
        public ExToolBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ToolBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExToolBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "ToolBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExToolBar(int hObj) : base(hObj)
        {
        }
        public ExToolBar(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 插入项目
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        public IntPtr InsertItem(ExListButtonItemInfo itemInfo)
        {
            IntPtr intptr = Marshal.AllocHGlobal(Marshal.SizeOf(itemInfo));
            Marshal.StructureToPtr(itemInfo, intptr, true);
            var ret = this.SendMessage(LVM_INSERTITEM, (IntPtr)1, intptr);
            Marshal.FreeHGlobal(intptr);
            return ret;
        }
        public new string ClassName => "ToolBar";
    }

    /// <summary>
    /// 状态条
    /// </summary>
    public class ExStatusBar : ExControl
    {
        public ExStatusBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "StatusBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExStatusBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "StatusBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExStatusBar(int hObj) : base(hObj)
        {
        }
        public ExStatusBar(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 插入项目
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        public IntPtr InsertItem(ExListButtonItemInfo itemInfo)
        {
            IntPtr intptr = Marshal.AllocHGlobal(Marshal.SizeOf(itemInfo));
            Marshal.StructureToPtr(itemInfo, intptr, true);
            var ret = this.SendMessage(LVM_INSERTITEM, (IntPtr)1, intptr);
            Marshal.FreeHGlobal(intptr);
            return ret;
        }
        public new string ClassName => "StatusBar";
    }

    /// <summary>
    /// 马赛克加载动画
    /// </summary>
    public class ExMosaicLoading : ExControl
    {
        public ExMosaicLoading(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "MosaicLoading", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExMosaicLoading(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "MosaicLoading", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExMosaicLoading(int hObj) : base(hObj)
        {
        }
        public ExMosaicLoading(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "MosaicLoading";
    }

    /// <summary>
    /// Win10加载动画
    /// </summary>
    public class ExWin10Loading : ExControl
    {
        public ExWin10Loading(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "Win10Loading", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExWin10Loading(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "Win10Loading", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExWin10Loading(int hObj) : base(hObj)
        {
        }
        public ExWin10Loading(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "Win10Loading";
    }

    /// <summary>
    /// 标题框
    /// </summary>
    public class ExTitleBar : ExControl
    {
        public ExTitleBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TitleBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExTitleBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "TitleBar", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExTitleBar(int hObj) : base(hObj)
        {
        }
        public ExTitleBar(ExControl parent) : base(parent)
        {
        }
        public new string ClassName => "TitleBar";
    }

    /// <summary>
    /// 卷帘菜单
    /// </summary>
    public class ExRollMenu : ExControl
    {
        public ExRollMenu(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "RollMenu", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExRollMenu(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "RollMenu", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExRollMenu(int hObj) : base(hObj)
        {
        }
        public ExRollMenu(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 删除分组
        /// </summary>
        /// <param name="index">分组索引 从1开始</param>
        public void DelGroup(int index)
        {
            this.SendMessage(RM_DELGROUP, (IntPtr)index, IntPtr.Zero);
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="indexGroup">分组索引 从1开始</param>
        /// <param name="indexItem">项目索引 从1开始</param>
        public void DelItem(int indexGroup,int indexItem)
        {
            this.SendMessage(RM_DELITEM, (IntPtr)indexGroup, (IntPtr)indexItem);
        }

        /// <summary>
        /// 设置分组状态(展开/收缩)
        /// </summary>
        /// <param name="indexGroup">分组索引 从1开始</param>
        /// <param name="expand">是否展开</param>
        public void SetExpand(int indexGroup, bool expand)
        {
            this.SendMessage(RM_SETEXPAND, (IntPtr)indexGroup, (IntPtr)Convert.ToInt32(expand));
        }

        /// 添加分组
        /// </summary>
        /// <param name="indexGroup">分组索引 从1开始</param>
        /// <param name="info">数据</param>
        /// <returns>返回分组索引</returns>
        public int AddGroup(int indexGroup, ExRollMenuGroup info)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExRollMenuGroup)));
            Marshal.StructureToPtr(info, ptr, true);
            var ret = (int)this.SendMessage(RM_ADDGROUP, (IntPtr)indexGroup, ptr);
            Marshal.FreeHGlobal(ptr);
            return ret;
        }

        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="indexGroup">分组索引 从1开始</param>
        /// <param name="info">数据</param>
        /// <returns>返回项目索引</returns>
        public int AddItem(int indexGroup, ExRollMenuItem info)
        {
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExRollMenuItem)));
            Marshal.StructureToPtr(info, ptr, false);
            var ret = (int)this.SendMessage(RM_ADDITEM, (IntPtr)indexGroup, ptr);
            Marshal.FreeHGlobal(ptr);
            return ret;
        }

        /// <summary>
        /// 取选中项目
        /// </summary>
        /// <param name="indexGroup">分组索引</param>
        /// <param name="indexItem">项目索引</param>
        /// <returns>返回标题</returns>
        public string GetSel(ref int indexGroup, ref int indexItem)
        {
            var ptrIndexGroup = Marshal.AllocHGlobal(4);
            var ptrIndexItem = Marshal.AllocHGlobal(4);
            var ret = this.SendMessage(RM_GETSEL, ptrIndexGroup, ptrIndexItem);
            string retStr = "";
            if(ret!=IntPtr.Zero)
            {
                retStr = Marshal.PtrToStringUni(ret);
            }
            indexGroup = Marshal.ReadInt32(ptrIndexGroup);
            indexItem = Marshal.ReadInt32(ptrIndexItem);
            Marshal.FreeHGlobal(ptrIndexGroup);
            Marshal.FreeHGlobal(ptrIndexItem);
            return retStr;
        }

        /// <summary>
        /// 置选中项目
        /// </summary>
        /// <param name="indexGroup">分组索引</param>
        /// <param name="indexItem">项目索引</param>
        public void SetSel(int indexGroup, int indexItem)
        {
            this.SendMessage(RM_SETSEL, (IntPtr)indexGroup, (IntPtr)indexItem);
        }
        public new string ClassName => "RollMenu";
    }

    /// <summary>
    /// 媒体播放器,win10以上,H265格式mp4需要安装Microsoft.HEVCVideoExtension.Appx
    /// </summary>
    public class ExMediaPlay : ExControl
    {
        public ExMediaPlay(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "MediaFoundation", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExMediaPlay(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "MediaFoundation", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExMediaPlay(int hObj) : base(hObj)
        {
        }
        public ExMediaPlay(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 置播放地址
        /// </summary>
        public string StartPlay
        {
            set
            {
                this.SendMessage(MFM_STATE_PLAY, IntPtr.Zero, Marshal.StringToHGlobalUni(value));
            }
        }

        /// <summary>
        /// 暂停/继续 播放
        /// </summary>
        public bool PausePlay
        {
            set
            {
                if(value)
                {
                    this.SendMessage(MFM_STATE_PAUSE, IntPtr.Zero, IntPtr.Zero);
                }
                else
                {
                    this.SendMessage(MFM_STATE_CONTINUE, IntPtr.Zero, IntPtr.Zero);
                }
            }
        }

        /// <summary>
        /// 停止播放
        /// </summary>
        public bool StopPlay
        {
            set
            {
                if (value)
                {
                    this.SendMessage(MFM_STATE_STOP, IntPtr.Zero, IntPtr.Zero);
                }
            }
        }

        /// <summary>
        /// 置播放位置
        /// </summary>
        public int PlayPosition
        {
            set
            {
               this.SendMessage(MFM_SET_POSITION, IntPtr.Zero, (IntPtr)value);
            }
        }
        public new string ClassName => "MediaFoundation";
    }

    public class ExTaggingBoard : ExControl
    {
        public ExTaggingBoard(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "TaggingBoard", sTitle, x, y, nWidth, nHeight)
        {
        }

        public ExTaggingBoard(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight, int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, IntPtr lParam = default, ExObjProcDelegate pfnObjProc = null)
            : base(oParent, "TaggingBoard", sTitle, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat, nID, lParam, IntPtr.Zero, pfnObjProc)
        {
        }
        public ExTaggingBoard(int hObj) : base(hObj)
        {
        }
        public ExTaggingBoard(ExControl parent) : base(parent)
        {
        }

        /// <summary>
        /// 画笔颜色
        /// </summary>
        public int PenColor
        {
            set
            {
                this.SendMessage(TBM_SET_PEN_COLOR, IntPtr.Zero, (IntPtr)value);
            }
        }

        /// <summary>
        /// 标注图
        /// </summary>
        public ExImage TaggingImage
        {
            set
            {
                if (value == null)
                {
                    this.SendMessage(TBM_SET_BKG, IntPtr.Zero, IntPtr.Zero);
                }
                else
                {
                    this.SendMessage(TBM_SET_BKG, IntPtr.Zero, (IntPtr)value.handle);
                }
            }
        }

        /// <summary>
        /// 开始标注
        /// </summary>
        public bool StartTagging
        {
            set
            {
                this.SendMessage(TBM_START, IntPtr.Zero, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 结束标注
        /// </summary>
        public bool StopTagging
        {
            set
            {
                this.SendMessage(TBM_STOP, IntPtr.Zero, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 清空标注
        /// </summary>
        public bool ClearTagging
        {
            set
            {
                this.SendMessage(TBM_CLEAR, IntPtr.Zero, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 取/置标注数据,第一维度是闭合路径数量,第二维度是每条路径点坐标
        /// </summary>
        public List<List<ExPoint>> TaggingData
        {
            get
            {
                var arrPtr = this.SendMessage(TBM_GET_DATA, IntPtr.Zero, IntPtr.Zero);
                var offsetLeft = this.OffsetLeft;
                var offsetTop = this.OffsetTop;
                var scale = this.ImgScale;
                var polygonArr = Util.IntPtrToStructure<ExPolygonArray>(arrPtr);
                List<List<ExPoint>> polygons = new List<List<ExPoint>>();

                for (int i = 0; i < polygonArr.count - 1; i++)
                {
                    var ptr = Marshal.ReadIntPtr(polygonArr.polygons + i * Marshal.SizeOf(typeof(IntPtr)));
                    var polygon = Util.IntPtrToStructure<ExPolygon>(ptr);
                    List<ExPoint> points = new List<ExPoint>();
                    if (polygon.count > 0)
                    {
                        for (int j = 0; j < polygon.count; j++)
                        {
                            IntPtr targetPtrX = IntPtr.Add(polygon.points, j * 8);
                            float x = Marshal.PtrToStructure<float>(targetPtrX);
                            IntPtr targetPtrY = IntPtr.Add(polygon.points, j * 8 + 4);
                            float y = Marshal.PtrToStructure<float>(targetPtrY);
                            var point = new ExPoint();
                            point.x = (int)((x - offsetLeft) * scale);
                            point.y = (int)((y - offsetTop) * scale);
                            points.Add(point);
                        }
                    }
                    polygons.Add(points);
                }
                return polygons;
            }
            set
            {
                var arrPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExPolygonArray)));
                var offsetLeft = this.OffsetLeft;
                var offsetTop = this.OffsetTop;
                var scale = this.ImgScale;
                var polygonArr = new ExPolygonArray();
                polygonArr.count = value.Count;
                polygonArr.polygons = Marshal.AllocHGlobal(value.Count * Marshal.SizeOf(typeof(IntPtr)));
                for (int i = 0; i < polygonArr.count; i++)
                {
                    var points = value[i];
                    var ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(ExPolygon)));
                    var polygon = new ExPolygon();
                    polygon.count = points.Count;
                    polygon.points = Marshal.AllocHGlobal(points.Count * Marshal.SizeOf(typeof(ExPoint)));
                    for (int j = 0; j < points.Count; j++)
                    {
                        float x = (int)(points[j].x / scale + offsetLeft);
                        float y = (int)(points[j].y / scale + offsetTop);
                        IntPtr targetPtrX = IntPtr.Add(polygon.points, j * 8);
                        IntPtr targetPtrY = IntPtr.Add(polygon.points, j * 8 + 4);
                        Marshal.StructureToPtr(x, targetPtrX, false);
                        Marshal.StructureToPtr(y, targetPtrY, false);
                    }
                    Marshal.StructureToPtr<ExPolygon>(polygon, ptr, true);
                    Marshal.WriteIntPtr(polygonArr.polygons + i * Marshal.SizeOf(typeof(IntPtr)), ptr);
                }
                Marshal.StructureToPtr<ExPolygonArray>(polygonArr, arrPtr, true);
                this.SendMessage(TBM_SET_DATA, IntPtr.Zero, arrPtr);
            }
        }

        /// <summary>
        /// 图像缩放系数
        /// </summary>
        public float ImgScale
        {
            get
            {
                var ptr = this.SendMessage(TBM_GET_IMG_SCALE, IntPtr.Zero, IntPtr.Zero);
                var value = Util.IntPtrToFloat(ptr);
                return value;
            }
        }

        /// <summary>
        /// 图像缩放后横坐标偏移
        /// </summary>
        public int OffsetLeft
        {
            get
            {
                return (int)this.SendMessage(TBM_GET_IMG_LEFT_OFFSET, IntPtr.Zero, IntPtr.Zero);
            }
        }

        /// <summary>
        /// 图像缩放后纵坐标偏移
        /// </summary>
        public int OffsetTop
        {
            get
            {
                return (int)this.SendMessage(TBM_GET_IMG_TOP_OFFSET, IntPtr.Zero, IntPtr.Zero);
            }
        }

        public new string ClassName => "TaggingBoard";
    }
}
