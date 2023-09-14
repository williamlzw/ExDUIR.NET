using System;
using System.Text;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using static ExDuiR.NET.Native.ExConst;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Layout;
using System.Runtime.InteropServices;

namespace ExDuiR.NET.Frameworks
{
    /// <summary>
    /// 界面
    /// </summary>
    public class ExSkin : ExWindow, IExBaseUIEle
    {
        /// <summary>
        /// 创建界面
        /// </summary>
        /// <param name="pOwner">父界面</param>
        /// <param name="sClassName">窗口类名,可以是null</param>
        /// <param name="sWindowName">窗口标题</param>
        /// <param name="x">横坐标</param>
        /// <param name="y">纵坐标</param>
        /// <param name="nWidth">宽度</param>
        /// <param name="nHeight">高度</param>
        /// <param name="dwStyleDUI">界面风格WINDOW_STYLE_</param>
        /// <param name="dwStyle">win32窗口风格</param>
        /// <param name="dwStyleEx">win32窗口扩展风格</param>
        /// <param name="hTheme">主题包句柄,可以空</param>
        /// <param name="pfnWndProc">窗口回调</param>
        public ExSkin(ExSkin pOwner, string sClassName, string sWindowName, int x, int y, int nWidth, int nHeight, int dwStyleDUI,
            int dwStyle = 0, int dwStyleEx = 0, IntPtr hTheme = default, ExWndProcDelegate pfnWndProc = null)
        {
            IntPtr hWndParent = pOwner == null ? IntPtr.Zero : pOwner.Hwnd;
            m_hWnd = ExWindow.Create(hWndParent, sClassName, sWindowName, x, y, nWidth, nHeight, dwStyle, dwStyleEx);
            if (m_hWnd != IntPtr.Zero)
            {
                m_hExDUI = ExAPI.Ex_DUIBindWindowEx(m_hWnd, hTheme, dwStyleDUI, IntPtr.Zero, pfnWndProc);
                if(m_hExDUI != 0)
                {

                }
                else throw new ExException(ExStatus.HANDLE_INVALID, "绑定皮肤失败");
            }
            else throw new ExException(ExStatus.HANDLE_INVALID, "创建窗口失败");
        }

        /// <summary>
        /// 创建界面
        /// </summary>
        /// <param name="pWindow">父窗口</param>
        /// <param name="dwStyleDUI">界面风格WINDOW_STYLE_</param>
        /// <param name="hTheme">主题包句柄,可以空</param>
        /// <param name="pfnWndProc">窗口回调</param>
        public ExSkin(ExWindow pWindow, int dwStyleDUI, IntPtr hTheme = default, ExWndProcDelegate pfnWndProc = null)
        {
            m_hExDUI = ExAPI.Ex_DUIBindWindowEx(pWindow.WindowHandle, hTheme, dwStyleDUI, IntPtr.Zero, pfnWndProc);
            if (m_hExDUI != 0)
            {

            }
            else throw new ExException(ExStatus.HANDLE_INVALID, "绑定皮肤失败");
        }

        /// <summary>
        /// 创建界面
        /// </summary>
        /// <param name="hWnd">父窗口句柄</param>
        /// <param name="dwStyleDUI">界面风格WINDOW_STYLE_</param>
        /// <param name="hTheme">主题包句柄,可以空</param>
        /// <param name="pfnWndProc">窗口回调</param>
        public ExSkin(IntPtr hWnd, int dwStyleDUI, IntPtr hTheme = default, ExWndProcDelegate pfnWndProc = null)
        {
            m_hExDUI = ExAPI.Ex_DUIBindWindowEx(hWnd, hTheme, dwStyleDUI, IntPtr.Zero, pfnWndProc);
            m_hWnd = hWnd;
            if (m_hExDUI != 0)
            {

            }
            else throw new ExException(ExStatus.HANDLE_INVALID, "绑定皮肤失败");
        }

        /// <summary>
        /// 创建界面
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="hExDui">界面句柄</param>
        public ExSkin(IntPtr hWnd, int hExDui)
        {
            m_hWnd = hWnd;
            m_hExDUI = hExDui;
        }

