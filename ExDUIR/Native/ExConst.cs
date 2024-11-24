namespace ExDuiR.NET.Native
{
    /// <summary>
    /// ExDuiR常量声明
    /// </summary>
    public static class ExConst
    {
        #region 滚动条类型_
        /// <summary>
        /// 滚动条类型_水平滚动条
        /// </summary>
        ///
        public const int SCROLLBAR_TYPE_HORZ = 0;
        /// <summary>
        /// 滚动条类型_垂直滚动条
        /// </summary>
        ///
        public const int SCROLLBAR_TYPE_VERT = 1;
        /// <summary>
        /// 滚动条类型_滚动条控制器
        /// </summary>
        ///
        public const int SCROLLBAR_TYPE_CTL = 2;
        /// <summary>
        /// 滚动条类型_水平和垂直滚动条
        /// </summary>
        ///
        public const int SCROLLBAR_TYPE_BOTH = 3;
        #endregion

        #region 滚动条风格_
        /// <summary>
        /// 滚动条风格_水平滚动条
        /// </summary>
        ///
        public const int SCROLLBAR_STYLE_HORIZONTALSCROLL = 0;
        /// <summary>
        /// 滚动条风格_垂直滚动条
        /// </summary>
        ///
        public const int SCROLLBAR_STYLE_VERTICALSCROLL = 1;
        /// <summary>
        /// 滚动条风格_左顶对齐
        /// </summary>
        ///
        public const int SCROLLBAR_STYLE_LEFTTOPALIGN = 2;
        /// <summary>
        /// 滚动条风格_右底对齐
        /// </summary>
        ///
        public const int SCROLLBAR_STYLE_RIGHTBOTTOMALIGN = 4;
        /// <summary>
        /// 滚动条风格_控制按钮
        /// </summary>
        ///
        public const int SCROLLBAR_STYLE_CONTROLBUTTON = 8;
        #endregion

        #region 背景标识_
        /// <summary>
        /// 背景标识_默认
        /// </summary>
        ///
        public const int BACKGROUND_FLAG_DEFAULT = 0;
        /// <summary>
        /// 背景标识_播放动画
        /// </summary>
        ///
        public const int BACKGROUND_FLAG_PLAYIMAGE = 1;
        /// <summary>
        /// 背景标识_禁用缩放
        /// </summary>
        ///
        public const int BACKGROUND_FLAG_DISABLESCALE = 2;
        /// <summary>
        /// 背景标识_九宫矩形_排除中间区域
        /// </summary>
        ///
        public const int BACKGROUND_FLAG_GRID_EXCLUSION_CENTER = 4;
        /// <summary>
        /// 背景标识_X使用百分比单位
        /// </summary>
        ///
        public const int BACKGROUND_FLAG_POSITION_Y_PERCENT = 8;
        /// <summary>
        /// 背景标识_Y使用百分比单位
        /// </summary>
        ///
        public const int BACKGROUND_FLAG_POSITION_X_PERCENT = 16;
        #endregion

        #region 事件_
        /// <summary>
        /// 事件_创建
        /// </summary>
        public const int NM_CREATE = -99;

        /// <summary>
        /// 事件_销毁
        /// </summary>
        public const int NM_DESTROY = -98;

        /// <summary>
        /// 事件_计算尺寸
        /// </summary>
        public const int NM_CALCSIZE = -97;

        /// <summary>
        /// 事件_鼠标移动
        /// </summary>
        public const int NM_MOVE = -96;

        /// <summary>
        /// 事件_尺寸被改变
        /// </summary>
        public const int NM_SIZE = -95;

        /// <summary>
        /// 事件_禁止状态被改变
        /// </summary>
        public const int NM_ENABLE = -94;

        /// <summary>
        /// 事件_可视状态被改变
        /// </summary>
        public const int NM_SHOW = -93;

        /// <summary>
        /// 事件_左键被放开
        /// </summary>
        public const int NM_LUP = -92;

        /// <summary>
        /// 事件_离开组件
        /// </summary>
        public const int NM_LEAVE = -91;

        /// <summary>
        /// 事件_时钟
        /// </summary>
        public const int NM_TIMER = -90;

        /// <summary>
        /// 事件_选中
        /// </summary>
        public const int NM_CHECK = -89;

        /// <summary>
        /// 事件_托盘图标
        /// </summary>
        public const int NM_TRAYICON = -88;

        /// <summary>
        /// 事件_对话框初始化完毕
        /// </summary>
        public const int NM_INTDLG = -87;

        /// <summary>
        /// 事件_缓动
        /// </summary>
        public const int NM_EASING = -86;

        /// <summary>
        /// 事件_左键被单击
        /// </summary>
        public const int NM_CLICK = -2;

        /// <summary>
        /// 事件_左键被双击
        /// </summary>
        public const int NM_DBLCLK = -3;

        /// <summary>
        /// 事件_回车键被按下
        /// </summary>
        public const int NM_RETURN = -4;

        /// <summary>
        /// 事件_右键被单击
        /// </summary>
        public const int NM_RCLICK = -5;

        /// <summary>
        /// 事件_右键被双击
        /// </summary>
        public const int NM_RDBLCLK = -6;

        /// <summary>
        /// 事件_设置焦点
        /// </summary>
        public const int NM_SETFOCUS = -7;

        /// <summary>
        /// 事件_失去焦点
        /// </summary>
        public const int NM_KILLFOCUS = -8;

        /// <summary>
        /// 事件_自定义绘制
        /// </summary>
        public const int NM_CUSTOMDRAW = -12;

        /// <summary>
        /// 事件_进入组件
        /// </summary>
        public const int NM_HOVER = -13;

        /// <summary>
        /// 事件_点击测试
        /// </summary>
        public const int NM_NCHITTEST = -14;

        /// <summary>
        /// 事件_按下某键
        /// </summary>
        public const int NM_KEYDOWN = -15;

        /// <summary>
        /// 事件_取消鼠标捕获
        /// </summary>
        public const int NM_RELEASEDCAPTURE = -16;

        /// <summary>
        /// 事件_字符输入
        /// </summary>
        public const int NM_CHAR = -18;

        /// <summary>
        /// 事件_提示框即将弹出
        /// </summary>
        public const int NM_TOOLTIPSCREATED = -19;

        /// <summary>
        /// 事件_左键被按下
        /// </summary>
        public const int NM_LDOWN = -20;

        /// <summary>
        /// 事件_右键被按下
        /// </summary>
        public const int NM_RDOWN = -21;

        /// <summary>
        /// 事件_字体被改变
        /// </summary>
        public const int NM_FONTCHANGED = -23;

        /// <summary>
        /// 事件_编辑框_选择文本,lParam为ExSelChange结构体
        /// </summary>
        public const int NM_EN_SELCHANGE = 0x0702;

        /// <summary>
        /// 事件_编辑框_点击链接,lParam为ExEnLink结构体
        /// </summary>
        public const int NM_EN_LINK = 0x070b;
        #endregion

        #region 事件_卷帘菜单_
        /// <summary>
        /// 事件_卷帘菜单_单击子项 wParam: 子项索引 (索引从1开始,0为分组)  lParam: 分组索引 (索引从1开始)
        /// </summary>
        public const int ROLLMENU_EVENT_CLICK = -2;
        #endregion

        #region 消息_卷帘菜单_
        /// <summary>
        /// 消息_卷帘菜单_添加分组  wParam :索引(从1开始)  lParam: ROLLMENU_DATA * 指针
        /// </summary>
        public const int ROLLMENU_MESSAGE_ADDGROUP = 10010;
        /// <summary>
        /// 消息_卷帘菜单_添加子项  wParam :分组索引(从1开始)  lParam: ROLLMENU_ITEM * 指针
        /// </summary>
        public const int ROLLMENU_MESSAGE_ADDITEM = 10011;
        /// <summary>
        /// 消息_卷帘菜单_删除分组  wParam :分组索引(从1开始)  lParam:未定义   return: BOOL 
        /// </summary>
        public const int ROLLMENU_MESSAGE_DELGROUP = 10012;
        /// <summary>
        /// 消息_卷帘菜单_删除子项  wParam :分组索引(从1开始)  lParam:子项索引(从1开始) return: BOOL 
        /// </summary>
        public const int ROLLMENU_MESSAGE_DELITEM = 10013;
        /// <summary>
        /// 消息_卷帘菜单_设置分组状态(展开/收缩)  wParam :分组索引(从1开始)  lParam: 状态(BOOL)
        /// </summary>
        public const int ROLLMENU_MESSAGE_SETEXPAND = 10014;
        /// <summary>
        /// 消息_卷帘菜单_取当前选中子项  wParam: [int*] 分组索引(从1开始)  lParam: [int*] 子项索引(从1开始)  return:子项标题
        /// </summary>
        public const int ROLLMENU_MESSAGE_GETSEL = 10015;
        /// <summary>
        /// 消息_卷帘菜单_置当前选中子项  wParam: 分组索引(从1开始)  lParam : 子项索引(从1开始) return: BOOL
        /// </summary>
        public const int ROLLMENU_MESSAGE_SETSEL = 10016;
        #endregion

        #region 颜色索引_
        /// <summary>
        /// 颜色索引_背景颜色
        /// </summary>
        ///
        public const int COLOR_EX_BACKGROUND = 0;

        /// <summary>
        /// 颜色索引_边框颜色
        /// </summary>
        ///
        public const int COLOR_EX_BORDER = 1;

        /// <summary>
        /// 颜色索引_文本颜色_正常
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_NORMAL = 2;

        /// <summary>
        /// 颜色索引_文本颜色_悬浮
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_HOVER = 3;

        /// <summary>
        /// 颜色索引_文本颜色_按下
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_DOWN = 4;

        /// <summary>
        /// 颜色索引_文本颜色_焦点
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_FOCUS = 5;

        /// <summary>
        /// 颜色索引_文本颜色_选中
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_CHECKED = 6;

        /// <summary>
        /// 颜色索引_文本颜色_选择
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_SELECT = 7;

        /// <summary>
        /// 颜色索引_文本颜色_备用
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_RESERVE = 8;

        /// <summary>
        /// 颜色索引_文本颜色_已访问
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_VISTED = 9;

        /// <summary>
        /// 颜色索引_文本颜色_阴影
        /// </summary>
        ///
        public const int COLOR_EX_TEXT_SHADOW = 10;

        /// <summary>
        /// 颜色索引_报表_表头背景色
        /// </summary>
        ///
        public const int COLOR_EX_RLV_HEAD = 8;

        /// <summary>
        /// 颜色索引_编辑框_光标原色
        /// </summary>
        ///
        public const int COLOR_EX_EDIT_CARET = 30;

        /// <summary>
        /// 颜色索引_编辑框_提示文本颜色
        /// </summary>
        ///
        public const int COLOR_EX_EDIT_BANNER = 31;
        #endregion

        #region 组件风格_
        /// <summary>
        /// 组件风格_滚动条不可用时显示禁止状态
        /// </summary>
        public const int OBJECT_STYLE_DISABLENOSCROLL = 0x2000000;

        /// <summary>
        /// 组件风格_可调整尺寸
        /// </summary>
        public const int OBJECT_STYLE_SIZEBOX = 0x4000000;

        /// <summary>
        /// 组件风格_禁止
        /// </summary>
        public const int OBJECT_STYLE_DISABLED = 0x8000000;

        /// <summary>
        /// 组件风格_可视
        /// </summary>
        public const int OBJECT_STYLE_VISIBLE = 0x10000000;

        /// <summary>
        /// 组件风格_边框
        /// </summary>
        public const int OBJECT_STYLE_BORDER = 0x20000000;

        /// <summary>
        /// 组件风格_垂直滚动条
        /// </summary>
        public const int OBJECT_STYLE_VSCROLL = 0x40000000;

        /// <summary>
        /// 组件风格_水平滚动条
        /// </summary>
        public const int OBJECT_STYLE_HSCROLL = -2147483648;

        /// <summary>
        /// 组件风格_扩展_自适应尺寸
        /// </summary>
        public const int OBJECT_STYLE_EX_AUTOSIZE = 0x400000;

        /// <summary>
        /// 组件风格_扩展_鼠标穿透
        /// </summary>
        public const int OBJECT_STYLE_EX_TRANSPARENT = 0x800000;

        /// <summary>
        /// 组件风格_扩展_背景模糊
        /// </summary>
        public const int OBJECT_STYLE_EX_BLUR = 0x1000000;

        /// <summary>
        /// 组件风格_扩展_允许拖拽
        /// </summary>
        public const int OBJECT_STYLE_EX_DRAGDROP = 0x2000000;

        /// <summary>
        /// 组件风格_扩展_接收文件拖放
        /// </summary>
        public const int OBJECT_STYLE_EX_ACCEPTFILES = 0x4000000;

        /// <summary>
        /// 组件风格_扩展_允许焦点
        /// </summary>
        public const int OBJECT_STYLE_EX_FOCUSABLE = 0x8000000;

        /// <summary>
        /// 组件风格_扩展_允许TAB焦点
        /// </summary>
        public const int OBJECT_STYLE_EX_TABSTOP = 0x10000000;

        /// <summary>
        /// 组件风格_扩展_总在最前
        /// </summary>
        public const int OBJECT_STYLE_EX_TOPMOST = 0x20000000;

        /// <summary>
        /// 组件风格_扩展_背景混合
        /// </summary>
        public const int OBJECT_STYLE_EX_COMPOSITED = 0x40000000;

        /// <summary>
        /// 组件风格_扩展_自定义绘制
        /// </summary>
        public const int OBJECT_STYLE_EX_CUSTOMDRAW = -2147483648;
        #endregion

        #region 组件数值_
        /// <summary>
        /// 组件数值_组件节点ID
        /// </summary>
        ///
        public const int OBJECT_LONG_NODEID = -1;

        /// <summary>
        /// 组件数值_组件模糊系数
        /// </summary>
        ///
        public const int OBJECT_LONG_BLUR = -2;

        /// <summary>
        /// 组件数值_组件回调
        /// </summary>
        ///
        public const int OBJECT_LONG_OBJPROC = -4;

        /// <summary>
        /// 组件数值_组件透明度
        /// </summary>
        ///
        public const int OBJECT_LONG_ALPHA = -5;

        /// <summary>
        /// 组件数值_自定义参数
        /// </summary>
        ///
        public const int OBJECT_LONG_LPARAM = -7;

        /// <summary>
        /// 组件数值_父句柄
        /// </summary>
        ///
        public const int OBJECT_LONG_OBJPARENT = -8;

        /// <summary>
        /// 组件数值_组件文本格式
        /// </summary>
        ///
        public const int OBJECT_LONG_TEXTFORMAT = -11;

        /// <summary>
        /// 组件数值_组件ID
        /// </summary>
        ///
        public const int OBJECT_LONG_ID = -12;

        /// <summary>
        /// 组件数值_组件基本风格
        /// </summary>
        ///
        public const int OBJECT_LONG_STYLE = -16;

        /// <summary>
        /// 组件数值_组件字体句柄
        /// </summary>
        ///
        public const int OBJECT_LONG_HFONT = -19;

        /// <summary>
        /// 组件数值_组件扩展风格
        /// </summary>
        ///
        public const int OBJECT_LONG_EXSTYLE = -20;

        /// <summary>
        /// 组件数值_用户数据
        /// </summary>
        ///
        public const int OBJECT_LONG_USERDATA = -21;

        /// <summary>
        /// 组件数值_画布句柄（不要乱改）
        /// </summary>
        ///
        public const int OBJECT_LONG_HCANVAS = -22;

        /// <summary>
        /// 组件数值_控件数据（不要乱改）
        /// </summary>
        ///
        public const int OBJECT_LONG_OWNER = -23;

        /// <summary>
        /// 组件数值_组件状态
        /// </summary>
        ///
        public const int OBJECT_LONG_STATE = -24;

        /// <summary>
        /// 组件数值_组件标题内容指针
        /// </summary>
        ///
        public const int OBJECT_LONG_LPWZTITLE = -28;

        /// <summary>
        /// 组件数值_光标句柄
        /// </summary>
        ///
        public const int OBJECT_LONG_CURSOR = -17;
        #endregion

        #region 关联类型_
        /// <summary>
        /// 关联类型_子控件
        /// </summary>
        ///
        public const int GW_CHILD = 5;

        /// <summary>
        /// 关联类型_上一个兄弟
        /// </summary>
        ///
        public const int GW_HWNDPREV = 3;

        /// <summary>
        /// 关联类型_下一个兄弟
        /// </summary>
        ///
        public const int GW_HWNDNEXT = 2;

        #endregion

        #region 背景重复模式_
        /// <summary>
        /// 背景重复模式_默认(缩放)
        /// </summary>
        ///
        public const int BACKGROUND_REPEAT_ZOOM = 0;
        /// <summary>
        /// 背景重复模式_平铺不重复
        /// </summary>
        ///
        public const int BACKGROUND_REPEAT_NO_REPEAT = 1;
        /// <summary>
        /// 背景重复模式_水平、垂直重复平铺
        /// </summary>
        ///
        public const int BACKGROUND_REPEAT_REPEAT = 2;
        /// <summary>
        /// 背景重复模式_水平重复平铺
        /// </summary>
        ///
        public const int BACKGROUND_REPEAT_REPEAT_X = 3;
        /// <summary>
        /// 背景重复模式_垂直重复平铺
        /// </summary>
        ///
        public const int BACKGROUND_REPEAT_REPEAT_Y = 4;
        #endregion

        #region 编辑框风格_
        /// <summary>
        /// 编辑框风格_允许拖拽  
        /// </summary>
        ///
        public const int EDIT_STYLE_DISABLEDRAG = 1;
        /// <summary>
        /// 编辑框风格_密码输入
        /// </summary>
        ///
        public const int EDIT_STYLE_USEPASSWORD = 2;
        /// <summary>
        /// 编辑框风格_显示选择文本
        /// </summary>
        ///
        public const int EDIT_STYLE_HIDESELECTION = 4;
        /// <summary>
        /// 编辑框风格_丰富文本
        /// </summary>
        ///
        public const int EDIT_STYLE_RICHTEXT = 8;
        /// <summary>
        /// 编辑框风格_允许鸣叫
        /// </summary>
        ///
        public const int EDIT_STYLE_ALLOWBEEP = 16;
        /// <summary>
        /// 编辑框风格_只读
        /// </summary>
        ///
        public const int EDIT_STYLE_READONLY = 32;
        /// <summary>
        /// 编辑框风格_回车换行
        /// </summary>
        ///
        public const int EDIT_STYLE_NEWLINE = 64;
        /// <summary>
        /// 编辑框风格_数值输入
        /// </summary>
        ///
        public const int EDIT_STYLE_NUMERICINPUT = 128;
        /// <summary>
        /// 编辑框风格_自动选择字符
        /// </summary>
        ///
        public const int EDIT_STYLE_AUTOWORDSEL = 256;
        /// <summary>
        /// 编辑框风格_禁用右键默认菜单
        /// </summary>
        ///
        public const int EDIT_STYLE_DISABLEMENU = 512;
        /// <summary>
        /// 编辑框风格_解析URL
        /// </summary>
        ///
        public const int EDIT_STYLE_PARSEURL = 1024;
        /// <summary>
        /// 编辑框风格_允许TAB字符
        /// </summary>
        ///
        public const int EDIT_STYLE_ALLOWTAB = 2048;
        /// <summary>
        /// 编辑框风格_总是显示提示文本
        /// </summary>
        ///
        public const int EDIT_STYLE_SHOWTIPSALWAYS = 4096;
        /// <summary>
        /// 编辑框风格_隐藏插入符
        /// </summary>
        ///
        public const int EDIT_STYLE_HIDDENCARET = 8192;
        /// <summary>
        /// 编辑框风格_下划线
        /// </summary>
        ///
        public const int EDIT_STYLE_UNDERLINE = 16384;
        /// <summary>
        /// 编辑框风格_字母输入
        /// </summary>
        public const int EDIT_STYLE_LETTER = 32768;
        /// <summary>
        /// 编辑框风格_数字字母输入
        /// </summary>
        public const int EDIT_STYLE_NUMERIC_LETTER = 65536;
        #endregion

        #region 消息_列表_
        /// <summary>
        /// 消息_列表_获取表项 (LISTBUTTON wParam为项目索引, lParam为EX_REPORTLIST_ITEMINFO指针或EX_LISTBUTTON_ITEMINFO指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETITEM = 4101;
        /// <summary>
        /// 消息_列表_设置表项 (wParam为是否重画,lParam为EX_REPORTLIST_ITEMINFO或EX_LISTBUTTON_ITEMINFO指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETITEM = 4102;
        /// <summary>
        /// 消息_报表_获取表项文本 (wParam若不为0则为表项索引,lParam为EX_REPORTLIST_ITEMINFO指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETITEMTEXT = 4141;
        /// <summary>
        /// 消息_报表_设置表项文本 (wParam若不为0则为表项索引,lParam为EX_REPORTLIST_ITEMINFO指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETITEMTEXT = 4142;
        /// <summary>
        /// 消息_报表_插入列 (wParm为是否立即更新,lParam为EX_REPORTLIST_COLUMNINFO指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_INSERTCOLUMN = 4123;
        /// <summary>
        /// 消息_报表_删除列 (wParm为是否立即更新,lParam为列索引从1开始)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_DELETECOLUMN = 4124;
        /// <summary>
        /// 消息_报表_排序 (lParam为EX_REPORTLIST_SORTINFO指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SORTITEMS = 4144;
        /// <summary>
        /// 消息_列表_更新列表框
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_UPDATE = 4138;
        /// <summary>
        /// 消息_报表_删除所有列
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_DELETEALLCOLUMN = 4900;
        /// <summary>
        /// 消息_报表_获取列数
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETCOLUMNCOUNT = 4901;
        /// <summary>
        ///  消息_报表_获取列信息 (wParam为列索引,lParam为 EX_REPORTLIST_COLUMNINFO 指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETCOLUMN = 4121;
        /// <summary>
        /// 消息_报表_设置列信息 (wParam低位为列索引,高位为是否立即刷新,lParam为 EX_REPORTLIST_COLUMNINFO 指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETCOLUMN = 4122;
        /// <summary>
        /// 消息_报表_设置列标题 (wParam低位为列索引,高位为是否立即刷新,lParam为 宽文本指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETCOLUMNTEXT = 4904;
        /// <summary>
        /// 消息_报表_获取列标题 (wParam为列索引,lParam为 宽文本指针)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETCOLUMNTEXT = 4905;
        /// <summary>
        /// 消息_报表_获取列宽
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETCOLUMNWIDTH = 4125;
        /// <summary>
        /// 消息_报表_设置列宽 (wParam为列索引,lParam为 列宽)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETCOLUMNWIDTH = 4126;
        /// <summary>
        /// 消息_列表_设置表项高度 (lParam为新行高)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETITEMHEIGHT = 4908;
        /// <summary>
        /// 消息_列表_获取表项高度
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETITEMHEIGHT = 4909;
        /// <summary>
        /// 消息_列表_获取图片组
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETIMAGELIST = 4098;
        /// <summary>
        /// 消息_列表_设置图片组 (wParam为是否立即重画,lParam为图片组句柄)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETIMAGELIST = 4099;
        /// <summary>
        /// 消息_列表_命中测试 lParam为 返回列表命中测试_
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_HITTEST = 4114;
        /// <summary>
        /// 消息_列表_清空表项
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_DELETEALLITEMS = 4105;
        /// <summary>
        /// 消息_列表_删除表项,wParam为是否立即重画，lParam为删除的索引
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_DELETEITEM = 4104;
        /// <summary>
        /// 消息_报表_获取单元格信息   lParam: EX_REPORTLIST_CELLINFO
        /// </summary>
        public const int LISTVIEW_MESSAGE_GETCELL = 4106;
        /// <summary>
        /// 消息_报表_设置单元格信息   wParam:是否排除文本  lParam: EX_REPORTLIST_CELLINFO
        /// </summary>
        public const int LISTVIEW_MESSAGE_SETCELL = 4107;
        /// <summary>
        /// 消息_报表_获取单元格lParam   wParam :iRow lParam:iCol  return: LPARAM
        /// </summary>
        public const int LISTVIEW_MESSAGE_GETCELLLPARAM = 4108;
        /// <summary>
        /// 消息_报表_设置单元格lParam    wParam :新值  lParam: 低位 行 高位 列
        /// </summary>
        public const int LISTVIEW_MESSAGE_SETCELLLPARAM = 4109;
        /// <summary>
        /// 消息_列表_保证显示表项
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_ENSUREVISIBLE = 4115;
        /// <summary>
        /// 消息_列表_取可视区表项数
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETCOUNTPERPAGE = 4136;
        /// <summary>
        /// 消息_列表_取表项总数
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETITEMCOUNT = 4100;
        /// <summary>
        /// 消息_列表_取表项矩形
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETITEMRECT = 4110;
        /// <summary>
        /// 消息_列表_取被选择表项数
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETSELECTEDCOUNT = 4146;
        /// <summary>
        /// 消息_列表_取现行选中项
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETSELECTIONMARK = 4162;
        /// <summary>
        /// 置现行选择项目
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETSELECTIONMARK = 4163;
        /// <summary>
        /// 消息_列表_取可视区起始索引
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETTOPINDEX = 4135;
        /// <summary>
        /// 消息_列表_插入表项 lParam 为EX_REPORTLIST_ROWINFO指针,wParam为是否立即重画,返回索引
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_INSERTITEM = 4103;
        /// <summary>
        /// 消息_列表_重画表项 wParam为起始项目,lParam 为结束项目
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_REDRAWITEMS = 4117;
        /// <summary>
        /// 消息_列表_设置表项总数 wParam为表项条数,lParmam为MAKELONG(LVSICF_NOSCROLL, 表项条数)
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETITEMCOUNT = 4143;
        /// <summary>
        /// 消息_列表_取表项状态
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETITEMSTATE = 4140;
        /// <summary>
        /// 消息_列表_置表项状态
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_SETITEMSTATE = 4139;
        /// <summary>
        /// 消息_列表_取鼠标所在表项
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_GETHOTITEM = 4157;
        /// <summary>
        /// 消息_列表_重新计算尺寸
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_CALCITEMSIZE = 5150;
        /// <summary>
        /// 消息_列表_取消主题 不绘制列表主题 1为取消
        /// </summary>
        ///
        public const int LISTVIEW_MESSAGE_CANCELTHEME = 5151;
        #endregion

        #region 事件_列表_
        /// <summary>
        /// 事件_列表_现行选中项被改变,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LISTVIEW_EVENT_ITEMCHANGED = -101;
        /// <summary>
        /// 事件_列表_表项选中状态,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LISTVIEW_EVENT_ITEMSELECTD = -102;
        /// <summary>
        /// 事件_列表_表项选中状态取消,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LISTVIEW_EVENT_ITEMSELECTC = -103;
        /// <summary>
        /// 事件_列表_表项被右击,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LISTVIEW_EVENT_ITEMRCLICK = -104;
        /// <summary>
        /// 事件_列表_表项被双击,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LISTVIEW_EVENT_ITEMDCLICK = -105;
        /// <summary>
        /// 事件_列表_悬浮跟踪
        /// </summary>
        ///
        public const int LISTVIEW_EVENT_HOTTRACK = -121;
        #endregion

        #region 缓动类型_
        /// <summary>
        /// 缓动类型_线性
        /// </summary>
        ///
        public const int EASING_TYPE_LINEAR = 1;
        /// <summary>
        /// 缓动类型_圆线性插值
        /// </summary>
        ///
        public const int EASING_TYPE_CLERP = 2;
        /// <summary>
        /// 缓动类型_弹性
        /// </summary>
        ///
        public const int EASING_TYPE_SPRING = 3;
        /// <summary>
        /// 缓动类型_冲击
        /// </summary>
        ///
        public const int EASING_TYPE_PUNCH = 4;
        /// <summary>
        /// 缓动类型_二次方_In
        /// </summary>
        ///
        public const int EASING_TYPE_INQUAD = 5;
        /// <summary>
        /// 缓动类型_二次方_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTQUAD = 6;
        /// <summary>
        /// 缓动类型_二次方_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTQUAD = 7;
        /// <summary>
        /// 缓动类型_三次方_In
        /// </summary>
        ///
        public const int EASING_TYPE_INCUBIC = 8;
        /// <summary>
        /// 缓动类型_三次方_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTCUBIC = 9;
        /// <summary>
        /// 缓动类型_三次方_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTCUBIC = 10;
        /// <summary>
        /// 缓动类型_四次方_In
        /// </summary>
        ///
        public const int EASING_TYPE_INQUART = 11;
        /// <summary>
        /// 缓动类型_四次方_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTQUART = 12;
        /// <summary>
        /// 缓动类型_四次方_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTQUART = 13;
        /// <summary>
        /// 缓动类型_五次方_In
        /// </summary>
        ///
        public const int EASING_TYPE_INQUINT = 14;
        /// <summary>
        /// 缓动类型_五次方_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTQUINT = 15;
        /// <summary>
        /// 缓动类型_五次方_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTQUINT = 16;
        /// <summary>
        /// 缓动类型_正弦曲线_In
        /// </summary>
        ///
        public const int EASING_TYPE_INSINE = 17;
        /// <summary>
        /// 缓动类型_正弦曲线_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTSINE = 18;
        /// <summary>
        /// 缓动类型_正弦曲线_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTSINE = 19;
        /// <summary>
        /// 缓动类型_指数曲线_In
        /// </summary>
        ///
        public const int EASING_TYPE_INEXPO = 20;
        /// <summary>
        /// 缓动类型_指数曲线_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTEXPO = 21;
        /// <summary>
        /// 缓动类型_指数曲线_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTEXPO = 22;
        /// <summary>
        /// 缓动类型_圆曲线_In
        /// </summary>
        ///
        public const int EASING_TYPE_INCIRC = 23;
        /// <summary>
        /// 缓动类型_圆曲线_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTCIRC = 24;
        /// <summary>
        /// 缓动类型_圆曲线_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTCIRC = 25;
        /// <summary>
        /// 缓动类型_反弹_In
        /// </summary>
        ///
        public const int EASING_TYPE_INBOUNCE = 26;
        /// <summary>
        /// 缓动类型_反弹_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTBOUNCE = 27;
        /// <summary>
        /// 缓动类型_反弹_InOuts
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTBOUNCE = 28;
        /// <summary>
        /// 缓动类型_三次方溢出_In
        /// </summary>
        ///
        public const int EASING_TYPE_INBACK = 29;
        /// <summary>
        /// 缓动类型_三次方溢出_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTBACK = 30;
        /// <summary>
        /// 缓动类型_三次方溢出_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTBACK = 31;
        /// <summary>
        /// 缓动类型_正弦曲线指数衰减_In
        /// </summary>
        ///
        public const int EASING_TYPE_INELASTIC = 32;
        /// <summary>
        /// 缓动类型_正弦曲线指数衰减_Out
        /// </summary>
        ///
        public const int EASING_TYPE_OUTELASTIC = 33;
        /// <summary>
        /// 缓动类型_正弦曲线指数衰减_InOut
        /// </summary>
        ///
        public const int EASING_TYPE_INOUTELASTIC = 34;
        /// <summary>
        /// 缓动类型_自定义 pEasingContext为自定义回调函数(nProcess,nStart,nStop,nCurrent,pEasingContext)
        /// </summary>
        ///
        public const int EASING_TYPE_CUSTOM = 50;
        /// <summary>
        /// 缓动类型_曲线 pEasingContext为pCurveInfo(_easing_load_curve)
        /// </summary>
        ///
        public const int EASING_TYPE_CURVE = 51;
        #endregion

        #region 缓动模式_
        //<summary>
        ///// 缓动模式_单次
        //</summary>
        public const int EASING_MODE_SINGLE = 1;
        /// <summary>
        /// 缓动模式_循环,注意自行停止
        /// </summary>
        ///
        public const int EASING_MODE_CYCLE = 2;
        /// <summary>
        /// 缓动模式_多次,高位则为次数
        /// </summary>
        ///
        public const int EASING_MODE_MANYTIMES = 4;
        /// <summary>
        /// 缓动模式_顺序
        /// </summary>
        ///
        public const int EASING_MODE_ORDER = 8;
        /// <summary>
        /// 缓动模式_逆序
        /// </summary>
        ///
        public const int EASING_MODE_REVERSE = 16;
        /// <summary>
        /// 缓动模式_来回
        /// </summary>
        ///
        public const int EASING_MODE_BACKANDFORTH = 32;
        /// <summary>
        /// 缓动模式_调用函数 pContext为回调函数,bool isStop Cbk(pEasingProgress,double nProgress,double nCurrent,pEasingContext,nTimesSurplus,Param1,Param2,Param3,Param4)
        /// </summary>
        ///
        public const int EASING_MODE_CALLFUNCTION = 64;
        /// <summary>
        /// 缓动模式_分发消息 pContext为hObj或hExDUI, wParam:pEasing,lParam:lpEasingInfo,result:isStop
        /// </summary>
        ///
        public const int EASING_MODE_DISPATCHNOTIFY = 128;
        /// <summary>
        /// 缓动模式_使用线程 使用线程处理,否则在UI线程处理(过程中会阻塞输入)
        /// </summary>
        ///
        public const int EASING_MODE_THREAD = 256;
        /// <summary>
        /// 缓动模式_释放曲线 当使用曲线类型时生效,在结束时会自动释放曲线指针
        /// </summary>
        ///
        public const int EASING_MODE_RELEASECURVE = 512;
        #endregion

        #region 缓动状态_
        /// <summary>
        /// 缓动状态_播放    
        /// </summary>
        ///
        public const int EASING_STATE_PLAY = 0;
        /// <summary>
        /// 缓动状态_暂停
        /// </summary>
        ///
        public const int EASING_STATE_PAUSE = 1;
        /// <summary>
        /// 缓动状态_停止
        /// </summary>
        ///
        public const int EASING_STATE_STOP = 2;
        #endregion

        #region 布局类型_
        /// <summary>
        /// 布局类型_无
        /// </summary>
        ///
        public const int LAYOUT_TYPE_NULL = 0;

        /// <summary>
        /// 布局类型_线性
        /// </summary>
        ///
        public const int LAYOUT_TYPE_LINEAR = 1;

        /// <summary>
        /// 布局类型_流式
        /// </summary>
        ///
        public const int LAYOUT_TYPE_FLOW = 2;

        /// <summary>
        /// 布局类型_页面
        /// </summary>
        ///
        public const int LAYOUT_TYPE_PAGE = 3;

        /// <summary>
        /// 布局类型_表格
        /// </summary>
        ///
        public const int LAYOUT_TYPE_TABLE = 4;

        /// <summary>
        /// 布局类型_相对
        /// </summary>
        ///
        public const int LAYOUT_TYPE_RELATIVE = 5;

        /// <summary>
        /// 布局类型_绝对
        /// </summary>
        ///
        public const int LAYOUT_TYPE_ABSOLUTE = 6;
        #endregion

        #region 布局属性_
        /// <summary>
        /// 布局属性_通用_内间距_左
        /// </summary>
        ///
        public const int LAYOUT_PROP_PADDING_LEFT = -1;
        /// <summary>
        /// 布局属性_通用_内间距_顶
        /// </summary>
        ///
        public const int LAYOUT_PROP_PADDING_TOP = -2;
        /// <summary>
        /// 布局属性_通用_内间距_右
        /// </summary>
        ///
        public const int LAYOUT_PROP_PADDING_RIGHT = -3;
        /// <summary>
        /// 布局属性_通用_内间距_底
        /// </summary>
        ///
        public const int LAYOUT_PROP_PADDING_BOTTOM = -4;
        /// <summary>
        /// 布局属性:方向
        /// </summary>
        ///
        public const int LAYOUT_PROP_LINEAR_DIRECTION = 1;
        /// <summary>
        /// 方向:水平
        /// </summary>
        ///
        public const int LAYOUT_PROP_DIRECTION_H = 0;
        /// <summary>
        /// 方向:垂直
        /// </summary>
        ///
        public const int LAYOUT_PROP_DIRECTION_V = 1;
        /// <summary>
        /// 布局属性:布局方向对齐方式
        /// </summary>
        ///
        public const int LAYOUT_PROP_LINEAR_DALIGN = 2;
        /// <summary>
        /// 线性布局对齐方式_左上
        /// </summary>
        ///
        public const int LAYOUT_PROP_LINEAR_DALIGN_LEFT_TOP = 0;
        /// <summary>
        /// 线性布局对齐方式_居中
        /// </summary>
        ///
        public const int LAYOUT_PROP_LINEAR_DALIGN_CENTER = 1;
        /// <summary>
        /// 线性布局对齐方式_右下
        /// </summary>
        ///
        public const int LAYOUT_PROP_LINEAR_DALIGN_RIGHT_BOTTOM = 2;
        /// <summary>
        /// 布局属性:方向
        /// </summary>
        ///
        public const int LAYOUT_PROP_FLOW_DIRECTION = 1;
        /// <summary>
        /// 布局属性:当前显示页面索引
        /// </summary>
        ///
        public const int LAYOUT_PROP_PAGE_CURRENT = 1;
        #endregion

        #region 布局子属性_
        /// <summary>
        /// 布局子属性_通用_外间距_左
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_MARGIN_LEFT = -1;
        /// <summary>
        /// 布局子属性_通用_外间距_顶
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_MARGIN_TOP = -2;
        /// <summary>
        /// 布局子属性_通用_外间距_右
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_MARGIN_RIGHT = -3;
        /// <summary>
        /// 布局子属性_通用_外间距_底
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_MARGIN_BOTTOM = -4;
        /// <summary>
        /// 线性布局子属性_尺寸 [-1或未填写为组件当前尺寸]
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_LINEAR_SIZE = 1;
        /// <summary>
        /// 线性布局另一个方向对齐方式_填满
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_LINEAR_ALGIN_FILL = 0;
        /// <summary>
        /// 线性布局另一个方向对齐方式_左上
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_LINEAR_ALIGN_LEFT_TOP = 1;
        /// <summary>
        /// 线性布局另一个方向对齐方式_居中
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_LINEAR_ALIGN_CENTER = 2;
        /// <summary>
        /// 线性布局另一个方向对齐方式_右下
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_LINEAR_ALIGN_RIGHT_BOTTOM = 3;
        /// <summary>
        /// 布局子属性:另外一个方向的对齐方式
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_LINEAR_ALIGN = 2;
        /// <summary>
        /// 布局子属性:尺寸[-1或未填写为组件当前尺寸]
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_FLOW_SIZE = 1;
        /// <summary>
        /// 布局子属性:组件强制换行
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_FLOW_NEW_LINE = 2;
        /// <summary>
        /// 布局子属性:是否填充整个布局
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_PAGE_FILL = 1;
        /// <summary>
        /// 布局子属性_表格_所在行
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_TABLE_ROW = 1;
        /// <summary>
        /// 布局子属性_表格_所在列
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_TABLE_CELL = 2;
        /// <summary>
        /// 布局子属性_表格_跨行数
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_TABLE_ROW_SPAN = 3;
        /// <summary>
        /// 布局子属性_表格_跨列数
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_TABLE_CELL_SPAN = 4;
        /// <summary>
        /// 布局子属性_表格_是否填满
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_TABLE_FILL = 5;
        /// <summary>
        /// 布局子属性_相对_左侧于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_LEFT_OF = 1;
        /// <summary>
        /// 布局子属性_相对_之上于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_TOP_OF = 2;
        /// <summary>
        /// 布局子属性_相对_右侧于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_RIGHT_OF = 3;
        /// <summary>
        /// 布局子属性_相对_之下于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_BOTTOM_OF = 4;
        /// <summary>
        /// 布局子属性_相对_左对齐于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_LEFT_ALIGN_OF = 5;
        /// <summary>
        /// 布局子属性_相对_顶对齐于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_TOP_ALIGN_OF = 6;
        /// <summary>
        /// 布局子属性_相对_右对齐于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_RIGHT_ALIGN_OF = 7;
        /// <summary>
        /// 布局子属性_相对_底对齐于(组件)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_BOTTOM_ALIGN_OF = 8;
        /// <summary>
        /// 布局子属性_相对_水平居中于父
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_CENTER_PARENT_H = 9;
        /// <summary>
        /// 布局子属性_相对_垂直居中于父
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_RELATIVE_CENTER_PARENT_V = 10;
        /// <summary>
        /// 布局子属性_绝对_左侧
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_LEFT = 1;
        /// <summary>
        /// 布局子属性_绝对_左侧类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_LEFT_TYPE = 2;
        /// <summary>
        /// 布局子属性_绝对_顶部
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_TOP = 3;
        /// <summary>
        /// 布局子属性_绝对_顶部类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_TOP_TYPE = 4;
        /// <summary>
        /// 布局子属性_绝对_右侧
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_RIGHT = 5;
        /// <summary>
        /// 布局子属性_绝对_右侧类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_RIGHT_TYPE = 6;
        /// <summary>
        /// 布局子属性_绝对_底部
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_BOTTOM = 7;
        /// <summary>
        /// 布局子属性_绝对_底部类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_BOTTOM_TYPE = 8;
        /// <summary>
        /// 布局子属性_绝对_宽度（优先级低于右侧）
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_WIDTH = 9;
        /// <summary>
        /// 布局子属性_绝对_宽度类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_WIDTH_TYPE = 10;
        /// <summary>
        /// 布局子属性_绝对_高度（优先级低于底部）
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_HEIGHT = 11;
        /// <summary>
        /// 布局子属性_绝对_高度类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_HEIGHT_TYPE = 12;
        /// <summary>
        /// 布局属性_绝对_水平偏移量
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_OFFSET_H = 13;
        /// <summary>
        /// 布局子属性_绝对_水平偏移量类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_OFFSET_H_TYPE = 14;
        /// <summary>
        /// 布局子属性_绝对_垂直偏移量
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_OFFSET_V = 15;
        /// <summary>
        /// 布局子属性_绝对_垂直偏移量类型
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_OFFSET_V_TYPE = 16;
        /// <summary>
        /// 布局子属性_绝对_类型_未知(未设置或保持不变)
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_TYPE_UNKNOWN = 0;
        /// <summary>
        /// 布局子属性_绝对_类型_像素
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_TYPE_PX = 1;
        /// <summary>
        /// 布局子属性_绝对_类型_百分比
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_TYPE_PS = 2;
        /// <summary>
        /// 布局子属性_绝对_类型_组件尺寸百分比，仅OFFSET可用
        /// </summary>
        ///
        public const int LAYOUT_SUBPROP_ABSOLUTE_TYPE_OBJPS = 3;
        #endregion

        #region 信息框图标标识_
        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_OK = 0;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_YESNO = 4;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_YESNOCANCEL = 3;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_OKCANCEL = 1;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_ICONERROR = 16;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_ICONWARNING = 48;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_ICONQUESTION = 32;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_ICONINFORMATION = 64;


        public const int MB_USERICON = 128;

        /// <summary>
        /// 
        /// </summary>
        ///
        public const int MB_TOPMOST = 262144;
        #endregion

        #region 信息框返回钮_
        /// <summary>
        /// 信息框返回钮_是钮
        /// </summary>
        ///
        public const int IDYES = 6;
        /// <summary>
        /// 信息框返回钮_否钮
        /// </summary>
        ///
        public const int IDNO = 7;
        /// <summary>
        /// 信息框返回钮_取消钮
        /// </summary>
        ///
        public const int IDCANCEL = 2;
        /// <summary>
        /// 信息框返回钮_确认钮
        /// </summary>
        ///
        public const int IDOK = 1;
        /// <summary>
        /// 信息框返回钮_关闭钮
        /// </summary>
        ///
        public const int IDCLOSE = 8;
        /// <summary>
        /// 信息框返回钮_默认
        /// </summary>
        ///
        public const int NULL = 0;
        #endregion

        #region 进度条属性 PBL
        /// <summary>
        /// 进度条属性_位置
        /// </summary>
        ///
        public const int PROGRESSBAR_LONG_POS = 0;
        /// <summary>
        /// 进度条属性_范围
        /// </summary>
        ///
        public const int PROGRESSBAR_LONG_RANGE = 1;
        /// <summary>
        /// 进度条属性_圆角度
        /// </summary>
        ///
        public const int PROGRESSBAR_LONG_RADIUS = 2;
        /// <summary>
        /// 进度条属性_背景颜色
        /// </summary>
        ///
        public const int PROGRESSBAR_LONG_BACKGROUNDCOLOR = 3;
        /// <summary>
        /// 进度条属性_前景颜色
        /// </summary>
        ///
        public const int PROGRESSBAR_LONG_FOREGROUNDCOLOR = 4;
        #endregion

        #region 信息框标识_
        /// <summary>
        /// 信息框标识_显示窗口图标
        /// </summary>
        ///
        public const int MESSAGEBOX_FLAG_WINDOWICON = -2147483648;
        /// <summary>
        /// 信息框标识_消息框居父窗口中间
        /// </summary>
        ///
        public const int MESSAGEBOX_FLAG_CENTEWINDOW = 1073741824;
        /// <summary>
        /// 信息框标识_显示倒计时
        /// </summary>
        ///
        public const int MESSAGEBOX_FLAG_SHOWTIMEOUT = 536870912;
        #endregion

        #region 菜单标识_
        /// <summary>
        /// 菜单标识_不显示菜单阴影
        /// </summary>
        ///
        public const int MENU_FLAG_NOSHADOW = -2147483648;
        #endregion

        #region 引擎标识_
        /// <summary>
        /// 引擎标识_启用DPI缩放
        /// </summary>
        ///
        public const int ENGINE_FLAG_DPI_ENABLE = 0x02;

        /// <summary>
        /// 引擎标识_渲染_画布不抗锯齿
        /// </summary>
        ///
        public const int ENGINE_FLAG_RENDER_CANVAS_ALIAS = 0x40;

        /// <summary>
        /// 引擎标识_渲染_使用D2D
        /// </summary>
        ///
        public const int ENGINE_FLAG_RENDER_METHOD_D2D = 0x100;

        /// <summary>
        /// 引擎标识_渲染_使用支持GDI交互的D2D渲染
        /// </summary>
        ///
        public const int ENGINE_FLAG_RENDER_METHOD_D2D_GDI_COMPATIBLE = 0x300;

        /// <summary>
        /// 引擎标识_文本渲染_使用ClearType抗锯齿
        /// </summary>
        ///
        public const int ENGINE_FLAG_TEXT_CLEARTYPE = 0x400;

        /// <summary>
        /// 引擎标识_文本渲染_抗锯齿
        /// </summary>
        ///
        public const int ENGINE_FLAG_TEXT_ANTIALIAS = 0x800;

        /// <summary>
        /// 引擎标识_图像渲染_抗锯齿
        /// </summary>
        ///
        public const int ENGINE_FLAG_IMAGE_ANTIALIAS = 0x1000;

        /// <summary>
        /// 引擎标识_组件_禁用动画效果
        /// </summary>
        ///
        public const int ENGINE_FLAG_OBJECT_DISABLEANIMATION = 0x10000;

        /// <summary>
        /// 引擎标识_组件_显示组件边界
        /// </summary>
        ///
        public const int ENGINE_FLAG_OBJECT_SHOWRECTBORDER = 0x20000;

        /// <summary>
        /// 引擎标识_组件_显示组件位置
        /// </summary>
        ///
        public const int ENGINE_FLAG_OBJECT_SHOWPOSTION = 0x40000;

        /// <summary>
        /// 引擎标识_允许JS全局对象访问文件
        /// </summary>
        ///
        public const int ENGINE_FLAG_JS_FILE = 0x80000;

        /// <summary>
        /// 引擎标识_允许JS全局对象访问内存
        /// </summary>
        ///
        public const int ENGINE_FLAG_JS_MEMORY = 0x100000;

        /// <summary>
        /// 引擎标识_允许JS全局对象申请内存
        /// </summary>
        ///
        public const int ENGINE_FLAG_JS_MEMORY_ALLOC = 0x200000;

        /// <summary>
        /// 引擎标识_允许JS全局对象创建进程、允许程序、加载DLL
        /// </summary>
        ///
        public const int ENGINE_FLAG_JS_PROCESS = 0x400000;

        /// <summary>
        /// 引擎标识_允许JS全局对象访问所有资源
        /// </summary>
        ///
        public const int ENGINE_FLAG_JS_ALL = 0x780000;

        /// <summary>
        /// 引擎标识_菜单_渲染所有菜单
        /// </summary>
        ///
        public const int ENGINE_FLAG_MENU_ALL = 0x800000;
        #endregion

        #region 窗体风格_
        /// <summary>
        /// 窗体风格_关闭按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_CLOSE = 0x01;

        /// <summary>
        /// 窗体风格_最大化按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_MAX = 0x02;

        /// <summary>
        /// 窗体风格_最小化按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_MIN = 0x04;

        /// <summary>
        /// 窗体风格_菜单按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_MENU = 0x08;

        /// <summary>
        /// 窗体风格_皮肤按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_SKIN = 0x10;

        /// <summary>
        /// 窗体风格_设置按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_SETTING = 0x20;

        /// <summary>
        /// 窗体风格_帮助按钮
        /// </summary>
        ///
        public const int WINDOW_STYLE_BUTTON_HELP = 0x40;

        /// <summary>
        /// 窗体风格_图标
        /// </summary>
        ///
        public const int WINDOW_STYLE_HASICON = 0x80;

        /// <summary>
        /// 窗体风格_标题
        /// </summary>
        ///
        public const int WINDOW_STYLE_TITLE = 0x100;

        /// <summary>
        /// 窗体风格_全屏模式.设置该标记窗口最大化时
        /// </summary>
        ///
        public const int WINDOW_STYLE_FULLSCREEN = 0x200;

        /// <summary>
        /// 窗体风格_允许调整尺寸
        /// </summary>
        ///
        public const int WINDOW_STYLE_SIZEABLE = 0x400;

        /// <summary>
        /// 窗体风格_允许随意移动
        /// </summary>
        ///
        public const int WINDOW_STYLE_MOVEABLE = 0x800;

        /// <summary>
        /// 窗体风格_不显示窗口阴影
        /// </summary>
        ///
        public const int WINDOW_STYLE_NOSHADOW = 0x1000;

        /// <summary>
        /// 窗体风格_不继承父窗口背景数据
        /// </summary>
        ///
        public const int WINDOW_STYLE_NOINHERITBKG = 0x2000;

        /// <summary>
        /// 窗体风格_不显示TAB焦点边框
        /// </summary>
        ///
        public const int WINDOW_STYLE_NOTABBORDER = 0x4000;

        /// <summary>
        /// 窗体风格_ESC关闭窗口
        /// </summary>
        ///
        public const int WINDOW_STYLE_ESCEXIT = 0x8000;

        /// <summary>
        /// 窗体风格_主窗口(拥有该风格时 当窗口被关闭,会调用PostQuitMessage()退出消息循环)
        /// </summary>
        ///
        public const int WINDOW_STYLE_MAINWINDOW = 0x10000;

        /// <summary>
        /// 窗体风格_窗口居中(如果有父窗口则在父窗口中间,否则为屏幕中间)
        /// </summary>
        ///
        public const int WINDOW_STYLE_CENTERWINDOW = 0x20000;

        /// <summary>
        /// 窗体风格_标题栏取消置顶
        /// </summary>
        ///
        public const int WINDOW_STYLE_NOCAPTIONTOPMOST = 0x40000;

        /// <summary>
        /// 窗体风格_弹出式窗口
        /// </summary>
        ///
        public const int WINDOW_STYLE_POPUPWINDOW = 0x80000;
        #endregion

        #region 引擎数值_
        /// <summary>
        /// 引擎数值_背景模糊
        /// </summary>
        public const int ENGINE_LONG_BLUR = -2;

        /// <summary>
        /// 引擎数值_窗口消息过程
        /// </summary>
        public const int ENGINE_LONG_MSGPROC = -4;

        /// <summary>
        /// 引擎数值_窗口透明度
        /// </summary>
        public const int ENGINE_LONG_ALPHA = -5;

        /// <summary>
        /// 引擎数值_自定义参数
        /// </summary>
        public const int ENGINE_LONG_LPARAM = -7;

        /// <summary>
        /// 引擎数值_阴影圆角大小
        /// </summary>
        public const int ENGINE_LONG_RADIUS = -11;

        /// <summary>
        /// 引擎数值_边框颜色
        /// </summary>
        public const int ENGINE_LONG_CRBORDER = -30;

        /// <summary>
        /// 引擎数值_背景颜色
        /// </summary>
        public const int ENGINE_LONG_CRBKG = -31;

        /// <summary>
        /// 引擎数值_最小高度
        /// </summary>
        public const int ENGINE_LONG_MINHEIGHT = -33;

        /// <summary>
        /// 引擎数值_最小宽度
        /// </summary>
        public const int ENGINE_LONG_MINWIDTH = -34;

        /// <summary>
        /// 引擎数值_阴影颜色
        /// </summary>
        public const int ENGINE_LONG_CRSD = -35;

        /// <summary>
        /// 引擎数值_焦点组件组件
        /// </summary>
        public const int ENGINE_LONG_OBJFOCUS = -53;

        /// <summary>
        /// 引擎数值_标题栏组件句柄
        /// </summary>
        public const int ENGINE_LONG_OBJCAPTION = -54;
        #endregion

        #region 消息_扩展_
        /// <summary>
        /// 消息_扩展_左键单击组件
        /// </summary>
        public const int WM_EX_LCLICK = -3;

        /// <summary>
        /// 消息_扩展_右键单击组件
        /// </summary>
        public const int WM_EX_RCLICK = -4;

        /// <summary>
        /// 消息_扩展_中键单击组件
        /// </summary>
        public const int WM_EX_MCLICK = -5;

        /// <summary>
        /// 消息_扩展_弹出式窗口已经初始化完毕
        /// </summary>
        public const int WM_EX_INITPOPUP = -6;

        /// <summary>
        /// 消息_扩展_弹出式窗口即将销毁 (wParam=0:即将销毁.wParam=1:是否可销毁,返回1则取消销毁)
        /// </summary>
        public const int WM_EX_EXITPOPUP = -7;

        /// <summary>
        /// 消息_扩展_缓动消息,发给控件用这个,窗口是EMT_EASING转NM_EASING
        /// </summary>
        public const int WM_EX_EASING = -8;

        /// <summary>
        /// 消息_扩展_控件接收到拖放(lParam为EX_DROPINFO结构体,若处理后应当返回 DROPEFFECT_开头的常量)
        /// </summary>
        public const int WM_EX_DROP = -9;

        /// <summary>
        /// 消息_扩展_控件绘制中事件,(wParam为绘制进度,lParam为EX_PAINTSTRUCT指针)
        /// </summary>
        public const int WM_EX_PAINTING = -10;

        /// <summary>
        /// 消息_扩展_属性消息 lParam为EX_OBJ_PROPS结构体
        /// </summary>
        public const int WM_EX_PROPS = -11;
        #endregion

        #region 按钮风格_
        /// <summary>
        /// 按钮风格_复选按钮
        /// </summary>
        public const int BUTTON_STYLE_CHECKBUTTON = 1;
        /// <summary>
        /// 按钮风格_单选按钮
        /// </summary>
        public const int BUTTON_STYLE_RADIOBUTTON = 2;
        /// <summary>
        /// 按钮风格_文本偏移
        /// </summary>
        public const int BUTTON_STYLE_TEXTOFFSET = 4;
        /// <summary>
        /// 按钮风格_图标在右
        /// </summary>
        public const int BUTTON_STYLE_ICONRIGHT = 8;
        #endregion

        #region 状态_
        /// <summary>
        /// 状态_正常
        /// </summary>
        public const int STATE_NORMAL = 0;
        /// <summary>
        /// 状态_禁止
        /// </summary>
        public const int STATE_DISABLE = 0x01;
        /// <summary>
        /// 状态_选择
        /// </summary>
        public const int STATE_SELECT = 0x02;
        /// <summary>
        /// 状态_焦点
        /// </summary>
        public const int STATE_FOCUS = 0x04;
        /// <summary>
        /// 状态_按下
        /// </summary>
        public const int STATE_DOWN = 0x08;
        /// <summary>
        /// 状态_选中
        /// </summary>
        public const int STATE_CHECKED = 0x10;
        /// <summary>
        /// 状态_半选中
        /// </summary>
        public const int STATE_HALFSELECT = 0x20;
        /// <summary>
        /// 状态_只读
        /// </summary>
        public const int STATE_READONLY = 0x40;
        /// <summary>
        /// 状态_悬浮
        /// </summary>
        public const int STATE_HOVER = 0x80;
        /// <summary>
        /// 状态_默认
        /// </summary>
        public const int STATE_DEFAULT = 0x100;
        /// <summary>
        /// 状态_子项目_可视
        /// </summary>
        public const int STATE_SUBITEM_VISIABLE = 0x200;
        /// <summary>
        /// 状态_子项目_隐藏
        /// </summary>
        public const int STATE_SUBITEM_HIDDEN = 0x400;
        /// <summary>
        /// 状态_繁忙中
        /// </summary>
        public const int STATE_BUSY = 0x800;
        /// <summary>
        /// 状态_滚动中
        /// </summary>
        public const int STATE_ROLLING = 0x2000;
        /// <summary>
        /// 状态_动画中
        /// </summary>
        public const int STATE_ANIMATING = 0x4000;
        /// <summary>
        /// 状态_隐藏
        /// </summary>
        public const int STATE_HIDDEN = 0x8000;
        /// <summary>
        /// 状态_允许修改尺寸
        /// </summary>
        public const int STATE_ALLOWSIZE = 0x20000;
        /// <summary>
        /// 状态_允许拖动
        /// </summary>
        public const int STATE_ALLOWDRAG = 0x40000;
        /// <summary>
        /// 状态_允许焦点
        /// </summary>
        public const int STATE_ALLOWFOCUS = 0x100000;
        /// <summary>
        /// 状态_允许选择
        /// </summary>
        public const int STATE_ALLOWSELECT = 0x200000;
        /// <summary>
        /// 状态_超链接_悬浮
        /// </summary>
        public const int STATE_HYPERLINK_HOVER = 0x400000;
        /// <summary>
        /// 状态_超链接_已访问
        /// </summary>
        public const int STATE_HYPERLINK_VISITED = 0x800000;
        /// <summary>
        /// 状态_允许多选
        /// </summary>
        public const int STATE_ALLOWMULTIPLE = 0x1000000;
        /// <summary>
        /// 状态_密码模式
        /// </summary>
        public const int STATE_PASSWORD = 0x2000000;
        #endregion

        #region 绘制进度_
        /// <summary>
        /// 绘制进度_当控件开始绘制后
        /// </summary>
        public const int PAINT_PROGRESS_BEGIN = 0;
        /// <summary>
        /// 绘制进度_当控件绘制背景后
        /// </summary>
        public const int PAINT_PROGRESS_BKG = 1;
        /// <summary>
        /// 绘制进度_当控件绘制边框后
        /// </summary>
        ///
        public const int PAINT_PROGRESS_BORDER = 2;
        /// <summary>
        /// 绘制进度_当控件自定义绘制后
        /// </summary>
        ///
        public const int PAINT_PROGRESS_CUSTOMDRAW = 3;
        /// <summary>
        /// 绘制进度_当控件绘制结束后
        /// </summary>
        ///
        public const int PAINT_PROGRESS_END = 4;
        #endregion

        #region 列表风格_ 
        /// <summary>
        /// 列表风格_纵向列表
        /// </summary>
        ///
        public const int LISTVIEW_STYLE_VERTICALLIST = 0;
        /// <summary>
        /// 列表风格_横向列表
        /// </summary>
        ///
        public const int LISTVIEW_STYLE_HORIZONTALLIST = 0x01;
        /// <summary>
        /// 列表风格_允许多选
        /// </summary>
        ///
        public const int LISTVIEW_STYLE_ALLOWMULTIPLE = 0x08;
        /// <summary>
        /// 列表风格_表项跟踪
        /// </summary>
        ///
        public const int LISTVIEW_STYLE_ITEMTRACKING = 0x10;
        /// <summary>
        /// 列表风格_始终显示选择项
        /// </summary>
        ///
        public const int LISTVIEW_STYLE_SHOWSELALWAYS = 0x20;
        #endregion

        #region 消息_模板列表_
        /// <summary>
        /// 消息_模板列表_创建 返回值将作为列表项控件
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_ITEM_CREATE = 10010;
        /// <summary>
        ///消息_模板列表_创建完毕
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_ITEM_CREATED = 10011;
        /// <summary>
        /// 消息_模板列表_销毁
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_ITEM_DESTROY = 10012;
        /// <summary>
        ///消息_模板列表_填充数据 wParam:nIndex,lParam:hObjItem
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_ITEM_FILL = 10013;
        /// <summary>
        ///  消息_模板列表_置模板数据 wParam:cbSize,lParam:pTemplate
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_SETTEMPLATE = 10020;
        /// <summary>
        /// 消息_模板列表_取项目句柄 wParam:表项索引,返回表项容器句柄(不在可视区返回0)
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_GETITEMOBJ = 10021;
        /// <summary>
        /// 消息_模板列表_设置表项悬浮背景色 lParam:ARGB颜色
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_SET_ITEM_HOVERCOLOR = 10022;
        /// <summary>
        /// 消息_模板列表_设置表项选中背景色 lParam:ARGB颜色
        /// </summary>
        ///
        public const int TEMPLATELISTVIEW_MESSAGE_SET_ITEM_SELECTCOLOR = 100023;
        #endregion

        #region 列表命中_
        /// <summary>
        /// 列表命中_未命中
        /// </summary>
        ///
        public const int LISTVIEW_HITTYPE_NOWHERE = 1;
        /// <summary>
        /// 列表命中_命中表项
        /// </summary>
        ///
        public const int LISTVIEW_HITTYPE_ONITEM = 14;
        #endregion

        #region 画布信息类型_
        /// <summary>
        /// 画布信息类型_D2D描述表
        /// </summary>
        ///
        public const int CANVAS_DX_D2DCONTEXT = 1;
        /// <summary>
        /// 画布信息类型_D2D图形
        /// </summary>
        ///
        public const int CANVAS_DX_D2DBITMAP = 2;
        /// <summary>
        /// 画布信息类型_GDI渲染目标
        /// </summary>
        ///
        public const int CANVAS_DX_GDIRENDERTARGET = 3;
        #endregion

        #region 画布标识_
        /// <summary>
        /// 画布标识_画布抗锯齿
        /// </summary>
        public const int CANVAS_FLAG_CANVASANTIALIAS = 0x01;
        /// <summary>
        /// 画布标识_文本抗锯齿
        /// </summary>
        public const int CANVAS_FLAG_TEXTANTIALIAS = 0x02;
        /// <summary>
        /// 画布标识_GDI和D2D混合
        /// </summary>
        public const int CANVAS_FLAG_GDI_COMPATIBLE = 0x40000000;
        /// <summary>
        /// 画布标识_重置剪辑区
        /// </summary>
        public const int CANVAS_FLAG_CLIPED = -1;
        #endregion

        #region 混合模式_
        /// <summary>
        /// 混合模式_覆盖
        /// </summary>
        ///
        public const int CANVAS_COMPOSITE_MODE_SRCOVER = 0;
        /// <summary>
        /// 混合模式_拷贝
        /// </summary>
        ///
        public const int CANVAS_COMPOSITE_MODE_SRCCOPY = 1;
        #endregion

        #region 消息_编辑框_
        ///<summary>
        /// 消息_编辑框_取指针位置
        ///</summary>
        public const int EDIT_MESSAGE_GETSEL = 176;
        ///<summary>
        /// 消息_编辑框_置指针位置
        ///</summary>
        public const int EDIT_MESSAGE_SETSEL = 177;
        /// <summary>
        /// 消息_编辑框_取行数
        /// </summary>
        public const int EDIT_MESSAGE_GETLINECOUNT = 186;
        /// <summary>
        /// 消息_编辑框_替换文本内容
        /// </summary>
        public const int EDIT_MESSAGE_REPLACESEL = 194;
        ///<summary>
        ///消息_编辑框_撤销
        ///</summary>
        public const int EDIT_MESSAGE_UNDO = 199;
        ///<summary>
        ///消息_编辑框_重做
        ///</summary>
        public const int EDIT_MESSAGE_REDO = 1108;
        ///<summary>
        ///消息_编辑框_设置选中区域
        ///</summary>
        public const int EDIT_MESSAGE_EXSETSEL = 1079;
        ///<summary>
        ///消息_编辑框_取选中范围内容
        ///</summary>
        public const int EDIT_MESSAGE_GETTEXTRANGE = 1099;
        ///<summary>
        ///消息_编辑框_设置富文本
        ///</summary>
        public const int EDIT_MESSAGE_SETTEXTEX = 1121;
        ///<summary>
        ///消息_编辑框_查找文本
        ///</summary>
        public const int EDIT_MESSAGE_FINDTEXTW = 1147;
        ///<summary>
        ///设置提示文本(wParam:提示文本颜色,lParam:文本指针)
        ///</summary>
        public const int EDIT_MESSAGE_SETCUEBANNER = 5377;
        ///<summary>
        /// 加载RTF文件(wParam:数据长度,lParam:数据指针)
        ///</summary>
        public const int EDIT_MESSAGE_LOAD_RTF = 6001;
        #endregion

        #region 编辑框选中行字符格式
        /// <summary>
        /// 编辑框选中行字符格式_加粗
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_BOLD = 1;
        /// <summary>
        /// 编辑框选中行字符格式_倾斜
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_ITALIC = 2;
        /// <summary>
        /// 编辑框选中行字符格式_下划线
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_UNDERLINE = 4;
        /// <summary>
        /// 编辑框选中行字符格式_删除线
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_STRIKEOUT = 8;
        /// <summary>
        /// 编辑框选中行字符格式_超链接
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_LINK = 32;
        /// <summary>
        /// 编辑框选中行字符格式_尺寸
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_SIZE = -1;
        /// <summary>
        /// 编辑框选中行字符格式_颜色
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_COLOR = 0x40000000;
        /// <summary>
        /// 编辑框选中行字符格式_字体名称
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_FACE = 0x20000000;
        /// <summary>
        /// 编辑框选中行字符格式_垂直偏移
        /// </summary>
        public const int EDIT_SELECT_CHARFORMAT_OFFSET = 0x10000000;
        #endregion

        #region 编辑框选中行段落格式
        /// <summary>
        /// 编辑框选中行段落格式_首行缩进
        /// </summary>
        public const int EDIT_SELECT_PARAGRAPHFORMAT_STARTINDENT = 0x00000001;
        /// <summary>
        /// 编辑框选中行段落格式_右侧缩进
        /// </summary>
        public const int EDIT_SELECT_PARAGRAPHFORMAT_RIGHTINDENT = 0x00000002;
        /// <summary>
        /// 编辑框选中行段落格式_非首行缩进
        /// </summary>
        public const int EDIT_SELECT_PARAGRAPHFORMAT_OFFSET = 0x00000004;
        /// <summary>
        /// 编辑框选中行段落格式_段落对齐方式
        /// </summary>
        public const int EDIT_SELECT_PARAGRAPHFORMAT_ALIGNMENT = 0x00000008;
        /// <summary>
        /// 编辑框选中行段落格式_编号类型
        /// </summary>
        public const int EDIT_SELECT_PARAGRAPHFORMAT_NUMBERING = 0x00000020;
        #endregion

        #region 编辑框段落对齐方式
        /// <summary>
        /// 编辑框段落对齐方式_左对齐
        /// </summary>
        public const int EDIT_PARAGRAPHFALIGN_LEFT = 1;
        /// <summary>
        /// 编辑框段落对齐方式_右对齐
        /// </summary>
        public const int EDIT_PARAGRAPHFALIGN_RIGHT = 2;
        /// <summary>
        /// 编辑框段落对齐方式_居中
        /// </summary>
        public const int EDIT_PARAGRAPHFALIGN_CENTER = 3;
        #endregion

        #region 编辑框段落项目符号类型
        /// <summary>
        /// 编辑框段落项目符号类型_圆点
        /// </summary>
        public const int EDIT_PARAGRAPHFSYMBOL_BULLET = 1;
        /// <summary>
        /// 编辑框段落项目符号类型_阿拉伯数字 0, 1, 2,...
        /// </summary>
        public const int EDIT_PARAGRAPHFSYMBOL_ARABIC = 2;
        /// <summary>
        /// 编辑框段落项目符号类型_小写字母 a, b, c,...
        /// </summary>
        public const int EDIT_PARAGRAPHFSYMBOL_LCLETTER = 3;
        /// <summary>
        /// 编辑框段落项目符号类型_大写字母 A, B, C,...
        /// </summary>
        public const int EDIT_PARAGRAPHFSYMBOL_UCLETTER = 4;
        /// <summary>
        /// 编辑框段落项目符号类型_小写罗马字母 i, ii, iii, ...
        /// </summary>
        public const int EDIT_PARAGRAPHFSYMBOL_LCROMAN = 5;
        /// <summary>
        /// 编辑框段落项目符号类型_大写罗马字母 I, II, III, ...
        /// </summary>
        public const int EDIT_PARAGRAPHFSYMBOL_UCROMAN = 6;
        #endregion

        #region 区域模式_
        /// <summary>
        /// 区域模式_并集	采用两个区域的并集来合并这两个区域
        /// </summary>
        ///
        public const int REGION_COMBINE_UNION = 0;
        /// <summary>
        /// 区域模式_交集.采用两个区域的交集来合并这两个区域
        /// </summary>
        ///
        public const int REGION_COMBINE_INTERSECT = 1;
        /// <summary>
        /// 区域模式_异或.采用两个区域的并集，且去除重叠区域
        /// </summary>
        ///
        public const int REGION_COMBINE_XOR = 2;
        /// <summary>
        /// 区域模式_排除.从第一个区域中排除第二个区域
        /// </summary>
        ///
        public const int REGION_COMBINE_EXCLUDE = 3;
        #endregion

        #region 事件_布局_
        /// <summary>
        /// 事件_布局_获取布局父属性个数
        /// </summary>
        ///
        public const int LAYOUT_EVENT_GETPROPSCOUNT = 1;
        /// <summary>
        /// 事件_布局_获取布局子属性个数
        /// </summary>
        ///
        public const int LAYOUT_EVENT_GETCHILDPROPCOUNT = 2;
        /// <summary>
        /// 事件_布局_初始化父属性列表
        /// </summary>
        ///
        public const int LAYOUT_EVENT_INITPROPS = 3;
        /// <summary>
        /// 事件_布局_释放父属性列表
        /// </summary>
        ///
        public const int LAYOUT_EVENT_UNINITPROPS = 4;
        /// <summary>
        /// 事件_布局_初始化子属性列表
        /// </summary>
        ///
        public const int LAYOUT_EVENT_INITCHILDPROPS = 5;
        /// <summary>
        /// 事件_布局_释放子属性列表
        /// </summary>
        ///
        public const int LAYOUT_EVENT_UNINITCHILDPROPS = 6;
        /// <summary>
        /// 事件_布局_检查属性值是否正确,wParam为propID，lParam为值
        /// </summary>
        ///
        public const int LAYOUT_EVENT_CHECKPROPVALUE = 7;
        /// <summary>
        /// 事件_布局_检查子属性值是否正确,wParam低位为nIndex，高位为propID，lParam为值
        /// </summary>
        ///
        public const int LAYOUT_EVENT_CHECKCHILDPROPVALUE = 8;
        /// <summary>
        /// 事件_布局_从XML属性表填充到布局信息中
        /// </summary>
        ///
        public const int LAYOUT_EVENT_FILL_XML_PROPS = 9;
        /// <summary>
        /// 事件_布局_从XML属性表填充到父布局信息中
        /// </summary>
        ///
        public const int LAYOUT_EVENT_FILL_XML_CHILD_PROPS = 10;
        /// <summary>
        /// 事件_布局_更新布局
        /// </summary>
        ///
        public const int LAYOUT_EVENT_UPDATE = 15;
        #endregion

        #region 布局单位_
        /// <summary>
        /// 单位:像素
        /// </summary>
        ///
        public const int UNIT_PIXEL = 0;
        /// <summary>
        /// 单位:百分比
        /// </summary>
        ///
        public const int UNIT_PERCENT = 1;
        #endregion

        #region 事件_组合框_
        /// <summary>
        /// 组合框事件_列表项被改变
        /// </summary>
        ///
        public const int COMBOBOX_EVENT_SELCHANGE = 1;
        /// <summary>
        /// 组合框事件_编辑内容被改变
        /// </summary>
        ///
        public const int COMBOBOX_EVENT_EDITCHANGE = 5;
        /// <summary>
        /// 组合框事件_即将弹出列表
        /// </summary>
        ///
        public const int COMBOBOX_EVENT_DROPDOWN = 7;
        /// <summary>
        /// 组合框事件_即将关闭列表
        /// </summary>
        ///
        public const int COMBOBOX_EVENT_CLOSEUP = 8;
        /// <summary>
        /// 组合框事件_弹出下拉列表
        /// </summary>
        ///
        public const int COMBOBOX_EVENT_POPUPLISTWINDOW = 2001;
        #endregion

        #region 消息_组合框_
        /// <summary>
        /// 消息_组合框_添加项目,lParam内容
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_ADDSTRING = 0x0143;
        /// <summary>
        /// 消息_组合框_删除项目,wParam索引
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_DELETESTRING = 0x0144;
        /// <summary>
        /// 消息_组合框_插入项目,wParam索引,lParam内容
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_INSERTSTRING = 0x014A;
        /// <summary>
        /// 消息_组合框_寻找项目,wParam索引,lParam内容
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_FINDSTRING = 0x014C;
        /// <summary>
        /// 消息_组合框_取项目数
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_GETCOUNT = 0x0146;
        /// <summary>
        /// 消息_组合框_取当前选中项目
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_GETCURSEL = 0x0147;
        /// <summary>
        /// 消息_组合框_置当前选中项目
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_SETCURSEL = 0x014E;
        /// <summary>
        /// 消息_组合框_取下拉列表宽度
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_GETDROPPEDWIDTH = 0x015F;
        /// <summary>
        /// 消息_组合框_置下拉列表宽度,wParam宽度
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_SETDROPPEDWIDTH = 0x0160;
        /// <summary>
        /// 消息_组合框_取表项高度
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_GETITEMHEIGHT = 0x0154;
        /// <summary>
        /// 消息_组合框_置表项高度,lParam高度
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_SETITEMHEIGHT = 0x0153;
        /// <summary>
        /// 消息_组合框_取可视数量
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_GETMINVISIBLE = 5890;
        /// <summary>
        /// 消息_组合框_置可视数量
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_SETMINVISIBLE = 5889;
        /// <summary>
        /// 消息_组合框_重置内容
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_RESETCONTENT = 0x014B;
        /// <summary>
        /// 消息_组合框_显示下拉列表
        /// </summary>
        ///
        public const int COMBOBOX_MESSAGE_SHOWDROPDOWN = 0x014F;
        #endregion

        #region 组合框风格_
        /// <summary>
        /// 组合框风格_允许编辑
        /// </summary>
        ///
        public const int COMBOBOX_STYLE_ALLOWEDIT = 1;
        #endregion

        #region 窗口位置标识_
        /// <summary>
        /// 窗口位置标识_不改变尺寸
        /// </summary>
        ///
        public const int SWP_NOSIZE = 0x0001;
        /// <summary>
        /// 窗口位置标识_不移动
        /// </summary>
        ///
        public const int SWP_NOMOVE = 0x0002;
        /// <summary>
        /// 窗口位置标识_维持当前Z序
        /// </summary>
        ///
        public const int SWP_NOZORDER = 0x0004;
        /// <summary>
        /// 窗口位置标识_不激活
        /// </summary>
        ///
        public const int SWP_NOACTIVATE = 0x0010;
        #endregion

        #region 树形框节点类型_
        /// <summary>
        /// 树形框节点类型_首节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_FIRST = -65535;
        /// <summary>
        /// 树形框节点类型_尾节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_LAST = -65534;
        /// <summary>
        /// 树形框节点类型_根节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_ROOT = -65536;
        /// <summary>
        /// 树形框节点类型_排序
        /// </summary>
        ///
        public const int TREEVIEW_NODE_SORT = -65533;
        #endregion

        #region 消息_树形框_
        /// <summary>
        /// 消息_树形框_删除节点及所有子孙 (lParam为节点句柄,0或TVI_ROOT为删除所有)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_DELETEITEM = 4353;
        /// <summary>
        /// 消息_树形框_保证显示 (lParam为显示的节点句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_ENSUREVISIBLE = 4372;
        /// <summary>
        /// 消息_树形框_展开收缩 (wParam为是否展开,lParam为设置的节点句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_EXPAND = 4354;
        /// <summary>
        /// 消息_树形框_取节点数
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETCOUNT = 4357;
        /// <summary>
        /// 消息_树形框_取留白宽度
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETINDENT = 4358;
        /// <summary>
        /// 消息_树形框_取节点矩形 (wParam为节点句柄,lParam为 EX_RECT 指针,注意该节点必须处于可见范围,否则消息无法获取并返回0)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETITEMRECT = 4356;
        /// <summary>
        /// 消息_树形框_取相关节点(wParam为 TVGN_ 开头的常量,lParam为节点句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETNEXTITEM = 4362;
        /// <summary>
        /// 消息_树形框_取展开可视节点个数
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETVISIBLECOUNT = 4368;
        /// <summary>
        /// 消息_树形框_命中测试 (wParam低位为x高位为y[相对控件],lParam为 返回#TVHT_开头常量 的指针,消息返回值为命中的节点句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_HITTEST = 4369;
        /// <summary>
        /// 消息_树形框_插入节点 (lParam为 EX_TREEVIEW_ITEMINFO 指针，tzText为Unicode)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_INSERTITEM = 4352;
        /// <summary>
        /// 消息_树形框_置选中项 (lParam为选中的节点句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_SELECTITEM = 4363;
        /// <summary>
        /// 消息_树形框_设置留白宽度 取相关节点(wParam为 TVGN_ 开头的常量,lParam为节点句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_SETINDENT = 4359;
        /// <summary>
        /// 消息_树形框_取节点信息 (wParam为节点句柄,lParam为 EX_TREEVIEW_ITEMINFO 指针，tzText为Unicode)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETITEM = 4364;
        /// <summary>
        /// 消息_树形框_设置节点信息 (wParam为节点句柄,lParam为 EX_TREEVIEW_ITEMINFO 指针)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_SETITEM = 4365;
        /// <summary>
        /// 消息_树形框_更新树形框
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_UPDATE = 4499;
        /// <summary>
        /// 消息_树形框_设置行高 (lParam为新行高)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_SETITEMHEIGHT = 5091;
        /// <summary>
        /// 消息_树形框_获取行高
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETITEMHEIGHT = 5092;
        /// <summary>
        /// 消息_树形框_从索引获取节点句柄 (wParam为索引,节点必须可见否则返回0)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETNODEFROMINDEX = 5093;
        /// <summary>
        /// 消息_树形框_设置节点标题 (wParam为节点句柄,lParam为 文本指针,Unicode)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_SETITEMTEXTW = 14414;
        /// <summary>
        /// 消息_树形框_获取节点标题 (wParam为节点句柄,返回值为标题Unicode字符串,不要自行释放)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETITEMTEXTW = 14415;
        /// <summary>
        /// 消息_树形框_设置图片组(wParam为是否更新表项宽高,lParam为图片组句柄)
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_SETIMAGELIST = 4361;
        /// <summary>
        /// 消息_树形框_获取图片组
        /// </summary>
        ///
        public const int TREEVIEW_MESSAGE_GETIMAGELIST = 4360;
        #endregion

        #region 树形框相关节点_
        /// <summary>
        /// 树形框相关节点_获取根节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_CORRELATION_ROOT = 0;
        /// <summary>
        /// 树形框相关节点_获取下一个节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_CORRELATION_NEXT = 1;
        /// <summary>
        /// 树形框相关节点_获取上一个节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_CORRELATION_PREVIOUS = 2;
        /// <summary>
        /// 树形框相关节点_获取父节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_CORRELATION_PARENT = 3;
        /// <summary>
        /// 树形框相关节点_获取子节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_CORRELATION_CHILD = 4;
        /// <summary>
        /// 树形框相关节点_获取下一个可见节点
        /// </summary>
        ///
        public const int TREEVIEW_NODE_CORRELATION_NEXTVISIBLE = 6;
        #endregion

        #region 树形框命中测试_
        /// <summary>
        /// 树形框命中测试_没有命中
        /// </summary>
        ///
        public const int TREEVIEW_HITTYPE_NOWHERE = 1;
        /// <summary>
        /// 树形框命中测试_命中图标
        /// </summary>
        ///
        public const int TREEVIEW_HITTYPE_ONITEMICON = 2;
        /// <summary>
        ///  树形框命中测试_命中标题
        /// </summary>
        ///
        public const int TREEVIEW_HITTYPE_ONITEMLABEL = 4;
        /// <summary>
        /// 树形框命中测试_命中留白
        /// </summary>
        ///
        public const int TREEVIEW_HITTYPE_ONITEMINDENT = 8;
        /// <summary>
        /// 树形框命中测试_命中加减框
        /// </summary>
        ///
        public const int TREEVIEW_HITTYPE_ONITEMSTATEICON = 64;
        #endregion

        #region 事件_树形框_
        /// <summary>
        /// 事件_树形框_删除节点
        /// </summary>
        ///
        public const int TREEVIEW_EVENT_DELETEITEM = 391;
        /// <summary>
        /// 事件_树形框_节点展开
        /// </summary>
        ///
        public const int TREEVIEW_EVENT_ITEMEXPANDED = 394;
        /// <summary>
        /// 事件_树形框_节点展开中
        /// </summary>
        ///
        public const int TREEVIEW_EVENT_ITEMEXPANDING = 395;
        /// <summary>
        /// 事件_树形框_绘制节点
        /// </summary>
        ///
        public const int TREEVIEW_EVENT_DRAWITEM = 3099;
        #endregion

        #region 报表框_
        /// <summary>
        /// 报表风格_绘制横线
        /// </summary>
        ///
        public const int REPORTLISTVIEW_STYLE_DRAWHORIZONTALLINE = 256;
        /// <summary>
        /// 报表风格_绘制竖线
        /// </summary>
        ///
        public const int REPORTLISTVIEW_STYLE_DRAWVERTICALLINE = 512;
        /// <summary>
        /// 报表风格_无表头
        /// </summary>
        ///
        public const int REPORTLISTVIEW_STYLE_NOHEAD = 1024;
        /// <summary>
        /// 报表风格_表项可编辑
        /// </summary>
        ///
        public const int REPORTLISTVIEW_STYLE_EDIT = 2048;
        #endregion

        #region 报表表头风格_
        /// <summary>
        /// 报表表头风格_默认
        /// </summary>
        ///
        public const int REPORTLISTVIEW_HEADER_STYLE_DEFAULT = 0;
        /// <summary>
        /// 报表表头风格_可点击
        /// </summary>
        ///
        public const int REPORTLISTVIEW_HEADER_STYLE_CLICKABLE = 1;
        /// <summary>
        /// 报表表头风格_锁定宽度
        /// </summary>
        ///
        public const int REPORTLISTVIEW_HEADER_STYLE_LOCKWIDTH = 2;
        /// <summary>
        /// 报表表头风格_可排序 (前提是得可点击)
        /// </summary>
        ///
        public const int REPORTLISTVIEW_HEADER_STYLE_SORTABLE = 4;
        /// <summary>
        /// 报表表头风格_自定义列表头背景色
        /// </summary>
        public const int REPORTLISTVIEW_HEADER_STYLE_COLOUR = 8;
        #endregion

        #region 事件_报表_
        /// <summary>
        /// 事件_报表_表头被单击,wParam项目索引从1开始
        /// </summary>
        ///
        public const int REPORTLISTVIEW_EVENT_COLUMNCLICK = 97000;
        /// <summary>
        /// 事件_报表_绘制表行
        /// </summary>
        ///
        public const int REPORTLISTVIEW_EVENT_DRAW_TR = 97001;
        /// <summary>
        /// 事件_报表_绘制表项
        /// </summary>
        ///
        public const int REPORTLISTVIEW_EVENT_DRAW_TD = 97002;
        /// <summary>
        /// 事件_报表_检查框点击,wParam项目索引从1开始;lParam项目状态0取消选中 1选中
        /// </summary>
        ///
        public const int REPORTLISTVIEW_EVENT_CHECK = 97003;
        /// <summary>
        /// 事件_报表_当删除表项
        /// </summary>
        ///
        public const int REPORTLISTVIEW_EVENT_DELETE_ITEM = 97004;
        #endregion

        #region 消息_报表_
        /// <summary>
        /// 消息_报表_检查框点击
        /// </summary>
        ///
        public const int REPORTLISTVIEW_MESSAGE_CHECK = 99001;
        /// <summary>
        /// 消息_报表_设置检查框状态 wParam 为项目索引 lParam为置选中状态1选中, 0不选中
        /// </summary>
        ///
        public const int REPORTLISTVIEW_MESSAGE_SETCHECK = 99002;
        /// <summary>
        /// 消息_报表_获取检查框状态 wParam 为项目索引 , 返回1选中, 0不选中
        /// </summary>
        ///
        public const int REPORTLISTVIEW_MESSAGE_GETCHECK = 99003;
        /// <summary>
        /// 消息_报表_获取命中列索引
        /// </summary>
        ///
        public const int REPORTLISTVIEW_MESSAGE_GETHITCOL = 99004;
        #endregion

        #region 窗口显示标识_
        /// <summary>
        /// 窗口显示标识_显示
        /// </summary>
        ///
        public const int SW_SHOW = 5;
        /// <summary>
        /// 窗口显示标识_隐藏
        /// </summary>
        ///
        public const int SW_HIDE = 0;
        /// <summary>
        /// 窗口显示标识_最大化
        /// </summary>
        ///
        public const int SW_SHOWMAXIMIZED = 3;
        /// <summary>
        /// 窗口显示标识_最小化
        /// </summary>
        ///
        public const int SW_SHOWMINIMIZED = 2;
        /// <summary>
        /// 窗口显示标识_不激活
        /// </summary>
        ///
        public const int SW_SHOWNOACTIVATE = 4;
        #endregion

        #region 菜单消息_
        /// <summary>
        /// 消息_选择菜单项目
        /// </summary>
        public const int MENU_MESSAGE_SELECTITEM = 0x1E5;
        #endregion

        #region 消息_列表按钮_
        /// <summary>
        ///  消息_列表按钮_按下项目 wParam按下横坐标 lParam 菜单句柄
        /// </summary>
        ///
        public const int LISTBUTTON_MESSAGE_DOWNITEM = 1237701;
        /// <summary>
        ///  消息_列表按钮_选择项目
        /// </summary>
        ///
        public const int LISTBUTTON_MESSAGE_SELECTITEM = 1237702;
        #endregion

        #region WIN10动画加载风格_
        /// <summary>
        ///  WIN10动画加载风格_直线
        /// </summary>
        ///
        public const int LOADING_STYLE_LINE = 1;
        #endregion

        #region 滑块条风格_
        /// <summary>
        ///  滑块条风格_横向
        /// </summary>
        ///
        public const int SLIDERBAR_STYLE_HORIZONTAL = 0;
        /// <summary>
        ///  滑块条风格_纵向
        /// </summary>
        ///
        public const int SLIDERBAR_STYLE_VERTICAL = 1;
        #endregion

        #region 消息_滑块条_
        /// <summary>
        ///  消息_滑块条_取当前滑块坐标
        /// </summary>
        ///
        public const int SLIDERBAR_MESSAGE_GETBLOCKRECT = 10010;
        /// <summary>
        ///  消息_滑块条_坐标转值
        /// </summary>
        ///
        public const int SLIDERBAR_MESSAGE_PT2VALUE = 10011;
        #endregion

        #region 事件_滑块条_
        /// <summary>
        ///  事件_滑块条_值改变 事件编号(lParam=值)
        /// </summary>
        ///
        public const int SLIDERBAR_EVENT_VALUE = 10010;
        #endregion

        #region 滑块条属性_
        /// <summary>
        ///  滑块条属性_最小值
        /// </summary>
        ///
        public const int SLIDERBAR_LONG_MIN = 0;
        /// <summary>
        ///  滑块条属性_最大值
        /// </summary>
        ///
        public const int SLIDERBAR_LONG_MAX = 1;
        /// <summary>
        ///  滑块条属性_当前值
        /// </summary>
        ///
        public const int SLIDERBAR_LONG_POS = 2;
        /// <summary>
        ///  滑块条属性_滑块圆滑动方向 设定值：1，横向风格（从右往左）|纵向风格（从下往上）
        /// </summary>
        ///
        public const int SLIDERBAR_LONG_BLOCK_POINT = 3;
        /// <summary>
        ///  滑块条属性_滑块圆半径
        /// </summary>
        ///
        public const int SLIDERBAR_LONG_BLOCK_SIZE = 4;
        #endregion

        #region 分组框属性_
        /// <summary>
        ///  分组框属性_文本左边的偏移
        /// </summary>
        ///
        public const int GROUPBOX_LONG_TEXT_OFFSET = 0;
        /// <summary>
        ///  分组框属性_线框圆角度
        /// </summary>
        ///
        public const int GROUPBOX_LONG_RADIUS = 1;
        /// <summary>
        ///  分组框属性_线宽
        /// </summary>
        ///
        public const int GROUPBOX_LONG_STROKEWIDTH = 2;
        #endregion

        #region 消息_颜色选择器_
        /// <summary>
        /// 消息_颜色选择器_改变颜色
        /// </summary>
        ///
        public const int COLORPICKER_MESSAGE_COLORCHANGE = 100051;
        #endregion

        #region 事件_颜色选择器_
        /// <summary>
        /// 事件_颜色选择器_颜色已更改,lParam更改的ARGB颜色
        /// </summary>
        ///
        public const int COLORPICKER_EVENT_COLORCHANGE = 100052;
        #endregion

        #region 事件_调色板_
        /// <summary>
        /// 调色板通知_鼠标移动 wParam返回不带alpha的RGB颜色,用ExRGB2ARGB转换到ARGB
        /// </summary>
        ///
        public const int PALETTE_EVENT_MOUSEMOVE = 100000;
        #endregion

        #region 事件_列表按钮_
        /// <summary>
        /// 事件_列表按钮_单击 wParam 索引从1开始
        /// </summary>
        ///
        public const int LISTBUTTON_EVENT_CLICK = 1;
        /// <summary>
        /// 事件_列表按钮_选中 wParam 索引从1开始,lParam 状态 STATE_
        /// </summary>
        ///
        public const int LISTBUTTON_EVENT_CHECK = 2;
        #endregion

        #region 消息_日期框_
        /// <summary>
        /// 消息_日期框_设置日期
        /// </summary>
        ///
        public const int DATEBOX_MESSAGE_DATETIME = 100061;
        #endregion

        #region 事件_日期框_
        /// <summary>
        /// 事件_日期框_日期选中,lParam是ExDateTimeInfo结构体
        /// </summary>
        ///
        public const int DATEBOX_EVENT_DATETIME = 100062;
        #endregion

        #region 事件_月历_
        /// <summary>
        /// 事件_月历_日期选中,lParam是ExDateTimeInfo结构体
        /// </summary>
        ///
        public const int CALENDAR_EVENT_DATETIME = 100062;
        #endregion

        #region 消息_Cef浏览框_
        /// <summary>
        /// 消息_Cef浏览框_加载URL
        /// </summary>
        ///
        public const int CEFBROWSER_MESSAGE_LOADURL = 100001;
        /// <summary>
        /// 消息_Cef浏览框_获取浏览框句柄
        /// </summary>
        ///
        public const int CEFBROWSER_MESSAGE_GETWEBVIEW = 100002;
        #endregion

        #region 事件_Cef浏览框_
        /// <summary>
        /// 事件_Cef浏览框_已创建CEFN_
        /// </summary>
        ///
        public const int CEFBROWSER_EVENT_CREATE = 100100;
        /// <summary>
        /// 事件_Cef浏览框_加载完毕
        /// </summary>
        ///
        public const int CEFBROWSER_EVENT_LOADEND = 100101;
        /// <summary>
        /// 事件_Cef浏览框_加载开始
        /// </summary>
        ///
        public const int CEFBROWSER_EVENT_LOADSTART = 100102;
        #endregion

        #region 消息_轮播_
        /// <summary>
        /// 消息_轮播_设置尺寸
        /// </summary>
        ///
        public const int CAROUSEL_MESSAGE_SIZE = 5000;
        /// <summary>
        /// 消息_轮播_播放下一张
        /// </summary>
        ///
        public const int CAROUSEL_MESSAGE_NEXT = 5001;
        /// <summary>
        /// 消息_轮播_播放上一张
        /// </summary>
        ///
        public const int CAROUSEL_MESSAGE_PREV = 5002;
        /// <summary>
        /// 消息_轮播_添加图片
        /// </summary>
        ///
        public const int CAROUSEL_MESSAGE_ADDIMG = 5003;
        /// <summary>
        /// 消息_轮播_清空
        /// </summary>
        ///
        public const int CAROUSEL_MESSAGE_CLEAR = 5004;
        /// <summary>
        /// 消息_轮播_设置时钟周期
        /// </summary>
        ///
        public const int CAROUSEL_MESSAGE_SETTIMER = 5005;
        #endregion

        #region 消息_鼠绘板_
        /// <summary>
        /// 消息_鼠绘板_设置画笔类型 lParam 0画笔 1橡皮擦
        /// </summary>
        ///
        public const int DRAWINGBOARD_MESSAGE_SETPENTYPE = 20000;
        /// <summary>
        /// 消息_鼠绘板_设置画笔宽度 lParam
        /// </summary>
        ///
        public const int DRAWINGBOARD_MESSAGE_SETPENWIDTH = 20001;
        /// <summary>
        /// 消息_鼠绘板_设置画笔颜色 lParam
        /// </summary>
        ///
        public const int DRAWINGBOARD_MESSAGE_SETPENCOLOR = 20002;
        /// <summary>
        /// 消息_鼠绘板_清空画板
        /// </summary>
        ///
        public const int DRAWINGBOARD_MESSAGE_CLEAR = 20003;
        #endregion

        #region 消息_属性框_
        /// <summary>
        /// 消息_属性框_添加表项 添加行到尾部 wParam:组件_类型  lParam: PGITEM 指针
        /// </summary>
        ///
        public const int PROPERTYGRID_MESSAGE_ADDITEM = 10010;
        /// <summary>
        /// 消息_属性框_取表项值 wParam: 未定义    lParam:表项名  return:表项值文本指针
        /// </summary>
        ///
        public const int PROPERTYGRID_MESSAGE_GETITEMVALUE = 10011;
        /// <summary>
        ///  消息_属性框_置表项值 wParam: 欲写入值    lParam:表项名  return:未定义
        /// </summary>
        ///
        public const int PROPERTYGRID_MESSAGE_SETITEMVALUE = 10012;
        /// <summary>
        ///  消息_属性框_清空项目
        /// </summary>
        ///
        public const int PROPERTYGRID_MESSAGE_CLEAR = 10013;
        #endregion

        #region 事件_属性框_
        /// <summary>
        /// 事件_属性框_表项值改变 wParam:行索引(不包括标题行,包括分组行和组件行,从1开始)   lParam:数据指针(可以通过"__get(数据指针,PGL_内存偏移_/////)"来获取数据)
        /// </summary>
        ///
        public const int PROPERTYGRID_EVENT_ITEMVALUECHANGE = 10012;
        #endregion

        #region 属性框_组件类型_
        /// <summary>
        /// 属性框_组件类型_分组
        /// </summary>
        ///
        public const int PROPERTYGRID_OBJTYPE_GROUP = -1;
        /// <summary>
        /// 属性框_组件类型_编辑框
        /// </summary>
        ///
        public const int PROPERTYGRID_OBJTYPE_EDIT = 0;
        /// <summary>
        /// 属性框_组件类型_组合框
        /// </summary>
        ///
        public const int PROPERTYGRID_OBJTYPE_COMBOBOX = 1;
        /// <summary>
        /// 属性框_组件类型_颜色框
        /// </summary>
        ///
        public const int PROPERTYGRID_OBJTYPE_COLORPICKER = 2;
        /// <summary>
        /// 属性框_组件类型_日期框
        /// </summary>
        ///
        public const int PROPERTYGRID_OBJTYPE_DATEBOX = 3;
        #endregion

        #region 报表表行风格_
        /// <summary>
        /// 报表表行风格_默认
        /// </summary>
        ///
        public const int REPORTLISTVIEW_LINESTYLE_DEFAULT = 0;
        /// <summary>
        /// 报表表行风格_表项带检查框
        /// </summary>
        ///
        public const int REPORTLISTVIEW_LINESTYLE_CHECKBOX = 1;
        /// <summary>
        /// 报表表行风格_检查框为选中状态
        /// </summary>
        ///
        public const int REPORTLISTVIEW_LINESTYLE_CHECKBOX_CHECK = 2;
        /// <summary>
        /// 报表表行风格_自定义整行格背景色
        /// </summary>
        public const int REPORTLISTVIEW_LINESTYLE_ROWCOLOUR = 4;
        #endregion

        #region 报表单元格风格_
        /// <summary>
        /// 报表单元格风格_背景色
        /// </summary>
        public const int REPORTLISTVIEW_CELLSTYLE_CELLCOLOUR = 1;
        /// <summary>
        /// 报表单元格风格_文本色
        /// </summary>
        public const int REPORTLISTVIEW_CELLSTYLE_CELLTEXTCOLOUR = 2;
        /// <summary>
        /// 报表单元格风格_字体
        /// </summary>
        public const int REPORTLISTVIEW_CELLSTYLE_CELLFONT = 4;
        #endregion

        #region 图标列表风格_
        /// <summary>
        /// 图标列表风格_表项以按钮形式呈现
        /// </summary>
        ///
        public const int ICONLISTVIEW_STYLE_BUTTON = 0x400;
        #endregion

        #region 消息_图标列表_
        /// <summary>
        /// 消息_图标列表_设置表项尺寸
        /// </summary>
        ///
        public const int ICONLISTVIEW_MESSAGE_SETITEMSIZE = 11001;
        #endregion

        #region 路径标识_
        /// <summary>
        /// 路径标识_缩放
        /// </summary>
        public const int PATH_FLAG_NORMAL = 0;
        /// <summary>
        /// 路径标识_禁止缩放
        /// </summary>
        public const int PATH_FLAG_DISABLESCALE = 1;
        #endregion

        #region 路径开始标识_
        /// <summary>
        /// 路径开始标识_填充圆，影响hittest
        /// </summary>
        public const int PATH_BEGIN_FLAG_FILLED = 0;
        /// <summary>
        /// 路径开始标识_空心，影响hittest
        /// </summary>
        public const int PATH_BEGIN_FLAG_HOLLOW = 1;
        #endregion

        #region 位置信息标识_
        /// <summary>
        /// 组件位置默认值
        /// </summary>
        ///
        public const int OBJECT_POSITION_DEFAULT = -2147483648;
        #endregion

        #region 树形框风格_
        /// <summary>
        /// 树形框风格_显示加减号
        /// </summary>
        ///
        public const int TREEVIEW_STYLE_SHOWADDANDSUB = 64;
        /// <summary>
        /// 树形框风格_显示连接线
        /// </summary>
        ///
        public const int TREEVIEW_STYLE_SHOWCABLE = 128;
        #endregion

        #region 包头_
        /// <summary>
        /// 主题包头
        /// </summary>
        ///
        public const int PACKAGEHEADER_THEME = 254;
        /// <summary>
        /// 资源包头
        /// </summary>
        ///
        public const int PACKAGEHEADER_FILES = 255;
        #endregion

        #region 图标类型_
        /// <summary>
        /// 位图
        /// </summary>
        ///
        public const int IMAGE_BITMAP = 0;
        /// <summary>
        /// 图标
        /// </summary>
        ///
        public const int IMAGE_ICON = 1;
        /// <summary>
        /// 鼠标指针
        /// </summary>
        ///
        public const int IMAGE_CURSOR = 2;
        #endregion

        #region 文本对齐格式_
        /// <summary>
        /// 文本对齐_顶对齐
        /// </summary>
        public const int DT_TOP = 0x00000000;
        /// <summary>
        /// 文本对齐_左对齐
        /// </summary>
        public const int DT_LEFT = 0x00000000;
        /// <summary>
        /// 文本对齐_水平居中
        /// </summary>
        public const int DT_CENTER = 0x00000001;
        /// <summary>
        /// 文本对齐_右对齐
        /// </summary>
        public const int DT_RIGHT = 0x00000002;
        /// <summary>
        /// 文本对齐_垂直居中
        /// </summary>
        public const int DT_VCENTER = 0x00000004;
        /// <summary>
        /// 文本对齐_底对齐
        /// </summary>
        public const int DT_BOTTOM = 0x00000008;
        /// <summary>
        /// 文本对齐_自动换行
        /// </summary>
        public const int DT_WORDBREAK = 0x00000010;
        /// <summary>
        /// 文本对齐_单行模式
        /// </summary>
        public const int DT_SINGLELINE = 0x00000020;
        public const int DT_EXPANDTABS = 0x00000040;
        public const int DT_TABSTOP = 0x00000080;
        public const int DT_NOCLIP = 0x00000100;
        public const int DT_EXTERNALLEADING = 0x00000200;
        public const int DT_CALCRECT = 0x00000400;
        public const int DT_NOPREFIX = 0x00000800;
        public const int DT_INTERNAL = 0x00001000;
        #endregion

        #region 窗口消息_
        public const int WM_CREATE = 1;
        public const int WM_DESTROY = 2;
        public const int WM_MOVE = 3;
        public const int WM_SIZE = 5;
        public const int WM_ACTIVATE = 6;
        public const int WM_SETFOCUS = 7;
        public const int WM_KILLFOCUS = 8;
        public const int WM_PAINT = 15;
        public const int WM_CLOSE = 16;
        public const int WM_ERASEBKGND = 20;
        public const int WM_NOTIFY = 78;
        public const int WM_SETICON = 128;
        public const int WM_NCHITTEST = 132;
        public const int WM_NCLBUTTONDOWN = 161;
        public const int WM_NCLBUTTONDBLCLK = 163;
        public const int WM_KEYDOWN = 256;
        public const int WM_KEYUP = 257;
        public const int WM_CHAR = 258;
        public const int WM_SYSKEYDOWN = 260;
        public const int WM_SYSKEYUP = 261;
        public const int WM_SYSCHAR = 262;
        public const int WM_IME_ENDCOMPOSITION = 270;
        public const int WM_IME_COMPOSITION = 271;
        public const int WM_INITDIALOG = 272;
        public const int WM_COMMAND = 273;
        public const int WM_TIMER = 275;
        public const int WM_HSCROLL = 276;
        public const int WM_VSCROLL = 277;
        public const int WM_INITMENUPOPUP = 279;
        public const int WM_MOUSEMOVE = 512;
        public const int WM_LBUTTONDOWN = 513;
        public const int WM_LBUTTONUP = 514;
        public const int WM_LBUTTONDBLCLK = 515;
        public const int WM_RBUTTONDOWN = 516;
        public const int WM_RBUTTONUP = 517;
        public const int WM_RBUTTONDBLCLK = 518;
        public const int WM_MBUTTONDOWN = 519;
        public const int WM_MBUTTONUP = 520;
        public const int WM_MBUTTONDBLCLK = 521;
        public const int WM_MOUSEWHEEL = 522;
        public const int WM_IME_SETCONTEXT = 641;
        public const int WM_IME_CHAR = 646;

        /// <summary>
        /// 收到拖拽文件,wParam拖曳句柄
        /// </summary>
        public const int WM_DROPFILES = 563;
        public const int WM_MOUSEHOVER = 673;
        public const int WM_MOUSELEAVE = 675;
        /// <summary>
        /// 编辑框剪切消息
        /// </summary>
        public const int WM_CUT = 0x0300;
        /// <summary>
        /// 编辑框复制消息
        /// </summary>
        public const int WM_COPY = 0x0301;
        /// <summary>
        /// 编辑框粘贴消息
        /// </summary>
        public const int WM_PASTE = 0x0302;
        /// <summary>
        /// 删除编辑框选中内容
        /// </summary>
        public const int WM_CLEAR = 0x0303;

        #endregion

        #region 鼠标消息功能键状态_ 
        public const int MK_LBUTTON = 0x01;
        public const int MK_RBUTTON = 0x02;
        public const int MK_SHIFT = 0x04;
        public const int MK_CONTROL = 0x08;
        public const int MK_MBUTTON = 0x10;
        #endregion

        #region WM_KEYUP/DOWN/CHAR HIWORD(lParam) flags
        public const int KF_EXTENDED = 0x100;
        public const int KF_ALTDOWN = 0x2000;
        public const int KF_REPEAT = 0x4000;
        #endregion

        public const int VK_CLEAR = 0x0C;
        public const int VK_RETURN = 0x0D;
        public const int VK_SHIFT = 0x10;
        public const int VK_CONTROL = 0x11;
        public const int VK_MENU = 0x12;
        public const int VK_CAPITAL = 0x14;
        public const int VK_INSERT = 0x2D;
        public const int VK_DELETE = 0x2E;
        public const int VK_PRIOR = 0x21;
        public const int VK_NEXT = 0x22;
        public const int VK_END = 0x23;
        public const int VK_HOME = 0x24;
        public const int VK_LEFT = 0x25;
        public const int VK_UP = 0x26;
        public const int VK_RIGHT = 0x27;
        public const int VK_DOWN = 0x28;
        public const int VK_LWIN = 0x5B;
        public const int VK_RWIN = 0x5C;
        public const int VK_NUMPAD0 = 0x60;
        public const int VK_NUMPAD1 = 0x61;
        public const int VK_NUMPAD2 = 0x62;
        public const int VK_NUMPAD3 = 0x63;
        public const int VK_NUMPAD4 = 0x64;
        public const int VK_NUMPAD5 = 0x65;
        public const int VK_NUMPAD6 = 0x66;
        public const int VK_NUMPAD7 = 0x67;
        public const int VK_NUMPAD8 = 0x68;
        public const int VK_NUMPAD9 = 0x69;
        public const int VK_MULTIPLY = 0x6A;
        public const int VK_ADD = 0x6B;
        public const int VK_SUBTRACT = 0x6D;
        public const int VK_DECIMAL = 0x6E;
        public const int VK_DIVIDE = 0x6F;
        public const int VK_NUMLOCK = 0x90;
        public const int VK_LSHIFT = 0xA0;
        public const int VK_RSHIFT = 0xA1;
        public const int VK_LCONTROL = 0xA2;
        public const int VK_RCONTROL = 0xA3;
        public const int VK_LMENU = 0xA4;
        public const int VK_RMENU = 0xA5;

        #region 按钮开关消息_ 
        /// <summary>
        /// 按钮开关消息_取选中
        /// </summary>
        public const int BUTTON_MESSAGE_GETCHECK = 240;
        /// <summary>
        /// 按钮开关消息_置选中,wParam是否刷新,lParam索引
        /// </summary>
        public const int BUTTON_MESSAGE_SETCHECK = 241;
        /// <summary>
        /// 按钮开关消息_取图片
        /// </summary>
        public const int BUTTON_MESSAGE_GETIMAGE = 246;
        /// <summary>
        /// 按钮开关消息_置图片
        /// </summary>
        public const int BUTTON_MESSAGE_SETIMAGE = 247;
        #endregion

        #region 字体风格_
        /// <summary>
        /// 字体风格_普通
        /// </summary>
        public const int FONT_STYLE_DEFAULT = 0;
        /// <summary>
        /// 字体风格_加粗
        /// </summary>
        public const int FONT_STYLE_BOLD = 1;
        /// <summary>
        /// 字体风格_倾斜
        /// </summary>
        public const int FONT_STYLE_ITALIC = 2;
        /// <summary>
        /// 字体风格_下划线
        /// </summary>
        public const int FONT_STYLE_UNDERLINE = 4;
        /// <summary>
        /// 字体风格_删除线
        /// </summary>
        public const int FONT_STYLE_STRICKOUT = 8;
        #endregion

        #region 拖曳格式_
        /// <summary>
        /// 文本
        /// </summary>
        public const int CF_TEXT = 1;
        /// <summary>
        /// unicode文本
        /// </summary>
        public const int CF_UNICODETEXT = 13;
        #endregion
        #region 拖曳处理模式_
        /// <summary>
        /// 复制方式
        /// </summary>
        public const int DROPEFFECT_COPY = 1;
        /// <summary>
        /// 快捷方式
        /// </summary>
        public const int DROPEFFECT_LINK = 4;
        #endregion

        #region 点击位置判断消息返回类型_
        /// <summary>
        /// 在一个被其它窗口覆盖的窗口中
        /// </summary>
        public const int HTTRANSPARENT = -1;
        /// <summary>
        /// 标题栏
        /// </summary>
        public const int HTCAPTION = 2;
        #endregion

        #region win32窗口风格_
        /// <summary>
        /// 分层窗口
        /// </summary>
        public const int WS_OVERLAPPEDWINDOW = 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000;
        #endregion

        #region win32窗口扩展风格_
        /// <summary>
        /// 分层窗口
        /// </summary>
        public const int WS_EX_LAYERED = 0x00080000;
        #endregion

        #region 消息_VLC播放器_
        /// <summary>
        /// 消息_vlc播放器_播放自文件 lParam :本地文件名
        /// </summary>
        public const int VLCPLAYER_MESSAGE_STATE_PLAY = 20000;
        /// <summary>
        /// 消息_vlc播放器_播放自url lParam :URL 如https://media.w3.org/2010/05/sintel/trailer.mp4
        /// </summary>
        public const int VLCPLAYER_MESSAGE_STATE_PLAYFROMURL = 20001;
        /// <summary>
        /// 消息_vlc播放器_暂停播放
        /// </summary>
        public const int VLCPLAYER_MESSAGE_STATE_PAUSE = 20002;
        /// <summary>
        /// 消息_vlc播放器_继续播放
        /// </summary>
        public const int VLCPLAYER_MESSAGE_STATE_RESUME = 20003;
        /// <summary>
        /// 消息_vlc播放器_停止播放
        /// </summary>
        public const int VLCPLAYER_MESSAGE_STATE_STOP = 20004;
        /// <summary>
        /// 消息_vlc播放器_置播放速率 lParam: 速率 int类型 0到3之间
        /// </summary>
        public const int VLCPLAYER_MESSAGE_SET_RATE = 20005;
        /// <summary>
        /// 消息_vlc播放器_取播放速率 lParam: 速率 int类型
        /// </summary>
        public const int VLCPLAYER_MESSAGE_GET_RATE = 20006;
        /// <summary>
        /// 消息_vlc播放器_置播放音量 lParam: 音量 int类型 0到100之间
        /// </summary>
        public const int VLCPLAYER_MESSAGE_SET_VOLUME = 20007;
        /// <summary>
        /// 消息_vlc播放器_取播放音量 lParam: 音量 int类型 0到100之间
        /// </summary>
        public const int VLCPLAYER_MESSAGE_GET_VOLUME = 20008;
        /// <summary>
        /// 消息_vlc播放器_置播放媒体时间 lParam: 单位 INT64类型 毫秒
        /// </summary>
        public const int VLCPLAYER_MESSAGE_SET_MEDIATIME = 20009;
        /// <summary>
        /// 消息_vlc播放器_取播放媒体时间 单位 INT64类型 毫秒
        /// </summary>
        public const int VLCPLAYER_MESSAGE_GET_MEDIATIME = 20010;
        /// <summary>
        /// 消息_取视频总时长 单位 INT64类型 毫秒
        /// </summary>
        public const int VLCPLAYER_MESSAGE_GET_DURATION = 20011;
        #endregion

        #region 标识_托盘_
        /// <summary>
        /// 托盘标识_默认无图标
        /// </summary>
        public const int NIIF_NONE = 0;
        /// <summary>
        /// 托盘标识_信息图标
        /// </summary>
        public const int NIIF_INFO = 0x01;
        /// <summary>
        /// 托盘标识_警告图标
        /// </summary>
        public const int NIIF_WARNING = 0x02;
        /// <summary>
        /// 托盘标识_错误图标
        /// </summary>
        public const int NIIF_ERROR = 0x03;
        /// <summary>
        /// 托盘标识_用户图标
        /// </summary>
        public const int NIIF_USER = 0x04;
        #endregion

        #region 标识_菜单_
        /// <summary>
        /// 文本
        /// </summary>
        public const int MF_STRING = 0;
        /// <summary>
        /// 指示菜单项已禁用，但未灰显，因此无法选择它
        /// </summary>
        public const int MF_DISABLED = 2;
        /// <summary>
        /// 选中菜单
        /// </summary>
        public const int MF_CHECKED = 0x08;
        /// <summary>
        /// 弹出式
        /// </summary>
        public const int MF_POPUP = 0x10;
        /// <summary>
        /// 指示 uIDEnableItem 提供菜单项的从零开始的相对位置
        /// </summary>
        public const int MF_BYPOSITION = 0x400;
        /// <summary>
        /// 分隔条
        /// </summary>
        public const int MF_SEPARATOR = 0x800;
        #endregion

        #region 消息_标注板_
        /// <summary>
        /// 消息_标注板_开始绘制
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_START = 10000;
        /// <summary>
        /// 消息_标注板_结束绘制
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_STOP = 10001;
        /// <summary>
        /// 消息_标注板_清空
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_CLEAR = 10002;
        /// <summary>
        /// 消息_标注板_设置背景图片
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_SET_BKG = 10003;
        /// <summary>
        /// 消息_标注板_设置画笔颜色, lParam颜色
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_SET_PEN_COLOR = 10004;
        /// <summary>
        /// 消息_标注板_取闭合路径点数组EX_POLYGON_ARRAY*指针, ret返回,不要释放
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_GET_DATA = 10005;
        /// <summary>
        /// 消息_标注板_置闭合路径点数组EX_POLYGON_ARRAY*指针,lParam设置,内部原指针释放,无需设置临时点,只需设置闭合路径
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_SET_DATA = 10006;
        /// <summary>
        /// 消息_标注板_取图像缩放系数,ret返回小数指针,不要释放
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_GET_IMG_SCALE = 10007;
        /// <summary>
        /// 消息_标注板_取图像缩放后横坐标偏移, ret返回
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_GET_IMG_LEFT_OFFSET = 10008;
        /// <summary>
        /// 消息_标注板_取图像缩放后纵坐标偏移, ret返回
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_GET_IMG_TOP_OFFSET = 10009;
        /// <summary>
        /// 消息_标注板_删除路径, lParam路径索引,索引从1开始
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_DELETE_PATH = 10010;
        /// <summary>
        /// 消息_标注板_获取选中路径, 索引从1开始, 未选中返回0
        /// </summary>
        public const int TAGGINGBOARD_MESSAGE_GET_HIT_PATH = 10011;
        #endregion

        #region 事件_标注板_
        /// <summary>
        /// 事件_标注板_激活闭合路径,lParam返回路径索引,从1开始
        /// </summary>
        ///
        public const int TAGGINGBOARD_EVENT_HIT_PATH = 20000;
        /// <summary>
        /// 事件_标注板_鼠标移动, wParam返回鼠标所处图横坐标,lParam返回鼠标所处图纵坐标
        /// </summary>
        public const int TAGGINGBOARD_EVENT_MOUSE_MOVE = 20001;
        #endregion
    }
}
