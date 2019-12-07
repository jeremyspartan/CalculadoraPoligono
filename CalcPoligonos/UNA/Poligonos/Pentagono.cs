using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : ICalculable
    {
        public double Lado
        {
            get;
            set;
        }

        public double Apotema
        {
            get;
            set;
        }

        public double CalcularArea()
        {
            return (Apotema * CalcularPerimetro()) / 2;
        }

        public double CalcularPerimetro()
        {
            return Lado * 5;

        }
    }
}