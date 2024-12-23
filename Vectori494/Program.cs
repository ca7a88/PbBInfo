using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori494
{
    // Se dă un vector x cu n elemente, numere naturale.
    // Să se construiască un alt vector, y, cu n elemente,                                      LABORATOR
    // cu proprietatea că y[i] este egal cu suma elementelor din x, cu excepția lui x[i].
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];
            int[] y = new int[n];

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                suma = suma + v[i];
            }

            for (int i = 0; i < n; i++)
            {
                y[i] = suma - v[i];
                Console.Write(y[i] + " ");
            }
        }
    }
}