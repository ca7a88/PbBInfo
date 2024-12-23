using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori553
{
    // Se citește n, apoi n numere naturale distincte, reprezentând elementele unui vector.
    // Calculaţi indicele imin și indicele imax ai elementului cu valoarea minimă,
    // respectiv cu valoarea maximă, din vectorul dat.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int minim = int.Parse(data[0]), maxim = int.Parse(data[0]), imin = 1, imax = 1;

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    imax = i + 1;
                }

                if (v[i] < minim)
                {
                    minim = v[i];
                    imin = i + 1;
                }
                    
            }

            Console.WriteLine(imin + " " + imax);

        }
    }
}