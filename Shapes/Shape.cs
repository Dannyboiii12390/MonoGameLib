using ai_for_games_lab_week_1;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib.Shapes
{   

    public abstract class Shape
    {
        
        public Vector2 Position { get; protected set; }
        public Vector2 Velocity { get; protected set; }
        public ref ShapeBatcher Batcher => ref Batcher;
        public Color Colour { get; protected set; }
        

        public Shape(Vector2 pPosition, Color pColour, ref ShapeBatcher pBatcher)
        {
            Position = pPosition;
            Colour = pColour;
            Batcher = pBatcher;
            

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
        public virtual void Draw()
        {
            Batcher.Draw(this);
        }
    
    }

    
}
