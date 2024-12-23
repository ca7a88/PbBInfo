using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori492
{
    // Se dă un vector cu n numere naturale.
    // Să se determine câte dintre perechile de elemente egal               LABORATOR
    // depărtate de capetele vectorului sunt prime între ele.
    internal class Program
    {
        public static int Cmmdc (int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                if (a < b)
                    b = b - a;
            }
            return a;
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

            int k = 0, j = n - 1, contor = 0;

            while (k <= j)
            {
                if (Cmmdc(v[k], v[j]) == 1)
                {
                    contor++;
                }
                k++;
                j--;
            }
            Console.WriteLine(contor);
        }
    }
}