using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks
{
    public class ExApp
    {
        public ExApp(byte[] theme, int dwGlobalFlags = 0)
        {
            if (theme != null)
            {

                IntPtr hInstance = WinAPI.GetModuleHandle(null);
                if (hInstance != IntPtr.Zero)
                {
                    if (!ExAPI.Ex_Init(hInstance, dwGlobalFlags, IntPtr.Zero, null, theme, (IntPtr)theme.Length, null, IntPtr.Zero))
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
