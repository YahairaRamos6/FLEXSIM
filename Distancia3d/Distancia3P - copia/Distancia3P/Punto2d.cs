using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia3P
{
    class Punto2d : Punto
    {
        protected decimal y;

        public decimal Y
        {
            get { return y; }
            set { y = value; }
        }

        public Punto2d() : base()
        {
            y = 0;
        }
        public Punto2d(decimal x, decimal y) : base(x)
        {
            this.y = y;
        }

        public decimal Calcular_Distancia(Punto2d a)
        {
            return (decimal)(Math.Sqrt(Math.Pow((double)(x - a.X), 2) + Math.Pow((double)(y - a.Y), 2)));

        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}

