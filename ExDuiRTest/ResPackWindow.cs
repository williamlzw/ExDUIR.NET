using ExDuiR.NET.Frameworks.Graphics;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using static ExDuiR.NET.Native.ExConst;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class ResPackWindow
    {
        static private ExSkin skin;

        static public void CreateResPackWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试打包", 0, 0, 300, 200,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExARGB(150, 150, 150, 255);
                //打包主题包
                ExAPI._res_pack("Default", "res/test_theme.ext", (char)PACKAGEHEADER_THEME);

                //打包素材包
                ExAPI._res_pack("Default", "res/test_res.exr", (char)PACKAGEHEADER_FILES);
                var res = new ExResource("res/test_res.exr");
                IntPtr dataPtr;
                IntPtr dataLen;
                res.GetFile("messagebox.png", out dataPtr, out dataLen);

                var img = new ExImage(res, ExAPI.Ex_Atom("messagebox.png"));
                img.SaveToFile("res/read_from_res1.png");
                img.Dispose();

                byte[] byteData = new Byte[(int)dataLen];
                Marshal.Copy(dataPtr, byteData, 0, (int)dataLen);
                File.WriteAllBytes("res/read_from_res2.png", byteData);
                res.Dispose();
                skin.Visible = true;
            }
        }
    }
}
