﻿using System;

namespace Geodex.Curves.Fixed
{
    public class Talbot : Curve
    {

        #region members

        public double A = 1;
        public double B = 2;

        #endregion

        #region constructors

        public Talbot() : base()
        {

        }

        public Talbot(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
            
            p.X = (Math.Pow(A, 2) + Math.Pow(B, 2) * Math.Pow(Math.Sin(s), 2)) * Math.Cos(s) / A;
            p.Y = (Math.Pow(A, 2) - Math.Pow(2*B, 2) + Math.Pow(B, 2) * Math.Pow(Math.Sin(s), 2)) * Math.Cos(s) / B;

        }

        #endregion

    }
}
