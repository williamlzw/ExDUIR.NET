using System;
using ExDuiR.NET.Native;

namespace ExDuiR.NET.Frameworks.Controls
{
    public class ExScrollBar : ExControl
    {
        public ExScrollBar(IExBaseUIEle oParent, string sTitle, int x, int y, int nWidth, int nHeight)
            : base(oParent, "ScrollBar", sTitle, x, y, nWidth, nHeight)
        {
        }

        public new string ClassName => "ScrollBar";

        public bool ScrollEnable(int wSB, int wArrows)
        {
            return ExAPI.Ex_ObjScrollEnable(m_hObj, wSB, wArrows);
        }

        public nint GetControl(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetControl(m_hObj, nBar);
        }

        public bool GetInfo(int fnBar, out int lpnMin, out int lpnMax, out int lpnPos, out int lpnTrackPos)
        {
            return ExAPI.Ex_ObjScrollGetInfo(m_hObj, fnBar, out lpnMin, out lpnMax, out lpnPos, out lpnTrackPos);
        }

        public int GetPos(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetPos(m_hObj, nBar);
        }

        public bool GetRange(int nBar, out int lpnMinPos, out int lpnMaxPos)
        {
            return ExAPI.Ex_ObjScrollGetRange(m_hObj, nBar, out lpnMinPos, out lpnMaxPos);
        }

        public int GetTrackPos(int nBar)
        {
            return ExAPI.Ex_ObjScrollGetTrackPos(m_hObj, nBar);
        }

        public int SetInfo(int fnBar, int fMask, int nMin, int nMax, int nPage, int nPos, bool fRedraw)
        {
            return ExAPI.Ex_ObjScrollSetInfo(m_hObj, fnBar, fMask, nMin, nMax, nPage, nPos, fRedraw);
        }

        public int SetPos(int nBar, int nPos, bool bRedraw)
        {
            return ExAPI.Ex_ObjScrollSetPos(m_hObj, nBar, nPos, bRedraw);
        }

        public bool SetRange(int nBar, int nMin, int nMax, bool bRedraw)
        {
            return ExAPI.Ex_ObjScrollSetRange(m_hObj, nBar, nMin, nMax, bRedraw);
        }

        public bool ScrollShow(int wBar, bool fShow)
        {
            return ExAPI.Ex_ObjScrollShow(m_hObj, wBar, fShow);
        }
    }
}
