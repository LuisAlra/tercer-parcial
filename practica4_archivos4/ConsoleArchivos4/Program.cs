using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleArchivos4
{
    internal class Program
    {
        static int[,] data;

        static void Main(string[] args)
        {
            data = new int[5,5];
            Save();
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
            Console.WriteLine("Archivo binario de datos con matrices generado\n");
            Load();
            Console.ReadKey();
        }

        public static void Save()
        {
            Stream save1 = File.Create("my-data.txt");
            BinaryFormatter serialize = new BinaryFormatter();
            int sum = 0;

            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    data[k, i] = i + sum;
                    serialize.Serialize(save1, data[k, i]);
                }
                sum += 5;
            }

            save1.Close();
        }

        public static void Load()
        {
            Stream load1 = File.OpenRead("my-data.txt");
            BinaryFormatter deserialize = new BinaryFormatter();
            Console.WriteLine("Leyendo datos de un archivo binario...\n");
            string aux;

            for (int k = 0; k < 5; k++)
            {
                aux = "";
                for (int i = 0; i < 5; i++)
                {
                    data[k, i] = Convert.ToInt32(deserialize.Deserialize(load1));
                    aux += data[k, i].ToString() + "\t";
                }
                Console.WriteLine(aux);
            }

            load1.Close();
        }
    }
}
