using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori547
{
    // Se citește un vector cu n elemente, numere naturale.
    // Să se determine câte elemente ale vectorului sunt egale cu
    // diferența dintre cea mai mare și cea mai mică valoare din vector.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int minim = int.Parse(data[0]), maxim = int.Parse(data[0]), contor = 0;

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] > maxim)
                    maxim = v[i];
                if (v[i] < minim)
                    minim = v[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == maxim - minim)
                    contor++;
            }

            Console.WriteLine(contor);
        }
    }
}