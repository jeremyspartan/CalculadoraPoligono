using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Triangulo : ICalculable
    {

        public double Base
        {
            get;
            set;
        }

        public double Altura
        {
            get;
            set;
        }

        public double Lado1
        {
            get;
            set;
        }

        public double Lado2
        {
            get;
            set;
        }

        public double Lado3
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
            return Lado1 + Lado2 + Lado3;
        }
    }
}