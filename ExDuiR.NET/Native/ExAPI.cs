using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static ExDuiR.NET.Native.WinAPI;

namespace ExDuiR.NET.Native
{
    public delegate nint ExWndProcDelegate(nint hWnd, int hExDui, int uMsg, nint wParam, nint lParam, nint pResult);
    public delegate nint ExObjProcDelegate(nint hWnd, int hObj, int uMsg, nint wParam, nint lParam, nint pResult);
    public delegate nint ExObjClassProcDelegate(nint hWnd, int hObj, int uMsg, nint wParam, nint lParam, nint pvData);
    public delegate nint ExObjEventProcDelegate(int hObj, int nID, int nCode, nint wParam, nint lParam);
    //public delegate bool ExI18NCallbackDelegate(int atomID, out string ppString);
    public delegate nint ExLayoutProcDelegate(nint pLayout, int nEvent, nint wParam, nint lParam);
    public delegate bool ExObjEnumCallbackDelegate(int hObj, nint lParam);
    public delegate nint ExObjPropEnumCallbackDelegate(int hObj, nint nKey, nint nValue, nint lParam);
    public delegate void ExCefBeforeCommandLineCallbackDelegate(int uMsg, nint handler, int hObj, nint attach1, nint attach2, nint attach3, nint attach4, nint pbHWEBVIEWd, nint lParam);

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

    /// <summary>
    /// 绘制信息结构
    /// </summary>
    public struct ExPaintStruct
    {
        public int hCanvas;
        public nint hTheme;
        public int dwStyle;
        public int dwStyleEx;
        public int dwTextFormat;
        public int dwState;
        public nint dwOwnerData;
        public UInt32 nWidth;
        public UInt32 nHeight;
        public ExRect rcPaint;
        public ExRect rcText;
        public nint dwReserved;
    }

    /// <summary>
    /// 自定义绘制信息结构
    /// </summary>
    public struct ExCustomDraw
    {
        public int hCanvas;
        public int hTheme;
        public UInt32 dwState;
        public UInt32 dwStyle;
        public int nLeft;
        public int nTop;
        public int nRight;
        public int nBottom;
        public int iItem;
        public nint nItemParam;
    }

    /// <summary>
    /// 背景信息结构
    /// </summary>
    public struct ExBackgroundImageInfo
    {
        public int dwFlags;     //标识 
        public int hImage;         //图片句柄
        public int x;              //左上角横坐标
        public int y;              //左上角纵坐标
        public int dwRepeat;    //重复方式
        public nint lpGrid;      //九宫矩形
        public nint lpDelay;     //延时信息
        public int nCurFrame;   //当前帧
        public int nMaxFrame;   //最大帧
        public int nAlpha;      //透明度
    }


    /// <summary>
    /// 组件类信息结构
    /// </summary>
    public struct ExClassInfo
    {
        public UInt32 dwFlags;
        public int dwStyle;
        public int dwStyleEx;
        public int dwTextFormat;
        public int cbObjExtra;
        public nint hCursor;
        public nint pfnProc;
        public int atomName;
    }

    /// <summary>
    /// 接收WM_NOTIFY通知信息结构
    /// </summary>
    public struct ExNotifyHeader
    {
        public int hObjFrom;
        public int idFrom;
        public int nCode;
        public nint wParam;
        public nint lParam;
    }

    public struct NMHDR
    {
        public nint hwndFrom;
        public nint idFrom;
        public int code;
    }

    /// <summary>
    /// 缓动信息结构
    /// </summary>
    public struct ExEasingInfo
    {
        public nint pEasing;
        public double nProgress;
        public double nCurrent;
        public nint nParam;
        public UInt32 nLastTimes;
        public nint nParam1;
        public nint nParam2;
        public nint nParam3;
        public nint nParam4;
    }

    /// <summary>
    /// 图像像素数据结构
    /// </summary>
    public struct ExBitmapData
    {
        public int nWidth;
        public int nHeight;
        public int nStride;
        public int nPixelFormat;
        public nint pScan0;
        public nint nReserved;
    }

    /// <summary>
    /// 扩展控件属性信息结构
    /// </summary>
    public struct ExObjProps
    {
        public int crBkgNormal;           //背景颜色.正常
        public int crBkgHover;            //背景颜色.悬浮
        public int crBkgDownOrChecked;    //背景颜色.按下或者选中
        public int crBkgBegin;            //渐变背景.起点颜色ARGB
        public int crBkgEnd;              //渐变背景.终点颜色ARGB
        public int crBorderNormal;        //边框颜色.正常
        public int crBorderHover;         //边框颜色.悬浮
        public int crBorderDownOrChecked; //边框颜色.按下或者选中
        public int crBorderBegin;         //渐变边框.起点颜色ARGB
        public int crBorderEnd;           //渐变边框.终点颜色ARGB
        public int crIconNormal;          //图标颜色.正常
        public int crIconHover;           //图标颜色.悬浮
        public int crIconDownOrFocus;     //图标颜色.按下或者焦点
        public int radius;                   //圆角度
        public int strokeWidth;              //线宽
        public int nIconPosition;            //图标位置 [忽略/0：左; 1：右; 2:上]
    }

    /// <summary>
    /// 报表列信息结构
    /// </summary>
    public struct ExReportListColumnInfo
    {
        public string pwzText;    //表头标题
        public UInt32 nWidth;        //列宽度
        public UInt32 dwStyle;      //表头风格 ERLV_CS_
        public UInt32 dwTextFormat; //列文本格式
        public int crText;      //列文本颜色
        public UInt32 nInsertIndex;  //插入位置,0为在最后
    };

    /// <summary>
    /// 报表项目信息结构
    /// </summary>
    public struct ExReportListItemInfo
    {
        public UInt32 iRow;         //所在行[IN / OUT]
        public UInt32 iCol;         //所在列[IN / OUT]
        public UInt32 dwStyle;     //项目行风格(同行共用)
        public string pwzText;   //项目文本
        public UInt32 nImageIndex; //项目图片组索引(同行共用)
        public nint lParam;     //项目参数(同行共用)
        public UInt32 dwState;     //项目状态(同行共用)
    };

    /// <summary>
    /// 报表行信息结构
    /// </summary>
    public struct ExReportListRowInfo
    {
        public UInt32 nInsertIndex; //插入位置,0为最后
        public UInt32 dwStyle;         //项目行风格 ERLV_RS_
        public nint lParam;         //项目附加参数
        public UInt32 nImageIndex;     //图片组索引
    };

    /// <summary>
    /// 报表排序信息结构
    /// </summary>
    public struct ExReportListSortInfo
    {
        public UInt32 iCol;                       //0为按row.lParam排序
        public UInt32 nType;                      //0:文本,1:整数
        public nint lpfnCmp;                    //LRESULT orderProc(HEXOBJ hObj,UINT nIndex1,LPVOID pvData1,UINT nIndex2,LPVOID pvData2,UINT nIndexCol,UINT nType,size_t lParam)
        public bool fDesc;                      //是否倒序
        public nint lParam;                   //排序附加参数
    };

    /// <summary>
    /// 树形框节点信息结构,不能改变成员顺序
    /// </summary>
    public struct ExTreeViewNodeItem
    {
        public int nID;                           //项目ID
        public string pwzText;                   //项目标题
        public nint lParam;                     //项目附加参数
        public UInt32 nImageIndex;                 //收缩图片索引
        public UInt32 nImageIndexExpand;           //扩展图片索引
        public bool fExpand;                      //是否展开
        public UInt32 dwStyle;                     //风格
        public int nDepth;                        //层次
        public nint pParent;     //父节点
        public nint pPrev;       //上一个节点
        public nint pNext;       //下一个节点
        public nint pChildFirst; //第一个子节点
        public int nCountChild;                   //子节点数量
    };

    /// <summary>
    /// 树形框表项信息结构,不能改变成员顺序
    /// </summary>
    public struct ExTreeViewItemInfo
    {
        public int nID;          //项目ID
        public string pwzText;   //项目标题
        public nint lParam;           //项目附加参数
        public UInt32 nImageIndex;       //收缩图片索引
        public UInt32 nImageIndexExpand; //扩展图片索引
        public bool fExpand;            //是否展开
        public UInt32 dwStyle;           //风格
    };

    /// <summary>
    /// 树形框插入项目信息结构
    /// </summary>
    public struct ExTreeViewInsertInfo
    {
        public nint itemParent;      // 父项句柄（0为根项）
        public nint itemInsertAfter; // 插入在此项之后（必须是同层）
        public int nID;                               // 项目ID
        public string pwzText;                       // 项目标题
        public nint lParam;                         // 项目附加参数
        public int nImageIndex;                       // 收缩图片索引
        public int nImageIndexExpand;                 // 展开图片索引
        public bool fExpand;                          // 是否展开
        public UInt32 dwStyle;                         // 风格
        public bool fUpdateLater;                     // 是否暂不更新(统一用TVM_UPDATE更新)
    };

    /// <summary>
    /// 图标列表框插入信息结构
    /// </summary>
    public struct ExIconListViewItemInfo
    {
        public UInt32 nIndex;      //插入位置
        public UInt32 nImageIndex; //图片索引
        public string pwzText;   //文本
    };

    /// <summary>
    /// 图像属性信息
    /// </summary>
    public struct ExImageInfo
    {
        public nint imgNormal;        //图像.正常
        public nint imgHover;         //图像.悬浮
        public nint imgDownOrChecked; //图像.按下或者选中
    };

    /// <summary>
    /// 拖曳信息结构
    /// </summary>
    public struct ExDropInfo
    {
        public nint pDataObject; //数据对象指针IDataObject*
        public UInt32 grfKeyState;  //功能键状态
        public int x;              //鼠标水平位置
        public int y;              //鼠标垂直位置
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
    public struct ExTextRange
    {
        public ExCharRange chrg;
        public nint pwzText;
    };

    /// <summary>
    /// 富文本框EN_SELCHANGE消息lParam参数结构
    /// </summary>
    public struct ExSelChange
    {
        public ExNotifyHeader nmhdr;
        public ExCharRange chrg;
        public ushort seltyp;
    };

    /// <summary>
    /// 富文本框EN_LINK消息lParam参数结构
    /// </summary>
    public struct ExEnLink
    {
        public NMHDR nmhdr;
        public int msg;
        public nint wParam;
        public nint lParam;
        public ExCharRange chrg;
    };

    /// <summary>
    /// 富文本框替换文本信息结构
    /// </summary>
    public struct ExSetTextEx
    {
        public UInt32 flags;
        public UInt32 codePage;
    };

    /// <summary>
    /// 列表按钮项目信息结构
    /// </summary>
    public struct ExListButtonItemInfo
    {
        public UInt32 dwMask;     // 1,图片 2,标题 4,提示文本 8,状态 16,菜单 32,文本格式 64,宽度
        public UInt32 nType;      //项目类型   0,分隔条 1,普通按钮 2,选择按钮
        public UInt32 nIndex;     //插入索引
        public UInt32 nImage;     //图片索引
        public string wzText;  //项目标题
        public string wzTips;  //项目提示文本
        public UInt32 nLeft;      //项目左边
        public UInt32 nWidth;     //项目宽度
        public UInt32 dwState;    //项目状态   可取STATE_NORMAL,STATE_DOWN,STATE_FOCUS,STATE_DISABLE
        public nint nMenu;      //项目菜单
        public int TextFormat; //项目文本格式
    };

    /// <summary>
    /// 日期框信息结构
    /// </summary>
    public struct ExDateTimeInfo
    {
        public int Year;               //年
        public int Mon;                //月   1-12
        public int Mday;               //日   1-31
        public int Wday;				//星期 1-7 7=星期日
    };


        public class ExAPI
    {

