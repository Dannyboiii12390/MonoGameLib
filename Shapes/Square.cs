using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace MonoGameLib.Shapes
{
    public class Square : Shape
    {
        private Polygon shape;
         

        public Square(Vector2 pPosition, int pWidth, int pHeight, Color pColour) : base(pPosition, pColour)
        {


            shape = new Polygon(base.Position, GetVertices(base.Position, pWidth, pHeight), base.Colour);

        }

        public override bool isInside(Vector2 pPosition)
        {
            throw new NotImplementedException();
        }

        public override void Draw(ShapeBatcher pBatcher)
        {
            shape.Draw(pBatcher);
        }
        

        private List<Vector2> GetVertices(Vector2 pPosition, int pWidth, int pHeight)
        {

            pWidth = pWidth / 2;
            pHeight = pHeight / 2;

            Vector2 p1 = new Vector2(pPosition.X - pWidth, pPosition.Y + pHeight);
            Vector2 p2 = new Vector2(pPosition.X + pWidth, pPosition.Y + pHeight);
            Vector2 p3 = new Vector2(pPosition.X - pWidth, pPosition.Y - pHeight);
            Vector2 p4 = new Vector2(pPosition.X + pWidth, pPosition.Y - pHeight);

            List<Vector2> Vertices = new List<Vector2>();
            Vertices.Add(p1);
            Vertices.Add(p2);
            Vertices.Add(p3);
            Vertices.Add(p4);

            return Vertices;


        }



    }
}
