﻿using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using System;

namespace ExDuiR.NET.Frameworks
{
    public interface IExBaseUIEle
    {
        nint GetLong(int nIndex);
        nint SetLong(int nIndex, nint nValue);

        nint SendMessage(int uMsg, nint wParam = new nint(), nint lParam = new nint());
        bool PostMessage(int uMsg, nint wParam = new nint(), nint lParam = new nint());

        bool Move(int x, int y, int nWidth, int nHeight, bool fRedraw = true);
        bool SetPos(int x, int y, int nWidth, int nHeight, nint hEleAfter, int dwFlags);

        bool SetBackgroundImage(byte[] image, int x, int y, int dwRepeat, nint rcGrids, int dwFlags, int dwAlpha, bool fUpdate);

        bool SetBackgroundPlayState(bool fPlayFrames, bool fResetFrame, bool fUpdate);
        bool GetBackgroundImage(out ExBackgroundImageInfo pImageInfo);

        ExControl GetObjFromID(int id);
        ExControl GetObjFromName(string name);
        ExControl GetObjFromNodeID(int nodeid);

        ExControl GetFocus();

        bool TrackPopupMenu(nint hMenu, int uFlags, int x, int y, nint nReserved, ref ExRect pRc, ExWndProcDelegate pfnWndProc, int dwFlags);

        bool LoadLayoutXml(byte[] pLayout, nint hRes);

        ExControl Find(ExControl pObjChildAfter = null, string sClassName = null, string sTitle = null);



        bool Validate { get; }

        bool Enable { get; set; }
        bool Visible { get; set; }
        int handle { get; }

        string Text { get; set; }

    }
}