        /** <summary>
         * 初始化引擎.
         * </summary>
         * <param name="hInstance">(值可为0)</param>
         * <param name="dwGlobalFlags">相关常量:#EXGF_ .(值可为0)</param>
         * <param name="hDefaultCursor">默认鼠标指针.(值可为0)</param>
         * <param name="lpszDefaultClassName">默认窗口类名.(值可为0)</param>
         * <param name="lpDefaultTheme">默认主题包指针.</param>
         * <param name="dwDefaultThemeLen">默认主题包长度.</param>
         * <param name="lpDefaultI18N">默认语言包指针.(值可为0)</param>
         * <param name="dwDefaultI18NLen">默认语言包长度.(值可为0)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Init")]
        public static extern bool Ex_Init(nint hInstance, int dwGlobalFlags, nint hDefaultCursor,
            string lpszDefaultClassName, byte[] lpDefaultTheme, nint dwDefaultThemeLen, byte[] lpDefaultI18N, nint dwDefaultI18NLen);

        /** <summary>
         * 反初始化引擎
         * </summary>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_UnInit")]
        public static extern void Ex_UnInit();

        /** <summary>
         * 获取最后错误代码.相关常量 :#ERROR_EX_
         * </summary>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_GetLastError")]
        public static extern int Ex_GetLastError();

        /** <summary>
         * 创建自内存。成功返回0。
         * </summary>
         * <param name="lpData">图像指针</param>
         * <param name="dwLen">图像长度</param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfrommemory")]
        public static extern bool _img_createfrommemory(byte[] lpData, long dwLen, out int hImg);

        /** <summary>
         * 创建图像。成功返回0。
         * </summary>
         * <param name="width">图像宽度</param>
         * <param name="height">图像高度</param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_create")]
        public static extern bool _img_create(int width, int height, out int hImg);

        /** <summary>
         * 锁定图像.成功返回0.
         * </summary>
         * <param name="hImg"></param>
         * <param name="lpRectL">锁定矩形指针，如果为0，则锁定整张图像。</param>
         * <param name="flags">READ:1 / WRITE:2 / READ&WRITE:3</param>
         * <param name="PixelFormat">参考:https://msdn.microsoft.com/en-us/library/ms534412(v=vs.85).aspx</param>
         * <param name="lpLockedBitmapData">BITMAPDATA</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_lock")]
        public static extern bool _img_lock(int hImg, ExRect lpRectL, int flags, int PixelFormat, ref ExBitmapData lpLockedBitmapData);

        /** <summary>
         * 解锁图像.成功返回0.
         * </summary>
         * <param name="hImg"></param>
         * <param name="lpLockedBitmapData"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_unlock")]
        public static extern bool _img_unlock(int hImg, ref ExBitmapData lpLockedBitmapData);

        /** <summary>
         * 销毁图像
         * </summary>
         * <param name="hImg"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_destroy")]
        public static extern bool _img_destroy(int hImg);

        /** <summary>
         * 设置最后错误代码.相关常量 :#ERROR_EX_
         * </summary>
         * <param name="nError"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_SetLastError")]
        public static extern void Ex_SetLastError(int nError);

        /** <summary>
         * 取图像帧数。成功返回0。
         * </summary>
         * <param name="hImg"></param>
         * <param name="nFrameCount">返回帧数.</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getframecount")]
        public static extern bool _img_getframecount(int hImg, out int nFrameCount);

        /** <summary>
         * 设置当前活动帧。成功返回0。
         * </summary>
         * <param name="hImg"></param>
         * <param name="nIndex"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_selectactiveframe")]
        public static extern bool _img_selectactiveframe(int hImg, int nIndex);

        /** <summary>
         * 创建自字节流。成功返回0。
         * </summary>
         * <param name="lpStream"></param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromstream")]
        public static extern bool _img_createfromstream(IStream lpStream, out int hImg);

        /** <summary>
         * (拷贝)创建自画布。成功返回0。
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromcanvas")]
        public static extern int _img_createfromcanvas(int hCanvas, out int hImg);

        /** <summary>
         * 取图像帧延时。成功返回0。
         * </summary>
         * <param name="hImg"></param>
         * <param name="lpDelayAry">指针指向图像帧延时数组。</param>
         * <param name="nFrames">返回总帧数</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getframedelay")]
        public static extern bool _img_getframedelay(int hImg, int[] lpDelayAry, out int nFrames);

        /** <summary>
         * 获取图像尺寸.成功返回0
         * </summary>
         * <param name="hImg"></param>
         * <param name="lpWidth"></param>
         * <param name="lpHeight"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getsize")]
        public static extern bool _img_getsize(int hImg, out int lpWidth, out int lpHeight);

        /** <summary>
         * 是否使用D2D渲染
         * </summary>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_IsDxRender")]
        public static extern bool Ex_IsDxRender();

        /// <summary>
        /// 加载位图对象自内存
        /// </summary>
        /// <param name="lpData">图像数据指针</param>
        /// <param name="dwLen">图像数据长度</param>
        /// <param name="retBitMap">返回位图句柄</param>
        /// <returns></returns>
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_LoadBitMapFromMemory")]
        public static extern bool Ex_LoadBitMapFromMemory(byte[] lpData, int dwLen, out nint retBitMap);

        /** <summary>
         * 返回宽度
         * </summary>
         * <param name="hImg"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_width")]
        public static extern int _img_width(int hImg);

        /** <summary>
         * 返回高度
         * </summary>
         * <param name="hImg"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_height")]
        public static extern int _img_height(int hImg);

        /** <summary>
         * 复制图像.成功返回0
         * </summary>
         * <param name="hImg"></param>
         * <param name="dstImg">返回新图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_copy")]
        public static extern bool _img_copy(int hImg, out int dstImg);

        /** <summary>
         * 复制部分图像.成功返回0
         * </summary>
         * <param name="hImg"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         * <param name="dstImg">返回新图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_copyrect")]
        public static extern bool _img_copyrect(int hImg, int x, int y, int width, int height, out int dstImg);

        /** <summary>
         * 创建自GDI位图句柄。成功返回0。
         * </summary>
         * <param name="hBitmap"></param>
         * <param name="hPalette"></param>
         * <param name="fPreAlpha">是否预乘透明通道</param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromhbitmap")]
        public static extern bool _img_createfromhbitmap(nint hBitmap, nint hPalette, bool fPreAlpha, out int hImg);

        /** <summary>
         * 创建自图标句柄。成功返回0。
         * </summary>
         * <param name="hIcon"></param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromhicon")]
        public static extern bool _img_createfromhicon(nint hIcon, out int hImg);

        /** <summary>
         * 创建自文件。成功返回0。
         * </summary>
         * <param name="wzFilename"></param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromfile")]
        public static extern bool _img_createfromfile(string wzFilename, out int hImg);

        /** <summary>
         * 获取点像素
         * </summary>
         * <param name="hImg"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="color">返回ARGB颜色</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getpixel")]
        public static extern bool _img_getpixel(int hImg, int x, int y, out int color);

        /** <summary>
         * 设置点像素.成功返回0
         * </summary>
         * <param name="hImg"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="color">argb</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_setpixel")]
        public static extern bool _img_setpixel(int hImg, int x, int y, int color);

        /** <summary>
         * 旋转翻转图像.成功返回0
         * </summary>
         * <param name="hImg"></param>
         * <param name="rfType">参考:https://msdn.microsoft.com/en-us/library/windows/desktop/ms534171(v=vs.85).aspx</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_rotateflip")]
        public static extern bool _img_rotateflip(int hImg, int rfType, out int phImg);

        /** <summary>
         * 取缩略图.成功返回0
         * </summary>
         * <param name="hImg"></param>
         * <param name="thumbWidth"></param>
         * <param name="thumbHeight"></param>
         * <param name="hImgThumbnail">返回缩略图图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_getthumbnail")]
        public static extern int _img_getthumbnail(int hImg, int thumbWidth, int thumbHeight, out int hImgThumbnail);

        /** <summary>
         * 重新设置尺寸。
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         * <param name="fCopy"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_resize")]
        public static extern bool _canvas_resize(int hCanvas, int width, int height);

        /** <summary>
         * 获取canvas上下文相关信息
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="nType">#CVC_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_getcontext")]
        public static extern nint _canvas_getcontext(int hCanvas, int nType);

        /** <summary>
         * 绑定窗口
         * </summary>
         * <param name="hWnd">窗口句柄</param>
         * <param name="hTheme">主题句柄.(值可为0)</param>
         * <param name="dwStyle">相关常量:#EWS_</param>
         * <param name="lParam">附加参数.(值可为0)</param>
         * <param name="lpfnMsgProc">(BOOL)MsgProc(hWnd</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIBindWindowEx")]
        public static extern int Ex_DUIBindWindowEx(nint hWnd, int hTheme, int dwStyle, nint lParam, ExWndProcDelegate lpfnMsgProc);

        /** <summary>
         * 创建画布自组件句柄。成功返回画布句柄，失败返回0
         * </summary>
         * <param name="hObj"></param>
         * <param name="uWidth"></param>
         * <param name="uHeight"></param>
         * <param name="dwFlags">CVF_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_createfromobj")]
        public static extern int _canvas_createfromobj(int hObj, int uWidth, int uHeight, int dwFlags);

        /** <summary>
         * 注册窗口类
         * </summary>
         * <param name="lpwzClassName"></param>
         * <param name="hIcon"></param>
         * <param name="hIconsm"></param>
         * <param name="hCursor"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndRegisterClass")]
        public static extern ushort Ex_WndRegisterClass(string lpwzClassName, nint hIcon, nint hIconsm, nint hCursor);

        /** <summary>
         * 创建窗口
         * </summary>
         * <param name="hWndParent"></param>
         * <param name="lpwzClassName"></param>
         * <param name="lpwzWindowName"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="Width"></param>
         * <param name="Height"></param>
         * <param name="dwStyle"></param>
         * <param name="dwStyleEx"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndCreate")]
        public static extern nint Ex_WndCreate(nint hWndParent, string lpwzClassName, string lpwzWindowName, int x, int y, int Width, int Height, int dwStyle, int dwStyleEx);

        /** <summary>
         * 窗口消息循环
         * </summary>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndMsgLoop")]
        public static extern nint Ex_WndMsgLoop();

        /** <summary>
         * 窗口居中
         * </summary>
         * <param name="hWnd">预居中的原始窗口</param>
         * <param name="hWndFrom">预居中的目标窗口</param>
         * <param name="bFullScreen">是否全屏模式</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_WndCenterFrom")]
        public static extern void Ex_WndCenterFrom(nint hWnd, nint hWndFrom, bool bFullScreen);

        /** <summary>
         * 显示窗口
         * </summary>
         * <param name="hExDui">引擎句柄</param>
         * <param name="nCmdShow">相关常量:#SW_</param>
         * <param name="dwTimer">动画时间间隔.(ms)</param>
         * <param name="dwFrames">动画总帧数.</param>
         * <param name="dwFlags">动画标记.#EXA_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIShowWindow")]
        public static extern bool Ex_DUIShowWindow(int hExDui, int nCmdShow, int dwTimer, int dwFrames, int dwFlags);

        /** <summary>
         * 显示窗口
         * </summary>
         * <param name="hExDui">引擎句柄</param>
         * <param name="nCmdShow">相关常量:#SW_</param>
         * <param name="dwTimer">动画时间间隔.(ms)</param>
         * <param name="dwFrames">动画总帧数.</param>
         * <param name="dwFlags">动画标记.#EXA_</param>
         * <param name="uEasing">#缓动类型_</param>
         * <param name="wParam">参数1</param>
         * <param name="lParam">参数2</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIShowWindowEx")]
        public static extern bool Ex_DUIShowWindowEx(int hExDui, int nCmdShow, int dwTimer, int dwFrames, int dwFlags, int uEasing, nint wParam, nint lParam);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_destroy")]
        public static extern bool _canvas_destroy(int hCanvas);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_enddraw")]
        public static extern bool _canvas_enddraw(int hCanvas);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="lColor"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_clear")]
        public static extern bool _canvas_clear(int hCanvas, int nColor);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_getdc")]
        public static extern nint _canvas_getdc(int hCanvas);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_releasedc")]
        public static extern bool _canvas_releasedc(int hCanvas);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas">0</param>
         * <param name="hImage">4</param>
         * <param name="left">8</param>
         * <param name="top">12</param>
         * <param name="alpha">16</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimage")]
        public static extern bool _canvas_drawimage(int hCanvas, int hImage, float left, float top, int alpha);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hImage"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="alpha"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimagerect")]
        public static extern bool _canvas_drawimagerect(int hCanvas, int hImage, float left, float top, float right, float bottom, int alpha);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas">0</param>
         * <param name="hImage">4</param>
         * <param name="dstLeft">8</param>
         * <param name="dstTop">12</param>
         * <param name="dstRight">16</param>
         * <param name="dstBottom">20</param>
         * <param name="srcLeft">24</param>
         * <param name="srcTop">28</param>
         * <param name="srcRight">32</param>
         * <param name="srcBottom">36</param>
         * <param name="alpha">40</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimagerectrect")]
        public static extern bool _canvas_drawimagerectrect(int hCanvas, int hImage, float dstLeft, float dstTop, float dstRight, float dstBottom, float srcLeft, float srcTop, float srcRight, float srcBottom, int alpha);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hImage"></param>
         * <param name="dstLeft"></param>
         * <param name="dstTop"></param>
         * <param name="dstRight"></param>
         * <param name="dstBottom"></param>
         * <param name="srcLeft"></param>
         * <param name="srcTop"></param>
         * <param name="srcRight"></param>
         * <param name="srcBottom"></param>
         * <param name="gridPaddingLeft"></param>
         * <param name="gridPaddingTop"></param>
         * <param name="gridPaddingRight"></param>
         * <param name="gridPaddingBottom"></param>
         * <param name="dwFlags">#bif_</param>
         * <param name="dwAlpha"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawimagefromgrid")]
        public static extern bool _canvas_drawimagefromgrid(int hCanvas, int hImage, float dstLeft, float dstTop, float dstRight, float dstBottom, float srcLeft, float srcTop, float srcRight, float srcBottom, float gridPaddingLeft, float gridPaddingTop, float gridPaddingRight, float gridPaddingBottom, int dwFlags, int dwAlpha);

        /** <summary>
         * 组件默认过程
         * </summary>
         * <param name="hWnd"></param>
         * <param name="hObj"></param>
         * <param name="uMsg"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDefProc")]
        public static extern nint Ex_ObjDefProc(nint hWnd, int hObj, int uMsg, nint wParam, nint lParam);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillrect")]
        public static extern bool _canvas_fillrect(int hCanvas, nint hBrush, float left, float top, float right, float bottom);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="radiuX"></param>
         * <param name="radiuY"></param>
         * <param name="shadowNum"></param>
         * <param name="number"></param>
         * <param name="crShadow"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillroundedimage")]
        public static extern bool _canvas_fillroundedimage(int hCanvas, nint hBrush, float left, float top, float right, float bottom, float radiuX, float radiuY, nint shadowNum, int number, int crShadow);

        /** <summary>
         * 
         * </summary>
         * <param name="argb"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_create")]
        public static extern nint _brush_create(int argb);

        /** <summary>
         * 
         * </summary>
         * <param name="xs"></param>
         * <param name="ys"></param>
         * <param name="xe"></param>
         * <param name="ye"></param>
         * <param name="crBegin"></param>
         * <param name="crEnd"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createlinear")]
        public static extern int _brush_createlinear(float xs, float ys, float xe, float ye, int crBegin, int crEnd);

        /** <summary>
         * 
         * </summary>
         * <param name="xs"></param>
         * <param name="ys"></param>
         * <param name="xe"></param>
         * <param name="ye"></param
         * <param name="arrStopPts"></param>
         * <param name="cStopPts"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createlinear_ex")]
        public static extern int _brush_createlinear_ex(float xs, float ys, float xe, float ye, nint arrStopPts, int cStopPts);

        /** <summary>
         * 
         * </summary>
         * <param name="hBrush"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_destroy")]
        public static extern int _brush_destroy(nint hBrush);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="strokeWidth"></param>
         * <param name="strokeStyle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawrect")]
        public static extern bool _canvas_drawrect(int hCanvas, nint hBrush, float left, float top, float right, float bottom, float strokeWidth, int strokeStyle);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="radiusX"></param>
         * <param name="radiusY"></param>
         * <param name="strokeWidth"></param>
         * <param name="strokeStyle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawroundedrect")]
        public static extern bool _canvas_drawroundedrect(int hCanvas, nint hBrush, float left, float top, float right, float bottom, float radiusX, float radiusY, float strokeWidth, int strokeStyle);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="radiusX"></param>
         * <param name="radiusY"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillroundedrect")]
        public static extern bool _canvas_fillroundedrect(int hCanvas, nint hBrush, float left, float top, float right, float bottom, float radiusX, float radiusY);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="radiusX"></param>
         * <param name="radiusY"></param>
         * <param name="strokeWidth"></param>
         * <param name="strokeStyle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawellipse")]
        public static extern bool _canvas_drawellipse(int hCanvas, nint hBrush, float x, float y, float radiusX, float radiusY, float strokeWidth, int strokeStyle);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="radiusX"></param>
         * <param name="radiusY"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillellipse")]
        public static extern bool _canvas_fillellipse(int hCanvas, nint hBrush, float x, float y, float radiusX, float radiusY);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hBrush"></param>
         * <param name="X1"></param>
         * <param name="Y1"></param>
         * <param name="X2"></param>
         * <param name="Y2"></param>
         * <param name="strokeWidth"></param>
         * <param name="strokeStyle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawline")]
        public static extern bool _canvas_drawline(int hCanvas, nint hBrush, float X1, float Y1, float X2, float Y2, float strokeWidth, int strokeStyle);

        /** <summary>
         * 注册组件.失败返回0
         * </summary>
         * <param name="lptszClassName">组件类名.最大允许长度:MAX_CLASS_NAME_LEN</param>
         * <param name="dwStyle">组件默认风格</param>
         * <param name="dwStyleEx">组件默认扩展风格</param>
         * <param name="dwTextFormat">相关常量 DT_</param>
         * <param name="cbObjExtra">组件额外分配字节数(值可为0)</param>
         * <param name="hCursor">组件默认鼠标指针句柄(值可为0)</param>
         * <param name="dwFlags">类标志 #ECF_(值可为0)</param>
         * <param name="pfnObjProc">组件默认回调</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjRegister")]
        public static extern int Ex_ObjRegister(string lptszClassName, int dwStyle, int dwStyleEx, int dwTextFormat, int cbObjExtra, nint hCursor, int dwFlags, ExObjClassProcDelegate pfnObjProc);

        /** <summary>
         * 创建组件.
         * </summary>
         * <param name="lptszClassName">组件类名</param>
         * <param name="lptszObjTitle">组件标题</param>
         * <param name="dwStyle">组件风格 相关常量 EOS_</param>
         * <param name="x">左边</param>
         * <param name="y">顶边</param>
         * <param name="width">宽度</param>
         * <param name="height">高度</param>
         * <param name="hParent">父组件句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCreate")]
        public static extern nint Ex_ObjCreate(string lptszClassName, string lptszObjTitle, int dwStyle, int x, int y, int width, int height, nint hParent);

        /** <summary>
         * 创建组件.
         * </summary>
         * <param name="dwStyleEx">组件扩展风格 相关常量 EOS_EX_</param>
         * <param name="lptszClassName">组件类名</param>
         * <param name="lptszObjTitle">组件标题</param>
         * <param name="dwStyle">组件风格 相关常量 EOS_</param>
         * <param name="x">左边</param>
         * <param name="y">顶边</param>
         * <param name="width">宽度</param>
         * <param name="height">高度</param>
         * <param name="hParent">父组件句柄</param>
         * <param name="nID"></param>
         * <param name="dwTextFormat">相关常量 DT_</param>
         * <param name="lParam">附加参数</param>
         * <param name="hTheme">主题句柄.0为默认</param>
         * <param name="lpfnMsgProc">(BOOL)MsgProc(hWnd</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCreateEx")]
        public static extern int Ex_ObjCreateEx(int dwStyleEx, string lptszClassName, string lptszObjTitle, int dwStyle, int x, int y, int width, int height, int hParent, int nID, int dwTextFormat, nint lParam, int hTheme, ExObjProcDelegate lpfnMsgProc);

        /** <summary>
         * 取DPI缩放值
         * </summary>
         * <param name="n"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Scale")]
        public static extern float Ex_Scale(float n);

        /** <summary>
         * 
         * </summary>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_createfromrect")]
        public static extern nint _rgn_createfromrect(float left, float top, float right, float bottom);

        /** <summary>
         * 
         * </summary>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="radiusX"></param>
         * <param name="radiusY"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_createfromroundrect")]
        public static extern nint _rgn_createfromroundrect(float left, float top, float right, float bottom, float radiusX, float radiusY);

        /** <summary>
         * 
         * </summary>
         * <param name="hRgn"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_destroy")]
        public static extern bool _rgn_destroy(nint hRgn);

        /** <summary>
         * 
         * </summary>
         * <param name="hRgnSrc"></param>
         * <param name="hRgnDst"></param>
         * <param name="nCombineMode">#RGN_COMBINE_</param>
         * <param name="dstOffsetX"></param>
         * <param name="dstOffsetY"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_combine")]
        public static extern nint _rgn_combine(nint hRgnSrc, nint hRgnDst, int nCombineMode, int dstOffsetX, int dstOffsetY);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hRgn"></param>
         * <param name="hBrush"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillregion")]
        public static extern bool _canvas_fillregion(int hCanvas, nint hRgn, nint hBrush);

        /** <summary>
         * 
         * </summary>
         * <param name="hRgn"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_hittest")]
        public static extern bool _rgn_hittest(nint hRgn, float x, float y);

        /** <summary>
         * 销毁组件
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDestroy")]
        public static extern bool Ex_ObjDestroy(int hObj);

        /** <summary>
         * 发送消息
         * </summary>
         * <param name="hObj"></param>
         * <param name="uMsg"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSendMessage")]
        public static extern nint Ex_ObjSendMessage(int hObj, int uMsg, nint wParam, nint lParam);

        /** <summary>
         * 开始绘制
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpPS"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjBeginPaint")]
        public static extern bool Ex_ObjBeginPaint(int hObj, out ExPaintStruct lpPS);

        /** <summary>
         * 结束绘制
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpPS"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEndPaint")]
        public static extern bool Ex_ObjEndPaint(int hObj, ref ExPaintStruct lpPS);

        /** <summary>
         * 获取组件矩形
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpRect"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetRect")]
        public static extern bool Ex_ObjGetRect(int hObj, out ExRect lpRect);

        /** <summary>
         * 客户区坐标到窗口坐标
         * </summary>
         * <param name="hObj"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjClientToWindow")]
        public static extern bool Ex_ObjClientToWindow(int hObj, ref int x, ref int y);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_cliprect")]
        public static extern bool _canvas_cliprect(int hCanvas, int left, int top, int right, int bottom);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_resetclip")]
        public static extern bool _canvas_resetclip(int hCanvas);

        /** <summary>
         * 客户区坐标到屏幕坐标
         * </summary>
         * <param name="hObj"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjClientToScreen")]
        public static extern bool Ex_ObjClientToScreen(int hObj, ref int x, ref int y);

        /** <summary>
         * 设置重画区域
         * </summary>
         * <param name="hObj"></param>
         * <param name="lprcRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjInvalidateRect")]
        public static extern bool Ex_ObjInvalidateRect(int hObj, ref ExRect lprcRedraw);

        /** <summary>
         * 设置重画区域
         * </summary>
         * <param name="hObj"></param>
         * <param name="lprcRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjInvalidateRect")]
        public static extern bool Ex_ObjInvalidateRect(int hObj, nint rcRedraw);

        /** <summary>
         * 立即更新组件
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjUpdate")]
        public static extern bool Ex_ObjUpdate(int hObj);

        /** <summary>
         * 获取组件客户区矩形
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpRect"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetClientRect")]
        public static extern bool Ex_ObjGetClientRect(int hObj, out ExRect lpRect);

        /** <summary>
         * 设置组件可用状态.
         * </summary>
         * <param name="hObj">组件句柄</param>
         * <param name="fEnable">是否可用</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnable")]
        public static extern bool Ex_ObjEnable(int hObj, bool fEnable);

        /** <summary>
         * 组件是否可用
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjIsEnable")]
        public static extern bool Ex_ObjIsEnable(int hObj);

        /** <summary>
         * 判断组件是否可视.
         * </summary>
         * <param name="hObj">组件句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjIsVisible")]
        public static extern bool Ex_ObjIsVisible(int hObj);

        /** <summary>
         * 设置组件可视状态
         * </summary>
         * <param name="hObj"></param>
         * <param name="fShow"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjShow")]
        public static extern bool Ex_ObjShow(int hObj, bool fShow);

        /** <summary>
         * 获取组件数值
         * </summary>
         * <param name="hObj"></param>
         * <param name="nIndex">相关常量 #EOL_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetLong")]
        public static extern nint Ex_ObjGetLong(int hObj, int nIndex);

        /** <summary>
         * 获取父组件
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetParent")]
        public static extern nint Ex_ObjGetParent(int hObj);

        /** <summary>
         * 设置组件数值
         * </summary>
         * <param name="hObj"></param>
         * <param name="nIndex">#EOL_</param>
         * <param name="dwNewLong"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetLong")]
        public static extern nint Ex_ObjSetLong(int hObj, int nIndex, nint dwNewLong);

        /** <summary>
         * 设置组件数值(子类化专用)
         * </summary>
         * <param name="hObj"></param>
         * <param name="nIndex">#EOL_</param>
         * <param name="dwNewLong"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetLong")]
        public static extern nint Ex_ObjSetLong(int hObj, int nIndex, Delegate dwNewLong);

        /** <summary>
         * 设置组件位置
         * </summary>
         * <param name="hObj"></param>
         * <param name="hObjInsertAfter"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         * <param name="flags">相关常量 #SWP_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetPos")]
        public static extern bool Ex_ObjSetPos(int hObj, nint hObjInsertAfter, int x, int y, int width, int height, int flags);

        /** <summary>
         * 是否有效的组件
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjIsValidate")]
        public static extern bool Ex_ObjIsValidate(int hObj);

        /** <summary>
         * 枚举子组件.
         * </summary>
         * <param name="hObjParent">父组件的句柄。从根部枚举则为引擎句柄。</param>
         * <param name="lpEnumFunc">callback(hObj</param>
         * <param name="lParam">附带参数</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnumChild")]
        public static extern bool Ex_ObjEnumChild(int hObjParent, ExObjEnumCallbackDelegate lpEnumFunc, nint lParam);

        /** <summary>
         * 获取组件文本.返回值:已拷贝字符长度.
         * </summary>
         * <param name="hObj">组件句柄.</param>
         * <param name="lpString">缓冲区指针.</param>
         * <param name="nMaxCount">缓冲区长度.</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetText")]
        public static extern nint Ex_ObjGetText(int hObj, StringBuilder lpString, nint nMaxCount);

        /** <summary>
         * 获取组件文本长度
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetTextLength")]
        public static extern nint Ex_ObjGetTextLength(int hObj);

        /** <summary>
         * 设置组件文本.
         * </summary>
         * <param name="hObj">组件句柄.</param>
         * <param name="lpString">指向一个空结束的字符串的指针.</param>
         * <param name="fRedraw">是否重画组件</param>
         **/
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

