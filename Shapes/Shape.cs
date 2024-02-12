
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib
{   

    public abstract class Shape
    {
        
        public Vector2 Position { get; protected set; }
        public Vector2 Velocity { get; protected set; }
        //public ShapeBatcher Batcher { get; protected set; }
        public Color Colour { get; protected set; }
        

        public Shape(Vector2 pPosition, Color pColour)
        {
            Position = pPosition;
            Colour = pColour;
            
            

        }
        public abstract bool isInside(Vector2 pPosition);

        public void changeColour(Color c)
        {
            Colour = c;
        }
        public override string ToString()
        {
            return $"Shape with position {Position.ToString()}";
        }
        public void changePosition(Vector2 pPos)
        {
            Position = pPos;
        }

        public void changeVelocity(Vector2 v)
        {
            Velocity = v;
        }

        private float LengthBetween(Vector2 pTarget)
        {
            Vector2 delV = Position - pTarget;
            float len = delV.Length();

            return len;
        }
        public virtual void Draw(ShapeBatcher Batcher)
        {
            Batcher.Draw(this);
        }
    
    }

    
}
