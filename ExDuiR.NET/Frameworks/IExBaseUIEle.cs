using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using System;

namespace ExDuiR.NET.Frameworks
{
    public interface IExBaseUIEle
    {
        IntPtr GetLong(int nIndex);
        IntPtr SetLong(int nIndex, IntPtr nValue);

        IntPtr SendMessage(int uMsg, IntPtr wParam = new IntPtr(), IntPtr lParam = new IntPtr());
        bool PostMessage(int uMsg, IntPtr wParam = new IntPtr(), IntPtr lParam = new IntPtr());

        bool Move(int x, int y, int nWidth, int nHeight, bool fRedraw = true);
        bool SetPos(int x, int y, int nWidth, int nHeight, IntPtr hEleAfter, int dwFlags);

        bool SetBackgroundImage(byte[] image, int x, int y, int dwRepeat, IntPtr rcGrids, int dwFlags, int dwAlpha, bool fUpdate);

        bool SetBackgroundPlayState(bool fPlayFrames, bool fResetFrame, bool fUpdate);
        bool GetBackgroundImage(out ExBackgroundImageInfo pImageInfo);

        ExControl GetObjFromID(int id);
        ExControl GetObjFromName(string name);
        ExControl GetObjFromNodeID(int nodeid);

        ExControl GetFocus();

        bool TrackPopupMenu(IntPtr hMenu, int uFlags, int x, int y, IntPtr nReserved, ref ExRect pRc, ExWndProcDelegate pfnWndProc, int dwFlags);

        ExControl Find(ExControl pObjChildAfter = null, string sClassName = null, string sTitle = null);

        bool Validate { get; }

        bool Enable { get; set; }
        bool Visible { get; set; }
        int handle { get; }

        string Text { get; set; }

    }
}
