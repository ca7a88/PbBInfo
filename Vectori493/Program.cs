using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori493
{
    // Se dă un vector x cu n elemente, numere naturale.
    // Să se construiască un alt vector, y, cu proprietatea că y[i] este egal cu
    // restul împărțirii lui x[i] la suma cifrelor lui x[i].
    internal class Program
    {
        static int SumaCifre(int n)
        {
            int cif = 0, s = 0;
            while (n != 0)
            {
                cif = n % 10;
                s = s + cif;
                n = n / 10;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data[i]);

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] % SumaCifre(v[i]) + " ");
            }
        }
    }
}