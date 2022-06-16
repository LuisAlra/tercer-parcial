using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHerencia
{
    internal class MatA
    {
        protected int ma, na;
        protected double[,] a;

        public MatA(int ma, int na)
        {
            this.ma = ma;
            this.na = na;
            a = new double[ma,na];
        }

        public void LeeA()
        {
            Console.WriteLine("Ingrese los valores para la matriz A");
            for(int i = 0; i < ma; i++)
            {
                for(int j = 0; j < na; j++)
                {
                    Console.Write("Ingresa el valor para el elemento A"+"["+i+"]["+j+"]: ");
                    a[i,j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public void PonA()
        {
            Console.WriteLine("Matriz A ingresada: ");
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
