

using ai_for_games_lab_week_1;
using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;
using System.Threading;


namespace MonoGameLib.Shapes
{
    public class Circle : Shape
    {
        //public Vector2 position { get; set; } = Vector2.Zero;
        public float Radius { get; private set; }
        public int numVertices { get; private set; } = 100;
        public int thickness { get; private set; } = 2;


   
        public Circle(Vector2 position, float radius, Color pColour, ref ShapeBatcher pBatcher) : base(position, pColour, ref pBatcher)
        {
            Radius = radius;
        }
       

        public override string ToString()
        {
            return $"Circle with position {Position.ToString()}";
        }
        
        public override bool isInside(Vector2 pPosition)
        {
            return (Position - pPosition).LengthSquared() < Radius * Radius;
        }

    }
}
