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

                nint hInstance = WinAPI.GetModuleHandle(null);
                if (hInstance != nint.Zero)
                {
                    if (!ExAPI.Ex_Init(hInstance, dwGlobalFlags, nint.Zero, null, theme, (nint)theme.Length, null, nint.Zero))
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
