using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolimorfismo
{
    internal class Program
    {
        static int ar, br, bt, ht, ct, dt, rc;

        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el área y perimetro\n\n");

            Console.WriteLine("Ingresa primero los valores para el Rectángulo\n");
            Console.Write("Ingresa la altura del rectángulo: ");
            ar = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la base del rectángulo: ");
            br = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            Console.WriteLine("Ingresa los valores para el Triángulo\n");
            Console.Write("Ingresa la base del triángulo: ");
            bt = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la altura del triángulo: ");
            ht = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el lado izquierdo del triángulo: ");
            ct = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el lado derecho del triángulo: ");
            dt = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            Console.WriteLine("Ingresa los valores para el Circulo\n");
            Console.Write("Ingresa el radio del circulo: ");
            rc = int.Parse(Console.ReadLine());

            Console.WriteLine();

            FigGeo[] ofg = new FigGeo[3];
            Rectangulos or = new Rectangulos(ar, br);
            Triangulos ot = new Triangulos(ar, br, bt, ht, ct, dt);
            Circulos oc = new Circulos(ar, br, bt, ht, ct, dt, rc);
            ofg[0] = or;
            ofg[1] = ot;
            ofg[2] = oc;

            double a;
            a = ofg[0].Area();
            Console.WriteLine($"El área del rectángulo es: {a}");
            a = ofg[1].Area();
            Console.WriteLine($"El área del triángulo es: {a}");
            a = ofg[2].Area();
            Console.WriteLine($"El área del circulo es: {a}");


            a = oc.PeriRec();
            Console.WriteLine($"El perimetro del rectángulo es: {a}");
            a = oc.PeriTri();
            Console.WriteLine($"El perimetro del triángulo es: {a}");
            a = oc.PeriCir();
            Console.WriteLine($"El perimetro del circulo es: {a}");

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            Console.ReadKey();
        }
    }
}