        /// <summary>
        /// 创建界面
        /// </summary>
        /// <param name="hExDui"></param>
        public ExSkin(int hExDui)
        {
            m_hExDUI = hExDui;
        }
        public static ExSkin FromWindow(IntPtr hWnd)
        {
            var hexdui = ExAPI.Ex_DUIFromWindow(hWnd);
            return new ExSkin(hexdui);
        }
        /// <summary>
        /// 启用/禁用窗口
        /// </summary>
        public bool Enable { get => WinAPI.IsWindowEnabled(m_hWnd); set => WinAPI.EnableWindow(m_hWnd, value); }
        
        /// <summary>
        /// 取/置 窗口可视
        /// </summary>
        public bool Visible { get => WinAPI.IsWindowVisible(m_hWnd); set => ExAPI.Ex_DUIShowWindow(m_hExDUI, value ? 1 : 0, 0, 0, 0); }

        protected int m_hExDUI;

        /// <summary>
        /// 界面句柄
        /// </summary>
        public int handle => m_hExDUI;

        /// <summary>
        /// 窗口句柄
        /// </summary>
        public IntPtr Hwnd => m_hWnd;

        /// <summary>
        /// 取客户区矩形
        /// </summary>
        public ExRect ClientRect
        {
            get
            {
                ExAPI.Ex_DUIGetClientRect(m_hExDUI, out var rc);
                return rc;
            }
        }

        /// <summary>
        /// 取窗口矩形
        /// </summary>
        public ExRect WindowRect
        {
            get
            {
                WinAPI.GetWindowRect(m_hWnd, out var rc);
                return rc;
            }
        }

        /// <summary>
        /// 是否是窗口
        /// </summary>
        public bool Validate => WinAPI.IsWindow(m_hWnd) && m_hExDUI != 0;

