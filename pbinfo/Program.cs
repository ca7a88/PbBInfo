using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum00();
            //Urare();
            Console.ReadLine();
        }

        private static void Urare()
        {
            Console.WriteLine("Va iubesc!");
        }

        /// <summary>
        /// Se dau 2 numere naturale. Calculaţi suma celor 2 numere date.
        /// </summary>
        /// <example>
        /// n = 2, 8
        /// se va afisa 10
        /// </example>
        /// <restrictii>
        /// n < 1000000000
        /// </restrictii>
        private static void Sum00()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }
    }
}
