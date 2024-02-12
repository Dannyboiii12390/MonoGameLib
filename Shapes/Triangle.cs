
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib
{
    public class Triangle : Shape
    {
        public Vector2 Position2 { get; private set; }
        public Vector2 Position3 { get; private set; }

        public Triangle(Vector2 pPosition, Vector2 p2, Vector2 p3, Color pColour) : base(pPosition, pColour)
        {
            Position2 = p2;
            Position3 = p3;

        }

        public override bool isInside(Vector2 point)
        {
            float Px = point.X - Position.X,
            Py = point.Y - Position.Y,
            V1x = Position2.X - Position.X,
            V1y = Position2.Y - Position.Y,
            V2x = Position3.X - Position.X,
            V2y = Position3.Y - Position.Y;

            float n = (Py * V1x - Px * V1y) / (V2y * V1x - V2x * V1y);
            float m = (Px - n * V2x) / V1x;

            return m >= 0 && m <= 1 && n >= 0 && n <= 1 && m + n <= 1;
        }
 
    }
}
