using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib
{
    public class Bullet : Shape
    {
        public Circle hitbox { get; private set; }
        public float Damage { get; private set; }


        public Bullet(Vector2 pPosition,float pDamage, Vector2 pTarget ,Color pColour) : base(pPosition, pColour)
        {
            hitbox = new Circle(pPosition, 5, pColour);
            Damage = pDamage;

        }

        public override bool isInside(Vector2 pPosition)
        {
            return hitbox.isInside(pPosition);
        }

    }
}
