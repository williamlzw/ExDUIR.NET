using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class TreeViewWindow
    {
        static private ExSkin skin;
        static private ExTreeView treeview;

        static public void CreateTreeViewWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试树形列表", 0, 0, 350, 350,
            EWS_NOINHERITBKG | EWS_BUTTON_CLOSE | EWS_BUTTON_MIN | EWS_MOVEABLE |
            EWS_CENTERWINDOW | EWS_TITLE | EWS_HASICON | EWS_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                treeview = new ExTreeView(skin, "", 50, 50, 250, 250, EOS_BORDER | EOS_VISIBLE | EOS_HSCROLL | EOS_VSCROLL);
                treeview.ColorBackground = Util.ExRGBA(255, 255, 255, 125);
                treeview.ColorBorder = Util.ExRGBA(255, 255, 255, 255);
                ExTreeViewInsertInfo ti1 = new ExTreeViewInsertInfo
                {
                    fExpand = false,
                    pwzText = Marshal.StringToHGlobalUni("节点1")
                };
                treeview.InsertItem(ti1);

                ExTreeViewInsertInfo ti2 = new ExTreeViewInsertInfo
                {
                    fExpand = false,
                    pwzText = Marshal.StringToHGlobalUni("节点2")
                };
                treeview.InsertItem(ti2);

                ExTreeViewInsertInfo ti3 = new ExTreeViewInsertInfo
                {
                    fExpand = false,
                    pwzText = Marshal.StringToHGlobalUni("节点3"),
                };

                var ti3Index = treeview.InsertItem(ti3);
                ExTreeViewInsertInfo ti31 = new ExTreeViewInsertInfo
                {
                    fExpand = false,
                    pwzText = Marshal.StringToHGlobalUni("节点3-1"),
                    itemParent = ti3Index
                };
                treeview.InsertItem(ti31);

                ExTreeViewInsertInfo ti32 = new ExTreeViewInsertInfo
                {
                    fExpand = false,
                    pwzText = Marshal.StringToHGlobalUni("节点3-2"),
                    itemParent = ti3Index
                };
                treeview.InsertItem(ti32);

                ExTreeViewInsertInfo ti33 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点3-3"),
                    itemParent = ti3Index
                };
                var ti33Index = treeview.InsertItem(ti33);

                ExTreeViewInsertInfo ti331 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点3-3-1"),
                    itemParent = ti33Index
                };
                treeview.InsertItem(ti331);

                ExTreeViewInsertInfo ti332 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点3-3-2"),
                    itemParent = ti33Index
                };
                treeview.InsertItem(ti332);

                ExTreeViewInsertInfo ti4 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点4")
                };
                treeview.InsertItem(ti4);

                ExTreeViewInsertInfo ti5 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5")
                };
                var ti5Index = treeview.InsertItem(ti5);

                ExTreeViewInsertInfo ti51 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-1"),
                    itemParent = ti5Index
                };
                treeview.InsertItem(ti51);

                ExTreeViewInsertInfo ti52 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2"),
                    itemParent = ti5Index
                };
                var ti52Index = treeview.InsertItem(ti52);

                ExTreeViewInsertInfo ti521 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-1"),
                    itemParent = ti52Index
                };
                treeview.InsertItem(ti521);

                ExTreeViewInsertInfo ti522 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-2"),
                    itemParent = ti52Index
                };
                var ti522Index =  treeview.InsertItem(ti522);

                ExTreeViewInsertInfo ti5221 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-2-1"),
                    itemParent = ti522Index
                };
                treeview.InsertItem(ti5221);

                ExTreeViewInsertInfo ti5222 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-2-2"),
                    itemParent = ti522Index
                };
                var ti5222Index = treeview.InsertItem(ti5222);

                ExTreeViewInsertInfo ti52221 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-2-2-1"),
                    itemParent = ti5222Index
                };
                var ti52221Index = treeview.InsertItem(ti52221);

                ExTreeViewInsertInfo ti522211 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-2-2-1-1"),
                    itemParent = ti52221Index
                };
                var ti522211Index = treeview.InsertItem(ti522211);

                ExTreeViewInsertInfo ti5222111 = new ExTreeViewInsertInfo
                {
                    fExpand = true,
                    pwzText = Marshal.StringToHGlobalUni("节点5-2-2-2-1-1-1"),
                    itemParent = ti522211Index
                };
                treeview.InsertItem(ti5222111);

                treeview.Update();
                skin.Visible = true;
            }
        }
    }
}
