using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia3P
{
    class Punto3d:Punto2d
    {
        protected decimal z;

        public decimal Z
        {
            get { return z; }
            set { z = value; }
        }

        public Punto3d() : base()
        {
            z = 0;
        }
        public Punto3d(decimal x, decimal y, decimal z) : base(x,y)
        {
            this.z = z;
        }

        public decimal Calcular_Distancia(Punto3d a)
        {
            return (decimal)(Math.Sqrt(Math.Pow((double)(x - a.X), 2) + Math.Pow((double)(y - a.Y), 2)+ Math.Pow((double)(z-a.Z),2)));

        }

        public override string ToString()
        {
            return x + " " + y + " " + z;
        }
    }
}
