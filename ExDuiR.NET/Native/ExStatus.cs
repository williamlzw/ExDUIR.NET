namespace ExDuiR.NET.Native
{
    public class ExStatus
    {
        /** <summary>
         * 成功
         * </summary>
         **/
        public const int NOERROR = 0;

        /** <summary>
         * canvas初始化失败
         * </summary>
         **/
        public const int CANVAS_INITERROR = 16001;

        /** <summary>
         * 数据效验失败
         * </summary>
         **/
        public const int CHECKSUM = 16002;

        /** <summary>
         * 未支持的类型/格式
         * </summary>
         **/
        public const int UNSUPPORTED_TYPE = 16003;

        /** <summary>
         * 错误的长度
         * </summary>
         **/
        public const int BAD_LENGTH = 16004;

        /** <summary>
         * 错误的尺寸
         * </summary>
         **/
        public const int BAD_SIZE = 16005;

        /** <summary>
         * 未初始化的对象
         * </summary>
         **/
        public const int INVALID_OBJECT = 16006;

        /** <summary>
         * 状态错误
         * </summary>
         **/
        public const int DX_STATE = 16007;

        /** <summary>
         * 错误的文本
         * </summary>
         **/
        public const int BAD_STRING = 16008;

        /** <summary>
         * 未初始化的组件类
         * </summary>
         **/
        public const int INVALID_CLASS = 16009;

        /** <summary>
         * 超出尺寸/超出内存
         * </summary>
         **/
        public const int MEMORY_OVERFLOW = 16010;

        /** <summary>
         * 申请内存失败
         * </summary>
         **/
        public const int MEMORY_ALLOC = 16011;

        /** <summary>
         * 
         * </summary>
         **/
        public const int MEMORY_BADPTR = 16012;

        /** <summary>
         * 内存池，申请内存失败
         * </summary>
         **/
        public const int MEMPOOL_ALLOC = 16021;

        /** <summary>
         * 检索索引失败
         * </summary>
         **/
        public const int MEMPOOL_BADINDEX = 16022;

        /** <summary>
         * 检索指针失败
         * </summary>
         **/
        public const int MEMPOOL_BADPTR = 16023;

        /** <summary>
         * 未初始化的内存块
         * </summary>
         **/
        public const int MEMPOOL_INVALIDBLOCK = 16024;

        /** <summary>
         * 未初始化的内存池
         * </summary>
         **/
        public const int MEMPOOL_INVALID = 16025;

        /** <summary>
         * 检索索引失败
         * </summary>
         **/
        public const int HANDLE_BADINDEX = 16030;

        /** <summary>
         * 检索类型失败
         * </summary>
         **/
        public const int HANDLE_UNSUPPORTED_TYPE = 16031;

        /** <summary>
         * 检索句柄失败
         * </summary>
         **/
        public const int HANDLE_INVALID = 16032;

        /** <summary>
         * XML解析失败
         * </summary>
         **/
        public const int XML_PARSE = 16040;

        /** <summary>
         * 布局类型未初始化
         * </summary>
         **/
        public const int LAYOUT_INVALID = 16050;

        /** <summary>
         * 未支持的属性
         * </summary>
         **/
        public const int LAYOUT_UNSUPPORTED_PROP = 16051;

        /** <summary>
         * 未找到布局子组件或组件不是子组件
         * </summary>
         **/
        public const int LAYOUT_NOT_CHILD = 16052;


    }
}
