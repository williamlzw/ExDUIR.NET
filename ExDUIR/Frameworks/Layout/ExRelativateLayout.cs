using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExRelativateLayout : ExBaseLayout
    {
        public ExRelativateLayout(ExControl objBind)
            : base(ELT_RELATIVE, objBind)
        {
        }

        public ExRelativateLayout(ExSkin objBind)
            : base(ELT_RELATIVE, objBind)
        {
        }

        public ExRelativateLayout(int hLayout)
            : base(hLayout)
        {
        }

        /// <summary>
        /// 置相对布局子属性_左侧于(组件)
        /// </summary>
        public bool SetLeftOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_LEFT_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_左侧于(组件)
        /// </summary>
        public bool SetLeftOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_LEFT_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_左侧于(组件)
        /// </summary>
        public bool GetLeftOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_LEFT_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_之上于(组件)
        /// </summary>
        public bool SetTopOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_TOP_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_之上于(组件)
        /// </summary>
        public bool SetTopOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_TOP_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_之上于(组件)
        /// </summary>
        public bool GetTopOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_TOP_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_右侧于(组件)
        /// </summary>
        public bool SetRightOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_RIGHT_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_右侧于(组件)
        /// </summary>
        public bool SetRightOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_RIGHT_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_右侧于(组件)
        /// </summary>
        public bool GetRightOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_RIGHT_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_之下于(组件)
        /// </summary>
        public bool SetBottomOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_BOTTOM_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_之下于(组件)
        /// </summary>
        public bool SetBottomOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_BOTTOM_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_之下于(组件)
        /// </summary>
        public bool GetBottomOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_BOTTOM_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_左对齐于(组件)
        /// </summary>
        public bool SetLeftAlignOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_LEFT_ALIGN_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_左对齐于(组件)
        /// </summary>
        public bool SetLeftAlignOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_LEFT_ALIGN_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_左对齐于(组件)
        /// </summary>
        public bool GetLeftAlignOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_LEFT_ALIGN_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_顶对齐于(组件)
        /// </summary>
        public bool SetTopAlignOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_TOP_ALIGN_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_顶对齐于(组件)
        /// </summary>
        public bool SetTopAlignOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_TOP_ALIGN_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_顶对齐于(组件)
        /// </summary>
        public bool GetTopAlignOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_TOP_ALIGN_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_右对齐于(组件)
        /// </summary>
        public bool SetRightAlignOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_RIGHT_ALIGN_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_右对齐于(组件)
        /// </summary>
        public bool SetRightAlignOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_RIGHT_ALIGN_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_右对齐于(组件)
        /// </summary>
        public bool GetRightAlignOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_RIGHT_ALIGN_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置相对布局子属性_底对齐于(组件)
        /// </summary>
        public bool SetBottomAlignOf(ExControl obj, ExControl obj2)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_BOTTOM_ALIGN_OF, (IntPtr)obj2.handle);
        }

        /// <summary>
        /// 置相对布局子属性_底对齐于(组件)
        /// </summary>
        public bool SetBottomAlignOf(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_BOTTOM_ALIGN_OF, (IntPtr)value);
        }

        /// <summary>
        /// 取相对布局子属性_底对齐于(组件)
        /// </summary>
        public bool GetBottomAlignOf(ExControl obj, ref ExControl retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_BOTTOM_ALIGN_OF, out var value);
            retValue = new ExControl((int)value);
            return ret;
        }

        /// <summary>
        /// 置布局子属性_相对_水平居中于父
        /// </summary>
        public bool SetCenterParentHorizontal(ExControl obj, bool value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_CENTER_PARENT_H, (IntPtr)Convert.ToInt32(value));
        }

        /// <summary>
        /// 取布局子属性_相对_水平居中于父
        /// </summary>
        public bool GetCenterParentHorizontal(ExControl obj, ref bool retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_CENTER_PARENT_H, out var value);
            retValue = Convert.ToBoolean((int)value);
            return ret;
        }

        /// <summary>
        /// 置布局子属性_相对_垂直居中于父
        /// </summary>
        public bool SetCenterParentVertical(ExControl obj, bool value)
        {
            return this.SetChildProp(obj, ELCP_RELATIVE_CENTER_PARENT_V, (IntPtr)Convert.ToInt32(value));
        }

        /// <summary>
        /// 取布局子属性_相对_垂直居中于父
        /// </summary>
        public bool GetCenterParentVertical(ExControl obj, ref bool retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_RELATIVE_CENTER_PARENT_V, out var value);
            retValue = Convert.ToBoolean((int)value);
            return ret;
        }
    }
}
