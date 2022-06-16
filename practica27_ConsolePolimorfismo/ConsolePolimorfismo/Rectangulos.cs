using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolimorfismo
{
    internal class Rectangulos : FigGeo
    {
        protected double ar, br;

        public Rectangulos(double ar, double br) : base()
        {
            this.ar = ar;
            this.br = br;
        }

        public override double Area()
        {
            double area;
            area = ar * br;
            return (area);
        }

        public double PeriRec()
        {
            double peri;
            peri = 2 * ar + 2 * br;
            return (peri);
        }
    }
}
