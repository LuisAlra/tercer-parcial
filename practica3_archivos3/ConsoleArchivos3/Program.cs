using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleArchivos3
{
    internal class Program
    {
        static int[,] data;

        static void Main(string[] args)
        {
            data = new int[5, 5];
            Save();
            Console.WriteLine("Archivo de datos con matrices generado\n");
            Load();
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
            Console.ReadKey();
        }

        public static void Save()
        {
            StreamWriter save1 = new StreamWriter("my-data.txt");
            int add = 0;

            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    data[k, i] = i + add;
                    save1.WriteLine(data[k, i]);
                }
                add += 5;
            }

            save1.Close();
        }

        public static void Load()
        {
            StreamReader load1 = new StreamReader("my-data.txt");
            Console.WriteLine("Leyendo datos...\n");
            string aux;

            for (int k = 0; k < 5; k++)
            {
                aux = "";
                for (int i = 0; i < 5; i++)
                {
                    data[k, i] = int.Parse(load1.ReadLine());
                    aux += data[k, i].ToString() + "\t";
                }

                Console.WriteLine(aux);
            }

            load1.Close();
        }
    }
}
