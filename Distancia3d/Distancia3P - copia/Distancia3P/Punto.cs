using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia3P
{
    class Punto
    {
        protected decimal x;

        public decimal X {
            get { return x; }
            set { x= value; } }

        public Punto(){
            x = 0;
          
}
        public Punto(decimal x)
        {
            this.X = x;
        }
          
        public decimal Calcular_Distancia(Punto a)
        {
            return Math.Abs(x - a.X);
            
        }

        public override string ToString()
        {
            return x + " ";
        }
    }
} 
