using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori499
{
    // Se dă un vector cu n numere naturale.
    // Să se determine câte dintre perechile de elemente din vector                 LABORATOR 
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
            {
                v[i] = int.Parse(data[i]);
            }

            int contor = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {                                                       
                    if (SumaCifre(v[i]) == SumaCifre(v[j]))
                    {
                        contor++;
                    }
                }
            }

            Console.WriteLine(contor);
        }
    }
}