using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori498
{
    // Se dă un vector cu n numere naturale.                                                    LABORATOR
    // Să se determine câte dintre perechile de elemente din vector sunt prime între ele.
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

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }

            int contor = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {                                                     
                    if (Cmmdc(v[i], v[j]) == 1)
                    {
                        contor++;
                    }
                }
            }
            Console.WriteLine(contor);
        }
    }
}