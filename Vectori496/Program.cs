using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori496
{
    // Se dă un vector cu n numere naturale.
    // Să se determine câte dintre elementele vectorului sunt prime cu ultimul element.

    internal class Program
    {
        public static int Cmmdc(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                if (a < b)
                    b = b - a;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int contor = 0;
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data[i]);

            for (int i = 0; i < n; i++)
            {
                if (Cmmdc(v[i], v[n - 1]) == 1)
                {
                    contor++;
                }
            }

            Console.WriteLine(contor);
        }
    }
}