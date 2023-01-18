using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static ExDuiR.NET.Native.WinAPI;

namespace ExDuiR.NET.Native
{
    public delegate IntPtr ExWndProcDelegate(IntPtr hWnd, int hExDui, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult);
    public delegate IntPtr ExObjProcDelegate(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult);
    public delegate IntPtr ExObjClassProcDelegate(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData);
    public delegate IntPtr ExObjEventProcDelegate(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam);
    public delegate IntPtr ExLayoutProcDelegate(IntPtr pLayout, int nEvent, IntPtr wParam, IntPtr lParam);
    public delegate bool ExObjEnumCallbackDelegate(int hObj, IntPtr lParam);
    public delegate IntPtr ExObjPropEnumCallbackDelegate(int hObj, IntPtr nKey, IntPtr nValue, IntPtr lParam);
    public delegate void ExCefBeforeCommandLineCallbackDelegate(int uMsg, IntPtr handler, int hObj, IntPtr attach1, IntPtr attach2, IntPtr attach3, IntPtr attach4, IntPtr pbHWEBVIEWd, IntPtr lParam);
    public delegate IntPtr ExEasingProcDelegate(IntPtr pEasing, double nProgress, double nCurrent, IntPtr pContext, int nTimeSurplus, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4);

    public struct ExRectF
    {
        public float nLeft;
        public float nTop;
        public float nRight;
        public float nBottom;
    }

    public struct ExRect
    {
        public int nLeft;
        public int nTop;
        public int nRight;
        public int nBottom;
    }

    public struct ExPoint
    {
        public int x;
        public int y;
    }

    /// <summary>
    /// 绘制信息结构
    /// </summary>
    public struct ExPaintStruct
    {
        /// <summary>
        /// 画布句柄
        /// </summary>
        public int hCanvas;
        /// <summary>
        /// 主题句柄
        /// </summary>
        public IntPtr hTheme;
        /// <summary>
        /// 风格
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 扩展风格
        /// </summary>
        public int dwStyleEx;
        /// <summary>
        /// 文本格式
        /// </summary>
        public int dwTextFormat;
        /// <summary>
        /// 状态
        /// </summary>
        public int dwState;
        /// <summary>
        /// 用户数据
        /// </summary>
        public IntPtr dwOwnerData;
        /// <summary>
        /// 宽度
        /// </summary>
        public int nWidth;
        /// <summary>
        /// 高度
        /// </summary>
        public int nHeight;
        /// <summary>
        /// 绘制矩形
        /// </summary>
        public ExRect rcPaint;
        /// <summary>
        /// 文本矩形
        /// </summary>
        public ExRect rcText;
        /// <summary>
        /// 保留
        /// </summary>
        public IntPtr dwReserved;
    }

    /// <summary>
    /// 自定义绘制信息结构
    /// </summary>
    public struct ExCustomDraw
    {
        /// <summary>
        /// 画布句柄
        /// </summary>
        public int hCanvas;
        /// <summary>
        /// 主题句柄
        /// </summary>
        public int hTheme;
        /// <summary>
        /// 状态
        /// </summary>
        public int dwState;
        /// <summary>
        /// 风格
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 绘制矩形左边
        /// </summary>
        public int nLeft;
        /// <summary>
        /// 绘制矩形顶边
        /// </summary>
        public int nTop;
        /// <summary>
        /// 绘制矩形右边
        /// </summary>
        public int nRight;
        /// <summary>
        /// 绘制矩形底边
        /// </summary>
        public int nBottom;
        /// <summary>
        /// 项目索引
        /// </summary>
        public int iItem;
        /// <summary>
        /// 项目信息指针
        /// </summary>
        public IntPtr nItemParam;
    }

    /// <summary>
    /// 背景信息结构
    /// </summary>
    public struct ExBackgroundImageInfo
    {
        /// <summary>
        /// 标识
        /// </summary>
        public int dwFlags;
        /// <summary>
        /// 图片句柄
        /// </summary>
        public int hImage;
        /// <summary>
        /// 左上角横坐标
        /// </summary>
        public int x;
        /// <summary>
        /// 左上角纵坐标
        /// </summary>
        public int y;
        /// <summary>
        /// 重复方式
        /// </summary>
        public int dwRepeat;
        /// <summary>
        /// 九宫矩形
        /// </summary>
        public IntPtr lpGrid;
        /// <summary>
        /// 延时信息
        /// </summary>
        public IntPtr lpDelay;
        /// <summary>
        /// 当前帧
        /// </summary>
        public int nCurFrame;
        /// <summary>
        /// 最大帧
        /// </summary>
        public int nMaxFrame;
        /// <summary>
        /// 透明度
        /// </summary>
        public int nAlpha;     
    }


    /// <summary>
    /// 组件类信息结构
    /// </summary>
    public struct ExClassInfo
    {
        /// <summary>
        /// 组件标识
        /// </summary>
        public int dwFlags;
        /// <summary>
        /// 基础风格
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 扩展风格
        /// </summary>
        public int dwStyleEx;
        /// <summary>
        /// 文本格式
        /// </summary>
        public int dwTextFormat;
        /// <summary>
        /// 类附加属性尺寸
        /// </summary>
        public int cbObjExtra;
        /// <summary>
        /// 鼠标句柄
        /// </summary>
        public IntPtr hCursor;
        /// <summary>
        /// 类回调
        /// </summary>
        public IntPtr pfnProc;
        /// <summary>
        /// 类名
        /// </summary>
        public int atomName;
    }

    /// <summary>
    /// 接收WM_NOTIFY通知信息结构
    /// </summary>
    public struct ExNMHDR
    {
        /// <summary>
        /// 组件句柄
        /// </summary>
        public int hObjFrom;
        /// <summary>
        /// 组件ID
        /// </summary>
        public int idFrom;
        /// <summary>
        /// 通知消息
        /// </summary>
        public int nCode;
        /// <summary>
        /// 无符号整数 通常是一个与消息有关的常量值，也可能是窗口或控件的句柄
        /// </summary>
        public IntPtr wParam;
        /// <summary>
        /// 通常是一个指向内存中数据的指针
        /// </summary>
        public IntPtr lParam;
    }

    /// <summary>
    /// 列表框信息结构,列表框NM_CALCSIZE通知EX_NMHDR.lParam结构体
    /// </summary>
    public struct ExListViewInfo
    {
        /// <summary>
        /// 项目宽度
        /// </summary>
        public int widthItem;
        /// <summary>
        /// 项目高度
        /// </summary>
        public int heightItem;
        /// <summary>
        /// 间隔宽度
        /// </summary>
        public int widthInterval;
        /// <summary>
        /// 间隔高度
        /// </summary>
        public int heightInterval;
        /// <summary>
        /// 特殊项目宽度
        /// </summary>
        public int widthSpec;
        /// <summary>
        /// 特殊项目高度
        /// </summary>
        public int heightSpec;
        /// <summary>
        /// 项目总宽度
        /// </summary>
        public int widthView;
        /// <summary>
        /// 项目总高度
        /// </summary>
        public int heightView;
        /// <summary>
        /// 选中项目数
        /// </summary>
        public int countSelects;
        /// <summary>
        /// 项目总数
        /// </summary>
        public int countItems;
        /// <summary>
        /// 可视总数量
        /// </summary>
        public int countView;
        /// <summary>
        /// 可视横向数量
        /// </summary>
        public int countViewHorizontal;
        /// <summary>
        /// 可视纵向数量
        /// </summary>
        public int countViewVertical;
        /// <summary>
        /// 当前选中索引
        /// </summary>
        public int indexSelect;
        /// <summary>
        /// 悬浮项目索引
        /// </summary>
        public int indexHover;
        /// <summary>
        /// 可视起始项目索引
        /// </summary>
        public int indexStart;
        /// <summary>
        /// 可视结束项目索引
        /// </summary>
        public int indexEnd;
        /// <summary>
        /// 列表命中类型
        /// </summary>
        public int nHittest;
        /// <summary>
        /// 列表水平偏移
        /// </summary>
        public int nOffsetX;
        /// <summary>
        /// 列表垂直偏移
        /// </summary>
        public int nOffsetY;
        /// <summary>
        /// 列表项目状态信息
        /// </summary>
        public IntPtr lpItems; 
    }

    public struct NMHDR
    {
        /// <summary>
        /// 来源窗口
        /// </summary>
        public IntPtr hwndFrom;
        /// <summary>
        /// 来源组件id
        /// </summary>
        public IntPtr idFrom;
        /// <summary>
        /// 事件
        /// </summary>
        public int code;
    }

    /// <summary>
    /// 缓动信息结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct ExEasingInfo
    {
        /// <summary>
        /// 缓动指针
        /// </summary>
        public IntPtr pEasing;
        /// <summary>
        /// 进度0到1
        /// </summary>
        public double nProgress;
        /// <summary>
        /// 当前值
        /// </summary>
        public double nCurrent;
        /// <summary>
        /// 缓动参数
        /// </summary>
        public IntPtr pEasingContext;
        /// <summary>
        /// 剩余数
        /// </summary>
        public int nTimesSurplus;
        /// <summary>
        /// 参数1
        /// </summary>
        public IntPtr nParam1;
        /// <summary>
        /// 参数2
        /// </summary>
        public IntPtr nParam2;
        /// <summary>
        /// 参数3
        /// </summary>
        public IntPtr nParam3;
        /// <summary>
        /// 参数4
        /// </summary>
        public IntPtr nParam4;
    }

    /// <summary>
    /// 图像像素数据结构
    /// </summary>
    public struct ExBitmapData
    {
        /// <summary>
        /// 宽度
        /// </summary>
        public int nWidth;
        /// <summary>
        /// 高度
        /// </summary>
        public int nHeight;
        /// <summary>
        /// 步长
        /// </summary>
        public int nStride;
        /// <summary>
        /// 像素格式
        /// </summary>
        public int nPixelFormat;
        /// <summary>
        /// scan0指针
        /// </summary>
        public IntPtr pScan0;
        /// <summary>
        /// 保留
        /// </summary>
        public IntPtr nReserved;
    }

    /// <summary>
    /// 扩展控件属性信息结构
    /// </summary>
    public struct ExObjProps
    {
        /// <summary>
        /// 背景颜色.正常
        /// </summary>
        public int crBkgNormal;
        /// <summary>
        /// 背景颜色.悬浮
        /// </summary>
        public int crBkgHover;
        /// <summary>
        /// 背景颜色.按下或者选中
        /// </summary>
        public int crBkgDownOrChecked;
        /// <summary>
        /// 渐变背景.起点颜色ARGB
        /// </summary>
        public int crBkgBegin;
        /// <summary>
        /// 渐变背景.终点颜色ARGB
        /// </summary>
        public int crBkgEnd;
        /// <summary>
        /// 边框颜色.正常
        /// </summary>
        public int crBorderNormal;
        /// <summary>
        /// 边框颜色.悬浮
        /// </summary>
        public int crBorderHover;
        /// <summary>
        /// 边框颜色.按下或者选中
        /// </summary>
        public int crBorderDownOrChecked;
        /// <summary>
        /// 渐变边框.起点颜色ARGB
        /// </summary>
        public int crBorderBegin;
        /// <summary>
        /// 渐变边框.终点颜色ARGB
        /// </summary>
        public int crBorderEnd;
        /// <summary>
        /// 图标颜色.正常
        /// </summary>
        public int crIconNormal;
        /// <summary>
        /// 图标颜色.悬浮
        /// </summary>
        public int crIconHover;
        /// <summary>
        /// 图标颜色.按下或者焦点
        /// </summary>
        public int crIconDownOrFocus;
        /// <summary>
        /// 圆角度
        /// </summary>
        public int radius;
        /// <summary>
        /// 线宽
        /// </summary>
        public int strokeWidth;
        /// <summary>
        /// 图标位置 [忽略/0：左; 1：右; 2:上]
        /// </summary>
        public int nIconPosition;           
    }

    /// <summary>
    /// 报表列信息结构
    /// </summary>
    public struct ExReportListColumnInfo
    {
        /// <summary>
        /// 表头标题，unicode
        /// </summary>
        public IntPtr pwzText;
        /// <summary>
        /// 列宽度
        /// </summary>
        public int nWidth;
        /// <summary>
        /// 表头风格 ERLV_CS_
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 列文本格式 DT_
        /// </summary>
        public int dwTextFormat;
        /// <summary>
        /// 列文本颜色 argb
        /// </summary>
        public int crText;
        /// <summary>
        /// 插入位置,0为在最后
        /// </summary>
        public int nInsertIndex; 
    };

    /// <summary>
    /// 报表项目信息结构
    /// </summary>
    public struct ExReportListItemInfo
    {
        /// <summary>
        /// 所在行[IN / OUT]
        /// </summary>
        public int iRow;
        /// <summary>
        /// 所在列[IN / OUT]
        /// </summary>
        public int iCol;
        /// <summary>
        /// 项目行风格(同行共用)
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 项目文本,unicode
        /// </summary>
        public IntPtr pwzText;
        /// <summary>
        /// 项目图片组索引(同行共用)
        /// </summary>
        public int nImageIndex;
        /// <summary>
        /// 项目参数(同行共用)
        /// </summary>
        public IntPtr lParam;
        /// <summary>
        /// 项目状态(同行共用)
        /// </summary>
        public int dwState;    
    };

