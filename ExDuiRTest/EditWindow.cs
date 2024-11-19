using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Layout;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Collections.Generic;

namespace ExDuiRTest
{
    static class EditWindow
    {
        static private ExSkin skin;
        static private ExEdit edit1;
        static private ExEdit edit2;
        static private ExEdit edit3;
        static private ExEdit edit4;
        static private ExEdit edit5;
        static private ExEdit edit6;
        static private ExEdit edit7;
        static private ExPage page;
        static private ExFlowLayout flowLayout;
        static private List<ExButton> buttons;
        static private ExObjEventProcDelegate editNotifyEventProc;
        static private ExObjEventProcDelegate editButtonEventProc;

        static public void CreateEditWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试编辑框", 0, 0, 850, 350,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                edit1 = new ExEdit(skin, "背景图片编辑框", 10, 30, 150, 30, OBJECT_STYLE_VISIBLE | EDIT_STYLE_HIDESELECTION, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED | OBJECT_STYLE_EX_CUSTOMDRAW, DT_VCENTER);
                var bitmap = Properties.Resources.editbkg;
                edit1.SetBackgroundImage(bitmap, 0, 0, 0, default, 0, 255, true);
                edit2 = new ExEdit(skin, "测试密码输入编辑框", 10, 70, 150, 30, OBJECT_STYLE_VISIBLE | EDIT_STYLE_USEPASSWORD, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED, DT_SINGLELINE);
                edit3 = new ExEdit(skin, "测试数值输入编辑框", 10, 110, 150, 30, OBJECT_STYLE_VISIBLE | EDIT_STYLE_NUMERICINPUT, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED, DT_SINGLELINE);
                edit4 = new ExEdit(skin, "测试只读编辑框", 10, 150, 150, 30, OBJECT_STYLE_VISIBLE | EDIT_STYLE_READONLY, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED, DT_SINGLELINE);
                edit5 = new ExEdit(skin, "测试透明圆角编辑框", 10, 190, 150, 30, OBJECT_STYLE_VISIBLE | EDIT_STYLE_HIDESELECTION, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED | OBJECT_STYLE_EX_TABSTOP | OBJECT_STYLE_EX_CUSTOMDRAW, DT_VCENTER);
                edit5.SetFont("微软雅黑", 16, FONT_STYLE_UNDERLINE | FONT_STYLE_ITALIC, false);

                edit5.ColorBackground = Util.ExARGB(200, 120, 130, 100);
                edit5.ColorTextNormal = Util.ExARGB(23, 115, 1, 100);
                edit5.SetRadius(10, 10, 10, 0, false);
                edit6 = new ExEdit(skin, "测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框\r\n测试多行编辑框",
                    10, 230, 150, 100, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_VSCROLL, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED, DT_VCENTER);
                edit7 = new ExEdit(skin, "测试透明圆角编辑框", 180, 30, 300, 300, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_VSCROLL | OBJECT_STYLE_HSCROLL | EDIT_STYLE_RICHTEXT | EDIT_STYLE_PARSEURL | EDIT_STYLE_ALLOWTAB | EDIT_STYLE_NEWLINE, OBJECT_STYLE_EX_FOCUSABLE, DT_LEFT | DT_TOP, 101);
                var rtf = Properties.Resources.testrtf;
                byte[] rtfdata = System.Text.Encoding.UTF8.GetBytes(rtf.ToCharArray());
                //byte[] rtfdata = System.IO.File.ReadAllBytes(".\\res\\test.rtf");
                editNotifyEventProc = new ExObjEventProcDelegate(OnEditNotifyEventProc);
                edit7.LoadRtf(rtfdata);
                edit7.HandleEvent(NM_EN_SELCHANGE, editNotifyEventProc);
                edit7.HandleEvent(NM_EN_LINK, editNotifyEventProc);

                editButtonEventProc = new ExObjEventProcDelegate(OnEditButtonEventProc);
                List<string> buttonTiles = new List<string> { "全选", "取消选择", "置选择", "左对齐 ", "居中对齐", "右对齐", "首行缩进 ", "右侧缩进", "非首行缩进",
                    "项目符", "文本蓝色 ", "加粗", "倾斜", "下划线", "删除线", "超链接", "幼圆30", "撤销 ", "重做", "复制", "剪切", "粘贴", "删除", "取行数 ",
                    "寻找文本", "替换文本" };
                page = new ExPage(skin, "", 500, 30, 350, 300);
                flowLayout = new ExFlowLayout(page);