        /// <summary>
        /// 窗口透明度
        /// </summary>
        public int Alpha
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_ALPHA);
            }
            set =>  ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_ALPHA, (IntPtr)value);
        }

        /// <summary>
        /// 窗口模糊度
        /// </summary>
        public int Blur
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_BLUR);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_BLUR, (IntPtr)value);
            }
        }

        /// <summary>
        /// 窗口背景色
        /// </summary>
        public int BackgroundColor
        {
            set => ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_CRBKG, (IntPtr)value);
            get => (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_CRBKG); 
        }

        /// <summary>
        /// 窗口边框色
        /// </summary>
        public int BorderColor
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_CRBORDER);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_CRBORDER, (IntPtr)value);
            }
        }

        /// <summary>
        /// 窗口阴影色
        /// </summary>
        public int ShadowColor
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_CRSD);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_CRSD, (IntPtr)value);
            }
        }

        /// <summary>
        /// 窗口最小高度
        /// </summary>
        public int MinHeight
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_MINHEIGHT);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_MINHEIGHT, (IntPtr)value);
            }
        }

        /// <summary>
        /// 窗口最小宽度
        /// </summary>
        public int MinWidth
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_MINWIDTH);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_MINWIDTH, (IntPtr)value);
            }
        }

        /// <summary>
        /// 窗口阴影圆角度
        /// </summary>
        public int ShadowRadius
        {
            get
            {
                return (int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_RADIUS);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_RADIUS, (IntPtr)value);
            }
        }

        /// <summary>
        /// 窗口自定义参数
        /// </summary>
        public IntPtr LParam
        {
            get
            {
                return ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_LPARAM);
            }
            set
            {
                ExAPI.Ex_DUISetLong(m_hExDUI, ENGINE_LONG_LPARAM, value);
            }
        }

        /// <summary>
        /// 取/置窗口标题
        /// </summary>
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

        /// <summary>
        /// 标题栏组件
        /// </summary>
        public ExControl Caption
        {
            get
            {
                return new ExControl((int)ExAPI.Ex_DUIGetLong(m_hExDUI, ENGINE_LONG_OBJCAPTION));
            }
        }

        /// <summary>
        /// 取背景图片信息
        /// </summary>
        /// <param name="pImageInfo"></param>
        /// <returns></returns>
        public bool GetBackgroundImage(out ExBackgroundImageInfo pImageInfo)
        {
            return ExAPI.Ex_ObjGetBackgroundImage(m_hExDUI, out pImageInfo);
        }

        /// <summary>
        /// 取引擎数值
        /// </summary>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        public IntPtr GetLong(int nIndex)
        {
            return ExAPI.Ex_DUIGetLong(m_hExDUI, nIndex);
        }

        /// <summary>
        /// 移动窗口
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        public bool Move(int x, int y, int nWidth, int nHeight, bool fRedraw = true)
        {
            return WinAPI.MoveWindow(m_hWnd, x, y, nWidth, nHeight, fRedraw);
        }

        /// <summary>
        /// 非阻塞发送消息
        /// </summary>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public bool PostMessage(int uMsg, IntPtr wParam = new IntPtr(), IntPtr lParam = new IntPtr())
        {
            return WinAPI.PostMessage(m_hWnd, uMsg, wParam, lParam);
        }

        /// <summary>
        /// 阻塞发送消息
        /// </summary>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public IntPtr SendMessage(int uMsg, IntPtr wParam = new IntPtr(), IntPtr lParam = new IntPtr())
        {
            return WinAPI.SendMessage(m_hWnd, uMsg, wParam, lParam);
        }

        /// <summary>
        /// 设置背景图片
        /// </summary>
        /// <param name="bitmap">图片数据</param>
        /// <param name="x">偏移X</param>
        /// <param name="y">偏移Y</param>
        /// <param name="dwRepeat">背景重复模式BIR_</param>
        /// <param name="rcGrids">九宫矩形</param>
        /// <param name="dwFlags">背景标识BIF_</param>
        /// <param name="dwAlpha">透明度</param>
        /// <param name="fUpdate">是否立即刷新</param>
        /// <returns></returns>
        public bool SetBackgroundImage(System.Drawing.Bitmap bitmap, int x, int y, int dwRepeat = BACKGROUND_REPEAT_ZOOM, ExRect rcGrids = default, int dwFlags = BACKGROUND_FLAG_DEFAULT, int dwAlpha = 255, bool fUpdate = true)
        {
            byte[] image = Util.BitmapToByte(bitmap);
            return ExAPI.Ex_ObjSetBackgroundImage(m_hExDUI, image, image == null ? 0 : image.Length, x, y, dwRepeat, ref rcGrids, dwFlags, dwAlpha, fUpdate);
        }

        /// <summary>
        /// 设置背景图片
        /// </summary>
        /// <param name="image">图片数据</param>
        /// <param name="x">偏移X</param>
        /// <param name="y">偏移Y</param>
        /// <param name="dwRepeat">背景重复模式BIR_</param>
        /// <param name="rcGrids">九宫矩形</param>
        /// <param name="dwFlags">背景标识BIF_</param>
        /// <param name="dwAlpha">透明度</param>
        /// <param name="fUpdate">是否立即刷新</param>
        /// <returns></returns>
        public bool SetBackgroundImage(byte[] image, int x, int y, int dwRepeat = BACKGROUND_REPEAT_ZOOM, ExRect rcGrids = default, int dwFlags = BACKGROUND_FLAG_DEFAULT, int dwAlpha = 255, bool fUpdate = true)
        {
            return ExAPI.Ex_ObjSetBackgroundImage(m_hExDUI, image, image.Length, x, y, dwRepeat, ref rcGrids, dwFlags, dwAlpha, fUpdate);
        }

        /// <summary>
        /// 设置背景图播放模式
        /// </summary>
        /// <param name="fPlayFrames">是否播放</param>
        /// <param name="fResetFrame">是否重置当前帧为首帧</param>
        /// <param name="fUpdate">是否立即刷新</param>
        /// <returns></returns>
        public bool SetBackgroundPlayState(bool fPlayFrames, bool fResetFrame, bool fUpdate)
        {
            return ExAPI.Ex_ObjSetBackgroundPlayState(m_hExDUI, fPlayFrames, fResetFrame, fUpdate);
        }

        /// <summary>
        /// 设置引擎数值
        /// </summary>
        /// <param name="nIndex">ENGINE_LONG_</param>
        /// <param name="nValue"></param>
        /// <returns></returns>
        public IntPtr SetLong(int nIndex, IntPtr nValue)
        {
            return ExAPI.Ex_DUISetLong(m_hExDUI, nIndex, nValue);
        }

        /// <summary>
        /// 移动窗口
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <param name="hEleAfter"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        public bool SetPos(int x, int y, int nWidth, int nHeight, IntPtr hEleAfter, int dwFlags)
        {
            return WinAPI.SetWindowPos(m_hWnd, hEleAfter, x, y, nWidth, nHeight, dwFlags);
        }

        /// <summary>
        /// 取组件自组件ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 取组件自组件名称
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 取组件自节点id
        /// </summary>
        /// <param name="nodeid"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 取焦点组件
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 弹出菜单
        /// </summary>
        /// <param name="hMenu">菜单句柄</param>
        /// <param name="uFlags">相关常量 TPM_</param>
        /// <param name="x">弹出坐标X(屏幕坐标)</param>
        /// <param name="y">弹出坐标Y(屏幕坐标)</param>
        /// <param name="nReserved">保留</param>
        /// <param name="pfnWndProc">回调</param>
        /// <param name="dwFlags">相关常量 EMNF_</param>
        /// <returns></returns>
        public bool TrackPopupMenu(IntPtr hMenu, int uFlags, int x, int y, IntPtr nReserved, ExWndProcDelegate pfnWndProc, int dwFlags)
        {
            return ExAPI.Ex_TrackPopupMenu(hMenu, uFlags, x, y, nReserved, m_hExDUI, IntPtr.Zero, pfnWndProc, dwFlags);
        }

        /// <summary>
        /// 获取鼠标所在窗口组件句柄
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="hParent"></param>
        /// <returns></returns>
        public ExControl GetObjFromPoint(int x, int y, int hParent)
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_DUIGetObjFromPoint(hParent, x, y);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        /// <summary>
        /// 寻找组件
        /// </summary>
        /// <param name="pObjChildAfter"></param>
        /// <param name="sClassName"></param>
        /// <param name="sTitle"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 设置组件布局
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public bool SetLayout(ExBaseLayout layout)
        {
            return ExAPI.Ex_ObjLayoutSet(m_hExDUI, layout.handle, true);
        }

        /// <summary>
        /// 设置托盘图标
        /// </summary>
        /// <param name="bitmap">图标</param>
        /// <param name="tipsStr">提示内容</param>
        /// <returns></returns>
        public bool SetTrayIcon(System.Drawing.Icon icon, string tipsStr)
        {
            return ExAPI.Ex_DUITrayIconSet(m_hExDUI, icon.Handle, tipsStr);
        }

        /// <summary>
        /// 设置托盘图标
        /// </summary>
        /// <param name="data">图标数据,可以是png,jpg</param>
        /// <param name="tipsStr">提示内容</param>
        /// <returns></returns>
        public bool SetTrayIcon(byte[] data, string tipsStr)
        {
            var icon = ExAPI.Ex_LoadImageFromMemory(data, (IntPtr)data.Length, IMAGE_ICON, 0);
            return ExAPI.Ex_DUITrayIconSet(m_hExDUI, icon, tipsStr);
        }

        /// <summary>
        /// 弹出托盘通知
        /// </summary>
        /// <param name="info">内容</param>
        /// <param name="title">标题</param>
        /// <param name="flags">常量NIIF_</param>
        /// <returns></returns>
        public bool PopupTrayIcon(string info, string title, int flags)
        {
            return ExAPI.Ex_DUITrayIconPopup(m_hExDUI, info, title, flags);
        }
    }
}
