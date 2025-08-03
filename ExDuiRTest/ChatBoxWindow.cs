using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using ExDuiR.NET.Frameworks.Graphics;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    class ChatBoxWindow
    {
        static private ExSkin skin;
        static private ExChatBox chatbox;
        static private ExObjEventProcDelegate objProc;
        static private ExObjEventProcDelegate chatboxProc;
        static private ExEdit edit;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExButton button4;
        static private ExButton button5;

        static public void CreateChatBoxWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试对话盒", 0, 0, 1100, 1000,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(80, 80, 90, 255);
                objProc = new ExObjEventProcDelegate(OnChatButtonEvent);
                chatboxProc = new ExObjEventProcDelegate(OnChatBoxEvent);
                edit = new ExEdit(skin, "测试多行编辑框\n测试多行编辑框测试多行编辑框\n测试多行编辑框测试多行编辑框测试多行编辑框\n测试多行编辑框测试多行编辑框测试多行编辑框测试多行编辑框",
                    50, 830, 600, 100, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_VSCROLL, OBJECT_STYLE_EX_FOCUSABLE | OBJECT_STYLE_EX_COMPOSITED, DT_VCENTER);
                button1 = new ExButton(skin, "发送助手", 50, 950, 100, 30, -1, -1, DT_CENTER | DT_VCENTER, 101);
                button2 = new ExButton(skin, "发送用户", 180, 950, 100, 30, -1, -1, DT_CENTER | DT_VCENTER, 102);
                button3 = new ExButton(skin, "更新文本", 310, 950, 100, 30, -1, -1, DT_CENTER | DT_VCENTER, 103);
                button4 = new ExButton(skin, "更新卡片", 440, 950, 100, 30, -1, -1, DT_CENTER | DT_VCENTER, 104);
                button5 = new ExButton(skin, "取内容", 570, 950, 100, 30, -1, -1, DT_CENTER | DT_VCENTER, 105);
                button1.HandleEvent(NM_CLICK, objProc);
                button2.HandleEvent(NM_CLICK, objProc);
                button3.HandleEvent(NM_CLICK, objProc);
                button4.HandleEvent(NM_CLICK, objProc);
                button5.HandleEvent(NM_CLICK, objProc);
                chatbox = new ExChatBox(skin, "", 50, 50, 1000, 750);
                chatbox.HandleEvent(CHATBOX_EVENT_CLICKBUTTON, chatboxProc);
                chatbox.HandleEvent(CHATBOX_EVENT_CLICKLINK, chatboxProc);

                chatbox.AssistantImg = new ExImage(Properties.Resources.ai);
                chatbox.UserImg = new ExImage(Properties.Resources.user);
                chatbox.AddItemText("C#编写的计算当前月天数的方法", true);
                string assistant = @"以下是一个用C#编写的计算当前月天数的方法：
                using System;

                public class MonthDaysCalculator
                {
                    /// <summary>
                    /// 获取当前月份的天数
                    /// </summary>
                    /// <returns>当前月份的总天数</returns>
                    public static int GetDaysInCurrentMonth()
                    {
                        DateTime today = DateTime.Today;
                        return DateTime.DaysInMonth(today.Year, today.Month);
                    }

                    /// <summary>
                    /// 获取指定年份和月份的天数
                    /// </summary>
                    /// <param name=""year"">年份</param>
                    /// <param name=""month"">月份(1-12)</param>
                    /// <returns>该月的总天数</returns>
                    public static int GetDaysInMonth(int year, int month)
                    {
                        return DateTime.DaysInMonth(year, month);
                    }
                }

                // 使用示例
                class Program
                {
                    static void Main(string[] args)
                    {
                        int daysInCurrentMonth = MonthDaysCalculator.GetDaysInCurrentMonth();
                        Console.WriteLine($""当前月份有 {daysInCurrentMonth} 天"");

                        // 也可以查询指定年月
                        int days = MonthDaysCalculator.GetDaysInMonth(2023, 2);
                        Console.WriteLine($""2023年2月有 {days} 天"");
                    }
                }   
                这个方法使用了.NET框架内置的DateTime.DaysInMonth方法，它可以正确处理闰年二月的情况（28天或29天）。

                主要特点：

                GetDaysInCurrentMonth()方法无需参数，直接返回当前月份的天数

                还提供了GetDaysInMonth(int year, int month)方法，可以查询任意年份月份的天数

                这两个方法都是静态方法，可以直接调用

                这个方法会正确处理所有月份，包括不同年份的二月天数差异。
                ";
                chatbox.AddItemText(assistant, false);
                chatbox.AddItemText("输出更多样式", true);

                //============================
                chatbox.AddItemCard(new ExImage(Properties.Resources.user),
                    "测试卡片标题!",
                    "测试卡片内容测试卡片内容测试卡片内容测试卡片内容测试卡片内容测试卡片内容测试卡片内容测试卡片内容测试卡片内容",
                    "测试卡片子标题",
                    "测试卡片子内容测试卡片子内容测试卡片子内容测试卡片子内容测试卡片子内容测试卡片子内容测试卡片子内容测试卡片子内容.",
                    "测试按钮");

                //============================
                chatbox.AddItemMode(new ExImage(Properties.Resources.user),
                   "完成标题",
                   "完成内容!");

                //============================
                List<ExChatBoxItemInfoErrorListUnit> units = new List<ExChatBoxItemInfoErrorListUnit>();
                ExChatBoxItemInfoErrorListUnit unit1 = new ExChatBoxItemInfoErrorListUnit
                {
                    errorCode = Marshal.StringToHGlobalUni("错误ID"),
                    errorCodeText = Marshal.StringToHGlobalUni("20"),
                    description = Marshal.StringToHGlobalUni("错误描述"),
                    descriptionText = Marshal.StringToHGlobalUni("错误详情\r\n[来源]Microsoft-Windows-WindowsUpdateClient\r\n[创建时间]2025-06-24 23:25:18\r\n[记录ID]26994"),
                };
                units.Add(unit1);
                ExChatBoxItemInfoErrorListUnit unit2 = new ExChatBoxItemInfoErrorListUnit
                {
                    errorCode = Marshal.StringToHGlobalUni("错误ID"),
                    errorCodeText = Marshal.StringToHGlobalUni("20"),
                    description = Marshal.StringToHGlobalUni("错误描述"),
                    descriptionText = Marshal.StringToHGlobalUni("错误详情\r\n[来源]Microsoft-Windows-WindowsUpdateClient\r\n[创建时间]2025-06-24 23:25:18\r\n[记录ID]26994\r\n错误详情\r\n[来源]Microsoft-Windows-WindowsUpdateClient\r\n[创建时间]2025-06-24 23:25:18\r\n[记录ID]26994"),
                };
                units.Add(unit2);
                ExChatBoxItemInfoErrorListUnit unit3 = new ExChatBoxItemInfoErrorListUnit
                {
                    errorCode = Marshal.StringToHGlobalUni("错误ID"),
                    errorCodeText = Marshal.StringToHGlobalUni("20"),
                    description = Marshal.StringToHGlobalUni("错误描述"),
                    descriptionText = Marshal.StringToHGlobalUni("错误详情\r\n[来源]Microsoft-Windows-WindowsUpdateClient\r\n[创建时间]2025-06-24 23:25:18\r\n[记录ID]26994"),
                };
                units.Add(unit3);
                chatbox.AddItemErrorList(new ExImage(Properties.Resources.user),
                    "一些错误被捕捉",
                    units);

                //============================
                List<ExChatBoxItemInfoInfoListUnit> unitsInfo = new List<ExChatBoxItemInfoInfoListUnit>();
                ExChatBoxItemInfoInfoListUnit unitInfo1 = new ExChatBoxItemInfoInfoListUnit
                {
                    title = Marshal.StringToHGlobalUni("CPU"),
                    description = Marshal.StringToHGlobalUni("Intel i9 14900k")
                };
                unitsInfo.Add(unitInfo1);
                ExChatBoxItemInfoInfoListUnit unitInfo2 = new ExChatBoxItemInfoInfoListUnit
                {
                    title = Marshal.StringToHGlobalUni("网络"),
                    description = Marshal.StringToHGlobalUni("●Intel Ethernet Connection 1219-LM\n●TP-LINK Wireless N Adapter\n●Marvell AQtion 10Gbit Network Adapter")
                };
                unitsInfo.Add(unitInfo2);
                ExChatBoxItemInfoInfoListUnit unitInfo3 = new ExChatBoxItemInfoInfoListUnit
                {
                    title = Marshal.StringToHGlobalUni("GPU"),
                    description = Marshal.StringToHGlobalUni("NVIDIA RTX 4090")
                };
                unitsInfo.Add(unitInfo3);
                chatbox.AddItemInfoList(new ExImage(Properties.Resources.user),
                    "以下是信息列表",
                    unitsInfo);

                //============================
                var tableData = new List<string[]>
                {
                    new string[] { "Header1", "Header2", "Header3", "Header4" },
                    new string[] { "Row1Col1", "Row1Col2", "行1列3\n多行文本", "Row1Col4" },
                    new string[] { "Row2Col1", "行2列2\n多行文本", "Row2Col3", "Row2Col4" },
                    new string[] { "Row3Col1", "Row3Col2", "Row3Col3", "行3列4\n多行文本\n多行文本" }
                };

                // 调用安全方法
                chatbox.AddItemTableList(
                    content: "表格测试",
                    rows: tableData,
                    totalColumnCount: 4
                );

                //============================
                var links = new List<string>
                {
                     "测试条目一",
                    "测试条目二测试条目二测试条目二",
                    "测试条目三\n测试条目三"
                };
                chatbox.AddItemInfoLink(
                    content: "测试标题",
                    title: "副标题",
                    linkItems: links
                );
                skin.Visible = true;
            }
        }

        static public IntPtr OnChatBoxEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode == CHATBOX_EVENT_CLICKLINK)
            {
                Console.WriteLine($"链接点击 {wParam}, {lParam}");
            }
            else if (nCode == CHATBOX_EVENT_CLICKBUTTON)
            {
                Console.WriteLine($"卡片按钮点击 {wParam}, {lParam}");
            }
            return IntPtr.Zero;
        }

        static public IntPtr OnChatButtonEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nID == 101)
            {
                var text = edit.Text;
                chatbox.AddItemText(text, false);
            }
            else if (nID == 102)
            {
                var text = edit.Text;
                chatbox.AddItemText(text, true);
            }
            else if (nID == 103)
            {
                chatbox.UpdateItemText(0, "更新内容", true);
            }
            else if (nID == 104)
            {
                chatbox.UpdateItemCard(3, new ExImage(Properties.Resources.user),
                    "测试卡片标题2!",
                    "测试卡片内容2测试卡片内容2",
                    "测试卡片子标题2",
                    "测试卡片子内容2测试卡片子内容2.",
                    "测试按钮2");
            }
            else if (nID == 105)
            {
                var type = chatbox.GetItemType(3);
                var dataCount = chatbox.GetItemCount();
                var str = chatbox.GetItemText(0);
                var card = chatbox.GetItemCard(3);
                Console.WriteLine($"类型{type}, 总数{dataCount}, {str}, {Marshal.PtrToStringUni(card.buttonText)}");
            }
            return IntPtr.Zero;
        }
    }
}
