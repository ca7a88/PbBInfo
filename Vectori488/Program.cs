using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori488
{
    // Se citește un vector cu n elemente, numere naturale.
    // Să se afișeze elementele cu indici pari în ordinea crescătoare a indicilor,
    // iar elementele cu indici impari în ordinea descrescătoare a indicilor.
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

            for (int i = 1; i < n; i += 2)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            if (n % 2 == 0)
                n--;
            for (int i = n - 1; i >= 0; i -= 2)
            {
                Console.Write(data[i] + " ");
            }
        }
    }
}