
using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;
using System.Threading;


namespace MonoGameLib
{
    public class Circle : Shape
    {
        //public Vector2 position { get; set; } = Vector2.Zero;
        public float Radius { get; private set; }
        public int numVertices { get; private set; } = 100;
        public int thickness { get; private set; } = 2;


   
        public Circle(Vector2 position, float radius, Color pColour) : base(position, pColour)
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