        /** <summary>
         * 弹出或关闭提示文本
         * </summary>
         * <param name="hObj">组件句柄.</param>
         * <param name="lpString">提示文本.该值为0则关闭提示文本</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjTooltipsPop")]
        public static extern bool Ex_ObjTooltipsPop(int hObj, string lpString);

        /** <summary>
         * 弹出或关闭提示文本Ex
         * </summary>
         * <param name="hObj">组件句柄.</param>
         * <param name="lpTitle">标题内容</param>
         * <param name="lpText">提示文本.</param>
         * <param name="x">屏幕坐标.(-1:默认)</param>
         * <param name="y">屏幕坐标.(-1:默认)</param>
         * <param name="dwTime">单位:毫秒.(-1:默认</param>
         * <param name="nIcon">#气泡图标_</param>
         * <param name="fShow">是否立即显示</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjTooltipsPopEx")]
        public static extern bool Ex_ObjTooltipsPopEx(int hObj, string lpTitle, string lpText, int x, int y, int dwTime, int nIcon, bool fShow);

        /** <summary>
         * 获取鼠标所在窗口组件句柄
         * </summary>
         * <param name="handle">0[坐标所在窗口]/窗口句柄/引擎句柄/组件句柄</param>
         * <param name="x">handle:0相对屏幕/其他相对窗口</param>
         * <param name="y"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIGetObjFromPoint")]
        public static extern int Ex_DUIGetObjFromPoint(int handle, int x, int y);

        /** <summary>
         * 设置组件焦点
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetFocus")]
        public static extern bool Ex_ObjSetFocus(int hObj);

        /** <summary>
         * 销毁组件焦点
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjKillFocus")]
        public static extern bool Ex_ObjKillFocus(int hObj);

        /** <summary>
         * 获取属性
         * </summary>
         * <param name="hObj"></param>
         * <param name="dwKey"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetProp")]
        public static extern nint Ex_ObjGetProp(int hObj, nint dwKey);

        /** <summary>
         * 设置组件属性条目
         * </summary>
         * <param name="hObj"></param>
         * <param name="dwKey"></param>
         * <param name="dwValue"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetProp")]
        public static extern nint Ex_ObjSetProp(int hObj, nint dwKey, nint dwValue);

        /** <summary>
         * 移动组件
         * </summary>
         * <param name="hObj"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         * <param name="bRepaint"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjMove")]
        public static extern bool Ex_ObjMove(int hObj, int x, int y, int width, int height, bool bRepaint);

        /** <summary>
         * 返回与指定组件有特定关系（如Z序或所有者）的组件句柄。
         * </summary>
         * <param name="hObj"></param>
         * <param name="nCmd">相关常量 #GW_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetObj")]
        public static extern int Ex_ObjGetObj(int hObj, int nCmd);

        /** <summary>
         * 查找组件.
         * </summary>
         * <param name="hObjParent">父组件句柄。从根部查找则为引擎句柄。</param>
         * <param name="hObjChildAfter">由此组件开始查找（不包含该组件）。如果为0，则从第一个组件开始查找。</param>
         * <param name="lpClassName">欲查找的组件类名指针/Ex_ATOM()</param>
         * <param name="lpTitle">欲查找的组件标题</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjFind")]
        public static extern int Ex_ObjFind(int hObjParent, int hObjChildAfter, string lpClassName, string lpTitle);

        /** <summary>
         * 设置组件是否可以重画.如果组件扩展风格存在EOS_EX_COMPOSITED
         * </summary>
         * <param name="hObj">组件句柄</param>
         * <param name="fCanbeRedraw">是否可重画</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetRedraw")]
        public static extern bool Ex_ObjSetRedraw(int hObj, bool fCanbeRedraw);

        /** <summary>
         * 加载主题包
         * </summary>
         * <param name="lptszFile"></param>
         * <param name="lpKey"></param>
         * <param name="dwKeyLen"></param>
         * <param name="bDefault"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeLoadFromFile")]
        public static extern int Ex_ThemeLoadFromFile(string lptszFile, byte[] lpKey, nint dwKeyLen, bool bDefault);

        /** <summary>
         * 加载主题包
         * </summary>
         * <param name="lpData"></param>
         * <param name="dwDataLen"></param>
         * <param name="lpKey"></param>
         * <param name="dwKeyLen"></param>
         * <param name="bDefault"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeLoadFromMemory")]
        public static extern int Ex_ThemeLoadFromMemory(byte[] lpData, nint dwDataLen, byte[] lpKey, nint dwKeyLen, bool bDefault);

        /** <summary>
         * 释放主题
         * </summary>
         * <param name="hTheme"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeFree")]
        public static extern bool Ex_ThemeFree(int hTheme);

        /** <summary>
         * 获取字符串唯一原子号
         * </summary>
         * <param name="lptstring"></param>
         **/
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
        public static extern bool Ex_ObjCefBrowserInitialize(string hModule, string libPath, string dllName, string cachePath, string userAgent, int debuggingPort, ExCefBeforeCommandLineCallbackDelegate lpBeforeCommandLine);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_getsize")]
        public static extern bool _canvas_getsize(int hCanvas, out int width, out int height);

