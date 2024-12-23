using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori546
{
    // Se citește un vector cu n elemente, numere naturale.
    // Să se afișeze elementele din vector care sunt multipli ai ultimului element.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] % v[n - 1] == 0)
                    Console.Write(v[i] + " ");
            }
        }
    }
}