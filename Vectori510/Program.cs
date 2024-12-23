using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori510
{
    // Se dă un vector cu n elemente, numere naturale.                              LABORATOR
    // Afișați în ordine crescătoare valorile prime din acest vector.               
    internal class Program
    {
        private static bool Prim(int v)
        {
            if (v < 2)
                return false;
            else if (v == 2)
                return true;
            else if (v % 2 == 0)
                return false;
            else
                for (int i = 3; i*i <= v; i++)
                {
                    if (v % i == 0)
                        return false;
                }
            return true;
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

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if(Prim(v[i]))
                    Console.Write(v[i] + " ");
            }
        }
    }
}