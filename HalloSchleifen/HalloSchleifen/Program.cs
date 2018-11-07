using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //zählergesteuerte schleifen
            StreamWriter sw = new StreamWriter("text.txt");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}");
                sw.WriteLine(i * 409);
            }
            sw.Close();

            Console.WriteLine("*************************************");
            //bedingungsgesteuerte schleifen
            //kopfgesteuert
            StreamReader sr = new StreamReader("text.txt");
            int lineCount = 1;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine($"{lineCount++} {line}");
            }
            sr.Close();

            //fußgesteut
            do
            {
                Console.WriteLine("Ich mach mal was");
            } while (false);


            foreach (var item in args)
            {
                Console.WriteLine($"--{item}");
            }


            Console.WriteLine("Ende");
            Console.ReadLine();
        }


    }
}
