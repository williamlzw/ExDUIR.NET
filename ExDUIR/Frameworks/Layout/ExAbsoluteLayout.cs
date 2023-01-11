﻿using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;

namespace ExDuiR.NET.Frameworks.Layout
{
    public class ExAbsoluteLayout : ExBaseLayout
    {
        public ExAbsoluteLayout(ExControl objBind)
            : base(ELT_ABSOLUTE, objBind)
        {
        }

        public ExAbsoluteLayout(ExSkin objBind)
            : base(ELT_ABSOLUTE, objBind)
        {
        }

        public ExAbsoluteLayout(int hLayout)
            : base(hLayout)
        {
        }

        /// <summary>
        /// 锁定组件位置
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="tLeft">ELCP_ABSOLUTE_XXX_TYPE</param>
        /// <param name="tTop">ELCP_ABSOLUTE_XXX_TYPE</param>
        /// <param name="tRight">ELCP_ABSOLUTE_XXX_TYPE</param>
        /// <param name="tBottom">ELCP_ABSOLUTE_XXX_TYPE</param>
        /// <param name="tWidth">ELCP_ABSOLUTE_XXX_TYPE</param>
        /// <param name="tHeight">ELCP_ABSOLUTE_XXX_TYPE</param>
        /// <returns></returns>
        public bool Lock(ExControl obj, int tLeft, int tTop, int tRight, int tBottom, int tWidth, int tHeight)
        {
            return ExAPI._layout_absolute_lock(m_hLayout, obj.handle, tLeft, tTop, tRight, tBottom, tWidth, tHeight);
        }

        /// <summary>
        /// 绝对布局置边界信息
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="dwEdge">ELCP_ABSOLUTE_</param>
        /// <param name="dwType">ELCP_ABSOLUTE_TYPE_</param>
        /// <param name="nValue"></param>
        /// <returns></returns>
        public bool SetEdge(ExControl obj, int dwEdge, int dwType, IntPtr nValue)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, dwEdge, dwType, nValue);
        }

        /// <summary>
        /// 置左边百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetLeftPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_LEFT, ELCP_ABSOLUTE_TYPE_PS, (IntPtr)value);
        }

        /// <summary>
        /// 置左边像素
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetLeftPX(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_LEFT, ELCP_ABSOLUTE_TYPE_PX, (IntPtr)value);
        }

        /// <summary>
        /// 置顶边百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetTopPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_TOP, ELCP_ABSOLUTE_TYPE_PS, (IntPtr)value);
        }

        /// <summary>
        /// 置顶边像素
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetTopPX(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_TOP, ELCP_ABSOLUTE_TYPE_PX, (IntPtr)value);
        }

        /// <summary>
        /// 置右边百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetRightPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_RIGHT, ELCP_ABSOLUTE_TYPE_PS, (IntPtr)value);
        }

        /// <summary>
        /// 置右边像素
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetRightPX(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_RIGHT, ELCP_ABSOLUTE_TYPE_PX, (IntPtr)value);
        }

        /// <summary>
        /// 置底边百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetBottomPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_BOTTOM, ELCP_ABSOLUTE_TYPE_PS, (IntPtr)value);
        }

        /// <summary>
        /// 置底边像素
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetBottomPX(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_BOTTOM, ELCP_ABSOLUTE_TYPE_PX, (IntPtr)value);
        }

        /// <summary>
        /// 置宽度百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetWidthPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_WIDTH, ELCP_ABSOLUTE_TYPE_PS, (IntPtr)value);
        }

        /// <summary>
        /// 置宽度像素
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetWidthPX(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_WIDTH, ELCP_ABSOLUTE_TYPE_PX, (IntPtr)value);
        }

        /// <summary>
        /// 置高度百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetHeightPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_HEIGHT, ELCP_ABSOLUTE_TYPE_PS, (IntPtr)value);
        }

        /// <summary>
        /// 置高度像素
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetHeightPX(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_HEIGHT, ELCP_ABSOLUTE_TYPE_PX, (IntPtr)value);
        }

        /// <summary>
        /// 置水平偏移量百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetHorizontalOffsetPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_OFFSET_H, ELCP_ABSOLUTE_TYPE_OBJPS, (IntPtr)value);
        }

        /// <summary>
        /// 置垂直偏移量百分比
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetVerticalOffsetPS(ExControl obj, int value)
        {
            return ExAPI._layout_absolute_setedge(m_hLayout, obj.handle, ELCP_ABSOLUTE_OFFSET_V, ELCP_ABSOLUTE_TYPE_OBJPS, (IntPtr)value);
        }
    }
}
