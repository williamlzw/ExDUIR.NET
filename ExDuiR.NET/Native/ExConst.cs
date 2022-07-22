namespace ExDuiR.NET.Native
{
    public static class ExConst
    {
        #region SB_
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int SB_HORZ = 0;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int SB_VERT = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int SB_CTL = 2;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int SB_BOTH = 3;
        #endregion

        #region 滚动条风格_
        /** <summary>
         * 滚动条风格_水平滚动条
         * </summary>
         **/
        public const int ESS_HORIZONTALSCROLL = 0;
        /** <summary>
         * 滚动条风格_垂直滚动条
         * </summary>
         **/
        public const int ESS_VERTICALSCROLL = 1;
        /** <summary>
         * 滚动条风格_左顶对齐
         * </summary>
         **/
        public const int ESS_LEFTTOPALIGN = 2;
        /** <summary>
         * 滚动条风格_右底对齐
         * </summary>
         **/
        public const int ESS_RIGHTBOTTOMALIGN = 4;
        /** <summary>
         * 滚动条风格_控制按钮
         * </summary>
         **/
        public const int ESS_CONTROLBUTTON = 8;

        #endregion

        #region BIF_
        /** <summary>
         * 播放动画
         * </summary>
         **/
        public const int BIF_PLAYIMAGE = 1;
        /** <summary>
         * 禁用缩放
         * </summary>
         **/
        public const int BIF_DISABLESCALE = 2;
        /** <summary>
         * 九宫矩形-排除中间区域
         * </summary>
         **/
        public const int BIF_GRID_EXCLUSION_CENTER = 4;
        /** <summary>
         * X使用百分比单位
         * </summary>
         **/
        public const int BIF_POSITION_Y_PERCENT = 8;
        /** <summary>
         * Y使用百分比单位
         * </summary>
         **/
        public const int BIF_POSITION_X_PERCENT = 16;

        #endregion

        #region NM_
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
        /// 事件_编辑框_选择文本
        /// </summary>
        public const int NM_EN_SELCHANGE = 1794;

        /// <summary>
        /// 事件_编辑框_点击链接
        /// </summary>
        public const int NM_EN_LINK = 1803;
        #endregion

        #region COLOR_EX
        /** <summary>
         * 背景颜色
         * </summary>
         **/
        public const int COLOR_EX_BACKGROUND = 0;

        /** <summary>
         * 边框颜色
         * </summary>
         **/
        public const int COLOR_EX_BORDER = 1;

        /** <summary>
         * 文本颜色.正常
         * </summary>
         **/
        public const int COLOR_EX_TEXT_NORMAL = 2;

        /** <summary>
         * 文本颜色.点燃
         * </summary>
         **/
        public const int COLOR_EX_TEXT_HOVER = 3;

        /** <summary>
         * 文本颜色.按下
         * </summary>
         **/
        public const int COLOR_EX_TEXT_DOWN = 4;

        /** <summary>
         * 文本颜色.焦点
         * </summary>
         **/
        public const int COLOR_EX_TEXT_FOCUS = 5;

        /** <summary>
         * 文本颜色.选中
         * </summary>
         **/
        public const int COLOR_EX_TEXT_CHECKED = 6;

        /** <summary>
         * 文本颜色.选择
         * </summary>
         **/
        public const int COLOR_EX_TEXT_SELECT = 7;

        /** <summary>
         * 文本颜色.热点
         * </summary>
         **/
        public const int COLOR_EX_TEXT_HOT = 8;

        /** <summary>
         * 文本颜色.已访问
         * </summary>
         **/
        public const int COLOR_EX_TEXT_VISTED = 9;

        /** <summary>
         * 文本颜色.阴影
         * </summary>
         **/
        public const int COLOR_EX_TEXT_SHADOW = 10;

        /** <summary>
         * 编辑框.光标原色
         * </summary>
         **/
        public const int COLOR_EX_EDIT_CARET = 30;

        /** <summary>
         * 编辑框.提示文本颜色
         * </summary>
         **/
        public const int COLOR_EX_EDIT_BANNER = 31;


        #endregion

        #region EOS_
        /** <summary>
         * 组件风格_滚动条不可用时显示禁止状态
         * </summary>
         **/
        public const int EOS_DISABLENOSCROLL = 33554432;

        /** <summary>
         * 组件风格_可调整尺寸
         * </summary>
         **/
        public const int EOS_SIZEBOX = 67108864;

        /** <summary>
         * 组件风格_禁止
         * </summary>
         **/
        public const int EOS_DISABLED = 134217728;

        /** <summary>
         * 组件风格_可视
         * </summary>
         **/
        public const int EOS_VISIBLE = 268435456;

        /** <summary>
         * 组件风格_边框
         * </summary>
         **/
        public const int EOS_BORDER = 536870912;

        /** <summary>
         * 组件风格_水平滚动条
         * </summary>
         **/
        public const int EOS_VSCROLL = 1073741824;

        /** <summary>
         * 组件风格_垂直滚动条
         * </summary>
         **/
        public const int EOS_HSCROLL = -2147483648;

        /** <summary>
         * 组件风格_扩展_自适应尺寸
         * </summary>
         **/
        public const int EOS_EX_AUTOSIZE = 4194304;

        /** <summary>
         * 组件风格_扩展_鼠标穿透
         * </summary>
         **/
        public const int EOS_EX_TRANSPARENT = 8388608;

        /** <summary>
         * 组件风格_扩展_允许拖拽
         * </summary>
         **/
        public const int EOS_EX_DRAGDROP = 33554432;

        /** <summary>
         * 组件风格_扩展_接收文件拖放
         * </summary>
         **/
        public const int EOS_EX_ACCEPTFILES = 67108864;

        /** <summary>
         * 组件风格_扩展_允许焦点
         * </summary>
         **/
        public const int EOS_EX_FOCUSABLE = 134217728;

        /** <summary>
         * 组件风格_扩展_允许TAB焦点
         * </summary>
         **/
        public const int EOS_EX_TABSTOP = 268435456;

        /** <summary>
         * 组件风格_扩展_总在最前
         * </summary>
         **/
        public const int EOS_EX_TOPMOST = 536870912;

        /** <summary>
         * 组件风格_扩展_背景混合
         * </summary>
         **/
        public const int EOS_EX_COMPOSITED = 1073741824;

        /** <summary>
         * 组件风格_扩展_自定义绘制
         * </summary>
         **/
        public const int EOS_EX_CUSTOMDRAW = -2147483648;


        #endregion

        #region EOL_
        /** <summary>
         * 组件节点ID
         * </summary>
         **/
        public const int EOL_NODEID = -1;

        /** <summary>
         * 组件模糊系数
         * </summary>
         **/
        public const int EOL_BLUR = -2;

        /** <summary>
         * 组件回调
         * </summary>
         **/
        public const int EOL_OBJPROC = -4;

        /** <summary>
         * 组件透明度
         * </summary>
         **/
        public const int EOL_ALPHA = -5;

        /** <summary>
         * 自定义参数
         * </summary>
         **/
        public const int EOL_LPARAM = -7;

        /** <summary>
         * 父句柄
         * </summary>
         **/
        public const int EOL_OBJPARENT = -8;

        /** <summary>
         * 组件文本格式
         * </summary>
         **/
        public const int EOL_TEXTFORMAT = -11;

        /** <summary>
         * 组件ID
         * </summary>
         **/
        public const int EOL_ID = -12;

        /** <summary>
         * 组件基本风格
         * </summary>
         **/
        public const int EOL_STYLE = -16;

        /** <summary>
         * 组件字体句柄
         * </summary>
         **/
        public const int EOL_HFONT = -19;

        /** <summary>
         * 组件扩展风格
         * </summary>
         **/
        public const int EOL_EXSTYLE = -20;

        /** <summary>
         * 用户数据
         * </summary>
         **/
        public const int EOL_USERDATA = -21;

        /** <summary>
         * 画布句柄（不要乱改）
         * </summary>
         **/
        public const int EOL_HCANVAS = -22;

        /** <summary>
         * 控件数据（不要乱改）
         * </summary>
         **/
        public const int EOL_OWNER = -23;

        /** <summary>
         * 组件状态
         * </summary>
         **/
        public const int EOL_STATE = -24;

        /** <summary>
         * 组件标题内容指针
         * </summary>
         **/
        public const int EOL_LPWZTITLE = -28;

        /** <summary>
         * 光标句柄
         * </summary>
         **/
        public const int EOL_CURSOR = -17;


        #endregion

        #region EOST_
        /** <summary>
         * 正常
         * </summary>
         **/
        public const int EOST_NORMAL = 0;

        /** <summary>
         * 禁用
         * </summary>
         **/
        public const int EOST_DISABLE = 1;

        /** <summary>
         * 选择
         * </summary>
         **/
        public const int EOST_SELECTED = 2;

        /** <summary>
         * 焦点
         * </summary>
         **/
        public const int EOST_FOCUS = 4;

        /** <summary>
         * 按下
         * </summary>
         **/
        public const int EOST_PRESS = 8;

        /** <summary>
         * 选中
         * </summary>
         **/
        public const int EOST_CHECKED = 16;

        /** <summary>
         * 半选中
         * </summary>
         **/
        public const int EOST_CHECKED_HALF = 32;

        /** <summary>
         * 只读
         * </summary>
         **/
        public const int EOST_READONLY = 64;

        /** <summary>
         * 点燃
         * </summary>
         **/
        public const int EOST_HOVER = 128;

        /** <summary>
         * 默认
         * </summary>
         **/
        public const int EOST_DEFAULT = 256;

        /** <summary>
         * 子项可视
         * </summary>
         **/
        public const int EOST_SUBITEM_VISIBLE = 512;

        /** <summary>
         * 子项隐藏
         * </summary>
         **/
        public const int EOST_SUBITEM_HIDE = 1024;

        /** <summary>
         * 忙碌中
         * </summary>
         **/
        public const int EOST_BUSY = 2048;

        /** <summary>
         * 滚动中
         * </summary>
         **/
        public const int EOST_SCROLLING = 8192;

        /** <summary>
         * 动画中
         * </summary>
         **/
        public const int EOST_ANIMATING = 16384;

        /** <summary>
         * 隐藏
         * </summary>
         **/
        public const int EOST_HIDE = 32768;

        /** <summary>
         * 可调尺寸
         * </summary>
         **/
        public const int EOST_SIZEABLE = 131072;

        /** <summary>
         * 可拖拽
         * </summary>
         **/
        public const int EOST_DRAGABLE = 262144;

        /** <summary>
         * 可有焦点
         * </summary>
         **/
        public const int EOST_FOCUSABLE = 1048576;

        /** <summary>
         * 可选择
         * </summary>
         **/
        public const int EOST_SELECTABLE = 2097152;

        /** <summary>
         * 超链接点燃
         * </summary>
         **/
        public const int EOST_LINK_HOVER = 4194304;

        /** <summary>
         * 超链接访问过
         * </summary>
         **/
        public const int EOST_LINK_VISITED = 8388608;

        /** <summary>
         * 允许多选
         * </summary>
         **/
        public const int EOST_MULTISELECT = 16777216;

        /** <summary>
         * 密码状态
         * </summary>
         **/
        public const int EOST_PASSWORD = 536870912;


        #endregion

        #region GW_
        /** <summary>
         * 子控件
         * </summary>
         **/
        public const int GW_CHILD = 5;

        /** <summary>
         * 上一个兄弟
         * </summary>
         **/
        public const int GW_HWNDPREV = 3;

        /** <summary>
         * 下一个兄弟
         * </summary>
         **/
        public const int GW_HWNDNEXT = 2;

        #endregion

        #region BIR_
        /** <summary>
         * 默认(缩放)
         * </summary>
         **/
        public const int BIR_DEFALUT = 0;
        /** <summary>
         * 平铺不重复
         * </summary>
         **/
        public const int BIR_NO_REPEAT = 1;
        /** <summary>
         * 水平、垂直重复平铺
         * </summary>
         **/
        public const int BIR_REPEAT = 2;
        /** <summary>
         * 水平重复平铺
         * </summary>
         **/
        public const int BIR_REPEAT_X = 3;
        /** <summary>
         * 垂直重复平铺
         * </summary>
         **/
        public const int BIR_REPEAT_Y = 4;
        #endregion

        #region 编辑框风格_
        /** <summary>
         * 编辑框风格_允许拖拽  
         * </summary>
         **/
        public const int EES_DISABLEDRAG = 1;
        /** <summary>
         * 编辑框风格_密码输入
         * </summary>
         **/
        public const int EES_USEPASSWORD = 2;
        /** <summary>
         * 编辑框风格_显示选择文本
         * </summary>
         **/
        public const int EES_HIDESELECTION = 4;
        /** <summary>
         * 编辑框风格_丰富文本
         * </summary>
         **/
        public const int EES_RICHTEXT = 8;
        /** <summary>
         * 编辑框风格_允许鸣叫
         * </summary>
         **/
        public const int EES_ALLOWBEEP = 16;
        /** <summary>
         * 编辑框风格_只读
         * </summary>
         **/
        public const int EES_READONLY = 32;
        /** <summary>
         * 编辑框风格_回车换行
         * </summary>
         **/
        public const int EES_NEWLINE = 64;
        /** <summary>
         * 编辑框风格_数值输入
         * </summary>
         **/
        public const int EES_NUMERICINPUT = 128;
        /** <summary>
         * 编辑框风格_自动选择字符
         * </summary>
         **/
        public const int EES_AUTOWORDSEL = 256;
        /** <summary>
         * 编辑框风格_禁用右键默认菜单
         * </summary>
         **/
        public const int EES_DISABLEMENU = 512;
        /** <summary>
         * 编辑框风格_解析URL
         * </summary>
         **/
        public const int EES_PARSEURL = 1024;
        /** <summary>
         * 编辑框风格_允许TAB字符
         * </summary>
         **/
        public const int EES_ALLOWTAB = 2048;
        /** <summary>
         * 编辑框风格_总是显示提示文本
         * </summary>
         **/
        public const int EES_SHOWTIPSALWAYS = 4096;
        /** <summary>
         * 编辑框风格_隐藏插入符
         * </summary>
         **/
        public const int EES_HIDDENCARET = 8192;
        /** <summary>
         * 编辑框风格_下划线
         * </summary>
         **/
        public const int EES_UNDERLINE = 16384;
        #endregion

        #region LVM_
        /** <summary>
         * 获取表象(lParam为EX_REPORTLIST_ITEMINFO指针)
         * </summary>
         **/
        public const int LVM_GETITEM = 4101;
        /** <summary>
         * 设置表象(lParam为EX_REPORTLIST_ITEMINFO指针)
         * </summary>
         **/
        public const int LVM_SETITEM = 4102;
        /** <summary>
         * 获取表象文本(wParam若不为0则为表项索引,lParam为EX_REPORTLIST_ITEMINFO指针)
         * </summary>
         **/
        public const int LVM_GETITEMTEXT = 4141;
        /** <summary>
         * 设置表象文本(wParam若不为0则为表项索引,lParam为EX_REPORTLIST_ITEMINFO指针)
         * </summary>
         **/
        public const int LVM_SETITEMTEXT = 4142;
        /** <summary>
         * 插入列(wParm为是否立即更新,lParam为EX_REPORTLIST_COLUMNINFO指针)
         * </summary>
         **/
        public const int LVM_INSERTCOLUMN = 4123;
        /** <summary>
         * 删除列(wParm为是否立即更新,lParam为列索引)
         * </summary>
         **/
        public const int LVM_DELETECOLUMN = 4124;
        /** <summary>
         * 排序(lParam为EX_REPORTLIST_SORTINFO指针)
         * </summary>
         **/
        public const int LVM_SORTITEMS = 4144;
        /** <summary>
         * 更新列表框
         * </summary>
         **/
        public const int LVM_UPDATE = 4138;
        /** <summary>
         * 删除所有列
         * </summary>
         **/
        public const int LVM_DELETEALLCOLUMN = 4900;
        /** <summary>
         * 获取列数
         * </summary>
         **/
        public const int LVM_GETCOLUMNCOUNT = 4901;
        /** <summary>
         * 获取列信息(wParam为列索引,lParam为 EX_REPORTLIST_COLUMNINFO 指针)
         * </summary>
         **/
        public const int LVM_GETCOLUMN = 4902;
        /** <summary>
         * 设置列信息(wParam低位为列索引,高位为是否立即刷新,lParam为 EX_REPORTLIST_COLUMNINFO 指针)
         * </summary>
         **/
        public const int LVM_SETCOLUMN = 4903;
        /** <summary>
         * 设置列标题(wParam低位为列索引,高位为是否立即刷新,lParam为 宽文本指针)
         * </summary>
         **/
        public const int LVM_SETCOLUMNTEXT = 4904;
        /** <summary>
         * 获取列标题(wParam为列索引,lParam为 宽文本指针)
         * </summary>
         **/
        public const int LVM_GETCOLUMNTEXT = 4905;
        /** <summary>
         * 获取列宽
         * </summary>
         **/
        public const int LVM_GETCOLUMNWIDTH = 4906;
        /** <summary>
         * 设置列宽(wParam为列索引,lParam为 列宽)
         * </summary>
         **/
        public const int LVM_SETCOLUMNWIDTH = 4907;
        /** <summary>
         * 设置表项高度
         * </summary>
         **/
        public const int LVM_SETITEMHEIGHT = 4908;
        /** <summary>
         * 获取表项高度(lParam为新行高)
         * </summary>
         **/
        public const int LVM_GETITEMHEIGHT = 4909;
        /** <summary>
         * 获取图片组
         * </summary>
         **/
        public const int LVM_GETIMAGELIST = 4098;
        /** <summary>
         * 设置图片组(wParam为是否更新表项宽高,lParam为图片组句柄)
         * </summary>
         **/
        public const int LVM_SETIMAGELIST = 4099;
        /** <summary>
         * 命中测试
         * </summary>
         **/
        public const int LVM_HITTEST = 4114;
        /** <summary>
         * 清空项目
         * </summary>
         **/
        public const int LVM_DELETEALLITEMS = 4015;
        /** <summary>
         * 删除项目
         * </summary>
         **/
        public const int LVM_DELETEITEM = 4104;
        /** <summary>
         * 保证显示项目
         * </summary>
         **/
        public const int LVM_ENSUREVISIBLE = 4115;
        /** <summary>
         * 取可视范围内的项目数量
         * </summary>
         **/
        public const int LVM_GETCOUNTPERPAGE = 4136;
        /** <summary>
         * 取项目总数
         * </summary>
         **/
        public const int LVM_GETITEMCOUNT = 4100;
        /** <summary>
         * 取指定项目的矩形范围
         * </summary>
         **/
        public const int LVM_GETITEMRECT = 4110;
        /** <summary>
         * 取被选择项目数
         * </summary>
         **/
        public const int LVM_GETSELECTEDCOUNT = 4146;
        /** <summary>
         * 取现行选择项目
         * </summary>
         **/
        public const int LVM_GETSELECTIONMARK = 4162;
        /** <summary>
         * 置现行选择项目
         * </summary>
         **/
        public const int LVM_SETSELECTIONMARK = 4163;
        /** <summary>
         * 取在可视范围中第一个项目的索引
         * </summary>
         **/
        public const int LVM_GETTOPINDEX = 4135;
        /** <summary>
         * 插入项目
         * </summary>
         **/
        public const int LVM_INSERTITEM = 4103;
        /** <summary>
         * 重画项目
         * </summary>
         **/
        public const int LVM_REDRAWITEMS = 4117;
        /** <summary>
         * 设置列表项目总数(wParam:表项条数,lParma:刷新风格)
         * </summary>
         **/
        public const int LVM_SETITEMCOUNT = 4143;
        /** <summary>
         * 取项目状态
         * </summary>
         **/
        public const int LVM_GETITEMSTATE = 4140;
        /** <summary>
         * 置项目状态
         * </summary>
         **/
        public const int LVM_SETITEMSTATE = 4139;
        /** <summary>
         * 取鼠标指针指向项目的索引
         * </summary>
         **/
        public const int LVM_GETHOTITEM = 4157;
        /** <summary>
         * 立即申请重算表项尺寸
         * </summary>
         **/
        public const int LVM_CALCITEMSIZE = 5150;
        /** <summary>
         * 取消主题 不绘制列表主题 1为取消
         * </summary>
         **/
        public const int LVM_CANCELTHEME = 5151;
        #endregion

        #region LVN_
        /** <summary>
         * 现行选中项被改变
         * </summary>
         **/
        public const int LVN_ITEMCHANGED = -101;
        /** <summary>
         * 热点跟踪
         * </summary>
         **/
        public const int LVN_HOTTRACK = -121;
        #endregion

        #region 缓动类型_
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_Linear = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_Clerp = 2;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_Spring = 3;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_Punch = 4;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InQuad = 5;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutQuad = 6;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutQuad = 7;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InCubic = 8;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutCubic = 9;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutCubic = 10;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InQuart = 11;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutQuart = 12;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutQuart = 13;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InQuint = 14;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutQuint = 15;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutQuint = 16;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InSine = 17;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutSine = 18;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutSine = 19;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InExpo = 20;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutExpo = 21;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutExpo = 22;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InCirc = 23;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutCirc = 24;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutCirc = 25;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InBounce = 26;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutBounce = 27;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutBounce = 28;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InBack = 29;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutBack = 30;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutBack = 31;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InElastic = 32;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_OutElastic = 33;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ET_InOutElastic = 34;
        /** <summary>
         * pEasingContext为自定义回调函数(nProcess,nStart,nStop,nCurrent*,pEasingContext)
         * </summary>
         **/
        public const int ET_CUSTOM = 50;
        /** <summary>
         * pEasingContext为pCurveInfo(_easing_load_curve)
         * </summary>
         **/
        public const int ET_CURVE = 51;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        #endregion

        #region 缓动模式
        //<summary>
        //* 缓动模式_单次
        //</summary>
        public const int ES_SINGLE = 1;
        /** <summary>
         * 缓动模式_循环,注意自行停止
         * </summary>
         **/
        public const int ES_CYCLE = 2;
        /** <summary>
         * 缓动模式_多次,高位则为次数
         * </summary>
         **/
        public const int ES_MANYTIMES = 4;
        /** <summary>
         * 缓动模式_顺序
         * </summary>
         **/
        public const int ES_ORDER = 8;
        /** <summary>
         * 缓动模式_逆序
         * </summary>
         **/
        public const int ES_REVERSE = 16;
        /** <summary>
         * 缓动模式_来回
         * </summary>
         **/
        public const int ES_BACKANDFORTH = 32;
        /** <summary>
         * 缓动模式_调用函数 pContext为回调函数,bool isStop Cbk(pEasingProgress,double nProgress,double nCurrent,pEasingContext,nTimesSurplus,Param1,Param2,Param3,Param4)
         * </summary>
         **/
        public const int ES_CALLFUNCTION = 64;
        /** <summary>
         * 缓动模式_分发消息 pContext为hObj或hExDUI, wParam:pEasing,lParam:lpEasingInfo,result:isStop
         * </summary>
         **/
        public const int ES_DISPATCHNOTIFY = 128;
        /** <summary>
         * 缓动模式_使用线程 使用线程处理,否则在UI线程处理(过程中会阻塞输入)
         * </summary>
         **/
        public const int ES_THREAD = 256;
        /** <summary>
         * 缓动模式_释放曲线 当使用曲线类型时生效,在结束时会自动释放曲线指针
         * </summary>
         **/
        public const int ES_RELEASECURVE = 512;
        #endregion

        #region 缓动状态
        /** <summary>
         * 缓动状态_播放    
         * </summary>
         **/
        public const int EES_PLAY = 0;
        /** <summary>
         * 缓动状态_暂停
         * </summary>
         **/
        public const int EES_PAUSE = 1;
        /** <summary>
         * 缓动状态_停止
         * </summary>
         **/
        public const int EES_STOP = 2;
        #endregion

        #region ELT_
        /** <summary>
        * 布局类型_无
        * </summary>
        **/
        public const int ELT_NULL = 0;

        /** <summary>
         * 布局类型_线性
         * </summary>
         **/
        public const int ELT_LINEAR = 1;

        /** <summary>
         * 布局类型_流式
         * </summary>
         **/
        public const int ELT_FLOW = 2;

        /** <summary>
         * 布局类型_页面
         * </summary>
         **/
        public const int ELT_PAGE = 3;

        /** <summary>
         * 布局类型_表格
         * </summary>
         **/
        public const int ELT_TABLE = 4;

        /** <summary>
         * 布局类型_相对
         * </summary>
         **/
        public const int ELT_RELATIVE = 5;

        /** <summary>
         * 布局类型_绝对
         * </summary>
         **/
        public const int ELT_ABSOLUTE = 6;
        #endregion

        #region ELP_
        /** <summary>
         * 布局属性_通用_内间距_左
         * </summary>
         **/
        public const int ELP_PADDING_LEFT = -1;
        /** <summary>
         * 布局属性_通用_内间距_顶
         * </summary>
         **/
        public const int ELP_PADDING_TOP = -2;
        /** <summary>
         * 布局属性_通用_内间距_右
         * </summary>
         **/
        public const int ELP_PADDING_RIGHT = -3;
        /** <summary>
         * 布局属性_通用_内间距_底
         * </summary>
         **/
        public const int ELP_PADDING_BOTTOM = -4;
        /** <summary>
         * 布局属性:方向
         * </summary>
         **/
        public const int ELP_LINEAR_DIRECTION = 1;
        /** <summary>
         * 布局属性:布局方向对齐方式
         * </summary>
         **/
        public const int ELP_LINEAR_DALIGN = 2;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELP_LINEAR_DALIGN_LEFT_TOP = 0;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELP_LINEAR_DALIGN_CENTER = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELP_LINEAR_DALIGN_RIGHT_BOTTOM = 2;
        /** <summary>
         * 方向:水平
         * </summary>
         **/
        public const int ELP_DIRECTION_H = 0;
        /** <summary>
         * 方向:垂直
         * </summary>
         **/
        public const int ELP_DIRECTION_V = 1;
        /** <summary>
         * 布局属性:方向
         * </summary>
         **/
        public const int ELP_FLOW_DIRECTION = 1;
        /** <summary>
         * 布局属性:当前显示页面索引
         * </summary>
         **/
        public const int ELP_PAGE_CURRENT = 1;
        #endregion

        #region ELCP_
        /** <summary>
         * 布局属性_通用_外间距_左
         * </summary>
         **/
        public const int ELCP_MARGIN_LEFT = -1;
        /** <summary>
         * 布局属性_通用_外间距_顶
         * </summary>
         **/
        public const int ELCP_MARGIN_TOP = -2;
        /** <summary>
         * 布局属性_通用_外间距_右
         * </summary>
         **/
        public const int ELCP_MARGIN_RIGHT = -3;
        /** <summary>
         * 布局属性_通用_外间距_底
         * </summary>
         **/
        public const int ELCP_MARGIN_BOTTOM = -4;
        /** <summary>
         * 布局子属性:尺寸[-1或未填写为组件当前尺寸]
         * </summary>
         **/
        public const int ELCP_LINEAR_SIZE = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELCP_LINEAR_ALGIN_FILL = 0;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELCP_LINEAR_ALIGN_LEFT_TOP = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELCP_LINEAR_ALIGN_CENTER = 2;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int ELCP_LINEAR_ALIGN_RIGHT_BOTTOM = 3;
        /** <summary>
         * 布局紫属性:另外一个方向的对齐方式
         * </summary>
         **/
        public const int ELCP_LINEAR_ALIGN = 2;
        /** <summary>
         * 布局子属性:尺寸[-1或未填写为组件当前尺寸]
         * </summary>
         **/
        public const int ELCP_FLOW_SIZE = 1;
        /** <summary>
         * 布局子属性:组件强制换行
         * </summary>
         **/
        public const int ELCP_FLOW_NEW_LINE = 2;
        /** <summary>
         * 布局子属性:是否填充整个布局
         * </summary>
         **/
        public const int ELCP_PAGE_FILL = 1;
        /** <summary>
         * 布局属性_表格_所在行
         * </summary>
         **/
        public const int ELCP_TABLE_ROW = 1;
        /** <summary>
         * 布局属性_表格_所在列
         * </summary>
         **/
        public const int ELCP_TABLE_CELL = 2;
        /** <summary>
         * 布局属性_表格_跨行数
         * </summary>
         **/
        public const int ELCP_TABLE_ROW_SPAN = 3;
        /** <summary>
         * 布局属性_表格_跨列数
         * </summary>
         **/
        public const int ELCP_TABLE_CELL_SPAN = 4;
        /** <summary>
         * 布局属性_表格_是否填满
         * </summary>
         **/
        public const int ELCP_TABLE_FILL = 5;
        /** <summary>
         * 布局属性_相对_左侧于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_LEFT_OF = 1;
        /** <summary>
         * 布局属性_相对_之上于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_TOP_OF = 2;
        /** <summary>
         * 布局属性_相对_右侧于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_RIGHT_OF = 3;
        /** <summary>
         * 布局属性_相对_之下于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_BOTTOM_OF = 4;
        /** <summary>
         * 布局属性_相对_左对齐于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_LEFT_ALIGN_OF = 5;
        /** <summary>
         * 布局属性_相对_顶对齐于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_TOP_ALIGN_OF = 6;
        /** <summary>
         * 布局属性_相对_右对齐于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_RIGHT_ALIGN_OF = 7;
        /** <summary>
         * 布局属性_相对_底对齐于(组件)
         * </summary>
         **/
        public const int ELCP_RELATIVE_BOTTOM_ALIGN_OF = 8;
        /** <summary>
         * 布局属性_相对_水平居中于父
         * </summary>
         **/
        public const int ELCP_RELATIVE_CENTER_PARENT_H = 9;
        /** <summary>
         * 布局属性_相对_垂直居中于父
         * </summary>
         **/
        public const int ELCP_RELATIVE_CENTER_PARENT_V = 10;
        /** <summary>
         * 布局属性_绝对_左侧
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_LEFT = 1;
        /** <summary>
         * 布局属性_绝对_左侧类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_LEFT_TYPE = 2;
        /** <summary>
         * 布局属性_绝对_顶部
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_TOP = 3;
        /** <summary>
         * 布局属性_绝对_顶部类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_TOP_TYPE = 4;
        /** <summary>
         * 布局属性_绝对_右侧
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_RIGHT = 5;
        /** <summary>
         * 布局属性_绝对_右侧类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_RIGHT_TYPE = 6;
        /** <summary>
         * 布局属性_绝对_底部
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_BOTTOM = 7;
        /** <summary>
         * 布局属性_绝对_底部类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_BOTTOM_TYPE = 8;
        /** <summary>
         * 布局属性_绝对_宽度（优先级低于右侧）
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_WIDTH = 9;
        /** <summary>
         * 布局属性_绝对_宽度类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_WIDTH_TYPE = 10;
        /** <summary>
         * 布局属性_绝对_高度（优先级低于底部）
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_HEIGHT = 11;
        /** <summary>
         * 布局属性_绝对_高度类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_HEIGHT_TYPE = 12;
        /** <summary>
         * 布局属性_绝对_水平偏移量
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_OFFSET_H = 13;
        /** <summary>
         * 布局属性_绝对_水平偏移量类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_OFFSET_H_TYPE = 14;
        /** <summary>
         * 布局属性_绝对_垂直偏移量
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_OFFSET_V = 15;
        /** <summary>
         * 布局属性_绝对_垂直偏移量类型
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_OFFSET_V_TYPE = 16;
        /** <summary>
         * 布局属性_绝对_类型_未知(未设置或保持不变)
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_TYPE_UNKNOWN = 0;
        /** <summary>
         * 布局属性_绝对_类型_像素
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_TYPE_PX = 1;
        /** <summary>
         * 布局属性_绝对_类型_百分比
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_TYPE_PS = 2;
        /** <summary>
         * 布局属性_绝对_类型_组件尺寸百分比，仅OFFSET可用
         * </summary>
         **/
        public const int ELCP_ABSOLUTE_TYPE_OBJPS = 3;
        #endregion

        #region MESSAGEBOX
        #region MB_
        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_OK = 0;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_YESNO = 4;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_YESNOCANCEL = 3;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_OKCANCEL = 1;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_ICONERROR = 16;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_ICONWARNING = 48;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_ICONQUESTION = 32;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_ICONINFORMATION = 64;


        public const int MB_USERICON = 128;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MB_TOPMOST = 262144;
        #endregion

        #region ID
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int IDYES = 6;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int IDNO = 7;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int IDCANCEL = 2;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int IDOK = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int IDCLOSE = 8;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int NULL = 0;
        #endregion

        #region EMBF_
        /** <summary>
         * 不显示菜单阴影
         * </summary>
         **/
        public const int EMNF_NOSHADOW = -2147483648;
        /** <summary>
         * 显示窗口图标
         * </summary>
         **/
        public const int EMBF_WINDOWICON = -2147483648;
        /** <summary>
         * 消息框居父窗口中间
         * </summary>
         **/
        public const int EMBF_CENTEWINDOW = 1073741824;
        /** <summary>
         * 显示倒计时
         * </summary>
         **/
        public const int EMBF_SHOWTIMEOUT = 536870912;

        #endregion

        #endregion

        #region EXGF_
        /** <summary>
         * 启用DPI缩放
         * </summary>
         **/
        public const int EXGF_DPI_ENABLE = 2;

        /** <summary>
         * 画布_不抗锯齿
         * </summary>
         **/
        public const int EXGF_RENDER_CANVAS_ALIAS = 64;

        /** <summary>
         * 使用GDI/GDI+渲染
         * </summary>
         **/
        public const int EXGF_RENDER_METHOD_GDI = 128;

        /** <summary>
         * 使用D2D渲染
         * </summary>
         **/
        public const int EXGF_RENDER_METHOD_D2D = 256;

        /** <summary>
         * 使用支持GDI交互的D2D渲染
         * </summary>
         **/
        public const int EXGF_RENDER_METHOD_D2D_GDI_COMPATIBLE = 768;

        /** <summary>
         * 禁用动画效果
         * </summary>
         **/
        public const int EXGF_OBJECT_DISABLEANIMATION = 65536;

        /** <summary>
         * 显示组件边界
         * </summary>
         **/
        public const int EXGF_OBJECT_SHOWRECTBORDER = 131072;

        /** <summary>
         * 显示组件位置
         * </summary>
         **/
        public const int EXGF_OBJECT_SHOWPOSTION = 262144;

        /** <summary>
         * 允许JS全局对象访问文件
         * </summary>
         **/
        public const int EXGF_JS_FILE = 524288;

        /** <summary>
         * 允许JS全局对象访问内存
         * </summary>
         **/
        public const int EXGF_JS_MEMORY = 1048576;

        /** <summary>
         * 允许JS全局对象申请内存
         * </summary>
         **/
        public const int EXGF_JS_MEMORY_ALLOC = 2097152;

        /** <summary>
         * 允许JS全局对象创建进程、允许程序、加载DLL
         * </summary>
         **/
        public const int EXGF_JS_PROCESS = 4194304;

        /** <summary>
         * 允许JS全局对象访问所有资源
         * </summary>
         **/
        public const int EXGF_JS_ALL = 7864320;

        /** <summary>
         * 渲染所有菜单
         * </summary>
         **/
        public const int EXGF_MENU_ALL = 8388608;
        #endregion

        #region EWS_
        /** <summary>
         * 窗体风格_关闭按钮
         * </summary>
         **/
        public const int EWS_BUTTON_CLOSE = 1;

        /** <summary>
         * 窗体风格_最大化按钮
         * </summary>
         **/
        public const int EWS_BUTTON_MAX = 2;

        /** <summary>
         * 窗体风格_最小化按钮
         * </summary>
         **/
        public const int EWS_BUTTON_MIN = 4;

        /** <summary>
         * 窗体风格_菜单按钮
         * </summary>
         **/
        public const int EWS_BUTTON_MENU = 8;

        /** <summary>
         * 窗体风格_皮肤按钮
         * </summary>
         **/
        public const int EWS_BUTTON_SKIN = 16;

        /** <summary>
         * 窗体风格_设置按钮
         * </summary>
         **/
        public const int EWS_BUTTON_SETTING = 32;

        /** <summary>
         * 窗体风格_帮助按钮
         * </summary>
         **/
        public const int EWS_BUTTON_HELP = 64;

        /** <summary>
         * 窗体风格_图标
         * </summary>
         **/
        public const int EWS_HASICON = 128;

        /** <summary>
         * 窗体风格_标题
         * </summary>
         **/
        public const int EWS_TITLE = 256;

        /** <summary>
         * 窗体风格_全屏模式.设置该标记窗口最大化时
         * </summary>
         **/
        public const int EWS_FULLSCREEN = 512;

        /** <summary>
         * 窗体风格_允许调整尺寸
         * </summary>
         **/
        public const int EWS_SIZEABLE = 1024;

        /** <summary>
         * 窗体风格_允许随意移动
         * </summary>
         **/
        public const int EWS_MOVEABLE = 2048;

        /** <summary>
         * 窗体风格_不显示窗口阴影
         * </summary>
         **/
        public const int EWS_NOSHADOW = 4096;

        /** <summary>
         * 窗体风格_不继承父窗口背景数据
         * </summary>
         **/
        public const int EWS_NOINHERITBKG = 8192;

        /** <summary>
         * 窗体风格_不显示TAB焦点边框
         * </summary>
         **/
        public const int EWS_NOTABBORDER = 16384;

        /** <summary>
         * 窗体风格_ESC关闭窗口
         * </summary>
         **/
        public const int EWS_ESCEXIT = 32768;

        /** <summary>
         * 窗体风格_主窗口(拥有该风格时
         * </summary>
         **/
        public const int EWS_MAINWINDOW = 65536;

        /** <summary>
         * 窗体风格_窗口居中(如果有父窗口
         * </summary>
         **/
        public const int EWS_CENTERWINDOW = 131072;

        /** <summary>
         * 窗体风格_标题栏取消置顶
         * </summary>
         **/
        public const int EWS_NOCAPTIONTOPMOST = 262144;

        /** <summary>
         * 窗体风格_弹出式窗口
         * </summary>
         **/
        public const int EWS_POPUPWINDOW = 524288;

        #endregion

        #region EWL_

        /** <summary>
         * 背景模糊
         * </summary>
         **/
        public const int EWL_BLUR = -2;

        /** <summary>
         * 窗口消息过程
         * </summary>
         **/
        public const int EWL_MSGPROC = -4;

        /** <summary>
         * 窗口透明度
         * </summary>
         **/
        public const int EWL_ALPHA = -5;

        /** <summary>
         * 自定义参数
         * </summary>
         **/
        public const int EWL_LPARAM = -7;

        /** <summary>
         * 边框颜色
         * </summary>
         **/
        public const int EWL_CRBORDER = -30;

        /** <summary>
         * 背景颜色
         * </summary>
         **/
        public const int EWL_CRBKG = -31;

        /** <summary>
         * 最小高度
         * </summary>
         **/
        public const int EWL_MINHEIGHT = -33;

        /** <summary>
         * 最小宽度
         * </summary>
         **/
        public const int EWL_MINWIDTH = -34;

        /** <summary>
         * 焦点组件组件
         * </summary>
         **/
        public const int EWL_OBJFOCUS = -53;

        /** <summary>
         * 标题栏组件句柄
         * </summary>
         **/
        public const int EWL_OBJCAPTION = -54;
        #endregion

        #region WM_EX_

        /** <summary>
         * XML属性分发回调(wParam->atomPropName
         * </summary>
         **/
        public const int WM_EX_XML_PROPDISPATCH = -1;

        /** <summary>
         * JS脚本分发回调(wParam->atomPropName
         * </summary>
         **/
        public const int WM_EX_JS_DISPATCH = -2;

        /** <summary>
         * 左键单击组件
         * </summary>
         **/
        public const int WM_EX_LCLICK = -3;

        /** <summary>
         * 右键单击组件
         * </summary>
         **/
        public const int WM_EX_RCLICK = -4;

        /** <summary>
         * 中键单击组件
         * </summary>
         **/
        public const int WM_EX_MCLICK = -5;

        /** <summary>
         * 弹出式窗口已经初始化完毕
         * </summary>
         **/
        public const int WM_EX_INITPOPUP = -6;

        /** <summary>
         * 弹出式窗口即将销毁 (wParam=0:即将销毁.wParam=1:是否可销毁,返回1则取消销毁)
         * </summary>
         **/
        public const int WM_EX_EXITPOPUP = -7;

        /** <summary>
         * 发给控件用这个,窗口是EMT_EASING转NM_EASING
         * </summary>
         **/
        public const int WM_EX_EASING = -8;

        /// <summary>
        /// 控件接收到拖放(lParam为EX_DROPINFO结构体,若处理后应当返回 DROPEFFECT_开头的常量)
        /// </summary>
        public const int WM_EX_DROP = -9;

        /// <summary>
        /// 控件绘制中事件,(wParam为绘制进度,lParam为EX_PAINTSTRUCT指针)
        /// </summary>
        public const int WM_EX_PAINTING = -10;

        /// <summary>
        /// 消息_扩展_属性消息 lParam为EX_OBJ_PROPS结构体
        /// </summary>
        public const int WM_EX_PROPS = -11;
        #endregion

        #region EXR_
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int EXR_DEFAULT = 0;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int EXR_STRING = 1;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int EXR_LAYOUT = 2;
        #endregion

        #region 按钮风格_
        /** <summary>
         * 按钮风格_复选按钮
         * </summary>
         **/
        public const int EBS_CHECKBUTTON = 1;
        /** <summary>
         * 按钮风格_单选按钮
         * </summary>
         **/
        public const int EBS_RADIOBUTTON = 2;
        /** <summary>
         * 按钮风格_文本偏移
         * </summary>
         **/
        public const int EBS_TEXTOFFSET = 4;
        /** <summary>
         * 按钮风格_图标在右
         * </summary>
         **/
        public const int EBS_ICONRIGHT = 8;
        #endregion

        #region 状态_
        /** <summary>
        * 状态_正常
        * </summary>
        **/
        public const int STATE_NORMAL = 0;
        /** <summary>
         * 状态_禁止
         * </summary>
         **/
        public const int STATE_DISABLE = 0x01;
        /** <summary>
         * 状态_选择
         * </summary>
         **/
        public const int STATE_SELECT = 0x02;
        /** <summary>
         * 状态_焦点
         * </summary>
         **/
        public const int STATE_FOCUS = 0x04;
        /** <summary>
         * 状态_按下
         * </summary>
         **/
        public const int STATE_DOWN = 0x08;
        /** <summary>
         * 状态_选中
         * </summary>
         **/
        public const int STATE_CHECKED = 0x10;
        /** <summary>
         * 状态_半选中
         * </summary>
         **/
        public const int STATE_HALFSELECT = 0x20;
        /** <summary>
         * 状态_只读
         * </summary>
         **/
        public const int STATE_READONLY = 0x40;
        /** <summary>
         * 状态_点燃
         * </summary>
         **/
        public const int STATE_HOVER = 0x80;
        /** <summary>
         * 状态_默认
         * </summary>
         **/
        public const int STATE_DEFAULT = 0x100;
        /** <summary>
         * 状态_子项目_可视
         * </summary>
         **/
        public const int STATE_SUBITEM_VISIABLE = 0x200;
        /** <summary>
         * 状态_子项目_隐藏
         * </summary>
         **/
        public const int STATE_SUBITEM_HIDDEN = 0x400;
        /** <summary>
         * 状态_繁忙中
         * </summary>
         **/
        public const int STATE_BUSY = 0x800;
        /** <summary>
         * 状态_滚动中
         * </summary>
         **/
        public const int STATE_ROLLING = 0x2000;
        /** <summary>
         * 状态_动画中
         * </summary>
         **/
        public const int STATE_ANIMATING = 0x4000;
        /** <summary>
         * 状态_隐藏
         * </summary>
         **/
        public const int STATE_HIDDEN = 0x8000;
        /** <summary>
         * 状态_允许修改尺寸
         * </summary>
         **/
        public const int STATE_ALLOWSIZE = 0x20000;
        /** <summary>
         * 状态_允许拖动
         * </summary>
         **/
        public const int STATE_ALLOWDRAG = 0x40000;
        /** <summary>
         * 状态_允许焦点
         * </summary>
         **/
        public const int STATE_ALLOWFOCUS = 0x100000;
        /** <summary>
         * 状态_允许选择
         * </summary>
         **/
        public const int STATE_ALLOWSELECT = 0x200000;
        /** <summary>
         * 状态_超链接_点燃
         * </summary>
         **/
        public const int STATE_HYPERLINK_HOVER = 0x400000;
        /** <summary>
         * 状态_超链接_已访问
         * </summary>
         **/
        public const int STATE_HYPERLINK_VISITED = 0x800000;
        /** <summary>
         * 状态_允许多选
         * </summary>
         **/
        public const int STATE_ALLOWMULTIPLE = 0x1000000;
        /** <summary>
         * 状态_密码模式
         * </summary>
         **/
        public const int STATE_PASSWORD = 0x2000000;
        #endregion


        #region EPP_
        /** <summary>
         * 当控件开始绘制后
         * </summary>
         **/
        public const int EPP_BEGIN = 0;
        /** <summary>
         * 当控件绘制背景后
         * </summary>
         **/
        public const int EPP_BKG = 1;
        /** <summary>
         * 当控件绘制边框后
         * </summary>
         **/
        public const int EPP_BORDER = 2;
        /** <summary>
         * 当控件自定义绘制后
         * </summary>
         **/
        public const int EPP_CUSTOMDRAW = 3;
        /** <summary>
         * 当控件绘制结束后
         * </summary>
         **/
        public const int EPP_END = 4;
        #endregion

        #region 列表风格_ 
        /** <summary>
         * 列表风格_纵向列表
         * </summary>
         **/
        public const int ELVS_VERTICALLIST = 0;
        /** <summary>
         * 列表风格_横向列表
         * </summary>
         **/
        public const int ELVS_HORIZONTALLIST = 1;
        /** <summary>
         * 列表风格_允许多选
         * </summary>
         **/
        public const int ELVS_ALLOWMULTIPLE = 8;
        /** <summary>
         * 列表风格_表项跟踪
         * </summary>
         **/
        public const int ELVS_ITEMTRACKING = 16;
        /** <summary>
         * 列表风格_始终显示选择项
         * </summary>
         **/
        public const int ELVS_SHOWSELALWAYS = 32;
        #endregion

        #region TLVM_
        /** <summary>
         * 返回值将作为列表项控件
         * </summary>
         **/
        public const int TLVM_ITEM_CREATE = 10010;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int TLVM_ITEM_CREATED = 10011;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int TLVM_ITEM_DESTROY = 10012;
        /** <summary>
         * wParam:nIndex,lParam:hObjItem
         * </summary>
         **/
        public const int TLVM_ITEM_FILL = 10013;
        /** <summary>
         * wParam:cbSize,lParam:pTemplate
         * </summary>
         **/
        public const int TLVM_SETTEMPLATE = 10020;
        /** <summary>
         * wParam:表项索引,返回表项容器句柄(不在可视区返回0)
         * </summary>
         **/
        public const int TLVM_GETITEMOBJ = 10021;
        #endregion

        #region ECF_
        /** <summary>
         * 需要与GDI交互
         * </summary>
         **/
        public const int ECF_D2D_GDI_COMPATIBLE = 1;
        #endregion

        #region LVHT_
        /** <summary>
         * 未命中
         * </summary>
         **/
        public const int LVHT_NOWHERE = 1;
        /** <summary>
         * 命中表项
         * </summary>
         **/
        public const int LVHT_ONITEM = 14;
        #endregion

        #region CVC_
        /** <summary>
         * ID2D1DeviceContext
         * </summary>
         **/
        public const int CVC_DX_D2DCONTEXT = 1;
        /** <summary>
         * ID2D1Bitmap
         * </summary>
         **/
        public const int CVC_DX_D2DBITMAP = 2;
        /** <summary>
         * Grahpics*
         * </summary>
         **/
        public const int CVC_GDIP_GRAPHICS = 1;
        #endregion

        #region CVF_
        /** <summary>
         * 需要与GDI交互
         * </summary>
         **/
        public const int CVF_GDI_COMPATIBLE = 1;
        #endregion

        #region CV_
        /** <summary>
         * 混合模式-覆盖
         * </summary>
         **/
        public const int CV_COMPOSITE_MODE_SRCOVER = 0;
        /** <summary>
         * 混合模式-拷贝
         * </summary>
         **/
        public const int CV_COMPOSITE_MODE_SRCCOPY = 1;
        #endregion

        #region 消息_编辑框
        ///<summary>
        /// 消息_编辑框_置指针位置
        ///</summary>
        public const int EM_SETSEL = 177;
        /// <summary>
        /// 消息_编辑框_取行数
        /// </summary>
        public const int EM_GETLINECOUNT = 186;
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

        #region RGN_
        /** <summary>
         * 并集.采用两个区域的并集来合并这两个区域
         * </summary>
         **/
        public const int RGN_COMBINE_UNION = 0;
        /** <summary>
         * 交集.采用两个区域的交集来合并这两个区域
         * </summary>
         **/
        public const int RGN_COMBINE_INTERSECT = 1;
        /** <summary>
         * 异或.采用两个区域的并集，且去除重叠区域
         * </summary>
         **/
        public const int RGN_COMBINE_XOR = 2;
        /** <summary>
         * 排除.从第一个区域中排除第二个区域
         * </summary>
         **/
        public const int RGN_COMBINE_EXCLUDE = 3;
        #endregion

        #region ELN_
        /** <summary>
         * 获取布局父属性个数
         * </summary>
         **/
        public const int ELN_GETPROPSCOUNT = 1;
        /** <summary>
         * 获取布局子属性个数
         * </summary>
         **/
        public const int ELN_GETCHILDPROPCOUNT = 2;
        /** <summary>
         * 初始化父属性列表
         * </summary>
         **/
        public const int ELN_INITPROPS = 3;
        /** <summary>
         * 释放父属性列表
         * </summary>
         **/
        public const int ELN_UNINITPROPS = 4;
        /** <summary>
         * 初始化子属性列表
         * </summary>
         **/
        public const int ELN_INITCHILDPROPS = 5;
        /** <summary>
         * 释放子属性列表
         * </summary>
         **/
        public const int ELN_UNINITCHILDPROPS = 6;
        /** <summary>
         * 检查属性值是否正确,wParam为propID，lParam为值
         * </summary>
         **/
        public const int ELN_CHECKPROPVALUE = 7;
        /** <summary>
         * 检查子属性值是否正确,wParam低位为nIndex，高位为propID，lParam为值
         * </summary>
         **/
        public const int ELN_CHECKCHILDPROPVALUE = 8;
        /** <summary>
         * 从XML属性表填充到布局信息中
         * </summary>
         **/
        public const int ELN_FILL_XML_PROPS = 9;
        /** <summary>
         * 从XML属性表填充到父布局信息中
         * </summary>
         **/
        public const int ELN_FILL_XML_CHILD_PROPS = 10;
        /** <summary>
         * 更新布局
         * </summary>
         **/
        public const int ELN_UPDATE = 15;
        #endregion

        #region UNIT_
        /** <summary>
         * 单位:像素
         * </summary>
         **/
        public const int UNIT_PIXEL = 0;
        /** <summary>
         * 单位:百分比
         * </summary>
         **/
        public const int UNIT_PERCENT = 1;
        #endregion

        #region 组合框事件_
        /** <summary>
         * 组合框事件_列表项被改变
         * </summary>
         **/
        public const int CBN_SELCHANGE = 1;
        /** <summary>
         * 组合框事件_编辑内容被改变
         * </summary>
         **/
        public const int CBN_EDITCHANGE = 5;
        /** <summary>
         * 组合框事件_即将弹出列表
         * </summary>
         **/
        public const int CBN_DROPDOWN = 7;
        /** <summary>
         * 组合框事件_即将关闭列表
         * </summary>
         **/
        public const int CBN_CLOSEUP = 8;
        /** <summary>
         * 组合框事件_弹出下拉列表
         * </summary>
         **/
        public const int CBN_POPUPLISTWINDOW = 2001;
        #endregion


        #region 组合框风格_
        /** <summary>
         * 组合框风格_允许编辑
         * </summary>
         **/
        public const int ECS_ALLOWEDIT = 1;
        #endregion

        #region TVI_
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int TVI_FIRST = -65535;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int TVI_LAST = -65534;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int TVI_ROOT = -65536;
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int TVI_SORT = -65533;
        #endregion

        #region TVM_
        /** <summary>
         * 删除节点及所有子孙(lParam为节点句柄,0或TVI_ROOT为删除所有)
         * </summary>
         **/
        public const int TVM_DELETEITEM = 4353;
        /** <summary>
         * 保证显示(lParam为显示的节点句柄)
         * </summary>
         **/
        public const int TVM_ENSUREVISIBLE = 4372;
        /** <summary>
         * 展开收缩(wParam为是否展开,lParam为设置的节点句柄)
         * </summary>
         **/
        public const int TVM_EXPAND = 4354;
        /** <summary>
         * 取节点数
         * </summary>
         **/
        public const int TVM_GETCOUNT = 4357;
        /** <summary>
         * 取留白宽度
         * </summary>
         **/
        public const int TVM_GETINDENT = 4358;
        /** <summary>
         * 取节点信息(wParam为节点句柄,lParam为 EX_TREEVIEW_ITEMINFO 指针，tzText为Unicode)
         * </summary>
         **/
        public const int TVM_GETITEMW = 4414;
        /** <summary>
         * 取节点矩形(wParam为节点句柄,lParam为 EX_RECT 指针,注意该节点必须处于可见范围,否则消息无法获取并返回0)
         * </summary>
         **/
        public const int TVM_GETITEMRECT = 4356;
        /** <summary>
         * 取相关节点(wParam为 TVGN_ 开头的常量,lParam为节点句柄)
         * </summary>
         **/
        public const int TVM_GETNEXTITEM = 4362;
        /** <summary>
         * 取展开可视节点个数
         * </summary>
         **/
        public const int TVM_GETVISIBLECOUNT = 4368;
        /** <summary>
         * 命中测试(wParam低位为x高位为y[相对控件],lParam为 返回#TVHT_开头常量 的指针,消息返回值为命中的节点句柄)
         * </summary>
         **/
        public const int TVM_HITTEST = 4369;
        /** <summary>
         * 插入节点(lParam为 EX_TREEVIEW_ITEMINFO 指针，tzText为Unicode)
         * </summary>
         **/
        public const int TVM_INSERTITEMW = 4402;
        /** <summary>
         * 置选中项(lParam为选中的节点句柄)
         * </summary>
         **/
        public const int TVM_SELECTITEM = 4363;
        /** <summary>
         * 设置留白宽度(wParam为留白宽度)
         * </summary>
         **/
        public const int TVM_SETINDENT = 4359;
        /** <summary>
         * 设置节点标题(wParam为节点句柄,lParam为 EX_TREEVIEW_ITEMINFO 指针)
         * </summary>
         **/
        public const int TVM_SETITEMW = 4415;
        /** <summary>
         * 更新树形框
         * </summary>
         **/
        public const int TVM_UPDATE = 4499;
        /** <summary>
         * 设置行高(lParam为新行高)
         * </summary>
         **/
        public const int TVM_SETITEMHEIGHT = 5091;
        /** <summary>
         * 获取行高
         * </summary>
         **/
        public const int TVM_GETITEMHEIGHT = 5092;
        /** <summary>
         * 从索引获取节点句柄(wParam为索引,节点必须可见否则返回0)
         * </summary>
         **/
        public const int TVM_GETNODEFROMINDEX = 5093;
        /** <summary>
         * 设置节点标题(wParam为节点句柄,lParam为 文本指针,Unicode)
         * </summary>
         **/
        public const int TVM_SETITEMTEXTW = 14414;
        /** <summary>
         * 获取节点标题(wParam为节点句柄,返回值为标题Unicode字符串,不要自行释放)
         * </summary>
         **/
        public const int TVM_GETITEMTEXTW = 14415;
        #endregion

        #region TVGN_
        /** <summary>
         * 获取根节点
         * </summary>
         **/
        public const int TVGN_ROOT = 0;
        /** <summary>
         * 获取下一个节点
         * </summary>
         **/
        public const int TVGN_NEXT = 1;
        /** <summary>
         * 获取上一个节点
         * </summary>
         **/
        public const int TVGN_PREVIOUS = 2;
        /** <summary>
         * 获取父节点
         * </summary>
         **/
        public const int TVGN_PARENT = 3;
        /** <summary>
         * 获取子节点
         * </summary>
         **/
        public const int TVGN_CHILD = 4;
        /** <summary>
         * 获取下一个可见节点
         * </summary>
         **/
        public const int TVGN_NEXTVISIBLE = 6;
        #endregion

        #region TVHT_
        /** <summary>
         * 没有命中
         * </summary>
         **/
        public const int TVHT_NOWHERE = 1;
        /** <summary>
         * 命中图标
         * </summary>
         **/
        public const int TVHT_ONITEMICON = 2;
        /** <summary>
         * 命中标题
         * </summary>
         **/
        public const int TVHT_ONITEMLABEL = 4;
        /** <summary>
         * 命中留白
         * </summary>
         **/
        public const int TVHT_ONITEMINDENT = 8;
        /** <summary>
         * 命中加减框
         * </summary>
         **/
        public const int TVHT_ONITEMSTATEICON = 64;
        #endregion

        #region TVN_
        /** <summary>
         * 删除节点
         * </summary>
         **/
        public const int TVN_DELETEITEM = 391;
        /** <summary>
         * 节点展开
         * </summary>
         **/
        public const int TVN_ITEMEXPANDED = 394;
        /** <summary>
         * 节点展开中
         * </summary>
         **/
        public const int TVN_ITEMEXPANDING = 395;
        /** <summary>
         * 绘制节点
         * </summary>
         **/
        public const int TVN_DRAWITEM = 3099;
        #endregion

        #region 报表框_
        /** <summary>
         * 报表风格_绘制横线
         * </summary>
         **/
        public const int ERLS_DRAWHORIZONTALLINE = 256;
        /** <summary>
         * 报表风格_绘制竖线
         * </summary>
         **/
        public const int ERLS_DRAWVERTICALLINE = 512;
        /** <summary>
         * 报表风格_无表头
         * </summary>
         **/
        public const int ERLS_NOHEAD = 1024;
        #endregion

        #region ERLV_CS_
        /** <summary>
         * 表头风格_可点击
         * </summary>
         **/
        public const int ERLV_CS_CLICKABLE = 1;
        /** <summary>
         * 表头风格_锁定宽度
         * </summary>
         **/
        public const int ERLV_CS_LOCKWIDTH = 2;
        /** <summary>
         * 表头风格_可排序(前提是得可点击)
         * </summary>
         **/
        public const int ERLV_CS_SORTABLE = 4;
        #endregion

        #region RLVN_
        /** <summary>
         * 表头被单击
         * </summary>
         **/
        public const int RLVN_COLUMNCLICK = 97000;
        /** <summary>
         * 绘制表行
         * </summary>
         **/
        public const int RLVN_DRAW_TR = 97001;
        /** <summary>
         * 绘制表项
         * </summary>
         **/
        public const int RLVN_DRAW_TD = 97002;
        /** <summary>
         * 检查框点击事件
         * </summary>
         **/
        public const int RLVN_CHECK = 97003;
        /** <summary>
         * 检查框点击消息
         * </summary>
         **/
        public const int RLVM_CHECK = 99001;
        /** <summary>
         * 设置检查框状态
         * </summary>
         **/
        public const int RLVM_SETCHECK = 99002;
        /** <summary>
         * 获取检查框状态
         * </summary>
         **/
        public const int RLVM_GETCHECK = 99003;
        #endregion

        #region SW_
        /** <summary>
         * 显示
         * </summary>
         **/
        public const int SW_SHOW = 5;
        /** <summary>
         * 隐藏
         * </summary>
         **/
        public const int SW_HIDE = 0;
        /** <summary>
         * 最大化
         * </summary>
         **/
        public const int SW_SHOWMAXIMIZED = 3;
        /** <summary>
         * 最小化
         * </summary>
         **/
        public const int SW_SHOWMINIMIZED = 2;
        /** <summary>
         * 不激活
         * </summary>
         **/
        public const int SW_SHOWNOACTIVATE = 4;
        #endregion

        #region PBM_
        /** <summary>
         * 设置进度条范围
         * </summary>
         **/
        public const int PBM_SETRANGE = 1025;
        /** <summary>
         * 设置进度条位置
         * </summary>
         **/
        public const int PBM_SETPOS = 1026;
        /** <summary>
         * 获取进度条位置
         * </summary>
         **/
        public const int PBM_GETPOS = 1032;
        /** <summary>
         * 获取进度条范围
         * </summary>
         **/
        public const int PBM_GETRANGE = 1031;
        #endregion

        #region ERLV_RS_
        /** <summary>
         * 表项带检查框
         * </summary>
         **/
        public const int ERLV_RS_CHECKBOX = 1;
        /** <summary>
         * 检查框为选中状态
         * </summary>
         **/
        public const int ERLV_RS_CHECKBOX_CHECK = 2;
        #endregion

        #region EPF_
        /** <summary>
         * 暂无注释
         * </summary>
         **/
        public const int EPF_DISABLESCALE = 1;
        #endregion

        #region EOP_
        /** <summary>
         * 组件位置默认值
         * </summary>
         **/
        public const int EOP_DEFAULT = -2147483648;
        #endregion

        #region TVM_
        /** <summary>
         * 设置图片组(wParam为是否更新表项宽高,lParam为图片组句柄)
         * </summary>
         **/
        public const int TVM_SETIMAGELIST = 4361;
        /** <summary>
         * 获取图片组
         * </summary>
         **/
        public const int TVM_GETIMAGELIST = 4360;
        #endregion

        #region 树形框风格_
        /** <summary>
         * 树形框风格_显示加减号
         * </summary>
         **/
        public const int ETS_SHOWADDANDSUB = 64;
        /** <summary>
         * 树形框风格_显示连接线
         * </summary>
         **/
        public const int ETS_SHOWCABLE = 128;
        #endregion

        #region EPDF_
        /** <summary>
         * 主题包头
         * </summary>
         **/
        public const int EPDF_THEME = 254;
        /** <summary>
         * 资源包头
         * </summary>
         **/
        public const int EPDF_FILES = 255;
        #endregion

        #region MBN_
        /** <summary>
         * 让菜单按钮弹出菜单(wParam:菜单组,lParam:菜单句柄)
         * </summary>
         **/
        public const int MBM_POPUP = 103001;
        /** <summary>
         * 菜单弹出事件(wParam:菜单组,lParam:菜单句柄)
         * </summary>
         **/
        public const int MBN_POPUP = 102401;
        #endregion

        #region IMAGE_
        /** <summary>
         * 位图
         * </summary>
         **/
        public const int IMAGE_BITMAP = 0;
        /** <summary>
         * 图标
         * </summary>
         **/
        public const int IMAGE_ICON = 1;
        #endregion

        #region PFB_
        /** <summary>
         * 图已填充
         * </summary>
         **/
        public const int PFB_FILL = 0;

        /** <summary>
        * 图是中空
        * </summary>
        **/
        public const int PFB_VOI = 1;
        #endregion

        #region DT_
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

        #region 窗口消息
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
        public const int WM_NCHITTEST = 132;
        public const int WM_KEYDOWN = 256;
        public const int WM_KEYUP = 257;
        public const int WM_CHAR = 258;
        public const int WM_COMMAND = 273;
        public const int WM_TIMER = 275;
        public const int WM_HSCROLL = 276;
        public const int WM_VSCROLL = 277;
        public const int WM_MOUSEMOVE = 512;
        public const int WM_LBUTTONDOWN = 513;
        public const int WM_LBUTTONUP = 514;
        public const int WM_LBUTTONDBLCLK = 515;
        public const int WM_RBUTTONDOWN = 516;
        public const int WM_RBUTTONUP = 517;
        public const int WM_MOUSEWHEEL = 522;
        /// <summary>
        /// 收到拖拽文件
        /// </summary>
        public const int WM_DROPFILES = 563;
        public const int WM_MOUSEHOVER = 673;

        public const int WM_MOUSELEAVE = 675;
        public const int WM_CUT = 768;
        public const int WM_COPY = 769;
        public const int WM_PASTE = 770;
        public const int WM_CLEAR = 771;

        #endregion

        #region 开关消息
        public const int BM_GETCHECK = 240;
        public const int BM_SETCHECK = 241;
        #endregion

        #region 字体风格
        // 字体风格_普通
        public const int FS_DEFAULT = 0;
        // 字体风格_加粗
        public const int FS_BOLD = 1;
        // 字体风格_倾斜
        public const int FS_ITALIC = 2;
        // 字体风格_下划线
        public const int FS_UNDERLINE = 4;
        // 字体风格_删除线
        public const int FS_STRICKOUT = 8;
        #endregion

    }
}
