using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Globalization;

namespace ExDuiRTest
{
    static class CalendarWindow
    {
        static private ExSkin skin;
        static private ExCalendar calendar;
        static private ExObjEventProcDelegate objEvent;

        static public void CreateCalendarWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试月历", 0, 0, 400, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                calendar = new ExCalendar(skin, "", 50, 50, 310, 320, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_BORDER);
                objEvent = new ExObjEventProcDelegate(OnCalendarEvent);
                calendar.HandleEvent(CALENDAR_EVENT_DATETIME, objEvent);
                skin.Visible = true;
            }
        }

        static public IntPtr OnCalendarEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == CALENDAR_EVENT_DATETIME)
            {
                var dt = Util.IntPtrToStructure<ExDateTimeInfo>(lParam);
                Console.WriteLine($"日期已更改,{dt.Year},{dt.Mon},{dt.Mday},{dt.Wday}");
            }
            return IntPtr.Zero;
        }
    }
}
