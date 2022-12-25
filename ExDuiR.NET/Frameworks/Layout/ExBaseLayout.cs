using System;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Native;

namespace ExDuiR.NET.Frameworks.Layout
{
    class ExBaseLayout : IDisposable
    {
        protected int m_hLayout;

        public int handle => m_hLayout;

        public ExBaseLayout(int nType, ExControl objBind)
        {
            m_hLayout = ExAPI._layout_create(nType, objBind.handle);
        }

        public ExBaseLayout(int hLayout)
        {
            m_hLayout = hLayout;
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
