using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori986
{
    // Se dă un șir cu n elemente, numere reale.
    // Să se determine câte dintre elemente se află în afara
    // intervalului închis determinat de primul și ultimul element.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int contor = 0;

            double[] v = new double[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = double.Parse(data[i]);
            }

            double min = v[0], max = v[n - 1];

            if (v[0] > v[n - 1])
            {
                double aux = v[0];
                min = max;
                max = aux;
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] < min || v[i] > max)
                {
                    contor++;
                }
            }

            Console.WriteLine(contor);
        }
    }
}