        /** <summary>
         * 获取组件属性值指针.
         * </summary>
         * <param name="hTheme">主题句柄</param>
         * <param name="atomClass"></param>
         * <param name="atomProp"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeGetValuePtr")]
        public static extern nint Ex_ThemeGetValuePtr(int hTheme, int atomClass, int atomProp);

        /** <summary>
         * 设置引擎数值
         * </summary>
         * <param name="hExDui"></param>
         * <param name="nIndex">#EWL_</param>
         * <param name="dwNewlong"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUISetLong")]
        public static extern nint Ex_DUISetLong(int hExDui, int nIndex, nint dwNewlong);

        /** <summary>
         * 获取引擎数值
         * </summary>
         * <param name="hExDui">引擎句柄</param>
         * <param name="nIndex">相关常量: EWL_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIGetLong")]
        public static extern nint Ex_DUIGetLong(int hExDui, int nIndex);

        /** <summary>
         * 创建默认字体
         * </summary>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_create")]
        public static extern int _font_create();

        /** <summary>
         * 
         * </summary>
         * <param name="lpwzFontFace"></param>
         * <param name="dwFontSize"></param>
         * <param name="dwFontStyle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_createfromfamily")]
        public static extern int _font_createfromfamily(string lpwzFontFace, int dwFontSize, int dwFontStyle);

        /** <summary>
         * 
         * </summary>
         * <param name="lpLogfont"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_createfromlogfont")]
        public static extern int _font_createfromlogfont(ref LogFont lpLogfont);

        /** <summary>
         * 获取逻辑字体
         * </summary>
         * <param name="hFont"></param>
         * <param name="lpLogFont"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_getlogfont")]
        public static extern bool _font_getlogfont(int hFont, ref LogFont lpLogFont);

        /** <summary>
         * 创建自布局
         * </summary>
         * <param name="hParent">父窗口句柄</param>
         * <param name="hTheme">主题句柄</param>
         * <param name="lpLayout">布局资源数据指针</param>
         * <param name="cbLayout">布局资源数据长度</param>
         * <param name="hWnd">(out)返回窗口句柄</param>
         * <param name="hExDui">(out)返回引擎句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUICreateFromLayout")]
        public static extern bool Ex_DUICreateFromLayout(nint hParent, int hTheme, byte[] lpLayout, int cbLayout, out nint hWnd, out int hExDui);

        /** <summary>
         * 创建自资源包句柄
         * </summary>
         * <param name="hParent">父窗口句柄</param>
         * <param name="hTheme">主题句柄</param>
         * <param name="hRes">资源句柄</param>
         * <param name="atomLayout">布局文件名原子号</param>
         * <param name="hWnd">(out)返回窗口句柄</param>
         * <param name="hExDui">(out)返回引擎句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUICreateFromHRes")]
        public static extern bool Ex_DUICreateFromHRes(nint hParent, int hTheme, nint hRes, int atomLayout, out nint hWnd, out int hExDui);

        /** <summary>
         * 注册XML键值回调
         * </summary>
         * <param name="atomValue"></param>
         * <param name="pfnCallback"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_XmlRegisterCallback")]
        public static extern void Ex_XmlRegisterCallback(int atomValue, nint pfnCallback);

        /** <summary>
         * 获取客户区矩形
         * </summary>
         * <param name="hExDui">引擎句柄</param>
         * <param name="lpClientRect">矩形指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIGetClientRect")]
        public static extern bool Ex_DUIGetClientRect(int hExDui, out ExRect lpClientRect);

        /** <summary>
         * 投递消息
         * </summary>
         * <param name="hObj"></param>
         * <param name="uMsg"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjPostMessage")]
        public static extern bool Ex_ObjPostMessage(int hObj, int uMsg, nint wParam, nint lParam);

        /** <summary>
         * 设置组件背景信息
         * </summary>
         * <param name="handle">引擎句柄/组件句柄</param>
         * <param name="lpImage">图片指针</param>
         * <param name="dwImageLen">图片长度 (为0时也可销毁背景图)</param>
         * <param name="X">偏移X</param>
         * <param name="Y">偏移Y</param>
         * <param name="dwRepeat">相关常量 BIR_</param>
         * <param name="lpGird">九宫矩形指针 (值可为0)</param>
         * <param name="dwFlags">相关常量 BIF_</param>
         * <param name="dwAlpha">透明度(0-255)</param>
         * <param name="fUpdate">是否立即刷新</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetBackgroundImage")]
        public static extern bool Ex_ObjSetBackgroundImage(int handle, byte[] lpImage, int dwImageLen, int X, int Y, int dwRepeat, nint pRcGrids, int dwFlags, int dwAlpha, bool fUpdate);

        /** <summary>
         * 获取组件背景信息
         * </summary>
         * <param name="handle"></param>
         * <param name="lpBackgroundImage">相关结构 EX_BACKGROUNDIMAGEINFO</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetBackgroundImage")]
        public static extern bool Ex_ObjGetBackgroundImage(int handle, out ExBackgroundImageInfo lpBackgroundImage);

        /** <summary>
         * 设置组件背景图片播放状态.
         * </summary>
         * <param name="handle">引擎句柄/组件句柄</param>
         * <param name="fPlayFrames">是否播放.</param>
         * <param name="fResetFrame">是否重置当前帧为首帧.</param>
         * <param name="fUpdate">是否更新背景.</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetBackgroundPlayState")]
        public static extern bool Ex_ObjSetBackgroundPlayState(int handle, bool fPlayFrames, bool fResetFrame, bool fUpdate);

        /** <summary>
         * 设置组件模糊度
         * </summary>
         * <param name="hObj">组件句柄</param>
         * <param name="fDeviation">模糊度</param>
         * <param name="fUpdate">是否更新背景.</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetBlur")]
        public static extern bool Ex_ObjSetBlur(int hObj, float fDeviation, bool fUpdate);

        /** <summary>
         * 无
         * </summary>
         * <param name="handle">引擎句柄/组件句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDestroyBackground")]
        public static extern int Ex_ObjDestroyBackground(int handle);


        /** <summary>
         * 模糊
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="fDeviation"></param>
         * <param name="lprc"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_blur")]
        public static extern bool _canvas_blur(int hCanvas, float fDeviation, ref nint lprc);

        /** <summary>
         * 旋转色相
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="fAngle">0-360</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_rotate_hue")]
        public static extern bool _canvas_rotate_hue(int hCanvas, float fAngle);

        /** <summary>
         * 设置组件时钟
         * </summary>
         * <param name="hObj"></param>
         * <param name="uElapse"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetTimer")]
        public static extern int Ex_ObjSetTimer(int hObj, int uElapse);

        /** <summary>
         * 销毁组件时钟
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjKillTimer")]
        public static extern bool Ex_ObjKillTimer(int hObj);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hFont">如果为0则使用默认字体句柄</param>
         * <param name="crText"></param>
         * <param name="lpwzText"></param>
         * <param name="dwLen">-1则自动计算尺寸(必须是指向空字符串的指针)</param>
         * <param name="dwDTFormat">#DT_</param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawtext")]
        public static extern bool _canvas_drawtext(int hCanvas, int hFont, int crText, string lpwzText, long dwLen, int dwDTFormat, float left, float top, float right, float bottom);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hFont">如果为0则使用默认字体句柄</param>
         * <param name="hBrush"></param>
         * <param name="lpwzText"></param>
         * <param name="dwLen">-1则自动计算尺寸(必须是指向空字符串的指针)</param>
         * <param name="dwDTFormat"#DT_></param>
         * <param name="left"></param>
         * <param name="right"></param>
         * <param name="top"></param>
         * <param name="bottom"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawtext2")]
        public static extern bool _canvas_drawtext2(int hCanvas, int hFont, nint hBrush, string lpwzText, long dwLen, int dwDTFormat, float left, float top, float right, float bottom);

        /** <summary>
         * 
         * </summary>
         * <param name="hFont"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_destroy")]
        public static extern bool _font_destroy(int hFont);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hFont"></param>
         * <param name="lpwzText"></param>
         * <param name="dwLen"></param>
         * <param name="dwDTFormat"></param>
         * <param name="lParam"></param>
         * <param name="layoutWidth"></param>
         * <param name="layoutHeight"></param>
         * <param name="lpWidth"></param>
         * <param name="lpHeight"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_calctextsize")]
        public static extern bool _canvas_calctextsize(int hCanvas, int hFont, string lpwzText, long dwLen, int dwDTFormat, nint lParam, float layoutWidth, float layoutHeight, out float lpWidth, out float lpHeight);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hFont"></param>
         * <param name="crText"></param>
         * <param name="lpwzText"></param>
         * <param name="dwLen">-1则自动计算尺寸(必须是指向空字符串的指针)</param>
         * <param name="dwDTFormat"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="iGlowsize"></param>
         * <param name="crShadow"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawtextex")]
        public static extern bool _canvas_drawtextex(int hCanvas, int hFont, int crText, string lpwzText, long dwLen, int dwDTFormat, float left, float top, float right, float bottom, int iGlowsize, int crShadow, nint lParam);

        /** <summary>
         * 分发消息
         * </summary>
         * <param name="hObj"></param>
         * <param name="uMsg"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDispatchMessage")]
        public static extern nint Ex_ObjDispatchMessage(int hObj, int uMsg, nint wParam, nint lParam);

        /** <summary>
         * ok
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_begindraw")]
        public static extern bool _canvas_begindraw(int hCanvas);

        /** <summary>
         * 设置组件状态
         * </summary>
         * <param name="hObj"></param>
         * <param name="dwState"></param>
         * <param name="fRemove"></param>
         * <param name="lprcRedraw"></param>
         * <param name="fRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetUIState")]
        public static extern bool Ex_ObjSetUIState(int hObj, int dwState, bool fRemove, ref ExRect lprcRedraw, bool fRedraw);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_flush")]
        public static extern bool _canvas_flush(int hCanvas);

        /** <summary>
         * 设置滚动条信息
         * </summary>
         * <param name="hObj"></param>
         * <param name="fnBar">SB_</param>
         * <param name="fMask">SIF_</param>
         * <param name="nMin"></param>
         * <param name="nMax"></param>
         * <param name="nPage"></param>
         * <param name="nPos"></param>
         * <param name="fRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollSetInfo")]
        public static extern int Ex_ObjScrollSetInfo(int hObj, int fnBar, int fMask, int nMin, int nMax, int nPage, int nPos, bool fRedraw);

        /** <summary>
         * 设置滚动条范围
         * </summary>
         * <param name="hObj"></param>
         * <param name="nBar">SB_</param>
         * <param name="nMin"></param>
         * <param name="nMax"></param>
         * <param name="bRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollSetRange")]
        public static extern bool Ex_ObjScrollSetRange(int hObj, int nBar, int nMin, int nMax, bool bRedraw);

        /** <summary>
         * 设置滚动条位置
         * </summary>
         * <param name="hObj"></param>
         * <param name="nBar">SB_</param>
         * <param name="nPos"></param>
         * <param name="bRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollSetPos")]
        public static extern int Ex_ObjScrollSetPos(int hObj, int nBar, int nPos, bool bRedraw);

        /** <summary>
         * 获取滚动条句柄
         * </summary>
         * <param name="hObj"></param>
         * <param name="nBar">相关常量 #SB_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetControl")]
        public static extern nint Ex_ObjScrollGetControl(int hObj, int nBar);

        /** <summary>
         * 调用过程
         * </summary>
         * <param name="lpPrevObjProc"></param>
         * <param name="hWnd"></param>
         * <param name="hObj"></param>
         * <param name="uMsg"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         * <param name="pvData"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCallProc")]
        public static extern nint Ex_ObjCallProc(nint lpPrevObjProc, nint hWnd, int hObj, int uMsg, nint wParam, nint lParam, nint pvData);

        /** <summary>
         * 创建画布自引擎句柄
         * </summary>
         * <param name="hExDui"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         * <param name="dwFlags">CVF_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_createfromexdui")]
        public static extern int _canvas_createfromexdui(int hExDui, int width, int height, int dwFlags);

        /** <summary>
         * 获取滚动条位置
         * </summary>
         * <param name="hObj"></param>
         * <param name="nBar"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetPos")]
        public static extern int Ex_ObjScrollGetPos(int hObj, int nBar);

        /** <summary>
         * 弹出信息框
         * </summary>
         * <param name="handle">组件句柄/引擎句柄/窗口句柄.(如果该值为窗口句柄且窗口未使用引擎渲染</param>
         * <param name="lpText">消息框内容</param>
         * <param name="lpCaption">消息框标题</param>
         * <param name="uType">相关常量 #MB_</param>
         * <param name="dwFlags">相关常量 #EMBF_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_MessageBox")]
        public static extern int Ex_MessageBox(int handle, string lpText, string lpCaption, int uType, int dwFlags);

        /** <summary>
         * 弹出信息框
         * </summary>
         * <param name="handle">组件句柄/引擎句柄/窗口句柄.(如果该值为窗口句柄且窗口未使用引擎渲染</param>
         * <param name="lpText">消息框内容</param>
         * <param name="lpCaption">消息框标题</param>
         * <param name="uType">相关常量 #MB_</param>
         * <param name="lpCheckBox">检查框标题(消息框左下角显示一个检查框组件).(如果该窗口未使用引擎渲染</param>
         * <param name="lpCheckBoxChecked">返回检查框选中状态.(如果该窗口未使用引擎渲染</param>
         * <param name="dwMilliseconds">消息框延迟关闭时间，单位：毫秒。如果该值不为0</param>
         * <param name="dwFlags">相关常量 #EMBF_</param>
         * <param name="lpfnMsgProc">(BOOL)MsgProc(hWnd</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_MessageBoxEx")]
        public static extern int Ex_MessageBoxEx(int handle, string lpText, string lpCaption, int uType, string lpCheckBox, ref bool lpCheckBoxChecked, int dwMilliseconds, int dwFlags, ExWndProcDelegate lpfnMsgProc);

        /** <summary>
         * 绑定窗口
         * </summary>
         * <param name="hWnd">窗口句柄</param>
         * <param name="hTheme">主题句柄.(值可为0)</param>
         * <param name="dwStyle">相关常量:#EWS_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIBindWindow")]
        public static extern nint Ex_DUIBindWindow(nint hWnd, int hTheme, int dwStyle);

        /** <summary>
         * 获取组件句柄自ID
         * </summary>
         * <param name="hExDuiOrhObj">如果指定引擎句柄</param>
         * <param name="nID"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFromID")]
        public static extern int Ex_ObjGetFromID(int hExDuiOrhObj, int nID);

        /** <summary>
         * 获取组件句柄自NAME
         * </summary>
         * <param name="hExDuiOrhObj">如果指定引擎句柄</param>
         * <param name="lpwzName"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFromName")]
        public static extern int Ex_ObjGetFromName(int hExDuiOrhObj, string lpwzName);

        /** <summary>
         * 挂接组件事件回调
         * </summary>
         * <param name="hObj"></param>
         * <param name="nEvent">#NM_</param>
         * <param name="pfnCallback">(Bool) Handler(hObj</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjHandleEvent")]
        public static extern bool Ex_ObjHandleEvent(int hObj, int nEvent, ExObjEventProcDelegate pfnCallback);

        /** <summary>
         * 获取主题相关颜色值
         * </summary>
         * <param name="hTheme">主题句柄</param>
         * <param name="nIndex">#COLOR_EX_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeGetColor")]
        public static extern int Ex_ThemeGetColor(int hTheme, int nIndex);

        /** <summary>
         * 获取组件状态
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetUIState")]
        public static extern int Ex_ObjGetUIState(int hObj);

        /** <summary>
         * 设置组件相关颜色
         * </summary>
         * <param name="hObj"></param>
         * <param name="nIndex">相关常量 COLOR_EX_</param>
         * <param name="dwColor"></param>
         * <param name="fRedraw">是否重画</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetColor")]
        public static extern int Ex_ObjSetColor(int hObj, int nIndex, int dwColor, bool fRedraw);

        /** <summary>
         * 获取组件相关颜色
         * </summary>
         * <param name="hObj"></param>
         * <param name="nIndex">相关常量 COLOR_EX_</param>
         **/
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
        public static extern nint Ex_ObjEditSetSelCharFormat(int hObj, int dwMask, int crText, string wzFontFace, int dwFontSize, int offsetY, bool bBold, bool bItalic, bool bUnderLine, bool bStrikeOut, bool bLink);

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
        public static extern nint Ex_ObjEditSetSelParFormat(int hObj, int dwMask, ushort wNumbering, int dxStartIndent, int dxRightIndent, int offsetX, ushort wAlignment);

