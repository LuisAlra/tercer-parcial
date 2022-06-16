using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleArchivos2
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
            Console.WriteLine("Archivo binario de datos generado");
            Console.ReadKey();
        }

        public static void Save()
        {
            Stream save1 = File.Create("my-data.txt");
            BinaryFormatter serialize = new BinaryFormatter();

            for (int k = 0; k < 5; k++)
            {
                data[k] = k;
                serialize.Serialize(save1, data[k]);
            }

            save1.Close();
        }

        public static void Load()
        {
            Stream load1 = File.OpenRead("my-data.txt");
            BinaryFormatter deserialize = new BinaryFormatter();

            for (int k = 0; k < 5; k++)
            {
                data[k] = Convert.ToInt32(deserialize.Deserialize(load1));
            }

            load1.Close();
        }
    }
}
