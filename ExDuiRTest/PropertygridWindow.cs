using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ExDuiRTest
{
    static class PropertygridWindow
    {
        static private ExSkin skin;
        static private ExPropertyGrid propertygrid;
        static private ExButton button1;
        static private ExButton button2;
        static private ExButton button3;
        static private ExObjEventProcDelegate buttonProc;
        static private ExObjEventProcDelegate propertygridProc;
        static private ExObjEventProcDelegate propertygridProc2;

        static public void CreatePropertygridWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试属性框", 0, 0, 500, 400,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                propertygrid = new ExPropertyGrid(skin, "属性框", 50, 50, 300, 300, OBJECT_STYLE_VISIBLE | OBJECT_STYLE_VSCROLL, -1, DT_LEFT);
                propertygrid.ColorBackground = Util.ExRGB2ARGB(14737632, 255);
                buttonProc = new ExObjEventProcDelegate(OnButtonEventProc);
                propertygridProc = new ExObjEventProcDelegate(OnPropertyGridEvent);
                propertygridProc2 = new ExObjEventProcDelegate(OnPropertyGridEventBUTTONCLICK);
                propertygrid.HandleEvent(PROPERTYGRID_EVENT_ITEMVALUECHANGE, propertygridProc);
                propertygrid.HandleEvent(PROPERTYGRID_EVENT_ITEMBUTTONCLICK, propertygridProc2);
                button1 = new ExButton(skin, "取表项内容", 380, 70, 100, 30);
                button2 = new ExButton(skin, "置表项内容", 380, 120, 100, 30);
                button3 = new ExButton(skin, "修改组件大小", 380, 170, 100, 30);
                button1.HandleEvent(NM_CLICK, buttonProc);
                button2.HandleEvent(NM_CLICK, buttonProc);
                button3.HandleEvent(NM_CLICK, buttonProc);

                PropertyGrid_AddGroup(propertygrid, "属性框演示", true);

                // 添加编辑框项目到第一个分组
                PropertyGrid_AddEditItem(propertygrid, "普通编辑框", "Aa测试123", 0, 0);

                // 添加颜色选择器到第一个分组
                PropertyGrid_AddColorPickerItem(propertygrid, "颜色框演示", Util.ExRGB2ARGB(3523123, 255).ToString(), 0); // 白色

                // 添加组合框到第一个分组
                List<string> options = new List<string> { "宋体", "黑体", "微软雅黑", "Arial" };
                PropertyGrid_AddComboBoxItem(propertygrid, "组合框演示", options, 0);

                // 添加日期选择器到第一个分组
                PropertyGrid_AddDateBoxItem(propertygrid, "日期框演示", "2026-01-01", 0);

                // 添加按钮项目到第一个分组
                PropertyGrid_AddButtonItem(propertygrid, "测试按钮", "按钮1", 0);

                // 添加编辑框混合按钮项目到第一个分组
                PropertyGrid_AddEditButtonItem(propertygrid, "编辑框混合按钮1", "测试", 0, 5);

                PropertyGrid_AddEditButtonItem(propertygrid, "编辑框混合按钮2", "随意输入", 0, 6);



                // 添加第二个分组
                PropertyGrid_AddGroup(propertygrid, "编辑框Style演示", true);
                PropertyGrid_AddEditItem(propertygrid, "数字模式", "25", 1, 1);
                PropertyGrid_AddEditItem(propertygrid, "字母模式", "Aa", 1, 2);
                PropertyGrid_AddEditItem(propertygrid, "字母数字模式", "Aa123", 1, 3);
                PropertyGrid_AddEditItem(propertygrid, "只读模式", "Aa测试123", 1, 4);

                // 添加第三个分组（初始为折叠状态）
                PropertyGrid_AddGroup(propertygrid, "占位使用", false);

                // 添加项目到第三个分组（初始不可见）
                PropertyGrid_AddEditItem(propertygrid, "参数1", "默认值1", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数2", "默认值2", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数3", "默认值3", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数4", "默认值4", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数5", "默认值5", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数6", "默认值6", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数7", "默认值7", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数8", "默认值8", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数9", "默认值9", 2, 0);
                PropertyGrid_AddEditItem(propertygrid, "参数10", "默认值10", 2, 0);
                skin.Visible = true;
            }
        }

        static private void PropertyGrid_AddGroup(ExPropertyGrid propertyGrid, string title, bool expanded)
        {
            int size = Marshal.SizeOf(typeof(ExPropergridItemInfoGroup));
            var dataPtr = Marshal.AllocHGlobal(size);
            ExPropergridItemInfoSubitem subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_GROUP,
                parentIndex = -1,
                data = dataPtr
            };
            ExPropergridItemInfoGroup info = new ExPropergridItemInfoGroup
            {
                title = title,
                bExpanded = expanded
            };
            int size2 = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            Marshal.StructureToPtr<ExPropergridItemInfoGroup>(info, subitem.data, false);
            IntPtr subitemPtr = Marshal.AllocHGlobal(size2);
            Marshal.StructureToPtr(subitem, subitemPtr, false);
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            Marshal.FreeHGlobal(dataPtr);
            Marshal.FreeHGlobal(subitemPtr);
        }

        static private void PropertyGrid_AddEditItem(ExPropertyGrid propertyGrid, string title, string content, int parentIndex, int editStyle)
        {
            int size = Marshal.SizeOf(typeof(ExPropergridItemInfoEdit));
            var dataPtr = Marshal.AllocHGlobal(size);
            ExPropergridItemInfoSubitem subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_EDIT,
                parentIndex = parentIndex,
                data = dataPtr
            };
            ExPropergridItemInfoEdit info = new ExPropergridItemInfoEdit
            {
                title = title,
                content = content,
                editStyle = editStyle
            };
            int size2 = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            Marshal.StructureToPtr<ExPropergridItemInfoEdit>(info, subitem.data, false);
            IntPtr subitemPtr = Marshal.AllocHGlobal(size2);
            Marshal.StructureToPtr(subitem, subitemPtr, false);
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            Marshal.FreeHGlobal(dataPtr);
            Marshal.FreeHGlobal(subitemPtr);
        }

        static private void PropertyGrid_AddColorPickerItem(ExPropertyGrid propertyGrid, string title, string colorValue, int parentIndex)
        {
            int size = Marshal.SizeOf(typeof(ExPropergridItemInfoEdit));
            var dataPtr = Marshal.AllocHGlobal(size);
            ExPropergridItemInfoSubitem subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_COLORPICKER,
                parentIndex = parentIndex,
                data = dataPtr
            };
            ExPropergridItemInfoColorPicker info = new ExPropergridItemInfoColorPicker
            {
                title = title,
                content = colorValue
            };
            int size2 = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            Marshal.StructureToPtr<ExPropergridItemInfoColorPicker>(info, subitem.data, false);
            IntPtr subitemPtr = Marshal.AllocHGlobal(size2);
            Marshal.StructureToPtr(subitem, subitemPtr, false);
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            Marshal.FreeHGlobal(dataPtr);
            Marshal.FreeHGlobal(subitemPtr);
        }

        static private void PropertyGrid_AddDateBoxItem(ExPropertyGrid propertyGrid, string title, string dateValue, int parentIndex)
        {
            int size = Marshal.SizeOf(typeof(ExPropergridItemInfoEdit));
            var dataPtr = Marshal.AllocHGlobal(size);
            ExPropergridItemInfoSubitem subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_DATEBOX,
                parentIndex = parentIndex,
                data = dataPtr
            };
            ExPropergridItemInfoDateBox info = new ExPropergridItemInfoDateBox
            {
                title = title,
                content = dateValue
            };
            int size2 = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            Marshal.StructureToPtr<ExPropergridItemInfoDateBox>(info, subitem.data, false);
            IntPtr subitemPtr = Marshal.AllocHGlobal(size2);
            Marshal.StructureToPtr(subitem, subitemPtr, false);
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            Marshal.FreeHGlobal(dataPtr);
            Marshal.FreeHGlobal(subitemPtr);
        }

        static private void PropertyGrid_AddButtonItem(ExPropertyGrid propertyGrid, string title, string buttonText, int parentIndex)
        {
            int size = Marshal.SizeOf(typeof(ExPropergridItemInfoEdit));
            var dataPtr = Marshal.AllocHGlobal(size);
            ExPropergridItemInfoSubitem subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_BUTTON,
                parentIndex = parentIndex,
                data = dataPtr
            };
            ExPropergridItemInfoButton info = new ExPropergridItemInfoButton
            {
                title = title,
                content = buttonText
            };
            int size2 = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            Marshal.StructureToPtr<ExPropergridItemInfoButton>(info, subitem.data, false);
            IntPtr subitemPtr = Marshal.AllocHGlobal(size2);
            Marshal.StructureToPtr(subitem, subitemPtr, false);
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            Marshal.FreeHGlobal(dataPtr);
            Marshal.FreeHGlobal(subitemPtr);
        }

        static private void PropertyGrid_AddEditButtonItem(ExPropertyGrid propertyGrid, string title, string buttonText, int parentIndex, int type)
        {
            int size = Marshal.SizeOf(typeof(ExPropergridItemInfoEdit));
            var dataPtr = Marshal.AllocHGlobal(size);
            ExPropergridItemInfoSubitem subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_EDIT | PROPERTYGRID_ITEMTYPE_BUTTON,
                parentIndex = parentIndex,
                data = dataPtr
            };
            ExPropergridItemInfoEdit info = new ExPropergridItemInfoEdit
            {
                title = title,
                content = buttonText,
                editStyle = type
            };
            int size2 = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            Marshal.StructureToPtr<ExPropergridItemInfoEdit>(info, subitem.data, false);
            IntPtr subitemPtr = Marshal.AllocHGlobal(size2);
            Marshal.StructureToPtr(subitem, subitemPtr, false);
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            Marshal.FreeHGlobal(dataPtr);
            Marshal.FreeHGlobal(subitemPtr);
        }

        static private void PropertyGrid_AddComboBoxItem(ExPropertyGrid propertyGrid, string title, List<string> options, int parentIndex)
        {
            // 分配组合框选项列表的内存
            int unitSize = Marshal.SizeOf(typeof(ExPropergridItemInfoComboboxUnit));
            IntPtr listInfoPtr = Marshal.AllocHGlobal(unitSize * options.Count);

            // 填充组合框选项列表
            for (int i = 0; i < options.Count; i++)
            {
                var unit = new ExPropergridItemInfoComboboxUnit
                {
                    text = options[i]
                };
                IntPtr unitPtr = listInfoPtr + i * unitSize;
                Marshal.StructureToPtr(unit, unitPtr, false);
            }

            // 创建组合框数据
            var comboData = new ExPropergridItemInfoCombobox
            {
                title = title,
                listCount = options.Count,
                listInfo = listInfoPtr
            };

            // 分配组合框数据的内存
            int comboDataSize = Marshal.SizeOf(typeof(ExPropergridItemInfoCombobox));
            IntPtr comboDataPtr = Marshal.AllocHGlobal(comboDataSize);
            Marshal.StructureToPtr(comboData, comboDataPtr, false);

            // 创建子项
            var subitem = new ExPropergridItemInfoSubitem
            {
                type = PROPERTYGRID_ITEMTYPE_COMBOBOX,
                parentIndex = parentIndex,
                data = comboDataPtr
            };

            // 分配子项内存并发送消息
            int subitemSize = Marshal.SizeOf(typeof(ExPropergridItemInfoSubitem));
            IntPtr subitemPtr = Marshal.AllocHGlobal(subitemSize);
            Marshal.StructureToPtr(subitem, subitemPtr, false);

            
            propertyGrid.SendMessage(PROPERTYGRID_MESSAGE_ADDITEM, IntPtr.Zero, subitemPtr);
            
            
            // 清理内存
            Marshal.FreeHGlobal(listInfoPtr);
            Marshal.FreeHGlobal(comboDataPtr);
            Marshal.FreeHGlobal(subitemPtr);
            
        }

        static public IntPtr OnPropertyGridEvent(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            var itemInfo = Util.IntPtrToStructure<ExPropergridChangeItemInfo>(lParam);
            Console.WriteLine($"属性框值改变,对应行索引:{wParam},改变后值:{itemInfo.text},改变类型:{itemInfo.type}");
            return IntPtr.Zero;
        }

        static public IntPtr OnPropertyGridEventBUTTONCLICK(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            var itemInfo = Util.IntPtrToStructure<ExPropergridChangeItemInfo>(lParam);
            Console.WriteLine($"按钮被点击,对应行索引:{wParam},改变后值:{itemInfo.text},改变类型:{itemInfo.type}");
            return IntPtr.Zero;
        }

        static public IntPtr OnButtonEventProc(int hObj, int nID, int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode == NM_CLICK)
            {
                if(hObj == button1.handle)
                {
                    var ret = propertygrid.GetItemValue("名称2");
                    Console.WriteLine($"名称2 对应值{ret}");
                }
                else if (hObj == button2.handle)
                {
                    propertygrid.SetItemValue("名称2","新数值123");
                }
                else if (hObj == button3.handle)
                {
                    propertygrid.Move(20, 30, 350, 360);
                }
            }
            return IntPtr.Zero;
        }
    }
}
