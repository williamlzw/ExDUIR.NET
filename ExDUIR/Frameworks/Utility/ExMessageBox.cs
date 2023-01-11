using ExDuiR.NET.Native;
using System;

namespace ExDuiR.NET.Frameworks.Utility
{
    public class ExMessageBox
    {
        public static int Show(string sText, string sCaption = null, int uType = 0, int dwFlags = 0, IExBaseUIEle pOwner = null)
        {
            int hOwner = pOwner == null ? 0 : pOwner.handle;
            return ExAPI.Ex_MessageBox(hOwner, sText, sCaption, uType, dwFlags);
        }

        public static int Show(IExBaseUIEle pOwner, string sText, string sCaption, int uType = 0, int dwFlags = 0)
        {
            int hOwner = pOwner == null ? 0 : pOwner.handle;
            return ExAPI.Ex_MessageBox(hOwner, sText, sCaption, uType, dwFlags);
        }

        public static int ShowEx(IExBaseUIEle pOwner, string sText, string sCaption, int uType, string sCheckbox, ref bool pfChecked, int dwTimeout = 0, int dwFlags = 0, ExWndProcDelegate pfnWndProc = null)
        {
            int hOwner = pOwner == null ? 0 : pOwner.handle;
            return ExAPI.Ex_MessageBoxEx(hOwner, sText, sCaption, uType, sCheckbox, ref pfChecked, dwTimeout, dwFlags, pfnWndProc);
        }
    }
}
