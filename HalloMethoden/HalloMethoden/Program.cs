using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Hallo Methoden ***");
            SagHallo();
            double result = GetKreisfläche(5);
            Console.WriteLine($"Fläche: {result:N5}");
            Console.WriteLine("Ende");
            Console.ReadLine();

        }

        #region Meine Methoden



        /// <summary>
        /// Schreibt Hallo in die Console
        /// </summary>
        static void SagHallo()
        {
            ZeigeText("Hallo");
        }

        static void ZeigeText(string txt)
        {
            Console.WriteLine($"[{DateTime.Now:T}] {txt}");
        }

        static double GetKreisfläche(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        static double GetKreisfläche(int radius)
        {
            return GetKreisfläche((double)radius);
        }
        #endregion
    }
}