                buttons = new List<ExButton>();
                for (var i = 0; i < buttonTiles.Count; i++)
                {
                    var bWrapLine = buttonTiles[i].EndsWith(" ");
                    string title;
                    if (bWrapLine)
                    {
                        title = buttonTiles[i].Substring(0, buttonTiles[i].Length - 1);
                    }
                    else
                    {
                        title = buttonTiles[i];
                    }

                    buttons.Add(new ExButton(page, title, 10, 30, 10, 10, -1, OBJECT_STYLE_EX_AUTOSIZE, -1, 201 + i));
                    var ret = flowLayout.SetChildProp(buttons[i], LAYOUT_SUBPROP_MARGIN_RIGHT, (IntPtr)5);

                    flowLayout.SetChildProp(buttons[i], LAYOUT_SUBPROP_MARGIN_BOTTOM, (IntPtr)5);
                    if (bWrapLine)
                    {
                        flowLayout.SetChildProp(buttons[i], LAYOUT_SUBPROP_FLOW_NEW_LINE, (IntPtr)1);
                    }
                    buttons[i].HandleEvent(NM_CLICK, editButtonEventProc);
                }
                page.SetLayout(flowLayout);
                skin.Visible = true;
            }
        }

        static private IntPtr OnEditButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (edit7.Validate)
            {
                switch (nID)
                {
                    case 201:
                        edit7.SelectAll();
                        break;
                    case 202:
                        edit7.CancelSelect();
                        break;
                    case 203:
                        edit7.Select(1, 15);
                        break;
                    case 204:
                        edit7.AlignLeft();
                        break;
                    case 205:
                        edit7.AlignCenter();
                        break;
                    case 206:
                        edit7.AlignRight();
                        break;
                    case 207:
                        edit7.SetSelParStartIndentation(20);
                        break;
                    case 208:
                        edit7.SetSelParRightIndentation(20);
                        break;
                    case 209:
                        edit7.SetSelParOffset(50);
                        break;
                    case 210:
                        edit7.SetSelParNumbering(EDIT_PARAGRAPHFSYMBOL_LCROMAN);
                        break;
                    case 211:
                        edit7.SetSelCharColor(Util.ExRGB2ARGB(16711680, 255));
                        break;
                    case 212:
                        edit7.SetSelCharBold();
                        break;
                    case 213:
                        edit7.SetSelCharItalic();
                        break;
                    case 214:
                        edit7.SetSelCharUnderLine();
                        break;
                    case 215:
                        edit7.SetSelCharStrikeOut();
                        break;
                    case 216:
                        edit7.SetSelCharLink();
                        break;
                    case 217:
                        edit7.SetSelCharFont("幼圆", 30);
                        break;
                    case 218:
                        edit7.Undo();
                        break;
                    case 219:
                        edit7.Redo();
                        break;
                    case 220:
                        edit7.Copy();
                        break;
                    case 221:
                        edit7.Cut();
                        break;
                    case 222:
                        edit7.Paste();
                        break;
                    case 223:
                        edit7.Clear();
                        break;
                    case 224:
                        Console.WriteLine($"编辑框行数:{edit7.GetLineCount()}");
                        break;
                    case 225:
                        edit7.FindText("a");
                        break;
                    case 226:
                        edit7.ReplaceText("选中替换为我");
                        break;
                    default:
                        break;
                }
            }
            return IntPtr.Zero;
        }

        static private IntPtr OnEditNotifyEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode == NM_EN_SELCHANGE)
            {
                ExSelChange selcha = Util.IntPtrToStructure<ExSelChange>(lParam);
                Console.WriteLine(String.Format("选中区域改变:{0},{1}", selcha.chrg.cpMin, selcha.chrg.cpMax));
            }
            else if (nCode == NM_EN_LINK)
            {
                ExEnLink selcha = Util.IntPtrToStructure<ExEnLink>(lParam);
                if (selcha.msg == WM_LBUTTONDOWN)
                {
                    Console.WriteLine(String.Format("链接被按下: {0}", edit7.GetLinkText(selcha)));
                }
            }
            return IntPtr.Zero;
        }
    }

}
