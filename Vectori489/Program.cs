using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori489
{
    // Se citește un vector cu n elemente, numere naturale.
    // Să se afișeze elementele vectorului în următoarea ordine:
    // primul, ultimul, al doilea, penultimul, etc.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int i = 0, j = n - 1;
            while (i <= j)
            {
                Console.Write(data[i] + " ");
                if (i != j)
                {
                    Console.Write(data[j] + " ");
                }
                i++;
                j--;
            }
        }
    }
}