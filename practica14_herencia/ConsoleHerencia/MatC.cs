using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHerencia
{
    internal class MatC:MatB
    {
        int mc, nc;
        double[,] c;

        public MatC(int ma, int na, int mb, int nb, int mc, int nc) : base(ma, na, mb, nb)
        {
            this.mc = mc;
            this.nc = nc;
            c = new double[mc, nc];
        }

        public void Suma()
        {
            LeeA();
            LeeB();
            PonA();
            PonB();
            for (int i = 0; i < mc; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    c[i, j] = a[i,j]+b[i,j];
                }
            }
        }

        public void PonC()
        {
            Console.WriteLine();
            Console.WriteLine("Matriz C: Suma de la matriz A y B");
            for (int i = 0; i < mc; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
