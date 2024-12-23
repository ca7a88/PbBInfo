using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori487
{
    // Se dă un vector cu n numere naturale.
    // Să se determine câte dintre elemente au valoarea
    // strict mai mare decât media aritmetică a elementelor vectorului.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int suma = 0, media, contor = 0;

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                suma = suma + v[i];
            }
            media = suma / n;

            for (int i = 0; i < n; i++)
            {
                if (v[i] > media)
                    contor++;
            }

            Console.WriteLine(contor);
        }
    }
}