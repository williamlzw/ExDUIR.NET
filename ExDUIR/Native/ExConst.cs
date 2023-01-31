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
        public const int SB_HORZ = 0;
        /// <summary>
        /// 滚动条类型_垂直滚动条
        /// </summary>
        ///
        public const int SB_VERT = 1;
        /// <summary>
        /// 滚动条类型_滚动条控制器
        /// </summary>
        ///
        public const int SB_CTL = 2;
        /// <summary>
        /// 滚动条类型_水平和垂直滚动条
        /// </summary>
        ///
        public const int SB_BOTH = 3;
        #endregion

        #region 滚动条风格_
        /// <summary>
        /// 滚动条风格_水平滚动条
        /// </summary>
        ///
        public const int ESS_HORIZONTALSCROLL = 0;
        /// <summary>
        /// 滚动条风格_垂直滚动条
        /// </summary>
        ///
        public const int ESS_VERTICALSCROLL = 1;
        /// <summary>
        /// 滚动条风格_左顶对齐
        /// </summary>
        ///
        public const int ESS_LEFTTOPALIGN = 2;
        /// <summary>
        /// 滚动条风格_右底对齐
        /// </summary>
        ///
        public const int ESS_RIGHTBOTTOMALIGN = 4;
        /// <summary>
        /// 滚动条风格_控制按钮
        /// </summary>
        ///
        public const int ESS_CONTROLBUTTON = 8;

        #endregion

        #region 背景标识_
        /// <summary>
        /// 背景标识_默认
        /// </summary>
        ///
        public const int BIF_DEFAULT = 0;
        /// <summary>
        /// 背景标识_播放动画
        /// </summary>
        ///
        public const int BIF_PLAYIMAGE = 1;
        /// <summary>
        /// 背景标识_禁用缩放
        /// </summary>
        ///
        public const int BIF_DISABLESCALE = 2;
        /// <summary>
        /// 背景标识_九宫矩形_排除中间区域
        /// </summary>
        ///
        public const int BIF_GRID_EXCLUSION_CENTER = 4;
        /// <summary>
        /// 背景标识_X使用百分比单位
        /// </summary>
        ///
        public const int BIF_POSITION_Y_PERCENT = 8;
        /// <summary>
        /// 背景标识_Y使用百分比单位
        /// </summary>
        ///
        public const int BIF_POSITION_X_PERCENT = 16;

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
        public const int RMN_CLICK = -2;
        #endregion

        #region 消息_卷帘菜单_
        /// <summary>
        /// 消息_卷帘菜单_添加分组  wParam :索引(从1开始)  lParam: ROLLMENU_DATA * 指针
        /// </summary>
        public const int RM_ADDGROUP = 10010;
        /// <summary>
        /// 消息_卷帘菜单_添加子项  wParam :分组索引(从1开始)  lParam: ROLLMENU_ITEM * 指针
        /// </summary>
        public const int RM_ADDITEM = 10011;
        /// <summary>
        /// 消息_卷帘菜单_删除分组  wParam :分组索引(从1开始)  lParam:未定义   return: BOOL 
        /// </summary>
        public const int RM_DELGROUP = 10012;
        /// <summary>
        /// 消息_卷帘菜单_删除子项  wParam :分组索引(从1开始)  lParam:子项索引(从1开始) return: BOOL 
        /// </summary>
        public const int RM_DELITEM = 10013;
        /// <summary>
        /// 消息_卷帘菜单_设置分组状态(展开/收缩)  wParam :分组索引(从1开始)  lParam: 状态(BOOL)
        /// </summary>
        public const int RM_SETEXPAND = 10014;
        /// <summary>
        /// 消息_卷帘菜单_取当前选中子项  wParam: [int*] 分组索引(从1开始)  lParam: [int*] 子项索引(从1开始)  return:子项标题
        /// </summary>
        public const int RM_GETSEL = 10015;
        /// <summary>
        /// 消息_卷帘菜单_置当前选中子项  wParam: 分组索引(从1开始)  lParam : 子项索引(从1开始) return: BOOL
        /// </summary>
        public const int RM_SETSEL = 10016;
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
        public const int EOS_DISABLENOSCROLL = 0x2000000;

        /// <summary>
        /// 组件风格_可调整尺寸
        /// </summary>
        public const int EOS_SIZEBOX = 0x4000000;

        /// <summary>
        /// 组件风格_禁止
        /// </summary>
        public const int EOS_DISABLED = 0x8000000;

        /// <summary>
        /// 组件风格_可视
        /// </summary>
        public const int EOS_VISIBLE = 0x10000000;

        /// <summary>
        /// 组件风格_边框
        /// </summary>
        public const int EOS_BORDER = 0x20000000;

        /// <summary>
        /// 组件风格_垂直滚动条
        /// </summary>
        public const int EOS_VSCROLL = 0x40000000;

        /// <summary>
        /// 组件风格_水平滚动条
        /// </summary>
        public const int EOS_HSCROLL = -2147483648;

        /// <summary>
        /// 组件风格_扩展_自适应尺寸
        /// </summary>
        public const int EOS_EX_AUTOSIZE = 0x400000;

        /// <summary>
        /// 组件风格_扩展_鼠标穿透
        /// </summary>
        public const int EOS_EX_TRANSPARENT = 0x800000;

        /// <summary>
        /// 组件风格_扩展_背景模糊
        /// </summary>
        public const int EOS_EX_BLUR = 0x1000000;

        /// <summary>
        /// 组件风格_扩展_允许拖拽
        /// </summary>
        public const int EOS_EX_DRAGDROP = 0x2000000;

        /// <summary>
        /// 组件风格_扩展_接收文件拖放
        /// </summary>
        public const int EOS_EX_ACCEPTFILES = 0x4000000;

        /// <summary>
        /// 组件风格_扩展_允许焦点
        /// </summary>
        public const int EOS_EX_FOCUSABLE = 0x8000000;

        /// <summary>
        /// 组件风格_扩展_允许TAB焦点
        /// </summary>
        public const int EOS_EX_TABSTOP = 0x10000000;

        /// <summary>
        /// 组件风格_扩展_总在最前
        /// </summary>
        public const int EOS_EX_TOPMOST = 0x20000000;

        /// <summary>
        /// 组件风格_扩展_背景混合
        /// </summary>
        public const int EOS_EX_COMPOSITED = 0x40000000;

        /// <summary>
        /// 组件风格_扩展_自定义绘制
        /// </summary>
        public const int EOS_EX_CUSTOMDRAW = -2147483648;
        #endregion

        #region 组件数值_
        /// <summary>
        /// 组件数值_组件节点ID
        /// </summary>
        ///
        public const int EOL_NODEID = -1;

        /// <summary>
        /// 组件数值_组件模糊系数
        /// </summary>
        ///
        public const int EOL_BLUR = -2;

        /// <summary>
        /// 组件数值_组件回调
        /// </summary>
        ///
        public const int EOL_OBJPROC = -4;

        /// <summary>
        /// 组件数值_组件透明度
        /// </summary>
        ///
        public const int EOL_ALPHA = -5;

        /// <summary>
        /// 组件数值_自定义参数
        /// </summary>
        ///
        public const int EOL_LPARAM = -7;

        /// <summary>
        /// 组件数值_父句柄
        /// </summary>
        ///
        public const int EOL_OBJPARENT = -8;

        /// <summary>
        /// 组件数值_组件文本格式
        /// </summary>
        ///
        public const int EOL_TEXTFORMAT = -11;

        /// <summary>
        /// 组件数值_组件ID
        /// </summary>
        ///
        public const int EOL_ID = -12;

        /// <summary>
        /// 组件数值_组件基本风格
        /// </summary>
        ///
        public const int EOL_STYLE = -16;

        /// <summary>
        /// 组件数值_组件字体句柄
        /// </summary>
        ///
        public const int EOL_HFONT = -19;

        /// <summary>
        /// 组件数值_组件扩展风格
        /// </summary>
        ///
        public const int EOL_EXSTYLE = -20;

        /// <summary>
        /// 组件数值_用户数据
        /// </summary>
        ///
        public const int EOL_USERDATA = -21;

        /// <summary>
        /// 组件数值_画布句柄（不要乱改）
        /// </summary>
        ///
        public const int EOL_HCANVAS = -22;

        /// <summary>
        /// 组件数值_控件数据（不要乱改）
        /// </summary>
        ///
        public const int EOL_OWNER = -23;

        /// <summary>
        /// 组件数值_组件状态
        /// </summary>
        ///
        public const int EOL_STATE = -24;

        /// <summary>
        /// 组件数值_组件标题内容指针
        /// </summary>
        ///
        public const int EOL_LPWZTITLE = -28;

        /// <summary>
        /// 组件数值_光标句柄
        /// </summary>
        ///
        public const int EOL_CURSOR = -17;
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
        public const int BIR_DEFAULT = 0;
        /// <summary>
        /// 背景重复模式_平铺不重复
        /// </summary>
        ///
        public const int BIR_NO_REPEAT = 1;
        /// <summary>
        /// 背景重复模式_水平、垂直重复平铺
        /// </summary>
        ///
        public const int BIR_REPEAT = 2;
        /// <summary>
        /// 背景重复模式_水平重复平铺
        /// </summary>
        ///
        public const int BIR_REPEAT_X = 3;
        /// <summary>
        /// 背景重复模式_垂直重复平铺
        /// </summary>
        ///
        public const int BIR_REPEAT_Y = 4;
        #endregion

        #region 编辑框风格_
        /// <summary>
        /// 编辑框风格_允许拖拽  
        /// </summary>
        ///
        public const int EES_DISABLEDRAG = 1;
        /// <summary>
        /// 编辑框风格_密码输入
        /// </summary>
        ///
        public const int EES_USEPASSWORD = 2;
        /// <summary>
        /// 编辑框风格_显示选择文本
        /// </summary>
        ///
        public const int EES_HIDESELECTION = 4;
        /// <summary>
        /// 编辑框风格_丰富文本
        /// </summary>
        ///
        public const int EES_RICHTEXT = 8;
        /// <summary>
        /// 编辑框风格_允许鸣叫
        /// </summary>
        ///
        public const int EES_ALLOWBEEP = 16;
        /// <summary>
        /// 编辑框风格_只读
        /// </summary>
        ///
        public const int EES_READONLY = 32;
        /// <summary>
        /// 编辑框风格_回车换行
        /// </summary>
        ///
        public const int EES_NEWLINE = 64;
        /// <summary>
        /// 编辑框风格_数值输入
        /// </summary>
        ///
        public const int EES_NUMERICINPUT = 128;
        /// <summary>
        /// 编辑框风格_自动选择字符
        /// </summary>
        ///
        public const int EES_AUTOWORDSEL = 256;
        /// <summary>
        /// 编辑框风格_禁用右键默认菜单
        /// </summary>
        ///
        public const int EES_DISABLEMENU = 512;
        /// <summary>
        /// 编辑框风格_解析URL
        /// </summary>
        ///
        public const int EES_PARSEURL = 1024;
        /// <summary>
        /// 编辑框风格_允许TAB字符
        /// </summary>
        ///
        public const int EES_ALLOWTAB = 2048;
        /// <summary>
        /// 编辑框风格_总是显示提示文本
        /// </summary>
        ///
        public const int EES_SHOWTIPSALWAYS = 4096;
        /// <summary>
        /// 编辑框风格_隐藏插入符
        /// </summary>
        ///
        public const int EES_HIDDENCARET = 8192;
        /// <summary>
        /// 编辑框风格_下划线
        /// </summary>
        ///
        public const int EES_UNDERLINE = 16384;
        #endregion

        #region 消息_列表_
        /// <summary>
        /// 消息_列表_获取表项 (LISTBUTTON wParam为项目索引, lParam为EX_REPORTLIST_ITEMINFO指针或EX_LISTBUTTON_ITEMINFO指针)
        /// </summary>
        ///
        public const int LVM_GETITEM = 4101;
        /// <summary>
        /// 消息_列表_设置表项 (wParam为是否重画,lParam为EX_REPORTLIST_ITEMINFO或EX_LISTBUTTON_ITEMINFO指针)
        /// </summary>
        ///
        public const int LVM_SETITEM = 4102;
        /// <summary>
        /// 消息_报表_获取表项文本 (wParam若不为0则为表项索引,lParam为EX_REPORTLIST_ITEMINFO指针)
        /// </summary>
        ///
        public const int LVM_GETITEMTEXT = 4141;
        /// <summary>
        /// 消息_报表_设置表项文本 (wParam若不为0则为表项索引,lParam为EX_REPORTLIST_ITEMINFO指针)
        /// </summary>
        ///
        public const int LVM_SETITEMTEXT = 4142;
        /// <summary>
        /// 消息_报表_插入列 (wParm为是否立即更新,lParam为EX_REPORTLIST_COLUMNINFO指针)
        /// </summary>
        ///
        public const int LVM_INSERTCOLUMN = 4123;
        /// <summary>
        /// 消息_报表_删除列 (wParm为是否立即更新,lParam为列索引从1开始)
        /// </summary>
        ///
        public const int LVM_DELETECOLUMN = 4124;
        /// <summary>
        /// 消息_报表_排序 (lParam为EX_REPORTLIST_SORTINFO指针)
        /// </summary>
        ///
        public const int LVM_SORTITEMS = 4144;
        /// <summary>
        /// 消息_列表_更新列表框
        /// </summary>
        ///
        public const int LVM_UPDATE = 4138;
        /// <summary>
        /// 消息_报表_删除所有列
        /// </summary>
        ///
        public const int LVM_DELETEALLCOLUMN = 4900;
        /// <summary>
        /// 消息_报表_获取列数
        /// </summary>
        ///
        public const int LVM_GETCOLUMNCOUNT = 4901;
        /// <summary>
        ///  消息_报表_获取列信息 (wParam为列索引,lParam为 EX_REPORTLIST_COLUMNINFO 指针)
        /// </summary>
        ///
        public const int LVM_GETCOLUMN = 4121;
        /// <summary>
        /// 消息_报表_设置列信息 (wParam低位为列索引,高位为是否立即刷新,lParam为 EX_REPORTLIST_COLUMNINFO 指针)
        /// </summary>
        ///
        public const int LVM_SETCOLUMN = 4122;
        /// <summary>
        /// 消息_报表_设置列标题 (wParam低位为列索引,高位为是否立即刷新,lParam为 宽文本指针)
        /// </summary>
        ///
        public const int LVM_SETCOLUMNTEXT = 4904;
        /// <summary>
        /// 消息_报表_获取列标题 (wParam为列索引,lParam为 宽文本指针)
        /// </summary>
        ///
        public const int LVM_GETCOLUMNTEXT = 4905;
        /// <summary>
        /// 消息_报表_获取列宽
        /// </summary>
        ///
        public const int LVM_GETCOLUMNWIDTH = 4125;
        /// <summary>
        /// 消息_报表_设置列宽 (wParam为列索引,lParam为 列宽)
        /// </summary>
        ///
        public const int LVM_SETCOLUMNWIDTH = 4126;
        /// <summary>
        /// 消息_列表_设置表项高度 (lParam为新行高)
        /// </summary>
        ///
        public const int LVM_SETITEMHEIGHT = 4908;
        /// <summary>
        /// 消息_列表_获取表项高度
        /// </summary>
        ///
        public const int LVM_GETITEMHEIGHT = 4909;
        /// <summary>
        /// 消息_列表_获取图片组
        /// </summary>
        ///
        public const int LVM_GETIMAGELIST = 4098;
        /// <summary>
        /// 消息_列表_设置图片组 (wParam为是否立即重画,lParam为图片组句柄)
        /// </summary>
        ///
        public const int LVM_SETIMAGELIST = 4099;
        /// <summary>
        /// 消息_列表_命中测试 lParam为 返回列表命中测试_
        /// </summary>
        ///
        public const int LVM_HITTEST = 4114;
        /// <summary>
        /// 消息_列表_清空表项
        /// </summary>
        ///
        public const int LVM_DELETEALLITEMS = 4015;
        /// <summary>
        /// 消息_列表_删除表项,wParam为是否立即重画，lParam为删除的索引
        /// </summary>
        ///
        public const int LVM_DELETEITEM = 4104;
        /// <summary>
        /// 消息_列表_保证显示表项
        /// </summary>
        ///
        public const int LVM_ENSUREVISIBLE = 4115;
        /// <summary>
        /// 消息_列表_取可视区表项数
        /// </summary>
        ///
        public const int LVM_GETCOUNTPERPAGE = 4136;
        /// <summary>
        /// 消息_列表_取表项总数
        /// </summary>
        ///
        public const int LVM_GETITEMCOUNT = 4100;
        /// <summary>
        /// 消息_列表_取表项矩形
        /// </summary>
        ///
        public const int LVM_GETITEMRECT = 4110;
        /// <summary>
        /// 消息_列表_取被选择表项数
        /// </summary>
        ///
        public const int LVM_GETSELECTEDCOUNT = 4146;
        /// <summary>
        /// 消息_列表_取现行选中项
        /// </summary>
        ///
        public const int LVM_GETSELECTIONMARK = 4162;
        /// <summary>
        /// 置现行选择项目
        /// </summary>
        ///
        public const int LVM_SETSELECTIONMARK = 4163;
        /// <summary>
        /// 消息_列表_取可视区起始索引
        /// </summary>
        ///
        public const int LVM_GETTOPINDEX = 4135;
        /// <summary>
        /// 消息_列表_插入表项 lParam 为EX_REPORTLIST_ROWINFO指针,wParam为是否立即重画,返回索引
        /// </summary>
        ///
        public const int LVM_INSERTITEM = 4103;
        /// <summary>
        /// 消息_列表_重画表项 wParam为起始项目,lParam 为结束项目
        /// </summary>
        ///
        public const int LVM_REDRAWITEMS = 4117;
        /// <summary>
        /// 消息_列表_设置表项总数 wParam为表项条数,lParmam为MAKELONG(LVSICF_NOSCROLL, 表项条数)
        /// </summary>
        ///
        public const int LVM_SETITEMCOUNT = 4143;
        /// <summary>
        /// 消息_列表_取表项状态
        /// </summary>
        ///
        public const int LVM_GETITEMSTATE = 4140;
        /// <summary>
        /// 消息_列表_置表项状态
        /// </summary>
        ///
        public const int LVM_SETITEMSTATE = 4139;
        /// <summary>
        /// 消息_列表_取鼠标所在表项
        /// </summary>
        ///
        public const int LVM_GETHOTITEM = 4157;
        /// <summary>
        /// 消息_列表_重新计算尺寸
        /// </summary>
        ///
        public const int LVM_CALCITEMSIZE = 5150;
        /// <summary>
        /// 消息_列表_取消主题 不绘制列表主题 1为取消
        /// </summary>
        ///
        public const int LVM_CANCELTHEME = 5151;
        #endregion

        #region 事件_列表_
        /// <summary>
        /// 事件_列表_现行选中项被改变,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LVN_ITEMCHANGED = -101;
        /// <summary>
        /// 事件_列表_表项选中状态,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LVN_ITEMSELECTD = -102;
        /// <summary>
        /// 事件_列表_表项选中状态取消,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LVN_ITEMSELECTC = -103;
        /// <summary>
        /// 事件_列表_表项被右击,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LVN_ITEMRCLICK = -104;
        /// <summary>
        /// 事件_列表_表项被双击,wParam项目索引从1开始
        /// </summary>
        ///
        public const int LVN_ITEMDCLICK = -105;
        /// <summary>
        /// 事件_列表_悬浮跟踪
        /// </summary>
        ///
        public const int LVN_HOTTRACK = -121;
        #endregion

        #region 缓动类型_
        /// <summary>
        /// 缓动类型_线性
        /// </summary>
        ///
        public const int ET_Linear = 1;
        /// <summary>
        /// 缓动类型_圆线性插值
        /// </summary>
        ///
        public const int ET_Clerp = 2;
        /// <summary>
        /// 缓动类型_弹性
        /// </summary>
        ///
        public const int ET_Spring = 3;
        /// <summary>
        /// 缓动类型_冲击
        /// </summary>
        ///
        public const int ET_Punch = 4;
        /// <summary>
        /// 缓动类型_二次方_In
        /// </summary>
        ///
        public const int ET_InQuad = 5;
        /// <summary>
        /// 缓动类型_二次方_Out
        /// </summary>
        ///
        public const int ET_OutQuad = 6;
        /// <summary>
        /// 缓动类型_二次方_InOut
        /// </summary>
        ///
        public const int ET_InOutQuad = 7;
        /// <summary>
        /// 缓动类型_三次方_In
        /// </summary>
        ///
        public const int ET_InCubic = 8;
        /// <summary>
        /// 缓动类型_三次方_Out
        /// </summary>
        ///
        public const int ET_OutCubic = 9;
        /// <summary>
        /// 缓动类型_三次方_InOut
        /// </summary>
        ///
        public const int ET_InOutCubic = 10;
        /// <summary>
        /// 缓动类型_四次方_In
        /// </summary>
        ///
        public const int ET_InQuart = 11;
        /// <summary>
        /// 缓动类型_四次方_Out
        /// </summary>
        ///
        public const int ET_OutQuart = 12;
        /// <summary>
        /// 缓动类型_四次方_InOut
        /// </summary>
        ///
        public const int ET_InOutQuart = 13;
        /// <summary>
        /// 缓动类型_五次方_In
        /// </summary>
        ///
        public const int ET_InQuint = 14;
        /// <summary>
        /// 缓动类型_五次方_Out
        /// </summary>
        ///
        public const int ET_OutQuint = 15;
        /// <summary>
        /// 缓动类型_五次方_InOut
        /// </summary>
        ///
        public const int ET_InOutQuint = 16;
        /// <summary>
        /// 缓动类型_正弦曲线_In
        /// </summary>
        ///
        public const int ET_InSine = 17;
        /// <summary>
        /// 缓动类型_正弦曲线_Out
        /// </summary>
        ///
        public const int ET_OutSine = 18;
        /// <summary>
        /// 缓动类型_正弦曲线_InOut
        /// </summary>
        ///
        public const int ET_InOutSine = 19;
        /// <summary>
        /// 缓动类型_指数曲线_In
        /// </summary>
        ///
        public const int ET_InExpo = 20;
        /// <summary>
        /// 缓动类型_指数曲线_Out
        /// </summary>
        ///
        public const int ET_OutExpo = 21;
        /// <summary>
        /// 缓动类型_指数曲线_InOut
        /// </summary>
        ///
        public const int ET_InOutExpo = 22;
        /// <summary>
        /// 缓动类型_圆曲线_In
        /// </summary>
        ///
        public const int ET_InCirc = 23;
        /// <summary>
        /// 缓动类型_圆曲线_Out
        /// </summary>
        ///
        public const int ET_OutCirc = 24;
        /// <summary>
        /// 缓动类型_圆曲线_InOut
        /// </summary>
        ///
        public const int ET_InOutCirc = 25;
        /// <summary>
        /// 缓动类型_反弹_In
        /// </summary>
        ///
        public const int ET_InBounce = 26;
        /// <summary>
        /// 缓动类型_反弹_Out
        /// </summary>
        ///
        public const int ET_OutBounce = 27;
        /// <summary>
        /// 缓动类型_反弹_InOuts
        /// </summary>
        ///
        public const int ET_InOutBounce = 28;
        /// <summary>
        /// 缓动类型_三次方溢出_In
        /// </summary>
        ///
        public const int ET_InBack = 29;
        /// <summary>
        /// 缓动类型_三次方溢出_Out
        /// </summary>
        ///
        public const int ET_OutBack = 30;
        /// <summary>
        /// 缓动类型_三次方溢出_InOut
        /// </summary>
        ///
        public const int ET_InOutBack = 31;
        /// <summary>
        /// 缓动类型_正弦曲线指数衰减_In
        /// </summary>
        ///
        public const int ET_InElastic = 32;
        /// <summary>
        /// 缓动类型_正弦曲线指数衰减_Out
        /// </summary>
        ///
        public const int ET_OutElastic = 33;
        /// <summary>
        /// 缓动类型_正弦曲线指数衰减_InOut
        /// </summary>
        ///
        public const int ET_InOutElastic = 34;
        /// <summary>
        /// 缓动类型_自定义 pEasingContext为自定义回调函数(nProcess,nStart,nStop,nCurrent///,pEasingContext)
        /// </summary>
        ///
        public const int ET_CUSTOM = 50;
        /// <summary>
        /// 缓动类型_曲线 pEasingContext为pCurveInfo(_easing_load_curve)
        /// </summary>
        ///
        public const int ET_CURVE = 51;
        #endregion

        #region 缓动模式_
        //<summary>
        ///// 缓动模式_单次
        //</summary>
        public const int ES_SINGLE = 1;
        /// <summary>
        /// 缓动模式_循环,注意自行停止
        /// </summary>
        ///
        public const int ES_CYCLE = 2;
        /// <summary>
        /// 缓动模式_多次,高位则为次数
        /// </summary>
        ///
        public const int ES_MANYTIMES = 4;
        /// <summary>
        /// 缓动模式_顺序
        /// </summary>
        ///
        public const int ES_ORDER = 8;
        /// <summary>
        /// 缓动模式_逆序
        /// </summary>
        ///
        public const int ES_REVERSE = 16;
        /// <summary>
        /// 缓动模式_来回
        /// </summary>
        ///
        public const int ES_BACKANDFORTH = 32;
        /// <summary>
        /// 缓动模式_调用函数 pContext为回调函数,bool isStop Cbk(pEasingProgress,double nProgress,double nCurrent,pEasingContext,nTimesSurplus,Param1,Param2,Param3,Param4)
        /// </summary>
        ///
        public const int ES_CALLFUNCTION = 64;
        /// <summary>
        /// 缓动模式_分发消息 pContext为hObj或hExDUI, wParam:pEasing,lParam:lpEasingInfo,result:isStop
        /// </summary>
        ///
        public const int ES_DISPATCHNOTIFY = 128;
        /// <summary>
        /// 缓动模式_使用线程 使用线程处理,否则在UI线程处理(过程中会阻塞输入)
        /// </summary>
        ///
        public const int ES_THREAD = 256;
        /// <summary>
        /// 缓动模式_释放曲线 当使用曲线类型时生效,在结束时会自动释放曲线指针
        /// </summary>
        ///
        public const int ES_RELEASECURVE = 512;
        #endregion

        #region 缓动状态_
        /// <summary>
        /// 缓动状态_播放    
        /// </summary>
        ///
        public const int EES_PLAY = 0;
        /// <summary>
        /// 缓动状态_暂停
        /// </summary>
        ///
        public const int EES_PAUSE = 1;
        /// <summary>
        /// 缓动状态_停止
        /// </summary>
        ///
        public const int EES_STOP = 2;
        #endregion

        #region 布局类型_
        /// <summary>
        /// 布局类型_无
        /// </summary>
        ///
        public const int ELT_NULL = 0;

        /// <summary>
        /// 布局类型_线性
        /// </summary>
        ///
        public const int ELT_LINEAR = 1;

        /// <summary>
        /// 布局类型_流式
        /// </summary>
        ///
        public const int ELT_FLOW = 2;

        /// <summary>
        /// 布局类型_页面
        /// </summary>
        ///
        public const int ELT_PAGE = 3;

        /// <summary>
        /// 布局类型_表格
        /// </summary>
        ///
        public const int ELT_TABLE = 4;

        /// <summary>
        /// 布局类型_相对
        /// </summary>
        ///
        public const int ELT_RELATIVE = 5;

        /// <summary>
        /// 布局类型_绝对
        /// </summary>
        ///
        public const int ELT_ABSOLUTE = 6;
        #endregion

        #region 布局属性_
        /// <summary>
        /// 布局属性_通用_内间距_左
        /// </summary>
        ///
        public const int ELP_PADDING_LEFT = -1;
        /// <summary>
        /// 布局属性_通用_内间距_顶
        /// </summary>
        ///
        public const int ELP_PADDING_TOP = -2;
        /// <summary>
        /// 布局属性_通用_内间距_右
        /// </summary>
        ///
        public const int ELP_PADDING_RIGHT = -3;
        /// <summary>
        /// 布局属性_通用_内间距_底
        /// </summary>
        ///
        public const int ELP_PADDING_BOTTOM = -4;
        /// <summary>
        /// 布局属性:方向
        /// </summary>
        ///
        public const int ELP_LINEAR_DIRECTION = 1;
        /// <summary>
        /// 方向:水平
        /// </summary>
        ///
        public const int ELP_DIRECTION_H = 0;
        /// <summary>
        /// 方向:垂直
        /// </summary>
        ///
        public const int ELP_DIRECTION_V = 1;
        /// <summary>
        /// 布局属性:布局方向对齐方式
        /// </summary>
        ///
        public const int ELP_LINEAR_DALIGN = 2;
        /// <summary>
        /// 线性布局对齐方式_左上
        /// </summary>
        ///
        public const int ELP_LINEAR_DALIGN_LEFT_TOP = 0;
        /// <summary>
        /// 线性布局对齐方式_居中
        /// </summary>
        ///
        public const int ELP_LINEAR_DALIGN_CENTER = 1;
        /// <summary>
        /// 线性布局对齐方式_右下
        /// </summary>
        ///
        public const int ELP_LINEAR_DALIGN_RIGHT_BOTTOM = 2;
        /// <summary>
        /// 布局属性:方向
        /// </summary>
        ///
        public const int ELP_FLOW_DIRECTION = 1;
        /// <summary>
        /// 布局属性:当前显示页面索引
        /// </summary>
        ///
        public const int ELP_PAGE_CURRENT = 1;
        #endregion

        #region 布局子属性_
        /// <summary>
        /// 布局子属性_通用_外间距_左
        /// </summary>
        ///
        public const int ELCP_MARGIN_LEFT = -1;
        /// <summary>
        /// 布局子属性_通用_外间距_顶
        /// </summary>
        ///
        public const int ELCP_MARGIN_TOP = -2;
        /// <summary>
        /// 布局子属性_通用_外间距_右
        /// </summary>
        ///
        public const int ELCP_MARGIN_RIGHT = -3;
        /// <summary>
        /// 布局子属性_通用_外间距_底
        /// </summary>
        ///
        public const int ELCP_MARGIN_BOTTOM = -4;
        /// <summary>
        /// 线性布局子属性_尺寸 [-1或未填写为组件当前尺寸]
        /// </summary>
        ///
        public const int ELCP_LINEAR_SIZE = 1;
        /// <summary>
        /// 线性布局另一个方向对齐方式_填满
        /// </summary>
        ///
        public const int ELCP_LINEAR_ALGIN_FILL = 0;
        /// <summary>
        /// 线性布局另一个方向对齐方式_左上
        /// </summary>
        ///
        public const int ELCP_LINEAR_ALIGN_LEFT_TOP = 1;
        /// <summary>
        /// 线性布局另一个方向对齐方式_居中
        /// </summary>
        ///
        public const int ELCP_LINEAR_ALIGN_CENTER = 2;
        /// <summary>
        /// 线性布局另一个方向对齐方式_右下
        /// </summary>
        ///
        public const int ELCP_LINEAR_ALIGN_RIGHT_BOTTOM = 3;
        /// <summary>
        /// 布局子属性:另外一个方向的对齐方式
        /// </summary>
        ///
        public const int ELCP_LINEAR_ALIGN = 2;
        /// <summary>
        /// 布局子属性:尺寸[-1或未填写为组件当前尺寸]
        /// </summary>
        ///
        public const int ELCP_FLOW_SIZE = 1;
        /// <summary>
        /// 布局子属性:组件强制换行
        /// </summary>
        ///
        public const int ELCP_FLOW_NEW_LINE = 2;
        /// <summary>
        /// 布局子属性:是否填充整个布局
        /// </summary>
        ///
        public const int ELCP_PAGE_FILL = 1;
        /// <summary>
        /// 布局子属性_表格_所在行
        /// </summary>
        ///
        public const int ELCP_TABLE_ROW = 1;
        /// <summary>
        /// 布局子属性_表格_所在列
        /// </summary>
        ///
        public const int ELCP_TABLE_CELL = 2;
        /// <summary>
        /// 布局子属性_表格_跨行数
        /// </summary>
        ///
        public const int ELCP_TABLE_ROW_SPAN = 3;
        /// <summary>
        /// 布局子属性_表格_跨列数
        /// </summary>
        ///
        public const int ELCP_TABLE_CELL_SPAN = 4;
        /// <summary>
        /// 布局子属性_表格_是否填满
        /// </summary>
        ///
        public const int ELCP_TABLE_FILL = 5;
        /// <summary>
        /// 布局子属性_相对_左侧于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_LEFT_OF = 1;
        /// <summary>
        /// 布局子属性_相对_之上于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_TOP_OF = 2;
        /// <summary>
        /// 布局子属性_相对_右侧于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_RIGHT_OF = 3;
        /// <summary>
        /// 布局子属性_相对_之下于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_BOTTOM_OF = 4;
        /// <summary>
        /// 布局子属性_相对_左对齐于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_LEFT_ALIGN_OF = 5;
        /// <summary>
        /// 布局子属性_相对_顶对齐于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_TOP_ALIGN_OF = 6;
        /// <summary>
        /// 布局子属性_相对_右对齐于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_RIGHT_ALIGN_OF = 7;
        /// <summary>
        /// 布局子属性_相对_底对齐于(组件)
        /// </summary>
        ///
        public const int ELCP_RELATIVE_BOTTOM_ALIGN_OF = 8;
        /// <summary>
        /// 布局子属性_相对_水平居中于父
        /// </summary>
        ///
        public const int ELCP_RELATIVE_CENTER_PARENT_H = 9;
        /// <summary>
        /// 布局子属性_相对_垂直居中于父
        /// </summary>
        ///
        public const int ELCP_RELATIVE_CENTER_PARENT_V = 10;
        /// <summary>
        /// 布局子属性_绝对_左侧
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_LEFT = 1;
        /// <summary>
        /// 布局子属性_绝对_左侧类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_LEFT_TYPE = 2;
        /// <summary>
        /// 布局子属性_绝对_顶部
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_TOP = 3;
        /// <summary>
        /// 布局子属性_绝对_顶部类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_TOP_TYPE = 4;
        /// <summary>
        /// 布局子属性_绝对_右侧
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_RIGHT = 5;
        /// <summary>
        /// 布局子属性_绝对_右侧类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_RIGHT_TYPE = 6;
        /// <summary>
        /// 布局子属性_绝对_底部
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_BOTTOM = 7;
        /// <summary>
        /// 布局子属性_绝对_底部类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_BOTTOM_TYPE = 8;
        /// <summary>
        /// 布局子属性_绝对_宽度（优先级低于右侧）
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_WIDTH = 9;
        /// <summary>
        /// 布局子属性_绝对_宽度类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_WIDTH_TYPE = 10;
        /// <summary>
        /// 布局子属性_绝对_高度（优先级低于底部）
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_HEIGHT = 11;
        /// <summary>
        /// 布局子属性_绝对_高度类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_HEIGHT_TYPE = 12;
        /// <summary>
        /// 布局属性_绝对_水平偏移量
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_OFFSET_H = 13;
        /// <summary>
        /// 布局子属性_绝对_水平偏移量类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_OFFSET_H_TYPE = 14;
        /// <summary>
        /// 布局子属性_绝对_垂直偏移量
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_OFFSET_V = 15;
        /// <summary>
        /// 布局子属性_绝对_垂直偏移量类型
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_OFFSET_V_TYPE = 16;
        /// <summary>
        /// 布局子属性_绝对_类型_未知(未设置或保持不变)
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_TYPE_UNKNOWN = 0;
        /// <summary>
        /// 布局子属性_绝对_类型_像素
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_TYPE_PX = 1;
        /// <summary>
        /// 布局子属性_绝对_类型_百分比
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_TYPE_PS = 2;
        /// <summary>
        /// 布局子属性_绝对_类型_组件尺寸百分比，仅OFFSET可用
        /// </summary>
        ///
        public const int ELCP_ABSOLUTE_TYPE_OBJPS = 3;
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
        public const int PBL_POS = 0;
        /// <summary>
        /// 进度条属性_范围
        /// </summary>
        ///
        public const int PBL_RANGE = 1;
        /// <summary>
        /// 进度条属性_圆角度
        /// </summary>
        ///
        public const int PBL_RADIUS = 2;
        /// <summary>
        /// 进度条属性_背景颜色
        /// </summary>
        ///
        public const int PBL_BKCOLOR = 3;
        /// <summary>
        /// 进度条属性_前景颜色
        /// </summary>
        ///
        public const int PBL_BARCOLOR = 4;
        #endregion

        #region 信息框标识_
        /// <summary>
        /// 信息框标识_显示窗口图标
        /// </summary>
        ///
        public const int EMBF_WINDOWICON = -2147483648;
        /// <summary>
        /// 信息框标识_消息框居父窗口中间
        /// </summary>
        ///
        public const int EMBF_CENTEWINDOW = 1073741824;
        /// <summary>
        /// 信息框标识_显示倒计时
        /// </summary>
        ///
        public const int EMBF_SHOWTIMEOUT = 536870912;
        #endregion

        #region 菜单标识_
        /// <summary>
        /// 菜单标识_不显示菜单阴影
        /// </summary>
        ///
        public const int EMNF_NOSHADOW = -2147483648;
        #endregion

        #region 引擎标识_
        /// <summary>
        /// 引擎标识_启用DPI缩放
        /// </summary>
        ///
        public const int EXGF_DPI_ENABLE = 0x02;

        /// <summary>
        /// 引擎标识_渲染_画布不抗锯齿
        /// </summary>
        ///
        public const int EXGF_RENDER_CANVAS_ALIAS = 0x40;

        /// <summary>
        /// 引擎标识_渲染_使用D2D
        /// </summary>
        ///
        public const int EXGF_RENDER_METHOD_D2D = 0x100;

        /// <summary>
        /// 引擎标识_渲染_使用支持GDI交互的D2D渲染
        /// </summary>
        ///
        public const int EXGF_RENDER_METHOD_D2D_GDI_COMPATIBLE = 0x300;

        /// <summary>
        /// 引擎标识_文本渲染_使用ClearType抗锯齿
        /// </summary>
        ///
        public const int EXGF_TEXT_CLEARTYPE = 0x400;

        /// <summary>
        /// 引擎标识_文本渲染_抗锯齿
        /// </summary>
        ///
        public const int EXGF_TEXT_ANTIALIAS = 0x800;

        /// <summary>
        /// 引擎标识_图像渲染_抗锯齿
        /// </summary>
        ///
        public const int EXGF_IMAGE_ANTIALIAS = 0x1000;

        /// <summary>
        /// 引擎标识_组件_禁用动画效果
        /// </summary>
        ///
        public const int EXGF_OBJECT_DISABLEANIMATION = 0x10000;

        /// <summary>
        /// 引擎标识_组件_显示组件边界
        /// </summary>
        ///
        public const int EXGF_OBJECT_SHOWRECTBORDER = 0x20000;

        /// <summary>
        /// 引擎标识_组件_显示组件位置
        /// </summary>
        ///
        public const int EXGF_OBJECT_SHOWPOSTION = 0x40000;

        /// <summary>
        /// 引擎标识_允许JS全局对象访问文件
        /// </summary>
        ///
        public const int EXGF_JS_FILE = 0x80000;

        /// <summary>
        /// 引擎标识_允许JS全局对象访问内存
        /// </summary>
        ///
        public const int EXGF_JS_MEMORY = 0x100000;

        /// <summary>
        /// 引擎标识_允许JS全局对象申请内存
        /// </summary>
        ///
        public const int EXGF_JS_MEMORY_ALLOC = 0x200000;

        /// <summary>
        /// 引擎标识_允许JS全局对象创建进程、允许程序、加载DLL
        /// </summary>
        ///
        public const int EXGF_JS_PROCESS = 0x400000;

        /// <summary>
        /// 引擎标识_允许JS全局对象访问所有资源
        /// </summary>
        ///
        public const int EXGF_JS_ALL = 0x780000;

        /// <summary>
        /// 引擎标识_菜单_渲染所有菜单
        /// </summary>
        ///
        public const int EXGF_MENU_ALL = 0x800000;
        #endregion

        #region 窗体风格_
        /// <summary>
        /// 窗体风格_关闭按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_CLOSE = 0x01;

        /// <summary>
        /// 窗体风格_最大化按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_MAX = 0x02;

        /// <summary>
        /// 窗体风格_最小化按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_MIN = 0x04;

        /// <summary>
        /// 窗体风格_菜单按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_MENU = 0x08;

        /// <summary>
        /// 窗体风格_皮肤按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_SKIN = 0x10;

        /// <summary>
        /// 窗体风格_设置按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_SETTING = 0x20;

        /// <summary>
        /// 窗体风格_帮助按钮
        /// </summary>
        ///
        public const int EWS_BUTTON_HELP = 0x40;

        /// <summary>
        /// 窗体风格_图标
        /// </summary>
        ///
        public const int EWS_HASICON = 0x80;

        /// <summary>
        /// 窗体风格_标题
        /// </summary>
        ///
        public const int EWS_TITLE = 0x100;

        /// <summary>
        /// 窗体风格_全屏模式.设置该标记窗口最大化时
        /// </summary>
        ///
        public const int EWS_FULLSCREEN = 0x200;

        /// <summary>
        /// 窗体风格_允许调整尺寸
        /// </summary>
        ///
        public const int EWS_SIZEABLE = 0x400;

        /// <summary>
        /// 窗体风格_允许随意移动
        /// </summary>
        ///
        public const int EWS_MOVEABLE = 0x800;

        /// <summary>
        /// 窗体风格_不显示窗口阴影
        /// </summary>
        ///
        public const int EWS_NOSHADOW = 0x1000;

        /// <summary>
        /// 窗体风格_不继承父窗口背景数据
        /// </summary>
        ///
        public const int EWS_NOINHERITBKG = 0x2000;

        /// <summary>
        /// 窗体风格_不显示TAB焦点边框
        /// </summary>
        ///
        public const int EWS_NOTABBORDER = 0x4000;

        /// <summary>
        /// 窗体风格_ESC关闭窗口
        /// </summary>
        ///
        public const int EWS_ESCEXIT = 0x8000;

        /// <summary>
        /// 窗体风格_主窗口(拥有该风格时 当窗口被关闭,会调用PostQuitMessage()退出消息循环)
        /// </summary>
        ///
        public const int EWS_MAINWINDOW = 0x10000;

        /// <summary>
        /// 窗体风格_窗口居中(如果有父窗口则在父窗口中间,否则为屏幕中间)
        /// </summary>
        ///
        public const int EWS_CENTERWINDOW = 0x20000;

        /// <summary>
        /// 窗体风格_标题栏取消置顶
        /// </summary>
        ///
        public const int EWS_NOCAPTIONTOPMOST = 0x40000;

        /// <summary>
        /// 窗体风格_弹出式窗口
        /// </summary>
        ///
        public const int EWS_POPUPWINDOW = 0x80000;

        #endregion

        #region 引擎数值_
        /// <summary>
        /// 引擎数值_背景模糊
        /// </summary>
        public const int EWL_BLUR = -2;

        /// <summary>
        /// 引擎数值_窗口消息过程
        /// </summary>
        public const int EWL_MSGPROC = -4;

        /// <summary>
        /// 引擎数值_窗口透明度
        /// </summary>
        public const int EWL_ALPHA = -5;

        /// <summary>
        /// 引擎数值_自定义参数
        /// </summary>
        public const int EWL_LPARAM = -7;

        /// <summary>
        /// 引擎数值_边框颜色
        /// </summary>
        public const int EWL_CRBORDER = -30;

        /// <summary>
        /// 引擎数值_背景颜色
        /// </summary>
        public const int EWL_CRBKG = -31;

        /// <summary>
        /// 引擎数值_阴影颜色
        /// </summary>
        public const int EWL_CRSD = -35;

        /// <summary>
        /// 引擎数值_最小高度
        /// </summary>
        public const int EWL_MINHEIGHT = -33;

        /// <summary>
        /// 引擎数值_最小宽度
        /// </summary>
        public const int EWL_MINWIDTH = -34;

        /// <summary>
        /// 引擎数值_焦点组件组件
        /// </summary>
        public const int EWL_OBJFOCUS = -53;

        /// <summary>
        /// 引擎数值_标题栏组件句柄
        /// </summary>
        public const int EWL_OBJCAPTION = -54;

        /// <summary>
        /// 引擎数值_阴影圆角大小
        /// </summary>
        public const int EWL_RADIUS = -11;
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
        public const int EBS_CHECKBUTTON = 1;
        /// <summary>
        /// 按钮风格_单选按钮
        /// </summary>
        public const int EBS_RADIOBUTTON = 2;
        /// <summary>
        /// 按钮风格_文本偏移
        /// </summary>
        public const int EBS_TEXTOFFSET = 4;
        /// <summary>
        /// 按钮风格_图标在右
        /// </summary>
        public const int EBS_ICONRIGHT = 8;
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
        public const int EPP_BEGIN = 0;
        /// <summary>
        /// 绘制进度_当控件绘制背景后
        /// </summary>
        public const int EPP_BKG = 1;
        /// <summary>
        /// 绘制进度_当控件绘制边框后
        /// </summary>
        ///
        public const int EPP_BORDER = 2;
        /// <summary>
        /// 绘制进度_当控件自定义绘制后
        /// </summary>
        ///
        public const int EPP_CUSTOMDRAW = 3;
        /// <summary>
        /// 绘制进度_当控件绘制结束后
        /// </summary>
        ///
        public const int EPP_END = 4;
        #endregion

        #region 列表风格_ 
        /// <summary>
        /// 列表风格_纵向列表
        /// </summary>
        ///
        public const int ELVS_VERTICALLIST = 0;
        /// <summary>
        /// 列表风格_横向列表
        /// </summary>
        ///
        public const int ELVS_HORIZONTALLIST = 0x01;
        /// <summary>
        /// 列表风格_允许多选
        /// </summary>
        ///
        public const int ELVS_ALLOWMULTIPLE = 0x08;
        /// <summary>
        /// 列表风格_表项跟踪
        /// </summary>
        ///
        public const int ELVS_ITEMTRACKING = 0x10;
        /// <summary>
        /// 列表风格_始终显示选择项
        /// </summary>
        ///
        public const int ELVS_SHOWSELALWAYS = 0x20;
        #endregion

        #region 消息_模板列表_
        /// <summary>
        /// 消息_模板列表_创建 返回值将作为列表项控件
        /// </summary>
        ///
        public const int TLVM_ITEM_CREATE = 10010;
        /// <summary>
        ///消息_模板列表_创建完毕
        /// </summary>
        ///
        public const int TLVM_ITEM_CREATED = 10011;
        /// <summary>
        /// 消息_模板列表_销毁
        /// </summary>
        ///
        public const int TLVM_ITEM_DESTROY = 10012;
        /// <summary>
        ///消息_模板列表_填充数据 wParam:nIndex,lParam:hObjItem
        /// </summary>
        ///
        public const int TLVM_ITEM_FILL = 10013;
        /// <summary>
        ///  消息_模板列表_置模板数据 wParam:cbSize,lParam:pTemplate
        /// </summary>
        ///
        public const int TLVM_SETTEMPLATE = 10020;
        /// <summary>
        /// 消息_模板列表_取项目句柄 wParam:表项索引,返回表项容器句柄(不在可视区返回0)
        /// </summary>
        ///
        public const int TLVM_GETITEMOBJ = 10021;
        /// <summary>
        /// 消息_模板列表_设置表项悬浮背景色 lParam:ARGB颜色
        /// </summary>
        ///
        public const int TLVM_SET_ITEM_HOVERCOLOR = 10022;
        /// <summary>
        /// 消息_模板列表_设置表项选中背景色 lParam:ARGB颜色
        /// </summary>
        ///
        public const int TLVM_SET_ITEM_SELECTCOLOR = 100023;
        #endregion

        #region 列表命中_
        /// <summary>
        /// 列表命中_未命中
        /// </summary>
        ///
        public const int LVHT_NOWHERE = 1;
        /// <summary>
        /// 列表命中_命中表项
        /// </summary>
        ///
        public const int LVHT_ONITEM = 14;
        #endregion

        #region 画布信息类型_
        /// <summary>
        /// 画布信息类型_D2D描述表
        /// </summary>
        ///
        public const int CVC_DX_D2DCONTEXT = 1;
        /// <summary>
        /// 画布信息类型_D2D图形
        /// </summary>
        ///
        public const int CVC_DX_D2DBITMAP = 2;
        /// <summary>
        /// 画布信息类型_GDI渲染目标
        /// </summary>
        ///
        public const int CVC_DX_GDIRENDERTARGET = 3;
        #endregion

        #region 画布标识_
        /// <summary>
        /// 画布标识_画布抗锯齿
        /// </summary>
        public const int CVF_CANVASANTIALIAS = 0x01;
        /// <summary>
        /// 画布标识_文本抗锯齿
        /// </summary>
        public const int CVF_TEXTANTIALIAS = 0x02;
        /// <summary>
        /// 画布标识_GDI和D2D混合
        /// </summary>
        public const int CVF_GDI_COMPATIBLE = 0x40000000;
        /// <summary>
        /// 画布标识_重置剪辑区
        /// </summary>
        public const int CVF_CLIPED = -1;
        #endregion

        #region 混合模式_
        /// <summary>
        /// 混合模式_覆盖
        /// </summary>
        ///
        public const int CV_COMPOSITE_MODE_SRCOVER = 0;
        /// <summary>
        /// 混合模式_拷贝
        /// </summary>
        ///
        public const int CV_COMPOSITE_MODE_SRCCOPY = 1;
        #endregion

        #region 消息_编辑框_
        ///<summary>
        /// 消息_编辑框_取指针位置
        ///</summary>
        public const int EM_GETSEL = 176;
        ///<summary>
        /// 消息_编辑框_置指针位置
        ///</summary>
        public const int EM_SETSEL = 177;
        /// <summary>
        /// 消息_编辑框_取行数
        /// </summary>
        public const int EM_GETLINECOUNT = 186;
        /// <summary>
        /// 消息_编辑框_替换文本内容
        /// </summary>
        public const int EM_REPLACESEL = 194;
        ///<summary>
        ///消息_编辑框_撤销
        ///</summary>
        public const int EM_UNDO = 199;
        ///<summary>
        ///消息_编辑框_重做
        ///</summary>
        public const int EM_REDO = 1108;
        ///<summary>
        ///消息_编辑框_设置选中区域
        ///</summary>
        public const int EM_EXSETSEL = 1079;
        ///<summary>
        ///消息_编辑框_取选中范围内容
        ///</summary>
        public const int EM_GETTEXTRANGE = 1099;
        ///<summary>
        ///消息_编辑框_设置富文本
        ///</summary>
        public const int EM_SETTEXTEX = 1121;
        ///<summary>
        ///消息_编辑框_查找文本
        ///</summary>
        public const int EM_FINDTEXTW = 1147;
        ///<summary>
        ///设置提示文本(wParam:提示文本颜色,lParam:文本指针)
        ///</summary>
        public const int EM_SETCUEBANNER = 5377;
        ///<summary>
        /// 加载RTF文件(wParam:数据长度,lParam:数据指针)
        ///</summary>
        public const int EM_LOAD_RTF = 6001;
        #endregion

        #region 编辑框选中行字符格式
        /// <summary>
        /// 编辑框选中行字符格式_加粗
        /// </summary>
        public const int CFM_BOLD = 1;
        /// <summary>
        /// 编辑框选中行字符格式_倾斜
        /// </summary>
        public const int CFM_ITALIC = 2;
        /// <summary>
        /// 编辑框选中行字符格式_下划线
        /// </summary>
        public const int CFM_UNDERLINE = 4;
        /// <summary>
        /// 编辑框选中行字符格式_删除线
        /// </summary>
        public const int CFM_STRIKEOUT = 8;
        /// <summary>
        /// 编辑框选中行字符格式_超链接
        /// </summary>
        public const int CFM_LINK = 32;
        /// <summary>
        /// 编辑框选中行字符格式_尺寸
        /// </summary>
        public const int CFM_SIZE = -1;
        /// <summary>
        /// 编辑框选中行字符格式_颜色
        /// </summary>
        public const int CFM_COLOR = 0x40000000;
        /// <summary>
        /// 编辑框选中行字符格式_字体名称
        /// </summary>
        public const int CFM_FACE = 0x20000000;
        /// <summary>
        /// 编辑框选中行字符格式_垂直偏移
        /// </summary>
        public const int CFM_OFFSET = 0x10000000;
        #endregion

        #region 编辑框选中行段落格式
        /// <summary>
        /// 编辑框选中行段落格式_首行缩进
        /// </summary>
        public const int PFM_STARTINDENT = 0x00000001;
        /// <summary>
        /// 编辑框选中行段落格式_右侧缩进
        /// </summary>
        public const int PFM_RIGHTINDENT = 0x00000002;
        /// <summary>
        /// 编辑框选中行段落格式_非首行缩进
        /// </summary>
        public const int PFM_OFFSET = 0x00000004;
        /// <summary>
        /// 编辑框选中行段落格式_段落对齐方式
        /// </summary>
        public const int PFM_ALIGNMENT = 0x00000008;
        /// <summary>
        /// 编辑框选中行段落格式_编号类型
        /// </summary>
        public const int PFM_NUMBERING = 0x00000020;
        #endregion

        #region 编辑框段落对齐方式
        /// <summary>
        /// 编辑框段落对齐方式_左对齐
        /// </summary>
        public const int PFA_LEFT = 1;
        /// <summary>
        /// 编辑框段落对齐方式_右对齐
        /// </summary>
        public const int PFA_RIGHT = 2;
        /// <summary>
        /// 编辑框段落对齐方式_居中
        /// </summary>
        public const int PFA_CENTER = 3;
        #endregion

        #region 编辑框段落项目符号类型
        /// <summary>
        /// 编辑框段落项目符号类型_圆点
        /// </summary>
        public const int PFN_BULLET = 1;
        /// <summary>
        /// 编辑框段落项目符号类型_阿拉伯数字 0, 1, 2,...
        /// </summary>
        public const int PFN_ARABIC = 2;
        /// <summary>
        /// 编辑框段落项目符号类型_小写字母 a, b, c,...
        /// </summary>
        public const int PFN_LCLETTER = 3;
        /// <summary>
        /// 编辑框段落项目符号类型_大写字母 A, B, C,...
        /// </summary>
        public const int PFN_UCLETTER = 4;
        /// <summary>
        /// 编辑框段落项目符号类型_小写罗马字母 i, ii, iii, ...
        /// </summary>
        public const int PFN_LCROMAN = 5;
        /// <summary>
        /// 编辑框段落项目符号类型_大写罗马字母 I, II, III, ...
        /// </summary>
        public const int PFN_UCROMAN = 6;
        #endregion

        #region 区域模式_
        /// <summary>
        /// 区域模式_并集	采用两个区域的并集来合并这两个区域
        /// </summary>
        ///
        public const int RGN_COMBINE_UNION = 0;
        /// <summary>
        /// 区域模式_交集.采用两个区域的交集来合并这两个区域
        /// </summary>
        ///
        public const int RGN_COMBINE_INTERSECT = 1;
        /// <summary>
        /// 区域模式_异或.采用两个区域的并集，且去除重叠区域
        /// </summary>
        ///
        public const int RGN_COMBINE_XOR = 2;
        /// <summary>
        /// 区域模式_排除.从第一个区域中排除第二个区域
        /// </summary>
        ///
        public const int RGN_COMBINE_EXCLUDE = 3;
        #endregion

        #region 事件_布局_
        /// <summary>
        /// 事件_布局_获取布局父属性个数
        /// </summary>
        ///
        public const int ELN_GETPROPSCOUNT = 1;
        /// <summary>
        /// 事件_布局_获取布局子属性个数
        /// </summary>
        ///
        public const int ELN_GETCHILDPROPCOUNT = 2;
        /// <summary>
        /// 事件_布局_初始化父属性列表
        /// </summary>
        ///
        public const int ELN_INITPROPS = 3;
        /// <summary>
        /// 事件_布局_释放父属性列表
        /// </summary>
        ///
        public const int ELN_UNINITPROPS = 4;
        /// <summary>
        /// 事件_布局_初始化子属性列表
        /// </summary>
        ///
        public const int ELN_INITCHILDPROPS = 5;
        /// <summary>
        /// 事件_布局_释放子属性列表
        /// </summary>
        ///
        public const int ELN_UNINITCHILDPROPS = 6;
        /// <summary>
        /// 事件_布局_检查属性值是否正确,wParam为propID，lParam为值
        /// </summary>
        ///
        public const int ELN_CHECKPROPVALUE = 7;
        /// <summary>
        /// 事件_布局_检查子属性值是否正确,wParam低位为nIndex，高位为propID，lParam为值
        /// </summary>
        ///
        public const int ELN_CHECKCHILDPROPVALUE = 8;
        /// <summary>
        /// 事件_布局_从XML属性表填充到布局信息中
        /// </summary>
        ///
        public const int ELN_FILL_XML_PROPS = 9;
        /// <summary>
        /// 事件_布局_从XML属性表填充到父布局信息中
        /// </summary>
        ///
        public const int ELN_FILL_XML_CHILD_PROPS = 10;
        /// <summary>
        /// 事件_布局_更新布局
        /// </summary>
        ///
        public const int ELN_UPDATE = 15;
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
        public const int CBN_SELCHANGE = 1;
        /// <summary>
        /// 组合框事件_编辑内容被改变
        /// </summary>
        ///
        public const int CBN_EDITCHANGE = 5;
        /// <summary>
        /// 组合框事件_即将弹出列表
        /// </summary>
        ///
        public const int CBN_DROPDOWN = 7;
        /// <summary>
        /// 组合框事件_即将关闭列表
        /// </summary>
        ///
        public const int CBN_CLOSEUP = 8;
        /// <summary>
        /// 组合框事件_弹出下拉列表
        /// </summary>
        ///
        public const int CBN_POPUPLISTWINDOW = 2001;
        #endregion

        #region 消息_组合框_
        /// <summary>
        /// 消息_组合框_添加项目,lParam内容
        /// </summary>
        ///
        public const int CB_ADDSTRING = 0x0143;
        /// <summary>
        /// 消息_组合框_删除项目,wParam索引
        /// </summary>
        ///
        public const int CB_DELETESTRING = 0x0144;
        /// <summary>
        /// 消息_组合框_插入项目,wParam索引,lParam内容
        /// </summary>
        ///
        public const int CB_INSERTSTRING = 0x014A;
        /// <summary>
        /// 消息_组合框_寻找项目,wParam索引,lParam内容
        /// </summary>
        ///
        public const int CB_FINDSTRING = 0x014C;
        /// <summary>
        /// 消息_组合框_取项目数
        /// </summary>
        ///
        public const int CB_GETCOUNT = 0x0146;
        /// <summary>
        /// 消息_组合框_取当前选中项目
        /// </summary>
        ///
        public const int CB_GETCURSEL = 0x0147;
        /// <summary>
        /// 消息_组合框_置当前选中项目
        /// </summary>
        ///
        public const int CB_SETCURSEL = 0x014E;
        /// <summary>
        /// 消息_组合框_取下拉列表宽度
        /// </summary>
        ///
        public const int CB_GETDROPPEDWIDTH = 0x015F;
        /// <summary>
        /// 消息_组合框_置下拉列表宽度,wParam宽度
        /// </summary>
        ///
        public const int CB_SETDROPPEDWIDTH = 0x0160;
        /// <summary>
        /// 消息_组合框_取表项高度
        /// </summary>
        ///
        public const int CB_GETITEMHEIGHT = 0x0154;
        /// <summary>
        /// 消息_组合框_置表项高度,lParam高度
        /// </summary>
        ///
        public const int CB_SETITEMHEIGHT = 0x0153;
        /// <summary>
        /// 消息_组合框_取可视数量
        /// </summary>
        ///
        public const int CB_GETMINVISIBLE = 5890;
        /// <summary>
        /// 消息_组合框_置可视数量
        /// </summary>
        ///
        public const int CB_SETMINVISIBLE = 5889;
        /// <summary>
        /// 消息_组合框_重置内容
        /// </summary>
        ///
        public const int CB_RESETCONTENT = 0x014B;
        /// <summary>
        /// 消息_组合框_显示下拉列表
        /// </summary>
        ///
        public const int CB_SHOWDROPDOWN = 0x014F;
        #endregion

        #region 组合框风格_
        /// <summary>
        /// 组合框风格_允许编辑
        /// </summary>
        ///
        public const int ECS_ALLOWEDIT = 1;
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
        public const int TVI_FIRST = -65535;
        /// <summary>
        /// 树形框节点类型_尾节点
        /// </summary>
        ///
        public const int TVI_LAST = -65534;
        /// <summary>
        /// 树形框节点类型_根节点
        /// </summary>
        ///
        public const int TVI_ROOT = -65536;
        /// <summary>
        /// 树形框节点类型_排序
        /// </summary>
        ///
        public const int TVI_SORT = -65533;
        #endregion

        #region 消息_树形框_
        /// <summary>
        /// 消息_树形框_删除节点及所有子孙 (lParam为节点句柄,0或TVI_ROOT为删除所有)
        /// </summary>
        ///
        public const int TVM_DELETEITEM = 4353;
        /// <summary>
        /// 消息_树形框_保证显示 (lParam为显示的节点句柄)
        /// </summary>
        ///
        public const int TVM_ENSUREVISIBLE = 4372;
        /// <summary>
        /// 消息_树形框_展开收缩 (wParam为是否展开,lParam为设置的节点句柄)
        /// </summary>
        ///
        public const int TVM_EXPAND = 4354;
        /// <summary>
        /// 消息_树形框_取节点数
        /// </summary>
        ///
        public const int TVM_GETCOUNT = 4357;
        /// <summary>
        /// 消息_树形框_取留白宽度
        /// </summary>
        ///
        public const int TVM_GETINDENT = 4358;
        /// <summary>
        /// 消息_树形框_取节点矩形 (wParam为节点句柄,lParam为 EX_RECT 指针,注意该节点必须处于可见范围,否则消息无法获取并返回0)
        /// </summary>
        ///
        public const int TVM_GETITEMRECT = 4356;
        /// <summary>
        /// 消息_树形框_取相关节点(wParam为 TVGN_ 开头的常量,lParam为节点句柄)
        /// </summary>
        ///
        public const int TVM_GETNEXTITEM = 4362;
        /// <summary>
        /// 消息_树形框_取展开可视节点个数
        /// </summary>
        ///
        public const int TVM_GETVISIBLECOUNT = 4368;
        /// <summary>
        /// 消息_树形框_命中测试 (wParam低位为x高位为y[相对控件],lParam为 返回#TVHT_开头常量 的指针,消息返回值为命中的节点句柄)
        /// </summary>
        ///
        public const int TVM_HITTEST = 4369;
        /// <summary>
        /// 消息_树形框_插入节点 (lParam为 EX_TREEVIEW_ITEMINFO 指针，tzText为Unicode)
        /// </summary>
        ///
        public const int TVM_INSERTITEM = 4352;
        /// <summary>
        /// 消息_树形框_置选中项 (lParam为选中的节点句柄)
        /// </summary>
        ///
        public const int TVM_SELECTITEM = 4363;
        /// <summary>
        /// 消息_树形框_设置留白宽度 取相关节点(wParam为 TVGN_ 开头的常量,lParam为节点句柄)
        /// </summary>
        ///
        public const int TVM_SETINDENT = 4359;
        /// <summary>
        /// 消息_树形框_取节点信息 (wParam为节点句柄,lParam为 EX_TREEVIEW_ITEMINFO 指针，tzText为Unicode)
        /// </summary>
        ///
        public const int TVM_GETITEM = 4364;
        /// <summary>
        /// 消息_树形框_设置节点信息 (wParam为节点句柄,lParam为 EX_TREEVIEW_ITEMINFO 指针)
        /// </summary>
        ///
        public const int TVM_SETITEM = 4365;
        /// <summary>
        /// 消息_树形框_更新树形框
        /// </summary>
        ///
        public const int TVM_UPDATE = 4499;
        /// <summary>
        /// 消息_树形框_设置行高 (lParam为新行高)
        /// </summary>
        ///
        public const int TVM_SETITEMHEIGHT = 5091;
        /// <summary>
        /// 消息_树形框_获取行高
        /// </summary>
        ///
        public const int TVM_GETITEMHEIGHT = 5092;
        /// <summary>
        /// 消息_树形框_从索引获取节点句柄 (wParam为索引,节点必须可见否则返回0)
        /// </summary>
        ///
        public const int TVM_GETNODEFROMINDEX = 5093;
        /// <summary>
        /// 消息_树形框_设置节点标题 (wParam为节点句柄,lParam为 文本指针,Unicode)
        /// </summary>
        ///
        public const int TVM_SETITEMTEXTW = 14414;
        /// <summary>
        /// 消息_树形框_获取节点标题 (wParam为节点句柄,返回值为标题Unicode字符串,不要自行释放)
        /// </summary>
        ///
        public const int TVM_GETITEMTEXTW = 14415;
        /// <summary>
        /// 消息_树形框_设置图片组(wParam为是否更新表项宽高,lParam为图片组句柄)
        /// </summary>
        ///
        public const int TVM_SETIMAGELIST = 4361;
        /// <summary>
        /// 消息_树形框_获取图片组
        /// </summary>
        ///
        public const int TVM_GETIMAGELIST = 4360;
        #endregion

        #region 树形框相关节点_
        /// <summary>
        /// 树形框相关节点_获取根节点
        /// </summary>
        ///
        public const int TVGN_ROOT = 0;
        /// <summary>
        /// 树形框相关节点_获取下一个节点
        /// </summary>
        ///
        public const int TVGN_NEXT = 1;
        /// <summary>
        /// 树形框相关节点_获取上一个节点
        /// </summary>
        ///
        public const int TVGN_PREVIOUS = 2;
        /// <summary>
        /// 树形框相关节点_获取父节点
        /// </summary>
        ///
        public const int TVGN_PARENT = 3;
        /// <summary>
        /// 树形框相关节点_获取子节点
        /// </summary>
        ///
        public const int TVGN_CHILD = 4;
        /// <summary>
        /// 树形框相关节点_获取下一个可见节点
        /// </summary>
        ///
        public const int TVGN_NEXTVISIBLE = 6;
        #endregion

        #region 树形框命中测试_
        /// <summary>
        /// 树形框命中测试_没有命中
        /// </summary>
        ///
        public const int TVHT_NOWHERE = 1;
        /// <summary>
        /// 树形框命中测试_命中图标
        /// </summary>
        ///
        public const int TVHT_ONITEMICON = 2;
        /// <summary>
        ///  树形框命中测试_命中标题
        /// </summary>
        ///
        public const int TVHT_ONITEMLABEL = 4;
        /// <summary>
        /// 树形框命中测试_命中留白
        /// </summary>
        ///
        public const int TVHT_ONITEMINDENT = 8;
        /// <summary>
        /// 树形框命中测试_命中加减框
        /// </summary>
        ///
        public const int TVHT_ONITEMSTATEICON = 64;
        #endregion

        #region 事件_树形框_
        /// <summary>
        /// 事件_树形框_删除节点
        /// </summary>
        ///
        public const int TVN_DELETEITEM = 391;
        /// <summary>
        /// 事件_树形框_节点展开
        /// </summary>
        ///
        public const int TVN_ITEMEXPANDED = 394;
        /// <summary>
        /// 事件_树形框_节点展开中
        /// </summary>
        ///
        public const int TVN_ITEMEXPANDING = 395;
        /// <summary>
        /// 事件_树形框_绘制节点
        /// </summary>
        ///
        public const int TVN_DRAWITEM = 3099;
        #endregion

        #region 报表框_
        /// <summary>
        /// 报表风格_绘制横线
        /// </summary>
        ///
        public const int ERLS_DRAWHORIZONTALLINE = 256;
        /// <summary>
        /// 报表风格_绘制竖线
        /// </summary>
        ///
        public const int ERLS_DRAWVERTICALLINE = 512;
        /// <summary>
        /// 报表风格_无表头
        /// </summary>
        ///
        public const int ERLS_NOHEAD = 1024;
        #endregion

        #region 报表表头风格_
        /// <summary>
        /// 报表表头风格_默认
        /// </summary>
        ///
        public const int ERLV_CS_DEFAULT = 0;
        /// <summary>
        /// 报表表头风格_可点击
        /// </summary>
        ///
        public const int ERLV_CS_CLICKABLE = 1;
        /// <summary>
        /// 报表表头风格_锁定宽度
        /// </summary>
        ///
        public const int ERLV_CS_LOCKWIDTH = 2;
        /// <summary>
        /// 报表表头风格_可排序 (前提是得可点击)
        /// </summary>
        ///
        public const int ERLV_CS_SORTABLE = 4;
        #endregion

        #region 事件_报表_
        /// <summary>
        /// 事件_报表_表头被单击,wParam项目索引从1开始
        /// </summary>
        ///
        public const int RLVN_COLUMNCLICK = 97000;
        /// <summary>
        /// 事件_报表_绘制表行
        /// </summary>
        ///
        public const int RLVN_DRAW_TR = 97001;
        /// <summary>
        /// 事件_报表_绘制表项
        /// </summary>
        ///
        public const int RLVN_DRAW_TD = 97002;
        /// <summary>
        /// 事件_报表_检查框点击,wParam项目索引从1开始;lParam项目状态0取消选中 1选中
        /// </summary>
        ///
        public const int RLVN_CHECK = 97003;
        /// <summary>
        /// 事件_报表_当删除表项
        /// </summary>
        ///
        public const int RLVN_DELETE_ITEM = 97004;
        /// <summary>
        /// 消息_报表_检查框点击
        /// </summary>
        ///
        public const int RLVM_CHECK = 99001;
        /// <summary>
        /// 消息_报表_设置检查框状态 wParam 为项目索引 lParam为置选中状态1选中, 0不选中
        /// </summary>
        ///
        public const int RLVM_SETCHECK = 99002;
        /// <summary>
        /// 消息_报表_获取检查框状态 wParam 为项目索引 , 返回1选中, 0不选中
        /// </summary>
        ///
        public const int RLVM_GETCHECK = 99003;
        /// <summary>
        /// 消息_报表_获取命中列索引
        /// </summary>
        ///
        public const int RLVM_GETHITCOL = 99004;
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

        #region 消息_进度条_
        /// <summary>
        /// 消息_进度条_设置进度条范围  wParam范围
        /// </summary>
        ///
        public const int PBM_SETRANGE = 1025;
        /// <summary>
        /// 消息_进度条_设置进度条位置 wParam位置
        /// </summary>
        ///
        public const int PBM_SETPOS = 1026;

        /// <summary>
        /// 消息_进度条_获取进度条范围
        /// </summary>
        ///
        public const int PBM_GETRANGE = 1031;
        /// <summary>
        /// 消息_进度条_获取进度条位置
        /// </summary>
        ///
        public const int PBM_GETPOS = 1032;
        /// <summary>
        /// 消息_进度条_设置进度条颜色  wParam颜色
        /// </summary>
        ///
        public const int PBM_SETBARCOLOR = 1033;
        /// <summary>
        /// 消息_进度条_设置进度条背景颜色 wParam颜色
        /// </summary>
        ///
        public const int PBM_SETBKCOLOR = 8193;
        /// <summary>
        /// 消息_进度条_设置进度条圆角度 wParam圆角度
        /// </summary>
        ///
        public const int PBM_SETRADIUS = 1027;
        #endregion

        #region 菜单消息_
        /// <summary>
        /// 消息_选择菜单项目
        /// </summary>
        public const int MN_SELECTITEM = 0x1E5;
        #endregion

        #region 消息_列表按钮_
        /// <summary>
        ///  消息_列表按钮_按下项目 wParam按下横坐标 lParam 菜单句柄
        /// </summary>
        ///
        public const int LBM_DOWNITEM = 1237701;
        /// <summary>
        ///  消息_列表按钮_选择项目
        /// </summary>
        ///
        public const int LBM_SELECTITEM = 1237702;
        #endregion

        #region WIN10动画加载风格_
        /// <summary>
        ///  WIN10动画加载风格_直线
        /// </summary>
        ///
        public const int ELDS_LINE = 1;
        #endregion

        #region 滑块条风格_
        /// <summary>
        ///  滑块条风格_横向
        /// </summary>
        ///
        public const int ESBS_HORIZONTAL = 0;
        /// <summary>
        ///  滑块条风格_纵向
        /// </summary>
        ///
        public const int ESBS_VERTICAL = 1;
        #endregion

        #region 消息_滑块条_
        /// <summary>
        ///  消息_滑块条_取当前滑块坐标
        /// </summary>
        ///
        public const int SBM_GETBLOCKRECT = 10010;
        /// <summary>
        ///  消息_滑块条_坐标转值
        /// </summary>
        ///
        public const int SBM_PT2VALUE = 10011;
        #endregion

        #region 事件_滑块条_
        /// <summary>
        ///  事件_滑块条_值改变 事件编号(lParam=值)
        /// </summary>
        ///
        public const int SBN_VALUE = 10010;
        #endregion

        #region 滑块条属性_
        /// <summary>
        ///  滑块条属性_最小值
        /// </summary>
        ///
        public const int SBL_MIN = 0;
        /// <summary>
        ///  滑块条属性_最大值
        /// </summary>
        ///
        public const int SBL_MAX = 1;
        /// <summary>
        ///  滑块条属性_当前值
        /// </summary>
        ///
        public const int SBL_POS = 2;
        /// <summary>
        ///  滑块条属性_滑块圆滑动方向 设定值：1，横向风格（从右往左）|纵向风格（从下往上）
        /// </summary>
        ///
        public const int SBL_BLOCK_POINT = 3;
        /// <summary>
        ///  滑块条属性_滑块圆半径
        /// </summary>
        ///
        public const int SBL_BLOCK_SIZE = 4;
        #endregion

        #region 分组框属性_
        /// <summary>
        ///  分组框属性_文本左边的偏移
        /// </summary>
        ///
        public const int GROUPBOX_TEXT_OFFSET = 0;
        /// <summary>
        ///  分组框属性_线框圆角度
        /// </summary>
        ///
        public const int GROUPBOX_RADIUS = 1;
        /// <summary>
        ///  分组框属性_线宽
        /// </summary>
        ///
        public const int GROUPBOX_STROKEWIDTH = 2;
        #endregion

        #region 消息_颜色选择器_
        /// <summary>
        /// 消息_颜色选择器_改变颜色
        /// </summary>
        ///
        public const int CPM_COLORCHANGE = 100051;
        #endregion

        #region 消息_颜色选择器_
        /// <summary>
        /// 事件_颜色选择器_颜色已更改,lParam更改的ARGB颜色
        /// </summary>
        ///
        public const int CPN_COLORCHANGE = 100052;
        #endregion

        #region 事件_调色板_
        /// <summary>
        /// 调色板通知_鼠标移动 wParam返回不带alpha的RGB颜色,用ExRGB2ARGB转换到ARGB
        /// </summary>
        ///
        public const int PTN_MOUSEMOVE = 100000;
        #endregion

        #region 事件_列表按钮_
        /// <summary>
        /// 事件_列表按钮_单击 wParam 索引从1开始
        /// </summary>
        ///
        public const int LBN_CLICK = 1;
        /// <summary>
        /// 事件_列表按钮_选中 wParam 索引从1开始,lParam 状态 STATE_
        /// </summary>
        ///
        public const int LBN_CHECK = 2;
        #endregion

        #region 消息_日期框_
        /// <summary>
        /// 消息_日期框_设置日期
        /// </summary>
        ///
        public const int DBM_DATETIME = 100061;
        #endregion

        #region 事件_日期框_
        /// <summary>
        /// 事件_日期框_日期选中,lParam是ExDateTimeInfo结构体
        /// </summary>
        ///
        public const int DBN_DATETIME = 100062;
        #endregion

        #region 事件_月历_
        /// <summary>
        /// 事件_月历_日期选中,lParam是ExDateTimeInfo结构体
        /// </summary>
        ///
        public const int MCN_DATETIME = 100062;
        #endregion

        #region 消息_Cef浏览框_
        /// <summary>
        /// 消息_Cef浏览框_加载URL
        /// </summary>
        ///
        public const int CEFM_LOADURL = 100001;
        /// <summary>
        /// 消息_Cef浏览框_获取浏览框句柄
        /// </summary>
        ///
        public const int CEFM_GETWEBVIEW = 100002;
        #endregion

        #region 事件_Cef浏览框_
        /// <summary>
        /// 事件_Cef浏览框_已创建CEFN_
        /// </summary>
        ///
        public const int CEFN_CREATE = 100100;
        /// <summary>
        /// 事件_Cef浏览框_加载完毕
        /// </summary>
        ///
        public const int CEFN_LOADEND = 100101;
        /// <summary>
        /// 事件_Cef浏览框_加载开始
        /// </summary>
        ///
        public const int CEFN_LOADSTART = 100102;
        #endregion

        #region 消息_轮播_
        /// <summary>
        /// 消息_轮播_设置尺寸
        /// </summary>
        ///
        public const int CM_SIZE = 5000;
        /// <summary>
        /// 消息_轮播_播放下一张
        /// </summary>
        ///
        public const int CM_NEXT = 5001;
        /// <summary>
        /// 消息_轮播_播放上一张
        /// </summary>
        ///
        public const int CM_PREV = 5002;
        /// <summary>
        /// 消息_轮播_添加图片
        /// </summary>
        ///
        public const int CM_ADDIMG = 5003;
        /// <summary>
        /// 消息_轮播_清空
        /// </summary>
        ///
        public const int CM_CLEAR = 5004;
        /// <summary>
        /// 消息_轮播_设置时钟周期
        /// </summary>
        ///
        public const int CM_SETTIMER = 5005;
        #endregion

        #region 消息_鼠绘板_
        /// <summary>
        /// 消息_鼠绘板_设置画笔类型 lParam 0画笔 1橡皮擦
        /// </summary>
        ///
        public const int DBM_SETPENTYPE = 20000;
        /// <summary>
        /// 消息_鼠绘板_设置画笔宽度 lParam
        /// </summary>
        ///
        public const int DBM_SETPENWIDTH = 20001;
        /// <summary>
        /// 消息_鼠绘板_设置画笔颜色 lParam
        /// </summary>
        ///
        public const int DBM_SETPENCOLOR = 20002;
        /// <summary>
        /// 消息_鼠绘板_清空画板
        /// </summary>
        ///
        public const int DBM_CLEAR = 20003;
        #endregion

        #region 消息_属性框_
        /// <summary>
        /// 消息_属性框_添加表项 添加行到尾部 wParam:组件_类型  lParam: PGITEM 指针
        /// </summary>
        ///
        public const int PGM_ADDITEM = 10010;
        /// <summary>
        /// 消息_属性框_取表项值 wParam: 未定义    lParam:表项名  return:表项值文本指针
        /// </summary>
        ///
        public const int PGM_GETITEMVALUE = 10011;
        /// <summary>
        ///  消息_属性框_置表项值 wParam: 欲写入值    lParam:表项名  return:未定义
        /// </summary>
        ///
        public const int PGM_SETITEMVALUE = 10012;
        #endregion

        #region 事件_属性框_
        /// <summary>
        /// 事件_属性框_表项值改变 wParam:行索引(不包括标题行,包括分组行和组件行,从1开始)   lParam:数据指针(可以通过"__get(数据指针,PGL_内存偏移_/////)"来获取数据)
        /// </summary>
        ///
        public const int PGN_ITEMVALUECHANGE = 10012;
        #endregion

        #region 属性框_组件类型_
        /// <summary>
        /// 属性框_组件类型_分组
        /// </summary>
        ///
        public const int PGT_OBJ_GROUP = -1;
        /// <summary>
        /// 属性框_组件类型_编辑框
        /// </summary>
        ///
        public const int PGT_OBJ_EDIT = 0;
        /// <summary>
        /// 属性框_组件类型_组合框
        /// </summary>
        ///
        public const int PGT_OBJ_COMBOBOX = 1;
        /// <summary>
        /// 属性框_组件类型_颜色框
        /// </summary>
        ///
        public const int PGT_OBJ_COLORPICKER = 2;
        /// <summary>
        /// 属性框_组件类型_日期框
        /// </summary>
        ///
        public const int PGT_OBJ_DATEBOX = 3;
        #endregion

        #region mibiblink浏览框加载类型_
        /// <summary>
        /// mibiblink浏览框加载类型_URL
        /// </summary>
        ///
        public const int MBBL_TYPE_URL = 0;
        #endregion

        #region 消息_mibiblink浏览框_
        /// <summary>
        /// 消息_mibiblink浏览框_获取浏览框句柄
        /// </summary>
        ///
        public const int MBBM_GETWEBVIEW = 100011;
        /// <summary>
        /// 消息_mibiblink浏览框_加载
        /// </summary>
        ///
        public const int MBBM_LOAD = 100012;
        /// <summary>
        /// 消息_mibiblink浏览框_执行js
        /// </summary>
        ///
        public const int MBBM_JS = 100013;
        #endregion

        #region 报表表行风格_
        /// <summary>
        /// 报表表行风格_默认
        /// </summary>
        ///
        public const int ERLV_RS_DEFAULT = 0;
        /// <summary>
        /// 报表表行风格_表项带检查框
        /// </summary>
        ///
        public const int ERLV_RS_CHECKBOX = 1;
        /// <summary>
        /// 报表表行风格_检查框为选中状态
        /// </summary>
        ///
        public const int ERLV_RS_CHECKBOX_CHECK = 2;
        #endregion

        #region 图标列表风格_
        /// <summary>
        /// 图标列表风格_表项以按钮形式呈现
        /// </summary>
        ///
        public const int EILVS_BUTTON = 0x400;
        #endregion

        #region 消息_图标列表_
        /// <summary>
        /// 消息_图标列表_设置表项尺寸
        /// </summary>
        ///
        public const int ILVM_SETITEMSIZE = 11001;
        #endregion

        #region 路径标识_
        /// <summary>
        /// 路径标识_禁止缩放
        /// </summary>
        ///
        public const int EPF_DISABLESCALE = 1;
        #endregion

        #region 位置信息标识_
        /// <summary>
        /// 组件位置默认值
        /// </summary>
        ///
        public const int EOP_DEFAULT = -2147483648;
        #endregion

        #region 树形框风格_
        /// <summary>
        /// 树形框风格_显示加减号
        /// </summary>
        ///
        public const int ETS_SHOWADDANDSUB = 64;
        /// <summary>
        /// 树形框风格_显示连接线
        /// </summary>
        ///
        public const int ETS_SHOWCABLE = 128;
        #endregion

        #region 包头_
        /// <summary>
        /// 主题包头
        /// </summary>
        ///
        public const int EPDF_THEME = 254;
        /// <summary>
        /// 资源包头
        /// </summary>
        ///
        public const int EPDF_FILES = 255;
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
        public const int WM_MOUSEWHEEL = 522;
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

        #region 按钮开关消息_ 
        /// <summary>
        /// 按钮开关消息_取选中
        /// </summary>
        public const int BM_GETCHECK = 240;
        /// <summary>
        /// 按钮开关消息_置选中,wParam是否刷新,lParam索引
        /// </summary>
        public const int BM_SETCHECK = 241;
        /// <summary>
        /// 按钮开关消息_取图片
        /// </summary>
        public const int BM_GETIMAGE = 246;
        /// <summary>
        /// 按钮开关消息_置图片
        /// </summary>
        public const int BM_SETIMAGE = 247;
        #endregion

        #region 字体风格_
        /// <summary>
        /// 字体风格_普通
        /// </summary>
        public const int FS_DEFAULT = 0;
        /// <summary>
        /// 字体风格_加粗
        /// </summary>
        public const int FS_BOLD = 1;
        /// <summary>
        /// 字体风格_倾斜
        /// </summary>
        public const int FS_ITALIC = 2;
        /// <summary>
        /// 字体风格_下划线
        /// </summary>
        public const int FS_UNDERLINE = 4;
        /// <summary>
        /// 字体风格_删除线
        /// </summary>
        public const int FS_STRICKOUT = 8;
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

        #region 消息_媒体播放状态_
        /// <summary>
        /// 消息_媒体播放状态_播放
        /// </summary>
        public const int MFM_STATE_PLAY = 10010;
        /// <summary>
        /// 消息_媒体播放状态_暂停
        /// </summary>
        public const int MFM_STATE_PAUSE = 10011;
        /// <summary>
        /// 消息_媒体播放状态_继续播放
        /// </summary>
        public const int MFM_STATE_CONTINUE = 10012;
        /// <summary>
        /// 消息_媒体播放状态_停止
        /// </summary>
        public const int MFM_STATE_STOP = 10013;
        /// <summary>
        /// 消息_播放速率 lParam: (int)速率
        /// </summary>
        public const int MFM_RATE = 10014;
        /// <summary>
        /// 消息_置播放位置 lParam: 单位 秒
        /// </summary>
        public const int MFM_SET_POSITION = 10015;
        /// <summary>
        /// 消息_取视频时长 单位 秒
        /// </summary>
        public const int MFM_GET_DURATION = 10016;
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
    }
}
