﻿using System;

namespace Geodex.Surfaces.Loop
{
    public class Funnel : Field
    {

        #region members
        
        #endregion

        #region constructors

        public Funnel() : base()
        {

        }

        public Funnel(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = Math.Log(i);

        }

        #endregion

    }
}