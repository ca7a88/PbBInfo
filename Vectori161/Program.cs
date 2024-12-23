using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori161
{
    // Să se înlocuiască toate elementele nule dintr-un vector
    // cu elemente numere naturale cu partea întreagă a
    // mediei aritmetice a elementelor nenule din vector.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int suma = 0, contor = 0;

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data[i]);

            for (int i = 0; i < n; i++)
            {
                if (v[i] > 0)
                {
                    suma += v[i];
                    contor++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                {
                    v[i] = suma / contor;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}