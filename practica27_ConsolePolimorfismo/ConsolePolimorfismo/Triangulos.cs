using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolimorfismo
{
    internal class Triangulos : Rectangulos
    {
        double bt, ht, ct, dt;

        public Triangulos(double ar, double br, double bt, double ht, double ct, double dt) : base(ar, br)
        {
            this.bt = bt;
            this.ht = ht;
            this.ct = ct;
            this.dt = dt;
        }

        public override double Area()
        {
            double area;
            area = (bt * ht) / 2;
            return (area);
        }

        public double PeriTri()
        {
            double peri;
            peri = bt + dt + ct;
            return (peri);
        }
    }
}
