using System;
using System.Text;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;

namespace ExDuiR.NET.Frameworks
{
    public class ExSkin : ExWindow, IExBaseUIEle
    {

        public ExSkin(ExSkin pOwner, string sClassName, string sWindowName, int x, int y, int nWidth, int nHeight, int dwStyleDUI,
            int dwStyle = 0, int dwStyleEx = 0, int hTheme = 0, ExWndProcDelegate pfnWndProc = null)
        {
            nint hWndParent = pOwner == null ? 0 : pOwner.Hwnd;
            m_hWnd = ExWindow.Create(hWndParent, sClassName, sWindowName, x, y, nWidth, nHeight, dwStyle, dwStyleEx);
            if (m_hWnd != 0)
            {
                m_hExDUI = ExAPI.Ex_DUIBindWindowEx(m_hWnd, hTheme, dwStyleDUI, 0, pfnWndProc);
                if(m_hExDUI != 0)
                {

                }
                else throw new ExException(ExStatus.HANDLE_INVALID, "绑定皮肤失败");
            }
            else throw new ExException(ExStatus.HANDLE_INVALID, "创建窗口失败");
        }

        public ExSkin(ExWindow pWindow, int dwStyleDUI, int hTheme, ExWndProcDelegate pfnWndProc = null)
        {
            m_hExDUI = ExAPI.Ex_DUIBindWindowEx(pWindow.WindowHandle, hTheme, dwStyleDUI, 0, pfnWndProc);
            if (m_hExDUI != 0)
            {

            }
            else throw new ExException(ExStatus.HANDLE_INVALID, "绑定皮肤失败");
        }

        public ExSkin(ExSkin pOwner, byte[] pLayout, int hTheme = 0)
        {
            nint hWndParent = pOwner == null ? 0 : (nint)pOwner.handle;
            if(ExAPI.Ex_DUICreateFromLayout(hWndParent, hTheme, pLayout, pLayout.Length, out m_hWnd, out m_hExDUI))
            {

            }
            else throw new ExException(ExStatus.HANDLE_INVALID, "绑定皮肤失败");
        }
        
        public ExSkin(nint hWnd, int hExDui)
        {
            m_hWnd = hWnd;
            m_hExDUI = hExDui;
        }


        public bool Enable { get => WinAPI.IsWindowEnabled(m_hWnd); set => WinAPI.EnableWindow(m_hWnd, value); }
        public bool Visible { get => WinAPI.IsWindowVisible(m_hWnd); set => ExAPI.Ex_DUIShowWindow(m_hExDUI, value ? 1 : 0, 0, 0, 0); }

        protected int m_hExDUI;
        public int handle => m_hExDUI;
        public nint Hwnd => m_hWnd;

        public bool Validate => WinAPI.IsWindow(m_hWnd) && m_hExDUI != 0;

        public string Text {
            get
            {
                int cch = WinAPI.GetWindowTextLength(m_hWnd);
                StringBuilder sb = new StringBuilder(cch);
                WinAPI.GetWindowText(m_hWnd, sb, cch + 1);
                return sb.ToString();
            }
            set
            {
                WinAPI.SetWindowText(m_hWnd, value);
            }
        }

        public bool GetBackgroundImage(out ExBackgroundImageInfo pImageInfo)
        {
            return ExAPI.Ex_ObjGetBackgroundImage(m_hExDUI, out pImageInfo);
        }

        public nint GetLong(int nIndex)
        {
            return ExAPI.Ex_DUIGetLong(m_hExDUI, nIndex);
        }

        public bool Move(int x, int y, int nWidth, int nHeight, bool fRedraw = true)
        {
            return WinAPI.MoveWindow(m_hWnd, x, y, nWidth, nHeight, fRedraw);
        }

        public bool PostMessage(int uMsg, nint wParam = new nint(), nint lParam = new nint())
        {
            return WinAPI.PostMessage(m_hWnd, uMsg, wParam, lParam);
        }

        public nint SendMessage(int uMsg, nint wParam = new nint(), nint lParam = new nint())
        {
            return WinAPI.SendMessage(m_hWnd, uMsg, wParam, lParam);
        }

        public bool SetBackgroundImage(byte[] image, int x, int y, int dwRepeat, nint rcGrids, int dwFlags, int dwAlpha, bool fUpdate)
        {
            return ExAPI.Ex_ObjSetBackgroundImage(m_hExDUI, image, image.Length, x, y, dwRepeat, rcGrids, dwFlags, dwAlpha, fUpdate);
        }

        public bool SetBackgroundPlayState(bool fPlayFrames, bool fResetFrame, bool fUpdate)
        {
            return ExAPI.Ex_ObjSetBackgroundPlayState(m_hExDUI, fPlayFrames, fResetFrame, fUpdate);
        }

        public nint SetLong(int nIndex, nint nValue)
        {
            return ExAPI.Ex_DUISetLong(m_hExDUI, nIndex, nValue);
        }

        public bool SetPos(int x, int y, int nWidth, int nHeight, nint hEleAfter, int dwFlags)
        {
            return WinAPI.SetWindowPos(m_hWnd, hEleAfter, x, y, nWidth, nHeight, dwFlags);
        }

        public ExControl GetObjFromID(int id)
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetFromID(m_hExDUI, id);
            if(hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        public ExControl GetObjFromName(string name)
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetFromName(m_hExDUI, name);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        public ExControl GetObjFromNodeID(int nodeid)
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetFromNodeID(m_hExDUI, nodeid);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        public ExControl GetFocus()
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetFocus(m_hExDUI);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        public bool TrackPopupMenu(nint hMenu, int uFlags, int x, int y, nint nReserved, ref ExRect pRc, ExWndProcDelegate pfnWndProc, int dwFlags)
        {
            return ExAPI.Ex_TrackPopupMenu(hMenu, uFlags, x, y, nReserved, m_hExDUI, ref pRc, pfnWndProc, dwFlags);
        }

        public bool LoadLayoutXml(byte[] pLayout, nint hRes)
        {
            return ExAPI.Ex_ObjLoadFromLayout(m_hExDUI, hRes, pLayout, pLayout.Length);
        }

        public ExControl Find(ExControl pObjChildAfter = null, string sClassName = null, string sTitle = null)
        {
            int hObjAfter = pObjChildAfter == null ? 0 : pObjChildAfter.handle;
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjFind(m_hExDUI, hObjAfter, sClassName, sTitle);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }
    }
}
