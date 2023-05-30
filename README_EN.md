ExDUIR
=======
[中文](./README.md)

## Introduction

Lightweight DirectUI framework for Windows platform.ExDUIR for .net.

Original address:https://github.com/williamlzw/ExDUIR

Modified from https://github.com/F-Unction/ExDirectUI.NET

## Environment
win10+, win7 need install KB2670838 patch
.net 4.6.1

## Problem feedback & Help
* QQ group: 214406227

## Compiler
* Visual Studio 2019,Visual Studio 2022

## Characteristics
* Rendering function is DirectX11, Direct2D, efficiency is hundreds of times higher than GDI.
* Unicode encoding, support for multiple languages.
* Mimic The Windows messaging mechanism by sending messages and distributing notifications to components, compatible with native Windows messages and constants. Win32 API writing, more flexible than class writing extensibility.
* Use Win32 style API method to call, support the generation of lib static library and DLL dynamic library. The generated dynamic link library can be called by other languages such as python, Java, go, dephi, C#, VB, easy language, etc.
* Extension components are free and flexible, and the engine handles the underlying logic. The user only needs to write the drawing code and does not need to worry about complex message processing.
* Currently support component has a button, switch, radio buttons, select box, edit box, rich text edit box, listview, report listview, template listview, group boxes, combo boxes, menus, tree frame, the slider, radio buttons, select box, TAB, load, animations, rotating picture box, page, picture box, message box, list of ICONS, list button, the toolbar , status bar, date box, color palette, color picker, title box, calendar box, score button, cef3 browser box, drawing board, you can superclass extension components on these components.
* Support for layouts that automatically update component positions when window sizes change. Currently, the following layouts are supported: absolute layout, relative layout, linear layout, flow layout, and table layout. Users can extend the layout.
* Support GIF format images automatically play animation, support image format PNG, JPEG, BMP, GIF, WEBP. Windows or components can use the above format image as the background.
* Support 34 eases, users can freely write window eases or component eases. Users can extend the easing algorithm.
* Window support special-shaped window, picture shape window. Windows and components support 0 to 255 transparency. Supports Gaussian blur.
* Edit box supports rich text and supports loading documents in RTF format.
* Windows or components can receive drag files or text.
* Support for modal Windows.
* Support for restricted area message notification.

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

### modal:  
![image](demo_image/demo_modal.png)

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

### winform:  
![image](demo_image/demo_winform.png)

### cefsharp browser:  
![image](demo_image/demo_cef.png)

### login demo
![image](demo_image/demo_login.png)

### demo taggingboard:
![image](demo_image/demo_taggingboard.png)