using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks
{
    public class ExApp
    {
        /// <summary>
        /// 初始化引擎
        /// </summary>
        /// <param name="theme">主题包数据</param>
        /// <param name="dwGlobalFlags">引擎风格,常量EXGF_</param>
        /// <param name="hDefaultCursor">默认鼠标指针</param>
        /// <exception cref="ExException"></exception>
        public ExApp(byte[] theme, int dwGlobalFlags = 0, IntPtr hDefaultCursor = default)
        {
            if (theme != null)
            {
                IntPtr hInstance = WinAPI.GetModuleHandle(null);
                if (hInstance != IntPtr.Zero)
                {
                    if (!ExAPI.Ex_Init(hInstance, dwGlobalFlags, hDefaultCursor, null, theme, (IntPtr)theme.Length, null, IntPtr.Zero))
                    { 
                        throw new ExException(-1, "引擎初始化失败");
                    }
                    
                }
                else throw new ExException(ExStatus.HANDLE_INVALID, "实例句柄获取失败");
            }
            else throw new ExException(ExStatus.MEMORY_BADPTR, "参数错误");
        }

        ~ExApp()
        {
            ExAPI.Ex_UnInit();
        }

        public void Run()
        {
            ExAPI.Ex_WndMsgLoop();
        }

        public int LastError { get => ExAPI.Ex_GetLastError(); set => ExAPI.Ex_SetLastError(value); }
    }
}
