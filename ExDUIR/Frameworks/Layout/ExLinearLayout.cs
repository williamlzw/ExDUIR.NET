using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExLinearLayout : ExBaseLayout
    {
        public ExLinearLayout(ExControl objBind)
            : base(LAYOUT_TYPE_LINEAR, objBind)
        {
        }

        public ExLinearLayout(ExSkin objBind)
            : base(LAYOUT_TYPE_LINEAR, objBind)
        {
        }

        public ExLinearLayout(int hLayout)
            : base(hLayout)
        {
        }

        /// <summary>
        /// 取置布局方向, LAYOUT_PROP_DIRECTION
        /// </summary>
        public int Direction
        {
            set
            {
                this.SetProp(LAYOUT_PROP_LINEAR_DIRECTION, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_LINEAR_DIRECTION);
            }
        }

        /// <summary>
        /// 取置布局对齐方式, LAYOUT_PROP_LINEAR_DALIGN_
        /// </summary>
        public int Dalign
        {
            set
            {
                this.SetProp(LAYOUT_PROP_LINEAR_DALIGN, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_LINEAR_DALIGN);
            }
        }

        /// <summary>
        /// 置布局子属性 另外一个方向的对齐方式, LAYOUT_SUBPROP_LINEAR_ALIGN_
        /// </summary>
        public bool SetAlign(ExControl obj, int value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_LINEAR_ALIGN, (IntPtr)value);
        }

        /// <summary>
        /// 置布局子属性 另外一个方向的对齐方式, LAYOUT_SUBPROP_LINEAR_ALIGN_
        /// </summary>
        public bool GetAlign(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_LINEAR_ALIGN, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置线性布局子属性_尺寸 [-1或未填写为组件当前尺寸]
        /// </summary>
        public bool SetSize(ExControl obj, int value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_LINEAR_SIZE, (IntPtr)value);
        }

        /// <summary>
        /// 取线性布局子属性_尺寸
        /// </summary>
        public bool GetSize(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_LINEAR_SIZE, out var value);
            retValue = (int)value;
            return ret;
        }
    }
}
