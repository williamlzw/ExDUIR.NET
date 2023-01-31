ExDUIR
=======
[English](./README_EN.md)

## 简介

Windows平台轻量DirectUI框架。ExDUIR的.net框架封装。原版地址:https://github.com/williamlzw/ExDUIR
修改自https://github.com/F-Unction/ExDirectUI.NET

## 运行系统
win10+， win7 需要安装KB2670838补丁
.net 4.6.1

## 问题反馈&帮助
* 交流QQ群: 214406227

## 编译
* Visual Studio 2019,Visual Studio 2022

## 特点
* 绘制函数是DirectX11、Direct2D，效率比GDI高上百倍。
* Unicode编码，支持多国语言。
* 仿Windows消息机制，通过发送消息，分发通知给组件，兼容原生Windows消息和常量。win32 api写法，比类写法扩展性更灵活。
* 调用方式采用Win32风格API方式，支持生成lib静态库和dll动态库。生成的动态链接库支持被其它语言如python、java、go、dephi、C#、VB、易语言等调用。
* 扩展组件自由灵活，引擎处理底层逻辑。用户只需编写绘制代码，不需要考虑复杂的消息处理。
* 目前支持组件有按钮、开关、单选框、选择框、编辑框、富文本编辑框、列表框、报表列表、模板列表、分组框、组合框、菜单、树形框、滑块、单选框、选择框、选项卡、加载动画框、旋转图片框、页面、图片框、消息框、图标列表、列表按钮、工具条、状态条、日期框、调色板、颜色选择器、标题框、月历框、分数按钮、cef3浏览框、鼠标绘制板，可以在这些组件基础上超类化扩展组件。
* 支持布局，布局可以在窗口尺寸改变情况下自动更新组件位置。目前支持的布局有绝对布局，相对布局、线性布局、流式布局、表格布局。用户可以扩展布局。
* 支持GIF格式图片自动播放动画，支持图片格式PNG、JPEG、BMP、GIF、WEBP。窗口或组件都可以用以上格式图片做背景图。
* 支持34种缓动特效，用户可以自由编写窗口缓动或组件缓动特效。用户可以扩展缓动算法。
* 窗口支持异型窗口，图片形状窗口。窗口和组件支持0到255透明度。支持高斯模糊。
* 编辑框支持富文本，支持加载RTF格式文档。
* 窗口或组件支持接收拖曳文件或文本。
* 支持模态窗口。
* 支持限制区域消息通知。

## Demo
### demo code:  
![image](demo_image/demo_code.png)

### demo all:  
![image](demo_image/demo_all.png)

### button:  
![image](demo_image/demo_button.png)

### combobox:  
![image](demo_image/demo_combobox.png)

### custombackground:  
![image](demo_image/demo_custombackground.png)

### easing:  
![image](demo_image/demo_easing.png)

### edit:  
![image](demo_image/demo_edit.png)

### groupbox:  
![image](demo_image/demo_groupbox.png)

### irregular shape window:  
![image](demo_image/demo_irregular_shape_window.png)

### label:  
![image](demo_image/demo_label.png)

### layout absolute:  
![image](demo_image/demo_layout_absolute.png)

### layout flow:  
![image](demo_image/demo_layout_flow.png)

### layout linear:  
![image](demo_image/demo_layout_linear.png)

### layout relative:  
![image](demo_image/demo_layout_relative.png)

### layout table:  
![image](demo_image/demo_layout_table.png)

### listbutton:  
![image](demo_image/demo_listbutton.png)

### listview:  
![image](demo_image/demo_listview.png)

### navbutton:  
![image](demo_image/demo_navbutton.png)

### radio and checkbox:  
![image](demo_image/demo_radio_checkbox.png)

### reportlistview:  
![image](demo_image/demo_reportlistview.png)

### iconlistview:  
![image](demo_image/demo_iconlistview.png)

### treeview:  
![image](demo_image/demo_treeview.png)

### matrix:  
![image](demo_image/demo_matrix.png)

### buttonex:  
![image](demo_image/demo_buttonex.png)

### editex:  
![image](demo_image/demo_editex.png)

### custommenu:  
![image](demo_image/demo_custommenu.png)

### eventdispatch:  
![image](demo_image/demo_eventdispatch.png)

### loading:  
![image](demo_image/demo_loading.png)

### sliderbar:  
![image](demo_image/demo_sliderbar.png)

### rotatebox:  
![image](demo_image/demo_rotatebox.png)

### drag obj:  
![image](demo_image/demo_dragobj.png)

### progressbar
![image](demo_image/demo_progressbar.png)

### notify obj
![image](demo_image/demo_notifyobj.png)

### titlebar
![image](demo_image/demo_titlebar.png)

### datebox
![image](demo_image/demo_datebox.png)

### colorpicker
![image](demo_image/demo_colorpicker.png)

### scorebutton
![image](demo_image/demo_scorebutton.png)

### carousel
![image](demo_image/demo_carousel.png)

### template listview
![image](demo_image/demo_template_listview.png)

### drawingboard
![image](demo_image/demo_drawingboard.png)

### propertygrid
![image](demo_image/demo_propertygrid.png)

### mediaplayer
![image](demo_image/demo_mediaplayer.png)

### svg and font
![image](demo_image/demo_svg.png)

### rollmenu
![image](demo_image/demo_rollmenu.png)

### trayicon
![image](demo_image/demo_trayicon.png)

### login demo
![image](demo_image/demo_login.png)