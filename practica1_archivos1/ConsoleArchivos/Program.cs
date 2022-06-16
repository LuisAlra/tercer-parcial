using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleArchivos
{
    internal class Program
    {
        static int[] data;

        static void Main(string[] args)
        {
            data = new int[5];
            Save();
            Load();
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
            Console.WriteLine("Archivo de datos generado");
            Console.ReadKey();
        }

        public static void Save()
        {
            StreamWriter save1 = new StreamWriter("my-data.txt");

            for (int k = 0; k < 5; k++)
            {
                save1.WriteLine(data[k]);
            }

            save1.Close();
        }

        public static void Load()
        {
            StreamReader load1 = new StreamReader("my-data.txt");

            for (int k = 0; k < 5; k++)
            {
                data[k] = int.Parse(load1.ReadLine());
            }

            load1.Close();
        }
    }
}
