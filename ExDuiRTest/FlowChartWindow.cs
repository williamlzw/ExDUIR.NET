using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Native;
using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace ExDuiRTest
{
    class FlowChartWindow
    {
        static private ExSkin skin;
        static private ExFlowChart flowChart;


        static public void CreateFlowChartWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试流程图", 0, 0, 1100, 1000,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(80, 80, 90, 255);
                flowChart = new ExFlowChart(skin, "", 50, 50, 1000, 750);
                // 创建第一个节点数据项
                List<ExFlowChartNodeData> dataitems = new List<ExFlowChartNodeData>();

                // 编辑框项
                ExFlowChartNodeData dataitem0 = new ExFlowChartNodeData();
                dataitem0.type = FLOWCHART_NODEDATA_TYPE_EDIT;
                dataitem0.id = 1000;
                dataitem0.data = Marshal.StringToHGlobalUni("可编辑文本可编辑文本可编辑文本可编辑文本\n可编辑文本");
                dataitems.Add(dataitem0);

                // 图片项
                ExFlowChartNodeData dataitem1 = new ExFlowChartNodeData();
                dataitem1.type = FLOWCHART_NODEDATA_TYPE_IMAGE;
                dataitem1.id = 1001;
                // 假设ExImage类返回图片句柄的IntPtr
                dataitem1.data = (IntPtr)(new ExImage(Properties.Resources.user).handle);
                dataitems.Add(dataitem1);

                // 选项卡项
                ExFlowChartNodeData dataitem2 = new ExFlowChartNodeData();
                dataitem2.type = FLOWCHART_NODEDATA_TYPE_COMBO;
                dataitem2.id = 1002;

                // 创建并填充COMBO数据
                ExFlowChartNodeComboData comboData = new ExFlowChartNodeComboData();
                comboData.count = 2;
                comboData.current = 0;

                // 分配选项数组内存
                comboData.options = Marshal.AllocHGlobal(2 * IntPtr.Size);
                string[] options = { "选项1", "选项2" };

                // 分配并写入选项字符串
                IntPtr optionPtr0 = Marshal.StringToHGlobalUni(options[0]);
                IntPtr optionPtr1 = Marshal.StringToHGlobalUni(options[1]);
                Marshal.WriteIntPtr(comboData.options, 0 * IntPtr.Size, optionPtr0);
                Marshal.WriteIntPtr(comboData.options, 1 * IntPtr.Size, optionPtr1);

                // 分配COMBO数据结构内存
                IntPtr pComboData = Marshal.AllocHGlobal(Marshal.SizeOf(comboData));
                Marshal.StructureToPtr(comboData, pComboData, false);
                dataitem2.data = pComboData;
                dataitems.Add(dataitem2);

                // 创建第一个节点
                ExFlowChartNode node = new ExFlowChartNode();
                node.id = 1001;
                node.x = 200;
                node.y = 150;
                node.width = 200;
                node.height = 120;
                node.title = Marshal.StringToHGlobalUni("处理节点");

                // 分配节点数据列表内存
                int nodeDataSize = Marshal.SizeOf(typeof(ExFlowChartNodeData));
                node.nodeDataList = Marshal.AllocHGlobal(nodeDataSize * dataitems.Count);
                for (int i = 0; i < dataitems.Count; i++)
                {
                    IntPtr ptr = new IntPtr(node.nodeDataList.ToInt64() + i * nodeDataSize);
                    Marshal.StructureToPtr(dataitems[i], ptr, false);
                }
                node.nodeDataCount = dataitems.Count;

                // 添加输入插槽
                node.inputCount = 2;
                node.inputSlots = Marshal.AllocHGlobal(IntPtr.Size * node.inputCount);
                string[] inputSlots = { "输入A", "输入B" };
                for (int i = 0; i < node.inputCount; i++)
                {
                    IntPtr slotPtr = Marshal.StringToHGlobalUni(inputSlots[i]);
                    Marshal.WriteIntPtr(node.inputSlots, i * IntPtr.Size, slotPtr);
                }

                // 添加输出插槽
                node.outputCount = 2;
                node.outputSlots = Marshal.AllocHGlobal(IntPtr.Size * node.outputCount);
                string[] outputSlots = { "结果一", "结果二" };
                for (int i = 0; i < node.outputCount; i++)
                {
                    IntPtr slotPtr = Marshal.StringToHGlobalUni(outputSlots[i]);
                    Marshal.WriteIntPtr(node.outputSlots, i * IntPtr.Size, slotPtr);
                }

                // 添加节点
                IntPtr pNode = Marshal.AllocHGlobal(Marshal.SizeOf(node));
                Marshal.StructureToPtr(node, pNode, false);
                flowChart.SendMessage(FLOWCHART_MESSAGE_ADD_NODE, IntPtr.Zero, pNode);
                Marshal.FreeHGlobal(pNode);

                // 创建第二个节点
                List<ExFlowChartNodeData> dataitems2 = new List<ExFlowChartNodeData>();
                ExFlowChartNodeData dataitem20 = new ExFlowChartNodeData();
                dataitem20.type = FLOWCHART_NODEDATA_TYPE_EDIT;
                dataitem20.id = 2001;
                dataitem20.data = Marshal.StringToHGlobalUni("可编辑文本");
                dataitems2.Add(dataitem20);

                ExFlowChartNode node2 = new ExFlowChartNode();
                node2.id = 2000;
                node2.x = 500;
                node2.y = 150;
                node2.width = 200;
                node2.height = 120;
                node2.title = Marshal.StringToHGlobalUni("处理节点2");

                // 分配节点数据列表内存
                node2.nodeDataList = Marshal.AllocHGlobal(nodeDataSize * dataitems2.Count);
                for (int i = 0; i < dataitems2.Count; i++)
                {
                    IntPtr ptr = new IntPtr(node2.nodeDataList.ToInt64() + i * nodeDataSize);
                    Marshal.StructureToPtr(dataitems2[i], ptr, false);
                }
                node2.nodeDataCount = dataitems2.Count;

                // 添加输入插槽
                node2.inputCount = 2;
                node2.inputSlots = Marshal.AllocHGlobal(IntPtr.Size * node2.inputCount);
                for (int i = 0; i < node2.inputCount; i++)
                {
                    IntPtr slotPtr = Marshal.StringToHGlobalUni(inputSlots[i]);
                    Marshal.WriteIntPtr(node2.inputSlots, i * IntPtr.Size, slotPtr);
                }

                // 添加输出插槽
                node2.outputCount = 1;
                node2.outputSlots = Marshal.AllocHGlobal(IntPtr.Size * node2.outputCount);
                IntPtr outSlotPtr = Marshal.StringToHGlobalUni("结果");
                Marshal.WriteIntPtr(node2.outputSlots, 0, outSlotPtr);

                // 添加节点
                IntPtr pNode2 = Marshal.AllocHGlobal(Marshal.SizeOf(node2));
                Marshal.StructureToPtr(node2, pNode2, false);
                flowChart.SendMessage(FLOWCHART_MESSAGE_ADD_NODE, IntPtr.Zero, pNode2);
                Marshal.FreeHGlobal(pNode2);
                //创建连接线
                ExFlowChartConnection connect = new ExFlowChartConnection();
                connect.fromNode = 1001;  // 源节点ID
                connect.toNode = 2000;    // 目标节点ID
                connect.fromSlot = 0;     // 源插槽索引
                connect.toSlot = 0;       // 目标插槽索引
                connect.controlPoint1 = new ExPointF(200, 50);
                connect.controlPoint2 = new ExPointF(400, 50);
                IntPtr pConnect = Marshal.AllocHGlobal(Marshal.SizeOf(connect));
                Marshal.StructureToPtr(connect, pConnect, false);
                flowChart.SendMessage(FLOWCHART_MESSAGE_ADD_CONNECTION, IntPtr.Zero, pConnect);
                Marshal.FreeHGlobal(pConnect);
                //更新节点数据
                UpdateNodeData(2000, 2001);

                // 释放内存
                Marshal.FreeHGlobal(comboData.options);
                Marshal.FreeHGlobal(optionPtr0);
                Marshal.FreeHGlobal(optionPtr1);
                Marshal.FreeHGlobal(pComboData);

                Marshal.FreeHGlobal(node.nodeDataList);

                // 释放插槽内存
                for (int i = 0; i < node.inputCount; i++)
                {
                    IntPtr ptr = Marshal.ReadIntPtr(node.inputSlots, i * IntPtr.Size);
                    Marshal.FreeHGlobal(ptr);
                }
                Marshal.FreeHGlobal(node.inputSlots);

                for (int i = 0; i < node.outputCount; i++)
                {
                    IntPtr ptr = Marshal.ReadIntPtr(node.outputSlots, i * IntPtr.Size);
                    Marshal.FreeHGlobal(ptr);
                }
                Marshal.FreeHGlobal(node.outputSlots);


                Marshal.FreeHGlobal(node2.nodeDataList);

                for (int i = 0; i < node2.inputCount; i++)
                {
                    IntPtr ptr = Marshal.ReadIntPtr(node2.inputSlots, i * IntPtr.Size);
                    Marshal.FreeHGlobal(ptr);
                }
                Marshal.FreeHGlobal(node2.inputSlots);

                for (int i = 0; i < node2.outputCount; i++)
                {
                    IntPtr ptr = Marshal.ReadIntPtr(node2.outputSlots, i * IntPtr.Size);
                    Marshal.FreeHGlobal(ptr);
                }
                Marshal.FreeHGlobal(node2.outputSlots);

                // 释放标题
                Marshal.FreeHGlobal(node.title);
                Marshal.FreeHGlobal(node2.title);

                skin.Visible = true;
            }
        }

        private static void UpdateNodeData(int nodeId, int dataId)
        {
            ExFlowChartNodeData dataitem20 = new ExFlowChartNodeData();
            dataitem20.type = FLOWCHART_NODEDATA_TYPE_EDIT;
            dataitem20.id = dataId;
            dataitem20.data = Marshal.StringToHGlobalUni("更新的节点内容");

            IntPtr pData = Marshal.AllocHGlobal(Marshal.SizeOf(dataitem20));
            Marshal.StructureToPtr(dataitem20, pData, false);
            flowChart.SendMessage(FLOWCHART_MESSAGE_UPDATE_NODEDATA, (IntPtr)nodeId, pData);
            Marshal.FreeHGlobal(pData);
        }
    }
}
