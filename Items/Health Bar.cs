﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib
{
    

    public class HealthBar
    {
        public Vector2 Position {  get; private set; }
        public Vector2 End {  get; private set; }
        public Line bar { get; private set; } 
        private Vector2 FullEnd;
        private Color colour;
        

        public HealthBar(Vector2 pPosition, Vector2 pEnd, Color pColour, ref ShapeBatcher pBatcher, int pThickness = 10)
        {
            this.Position = pPosition;
            this.End = pEnd;
            this.FullEnd = pEnd;
            this.colour = pColour;
            this.bar = new Line(pPosition, pEnd, pColour, pThickness);

        }

        public void update(float health)
        {
            End = new Vector2(FullEnd.X * health, FullEnd.Y);

            bar = new Line(Position, End, colour, bar.thickness);
        }
    }
}
