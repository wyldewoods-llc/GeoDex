﻿using System;

namespace Geodex.Curves.Periodic
{
    public class CayleysSextic : Curve
    {

        public CayleysSextic() : base()
        {

        }

        public CayleysSextic(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI*3;

            double i = Math.Pow(Math.Cos(s / 3), 3)

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
