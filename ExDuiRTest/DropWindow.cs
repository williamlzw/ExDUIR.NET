using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace ExDuiRTest
{
    static class DropWindow
    {
        static private ExSkin skin;
        static private ExStatic label1;
        static private ExObjProcDelegate objProc;

        static public void CreateDropWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试接收拖曳信息", 0, 0, 300, 300,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_MOVEABLE | WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_NOSHADOW | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnDropMsgProc);
                label1 = new ExStatic(skin, "拖拽文本、文件到这里", 30, 30, 250, 250, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_BORDER, OBJECT_STYLE_EX_DRAGDROP | OBJECT_STYLE_EX_ACCEPTFILES, DT_SINGLELINE | DT_VCENTER | DT_CENTER, 0, IntPtr.Zero, objProc);
                skin.Visible = true;
            }
        }

        static private IntPtr OnDropMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            if (uMsg == WM_EX_DROP)//先触发本消息
            {
                var di = Util.IntPtrToStructure<ExDropInfo>(lParam);
                var obj = new ExControl(hObj);
                Console.WriteLine("aaaaaaaaaa");
                if (obj.CheckDropFormat(di.pDataObject, CF_UNICODETEXT) || obj.CheckDropFormat(di.pDataObject, CF_TEXT))
                {
                    var len = obj.GetDropString(di.pDataObject, out var str, 0);
                    if (len > 0)
                    {
                        StringBuilder strBuilder = new StringBuilder(len * 2 + 2);
                        var strRet = strBuilder.ToString();
                        obj.GetDropString(di.pDataObject, out strRet, len + 1);
                        Console.WriteLine($"接收到文本拖拽:{strRet}");
                        Marshal.WriteInt32(pResult, DROPEFFECT_COPY);
                        return (IntPtr)1;
                    }
                }
            }
            else if (uMsg == WM_DROPFILES)//若上面未处理,且控件拥有#OBJECT_STYLE_EX_ACCEPTFILES风格,则继续触发本消息
            {
                Console.WriteLine("bbbbbbbbb");
                var fileNumber = WinAPI.DragQueryFile(wParam, 0xFFFFFFFF, null, 0);
                foreach (var index in Enumerable.Range(0, (int)fileNumber))
                {
                    var fileNameLength = WinAPI.DragQueryFile(wParam, (uint)index, null, 0);
                    if (fileNameLength > 0)
                    {
                        StringBuilder fileName = new StringBuilder((int)fileNameLength);
                        WinAPI.DragQueryFile(wParam, (uint)index, fileName.ToString(), 0);
                        Console.WriteLine($"接收到文件拖拽:{fileName.ToString()}");
                    }
                }
                Marshal.WriteInt32(pResult, DROPEFFECT_LINK);
                return (IntPtr)1;
            }
            return IntPtr.Zero;
        }
    }
}
