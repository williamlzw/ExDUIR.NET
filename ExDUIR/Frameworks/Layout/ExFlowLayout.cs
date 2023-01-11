using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExFlowLayout : ExBaseLayout
    {
        public ExFlowLayout(ExControl objBind)
            : base(ELT_FLOW, objBind)
        {
        }

        public ExFlowLayout(ExSkin objBind)
            : base(ELT_FLOW, objBind)
        {
        }

        public ExFlowLayout(int hLayout)
            : base(hLayout)
        {
        }

        /// <summary>
        /// 取置布局方向, ELP_DIRECTION
        /// </summary>
        public int Direction
        {
            set
            {
                this.SetProp(ELP_FLOW_DIRECTION, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(ELP_FLOW_DIRECTION);
            }
        }

        /// <summary>
        /// 置布局子属性_尺寸 [-1或未填写为组件当前尺寸]
        /// </summary>
        public bool SetSize(ExControl obj, int value)
        {
            return this.SetChildProp(obj, ELCP_FLOW_SIZE, (IntPtr)value);
        }

        /// <summary>
        /// 取布局子属性_尺寸
        /// </summary>
        public bool GetSize(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_FLOW_SIZE, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置布局子属性_组件强制换行
        /// </summary>
        public bool SetNewLine(ExControl obj, bool value)
        {
            return this.SetChildProp(obj, ELCP_FLOW_NEW_LINE, (IntPtr)Convert.ToInt32(value));
        }

        /// <summary>
        /// 取布局子属性_组件强制换行
        /// </summary>
        public bool GetNewLine(ExControl obj, ref bool retValue)
        {
            var ret = this.GetChildProp(obj, ELCP_FLOW_NEW_LINE, out var value);
            retValue = Convert.ToBoolean((int)value);
            return ret;
        }
    }
}