        /** <summary>
         * 从文件加载资源
         * </summary>
         * <param name="lpwzFile"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResLoadFromFile")]
        public static extern nint Ex_ResLoadFromFile(string lpwzFile);

        /** <summary>
         * 从内存加载资源
         * </summary>
         * <param name="lpData"></param>
         * <param name="dwDataLen"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResLoadFromMemory")]
        public static extern nint Ex_ResLoadFromMemory(byte[] lpData, nint dwDataLen);

        /** <summary>
         * 语言包_获取文本
         * </summary>
         * <param name="lpwzID"></param>
         * <param name="lpString">[out]指向字符串指针.如果已被格式化</param>
         * <param name="bFormat">[in/out]是否需要格式化</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_I18NGetString")]
        public static extern bool Ex_I18NGetString(string lpwzID, StringBuilder lpString, ref bool bFormat);

        /** <summary>
         * 语言包_获取文本
         * </summary>
         * <param name="atomID"></param>
         * <param name="lpString">[out]指向字符串指针.如果已被格式化</param>
         * <param name="bFormat">[in/out]是否需要格式化</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_I18NGetStringFromAtom")]
        public static extern bool Ex_I18NGetStringFromAtom(int atomID, StringBuilder lpString, ref bool bFormat);

        /** <summary>
         * 获取资源文件
         * </summary>
         * <param name="hRes"></param>
         * <param name="lpwzPath"></param>
         * <param name="lpFile">[out]文件数据指针.用户不应该释放该内存.</param>
         * <param name="dwFileLen">[out]文件尺寸.</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResGetFile")]
        public static extern bool Ex_ResGetFile(nint hRes, string lpwzPath, out byte[] lpFile, out nint dwFileLen);

        /** <summary>
         * 获取资源文件
         * </summary>
         * <param name="hRes"></param>
         * <param name="atomPath"></param>
         * <param name="lpFile">[out]文件数据指针.用户不应该释放该内存.</param>
         * <param name="dwFileLen">[out]文件尺寸.</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResGetFileFromAtom")]
        public static extern bool Ex_ResGetFileFromAtom(nint hRes, int atomPath, out byte[] lpFile, out nint dwFileLen);

        /** <summary>
         * 释放资源
         * </summary>
         * <param name="hRes"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ResFree")]
        public static extern void Ex_ResFree(nint hRes);

        /** <summary>
         * 分发事件
         * </summary>
         * <param name="hObj"></param>
         * <param name="nCode"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDispatchNotify")]
        public static extern nint Ex_ObjDispatchNotify(int hObj, int nCode, nint wParam, nint lParam);

        /** <summary>
         * 语言包_文本格式化
         * </summary>
         * <param name="lppStringSrc"></param>
         * <param name="lpStringFormated"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_I18NStringFormat")]
        public static extern void Ex_I18NStringFormat(string lppStringSrc, ref bool lpStringFormated);

        /** <summary>
         * 语言包_注册回调
         * </summary>
         * <param name="pfnStringFormatCallback">[bool]callback(atomID</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_I18NRegisterCallback")]
        public static extern void Ex_I18NRegisterCallback(nint pfnStringFormatCallback);

        /** <summary>
         * 设置托盘图标
         * </summary>
         * <param name="hExdui">引擎句柄</param>
         * <param name="hIcon">图标句柄</param>
         * <param name="lpwzTips">提示文本指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUITrayIconSet")]
        public static extern bool Ex_DUITrayIconSet(int hExDui, nint hIcon, string lpwzTips);

        /** <summary>
         * 弹出托盘图标
         * </summary>
         * <param name="hExDui">引擎句柄</param>
         * <param name="lpwzInfo">弹出文本内容</param>
         * <param name="lpwzInfoTitle">弹出标题文本</param>
         * <param name="dwInfoFlags">相关常量 #NIIF_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUITrayIconPopup")]
        public static extern bool Ex_DUITrayIconPopup(int hExDui, string lpwzInfo, string lpwzInfoTitle, int dwInfoFlags);

        /** <summary>
         * 释放内存
         * </summary>
         * <param name="lpBuffer"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_FreeBuffer")]
        public static extern bool Ex_FreeBuffer(nint lpBuffer);

        /** <summary>
         * 默认绘制背景过程
         * </summary>
         * <param name="hObj"></param>
         * <param name="hCanvas"></param>
         * <param name="lprcPaint"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDrawBackgroundProc")]
        public static extern bool Ex_ObjDrawBackgroundProc(int hObj, int hCanvas, ref ExRect lprcPaint);

        /** <summary>
         * 获取焦点组件
         * </summary>
         * <param name="hExDuiOrhObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFocus")]
        public static extern int Ex_ObjGetFocus(int hExDuiOrhObj);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="pMatrix">0.则重置</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_settransform")]
        public static extern bool _canvas_settransform(int hCanvas, nint pMatrix);

        /** <summary>
         * 
         * </summary>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_create")]
        public static extern nint _matrix_create();

        /** <summary>
         * 
         * </summary>
         * <param name="pMatrix"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_destroy")]
        public static extern bool _matrix_destroy(nint pMatrix);

        /** <summary>
         * 
         * </summary>
         * <param name="pMatrix"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_reset")]
        public static extern bool _matrix_reset(nint pMatrix);

        /** <summary>
         * 
         * </summary>
         * <param name="pMatrix"></param>
         * <param name="offsetX"></param>
         * <param name="offsetY"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_translate")]
        public static extern bool _matrix_translate(nint pMatrix, float offsetX, float offsetY);

        /** <summary>
         * 
         * </summary>
         * <param name="pMatrix"></param>
         * <param name="fAngle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_rotate")]
        public static extern bool _matrix_rotate(nint pMatrix, float fAngle);

        /** <summary>
         * 
         * </summary>
         * <param name="pMatrix"></param>
         * <param name="scaleX"></param>
         * <param name="scaleY"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_matrix_scale")]
        public static extern bool _matrix_scale(nint pMatrix, float scaleX, float scaleY);

        /** <summary>
         * 创建图像自资源包。成功返回0。
         * </summary>
         * <param name="hRes"></param>
         * <param name="atomPath"></param>
         * <param name="hImg">返回图像指针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_createfromres")]
        public static extern bool _img_createfromres(nint hRes, int atomPath, out int hImg);

        /** <summary>
         * 
         * </summary>
         * <param name="hBrush"></param>
         * <param name="argb"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_setcolor")]
        public static extern int _brush_setcolor(nint hBrush, int argb);

        /** <summary>
         * 绘制主题数据
         * </summary>
         * <param name="hTheme">主题句柄</param>
         * <param name="hCanvas">画板句柄</param>
         * <param name="dstLeft">目标左边</param>
         * <param name="dstTop">目标顶边</param>
         * <param name="dstRight">目标右边</param>
         * <param name="dstBottom">目标底边</param>
         * <param name="atomClass"></param>
         * <param name="atomSrcRect"></param>
         * <param name="dwAlpha">透明度(0-255)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeDrawControl")]
        public static extern bool Ex_ThemeDrawControl(int hTheme, int hCanvas, float dstLeft, float dstTop, float dstRight, float dstBottom, int atomClass, int atomSrcRect, int dwAlpha);

        /** <summary>
         * 
         * </summary>
         * <param name="hImg"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createfromimg")]
        public static extern nint _brush_createfromimg(int hImg);

        /** <summary>
         * 
         * </summary>
         * <param name="cx">center_x</param>
         * <param name="cy">center_y</param>
         * <param name="off_x">Offset_x</param>
         * <param name="off_y">Offset_y</param>
         * <param name="radiusX">radiusX</param>
         * <param name="radiusY">radiusY</param>
         * <param name="arrStopPts"></param>
         * <param name="cStopPts"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createradial_ex")]
        public static extern nint _brush_createradial_ex(float cx, float cy, float off_x, float off_y, float radiusX, float radiusY, int arrStopPts, int cStopPts);


        /** <summary>
         * 创建路径
         * </summary>
         * <param name="dwFlags">EPF_</param>
         * <param name="hPath"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_create")]
        public static extern bool _path_create(int dwFlags, out int hPath);

        /** <summary>
         * 销毁路径
         * </summary>
         * <param name="hPath"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_destroy")]
        public static extern bool _path_destroy(int hPath);

        /** <summary>
         * 添加线
         * </summary>
         * <param name="hPath"></param>
         * <param name="x1"></param>
         * <param name="y1"></param>
         * <param name="x2"></param>
         * <param name="y2"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addline")]
        public static extern bool _path_addline(int hPath, float x1, float y1, float x2, float y2);

        /** <summary>
         * 开始新图形
         * </summary>
         * <param name="hPath"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_beginfigure")]
        public static extern bool _path_beginfigure(int hPath);

        /** <summary>
       * 开始新图形,可设置起始点
       * </summary>
       * <param name="hPath"></param>
       * <param name="x"></param>
       * <param name="y"></param>
       **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_beginfigure2")]
        public static extern bool _path_beginfigure2(int hPath, float x, float y);

        /** <summary>
        * 开始图形(可设置起始点,D2D有效,GDI模式和beginfigure一样)
        * </summary>
        * <param name="hPath"></param>
        * <param name="x"></param>
        * <param name="y"></param>
        * <param name="figureBegin">#PBF_  图形开始</param>
        **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_beginfigure2")]
        public static extern bool _path_beginfigure3(int hPath, float x, float y,int figureBegin);

        /** <summary>
         * 结束当前图形
         * </summary>
         * <param name="hPath"></param>
         * <param name="fCloseFigure">是否需要闭合图形</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_endfigure")]
        public static extern bool _path_endfigure(int hPath, bool fCloseFigure);

        /** <summary>
         * 添加贝塞尔
         * </summary>
         * <param name="hPath"></param>
         * <param name="x1"></param>
         * <param name="y1"></param>
         * <param name="x2"></param>
         * <param name="y2"></param>
         * <param name="x3"></param>
         * <param name="y3"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addbezier")]
        public static extern bool _path_addbezier(int hPath, float x1, float y1, float x2, float y2, float x3, float y3);

        /** <summary>
         * 添加二次方贝塞尔
         * </summary>
         * <param name="hPath"></param>
         * <param name="x1"></param>
         * <param name="y1"></param>
         * <param name="x2"></param>
         * <param name="y2"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addquadraticbezier")]
        public static extern bool _path_addquadraticbezier(int hPath, float x1, float y1, float x2, float y2);

        /** <summary>
         * 申请内存
         * </summary>
         * <param name="dwLen"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_AllocBuffer")]
        public static extern nint Ex_AllocBuffer(int dwLen);

        /** <summary>
         * 缩放图像.成功返回0
         * </summary>
         * <param name="hImage"></param>
         * <param name="dstWidth"></param>
         * <param name="dstHeight"></param>
         * <param name="dstImg">返回新图像</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_scale")]
        public static extern bool _img_scale(int hImage, int dstWidth, int dstHeight, out int dstImg);

        /** <summary>
         * 格式化_文本到整数
         * </summary>
         * <param name="lpValue">字符串指针</param>
         * <param name="lpdwPercentFlags">(out)返回是否为百分比单位</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_int")]
        public static extern int _fmt_int(string lpValue, out int lpdwPercentFlags);

        /** <summary>
         * 格式化_文本到整数数组
         * </summary>
         * <param name="lpValue">字符串指针</param>
         * <param name="lpAry">数组指针</param>
         * <param name="nMaxCount">最大数量</param>
         * <param name="fZero">是否清空</param>
         * <param name="lpdwPercentFlags">(out)返回百分比标记位(0-31位)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_intary")]
        public static extern int _fmt_intary(string lpValue, int[] lpAry, int nMaxCount, bool fZero, ref int lpdwPercentFlags);

        /** <summary>
         * 格式化_文本到矩形
         * </summary>
         * <param name="lpValue">字符串指针</param>
         * <param name="lpRect">矩形指针</param>
         * <param name="lpdwPercentFlags">(out)返回百分比标记位(0-31位)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_rect")]
        public static extern bool _fmt_rect(string lpValue, ref ExRect lpRect, ref int lpdwPercentFlags);

        /** <summary>
         * 格式化_文本到文本_语言包
         * </summary>
         * <param name="hRes">资源句柄.(值可为0)</param>
         * <param name="lpValue">字符串指针</param>
         * <param name="lpString">(out)</param>
         * <param name="bDispatchI18NCallback">(in/out)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_string")]
        public static extern bool _fmt_string(nint hRes, IStream lpValue, StringBuilder lpString, ref bool bDispatchI18NCallback);

        /** <summary>
         * 格式化_文本到颜色
         * </summary>
         * <param name="lpValue">字符串指针</param>
         * <param name="lpColor">(out)返回颜色</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_color")]
        public static extern bool _fmt_color(string lpValue, out int lpColor);

        /** <summary>
         * 格式化_二进制数据
         * </summary>
         * <param name="hRes">资源句柄</param>
         * <param name="lpValue">数据指针</param>
         * <param name="lpBin">(out)返回二进制数据指针</param>
         * <param name="lpLen">(out)返回数据长度</param>
         * <param name="lpFreeBuffer">(out)返回是否需要释放数据</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_bin")]
        public static extern bool _fmt_bin(nint hRes, string lpValue, out byte[] lpBin, out int lpLen, out bool lpFreeBuffer);

        /** <summary>
         * 格式化_获取数据偏移地址
         * </summary>
         * <param name="lpValue"></param>
         * <param name="atomDest"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_getvalue")]
        public static extern bool _fmt_getvalue(string lpValue, int atomDest);

        /** <summary>
         * 格式化_获取数据偏移地址
         * </summary>
         * <param name="lpValue"></param>
         * <param name="lpValueOffset"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_getatom")]
        public static extern int _fmt_getatom(string lpValue, out int lpValueOffset);

        /** <summary>
         * 
         * </summary>
         * <param name="nType">布局类型</param>
         * <param name="lpfnLayoutProc">布局管理器回调函数(lpLayout[有可能是NULL]</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_register")]
        public static extern bool _layout_register(int nType, ExLayoutProcDelegate lpfnLayoutProc);

        /** <summary>
         * 
         * </summary>
         * <param name="nType">布局类型</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_unregister")]
        public static extern bool _layout_unregister(int nType);

        /** <summary>
         * hLayout
         * </summary>
         * <param name="nType">#ELT_ 布局类型</param>
         * <param name="hObjBind">所绑定的HOBJ或HEXDUI</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_create")]
        public static extern int _layout_create(int nType, int hObjBind);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_destroy")]
        public static extern bool _layout_destroy(int hLayout);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_addchild")]
        public static extern bool _layout_addchild(int hLayout, int hObj);

        /** <summary>
         * 已被加入的不会重复添加(系统按钮不加入)
         * </summary>
         * <param name="hLayout"></param>
         * <param name="fDesc">是否倒序</param>
         * <param name="dwObjClassATOM">0或空为所有</param>
         * <param name="nCount">加入的个数</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_addchildren")]
        public static extern bool _layout_addchildren(int hLayout, bool fDesc, int dwObjClassATOM, out int nCount);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_deletechild")]
        public static extern bool _layout_deletechild(int hLayout, int hObj);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="dwObjClassATOM">0或空为所有</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_deletechildren")]
        public static extern bool _layout_deletechildren(int hLayout, int dwObjClassATOM);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObj"></param>
         * <param name="dwPropID"></param>
         * <param name="pvValue"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_setchildprop")]
        public static extern bool _layout_setchildprop(int hLayout, int hObj, int dwPropID, nint pvValue);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObj"></param>
         * <param name="dwPropID"></param>
         * <param name="pvValue"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getchildprop")]
        public static extern bool _layout_getchildprop(int hLayout, int hObj, int dwPropID, out nint pvValue);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObj"></param>
         * <param name="lpProps">不释放</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getchildproplist")]
        public static extern bool _layout_getchildproplist(int hLayout, int hObj, out nint lpProps);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="dwPropID"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getprop")]
        public static extern nint _layout_getprop(int hLayout, int dwPropID);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="dwPropID"></param>
         * <param name="pvValue"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_setprop")]
        public static extern bool _layout_setprop(int hLayout, int dwPropID, nint pvValue);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_getproplist")]
        public static extern nint _layout_getproplist(int hLayout);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_update")]
        public static extern bool _layout_update(int hLayout);

        /** <summary>
         * 重新设置type应当重新创建LM
         * </summary>
         * <param name="hLayout"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_gettype")]
        public static extern int _layout_gettype(int hLayout);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="fUpdateable"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_enableupdate")]
        public static extern bool _layout_enableupdate(int hLayout, bool fUpdateable);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="nEvent"></param>
         * <param name="wParam"></param>
         * <param name="lParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_notify")]
        public static extern nint _layout_notify(int hLayout, int nEvent, nint wParam, nint lParam);

        /** <summary>
         * 获取父组件和EXDUI句柄
         * </summary>
         * <param name="hObj"></param>
         * <param name="phExDUI"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetParentEx")]
        public static extern nint Ex_ObjGetParentEx(int hObj, out int phExDUI);

        /** <summary>
         * 获取组件文本矩形
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpRect"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetTextRect")]
        public static extern bool Ex_ObjGetTextRect(int hObj, out ExRect lpRect);

        /** <summary>
         * 绘制主题数据加强版
         * </summary>
         * <param name="hTheme">主题句柄</param>
         * <param name="hCanvas">画板句柄</param>
         * <param name="dstLeft">目标左边</param>
         * <param name="dstTop">目标顶边</param>
         * <param name="dstRight">目标右边</param>
         * <param name="dstBottom">目标底边</param>
         * <param name="atomClass"></param>
         * <param name="atomSrcRect"></param>
         * <param name="atomBackgroundRepeat"></param>
         * <param name="atomBackgroundPositon"></param>
         * <param name="atomBackgroundGrid"></param>
         * <param name="atomBackgroundFlags"></param>
         * <param name="dwAlpha">透明度(0-255)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ThemeDrawControlEx")]
        public static extern bool Ex_ThemeDrawControlEx(int hTheme, int hCanvas, float dstLeft, float dstTop, float dstRight, float dstBottom, int atomClass, int atomSrcRect, int atomBackgroundRepeat, int atomBackgroundPositon, int atomBackgroundGrid, int atomBackgroundFlags, int dwAlpha);

        /** <summary>
         * 
         * </summary>
         * <param name="hFont"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_getcontext")]
        public static extern nint _font_getcontext(int hFont);

        /** <summary>
         * 设置提示文本
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpString"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjTooltipsSetText")]
        public static extern bool Ex_ObjTooltipsSetText(int hObj, string lpString);

        /** <summary>
         * 弹出菜单
         * </summary>
         * <param name="hMenu">菜单句柄</param>
         * <param name="uFlags">相关常量 TPM_</param>
         * <param name="x">弹出坐标X(屏幕坐标)</param>
         * <param name="y">弹出坐标Y(屏幕坐标)</param>
         * <param name="nReserved">0.备用</param>
         * <param name="handle">组件句柄/引擎句柄/窗口句柄.(如果该值为窗口句柄且窗口未使用引擎渲染</param>
         * <param name="lpRc">0.忽略</param>
         * <param name="pfnCallback">(BOOL)MsgProc(hWnd</param>
         * <param name="dwFlags">相关常量 EMNF_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_TrackPopupMenu")]
        public static extern bool Ex_TrackPopupMenu(nint hMenu, int uFlags, int x, int y, nint nReserved, int handle, ref ExRect lpRc, ExWndProcDelegate pfnCallback, int dwFlags);

        /** <summary>
         * 从窗口句柄获取引擎句柄
         * </summary>
         * <param name="hWnd"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_DUIFromWindow")]
        public static extern nint Ex_DUIFromWindow(nint hWnd);

        /** <summary>
         * 获取滚动条范围
         * </summary>
         * <param name="hObj"></param>
         * <param name="nBar"></param>
         * <param name="lpnMinPos"></param>
         * <param name="lpnMaxPos"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetRange")]
        public static extern bool Ex_ObjScrollGetRange(int hObj, int nBar, out int lpnMinPos, out int lpnMaxPos);

        /** <summary>
         * 获取滚动条拖动位置
         * </summary>
         * <param name="hObj"></param>
         * <param name="nBar"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetTrackPos")]
        public static extern int Ex_ObjScrollGetTrackPos(int hObj, int nBar);

        /** <summary>
         * 获取滚动条信息
         * </summary>
         * <param name="hObj"></param>
         * <param name="fnBar"></param>
         * <param name="lpnMin"></param>
         * <param name="lpnMax"></param>
         * <param name="lpnPos"></param>
         * <param name="lpnTrackPos"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollGetInfo")]
        public static extern bool Ex_ObjScrollGetInfo(int hObj, int fnBar, out int lpnMin, out int lpnMax, out int lpnPos, out int lpnTrackPos);

        /** <summary>
         * 加载XML布局
         * </summary>
         * <param name="handle">窗口句柄/引擎句柄/组件句柄</param>
         * <param name="hRes">资源句柄.(值可为0)</param>
         * <param name="lpLayout">布局资源指针</param>
         * <param name="cbLayout">布局资源长度</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLoadFromLayout")]
        public static extern bool Ex_ObjLoadFromLayout(int handle, nint hRes, byte[] lpLayout, int cbLayout);

        /** <summary>
         * 
         * </summary>
         * <param name="hExDUIOrObj"></param>
         * <param name="nNodeID"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFromNodeID")]
        public static extern int Ex_ObjGetFromNodeID(int hExDUIOrObj, int nNodeID);

        /** <summary>
         * 
         * </summary>
         * <param name="const">in/out</param>
         * <param name="consts">atom</param>
         * <param name="values">value</param>
         * <param name="nCount"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_fmt_const")]
        public static extern bool _fmt_const(nint st, int[] consts, int[] values, int nCount);

        /** <summary>
         * 绑定自己的JS对象
         * </summary>
         * <param name="hExDUI_hObj">作用域为DUI</param>
         * <param name="szObjName"></param>
         * <param name="lpfnDispatch">HRESULT DispatchFunc (this</param>
         * <param name="pvParam"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSBindObject")]
        public static extern int Ex_JSBindObject(int hExDUI_hObj, string szObjName, nint lpfnDispatch, int pvParam);

        /** <summary>
         * 
         * </summary>
         * <param name="hExDUI_hObj"></param>
         * <param name="szExpression"></param>
         * <param name="fUseThis">为真时表达式中this代表参数1对应的JS对象</param>
         * <param name="pVarResult">不为NULL时会将返回值写入</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSEval")]
        public static extern int Ex_JSEval(int hExDUI_hObj, string szExpression, bool fUseThis, nint pVarResult);

        /** <summary>
         * 
         * </summary>
         * <param name="hExDUI_hObj"></param>
         * <param name="szCode"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSAddCode")]
        public static extern bool Ex_JSAddCode(int hExDUI_hObj, string szCode);

        /** <summary>
         * 
         * </summary>
         * <param name="hExDUI_hObj"></param>
         * <param name="nErrCode"></param>
         * <param name="nErrLine"></param>
         * <param name="szErrMsg">char[1024]</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetLastError")]
        public static extern bool Ex_JSGetLastError(int hExDUI_hObj, StringBuilder nErrCode, StringBuilder nErrLine, StringBuilder szErrMsg);

        /** <summary>
         * 
         * </summary>
         * <param name="hObj"></param>
         * <param name="notyfiCode"></param>
         * <param name="szFuncName"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSRegisterFunction")]
        public static extern bool Ex_JSRegisterFunction(int hObj, int notyfiCode, string szFuncName);

        /** <summary>
         * 
         * </summary>
         * <param name="pVariant"></param>
         * <param name="nType"></param>
         * <param name="dwValue"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSSetVariant")]
        public static extern void Ex_JSSetVariant(nint pVariant, short nType, int dwValue);

        /** <summary>
         * 
         * </summary>
         * <param name="pVariant"></param>
         * <param name="nType"></param>
         * <param name="pValue"></param>
         * <param name="cbSize">1</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSSetVariantPtr")]
        public static extern void Ex_JSSetVariantPtr(nint pVariant, short nType, ref int pValue, int cbSize);

        /** <summary>
         * 
         * </summary>
         * <param name="lpParams"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamCount")]
        public static extern int Ex_JSGetParamCount(ref int lpParams);

        /** <summary>
         * 
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamType")]
        public static extern int Ex_JSGetParamType(ref int lpParams, int nIndex);

        /** <summary>
         * 返回pVar
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParam")]
        public static extern int Ex_JSGetParam(ref int lpParams, int nIndex);

        /** <summary>
         * 
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         * <param name="nDefault"></param>
         * <param name="pType"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamNumber")]
        public static extern double Ex_JSGetParamNumber(ref int lpParams, int nIndex, double nDefault, ref int pType);

        /** <summary>
         * 
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         * <param name="nDefault"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamInt")]
        public static extern int Ex_JSGetParamInt(ref int lpParams, int nIndex, int nDefault);

        /** <summary>
         * 
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         * <param name="nDefault"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamFloat")]
        public static extern float Ex_JSGetParamFloat(ref int lpParams, int nIndex, float nDefault);

        /** <summary>
         * 
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         * <param name="nDefault"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamDouble")]
        public static extern double Ex_JSGetParamDouble(ref int lpParams, int nIndex, double nDefault);

        /** <summary>
         * wchar_t* 不要释放
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamString")]
        public static extern int Ex_JSGetParamString(ref int lpParams, int nIndex);

        /** <summary>
         * wchar_t* 需要自己释放
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         * <param name="wzDefault"></param>
         * <param name="pType"></param>
         * <param name="fFormat"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamToString")]
        public static extern int Ex_JSGetParamToString(ref int lpParams, int nIndex, int wzDefault, ref int pType, bool fFormat);

        /** <summary>
         * wchar_t* 需要自己释放
         * </summary>
         * <param name="lpParams"></param>
         * <param name="nIndex"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSGetParamFormatString")]
        public static extern int Ex_JSGetParamFormatString(ref int lpParams, int nIndex);

        /** <summary>
         * 
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpRect"></param>
         * <param name="nType"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetRectEx")]
        public static extern bool Ex_ObjGetRectEx(int hObj, out ExRect lpRect, int nType);

        /** <summary>
         * 获取布局对象句柄
         * </summary>
         * <param name="handle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutGet")]
        public static extern nint Ex_ObjLayoutGet(int handle);

        /** <summary>
         * 设置布局对象句柄
         * </summary>
         * <param name="handle"></param>
         * <param name="hLayout"></param>
         * <param name="fUpdate"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutSet")]
        public static extern bool Ex_ObjLayoutSet(int handle, nint hLayout, bool fUpdate);

        /** <summary>
         * 更新对象布局
         * </summary>
         * <param name="handle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutUpdate")]
        public static extern bool Ex_ObjLayoutUpdate(int handle);

        /** <summary>
         * 清空对象布局信息
         * </summary>
         * <param name="handle"></param>
         * <param name="bChildren">是否清空所有子组件</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjLayoutClear")]
        public static extern bool Ex_ObjLayoutClear(int handle, bool bChildren);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="aRowHeight"></param>
         * <param name="cRows"></param>
         * <param name="aCellWidth"></param>
         * <param name="cCells"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_table_setinfo")]
        public static extern bool _layout_table_setinfo(int hLayout, int[] aRowHeight, int cRows, int[] aCellWidth, int cCells);

        /** <summary>
         * 设置组件偏移矩形
         * </summary>
         * <param name="hObj"></param>
         * <param name="nPaddingType">EOPT_TEXT=0</param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="fRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetPadding")]
        public static extern bool Ex_ObjSetPadding(int hObj, int nPaddingType, int left, int top, int right, int bottom, bool fRedraw);

        /** <summary>
         * 设置组件文本字体
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpszFontfamily">-1 为默认字体</param>
         * <param name="dwFontsize">-1 为默认尺寸</param>
         * <param name="dwFontstyle">-1 为默认风格</param>
         * <param name="fRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetFontFromFamily")]
        public static extern bool Ex_ObjSetFontFromFamily(int hObj, string lpszFontfamily, int dwFontsize, int dwFontstyle, bool fRedraw);

        /** <summary>
         * 获取字体。用户不应该销毁该字体对象
         * </summary>
         * <param name="hObj"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetFont")]
        public static extern nint Ex_ObjGetFont(int hObj);

        /** <summary>
         * 
         * </summary>
         * <param name="hObjSrc"></param>
         * <param name="hObjDst">0为所属窗口</param>
         * <param name="ptX">in/out</param>
         * <param name="ptY">in/out</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjPointTransform")]
        public static extern bool Ex_ObjPointTransform(int hObjSrc, int hObjDst, ref int ptX, ref int ptY);

        /** <summary>
         * 设置该控件是否启用事件冒泡
         * </summary>
         * <param name="hObj"></param>
         * <param name="fEnable"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnableEventBubble")]
        public static extern bool Ex_ObjEnableEventBubble(int hObj, bool fEnable);

        /** <summary>
         * 获取组件类信息
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpClassInfo">相关结构 EX_CLASSINFO</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetClassInfo")]
        public static extern bool Ex_ObjGetClassInfo(int hObj, out ExClassInfo lpClassInfo);

        /** <summary>
         * 通过类名/类ATOM获取类信息
         * </summary>
         * <param name="wzClassName">wzClassName/AtomClassName</param>
         * <param name="lpClassInfo">相关结构 EX_CLASSINFO</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetClassInfoEx")]
        public static extern bool Ex_ObjGetClassInfoEx(string wzClassName, out ExClassInfo lpClassInfo);

        /** <summary>
         * 
         * </summary>
         * <param name="lpCurveInfo"></param>
         * <param name="cbCurveInfo"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_curve_load")]
        public static extern nint _easing_curve_load(byte[] lpCurveInfo, int cbCurveInfo);

        /** <summary>
         * 
         * </summary>
         * <param name="pCurveInfo"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_curve_free")]
        public static extern void _easing_curve_free(nint pCurveInfo);

        /** <summary>
         * 
         * </summary>
         * <param name="dwType">#缓动类型_</param>
         * <param name="pEasingContext"></param>
         * <param name="dwMode">#缓动模式_ 的组合</param>
         * <param name="pContext"></param>
         * <param name="nTotalTime">ms</param>
         * <param name="nInterval">ms</param>
         * <param name="nState">#EES_</param>
         * <param name="nStart"></param>
         * <param name="nStop"></param>
         * <param name="param1"></param>
         * <param name="param2"></param>
         * <param name="param3"></param>
         * <param name="param4"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_create")]
        public static extern nint _easing_create(int dwType, nint pEasingContext, int dwMode, nint pContext, int nTotalTime, int nInterval, int nState, int nStart, int nStop, nint param1, nint param2, nint param3, nint param4);

        /** <summary>
         * 
         * </summary>
         * <param name="pEasing"></param>
         * <param name="nState">#EES_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_setstate")]
        public static extern bool _easing_setstate(nint pEasing, int nState);

        /** <summary>
         * 暂停
         * </summary>
         * <param name="us"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_Sleep")]
        public static extern void Ex_Sleep(int us);

        /** <summary>
         * 
         * </summary>
         * <param name="pEasing"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_easing_getstate")]
        public static extern int _easing_getstate(nint pEasing);

        /** <summary>
         * 
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObjChild"></param>
         * <param name="dwEdge">#ELCP_ABSOLUTE_XXX</param>
         * <param name="dwType"></param>
         * <param name="nValue"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_absolute_setedge")]
        public static extern bool _layout_absolute_setedge(int hLayout, int hObjChild, int dwEdge, int dwType, nint nValue);

        /** <summary>
         * 按当前位置锁定
         * </summary>
         * <param name="hLayout"></param>
         * <param name="hObjChild"></param>
         * <param name="tLeft">#ELCP_ABSOLUTE_XXX_TYPE 下同</param>
         * <param name="tTop"></param>
         * <param name="tRight"></param>
         * <param name="tBottom"></param>
         * <param name="tWidth"></param>
         * <param name="tHeight"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_layout_absolute_lock")]
        public static extern bool _layout_absolute_lock(int hLayout, int hObjChild, int tLeft, int tTop, int tRight, int tBottom, int tWidth, int tHeight);

        /** <summary>
         * 要注意每次初始化都会清空之前存储的内容
         * </summary>
         * <param name="hObj"></param>
         * <param name="nPropCount">-1为哈希表模式</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjInitPropList")]
        public static extern bool Ex_ObjInitPropList(int hObj, int nPropCount);

        /** <summary>
         * 移除属性
         * </summary>
         * <param name="hObj"></param>
         * <param name="dwKey"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjRemoveProp")]
        public static extern nint Ex_ObjRemoveProp(int hObj, nint dwKey);

        /** <summary>
         * 返回个数.枚举属性表
         * </summary>
         * <param name="hObj"></param>
         * <param name="lpfnCbk">bool enum(hObj</param>
         * <param name="param"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnumProps")]
        public static extern int Ex_ObjEnumProps(int hObj, ExObjPropEnumCallbackDelegate lpfnCbk, nint lParam);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createfromcanvas")]
        public static extern nint _brush_createfromcanvas(int hCanvas);

        /** <summary>
       * 
       * </summary>
       * <param name="hCanvas"></param>
       * <param name="alpha"></param>
       **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_createfromcanvas2")]
        public static extern nint _brush_createfromcanvas2(int hCanvas, int alpha);

        /** <summary>
         * 设置组件圆角度
         * </summary>
         * <param name="hObj"></param>
         * <param name="topleft">左上角</param>
         * <param name="topright">右上角</param>
         * <param name="bottomright">右下角</param>
         * <param name="bottomleft">左下角</param>
         * <param name="fUpdate"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetRadius")]
        public static extern bool Ex_ObjSetRadius(int hObj, float topleft, float topright, float bottomright, float bottomleft, bool fUpdate);

        /** <summary>
         * 重置路径
         * </summary>
         * <param name="hPath"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_reset")]
        public static extern bool _path_reset(int hPath);

        /** <summary>
         * 取路径边界矩形
         * </summary>
         * <param name="hPath"></param>
         * <param name="lpBounds">RECTF</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_getbounds")]
        public static extern bool _path_getbounds(int hPath, ref ExRectF lpBounds);

        /** <summary>
         * 关闭路径
         * </summary>
         * <param name="hPath"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_close")]
        public static extern bool _path_close(int hPath);

        /** <summary>
         * 打开路径
         * </summary>
         * <param name="hPath"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_open")]
        public static extern bool _path_open(int hPath);

        /** <summary>
         * 添加弧
         * </summary>
         * <param name="hPath"></param>
         * <param name="x1">起始坐标X</param>
         * <param name="y1">起始坐标Y</param>
         * <param name="x2">终点坐标X</param>
         * <param name="y2">终点坐标Y</param>
         * <param name="radiusX">半径X</param>
         * <param name="radiusY">半径Y</param>
         * <param name="fClockwise">是否顺时针</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addarc")]
        public static extern bool _path_addarc(int hPath, float x1, float y1, float x2, float y2, float radiusX, float radiusY, bool fClockwise);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hPath"></param>
         * <param name="hBrush"></param>
         * <param name="strokeWidth"></param>
         * <param name="strokeStyle"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawpath")]
        public static extern int _canvas_drawpath(int hCanvas, int hPath, nint hBrush, float strokeWidth, int strokeStyle);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="hPath"></param>
         * <param name="hBrush"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_fillpath")]
        public static extern bool _canvas_fillpath(int hCanvas, int hPath, nint hBrush);

        /** <summary>
         * 添加矩形
         * </summary>
         * <param name="hPath"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addrect")]
        public static extern bool _path_addrect(int hPath, float left, float top, float right, float bottom);

        /** <summary>
         * 添加圆角矩形
         * </summary>
         * <param name="hPath"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="right"></param>
         * <param name="bottom"></param>
         * <param name="radiusTopLeft"></param>
         * <param name="radiusTopRight"></param>
         * <param name="radiusBottomLeft"></param>
         * <param name="radiusBottomRight"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addroundedrect")]
        public static extern bool _path_addroundedrect(int hPath, float left, float top, float right, float bottom, float radiusTopLeft, float radiusTopRight, float radiusBottomLeft, float radiusBottomRight);

        /** <summary>
         * 测试坐标是否在可见路径内
         * </summary>
         * <param name="hPath"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_hittest")]
        public static extern bool _path_hittest(int hPath, float x, float y);

        /** <summary>
         * 
         * </summary>
         * <param name="hBrush"></param>
         * <param name="matrix"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_brush_settransform")]
        public static extern int _brush_settransform(nint hBrush, nint matrix);

        /** <summary>
         * 显示/隐藏滚动条
         * </summary>
         * <param name="hObj"></param>
         * <param name="wBar">支持SB_BOTH</param>
         * <param name="fShow"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollShow")]
        public static extern bool Ex_ObjScrollShow(int hObj, int wBar, bool fShow);

        /** <summary>
         * 禁用/启用滚动条
         * </summary>
         * <param name="hObj"></param>
         * <param name="wSB">支持SB_BOTH</param>
         * <param name="wArrows">相关常量 ESB_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjScrollEnable")]
        public static extern bool Ex_ObjScrollEnable(int hObj, int wSB, int wArrows);

        /** <summary>
         * 
         * </summary>
         * <param name="hFont"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_font_copy")]
        public static extern int _font_copy(int hFont);

        /** <summary>
         * 加载JS常量
         * </summary>
         * <param name="szConst"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_JSLoadConst")]
        public static extern void Ex_JSLoadConst(string szConst);

        /** <summary>
         * 设置组件文本字体
         * </summary>
         * <param name="hObj"></param>
         * <param name="hFont">_font_createxxx</param>
         * <param name="fRedraw"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetFont")]
        public static extern bool Ex_ObjSetFont(int hObj, int hFont, bool fRedraw);

        /** <summary>
         * 创建图片组
         * </summary>
         * <param name="nWidth">宽度</param>
         * <param name="nHeight">高度</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_create")]
        public static extern nint _imglist_create(int nWidth, int nHeight);

        /** <summary>
         * 销毁图片组
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_destroy")]
        public static extern bool _imglist_destroy(nint hImageList);

        /** <summary>
         * 添加图片
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="lpImage">图像数据指针</param>
         * <param name="cbImage">图像数据长度</param>
         * <param name="nIndexInsert">插入位置(0为最后)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_add")]
        public static extern nint _imglist_add(nint hImageList, byte[] lpImage, int cbImage, nint nIndexInsert);

        /** <summary>
         * 添加图片
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="hImage">图像对象句柄</param>
         * <param name="nIndexInsert">插入位置(0为最后)</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_addimage")]
        public static extern nint _imglist_addimage(nint hImageList, int hImage, nint nIndexInsert);

        /** <summary>
         * 删除图片
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="nIndex">图片索引</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_del")]
        public static extern bool _imglist_del(nint hImageList, nint nIndex);

        /** <summary>
         * 获取图片句柄
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="nIndex">图片索引</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_get")]
        public static extern nint _imglist_get(nint hImageList, nint nIndex);

        /** <summary>
         * 设置图片
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="nIndex">图片索引</param>
         * <param name="lpImage">图片数据指针</param>
         * <param name="cbImage">图片数据长度</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_set")]
        public static extern bool _imglist_set(nint hImageList, nint nIndex, byte[] lpImage, int cbImage);

        /** <summary>
         * 设置图片
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="nIndex">图片索引</param>
         * <param name="hImage">图像对象句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_setimage")]
        public static extern bool _imglist_setimage(nint hImageList, nint nIndex, int hImage);

        /** <summary>
         * 获取图片组图片数量
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_count")]
        public static extern int _imglist_count(nint hImageList);

        /** <summary>
         * 获取图片组图片尺寸
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="pWidth">图片宽度</param>
         * <param name="pHeight">图片高度</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_count")]
        public static extern bool _imglist_size(nint hImageList, out int pWidth, out int pHeight);

        /** <summary>
         * 绘制图片(图片将被居中绘制到提供的矩形中)
         * </summary>
         * <param name="hImageList">图片组句柄</param>
         * <param name="nIndex">图片索引</param>
         * <param name="hCanvas">画布句柄</param>
         * <param name="nLeft">左边</param>
         * <param name="nTop">顶边</param>
         * <param name="nRight">右边</param>
         * <param name="nBottom">底边</param>
         * <param name="nAlpha">透明度0-255</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_imglist_draw")]
        public static extern bool _imglist_draw(nint hImageList, nint nIndex, int hCanvas, int nLeft, int nTop, int nRight, int nBottom, int nAlpha);

        /** <summary>
         * 是否允许启用输入法
         * </summary>
         * <param name="hObj"></param>
         * <param name="fEnable"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnableIME")]
        public static extern bool Ex_ObjEnableIME(int hObj, bool fEnable);

        /** <summary>
         * 设置窗口的输入法状态
         * </summary>
         * <param name="hObjOrExDui"></param>
         * <param name="fOpen"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetIMEState")]
        public static extern bool Ex_ObjSetIMEState(int hObjOrExDui, bool fOpen);

        /** <summary>
         * 设置控件是否禁止转换空格和回车为单击事件
         * </summary>
         * <param name="hObj"></param>
         * <param name="fDisable"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjDisableTranslateSpaceAndEnterToClick")]
        public static extern bool Ex_ObjDisableTranslateSpaceAndEnterToClick(int hObj, bool fDisable);

        /** <summary>
         * 设置画布文本抗锯齿模式
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="textAntialiasMode">0.不抗锯齿 1.抗锯齿 2.ClearType</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_settextantialiasmode")]
        public static extern bool _canvas_settextantialiasmode(int hCanvas, bool textAntialiasMode);

        /** <summary>
         * 设置画布图形抗锯齿
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="antialias">是否抗锯齿</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_setantialias")]
        public static extern bool _canvas_setantialias(int hCanvas, bool antialias);

        /** <summary>
         * 设置画布图像抗锯齿
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="antialias">是否抗锯齿</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_setimageantialias")]
        public static extern bool _canvas_setimageantialias(int hCanvas, bool antialias);

        /** <summary>
         * 置父
         * </summary>
         * <param name="hObj">被置父的子控件</param>
         * <param name="hParent">新的父控件/皮肤/窗口 句柄</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjSetParent")]
        public static extern bool Ex_ObjSetParent(int hObj, int hParent);

        /**
         * <param name="hPath">hPath</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_rgn_createfrompath")]
        public static extern nint _rgn_createfrompath(int hPath);

        /** <summary>
         * _res_pack
         * </summary>
         * <param name="root"></param>
         * <param name="file"></param>
         * <param name="fSubDir"></param>
         * <param name="byteHeader"></param>
         * <param name="bPntBits"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_res_pack")]
        public static extern void _res_pack(string root, string file, bool fSubDir, char byteHeader, bool bPntBits);

        /** <summary>
         * 加载图像对象自内存
         * </summary>
         * <param name="lpData"></param>
         * <param name="dwLen"></param>
         * <param name="uType">IMAGE_</param>
         * <param name="nIndex"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_LoadImageFromMemory")]
        public static extern nint Ex_LoadImageFromMemory(byte[] lpData, int dwLen, int uType, int nIndex);

        /** <summary>
         * 
         * </summary>
         * <param name="hImg"></param>
         * <param name="argb"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_changecolor")]
        public static extern bool _img_changecolor(int hImg, int argb);

        /** <summary>
         * 
         * </summary>
         * <param name="hImg"></param>
         * <param name="left"></param>
         * <param name="top"></param>
         * <param name="width"></param>
         * <param name="height"></param>
         * <param name="phImg"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_clip")]
        public static extern bool _img_clip(int hImg, int left, int top, int width, int height, out int phImg);

        /** <summary>
         * 
         * </summary>
         * <param name="hImg"></param>
         * <param name="lpwzFile"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_savetofile")]
        public static extern bool _img_savetofile(int hImg, string lpwzFile);

        /** <summary>
         * 
         * </summary>
         * <param name="hImg"></param>
         * <param name="lpBuffer"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_img_savetomemory")]
        public static extern nint _img_savetomemory(int hImg, out byte[] lpBuffer);

        /** <summary>
         * 
         * </summary>
         * <param name="hCanvas"></param>
         * <param name="sCanvas"></param>
         * <param name="dstLeft"></param>
         * <param name="dstTop"></param>
         * <param name="dstRight"></param>
         * <param name="dstBottom"></param>
         * <param name="srcLeft"></param>
         * <param name="srcTop"></param>
         * <param name="dwAlpha"></param>
         * <param name="dwCompositeMode">CV_COMPOSITE_MODE_</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_canvas_drawcanvas")]
        public static extern bool _canvas_drawcanvas(int hCanvas, int sCanvas, int dstLeft, int dstTop, int dstRight, int dstBottom, int srcLeft, int srcTop, int dwAlpha, int dwCompositeMode);

        /** <summary>
         * 添加弧 v2
         * </summary>
         * <param name="hPath"></param>
         * <param name="x"></param>
         * <param name="y"></param>
         * <param name="width">宽度</param>
         * <param name="height">高度</param>
         * <param name="startAngle">开始角度</param>
         * <param name="sweepAngle">扫描角度</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addarc2")]
        public static extern bool _path_addarc2(int hPath, float x, float y, float width, float height, float startAngle, float sweepAngle);

        /** <summary>
         * 添加弧 v2
         * </summary>
         * <param name="hPath"></param>
         * <param name="x">终点坐标X</param>
         * <param name="y">终点坐标Y</param>
         * <param name="radiusX">弧中心坐标X</param>
         * <param name="radiusY">弧中心坐标Y</param>
         * <param name="startAngle">开始角度</param>
         * <param name="sweepAngle">扫描角度</param>
         * <param name="fClockwise">是否顺时针</param>
         * <param name="barcSize">是否大于180°</param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "_path_addarc3")]
        public static extern bool _path_addarc3(nint hPath, float x, float y, float radiusX, float radiusY, float startAngle, float sweepAngle, bool fClockwise, bool barcSize);

        /** <summary>
         * 返回是否适用
         * </summary>
         * <param name="hObj"></param>
         * <param name="pDataObject"></param>
         * <param name="dwFormat"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjCheckDropFormat")]
        public static extern bool Ex_ObjCheckDropFormat(int hObj, nint pDataObject, int dwFormat);

        /** <summary>
         * 返回数据指针,注意自行释放,0表示失败
         * </summary>
         * <param name="hObj"></param>
         * <param name="pDataObject"></param>
         * <param name="dwFormat"></param>
         * <param name="pcbData"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetDropData")]
        public static extern nint Ex_ObjGetDropData(int hObj, int pDataObject, int dwFormat, out int pcbData);


        /** <summary>
         * 返回字符数,0表示失败
         * </summary>
         * <param name="hObj"></param>
         * <param name="pDataObject"></param>
         * <param name="lpwzBuffer"></param>
         * <param name="cchMaxLength"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjGetDropString")]
        public static extern int Ex_ObjGetDropString(int hObj, int pDataObject, StringBuilder lpwzBuffer, int cchMaxLength);


        /** <summary>
         * 设置控件是否启用绘画中消息
         * </summary>
         * <param name="hObj"></param>
         * <param name="fEnable"></param>
         **/
        [DllImport("libexdui.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, EntryPoint = "Ex_ObjEnablePaintingMsg")]
        public static extern bool Ex_ObjEnablePaintingMsg(int hObj, bool fEnable);
    }
}
