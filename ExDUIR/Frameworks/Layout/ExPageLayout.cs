using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExPageLayout : ExBaseLayout
    {
        public ExPageLayout(ExControl objBind)
            : base(LAYOUT_TYPE_PAGE, objBind)
        {
        }

        public ExPageLayout(ExSkin objBind)
            : base(LAYOUT_TYPE_PAGE, objBind)
        {
        }

        public ExPageLayout(int hLayout)
            : base(hLayout)
        {
        }

        /// <summary>
        /// 当前显示页面索引
        /// </summary>
        public int Current
        {
            set
            {
                this.SetProp(LAYOUT_PROP_PAGE_CURRENT, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_PAGE_CURRENT);
            }
        }

        /// <summary>
        /// 置布局子属性_是否填充整个布局
        /// </summary>
        public bool SetFill(ExControl obj, bool value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_PAGE_FILL, (IntPtr)Convert.ToInt32(value));
        }

        /// <summary>
        /// 取布局子属性_是否填充整个布局
        /// </summary>
        public bool GetFill(ExControl obj, ref bool retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_PAGE_FILL, out var value);
            retValue = Convert.ToBoolean((int)value);
            return ret;
        }
    }
}
