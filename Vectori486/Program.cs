using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori486
{
    // Se citește n, apoi încă n numere naturale, reprezentând elementele unui vector.
    // Calculaţi valoarea minimă minim și valoarea maximă maxim a valorilor elementelor vectorului.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int minim = int.Parse(data[0]), maxim = int.Parse(data[0]);

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] > maxim)
                    maxim = v[i];
                if (v[i] < minim)
                    minim = v[i];
            }

            Console.WriteLine(minim + " " + maxim);
        }
    }
}