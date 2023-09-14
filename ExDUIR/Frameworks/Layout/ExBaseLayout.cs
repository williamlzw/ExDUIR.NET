using System;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExBaseLayout : IDisposable
    {
        protected int m_hLayout;

        public int handle => m_hLayout;

        public ExBaseLayout(int nType, ExControl objBind)
        {
            m_hLayout = ExAPI._layout_create(nType, objBind.handle);
        }

        public ExBaseLayout(int nType, ExSkin objBind)
        {
            m_hLayout = ExAPI._layout_create(nType, objBind.handle);
        }

        public ExBaseLayout(int hLayout)
        {
            m_hLayout = hLayout;
        }

        /// <summary>
        /// 置内间距_左
        /// </summary>
        public int PaddingLeft
        {
            set
            {
                this.SetProp(LAYOUT_PROP_PADDING_LEFT, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_PADDING_LEFT);
            }
        }

        /// <summary>
        /// 置内间距_右
        /// </summary>
        public int PaddingRight
        {
            set
            {
                this.SetProp(LAYOUT_PROP_PADDING_RIGHT, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_PADDING_RIGHT);
            }
        }

        /// <summary>
        /// 置内间距_上
        /// </summary>
        public int PaddingTop
        {
            set
            {
                this.SetProp(LAYOUT_PROP_PADDING_TOP, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_PADDING_TOP);
            }
        }

        /// <summary>
        /// 置内间距_下
        /// </summary>
        public int PaddingBottom
        {
            set
            {
                this.SetProp(LAYOUT_PROP_PADDING_BOTTOM, (IntPtr)value);
            }
            get
            {
                return (int)this.GetProp(LAYOUT_PROP_PADDING_BOTTOM);
            }
        }

        /// <summary>
        /// 置子组件外间距_左
        /// </summary>
        public bool SetMarginLeft(ExControl obj, int value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_MARGIN_LEFT, (IntPtr)value);
        }

        /// <summary>
        /// 取子组件外间距_左
        /// </summary>
        public bool GetMarginLeft(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_MARGIN_LEFT, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置子组件外间距_上
        /// </summary>
        public bool SetMarginTop(ExControl obj, int value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_MARGIN_TOP, (IntPtr)value);
        }

        /// <summary>
        /// 取子组件外间距_上
        /// </summary>
        public bool GetMarginTop(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_MARGIN_TOP, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置子组件外间距_右
        /// </summary>
        public bool SetMarginRight(ExControl obj, int value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_MARGIN_RIGHT, (IntPtr)value);
        }

        /// <summary>
        /// 取子组件外间距_右
        /// </summary>
        public bool GetMarginRight(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_MARGIN_RIGHT, out var value);
            retValue = (int)value;
            return ret;
        }

        /// <summary>
        /// 置子组件外间距_底
        /// </summary>
        public bool SetMarginBottom(ExControl obj, int value)
        {
            return this.SetChildProp(obj, LAYOUT_SUBPROP_MARGIN_BOTTOM, (IntPtr)value);
        }

        /// <summary>
        /// 取子组件外间距_底
        /// </summary>
        public bool GetMarginBottom(ExControl obj, ref int retValue)
        {
            var ret = this.GetChildProp(obj, LAYOUT_SUBPROP_MARGIN_BOTTOM, out var value);
            retValue = (int)value;
            return ret;
        }

        public void Dispose()
        {
            ExAPI._layout_destroy(m_hLayout);
            m_hLayout = 0;
        }

        public bool AddChild(ExControl obj)
        {
            return ExAPI._layout_addchild(m_hLayout, obj.handle);
        }

        public bool AddChildren(bool fDesc, int dwObjClassAtom, out int nCount)
        {
            return ExAPI._layout_addchildren(m_hLayout, fDesc, dwObjClassAtom, out nCount);
        }

        public bool DeleteChild(ExControl obj)
        {
            return ExAPI._layout_deletechild(m_hLayout, obj.handle);
        }

        public bool DeleteChildren(int dwObjClassATOM)
        {
            return ExAPI._layout_deletechildren(m_hLayout, dwObjClassATOM);
        }

        public bool SetChildProp(ExControl obj, int dwPropID, IntPtr pvValue)
        {
            return ExAPI._layout_setchildprop(m_hLayout, obj.handle, dwPropID, pvValue);
        }

        public bool SetProp(int dwPropID, IntPtr pvValue)
        {
            return ExAPI._layout_setprop(m_hLayout, dwPropID, pvValue);
        }

        public bool Update()
        {
            return ExAPI._layout_update(m_hLayout);
        }

        public bool EnableUpdate
        {
            set
            {
                ExAPI._layout_enableupdate(m_hLayout, value);
            }
        }

        public bool GetChildProp(ExControl obj, int dwPropID, out IntPtr pvValue)
        {
            return ExAPI._layout_getchildprop(m_hLayout, obj.handle, dwPropID, out pvValue);
        }

        public bool GetChildPropList(ExControl obj, out IntPtr lpProps)
        {
            return ExAPI._layout_getchildproplist(m_hLayout, obj.handle, out lpProps);
        }

        public IntPtr GetProp(int dwPropID)
        {
            return ExAPI._layout_getprop(m_hLayout, dwPropID);
        }

        public IntPtr GetPropList()
        {
            return ExAPI._layout_getproplist(m_hLayout);
        }

        public int Type
        {
            get
            {
                return ExAPI._layout_gettype(m_hLayout);
            }
        }

        public IntPtr Notify(int nEvent, IntPtr wParam, IntPtr lParam)
        {
            return ExAPI._layout_notify(m_hLayout, nEvent, wParam, lParam);
        }
    }
}
