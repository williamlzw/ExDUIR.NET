using System;
using System.Text;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExControl : IExBaseUIEle, IDisposable
    {
        public ExControl(IExBaseUIEle oParent, string sClassName, string sTitle, int x, int y, int nWidth, int nHeight,
            int dwStyle = -1, int dwStyleEx = -1, int dwTextFormat = -1, int nID = 0, int hTheme = 0, ExObjProcDelegate pfnObjProc = null)
        {
            m_hObj = ExAPI.Ex_ObjCreateEx(dwStyleEx, sClassName, sTitle, dwStyle, x, y, nWidth, nHeight, oParent.handle, nID, dwTextFormat, IntPtr.Zero, hTheme, pfnObjProc);
            if (m_hObj == 0)
            {
                throw new ExException(ExStatus.HANDLE_INVALID, "创建控件失败");
            }
        }

        public ExControl(int hObj)
        {
            m_hObj = hObj;
        }

        public ExControl(ExControl control)
        {
            if(control != null)
            {
                m_hObj = control.handle;
                ClassName = control.ClassName;
                var parentProperties = control.GetType().GetProperties();
                foreach (var parentProperty in parentProperties)
                {
                    var thisProperty = this.GetType().GetProperty(parentProperty.Name, parentProperty.PropertyType);
                    var value = parentProperty.GetValue(control);
                    if (thisProperty != null && value != null && thisProperty.CanWrite)
                    {
                        thisProperty.SetValue(this, value);
                    }
                }
            }
        }

        public void Dispose()
        {
            ExAPI.Ex_ObjDestroy(m_hObj);
            m_hObj = 0;
        }

        /// <summary>
        /// 组件是否有效
        /// </summary>
        public bool Validate => ExAPI.Ex_ObjIsValidate(m_hObj);

        /// <summary>
        /// 组件是否可视
        /// </summary>
        public bool Visible { get => ExAPI.Ex_ObjIsVisible(m_hObj); set => ExAPI.Ex_ObjShow(m_hObj, value); }

        /// <summary>
        /// 组件是否禁止
        /// </summary>
        public bool Enable { get => ExAPI.Ex_ObjIsEnable(m_hObj); set => ExAPI.Ex_ObjEnable(m_hObj, value); }

        protected int m_hObj;

        /// <summary>
        /// 组件句柄
        /// </summary>
        public int handle => m_hObj;

        /// <summary>
        /// 自定义参数
        /// </summary>
        public IntPtr LParam
        {
            get
            {
                return ExAPI.Ex_ObjGetLong(m_hObj, EOL_LPARAM);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_LPARAM, value);
            }
        }

        /// <summary>
        /// 组件回调
        /// </summary>
        public IntPtr ObjProc
        {
            get
            {
                return ExAPI.Ex_ObjGetLong(m_hObj, EOL_OBJPROC);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_OBJPROC, value);
            }
        }

        /// <summary>
        /// 用户数据
        /// </summary>
        public IntPtr UserData
        {
            get
            {
                return ExAPI.Ex_ObjGetLong(m_hObj, EOL_USERDATA);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_USERDATA, value);
            }
        }

        /// <summary>
        /// 组件ID
        /// </summary>
        public int ID
        {
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, EOL_ID);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_ID, (IntPtr)value);
            }
        }

        /// <summary>
        /// 组件透明度
        /// </summary>
        public int Alpha
        {
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, EOL_ALPHA);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_ALPHA, (IntPtr)value);
            }
        }

        /// <summary>
        /// 组件模糊系数
        /// </summary>
        public int Blur
        {
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, EOL_BLUR);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_BLUR, (IntPtr)value);
            }
        }

        /// <summary>
        /// 组件风格
        /// </summary>
        public int Style
        {
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, EOL_STYLE);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_STYLE, (IntPtr)value);
            }
        }

        /// <summary>
        /// 组件扩展风格
        /// </summary>
        public int StyleEx
        {
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, EOL_EXSTYLE);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_EXSTYLE, (IntPtr)value);
            }
        }

        /// <summary>
        /// 组件文本格式
        /// </summary>
        public int TextFormat
        {
            get
            {
                return (int)ExAPI.Ex_ObjGetLong(m_hObj, EOL_TEXTFORMAT);
            }
            set
            {
                ExAPI.Ex_ObjSetLong(m_hObj, EOL_TEXTFORMAT, (IntPtr)value);
            }
        }

        /// <summary>
        /// 组件相对位置矩形
        /// </summary>
        public ExRect Rect
        {
            get
            {
                ExAPI.Ex_ObjGetRect(m_hObj, out ExRect rc);
                return rc;
            }
            set => ExAPI.Ex_ObjMove(m_hObj, value.nLeft, value.nTop, value.nRight - value.nLeft, value.nBottom - value.nTop, true);
        }

        /// <summary>
        /// 组件窗口矩形
        /// </summary>
        public ExRect WindowRect
        {
            get
            {
                ExAPI.Ex_ObjGetRectEx(m_hObj, out ExRect rc, 2);
                return rc;
            }
        }

        /// <summary>
        /// 组件脏区域矩形
        /// </summary>
        public ExRect DirtyRect
        {
            get
            {
                ExAPI.Ex_ObjGetRectEx(m_hObj, out ExRect rc, 3);
                return rc;
            }
        }

        /// <summary>
        /// 组件文本矩形
        /// </summary>
        public ExRect TextRect
        {
            get
            {
                ExAPI.Ex_ObjGetRectEx(m_hObj, out ExRect rc, 4);
                return rc;
            }
        }

        /// <summary>
        /// 组件客户区矩形
        /// </summary>
        public ExRect Client
        {
            get
            {
                ExAPI.Ex_ObjGetClientRect(m_hObj, out ExRect rc);
                return rc;
            }
        }

        /// <summary>
        /// 组件文本
        /// </summary>
        public string Text
        {
            get
            {
                int cch = (int)ExAPI.Ex_ObjGetTextLength(m_hObj);
                StringBuilder sb = new StringBuilder(cch);
                ExAPI.Ex_ObjGetText(m_hObj, sb, (IntPtr)(cch * 2 + 2));
                sb.Length = cch;
                return sb.ToString();
            }
            set
            {
                ExAPI.Ex_ObjSetText(m_hObj, value, true);
            }
        }

        /// <summary>
        /// 组件类名
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 取组件背景图信息
        /// </summary>
        /// <param name="pImageInfo"></param>
        /// <returns></returns>
        public bool GetBackgroundImage(out ExBackgroundImageInfo pImageInfo)
        {
            return ExAPI.Ex_ObjGetBackgroundImage(m_hObj, out pImageInfo);
        }

        /// <summary>
        /// 取组件数值
        /// </summary>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        public IntPtr GetLong(int nIndex)
        {
            return ExAPI.Ex_ObjGetLong(m_hObj, nIndex);
        }

        /// <summary>
        /// 移动组件
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        public bool Move(int x, int y, int nWidth, int nHeight, bool fRedraw = true)
        {
            return ExAPI.Ex_ObjMove(m_hObj, x, y, nWidth, nHeight, fRedraw);
        }

        /// <summary>
        /// 设置组件文本偏移
        /// </summary>
        /// <param name="nPaddingType"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        public bool SetPadding(int nPaddingType, int left, int top, int right, int bottom, bool fRedraw = true)
        {
            return ExAPI.Ex_ObjSetPadding(m_hObj, nPaddingType, left, top, right, bottom, fRedraw);
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
            return ExAPI.Ex_ObjPostMessage(m_hObj, uMsg, wParam, lParam);
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
            return ExAPI.Ex_ObjSendMessage(m_hObj, uMsg, wParam, lParam);
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
        public bool SetBackgroundImage(byte[] image, int x, int y, int dwRepeat = BIR_DEFAULT, ExRect rcGrids = default, int dwFlags = BIF_DEFAULT, int dwAlpha = 255, bool fUpdate = true)
        {
            return ExAPI.Ex_ObjSetBackgroundImage(m_hObj, image, image == null ? 0 : image.Length, x, y, dwRepeat, ref rcGrids, dwFlags, dwAlpha, fUpdate);
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
        public bool SetBackgroundImage(System.Drawing.Bitmap bitmap, int x, int y, int dwRepeat = BIR_DEFAULT, ExRect rcGrids = default, int dwFlags = BIF_DEFAULT, int dwAlpha = 255, bool fUpdate = true)
        {
            byte[] image = Util.BitmapToByte(bitmap);
            return ExAPI.Ex_ObjSetBackgroundImage(m_hObj, image, image == null ? 0 : image.Length, x, y, dwRepeat, ref rcGrids, dwFlags, dwAlpha, fUpdate);
        }

        /// <summary>
        /// 销毁背景图
        /// </summary>
        /// <returns></returns>
        public int DestroyBackground()
        {
            return ExAPI.Ex_ObjDestroyBackground(m_hObj);
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
            return ExAPI.Ex_ObjSetBackgroundPlayState(m_hObj, fPlayFrames, fResetFrame, fUpdate);
        }

        /// <summary>
        /// 设置圆角度
        /// </summary>
        /// <param name="topleft"></param>
        /// <param name="topright"></param>
        /// <param name="bottomright"></param>
        /// <param name="bottomleft"></param>
        /// <param name="fUpdate">是否立即刷新</param>
        /// <returns></returns>
        public bool SetRadius(float topleft, float topright, float bottomright, float bottomleft, bool fUpdate)
        {
            return ExAPI.Ex_ObjSetRadius(m_hObj, topleft, topright, bottomright, bottomleft, fUpdate);
        }

        /// <summary>
        /// 设置模糊度
        /// </summary>
        /// <param name="fDeviation">模糊度</param>
        /// <param name="fUpdate">是否立即刷新</param>
        /// <returns></returns>
        public bool SetBlur(float fDeviation, bool fUpdate)
        {
            return ExAPI.Ex_ObjSetBlur(m_hObj, fDeviation, fUpdate);
        }

        /// <summary>
        /// 设置组件数值
        /// </summary>
        /// <param name="nIndex"></param>
        /// <param name="nValue"></param>
        /// <returns></returns>
        public IntPtr SetLong(int nIndex, IntPtr nValue)
        {
            return ExAPI.Ex_ObjSetLong(m_hObj, nIndex, nValue);
        }

        /// <summary>
        /// 组件设置位置
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <param name="hEleAfter"></param>
        /// <param name="dwFlags">SWP_</param>
        /// <returns></returns>
        public bool SetPos(int x, int y, int nWidth, int nHeight, IntPtr hEleAfter, int dwFlags)
        {
            return ExAPI.Ex_ObjSetPos(m_hObj, hEleAfter, x, y, nWidth, nHeight, dwFlags);
        }

        /// <summary>
        /// 取组件自组件ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ExControl GetObjFromID(int id)
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetFromID(m_hObj, id);
            if (hObj != 0)
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
            int hObj = ExAPI.Ex_ObjGetFromName(m_hObj, name);
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
            int hObj = ExAPI.Ex_ObjGetFromNodeID(m_hObj, nodeid);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        /// <summary>
        /// 取父组件
        /// </summary>
        /// <returns></returns>
        public ExControl GetParent()
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetParent(m_hObj);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        /// <summary>
        /// 置是否可以重画。如果组件扩展风格存在EOS_EX_COMPOSITED,则该函数无效
        /// </summary>
        /// <param name="fRedarw"></param>
        /// <returns></returns>
        public bool CanRedraw(bool fRedarw)
        {
            return ExAPI.Ex_ObjSetRedraw(m_hObj, fRedarw);
        }

        /// <summary>
        /// 挂接事件
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="pfnEvent"></param>
        /// <returns></returns>
        public bool HandleEvent(int nCode, ExObjEventProcDelegate pfnEvent)
        {
            return ExAPI.Ex_ObjHandleEvent(m_hObj, nCode, pfnEvent);
        }

        /// <summary>
        /// 取颜色
        /// </summary>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        public int GetColor(int nIndex)
        {
            return ExAPI.Ex_ObjGetColor(m_hObj, nIndex);
        }

        /// <summary>
        /// 置颜色
        /// </summary>
        /// <param name="nIndex"></param>
        /// <param name="nColor"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        public int SetColor(int nIndex, int nColor, bool fRedraw = true)
        {
            return ExAPI.Ex_ObjSetColor(m_hObj, nIndex, nColor, fRedraw);
        }

        /// <summary>
        /// 开始绘制
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        public bool BeginPaint(out ExPaintStruct ps)
        {
            return ExAPI.Ex_ObjBeginPaint(m_hObj, out ps);
        }

        /// <summary>
        /// 结束绘制
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        public bool EndPaint(ref ExPaintStruct ps)
        {
            return ExAPI.Ex_ObjEndPaint(m_hObj, ref ps);
        }

        /// <summary>
        /// 取焦点组件
        /// </summary>
        /// <returns></returns>
        public ExControl GetFocus()
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetFocus(m_hObj);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        /// <summary>
        /// 删除焦点
        /// </summary>
        /// <returns></returns>
        public bool KillFocus()
        {
            return ExAPI.Ex_ObjKillFocus(m_hObj);
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
            return ExAPI.Ex_TrackPopupMenu(hMenu, uFlags, x, y, nReserved, m_hObj, IntPtr.Zero, pfnWndProc, dwFlags);
        }

        /// <summary>
        /// 取组件内部滚动条句柄,组件带有滚动条风格才生效
        /// </summary>
        /// <param name="nBar"></param>
        /// <returns></returns>
        public int GetScrollControl(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetControl(m_hObj, nBar);
        }

        /// <summary>
        /// 启用/禁用内部滚动条
        /// </summary>
        /// <param name="wSB">滚动条类型SB_</param>
        /// <param name="wArrows">相关常量 ESB_</param>
        /// <returns></returns>
        public bool ScrollEnable(int wSB, int wArrows)
        {
            return ExAPI.Ex_ObjScrollEnable(m_hObj, wSB, wArrows);
        }

        /// <summary>
        /// 取内部滚动条位置
        /// </summary>
        /// <param name="nBar">滚动条类型SB_</param>
        /// <returns></returns>
        public int GetScrollPos(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetPos(m_hObj, nBar);
        }

        /// <summary>
        /// 取内部滚动条范围
        /// </summary>
        /// <param name="nBar">滚动条类型SB_</param>
        /// <param name="lpnMinPos">范围最小值</param>
        /// <param name="lpnMaxPos">范围最大值</param>
        /// <returns></returns>
        public bool GetScrollRange(int nBar, out int lpnMinPos, out int lpnMaxPos)
        {
            return ExAPI.Ex_ObjScrollGetRange(m_hObj, nBar, out lpnMinPos, out lpnMaxPos);
        }

        /// <summary>
        /// 取内部滚动条拖动位置
        /// </summary>
        /// <param name="nBar">滚动条类型SB_</param>
        /// <returns></returns>
        public int GetScrollTrackPos(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetTrackPos(m_hObj, nBar);
        }

        /// <summary>
        /// 置内部滚动条信息
        /// </summary>
        /// <param name="fnBar">滚动条类型SB_</param>
        /// <param name="fMask">SIF_</param>
        /// <param name="nMin">最小值</param>
        /// <param name="nMax">最大值</param>
        /// <param name="nPage">页改变值</param>
        /// <param name="nPos">位置</param>
        /// <param name="fRedraw">是否重画</param>
        /// <returns></returns>
        public int SetScrollInfo(int fnBar, int fMask, int nMin, int nMax, int nPage, int nPos, bool fRedraw)
        {
            return ExAPI.Ex_ObjScrollSetInfo(m_hObj, fnBar, fMask, nMin, nMax, nPage, nPos, fRedraw);
        }

        /// <summary>
        /// 置内部滚动条位置
        /// </summary>
        /// <param name="nBar">滚动条类型SB_</param>
        /// <param name="nPos">位置</param>
        /// <param name="bRedraw">是否重画</param>
        /// <returns></returns>
        public int SetScrollPos(int nBar, int nPos, bool bRedraw)
        {
            return ExAPI.Ex_ObjScrollSetPos(m_hObj, nBar, nPos, bRedraw);
        }

        /// <summary>
        /// 置内部滚动条范围
        /// </summary>
        /// <param name="nBar">滚动条类型SB_</param>
        /// <param name="nMin">最小值</param>
        /// <param name="nMax">最大值</param>
        /// <param name="bRedraw">是否重画</param>
        /// <returns></returns>
        public bool SetScrollRange(int nBar, int nMin, int nMax, bool bRedraw)
        {
            return ExAPI.Ex_ObjScrollSetRange(m_hObj, nBar, nMin, nMax, bRedraw);
        }

        /// <summary>
        /// 取内部滚动条信息
        /// </summary>
        /// <param name="nBar">滚动条类型SB_</param>
        /// <param name="lpnMin">返回最小值</param>
        /// <param name="lpnMax">返回最大值</param>
        /// <param name="lpnPos">返回位置</param>
        /// <param name="lpnTrackPos">返回拖动位置</param>
        /// <returns></returns>
        public bool GetScrollInfo(int nBar, out int lpnMin, out int lpnMax, out int lpnPos, out int lpnTrackPos)
        {
            return ExAPI.Ex_ObjScrollGetInfo(m_hObj, nBar, out lpnMin, out lpnMax, out lpnPos, out lpnTrackPos);
        }

        /// <summary>
        /// 显示/隐藏内部滚动条
        /// </summary>
        /// <param name="wBar">滚动条类型SB_</param>
        /// <param name="fShow">是否重画</param>
        /// <returns></returns>
        public bool ScrollShow(int wBar, bool fShow)
        {
            return ExAPI.Ex_ObjScrollShow(m_hObj, wBar, fShow);
        }

        /// <summary>
        /// 置组件回调
        /// </summary>
        /// <param name="pfnObjProc"></param>
        /// <returns></returns>
        public IntPtr SubClass(ExObjProcDelegate pfnObjProc)
        {

            return ExAPI.Ex_ObjSetLong(m_hObj, ExConst.EOL_OBJPROC, pfnObjProc);
        }

        /// <summary>
        /// 组件调用过程,用于基于现有的组件扩展新的组件
        /// </summary>
        /// <param name="pfnObjProc"></param>
        /// <param name="hWnd"></param>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <param name="pvData"></param>
        /// <returns></returns>
        public static IntPtr CallProc(IntPtr pfnObjProc, IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData)
        {
            return ExAPI.Ex_ObjCallProc(pfnObjProc, hWnd, hObj, uMsg, wParam, lParam, pvData);
        }

        /// <summary>
        /// 组件默认过程,用于重新扩展新的组件
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public static IntPtr CallDefProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam)
        {
            return ExAPI.Ex_ObjDefProc(hWnd, hObj, uMsg, wParam, lParam);
        }

        /// <summary>
        /// 分发消息
        /// </summary>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public IntPtr DispatchMessage(int uMsg, IntPtr wParam, IntPtr lParam)
        {
            return ExAPI.Ex_ObjDispatchMessage(m_hObj, uMsg, wParam, lParam);
        }

        /// <summary>
        /// 分发事件
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public IntPtr DispatchNotify(int nCode, IntPtr wParam, IntPtr lParam)
        {
            return ExAPI.Ex_ObjDispatchNotify(m_hObj, nCode, wParam, lParam);
        }

        /// <summary>
        /// 客户区坐标到屏幕坐标
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool ClientToScreen(ref int x, ref int y)
        {
            return ExAPI.Ex_ObjClientToScreen(m_hObj, ref x, ref y);
        }

        /// <summary>
        /// 客户区坐标到窗口坐标
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool ClientToWindow(ref int x, ref int y)
        {
            return ExAPI.Ex_ObjClientToWindow(m_hObj, ref x, ref y);
        }

        /// <summary>
        /// 重画组件
        /// </summary>
        /// <returns></returns>
        public bool Invalidate()
        {
            ExRect rect = new ExRect();
            return ExAPI.Ex_ObjInvalidateRect(m_hObj, ref rect);
        }

        /// <summary>
        /// 重画组件
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public bool Invalidate(ExRect rc)
        {
            return ExAPI.Ex_ObjInvalidateRect(m_hObj, ref rc);
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
            int hObjAfter = pObjChildAfter == null ? 0: pObjChildAfter.handle;
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjFind(m_hObj, hObjAfter, sClassName, sTitle);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        /// <summary>
        /// 取特定关系组件
        /// </summary>
        /// <param name="nCmd">相关常量 #GW_</param>
        /// <returns></returns>
        public ExControl GetObj(int nCmd)
        {
            ExControl ctrl = null;
            int hObj = ExAPI.Ex_ObjGetObj(m_hObj, nCmd);
            if (hObj != 0)
            {
                ctrl = new ExControl(hObj);
            }
            return ctrl;
        }

        /// <summary>
        /// 枚举子组件
        /// </summary>
        /// <param name="pfnEnum"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public bool EnumChild(ExObjEnumCallbackDelegate pfnEnum, IntPtr lParam)
        {
            return ExAPI.Ex_ObjEnumChild(m_hObj, pfnEnum, lParam);
        }

        /// <summary>
        /// 弹出或关闭提示文本
        /// </summary>
        /// <param name="sText">提示文本</param>
        /// <param name="sTitle">标题内容</param>
        /// <param name="x">屏幕坐标.(-1:默认)</param>
        /// <param name="y">屏幕坐标.(-1:默认)</param>
        /// <param name="nTime">单位:毫秒.(-1:默认,0:始终显示)</param>
        /// <param name="nIcon"></param>
        /// <param name="fShow"></param>
        /// <returns></returns>
        public bool PopupTips(string sText, string sTitle = null, int x = -1, int y = -1, int nTime = -1, int nIcon = 0, bool fShow = false)
        {
            return ExAPI.Ex_ObjTooltipsPopEx(m_hObj, sTitle, sText, x, y, nTime, nIcon, fShow);
        }

        private int m_nTimer = 0;

        /// <summary>
        /// 置/取 组件时钟
        /// </summary>
        public int Timer
        {
            get => m_nTimer;
            set
            {
                if (value <= 0)
                {
                    ExAPI.Ex_ObjKillTimer(m_hObj);
                    m_nTimer = 0;
                }
                else
                {
                    if (m_nTimer != 0)
                        ExAPI.Ex_ObjKillTimer(m_hObj);
                    ExAPI.Ex_ObjSetTimer(m_hObj, value);
                    m_nTimer = value;
                }
            }
        }

        /// <summary>
        /// 初始化属性表
        /// </summary>
        /// <param name="nPropCount"></param>
        /// <returns></returns>
        public bool InitPropList(int nPropCount)
        {
            return ExAPI.Ex_ObjInitPropList(m_hObj, nPropCount);
        }

        /// <summary>
        /// 取组件属性
        /// </summary>
        /// <param name="nKey"></param>
        /// <returns></returns>
        public IntPtr GetProp(IntPtr nKey)
        {
            return ExAPI.Ex_ObjGetProp(m_hObj, nKey);
        }

        /// <summary>
        /// 置组件属性
        /// </summary>
        /// <param name="nKey"></param>
        /// <param name="nValue"></param>
        /// <returns></returns>
        public IntPtr SetProp(IntPtr nKey, IntPtr nValue)
        {
            return ExAPI.Ex_ObjSetProp(m_hObj, nKey, nValue);
        }

        /// <summary>
        /// 移除组件属性
        /// </summary>
        /// <param name="nKey"></param>
        /// <returns></returns>
        public IntPtr RemoveProp(IntPtr nKey)
        {
            return ExAPI.Ex_ObjRemoveProp(m_hObj, nKey);
        }

        /// <summary>
        /// 枚举组件属性
        /// </summary>
        /// <param name="pfnEnum"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public int EnumProps(ExObjPropEnumCallbackDelegate pfnEnum, IntPtr lParam)
        {
            return ExAPI.Ex_ObjEnumProps(m_hObj, pfnEnum, lParam);
        }

        /// <summary>
        /// 置组件字体
        /// </summary>
        /// <param name="sName">字体名称</param>
        /// <param name="nSize">字体尺寸</param>
        /// <param name="dwStyle">字体风格</param>
        /// <param name="fRedraw">是否重画</param>
        /// <returns></returns>
        public bool SetFont(string sName = null, int nSize = -1, int dwStyle = 0, bool fRedraw = true)
        {
            return ExAPI.Ex_ObjSetFontFromFamily(m_hObj, sName, nSize, dwStyle, fRedraw);
        }

        /// <summary>
        /// 坐标转换
        /// </summary>
        /// <param name="pObjDest"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PointTransform(ExControl pObjDest, ref int x, ref int y)
        {
            int hObj = pObjDest == null ? 0 : pObjDest.handle;
            ExAPI.Ex_ObjPointTransform(m_hObj, hObj, ref x, ref y);
        }

        /// <summary>
        /// 是否启用绘画中消息
        /// </summary>
        /// <param name="fEnable"></param>
        public void EnablePaintingMsg(bool fEnable)
        {
            ExAPI.Ex_ObjEnablePaintingMsg(m_hObj, fEnable);
        }

        /// <summary>
        /// 取拖曳文本
        /// </summary>
        /// <param name="pDataObject"></param>
        /// <param name="lpwzBuffer"></param>
        /// <param name="cchMaxLength"></param>
        /// <returns></returns>
        public int GetDropString(int pDataObject, out string lpwzBuffer, int cchMaxLength)
        {
            StringBuilder str = new StringBuilder(cchMaxLength);
            var ret = ExAPI.Ex_ObjGetDropString(m_hObj, pDataObject, str, cchMaxLength);
            lpwzBuffer = str.ToString();
            return ret;
        }

        /// <summary>
        /// 校验拖曳格式
        /// </summary>
        /// <param name="pDataObject"></param>
        /// <param name="dwFormat"></param>
        /// <returns></returns>
        public bool CheckDropFormat(IntPtr pDataObject, int dwFormat)
        {
            return ExAPI.Ex_ObjCheckDropFormat(m_hObj, pDataObject, dwFormat);
        }

        /// <summary>
        /// 取组件字体
        /// </summary>
        /// <returns></returns>
        public ExFont GetFont()
        {
            return new ExFont(ExAPI.Ex_ObjGetFont(m_hObj));
        }

        /// <summary>
        /// 设置组件布局
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public bool SetLayout(ExBaseLayout layout)
        {
            return ExAPI.Ex_ObjLayoutSet(m_hObj, layout.handle, true);
        }

        /// <summary>
        /// 设置图标列表
        /// </summary>
        /// <param name="imageList"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        public IntPtr SetImageList(ExImageList imageList)
        {
            return this.SendMessage(LVM_SETIMAGELIST, (IntPtr)1, imageList.handle);
        }
    }
}
