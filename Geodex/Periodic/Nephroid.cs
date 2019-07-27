﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex.Curves.Periodic
{
    public class Nephroid : Curve
    {

        public Nephroid() : base()
        {

        }

        public Nephroid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = 3*Math.Cos(s)-Math.Cos(3*s);
            p.Y = 3 * Math.Sin(s) - Math.Sin(3 * s);
        }
    }
}