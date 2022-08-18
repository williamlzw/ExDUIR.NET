using System;
using System.Runtime.InteropServices;
using static ExDuiR.NET.Native.ExConst;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Utility;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExEdit : ExControl
    {
        public ExEdit(IExBaseUIEle pOwner, string sText, int x, int y, int nWidth, int nHeight, int dwStyle=-1, int dwStyleEx=-1, int dwTextFormat = -1)
           : base(pOwner, "Edit", sText, x, y, nWidth, nHeight, dwStyle, dwStyleEx, dwTextFormat)
        {

        }

        /// <summary>
        /// 加载rtf文件
        /// </summary>
        /// <param name="data"></param>
        public void LoadRtf(byte[] data)
        {
            nint allocIntPtr = Marshal.AllocHGlobal(data.Length);
            try
            {
                Marshal.Copy(data, 0, allocIntPtr, data.Length);
                this.SendMessage(EM_LOAD_RTF, (nint)data.Length, allocIntPtr);
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
            nint allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(charRange, allocIntPtr, false);
            this.SendMessage(EM_EXSETSEL, 0, allocIntPtr);
            Marshal.FreeHGlobal(allocIntPtr);
        }

        public void CancelSelect()
        {
            this.SendMessage(EM_SETSEL, 0, 0);
        }

        /// <summary>
        /// 置选择
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void Select(int start, int end)
        {
            this.SendMessage(EM_SETSEL, (nint)start, (nint)end);
        }

        /// <summary>
        /// 撤销
        /// </summary>
        public void Undo()
        {
            this.SendMessage(EM_UNDO, 0, 0);
        }

        /// <summary>
        /// 重做
        /// </summary>
        public void Redo()
        {
            this.SendMessage(EM_REDO, 0, 0);
        }

        /// <summary>
        /// 复制
        /// </summary>
        public void Copy()
        {
            this.SendMessage(WM_COPY, 0, 0);
        }

        /// <summary>
        /// 剪切
        /// </summary>
        public void Cut()
        {
            this.SendMessage(WM_CUT, 0, 0);
        }

        /// <summary>
        /// 粘贴
        /// </summary>
        public void Paste()
        {
            this.SendMessage(WM_PASTE, 0, 0);
        }

        /// <summary>
        /// 删除
        /// </summary>
        public void Clear()
        {
            this.SendMessage(WM_CLEAR, 0, 0);
        }

        /// <summary>
        /// 取行数
        /// </summary>
        public nint GetLineCount()
        {
            return this.SendMessage(EM_GETLINECOUNT, 0, 0);
        }

        /// <summary>
        /// 寻找选择文本
        /// </summary>
        public void FindText(string find)
        {
            ExTextRange textRange = new ExTextRange();
            textRange.chrg.cpMin = Utility.Util.HIWORD(Convert.ToUInt32(this.SendMessage(EM_GETLINECOUNT, 0, 0)));
            textRange.chrg.cpMax = -1;
            textRange.pwzText = Marshal.StringToHGlobalAnsi(find);
            int size = Marshal.SizeOf(typeof(ExTextRange));
            nint allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(textRange, allocIntPtr, false);       
            textRange.chrg.cpMin = Convert.ToInt32(this.SendMessage(EM_FINDTEXTW, (nint)1, allocIntPtr));
            if(textRange.chrg.cpMin!=-1)
            {
                textRange.chrg.cpMax = textRange.chrg.cpMin + Marshal.SizeOf(textRange.pwzText);
            }
            this.SendMessage(EM_SETSEL, (nint)textRange.chrg.cpMin, (nint)textRange.chrg.cpMax);
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
            nint allocIntPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(textformat, allocIntPtr, false);
            nint strPtr = Marshal.StringToHGlobalUni(replace);
            this.SendMessage(EM_SETSEL, allocIntPtr, strPtr);
            Marshal.FreeHGlobal(allocIntPtr);
            Marshal.FreeHGlobal(strPtr);
        }

        /// <summary>
        /// 置选中行段落左对齐
        /// </summary>
            public void AlignLeft()
        {
            ExAPI.Ex_ObjEditSetSelParFormat(m_hObj, PFM_ALIGNMENT, 0, 0, 0,0, PFA_LEFT);
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
        public void SetSelCharFont(string fontName, int  size)
        {
            ExAPI.Ex_ObjEditSetSelCharFormat(m_hObj, CFM_FACE | CFM_SIZE, 0, fontName, size, 0, false, false, false, false, false);
        }



        public new string ClassName => "Edit";
    }
}
