using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : ICalculable
    {
        public double Altura
        {
            get;
            set;
        }

        public double Base
        {
            get;
            set;
        }
        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return Altura * 2 + Base * 2;
        }
    }
}