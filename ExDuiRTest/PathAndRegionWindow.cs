using ExDuiR.NET.Frameworks.Controls;
using ExDuiR.NET.Frameworks;
using ExDuiR.NET.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExDuiR.NET.Native.ExConst;
using ExDuiR.NET.Frameworks.Utility;
using ExDuiR.NET.Frameworks.Graphics;
using System.Runtime.InteropServices;

namespace ExDuiRTest
{
    static class PathAndRegionWindow
    {
        static private ExSkin skin;
        static private ExStatic obj;
        static private ExObjProcDelegate objProc;

        static public void CreatePathAndRegionWindow(ExSkin pOwner)
        {
            skin = new ExSkin(pOwner, null, "测试路径与区域", 0, 0, 400, 250,
            WINDOW_STYLE_NOINHERITBKG | WINDOW_STYLE_BUTTON_CLOSE | WINDOW_STYLE_BUTTON_MIN | WINDOW_STYLE_MOVEABLE |
            WINDOW_STYLE_CENTERWINDOW | WINDOW_STYLE_TITLE | WINDOW_STYLE_HASICON | WINDOW_STYLE_NOSHADOW);
            if (skin.Validate)
            {
                skin.BackgroundColor = Util.ExRGBA(150, 150, 150, 255);
                objProc = new ExObjProcDelegate(OnPathAndRgnMsgProc);
                obj = new ExStatic(skin, "", 50, 50, 300, 200, -1, OBJECT_STYLE_EX_FOCUSABLE, -1, 0, IntPtr.Zero, objProc);
                skin.Visible = true;
            }
        }

        static public IntPtr OnPathAndRgnMsgProc(IntPtr hWnd, int hObj, int uMsg, IntPtr wParam, IntPtr lParam, IntPtr pResult)
        {
            var obj = new ExStatic(hObj);
            if (uMsg == WM_CREATE)
            {
                obj.InitPropList(4);

                var path = new ExPath();
                path.Open();
                path.BeginFigue(70, 155, PATH_BEGIN_FLAG_FILLED);
                path.AddArc3(240, 155, 85, 85, 0, 0, true, false);
                path.EndFigure(true);

                path.BeginFigue(99, 82, PATH_BEGIN_FLAG_HOLLOW);
                path.AddBezier(99, 82, 94, 76, 85, 78);
                path.AddBezier(76, 79, 72, 73, 72, 73);
                path.EndFigure(false);

                path.BeginFigue(154, 56, PATH_BEGIN_FLAG_HOLLOW);
                path.AddBezier(154, 56, 158, 49, 154, 42);
                path.AddBezier(149, 34, 154, 27, 154, 27);
                path.EndFigure(false);

                path.BeginFigue(122, 64, PATH_BEGIN_FLAG_HOLLOW);
                path.AddBezier(122, 64, 122, 56, 114, 52);
                path.AddBezier(106, 49, 105, 41, 105, 41);
                path.EndFigure(false);

                path.BeginFigue(185, 64, PATH_BEGIN_FLAG_HOLLOW);
                path.AddBezier(185, 64, 192, 61, 194, 52);
                path.AddBezier(195, 44, 202, 41, 202, 42);
                path.EndFigure(false);

                path.BeginFigue(208, 82, PATH_BEGIN_FLAG_HOLLOW);
                path.AddBezier(208, 82, 216, 84, 222, 78);
                path.AddBezier(228, 71, 235, 73, 235, 73);
                path.EndFigure(false);

                path.Close();
                var rgn = new ExRegion(path);
                obj.SetProp((IntPtr)2, (IntPtr)path.handle);
                obj.SetProp((IntPtr)3, rgn.handle);
            }
            else if (uMsg == WM_PAINT)
            {
                obj.BeginPaint(out var ps);
                var canvas = new ExCanvas(ps.hCanvas);

                var x = (int)obj.GetProp((IntPtr)0);
                var y = (int)obj.GetProp((IntPtr)1);
                var path = new ExPath((int)obj.GetProp((IntPtr)2));
                var path2 = new ExPath();
                path2.Open();
                path2.BeginFigue(x - 25, y - 25, PATH_BEGIN_FLAG_FILLED);
                path2.AddRect(x - 25, y - 25, x - 25 + 50, y - 25 + 50);
                path2.EndFigure(true);
                path2.Close();

                var rgn1 = new ExRegion(obj.GetProp((IntPtr)3));
                var rgn2 = new ExRegion(path2);
                var brush = new ExBrush(Util.ExRGBA(255, 0, 0, 255));
                var brushRgn = new ExBrush(Util.ExRGBA(255, 255, 0, 255));

                canvas.DrawPath(path, brush, 1, 1);
                int relation = -1;
                if (rgn1.HitTest2(rgn2, ref relation))
                {
                    if (relation == 3)
                    {
                        brushRgn.Color = Util.ExRGBA(0, 255, 0, 255);
                    }
                    else if (relation == 4)
                    {
                        brushRgn.Color = Util.ExRGBA(0, 0, 255, 255);
                        var rgn3 = rgn1.Combine(rgn2, REGION_COMBINE_EXCLUDE, 0, 0);
                        canvas.FillRegion(rgn3, brushRgn);
                        List<ExPointF> points = new List<ExPointF>();
                        int pointsCount = 0;
                        rgn2.GetLines(ref points, ref pointsCount);
                        for (int i = 0; i < pointsCount; i++)
                        {
                            if (i != 0)
                            {
                                canvas.DrawLine(brushRgn, points[i].x, points[i].y, points[i - 1].x, points[i - 1].y, 1, 0);
                            }
                        }
                    }
                    else
                    {
                        brushRgn.Color = Util.ExRGBA(255, 255, 0, 255);
                    }
                }
                canvas.DrawPath(path2, brushRgn, 1, 1);
                obj.EndPaint(ref ps);
            }
            else if (uMsg == WM_MOUSEMOVE)
            {
                var x = Util.GET_X_LPARAM(lParam);
                var y = Util.GET_Y_LPARAM(lParam);
                obj.SetProp((IntPtr)0, (IntPtr)x);
                obj.SetProp((IntPtr)1, (IntPtr)y);
                obj.Invalidate();
            }
            else if (uMsg == WM_DESTROY)
            {
                var path = new ExPath((int)obj.GetProp((IntPtr)2));
                var rgn1 = new ExRegion(obj.GetProp((IntPtr)3));
                path.Dispose();
                rgn1.Dispose();
            }
            return IntPtr.Zero;
        }
    }
}
