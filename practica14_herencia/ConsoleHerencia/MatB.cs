using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHerencia
{
    internal class MatB:MatA
    {
        protected int mb, nb;
        protected double[,] b;

        public MatB(int ma, int na, int mb, int nb):base(ma, na)
        {
            this.mb = mb;
            this.nb = nb;
            b = new double[mb,nb];    
        }

        public void LeeB()
        {
            Console.WriteLine("Ingrese los valores para la matriz B");
            for (int i = 0; i < mb; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    Console.Write("Ingresa el valor para el elemento B" + "[" + i + "][" + j + "]: ");
                    b[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public void PonB()
        {
            Console.WriteLine("Matriz B ingresada: ");
            for (int i = 0; i < mb; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