    /// <summary>
    /// 报表行信息结构
    /// </summary>
    public struct ExReportListRowInfo
    {
        /// <summary>
        /// 插入位置,0为最后
        /// </summary>
        public int nInsertIndex;
        /// <summary>
        /// 项目行风格 ERLV_RS_
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 项目附加参数
        /// </summary>
        public IntPtr lParam;
        /// <summary>
        /// 图片组索引
        /// </summary>
        public int nImageIndex;     
    };

    /// <summary>
    /// 报表排序信息结构
    /// </summary>
    public struct ExReportListSortInfo
    {
        /// <summary>
        /// 0为按row.lParam排序
        /// </summary>
        public int iCol;
        /// <summary>
        /// 0:文本,1:整数
        /// </summary>
        public int nType;
        /// <summary>
        /// 排序回调LRESULT orderProc(HEXOBJ hObj,UINT nIndex1,LPVOID pvData1,UINT nIndex2,LPVOID pvData2,UINT nIndexCol,UINT nType,size_t lParam)
        /// </summary>
        public IntPtr lpfnCmp;
        /// <summary>
        /// 是否倒序
        /// </summary>
        public bool fDesc;
        /// <summary>
        /// 排序附加参数
        /// </summary>
        public IntPtr lParam;                  
    };

    /// <summary>
    /// 树形框节点信息结构,不能改变成员顺序
    /// </summary>
    public struct ExTreeViewNodeItem
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        public int nID;
        /// <summary>
        /// 项目标题,unicode
        /// </summary>
        public IntPtr pwzText;
        /// <summary>
        /// 项目附加参数
        /// </summary>
        public IntPtr lParam;
        /// <summary>
        /// 收缩图片索引
        /// </summary>
        public int nImageIndex;
        /// <summary>
        /// 扩展图片索引
        /// </summary>
        public int nImageIndexExpand;
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool fExpand;
        /// <summary>
        /// 风格
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 层次
        /// </summary>
        public int nDepth;
        /// <summary>
        /// 父节点
        /// </summary>
        public IntPtr pParent;
        /// <summary>
        /// 上一个节点
        /// </summary>
        public IntPtr pPrev;
        /// <summary>
        /// 下一个节点
        /// </summary>
        public IntPtr pNext;
        /// <summary>
        /// 第一个子节点
        /// </summary>
        public IntPtr pChildFirst;
        /// <summary>
        /// 子节点数量
        /// </summary>
        public int nCountChild;                 
    };

    /// <summary>
    /// 树形框表项信息结构,不能改变成员顺序
    /// </summary>
    public struct ExTreeViewItemInfo
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        public int nID;
        /// <summary>
        /// 项目标题,unicode
        /// </summary>
        public IntPtr pwzText;
        /// <summary>
        /// 项目附加参数
        /// </summary>
        public IntPtr lParam;
        /// <summary>
        /// 收缩图片索引
        /// </summary>
        public int nImageIndex;
        /// <summary>
        /// 扩展图片索引
        /// </summary>
        public int nImageIndexExpand;
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool fExpand;
        /// <summary>
        /// 风格
        /// </summary>
        public int dwStyle;          
    };

    /// <summary>
    /// 树形框插入项目信息结构
    /// </summary>
    public struct ExTreeViewInsertInfo
    {
        /// <summary>
        /// 父项句柄（0为根项）
        /// </summary>
        public IntPtr itemParent;
        /// <summary>
        /// 插入在此项之后（必须是同层）
        /// </summary>
        public IntPtr itemInsertAfter;
        /// <summary>
        /// 项目ID
        /// </summary>
        public int nID;
        /// <summary>
        /// 项目标题,unicode
        /// </summary>
        public IntPtr pwzText;
        /// <summary>
        /// 项目附加参数
        /// </summary>
        public IntPtr lParam;
        /// <summary>
        /// 收缩图片索引
        /// </summary>
        public int nImageIndex;
        /// <summary>
        /// 展开图片索引
        /// </summary>
        public int nImageIndexExpand;
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool fExpand;
        /// <summary>
        /// 风格
        /// </summary>
        public int dwStyle;
        /// <summary>
        /// 是否暂不更新(统一用TVM_UPDATE更新)
        /// </summary>
        public bool fUpdateLater;                    
    };

    /// <summary>
    /// 图标列表框插入信息结构
    /// </summary>
    public struct ExIconListViewItemInfo
    {
        /// <summary>
        /// 插入位置
        /// </summary>
        public int nIndex;
        /// <summary>
        /// 图片索引
        /// </summary>
        public int nImageIndex;
        /// <summary>
        /// 文本,unicode
        /// </summary>
        public IntPtr pwzText;  
    };

    /// <summary>
    /// 图像属性信息
    /// </summary>
    public struct ExImageInfo
    {
        /// <summary>
        /// 图像.正常
        /// </summary>
        public IntPtr imgNormal;
        /// <summary>
        /// 图像.悬浮
        /// </summary>
        public IntPtr imgHover;
        /// <summary>
        /// 图像.按下或者选中
        /// </summary>
        public IntPtr imgDownOrChecked; 
    };

    /// <summary>
    /// 拖曳信息结构
    /// </summary>
    public struct ExDropInfo
    {
        /// <summary>
        /// 数据对象指针IDataObject*
        /// </summary>
        public IntPtr pDataObject;
        /// <summary>
        /// 功能键状态
        /// </summary>
        public int grfKeyState;
        /// <summary>
        /// 鼠标水平位置
        /// </summary>
        public int x;
        /// <summary>
        /// 鼠标垂直位置
        /// </summary>
        public int y;             
    };

    /// <summary>
    /// 富文本框EM_EXSETSEL消息lParam参数结构
    /// </summary>
    public struct ExCharRange
    {
        public int cpMin;
        public int cpMax;
    };

    /// <summary>
    /// 富文本框EM_GETTEXTRANGE,EM_FINDTEXT消息接收lParam参数
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct ExTextRange
    {
        public ExCharRange chrg;
        public IntPtr pwzText;
    };

    /// <summary>
    /// 富文本框EN_SELCHANGE消息lParam参数结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ExSelChange
    {
        public NMHDR nmhdr;
        public ExCharRange chrg;
        public ushort seltyp;
    };

    /// <summary>
    /// 富文本框EN_LINK消息lParam参数结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct ExEnLink
    {
        public NMHDR nmhdr;
        public int msg;
        public IntPtr wParam;
        public IntPtr lParam;
        public ExCharRange chrg;
    };

    /// <summary>
    /// 富文本框替换文本信息结构
    /// </summary>
    public struct ExSetTextEx
    {
        public int flags;
        public int codePage;
    };

    /// <summary>
    /// 列表按钮项目信息结构
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ExListButtonItemInfo
    {
        /// <summary>
        /// 1,图片 2,标题 4,提示文本 8,状态 16,菜单 32,文本格式 64,宽度
        /// </summary>
        public int dwMask;
        /// <summary>
        /// 项目类型   0,分隔条 1,普通按钮 2,选择按钮
        /// </summary>
        public int nType;
        /// <summary>
        /// 插入索引,从1开始
        /// </summary>
        public int nIndex;
        /// <summary>
        /// 图片索引
        /// </summary>
        public int nImage;
        /// <summary>
        /// 项目标题,IntPtr传值
        /// </summary>
        public IntPtr wzText;
        /// <summary>
        /// 项目提示文本,IntPtr传值
        /// </summary>
        public IntPtr wzTips;
        /// <summary>
        /// 项目左边
        /// </summary>
        public int nLeft;
        /// <summary>
        /// 项目宽度
        /// </summary>
        public int nWidth;
        /// <summary>
        /// 项目状态   可取STATE_NORMAL,STATE_DOWN,STATE_FOCUS,STATE_DISABLE
        /// </summary>
        public int dwState;
        /// <summary>
        /// 项目菜单
        /// </summary>
        public IntPtr nMenu;
        /// <summary>
        /// 项目文本格式
        /// </summary>
        public int iTextFormat;
    };

    /// <summary>
    /// 日期框信息结构
    /// </summary>
    public struct ExDateTimeInfo
    {
        /// <summary>
        /// 年
        /// </summary>
        public int Year;
        /// <summary>
        /// 月   1-12
        /// </summary>
        public int Mon;
        /// <summary>
        /// 日   1-31
        /// </summary>
        public int Mday;
        /// <summary>
        /// 星期 1-7 7=星期日
        /// </summary>
        public int Wday;			
    };

    /// <summary>
    /// API声明
    /// </summary>
    public class ExAPI
    {
        /// <summary>
        /// 初始化引擎
        /// </summary>
        /// <param name="hInstance">值可为0</param>
        /// <param name="dwGlobalFlags">相关常量:#EXGF_ .(值可为0)</param>
        /// <param name="hDefaultCursor">默认鼠标指针.(值可为0)</param>
        /// <param name="lpszDefaultClassName">默认窗口类名.(值可为0)</param>
        /// <param name="lpDefaultTheme">默认主题包指针</param>
        /// <param name="dwDefaultThemeLen">默认主题包长度</param>
        /// <param name="lpDefaultI18N">默认语言包指针.(值可为0)</param>
        /// <param name="dwDefaultI18NLen">默认语言包长度.(值可为0)</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Init")]
        public static extern bool Ex_Init(IntPtr hInstance, int dwGlobalFlags, IntPtr hDefaultCursor,
            string lpszDefaultClassName, byte[] lpDefaultTheme, IntPtr dwDefaultThemeLen, byte[] lpDefaultI18N, IntPtr dwDefaultI18NLen);

        /// <summary>
        /// 反初始化引擎
        /// </summary>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_UnInit")]
        public static extern void Ex_UnInit();

        /// <summary>
        /// 获取最后错误代码.相关常量 :#ERROR_EX_
        /// </summary>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_GetLastError")]
        public static extern int Ex_GetLastError();

        /// <summary>
        /// 图像创建自内存
        /// </summary>
        /// <param name="lpData"></param>
        /// <param name="dwLen"></param>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfrommemory")]
        public static extern bool _img_createfrommemory(byte[] lpData, IntPtr dwLen, out int hImg);

        /// <summary>
        /// 图像创建
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="hImg">返回新图像句柄</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_create")]
        public static extern bool _img_create(int width, int height, out int hImg);

        /// <summary>
        /// 锁定图像
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="lpRectL">锁定矩形指针，如果为0，则锁定整张图像</param>
        /// <param name="flags">READ:1 / WRITE:2 / READ+WRITE:3</param>
        /// <param name="PixelFormat">参考:https://msdn.microsoft.com/en-us/library/ms534412(v=vs.85).aspx</param>
        /// <param name="lpLockedBitmapData">BITMAPDATA</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_lock")]
        public static extern bool _img_lock(int hImg, ExRect lpRectL, int flags, int PixelFormat, ref ExBitmapData lpLockedBitmapData);

        /// <summary>
        /// 图像解锁
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="lpLockedBitmapData"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_unlock")]
        public static extern bool _img_unlock(int hImg, ref ExBitmapData lpLockedBitmapData);

        /// <summary>
        /// 图像销毁
        /// </summary>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_destroy")]
        public static extern bool _img_destroy(int hImg);

        /// <summary>
        /// 设置最后错误代码.相关常量 :#ERROR_EX_
        /// </summary>
        /// <param name="nError"></param>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_SetLastError")]
        public static extern void Ex_SetLastError(int nError);

        /// <summary>
        /// 图像取帧数
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="nFrameCount">返回帧数</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getframecount")]
        public static extern bool _img_getframecount(int hImg, out int nFrameCount);

        /// <summary>
        /// 图像设置当前活动帧
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_selectactiveframe")]
        public static extern bool _img_selectactiveframe(int hImg, int nIndex);

        /// <summary>
        /// 图像创建自字节流
        /// </summary>
        /// <param name="lpStream"></param>
        /// <param name="dstImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromstream")]
        public static extern bool _img_createfromstream(IStream lpStream, out int dstImg);

        /// <summary>
        /// 图像创建自画布句柄
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="dstImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromcanvas")]
        public static extern int _img_createfromcanvas(int hCanvas, out int dstImg);

        /// <summary>
        /// 图像取帧延时
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="lpDelayAry">指针指向图像帧延时数组</param>
        /// <param name="nFrames">返回总帧数</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getframedelay")]
        public static extern bool _img_getframedelay(int hImg, int[] lpDelayAry, out int nFrames);

        /// <summary>
        /// 图像获取尺寸
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="lpWidth"></param>
        /// <param name="lpHeight"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getsize")]
        public static extern bool _img_getsize(int hImg, out int lpWidth, out int lpHeight);

        /// <summary>
        /// 加载位图对象自内存
        /// </summary>
        /// <param name="lpData">图像数据指针</param>
        /// <param name="dwLen">图像数据长度</param>
        /// <param name="retBitMap">返回位图句柄</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_LoadBitMapFromMemory")]
        public static extern bool Ex_LoadBitMapFromMemory(byte[] lpData, IntPtr dwLen, ref IntPtr retBitMap);

        /// <summary>
        /// 图像取宽度
        /// </summary>
        /// <param name="hImg"></param>
        /// <returns>返回宽度</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_width")]
        public static extern int _img_width(int hImg);

        /// <summary>
        /// 图像取高度
        /// </summary>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_height")]
        public static extern int _img_height(int hImg);

        /// <summary>
        /// 图像复制
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="dstImg">返回新图像句柄</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_copy")]
        public static extern bool _img_copy(int hImg, out int dstImg);

        /// <summary>
        /// 图像复制部分
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="dstImg">返回新图像句柄</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_copyrect")]
        public static extern bool _img_copyrect(int hImg, int x, int y, int width, int height, out int dstImg);

        /// <summary>
        /// 图像创建自位图句柄
        /// </summary>
        /// <param name="hBitmap"></param>
        /// <param name="hPalette"></param>
        /// <param name="fPreAlpha">是否预乘透明通道</param>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromhbitmap")]
        public static extern bool _img_createfromhbitmap(IntPtr hBitmap, IntPtr hPalette, bool fPreAlpha, out int hImg);

        /// <summary>
        /// 图像创建自图标句柄
        /// </summary>
        /// <param name="hIcon"></param>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromhicon")]
        public static extern bool _img_createfromhicon(IntPtr hIcon, out int hImg);

        /// <summary>
        /// 图像创建自文件
        /// </summary>
        /// <param name="lpwzFilename"></param>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromfile")]
        public static extern bool _img_createfromfile(string lpwzFilename, out int hImg);

        /// <summary>
        /// 图像获取点像素
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="retPixel">返回ARGB颜色</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getpixel")]
        public static extern bool _img_getpixel(int hImg, int x, int y, out int retPixel);

        /// <summary>
        /// 图像设置点像素
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color">Argb颜色</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_setpixel")]
        public static extern bool _img_setpixel(int hImg, int x, int y, int color);

        /// <summary>
        /// 图像旋转翻转
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="rfType">参考:https://msdn.microsoft.com/en-us/library/windows/desktop/ms534171(v=vs.85).aspx</param>
        /// <param name="phImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_rotateflip")]
        public static extern bool _img_rotateflip(int hImg, int rfType, out int phImg);

        /// <summary>
        /// 画布重新设置尺寸
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_resize")]
        public static extern bool _canvas_resize(int hCanvas, int width, int height);

        /// <summary>
        /// 获取画布信息
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="nType">画布信息类型 CVC_DX常量</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_getcontext")]
        public static extern IntPtr _canvas_getcontext(int hCanvas, int nType);

        /// <summary>
        /// 绑定窗口ex
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hTheme">主题句柄.(值可为0)</param>
        /// <param name="dwStyle">#EWS_</param>
        /// <param name="lParam">附加参数.(值可为0)</param>
        /// <param name="lpfnMsgProc"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIBindWindowEx")]
        public static extern int Ex_DUIBindWindowEx(IntPtr hWnd, IntPtr hTheme, int dwStyle, IntPtr lParam, ExWndProcDelegate lpfnMsgProc);

        /// <summary>
        /// 注册窗口类
        /// </summary>
        /// <param name="lpwzClassName">窗口类名</param>
        /// <param name="hIcon">窗口大图标句柄</param>
        /// <param name="hIconsm">窗口小图标句柄</param>
        /// <param name="hCursor">窗口鼠标句柄</param>
        /// <returns>返回窗口类原子</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndRegisterClass")]
        public static extern ushort Ex_WndRegisterClass(string lpwzClassName, IntPtr hIcon, IntPtr hIconsm, IntPtr hCursor);

        /// <summary>
        /// 创建窗口
        /// </summary>
        /// <param name="hWndParent">父窗口句柄</param>
        /// <param name="lpwzClassName">窗口类名</param>
        /// <param name="lpwzWindowName">窗口标题</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="dwStyle">窗口风格</param>
        /// <param name="dwStyleEx">窗口扩展风格</param>
        /// <returns>返回窗口句柄</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndCreate")]
        public static extern IntPtr Ex_WndCreate(IntPtr hWndParent, string lpwzClassName, string lpwzWindowName, int x, int y, int width, int height, int dwStyle, int dwStyleEx);

        /// <summary>
        /// 窗口消息循环
        /// </summary>
        /// <returns>返回msg.wParam</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndMsgLoop")]
        public static extern IntPtr Ex_WndMsgLoop();

        /// <summary>
        /// 窗口居中
        /// </summary>
        /// <param name="hWnd">预居中的原始窗口</param>
        /// <param name="hWndFrom">预居中的目标窗口,如果为0则为屏幕居中</param>
        /// <param name="bFullScreen">是否全屏模式</param>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndCenterFrom")]
        public static extern void Ex_WndCenterFrom(IntPtr hWnd, IntPtr hWndFrom, bool bFullScreen);

        /// <summary>
        /// 显示窗口
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="nCmdShow">相关常量:#SW_</param>
        /// <param name="dwTimer">动画时间间隔(ms)</param>
        /// <param name="dwFrames">动画总帧数</param>
        /// <param name="dwFlags">动画标记</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIShowWindow")]
        public static extern bool Ex_DUIShowWindow(int hExDui, int nCmdShow, int dwTimer, int dwFrames, int dwFlags);

        /// <summary>
        /// 显示窗口Ex
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="nCmdShow">相关常量:#SW_</param>
        /// <param name="dwTimer">动画时间间隔</param>
        /// <param name="dwFrames">动画总帧数</param>
        /// <param name="dwFlags">动画标记.#EXA_</param>
        /// <param name="uEasing">缓动类型常量#ET_</param>
        /// <param name="wParam">参数1</param>
        /// <param name="lParam">参数2</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIShowWindowEx")]
        public static extern bool Ex_DUIShowWindowEx(int hExDui, int nCmdShow, int dwTimer, int dwFrames, int dwFlags, int uEasing, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 画布结束绘制
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_enddraw")]
        public static extern bool _canvas_enddraw(int hCanvas);

        /// <summary>
        /// 画布取DC
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_getdc")]
        public static extern IntPtr _canvas_getdc(int hCanvas);

        /// <summary>
        /// 画布释放DC
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_releasedc")]
        public static extern bool _canvas_releasedc(int hCanvas);

        /// <summary>
        /// 组件默认过程
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDefProc")]
        public static extern IntPtr Ex_ObjDefProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 画布填充矩形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillrect")]
        public static extern bool _canvas_fillrect(int hCanvas, IntPtr hBrush, float left, float top, float right, float bottom);

        /// <summary>
        /// 画布填充圆角图片
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hImg"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        /// <param name="shadowNum">透明度数组</param>
        /// <param name="number">透明度数量</param>
        /// <param name="crShadow"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillroundedimage")]
        public static extern bool _canvas_fillroundedimage(int hCanvas, IntPtr hImg, float left, float top, float width, float height, float radiusX, float radiusY, IntPtr shadowNum, int number, int crShadow);

        /// <summary>
        /// 画刷创建
        /// </summary>
        /// <param name="argb"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_create")]
        public static extern IntPtr _brush_create(int argb);

        /// <summary>
        /// 创建线性渐变画刷
        /// </summary>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="xEnd"></param>
        /// <param name="yEnd"></param>
        /// <param name="crBegin">起点颜色ARGB</param>
        /// <param name="crEnd">终点颜色ARGB</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createlinear")]
        public static extern IntPtr _brush_createlinear(float xStart, float yStart, float xEnd, float yEnd, int crBegin, int crEnd);

        /// <summary>
        /// 创建线性渐变画刷2
        /// </summary>
        /// <param name="xStart">起点X</param>
        /// <param name="yStart">起点Y</param>
        /// <param name="xEnd">终点X</param>
        /// <param name="yEnd">终点Y</param>
        /// <param name="arrStopPts">两个点位置和颜色数据,只能两个{位置(0-1.0),颜色(ARGB),位置(0-1.0),颜色(ARGB)}这样传参</param>
        /// <param name="cStopPts">点个数，只能两个传2</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createlinear_ex")]
        public static extern IntPtr _brush_createlinear_ex(float xStart, float yStart, float xEnd, float yEnd, float[,] arrStopPts, int cStopPts);

        /// <summary>
        /// 画刷销毁
        /// </summary>
        /// <param name="hBrush"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_destroy")]
        public static extern int _brush_destroy(IntPtr hBrush);

        /// <summary>
        /// 画布填充圆角矩形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillroundedrect")]
        public static extern bool _canvas_fillroundedrect(int hCanvas, IntPtr hBrush, float left, float top, float right, float bottom, float radiusX, float radiusY);

        /// <summary>
        /// 画布填充椭圆
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillellipse")]
        public static extern bool _canvas_fillellipse(int hCanvas, IntPtr hBrush, float x, float y, float radiusX, float radiusY);

        /// <summary>
        /// 注册组件
        /// </summary>
        /// <param name="lptszClassName">组件类名.最大允许长度:MAX_CLASS_NAME_LEN</param>
        /// <param name="dwStyle">组件默认风格    EOS_</param>
        /// <param name="dwStyleEx">组件默认扩展风格 EOS_EX</param>
        /// <param name="dwTextFormat">相关常量 DT_</param>
        /// <param name="cbObjExtra">组件额外分配字节数(值可为0),每个成员8字节</param>
        /// <param name="hCursor">组件默认鼠标指针句柄(值可为0)</param>
        /// <param name="dwFlags">画布标志 #ECVF_(值可为0)</param>
        /// <param name="pfnObjProc">组件默认回调</param>
        /// <returns>成功返回组件类名原子,失败返回0</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjRegister")]
        public static extern int Ex_ObjRegister(string lptszClassName, int dwStyle, int dwStyleEx, int dwTextFormat, int cbObjExtra, IntPtr hCursor, int dwFlags, ExObjClassProcDelegate pfnObjProc);

        /// <summary>
        /// 组件创建
        /// </summary>
        /// <param name="lptszClassName">组件类名</param>
        /// <param name="lptszObjTitle">组件标题</param>
        /// <param name="dwStyle">组件风格 相关常量 EOS_</param>
        /// <param name="x">左边</param>
        /// <param name="y">顶边</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="hParent">父组件句柄</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCreate")]
        public static extern IntPtr Ex_ObjCreate(string lptszClassName, string lptszObjTitle, int dwStyle, int x, int y, int width, int height, IntPtr hParent);

        /// <summary>
        /// 组件创建Ex
        /// </summary>
        /// <param name="dwStyleEx">组件扩展风格 相关常量 EOS_EX_</param>
        /// <param name="lptszClassName">组件类名</param>
        /// <param name="lptszObjTitle">组件标题</param>
        /// <param name="dwStyle">组件风格 相关常量 EOS_</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="hParent">父组件句柄</param>
        /// <param name="nID">组件ID</param>
        /// <param name="dwTextFormat">相关常量 DT_</param>
        /// <param name="lParam">附加参数</param>
        /// <param name="hTheme">主题句柄.0为默认</param>
        /// <param name="lpfnMsgProc"></param>
        /// <returns>返回组件句柄</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCreateEx")]
        public static extern int Ex_ObjCreateEx(int dwStyleEx, string lptszClassName, string lptszObjTitle, int dwStyle, int x, int y, int width, int height, int hParent, int nID, int dwTextFormat, IntPtr lParam, int hTheme, ExObjProcDelegate lpfnMsgProc);

        /// <summary>
        /// 取DPI缩放值
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Scale")]
        public static extern float Ex_Scale(float n);

        /// <summary>
        /// 区域创建自矩形
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_createfromrect")]
        public static extern IntPtr _rgn_createfromrect(float left, float top, float right, float bottom);

        /// <summary>
        /// 区域创建自圆角矩形
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_createfromroundrect")]
        public static extern IntPtr _rgn_createfromroundrect(float left, float top, float right, float bottom, float radiusX, float radiusY);

        /// <summary>
        /// 区域销毁
        /// </summary>
        /// <param name="hRgn"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_destroy")]
        public static extern bool _rgn_destroy(IntPtr hRgn);

        /// <summary>
        /// 区域合并
        /// </summary>
        /// <param name="hRgnSrc"></param>
        /// <param name="hRgnDst"></param>
        /// <param name="nCombineMode">#RGN_COMBINE_</param>
        /// <param name="dstOffsetX"></param>
        /// <param name="dstOffsetY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_combine")]
        public static extern IntPtr _rgn_combine(IntPtr hRgnSrc, IntPtr hRgnDst, int nCombineMode, int dstOffsetX, int dstOffsetY);

        /// <summary>
        /// 画布填充区域
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hRgn"></param>
        /// <param name="hBrush"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillregion")]
        public static extern bool _canvas_fillregion(int hCanvas, IntPtr hRgn, IntPtr hBrush);

        /// <summary>
        /// 区域命中测试
        /// </summary>
        /// <param name="hRgn"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_hittest")]
        public static extern bool _rgn_hittest(IntPtr hRgn, float x, float y);

        /// <summary>
        /// 组件销毁
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDestroy")]
        public static extern bool Ex_ObjDestroy(int hObj);

        /// <summary>
        /// 组件发送消息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSendMessage")]
        public static extern IntPtr Ex_ObjSendMessage(int hObj, int uMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 组件开始绘制
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpPS"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjBeginPaint")]
        public static extern bool Ex_ObjBeginPaint(int hObj, out ExPaintStruct lpPS);

        /// <summary>
        /// 组件结束绘制
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpPS"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEndPaint")]
        public static extern bool Ex_ObjEndPaint(int hObj, ref ExPaintStruct lpPS);

        /// <summary>
        /// 组件取矩形
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetRect")]
        public static extern bool Ex_ObjGetRect(int hObj, out ExRect lpRect);

        /// <summary>
        /// 组件客户区坐标到窗口坐标
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjClientToWindow")]
        public static extern bool Ex_ObjClientToWindow(int hObj, ref int x, ref int y);

        /// <summary>
        /// 画布重置剪辑区
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_resetclip")]
        public static extern bool _canvas_resetclip(int hCanvas);

        /// <summary>
        /// 组件客户区坐标到屏幕坐标
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjClientToScreen")]
        public static extern bool Ex_ObjClientToScreen(int hObj, ref int x, ref int y);

        /// <summary>
        /// 组件设置重画区域
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lprcRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjInvalidateRect")]
        public static extern bool Ex_ObjInvalidateRect(int hObj, IntPtr lprcRedraw);

        /// <summary>
        /// 组件立即更新
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjUpdate")]
        public static extern bool Ex_ObjUpdate(int hObj);

        /// <summary>
        /// 组件获取客户区矩形
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetClientRect")]
        public static extern bool Ex_ObjGetClientRect(int hObj, out ExRect lpRect);

        /// <summary>
        /// 组件设置可用状态
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fEnable">是否可用</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnable")]
        public static extern bool Ex_ObjEnable(int hObj, bool fEnable);

        /// <summary>
        /// 组件是否可用
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjIsEnable")]
        public static extern bool Ex_ObjIsEnable(int hObj);

        /// <summary>
        /// 组件是否可视
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjIsVisible")]
        public static extern bool Ex_ObjIsVisible(int hObj);

        /// <summary>
        /// 组件设置可视状态
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fShow"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjShow")]
        public static extern bool Ex_ObjShow(int hObj, bool fShow);

        /// <summary>
        /// 组件获取数值
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nIndex">相关常量 #EOL_</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetLong")]
        public static extern IntPtr Ex_ObjGetLong(int hObj, int nIndex);

        /// <summary>
        /// 组件获取父组件
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetParent")]
        public static extern int Ex_ObjGetParent(int hObj);

        /// <summary>
        /// 组件设置数值
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nIndex">#EOL_</param>
        /// <param name="dwNewLong"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetLong")]
        public static extern IntPtr Ex_ObjSetLong(int hObj, int nIndex, Delegate dwNewLong);

        /// <summary>
        /// 组件设置数值
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nIndex">#EOL_</param>
        /// <param name="dwNewLong"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetLong")]
        public static extern IntPtr Ex_ObjSetLong(int hObj, int nIndex, IntPtr dwNewLong);

        /// <summary>
        /// 组件设置位置
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="hObjInsertAfter"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="flags">相关常量 #SWP_</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetPos")]
        public static extern bool Ex_ObjSetPos(int hObj, IntPtr hObjInsertAfter, int x, int y, int width, int height, int flags);

        /// <summary>
        /// 组件是否有效
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjIsValidate")]
        public static extern bool Ex_ObjIsValidate(int hObj);

        /// <summary>
        /// 组件枚举子组件
        /// </summary>
        /// <param name="hObjParent">父组件的句柄。从根部枚举则为引擎句柄</param>
        /// <param name="lpEnumFunc">callback(hObj,lParam).返回1继续枚举,返回0停止枚举</param>
        /// <param name="lParam">附带参数</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnumChild")]
        public static extern bool Ex_ObjEnumChild(int hObjParent, ExObjEnumCallbackDelegate lpEnumFunc, IntPtr lParam);

        /// <summary>
        /// 组件获取文本
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpString">缓冲区指针</param>
        /// <param name="nMaxCount">缓冲区长度</param>
        /// <returns>返回已拷贝字符长度</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetText")]
        public static extern IntPtr Ex_ObjGetText(int hObj, StringBuilder lpString, IntPtr nMaxCount);

        /// <summary>
        /// 组件获取文本长度
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetTextLength")]
        public static extern IntPtr Ex_ObjGetTextLength(int hObj);

        /// <summary>
        /// 组件设置文本
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpString">指向一个空结束的字符串的指针</param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetText")]
        public static extern bool Ex_ObjSetText(int hObj, string lpString, bool fRedraw);

        /// <summary>
        /// 设置组件文本格式
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwTextFormat">DT_常量</param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetTextFormat")]
        public static extern bool Ex_ObjSetTextFormat(int hObj, int dwTextFormat, bool fRedraw);

        /// <summary>
        /// 组件弹出或关闭提示文本
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpText">提示文本.该值为0则关闭提示文本</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjTooltipsPop")]
        public static extern bool Ex_ObjTooltipsPop(int hObj, string lpText);

        /// <summary>
        /// 组件弹出或关闭提示文本Ex
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpTitle">标题内容</param>
        /// <param name="lpText">提示文本</param>
        /// <param name="x">屏幕坐标.(-1:默认)</param>
        /// <param name="y">屏幕坐标.(-1:默认)</param>
        /// <param name="dwTime">单位:毫秒.(-1:默认,0:始终显示)</param>
        /// <param name="nIcon"></param>
        /// <param name="fShow"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjTooltipsPopEx")]
        public static extern bool Ex_ObjTooltipsPopEx(int hObj, string lpTitle, string lpText, int x, int y, int dwTime, int nIcon, bool fShow);

        /// <summary>
        /// 获取鼠标所在窗口组件句柄
        /// </summary>
        /// <param name="handle">0[坐标所在窗口]/窗口句柄/引擎句柄/组件句柄</param>
        /// <param name="x">handle:0相对屏幕/其他相对窗口</param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIGetObjFromPoint")]
        public static extern int Ex_DUIGetObjFromPoint(int handle, int x, int y);

        /// <summary>
        /// 组件设置焦点
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetFocus")]
        public static extern bool Ex_ObjSetFocus(int hObj);

        /// <summary>
        /// 组件销毁焦点
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjKillFocus")]
        public static extern bool Ex_ObjKillFocus(int hObj);

        /// <summary>
        /// 组件获取属性
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwKey"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetProp")]
        public static extern IntPtr Ex_ObjGetProp(int hObj, IntPtr dwKey);

        /// <summary>
        /// 组件设置属性
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwKey"></param>
        /// <param name="dwValue"></param>
        /// <returns>返回旧属性</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetProp")]
        public static extern IntPtr Ex_ObjSetProp(int hObj, IntPtr dwKey, IntPtr dwValue);

        /// <summary>
        /// 移动组件
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="bRepaint"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjMove")]
        public static extern bool Ex_ObjMove(int hObj, int x, int y, int width, int height, bool bRepaint);

        /// <summary>
        /// 初始化Miniblink浏览器
        /// </summary>
        /// <param name="libPath">依赖父路径</param>
        /// <param name="dllPath">库文件名</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjMiniblinkBrowserInitialize")]
        public static extern bool Ex_ObjMiniblinkBrowserInitialize(string libPath, string dllPath);

        /// <summary>
        /// 组件返回特定关系（如Z序或所有者）的组件句柄。
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nCmd">相关常量 #GW_</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetObj")]
        public static extern int Ex_ObjGetObj(int hObj, int nCmd);

        /// <summary>
        /// 组件查找
        /// </summary>
        /// <param name="hObjParent">父组件句柄。从根部查找则为引擎句柄</param>
        /// <param name="hObjChildAfter"> 由此组件开始查找（不包含该组件）。如果为0，则从第一个组件开始查找</param>
        /// <param name="lpClassName">欲查找的组件类名指针/Ex_ATOM()</param>
        /// <param name="lpTitle">欲查找的组件标题</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjFind")]
        public static extern int Ex_ObjFind(int hObjParent, int hObjChildAfter, string lpClassName, string lpTitle);

        /// <summary>
        /// 组件设置是否可以重画.如果组件扩展风格存在EOS_EX_COMPOSITED,则该函数无效
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fCanbeRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetRedraw")]
        public static extern bool Ex_ObjSetRedraw(int hObj, bool fCanbeRedraw);

        /// <summary>
        /// 加载主题包自文件
        /// </summary>
        /// <param name="lptszFile"></param>
        /// <param name="lpKey"></param>
        /// <param name="dwKeyLen"></param>
        /// <param name="bDefault"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeLoadFromFile")]
        public static extern int Ex_ThemeLoadFromFile(string lptszFile, byte[] lpKey, IntPtr dwKeyLen, bool bDefault);

        /// <summary>
        /// 加载主题包自内存
        /// </summary>
        /// <param name="lpData"></param>
        /// <param name="dwDataLen"></param>
        /// <param name="lpKey"></param>
        /// <param name="dwKeyLen"></param>
        /// <param name="bDefault"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeLoadFromMemory")]
        public static extern int Ex_ThemeLoadFromMemory(byte[] lpData, IntPtr dwDataLen, byte[] lpKey, IntPtr dwKeyLen, bool bDefault);

        /// <summary>
        /// 释放主题
        /// </summary>
        /// <param name="hTheme"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeFree")]
        public static extern bool Ex_ThemeFree(int hTheme);

        /// <summary>
        /// 获取字符串唯一原子号
        /// </summary>
        /// <param name="lptstring"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Atom")]
        public static extern int Ex_Atom(string lptstring);

        /// <summary>
        /// 初始化CEF浏览框路径,创建前使用
        /// </summary>
        /// <param name="hModule">模块句柄</param>
        /// <param name="libPath">库文件夹路径,绝对路径,不为0时会写入环境变量PATH。默认程序运行路径</param>
        /// <param name="dllName">库文件名称 默认为FTBrowser.dll</param>
        /// <param name="cachePath">临时文件保存路径,绝对路径,0为内存模式</param>
        /// <param name="userAgent">用户设备</param>
        /// <param name="debuggingPort">调试端口</param>
        /// <param name="lpBeforeCommandLine"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCefBrowserInitialize")]
        public static extern bool Ex_ObjCefBrowserInitialize(IntPtr hModule, string libPath, IntPtr dllName, IntPtr cachePath, IntPtr userAgent, int debuggingPort, ExCefBeforeCommandLineCallbackDelegate lpBeforeCommandLine);

        /// <summary>
        /// 画布取尺寸
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_getsize")]
        public static extern bool _canvas_getsize(int hCanvas, out int width, out int height);

        /// <summary>
        /// 获取组件属性值指针
        /// </summary>
        /// <param name="hTheme"></param>
        /// <param name="atomClass"></param>
        /// <param name="atomProp"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeGetValuePtr")]
        public static extern IntPtr Ex_ThemeGetValuePtr(int hTheme, int atomClass, int atomProp);

        /// <summary>
        /// 设置引擎数值
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="nIndex"></param>
        /// <param name="dwNewlong"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUISetLong")]
        public static extern IntPtr Ex_DUISetLong(int hExDui, int nIndex, IntPtr dwNewlong);

        /// <summary>
        /// 获取引擎数值
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIGetLong")]
        public static extern IntPtr Ex_DUIGetLong(int hExDui, int nIndex);

        /// <summary>
        /// 创建默认字体
        /// </summary>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_create")]
        public static extern int _font_create();

        /// <summary>
        /// 创建字体自字体族
        /// </summary>
        /// <param name="lpwzFontFace"></param>
        /// <param name="dwFontSize"></param>
        /// <param name="dwFontStyle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_createfromfamily")]
        public static extern int _font_createfromfamily(string lpwzFontFace, int dwFontSize, int dwFontStyle);

        /// <summary>
        /// 创建字体自逻辑字体
        /// </summary>
        /// <param name="lpLogfont"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_createfromlogfont")]
        public static extern int _font_createfromlogfont(ref LogFont lpLogfont);

        /// <summary>
        /// 获取逻辑字体
        /// </summary>
        /// <param name="hFont"></param>
        /// <param name="lpLogFont"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_getlogfont")]
        public static extern bool _font_getlogfont(int hFont, ref LogFont lpLogFont);

        /// <summary>
        /// 获取客户区矩形
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="lpClientRect"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIGetClientRect")]
        public static extern bool Ex_DUIGetClientRect(int hExDui, out ExRect lpClientRect);

        /// <summary>
        /// 组件投递消息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjPostMessage")]
        public static extern bool Ex_ObjPostMessage(int hObj, int uMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 组件设置背景信息
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="lpImage"></param>
        /// <param name="dwImageLen"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="dwRepeat"></param>
        /// <param name="pRcGrids"></param>
        /// <param name="dwFlags"></param>
        /// <param name="dwAlpha"></param>
        /// <param name="fUpdate"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetBackgroundImage")]
        public static extern bool Ex_ObjSetBackgroundImage(int handle, byte[] lpImage, int dwImageLen, int X, int Y, int dwRepeat, ref ExRect pRcGrids, int dwFlags, int dwAlpha, bool fUpdate);

        /// <summary>
        /// 组件获取背景信息
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="lpBackgroundImage"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetBackgroundImage")]
        public static extern bool Ex_ObjGetBackgroundImage(int handle, out ExBackgroundImageInfo lpBackgroundImage);

        /// <summary>
        /// 组件设置背景图片播放状态
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="fPlayFrames"></param>
        /// <param name="fResetFrame"></param>
        /// <param name="fUpdate"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetBackgroundPlayState")]
        public static extern bool Ex_ObjSetBackgroundPlayState(int handle, bool fPlayFrames, bool fResetFrame, bool fUpdate);

        /// <summary>
        /// 组件设置模糊度
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fDeviation"></param>
        /// <param name="fUpdate"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetBlur")]
        public static extern bool Ex_ObjSetBlur(int hObj, float fDeviation, bool fUpdate);

        /// <summary>
        /// 组件销毁背景
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDestroyBackground")]
        public static extern int Ex_ObjDestroyBackground(int handle);

        /// <summary>
        /// 画布旋转色相
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="fAngle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_rotate_hue")]
        public static extern bool _canvas_rotate_hue(int hCanvas, float fAngle);

        /// <summary>
        /// 组件设置时钟
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="uElapse"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetTimer")]
        public static extern int Ex_ObjSetTimer(int hObj, int uElapse);

        /// <summary>
        /// 组件销毁时钟
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjKillTimer")]
        public static extern bool Ex_ObjKillTimer(int hObj);

        /// <summary>
        /// 字体销毁
        /// </summary>
        /// <param name="hFont"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_destroy")]
        public static extern bool _font_destroy(int hFont);

        /// <summary>
        /// 组件分发消息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDispatchMessage")]
        public static extern IntPtr Ex_ObjDispatchMessage(int hObj, int uMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 组件设置状态,用于更新组件界面显示状态
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwState"></param>
        /// <param name="bRemove"></param>
        /// <param name="lprcRedraw"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetUIState")]
        public static extern bool Ex_ObjSetUIState(int hObj, int dwState, bool bRemove, IntPtr lprcRedraw, bool fRedraw);

        /// <summary>
        /// 画布刷新
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_flush")]
        public static extern bool _canvas_flush(int hCanvas);

        /// <summary>
        /// 组件设置滚动条信息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fnBar"></param>
        /// <param name="fMask"></param>
        /// <param name="nMin"></param>
        /// <param name="nMax"></param>
        /// <param name="nPage"></param>
        /// <param name="nPos"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollSetInfo")]
        public static extern int Ex_ObjScrollSetInfo(int hObj, int fnBar, int fMask, int nMin, int nMax, int nPage, int nPos, bool fRedraw);

        /// <summary>
        /// 组件设置滚动条范围
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <param name="nMin"></param>
        /// <param name="nMax"></param>
        /// <param name="bRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollSetRange")]
        public static extern bool Ex_ObjScrollSetRange(int hObj, int nBar, int nMin, int nMax, bool bRedraw);

        /// <summary>
        /// 组件设置滚动条位置
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <param name="nPos"></param>
        /// <param name="bRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollSetPos")]
        public static extern int Ex_ObjScrollSetPos(int hObj, int nBar, int nPos, bool bRedraw);

        /// <summary>
        /// 组件获取滚动条句柄
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetControl")]
        public static extern int Ex_ObjScrollGetControl(int hObj, int nBar);

        /// <summary>
        /// 组件调用过程
        /// </summary>
        /// <param name="lpPrevObjProc"></param>
        /// <param name="hWnd"></param>
        /// <param name="hObj"></param>
        /// <param name="uMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <param name="pvData"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCallProc")]
        public static extern IntPtr Ex_ObjCallProc(IntPtr lpPrevObjProc, IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pvData);

        /// <summary>
        /// 组件获取滚动条位置
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetPos")]
        public static extern int Ex_ObjScrollGetPos(int hObj, int nBar);

        /// <summary>
        /// 弹出信息框
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="lpText"></param>
        /// <param name="lpCaption"></param>
        /// <param name="uType"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_MessageBox")]
        public static extern int Ex_MessageBox(int handle, string lpText, string lpCaption, int uType, int dwFlags);

        /// <summary>
        /// 弹出信息框Ex
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="lpText"></param>
        /// <param name="lpCaption"></param>
        /// <param name="uType"></param>
        /// <param name="lpCheckBox"></param>
        /// <param name="lpCheckBoxChecked"></param>
        /// <param name="dwMilliseconds"></param>
        /// <param name="dwFlags"></param>
        /// <param name="lpfnMsgProc"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_MessageBoxEx")]
        public static extern int Ex_MessageBoxEx(int handle, string lpText, string lpCaption, int uType, string lpCheckBox, ref bool lpCheckBoxChecked, int dwMilliseconds, int dwFlags, ExWndProcDelegate lpfnMsgProc);

        /// <summary>
        /// 绑定窗口
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hTheme"></param>
        /// <param name="dwStyle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIBindWindow")]
        public static extern IntPtr Ex_DUIBindWindow(IntPtr hWnd, int hTheme, int dwStyle);

        /// <summary>
        /// 获取组件句柄自ID
        /// </summary>
        /// <param name="hExDuiOrhObj"></param>
        /// <param name="nID"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFromID")]
        public static extern int Ex_ObjGetFromID(int hExDuiOrhObj, int nID);

        /// <summary>
        /// 获取组件句柄自名称
        /// </summary>
        /// <param name="hExDuiOrhObj"></param>
        /// <param name="lpwzName"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFromName")]
        public static extern int Ex_ObjGetFromName(int hExDuiOrhObj, string lpwzName);

        /// <summary>
        /// 组件挂接事件回调
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nEvent"></param>
        /// <param name="pfnCallback"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjHandleEvent")]
        public static extern bool Ex_ObjHandleEvent(int hObj, int nEvent, ExObjEventProcDelegate pfnCallback);

        /// <summary>
        /// 获取主题相关颜色值
        /// </summary>
        /// <param name="hTheme"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeGetColor")]
        public static extern int Ex_ThemeGetColor(int hTheme, int nIndex);

        /// <summary>
        /// 组件获取状态
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetUIState")]
        public static extern int Ex_ObjGetUIState(int hObj);

        /// <summary>
        /// 组件设置相关颜色
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nIndex"></param>
        /// <param name="dwColor"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetColor")]
        public static extern int Ex_ObjSetColor(int hObj, int nIndex, int dwColor, bool fRedraw);

        /// <summary>
        /// 组件获取相关颜色
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetColor")]
        public static extern int Ex_ObjGetColor(int hObj, int nIndex);

        /// <summary>
        /// 设置编辑框选中行字符格式
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwMask">相关常量 CFM_</param>
        /// <param name="crText">文本颜色</param>
        /// <param name="wzFontFace">字体名称</param>
        /// <param name="dwFontSize">字体尺寸</param>
        /// <param name="offsetY">字体垂直偏移</param>
        /// <param name="bBold">是否加粗</param>
        /// <param name="bItalic">是否倾斜</param>
        /// <param name="bUnderLine">是否下划线</param>
        /// <param name="bStrikeOut">是否删除线</param>
        /// <param name="bLink">是否超链接</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEditSetSelCharFormat")]
        public static extern IntPtr Ex_ObjEditSetSelCharFormat(int hObj, int dwMask, int crText, string wzFontFace, int dwFontSize, int offsetY, bool bBold, bool bItalic, bool bUnderLine, bool bStrikeOut, bool bLink);

        /// <summary>
        /// 设置编辑框选中行段落格式
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwMask">相关常量 PFM_</param>
        /// <param name="wNumbering">编号类型,可空 PFN_常量</param>
        /// <param name="dxStartIndent">首行缩进,可空</param>
        /// <param name="dxRightIndent">右侧缩进,可空</param>
        /// <param name="offsetX">非首行缩进,可空</param>
        /// <param name="wAlignment">段落对齐方式,可空 PFA_常量</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEditSetSelParFormat")]
        public static extern IntPtr Ex_ObjEditSetSelParFormat(int hObj, int dwMask, ushort wNumbering, int dxStartIndent, int dxRightIndent, int offsetX, ushort wAlignment);

        /// <summary>
        /// 从文件加载资源
        /// </summary>
        /// <param name="lpwzFile"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResLoadFromFile")]
        public static extern IntPtr Ex_ResLoadFromFile(string lpwzFile);

        /// <summary>
        /// 从内存加载资源
        /// </summary>
        /// <param name="lpData"></param>
        /// <param name="dwDataLen"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResLoadFromMemory")]
        public static extern IntPtr Ex_ResLoadFromMemory(byte[] lpData, IntPtr dwDataLen);

        /// <summary>
        /// 获取资源文件
        /// </summary>
        /// <param name="hRes"></param>
        /// <param name="lpwzPath"></param>
        /// <param name="lpFile"></param>
        /// <param name="dwFileLen"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResGetFile")]
        public static extern bool Ex_ResGetFile(IntPtr hRes, string lpwzPath, out byte[] lpFile, out IntPtr dwFileLen);

        /// <summary>
        /// 获取资源文件从路径原子
        /// </summary>
        /// <param name="hRes"></param>
        /// <param name="atomPath"></param>
        /// <param name="lpFile"></param>
        /// <param name="dwFileLen"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResGetFileFromAtom")]
        public static extern bool Ex_ResGetFileFromAtom(IntPtr hRes, int atomPath, out byte[] lpFile, out IntPtr dwFileLen);

        /// <summary>
        /// 资源释放
        /// </summary>
        /// <param name="hRes"></param>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResFree")]
        public static extern void Ex_ResFree(IntPtr hRes);

        /// <summary>
        /// 组件分发事件
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDispatchNotify")]
        public static extern IntPtr Ex_ObjDispatchNotify(int hObj, int nCode, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 设置托盘图标
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="hIcon"></param>
        /// <param name="lpwzTips"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUITrayIconSet")]
        public static extern bool Ex_DUITrayIconSet(int hExDui, IntPtr hIcon, string lpwzTips);

        /// <summary>
        /// 弹出托盘图标
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="lpwzInfo"></param>
        /// <param name="lpwzInfoTitle"></param>
        /// <param name="dwInfoFlags"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUITrayIconPopup")]
        public static extern bool Ex_DUITrayIconPopup(int hExDui, string lpwzInfo, string lpwzInfoTitle, int dwInfoFlags);

        /// <summary>
        /// 释放内存
        /// </summary>
        /// <param name="lpBuffer"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_FreeBuffer")]
        public static extern bool Ex_FreeBuffer(IntPtr lpBuffer);

        /// <summary>
        /// 组件默认绘制背景过程
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="hCanvas"></param>
        /// <param name="lprcPaint"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDrawBackgroundProc")]
        public static extern bool Ex_ObjDrawBackgroundProc(int hObj, int hCanvas, ref ExRect lprcPaint);

        /// <summary>
        /// 获取焦点组件
        /// </summary>
        /// <param name="hExDuiOrhObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFocus")]
        public static extern int Ex_ObjGetFocus(int hExDuiOrhObj);

        /// <summary>
        /// 画布置矩阵
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="pMatrix">0重置</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_settransform")]
        public static extern bool _canvas_settransform(int hCanvas, IntPtr pMatrix);

        /// <summary>
        /// 矩阵创建
        /// </summary>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_create")]
        public static extern IntPtr _matrix_create();

        /// <summary>
        /// 矩阵销毁
        /// </summary>
        /// <param name="pMatrix"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_destroy")]
        public static extern bool _matrix_destroy(IntPtr pMatrix);

        /// <summary>
        /// 矩阵重置
        /// </summary>
        /// <param name="pMatrix"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_reset")]
        public static extern bool _matrix_reset(IntPtr pMatrix);

        /// <summary>
        /// 矩阵转置
        /// </summary>
        /// <param name="pMatrix"></param>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_translate")]
        public static extern bool _matrix_translate(IntPtr pMatrix, float offsetX, float offsetY);

        /// <summary>
        /// 矩阵旋转
        /// </summary>
        /// <param name="pMatrix"></param>
        /// <param name="fAngle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_rotate")]
        public static extern bool _matrix_rotate(IntPtr pMatrix, float fAngle);

        /// <summary>
        /// 矩阵缩放
        /// </summary>
        /// <param name="pMatrix"></param>
        /// <param name="scaleX"></param>
        /// <param name="scaleY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_scale")]
        public static extern bool _matrix_scale(IntPtr pMatrix, float scaleX, float scaleY);

        /// <summary>
        /// 图像创建自资源包
        /// </summary>
        /// <param name="hRes"></param>
        /// <param name="atomPath"></param>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromres")]
        public static extern bool _img_createfromres(IntPtr hRes, int atomPath, out int hImg);

        /// <summary>
        /// 画刷置颜色
        /// </summary>
        /// <param name="hBrush"></param>
        /// <param name="argb"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_setcolor")]
        public static extern int _brush_setcolor(IntPtr hBrush, int argb);

        /// <summary>
        /// 绘制主题数据
        /// </summary>
        /// <param name="hTheme"></param>
        /// <param name="hCanvas"></param>
        /// <param name="dstLeft"></param>
        /// <param name="dstTop"></param>
        /// <param name="dstRight"></param>
        /// <param name="dstBottom"></param>
        /// <param name="atomClass"></param>
        /// <param name="atomSrcRect"></param>
        /// <param name="dwAlpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeDrawControl")]
        public static extern bool Ex_ThemeDrawControl(int hTheme, int hCanvas, float dstLeft, float dstTop, float dstRight, float dstBottom, int atomClass, int atomSrcRect, int dwAlpha);

        /// <summary>
        /// 画刷创建自图片句柄
        /// </summary>
        /// <param name="hImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createfromimg")]
        public static extern IntPtr _brush_createfromimg(int hImg);

        /// <summary>
        /// 路径创建
        /// </summary>
        /// <param name="dwFlags"></param>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_create")]
        public static extern bool _path_create(int dwFlags, out int hPath);

        /// <summary>
        /// 路径销毁
        /// </summary>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_destroy")]
        public static extern bool _path_destroy(int hPath);

        /// <summary>
        /// 路径添加直线
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addline")]
        public static extern bool _path_addline(int hPath, float x1, float y1, float x2, float y2);

        /// <summary>
        /// 路径开始新图形
        /// </summary>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_beginfigure")]
        public static extern bool _path_beginfigure(int hPath);

        /// <summary>
        /// 路径开始新图形2,可设置起始点
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_beginfigure2")]
        public static extern bool _path_beginfigure2(int hPath, float x, float y);

        /// <summary>
        /// 路径开始新图形3,可设置起始点和类型
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="figureBegin"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_beginfigure2")]
        public static extern bool _path_beginfigure3(int hPath, float x, float y,int figureBegin);

        /// <summary>
        /// 路径结束当前图形
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="fCloseFigure"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_endfigure")]
        public static extern bool _path_endfigure(int hPath, bool fCloseFigure);

        /// <summary>
        /// 路径添加贝塞尔曲线
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addbezier")]
        public static extern bool _path_addbezier(int hPath, float x1, float y1, float x2, float y2, float x3, float y3);

        /// <summary>
        /// 路径添加二次方贝塞尔曲线
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addquadraticbezier")]
        public static extern bool _path_addquadraticbezier(int hPath, float x1, float y1, float x2, float y2);

        /// <summary>
        /// 申请内存
        /// </summary>
        /// <param name="dwLen"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_AllocBuffer")]
        public static extern IntPtr Ex_AllocBuffer(int dwLen);

        /// <summary>
        /// 图像缩放
        /// </summary>
        /// <param name="hImage"></param>
        /// <param name="dstWidth"></param>
        /// <param name="dstHeight"></param>
        /// <param name="dstImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_scale")]
        public static extern bool _img_scale(int hImage, int dstWidth, int dstHeight, out int dstImg);

        /// <summary>
        /// 布局创建
        /// </summary>
        /// <param name="nType"></param>
        /// <param name="hObjBind"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_create")]
        public static extern int _layout_create(int nType, int hObjBind);

        /// <summary>
        /// 布局销毁
        /// </summary>
        /// <param name="hLayout"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_destroy")]
        public static extern bool _layout_destroy(int hLayout);

        /// <summary>
        /// 布局添加组件
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_addchild")]
        public static extern bool _layout_addchild(int hLayout, int hObj);

        /// <summary>
        /// 布局加入所有组件,已被加入的不会重复添加(系统按钮不加入)
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="fDesc"></param>
        /// <param name="dwObjClassATOM"></param>
        /// <param name="nCount"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_addchildren")]
        public static extern bool _layout_addchildren(int hLayout, bool fDesc, int dwObjClassATOM, out int nCount);

        /// <summary>
        /// 布局删除组件
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_deletechild")]
        public static extern bool _layout_deletechild(int hLayout, int hObj);

        /// <summary>
        /// 布局删除所有组件
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="dwObjClassATOM"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_deletechildren")]
        public static extern bool _layout_deletechildren(int hLayout, int dwObjClassATOM);

        /// <summary>
        /// 布局置子属性
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObj"></param>
        /// <param name="dwPropID"></param>
        /// <param name="pvValue"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_setchildprop")]
        public static extern bool _layout_setchildprop(int hLayout, int hObj, int dwPropID, IntPtr pvValue);

        /// <summary>
        /// 布局取子属性
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObj"></param>
        /// <param name="dwPropID"></param>
        /// <param name="pvValue"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getchildprop")]
        public static extern bool _layout_getchildprop(int hLayout, int hObj, int dwPropID, out IntPtr pvValue);

        /// <summary>
        /// 布局取子属性列表
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObj"></param>
        /// <param name="lpProps"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getchildproplist")]
        public static extern bool _layout_getchildproplist(int hLayout, int hObj, out IntPtr lpProps);

        /// <summary>
        /// 布局取属性
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="dwPropID"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getprop")]
        public static extern IntPtr _layout_getprop(int hLayout, int dwPropID);

        /// <summary>
        /// 布局置属性
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="dwPropID"></param>
        /// <param name="pvValue"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_setprop")]
        public static extern bool _layout_setprop(int hLayout, int dwPropID, IntPtr pvValue);

        /// <summary>
        /// 布局取属性列表
        /// </summary>
        /// <param name="hLayout"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getproplist")]
        public static extern IntPtr _layout_getproplist(int hLayout);

        /// <summary>
        /// 布局更新
        /// </summary>
        /// <param name="hLayout"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_update")]
        public static extern bool _layout_update(int hLayout);

        /// <summary>
        /// 布局取类型
        /// </summary>
        /// <param name="hLayout"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_gettype")]
        public static extern int _layout_gettype(int hLayout);

        /// <summary>
        /// 布局置是否允许更新
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="fUpdateable"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_enableupdate")]
        public static extern bool _layout_enableupdate(int hLayout, bool fUpdateable);

        /// <summary>
        /// 布局分发通知
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="nEvent"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_notify")]
        public static extern IntPtr _layout_notify(int hLayout, int nEvent, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 组件获取父组件和引擎句柄
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="phExDUI"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetParentEx")]
        public static extern int Ex_ObjGetParentEx(int hObj, out int phExDUI);

        /// <summary>
        /// 组件获取文本矩形
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpRect"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetTextRect")]
        public static extern bool Ex_ObjGetTextRect(int hObj, out ExRect lpRect);

        /// <summary>
        /// 绘制主题数据Ex
        /// </summary>
        /// <param name="hTheme"></param>
        /// <param name="hCanvas"></param>
        /// <param name="dstLeft"></param>
        /// <param name="dstTop"></param>
        /// <param name="dstRight"></param>
        /// <param name="dstBottom"></param>
        /// <param name="atomClass"></param>
        /// <param name="atomSrcRect"></param>
        /// <param name="atomBackgroundRepeat"></param>
        /// <param name="atomBackgroundPositon"></param>
        /// <param name="atomBackgroundGrid"></param>
        /// <param name="atomBackgroundFlags"></param>
        /// <param name="dwAlpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeDrawControlEx")]
        public static extern bool Ex_ThemeDrawControlEx(int hTheme, int hCanvas, float dstLeft, float dstTop, float dstRight, float dstBottom, int atomClass, int atomSrcRect, int atomBackgroundRepeat, int atomBackgroundPositon, int atomBackgroundGrid, int atomBackgroundFlags, int dwAlpha);

        /// <summary>
        /// 字体取描述表
        /// </summary>
        /// <param name="hFont"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_getcontext")]
        public static extern IntPtr _font_getcontext(int hFont);

        /// <summary>
        /// 组件设置提示文本
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpString"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjTooltipsSetText")]
        public static extern bool Ex_ObjTooltipsSetText(int hObj, string lpString);

        /// <summary>
        /// 弹出菜单
        /// </summary>
        /// <param name="hMenu"></param>
        /// <param name="uFlags">相关常量 TPM_</param>
        /// <param name="x">弹出坐标X(屏幕坐标)</param>
        /// <param name="y">弹出坐标Y(屏幕坐标)</param>
        /// <param name="nReserved">保留参数</param>
        /// <param name="handle">组件句柄/引擎句柄/窗口句柄.(如果该值为窗口句柄且窗口未使用引擎渲染,则以默认菜单弹出)</param>
        /// <param name="lpRc"></param>
        /// <param name="pfnCallback"></param>
        /// <param name="dwFlags">相关常量 EMNF_</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_TrackPopupMenu")]
        public static extern bool Ex_TrackPopupMenu(IntPtr hMenu, int uFlags, int x, int y, IntPtr nReserved, int handle, IntPtr lpRc, ExWndProcDelegate pfnCallback, int dwFlags);

        /// <summary>
        /// 从窗口句柄获取引擎句柄
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIFromWindow")]
        public static extern IntPtr Ex_DUIFromWindow(IntPtr hWnd);

        /// <summary>
        /// 组件获取滚动条范围
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <param name="lpnMinPos"></param>
        /// <param name="lpnMaxPos"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetRange")]
        public static extern bool Ex_ObjScrollGetRange(int hObj, int nBar, out int lpnMinPos, out int lpnMaxPos);

        /// <summary>
        /// 组件获取滚动条拖动位置
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetTrackPos")]
        public static extern int Ex_ObjScrollGetTrackPos(int hObj, int nBar);

        /// <summary>
        /// 组件获取滚动条信息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nBar"></param>
        /// <param name="lpnMin"></param>
        /// <param name="lpnMax"></param>
        /// <param name="lpnPos"></param>
        /// <param name="lpnTrackPos"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetInfo")]
        public static extern bool Ex_ObjScrollGetInfo(int hObj, int nBar, out int lpnMin, out int lpnMax, out int lpnPos, out int lpnTrackPos);

        /// <summary>
        /// 获取组件句柄自节点ID
        /// </summary>
        /// <param name="hExDUIOrObj"></param>
        /// <param name="nNodeID"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFromNodeID")]
        public static extern int Ex_ObjGetFromNodeID(int hExDUIOrObj, int nNodeID);

        /// <summary>
        /// 组件取矩形Ex
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpRect"></param>
        /// <param name="nType"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetRectEx")]
        public static extern bool Ex_ObjGetRectEx(int hObj, out ExRect lpRect, int nType);

        /// <summary>
        /// 组件获取布局对象句柄
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutGet")]
        public static extern IntPtr Ex_ObjLayoutGet(int handle);

        /// <summary>
        /// 组件设置布局对象句柄
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="hLayout"></param>
        /// <param name="fUpdate"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutSet")]
        public static extern bool Ex_ObjLayoutSet(int handle, int hLayout, bool fUpdate);

        /// <summary>
        /// 组件更新对象布局
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutUpdate")]
        public static extern bool Ex_ObjLayoutUpdate(int handle);

        /// <summary>
        /// 清空对象布局信息
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="bChildren"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutClear")]
        public static extern bool Ex_ObjLayoutClear(int handle, bool bChildren);

        /// <summary>
        /// 布局置表格信息
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="aRowHeight"></param>
        /// <param name="cRows"></param>
        /// <param name="aCellWidth"></param>
        /// <param name="cCells"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_table_setinfo")]
        public static extern bool _layout_table_setinfo(int hLayout, int[] aRowHeight, int cRows, int[] aCellWidth, int cCells);

        /// <summary>
        /// 组件设置偏移矩形
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nPaddingType"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetPadding")]
        public static extern bool Ex_ObjSetPadding(int hObj, int nPaddingType, int left, int top, int right, int bottom, bool fRedraw);

        /// <summary>
        /// 组件设置文本字体从字体名称
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpszFontfamily"></param>
        /// <param name="dwFontsize"></param>
        /// <param name="dwFontstyle"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetFontFromFamily")]
        public static extern bool Ex_ObjSetFontFromFamily(int hObj, string lpszFontfamily, int dwFontsize, int dwFontstyle, bool fRedraw);

        /// <summary>
        /// 组件获取字体。用户不应该销毁该字体对象
        /// </summary>
        /// <param name="hObj"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFont")]
        public static extern int Ex_ObjGetFont(int hObj);

        /// <summary>
        /// 坐标转换
        /// </summary>
        /// <param name="hObjSrc"></param>
        /// <param name="hObjDst"></param>
        /// <param name="ptX"></param>
        /// <param name="ptY"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjPointTransform")]
        public static extern bool Ex_ObjPointTransform(int hObjSrc, int hObjDst, ref int ptX, ref int ptY);

        /// <summary>
        /// 组件设置是否启用事件冒泡
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fEnable"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnableEventBubble")]
        public static extern bool Ex_ObjEnableEventBubble(int hObj, bool fEnable);

        /// <summary>
        /// 组件获取类信息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpClassInfo"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetClassInfo")]
        public static extern bool Ex_ObjGetClassInfo(int hObj, out ExClassInfo lpClassInfo);

        /// <summary>
        /// 通过类名/类ATOM获取类信息
        /// </summary>
        /// <param name="wzClassName"></param>
        /// <param name="lpClassInfo"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetClassInfoEx")]
        public static extern bool Ex_ObjGetClassInfoEx(string wzClassName, out ExClassInfo lpClassInfo);

        /// <summary>
        /// 缓动创建
        /// </summary>
        /// <param name="dwType"></param>
        /// <param name="pEasingContext"></param>
        /// <param name="dwMode"></param>
        /// <param name="pContext"></param>
        /// <param name="nTotalTime"></param>
        /// <param name="nInterval"></param>
        /// <param name="nState"></param>
        /// <param name="nStart"></param>
        /// <param name="nStop"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <param name="param4"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_create")]
        public static extern IntPtr _easing_create(int dwType, IntPtr pEasingContext, int dwMode, ExEasingProcDelegate pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4);

        /// <summary>
        /// 缓动创建
        /// </summary>
        /// <param name="dwType"></param>
        /// <param name="pEasingContext"></param>
        /// <param name="dwMode"></param>
        /// <param name="pContext"></param>
        /// <param name="nTotalTime"></param>
        /// <param name="nInterval"></param>
        /// <param name="nState"></param>
        /// <param name="nStart"></param>
        /// <param name="nStop"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <param name="param4"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_create")]
        public static extern IntPtr _easing_create(int dwType, IntPtr pEasingContext, int dwMode, IntPtr pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4);

        /// <summary>
        /// 缓动置状态
        /// </summary>
        /// <param name="pEasing"></param>
        /// <param name="nState"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_setstate")]
        public static extern bool _easing_setstate(IntPtr pEasing, int nState);

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="us"></param>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Sleep")]
        public static extern void Ex_Sleep(int us);

        /// <summary>
        /// 缓动取状态
        /// </summary>
        /// <param name="pEasing"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_getstate")]
        public static extern int _easing_getstate(IntPtr pEasing);

        /// <summary>
        /// 绝对布局置边界信息
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObjChild"></param>
        /// <param name="dwEdge"></param>
        /// <param name="dwType"></param>
        /// <param name="nValue"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_absolute_setedge")]
        public static extern bool _layout_absolute_setedge(int hLayout, int hObjChild, int dwEdge, int dwType, IntPtr nValue);

        /// <summary>
        /// 绝对布局按当前位置锁定
        /// </summary>
        /// <param name="hLayout"></param>
        /// <param name="hObjChild"></param>
        /// <param name="tLeft"></param>
        /// <param name="tTop"></param>
        /// <param name="tRight"></param>
        /// <param name="tBottom"></param>
        /// <param name="tWidth"></param>
        /// <param name="tHeight"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_absolute_lock")]
        public static extern bool _layout_absolute_lock(int hLayout, int hObjChild, int tLeft, int tTop, int tRight, int tBottom, int tWidth, int tHeight);

        /// <summary>
        /// 初始化属性列表,要注意每次初始化都会清空之前存储的内容,若存储的是指针需要自己先行释放
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="nPropCount"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjInitPropList")]
        public static extern bool Ex_ObjInitPropList(int hObj, int nPropCount);

        /// <summary>
        /// 组件移除属性
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="dwKey"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjRemoveProp")]
        public static extern IntPtr Ex_ObjRemoveProp(int hObj, IntPtr dwKey);

        /// <summary>
        /// 组件枚举属性表
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="lpfnCbk"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnumProps")]
        public static extern int Ex_ObjEnumProps(int hObj, ExObjPropEnumCallbackDelegate lpfnCbk, IntPtr lParam);

        /// <summary>
        /// 画刷创建自画布
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createfromcanvas")]
        public static extern IntPtr _brush_createfromcanvas(int hCanvas);

        /// <summary>
        /// 画刷创建自画布2
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createfromcanvas2")]
        public static extern IntPtr _brush_createfromcanvas2(int hCanvas, int alpha);

        /// <summary>
        /// 组件设置圆角度
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="topleft"></param>
        /// <param name="topright"></param>
        /// <param name="bottomright"></param>
        /// <param name="bottomleft"></param>
        /// <param name="fUpdate"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetRadius")]
        public static extern bool Ex_ObjSetRadius(int hObj, float topleft, float topright, float bottomright, float bottomleft, bool fUpdate);

        /// <summary>
        /// 路径重置
        /// </summary>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_reset")]
        public static extern bool _path_reset(int hPath);

        /// <summary>
        /// 路径取边界矩形
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="lpBounds"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_getbounds")]
        public static extern bool _path_getbounds(int hPath, ref ExRectF lpBounds);

        /// <summary>
        /// 路径关闭
        /// </summary>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_close")]
        public static extern bool _path_close(int hPath);

        /// <summary>
        /// 路径打开
        /// </summary>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_open")]
        public static extern bool _path_open(int hPath);

        /// <summary>
        /// 路径添加弧
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x1">起始坐标X</param>
        /// <param name="y1">起始坐标Y</param>
        /// <param name="x2">终点坐标X</param>
        /// <param name="y2">终点坐标Y</param>
        /// <param name="radiusX">弧中心坐标X</param>
        /// <param name="radiusY">弧中心坐标Y</param>
        /// <param name="fClockwise">是否顺时针</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addarc")]
        public static extern bool _path_addarc(int hPath, float x1, float y1, float x2, float y2, float radiusX, float radiusY, bool fClockwise);

        /// <summary>
        /// 画布填充路径
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hPath"></param>
        /// <param name="hBrush"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillpath")]
        public static extern bool _canvas_fillpath(int hCanvas, int hPath, IntPtr hBrush);

        /// <summary>
        /// 路径添加矩形
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addrect")]
        public static extern bool _path_addrect(int hPath, float left, float top, float right, float bottom);

        /// <summary>
        /// 路径添加圆角矩形
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="radiusTopLeft"></param>
        /// <param name="radiusTopRight"></param>
        /// <param name="radiusBottomLeft"></param>
        /// <param name="radiusBottomRight"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addroundedrect")]
        public static extern bool _path_addroundedrect(int hPath, float left, float top, float right, float bottom, float radiusTopLeft, float radiusTopRight, float radiusBottomLeft, float radiusBottomRight);

        /// <summary>
        /// 路径测试坐标是否在可见路径内
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_hittest")]
        public static extern bool _path_hittest(int hPath, float x, float y);

        /// <summary>
        /// 画刷置矩阵
        /// </summary>
        /// <param name="hBrush"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_settransform")]
        public static extern int _brush_settransform(IntPtr hBrush, IntPtr matrix);

        /// <summary>
        /// 组件显示/隐藏滚动条
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="wBar"></param>
        /// <param name="fShow"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollShow")]
        public static extern bool Ex_ObjScrollShow(int hObj, int wBar, bool fShow);

        /// <summary>
        /// 组件禁用/启用滚动条
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="wSB"></param>
        /// <param name="wArrows"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollEnable")]
        public static extern bool Ex_ObjScrollEnable(int hObj, int wSB, int wArrows);

        /// <summary>
        /// 组件设置文本字体从字体句柄
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="hFont"></param>
        /// <param name="fRedraw"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetFont")]
        public static extern bool Ex_ObjSetFont(int hObj, int hFont, bool fRedraw);

        /// <summary>
        /// 图片组创建
        /// </summary>
        /// <param name="nWidth"></param>
        /// <param name="nHeight"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_create")]
        public static extern IntPtr _imglist_create(int nWidth, int nHeight);

        /// <summary>
        /// 图片组销毁
        /// </summary>
        /// <param name="hImageList"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_destroy")]
        public static extern bool _imglist_destroy(IntPtr hImageList);

        /// <summary>
        /// 图片组添加图片从数据指针
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="lpImage"></param>
        /// <param name="cbImage"></param>
        /// <param name="nIndexInsert"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_add")]
        public static extern IntPtr _imglist_add(IntPtr hImageList, byte[] lpImage, IntPtr cbImage, IntPtr nIndexInsert);

        /// <summary>
        /// 图片组添加图片从图片句柄
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="hImage"></param>
        /// <param name="nIndexInsert"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_addimage")]
        public static extern IntPtr _imglist_addimage(IntPtr hImageList, int hImage, IntPtr nIndexInsert);

        /// <summary>
        /// 图片组删除图片
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_del")]
        public static extern bool _imglist_del(IntPtr hImageList, IntPtr nIndex);

        /// <summary>
        /// 图片组获取图片句柄
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_get")]
        public static extern IntPtr _imglist_get(IntPtr hImageList, IntPtr nIndex);

        /// <summary>
        /// 图片组设置图片从数据
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="nIndex"></param>
        /// <param name="lpImage"></param>
        /// <param name="cbImage"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_set")]
        public static extern bool _imglist_set(IntPtr hImageList, IntPtr nIndex, byte[] lpImage, IntPtr cbImage);

        /// <summary>
        /// 图片组设置图片从图像句柄
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="nIndex"></param>
        /// <param name="hImage"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_setimage")]
        public static extern bool _imglist_setimage(IntPtr hImageList, IntPtr nIndex, int hImage);

        /// <summary>
        /// 图片组获取图片数量
        /// </summary>
        /// <param name="hImageList"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_count")]
        public static extern int _imglist_count(IntPtr hImageList);

        /// <summary>
        /// 图片组获取图片尺寸
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_count")]
        public static extern bool _imglist_size(IntPtr hImageList, out int pWidth, out int pHeight);

        /// <summary>
        /// 图片组绘制图片
        /// </summary>
        /// <param name="hImageList"></param>
        /// <param name="nIndex"></param>
        /// <param name="hCanvas"></param>
        /// <param name="nLeft"></param>
        /// <param name="nTop"></param>
        /// <param name="nRight"></param>
        /// <param name="nBottom"></param>
        /// <param name="nAlpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_draw")]
        public static extern bool _imglist_draw(IntPtr hImageList, IntPtr nIndex, int hCanvas, int nLeft, int nTop, int nRight, int nBottom, int nAlpha);

        /// <summary>
        /// 组件是否允许启用输入法
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fEnable"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnableIME")]
        public static extern bool Ex_ObjEnableIME(int hObj, bool fEnable);

        /// <summary>
        /// 组件设置窗口的输入法状态
        /// </summary>
        /// <param name="hObjOrExDui"></param>
        /// <param name="fOpen"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetIMEState")]
        public static extern bool Ex_ObjSetIMEState(int hObjOrExDui, bool fOpen);

        /// <summary>
        /// 组件设置是否禁止转换空格和回车为单击事件
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fDisable"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDisableTranslateSpaceAndEnterToClick")]
        public static extern bool Ex_ObjDisableTranslateSpaceAndEnterToClick(int hObj, bool fDisable);

        /// <summary>
        /// 画布设置文本抗锯齿
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="textAntialiasMode"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_settextantialiasmode")]
        public static extern bool _canvas_settextantialiasmode(int hCanvas, bool textAntialiasMode);

        /// <summary>
        /// 画布设置图形抗锯齿
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="antialias"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_setantialias")]
        public static extern bool _canvas_setantialias(int hCanvas, bool antialias);

        /// <summary>
        /// 画布设置图像抗锯齿,等效于同时设置文本和图形抗锯齿
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="antialias"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_setimageantialias")]
        public static extern bool _canvas_setimageantialias(int hCanvas, bool antialias);

        /// <summary>
        /// 组件置父
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="hParent"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetParent")]
        public static extern bool Ex_ObjSetParent(int hObj, int hParent);

        /// <summary>
        /// 区域创建自路径
        /// </summary>
        /// <param name="hPath"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_createfrompath")]
        public static extern IntPtr _rgn_createfrompath(int hPath);
        
        /// <summary>
        /// 图像加载自缓冲区
        /// </summary>
        /// <param name="lpData"></param>
        /// <param name="dwLen"></param>
        /// <param name="uType"></param>
        /// <param name="nIndex"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_LoadImageFromMemory")]
        public static extern IntPtr Ex_LoadImageFromMemory(byte[] lpData, IntPtr dwLen, int uType, int nIndex);

        /// <summary>
        /// 图像裁剪
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="phImg"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_clip")]
        public static extern bool _img_clip(int hImg, int left, int top, int width, int height, out int phImg);

        /// <summary>
        /// 图像保存到文件
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="lpwzFile"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_savetofile")]
        public static extern bool _img_savetofile(int hImg, string lpwzFile);


        /// <summary>
        /// 图像保存到缓冲区
        /// </summary>
        /// <param name="hImg"></param>
        /// <param name="lpBuffer"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_savetomemory")]
        public static extern IntPtr _img_savetomemory(int hImg, IntPtr lpBuffer);

        /// <summary>
        /// 添加弧 v2
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="startAngle">开始角度</param>
        /// <param name="sweepAngle">扫描角度</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addarc2")]
        public static extern bool _path_addarc2(int hPath, float x, float y, float width, float height, float startAngle, float sweepAngle);

        /// <summary>
        /// 添加弧 v3
        /// </summary>
        /// <param name="hPath"></param>
        /// <param name="x">终点坐标X</param>
        /// <param name="y">终点坐标Y</param>
        /// <param name="radiusX">弧中心坐标X</param>
        /// <param name="radiusY">弧中心坐标Y</param>
        /// <param name="startAngle">开始角度</param>
        /// <param name="sweepAngle">扫描角度</param>
        /// <param name="fClockwise">是否顺时针</param>
        /// <param name="barcSize">是否大于180°</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addarc3")]
        public static extern bool _path_addarc3(IntPtr hPath, float x, float y, float radiusX, float radiusY, float startAngle, float sweepAngle, bool fClockwise, bool barcSize);


        /// <summary>
        /// 组件校验拖曳格式
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="pDataObject"></param>
        /// <param name="dwFormat"></param>
        /// <returns>返回是否适用</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCheckDropFormat")]
        public static extern bool Ex_ObjCheckDropFormat(int hObj, IntPtr pDataObject, int dwFormat);

        /// <summary>
        /// 组件取拖曳文本
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="pDataObject"></param>
        /// <param name="lpwzBuffer"></param>
        /// <param name="cchMaxLength"></param>
        /// <returns>返回字符数,0表示失败</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetDropString")]
        public static extern int Ex_ObjGetDropString(int hObj, int pDataObject, StringBuilder lpwzBuffer, int cchMaxLength);


        /// <summary>
        /// 设置控件是否启用绘画中消息
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="fEnable"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnablePaintingMsg")]
        public static extern bool Ex_ObjEnablePaintingMsg(int hObj, bool fEnable);

        #region 画布
        
        
        /// <summary>
        /// 画布开始绘制
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_begindraw")]
        public static extern bool _canvas_begindraw(int hCanvas);

        /// <summary>
        /// 画布模糊
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="fDeviation"></param>
        /// <param name="lprc"></param>
        /// <returns>返回是否成功</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_blur")]
        public static extern bool _canvas_blur(int hCanvas, float fDeviation, ref IntPtr lprc);

        /// <summary>
        /// 画布计算文本尺寸
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hFont"></param>
        /// <param name="lpwzText"></param>
        /// <param name="dwLen"></param>
        /// <param name="dwDTFormat"></param>
        /// <param name="lParam"></param>
        /// <param name="layoutWidth"></param>
        /// <param name="layoutHeight"></param>
        /// <param name="lpWidth"></param>
        /// <param name="lpHeight"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_calctextsize")]
        public static extern bool _canvas_calctextsize(int hCanvas, int hFont, string lpwzText, IntPtr dwLen, int dwDTFormat, IntPtr lParam, float layoutWidth, float layoutHeight, out float lpWidth, out float lpHeight);

        /// <summary>
        /// 画布清除背景
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="nColor"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_clear")]
        public static extern bool _canvas_clear(int hCanvas, int nColor);

        /// <summary>
        /// 画布置剪辑区
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_cliprect")]
        public static extern bool _canvas_cliprect(int hCanvas, int left, int top, int right, int bottom);

        /// <summary>
        /// 画布创建自引擎句柄
        /// </summary>
        /// <param name="hExDui"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_createfromexdui")]
        public static extern int _canvas_createfromexdui(int hExDui, int width, int height, int dwFlags);

        /// <summary>
        /// 创建画布自组件句柄
        /// </summary>
        /// <param name="hObj"></param>
        /// <param name="uWidth"></param>
        /// <param name="uHeight"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_createfromobj")]
        public static extern int _canvas_createfromobj(int hObj, int uWidth, int uHeight, int dwFlags);

        /// <summary>
        /// 画布销毁
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_destroy")]
        public static extern bool _canvas_destroy(int hCanvas);

        /// <summary>
        /// 画布画画布
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="sCanvas"></param>
        /// <param name="dstLeft"></param>
        /// <param name="dstTop"></param>
        /// <param name="dstRight"></param>
        /// <param name="dstBottom"></param>
        /// <param name="srcLeft"></param>
        /// <param name="srcTop"></param>
        /// <param name="dwAlpha"></param>
        /// <param name="dwCompositeMode"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawcanvas")]
        public static extern bool _canvas_drawcanvas(int hCanvas, int sCanvas, int dstLeft, int dstTop, int dstRight, int dstBottom, int srcLeft, int srcTop, int dwAlpha, int dwCompositeMode);

        /// <summary>
        /// 画布画椭圆
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        /// <param name="strokeWidth"></param>
        /// <param name="strokeStyle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawellipse")]
        public static extern bool _canvas_drawellipse(int hCanvas, IntPtr hBrush, float x, float y, float radiusX, float radiusY, float strokeWidth, int strokeStyle);

        /// <summary>
        /// 画布画图片
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hImage"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimage")]
        public static extern bool _canvas_drawimage(int hCanvas, int hImage, float left, float top, int alpha);

        /// <summary>
        /// 画布画九宫矩形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hImage"></param>
        /// <param name="dstLeft"></param>
        /// <param name="dstTop"></param>
        /// <param name="dstRight"></param>
        /// <param name="dstBottom"></param>
        /// <param name="srcLeft"></param>
        /// <param name="srcTop"></param>
        /// <param name="srcRight"></param>
        /// <param name="srcBottom"></param>
        /// <param name="gridPaddingLeft"></param>
        /// <param name="gridPaddingTop"></param>
        /// <param name="gridPaddingRight"></param>
        /// <param name="gridPaddingBottom"></param>
        /// <param name="dwFlags"></param>
        /// <param name="dwAlpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimagefromgrid")]
        public static extern bool _canvas_drawimagefromgrid(int hCanvas, int hImage, float dstLeft, float dstTop, float dstRight, float dstBottom, float srcLeft, float srcTop, float srcRight, float srcBottom, float gridPaddingLeft, float gridPaddingTop, float gridPaddingRight, float gridPaddingBottom, int dwFlags, int dwAlpha);

        /// <summary>
        /// 画布画图像矩形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hImage"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimagerect")]
        public static extern bool _canvas_drawimagerect(int hCanvas, int hImage, float left, float top, float right, float bottom, int alpha);

        /// <summary>
        /// 画布画图像缩放到
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hImage"></param>
        /// <param name="dstLeft"></param>
        /// <param name="dstTop"></param>
        /// <param name="dstRight"></param>
        /// <param name="dstBottom"></param>
        /// <param name="srcLeft"></param>
        /// <param name="srcTop"></param>
        /// <param name="srcRight"></param>
        /// <param name="srcBottom"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimagerectrect")]
        public static extern bool _canvas_drawimagerectrect(int hCanvas, int hImage, float dstLeft, float dstTop, float dstRight, float dstBottom, float srcLeft, float srcTop, float srcRight, float srcBottom, int alpha);

        /// <summary>
        /// 画布画直线
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="X1"></param>
        /// <param name="Y1"></param>
        /// <param name="X2"></param>
        /// <param name="Y2"></param>
        /// <param name="strokeWidth"></param>
        /// <param name="strokeStyle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawline")]
        public static extern bool _canvas_drawline(int hCanvas, IntPtr hBrush, float X1, float Y1, float X2, float Y2, float strokeWidth, int strokeStyle);

        /// <summary>
        /// 画布画路径
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hPath"></param>
        /// <param name="hBrush"></param>
        /// <param name="strokeWidth"></param>
        /// <param name="strokeStyle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawpath")]
        public static extern int _canvas_drawpath(int hCanvas, int hPath, IntPtr hBrush, float strokeWidth, int strokeStyle);

        /// <summary>
        /// 画布画多边形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="left">绘制多边形外接椭圆的左边</param>
        /// <param name="top">绘制多边形外接椭圆的顶边</param>
        /// <param name="right">绘制多边形外接椭圆的右边</param>
        /// <param name="bottom">绘制多边形外接椭圆的底边</param>
        /// <param name="numberOfEdges">边数</param>
        /// <param name="angle">角度</param>
        /// <param name="strokeWidth">绘制的线宽</param>
        /// <param name="strokeStyle">绘制的线型</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawpolygon")]
        public static extern int _canvas_drawpolygon(int hCanvas, IntPtr hBrush, float left, float top, float right, float bottom, int numberOfEdges, float angle, float strokeWidth, int strokeStyle);

        /// <summary>
        /// 画布画矩形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="strokeWidth"></param>
        /// <param name="strokeStyle"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawrect")]
        public static extern bool _canvas_drawrect(int hCanvas, IntPtr hBrush, float left, float top, float right, float bottom, float strokeWidth, int strokeStyle);

        /// <summary>
        /// 画布画圆角矩形
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hBrush"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="radiusX">横向圆角度</param>
        /// <param name="radiusY">纵向圆角度</param>
        /// <param name="strokeWidth">画刷宽度</param>
        /// <param name="strokeStyle"></param>
        /// <returns>返回是否成功</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawroundedrect")]
        public static extern bool _canvas_drawroundedrect(int hCanvas, IntPtr hBrush, float left, float top, float right, float bottom, float radiusX, float radiusY, float strokeWidth, int strokeStyle);

        /// <summary>
        /// 画布画阴影
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="fLeft">阴影包围左边</param>
        /// <param name="fTop">阴影包围顶边</param>
        /// <param name="fRight">阴影包围右边</param>
        /// <param name="fBottom">阴影包围底边</param>
        /// <param name="fShadowSize">阴影尺寸</param>
        /// <param name="crShadow">阴影颜色</param>
        /// <param name="radiusTopLeft">左上角圆角度</param>
        /// <param name="radiusTopRight">右上角圆角度</param>
        /// <param name="radiusBottomLeft">左下角圆角度</param>
        /// <param name="radiusBottomRight">右下角圆角度</param>
        /// <param name="OffsetX">阴影横向偏移</param>
        /// <param name="OffsetY">阴影纵向偏移</param>
        /// <returns>返回是否成功</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawshadow")]
        public static extern bool _canvas_drawshadow(int hCanvas, float fLeft, float fTop, float fRight, float fBottom, float fShadowSize, int crShadow, float radiusTopLeft, float radiusTopRight, float radiusBottomLeft, float radiusBottomRight, float OffsetX, float OffsetY);

        /// <summary>
        /// 画布画文本
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hFont">如果为0则使用默认字体句柄</param>
        /// <param name="crText"></param>
        /// <param name="lpwzText"></param>
        /// <param name="dwLen">-1则自动计算尺寸(必须是指向空字符串的指针)</param>
        /// <param name="dwDTFormat">#DT_</param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns>返回是否成功</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawtext")]
        public static extern bool _canvas_drawtext(int hCanvas, int hFont, int crText, string lpwzText, IntPtr dwLen, int dwDTFormat, float left, float top, float right, float bottom);

        /// <summary>
        /// 画布画文本2
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hFont">如果为0则使用默认字体句柄</param>
        /// <param name="hBrush"></param>
        /// <param name="lpwzText"></param>
        /// <param name="dwLen">-1则自动计算尺寸(必须是指向空字符串的指针)</param>
        /// <param name="dwDTFormat">#DT_</param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns>返回是否成功</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawtext2")]
        public static extern bool _canvas_drawtext2(int hCanvas, int hFont, IntPtr hBrush, string lpwzText, IntPtr dwLen, int dwDTFormat, float left, float top, float right, float bottom);

        /// <summary>
        /// 画布画文本Ex
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="hFont"></param>
        /// <param name="crText"></param>
        /// <param name="lpwzText"></param>
        /// <param name="dwLen"></param>
        /// <param name="dwDTFormat"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="iGlowsize"></param>
        /// <param name="crShadow"></param>
        /// <param name="lParam"></param>
        /// <returns>返回是否成功</returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawtextex")]
        public static extern bool _canvas_drawtextex(int hCanvas, int hFont, int crText, string lpwzText, IntPtr dwLen, int dwDTFormat, float left, float top, float right, float bottom, int iGlowsize, int crShadow, IntPtr lParam);

        /// <summary>
        /// 画布画SVG从数据
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="data"></param>
        /// <param name="color"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawsvg")]
        public static extern int _canvas_drawsvg(int hCanvas, IntPtr data, int color, float left, float top, float right, float bottom);

        /// <summary>
        /// 画布画SVG从数据
        /// </summary>
        /// <param name="hCanvas"></param>
        /// <param name="svgName"></param>
        /// <param name="color"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawsvgfromfile")]
        public static extern int _canvas_drawsvgfromfile(int hCanvas, string svgName, int color, float left, float top, float right, float bottom);

        /// <summary>
        /// 在画布上填充一个多边形
        /// </summary>
        /// <param name="hCanvas">画布句柄</param>
        /// <param name="hBrush">画刷句柄</param>
        /// <param name="left">填充多边形外接椭圆的坐标</param>
        /// <param name="top">填充多边形外接椭圆的坐标</param>
        /// <param name="right">填充多边形外接椭圆的坐标</param>
        /// <param name="bottom">填充多边形外接椭圆的坐标</param>
        /// <param name="numberOfEdges">边数</param>
        /// <param name="angle">角度</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillpolygon")]
        public static extern int _canvas_fillpolygon(int hCanvas, IntPtr hBrush, float left, float top, float right, float bottom, int numberOfEdges, float angle);
        
        
        #endregion
    }
}
