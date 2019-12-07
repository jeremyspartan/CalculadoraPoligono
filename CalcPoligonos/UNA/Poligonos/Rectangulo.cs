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

        public double Lado
        {
            get;
            set;
        }
        public double CalcularArea()
        {
            return Lado * Altura;
        }

        public double CalcularPerimetro()
        {
            return Altura * 2 + Lado * 2;
        }
    }
}