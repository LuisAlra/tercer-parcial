using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolimorfismo
{
    internal class Circulos : Triangulos
    {
        double rc;

        public Circulos(double ar, double br, double bt, double ht, double ct, double dt, double rc) : base(ar, br, bt, ht, ct, dt)
        {
            this.rc = rc;
        }

        public override double Area()
        {
            double area;
            area = Math.PI * Math.Pow(rc, 2);
            return (area);
        }

        public double PeriCir()
        {
            double peri;
            peri = 2 * Math.PI * rc;
            return (peri);
        }
    }
}
