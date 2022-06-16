using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHerencia
{
    internal class Program
    {
        static int ma, na, mb, nb, mc, nc;

        static void Main(string[] args)
        {
            Console.WriteLine("SUMA DE DOS MATRICES");
            Console.WriteLine("Ambas matrices deben ser cuadradas y de  misma dimensión");
            Console.WriteLine("");

            Console.Write("Ingresa las filas y columnas de la matriz A y B para poder sumarlas: ");
            ma = mb = mc = na = nb = nc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            MatC Oc = new MatC(ma, na, mb, nb, mc, nc);
            Oc.Suma();
            Oc.PonC();

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            Console.ReadKey();
        }
    }
}
