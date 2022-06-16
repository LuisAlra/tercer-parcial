using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFarchivos
{
    internal class Matrices
    {
        private int m;
        private int n;
        double[,] elem;

        public Matrices(int m, int n)
        {
            this.m = m;
            this.n = n;
            elem = new double[m, n];
        }

        public int M
        {
            get { return m; }
            set { m = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public double[,] Elem
        {
            get { return elem; }
            set { elem = value; }
        }
    }
}
