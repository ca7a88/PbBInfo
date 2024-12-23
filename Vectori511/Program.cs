using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori511
{
    // Se dă un vector cu n elemente, numere naturale și un număr k.            LABORATOR
    // Ordonați crescător primele k elemente ale vectorului și descrescător ultimele n-k elemente.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);

            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }

            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }

            for (int i = k; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] < v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}