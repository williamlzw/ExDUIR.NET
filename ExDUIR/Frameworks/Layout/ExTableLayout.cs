using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExTableLayout : ExBaseLayout
    {
        public ExTableLayout(ExControl objBind)
            : base(ELT_TABLE, objBind)
        {
        }

        public ExTableLayout(ExSkin objBind)
            : base(ELT_TABLE, objBind)
        {
        }

        public ExTableLayout(int hLayout)
            : base(hLayout)
        {
        }

        /// <summary>
        /// 设置表格信息
        /// </summary>
        /// <param name="aRowHeight">行高数组,正数为像素,负数为百分比</param>
        /// <param name="cRows">行数</param>
        /// <param name="aCellWidth">列宽数组,正数为像素,负数为百分比</param>
        /// <param name="cCells">列数</param>
        /// <returns></returns>
        public bool SetInfo(int[] aRowHeight, int cRows, int[] aCellWidth, int cCells)
        {
            return ExAPI._layout_table_setinfo(m_hLayout, aRowHeight, cRows, aCellWidth, cCells);
        }

        /// <summary>
        /// 置所在行
        /// </summary>
        public bool SetRow(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_TABLE_ROW, (IntPtr)value);
        }

        /// <summary>
        /// 取所在行
        /// </summary>
        public bool GetRow(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_TABLE_ROW, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置所在列
        /// </summary>
        public bool SetCell(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_TABLE_CELL, (IntPtr)value);
        }

        /// <summary>
        /// 取所在列
        /// </summary>
        public bool GetCell(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_TABLE_CELL, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置跨行数
        /// </summary>
        public bool SetRowSpan(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_TABLE_ROW_SPAN, (IntPtr)value);
        }

        /// <summary>
        /// 取跨行数
        /// </summary>
        public bool GetRowSpan(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_TABLE_ROW_SPAN, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置跨列数
        /// </summary>
        public bool SetCellSpan(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_TABLE_CELL_SPAN, (IntPtr)value);
        }

        /// <summary>
        /// 取跨列数
        /// </summary>
        public bool GetCellSpan(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_TABLE_CELL_SPAN, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置是否填满
        /// </summary>
        public bool SetFill(ExControl obj, bool value)
        {
            return this.SetChildProp(obj, ELCP_TABLE_FILL, (IntPtr)Convert.ToInt32(value));
        }

        /// <summary>
        /// 取是否填满
        /// </summary>
        public bool GetFill(ExControl obj, ref bool retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_TABLE_FILL, out var value);
            retValue = Convert.ToBoolean((int)value);
            return ret;
        }
    }
}
