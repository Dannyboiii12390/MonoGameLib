using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGameLib;
using Microsoft.Xna.Framework.Graphics;
using Color = Microsoft.Xna.Framework.Color;
using ImGuiNET;

namespace MonoGameLib
{
    internal static class ShapebatcherHelpers
    {

        public static void Draw(this ShapeBatcher shapeBatcher, Shape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    shapeBatcher.HelperDraw(shape as Circle);
                    break;
                
                case Triangle triangle:
                    shapeBatcher.HelperDrawTriangle(shape as Triangle);
                    break;

                case Line line:
                    shapeBatcher.HelperDrawLine(shape as Line);
                    break;
                case Polygon polygon:
                    shapeBatcher.HelperDrawPolygon(shape as Polygon);
                    break;



                default:
                    break;
            }
        }

        private static void HelperDraw(this ShapeBatcher shapeBatcher, Circle circle)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawCircle(circle.Position, circle.Radius, circle.numVertices, circle.thickness, circle.Colour);
            shapeBatcher.End();
        }

        public static void HelperDrawArrow(this ShapeBatcher shapeBatcher, Circle circle)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawArrow(circle.Position, circle.Velocity, 2, 10, circle.Colour);
            shapeBatcher.End();
        }

        private static void HelperDrawLine(this ShapeBatcher shapeBatcher, Line line)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawLine(line.Position, line.end, line.thickness, line.Colour);
            shapeBatcher.End();
        }
        private static void HelperDrawTriangle(this ShapeBatcher shapeBatcher, Triangle triangle)
        {
            shapeBatcher.Begin();
            shapeBatcher.DrawTriangle(triangle.Position, triangle.Position2, triangle.Position3, triangle.Colour);
            shapeBatcher.DrawTriangle(triangle.Position2, triangle.Position3, triangle.Position, triangle.Colour);
            shapeBatcher.DrawTriangle(triangle.Position, triangle.Position3, triangle.Position3, triangle.Colour);
            shapeBatcher.End();

        }

        private static void HelperDrawPolygon(this ShapeBatcher shapeBatcher, Polygon polygon)
        {
            shapeBatcher.Begin();
            foreach(Triangle triangle in polygon.triangles)
            {
                
                shapeBatcher.DrawLine(triangle.Position, triangle.Position2, 2, polygon.Colour);
                shapeBatcher.DrawLine(triangle.Position2, triangle.Position3, 2, polygon.Colour);
                shapeBatcher.DrawLine(triangle.Position3, triangle.Position, 2, polygon.Colour);
                
            }
            shapeBatcher.End();
        }
    }
            
}
