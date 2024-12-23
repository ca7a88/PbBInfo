using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori491
{
    // Se citește un vector cu n elemente, numere naturale.
    // Să se determine suma valorilor elementelor cuprinse între
    // primul și ultimul element par al vectorului, inclusiv acestea.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int suma = 0, contor = 0, indiceInitial = -1, indiceFinal = -1;

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0 && contor == 0)
                {
                    indiceInitial = i;
                    contor++;
                }
                if (v[i] % 2 == 0)
                    indiceFinal = i;
            }

            if (indiceInitial == -1)
                Console.WriteLine("NU EXISTA");
            else
            {
                for (int i = indiceInitial; i <= indiceFinal; i++)
                {
                    suma = suma + v[i];
                }
                Console.WriteLine(suma);
            }
        }
    }
}