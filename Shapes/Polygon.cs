using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using ai_for_games_lab_week_1;

namespace MonoGameLib.Shapes
{
    public class Polygon : Shape
    {
        public  List<Triangle> triangles { get; private set; } = new List<Triangle>();


        public Polygon(Vector2 pPosition, List<Vector2> point,Color pColour, ref ShapeBatcher pBatcher) : base(pPosition, pColour, ref pBatcher)
        {
            for (int i =2; i < point.Count; i++)
            {
                triangles.Add(new Triangle(point[i - 2], point[i-1], point[i], pColour, ref pBatcher));
            }
        }

        public override bool isInside(Vector2 pPosition)
        {
            for(int i = 0; i < triangles.Count; i++)
            {
                if (triangles[i].isInside(pPosition)) return true;
            }
            return false;

        }

    }
}
