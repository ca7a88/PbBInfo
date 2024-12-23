using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori2858
{
    // Se consideră un șir a1, a2, …, an de numere naturale.
    // Să se afișeze elementele șirului de la dreapta la stânga.
    // Să se calculeze suma valorilor pare din șir.
    // Să se determine suma valorilor aflate pe poziții pare în șir.
    // Să se determine numărul numerelor din șir care sunt divizibile cu 10.
    // Să se determine suma numerelor divizibile cu 3 și aflate pe poziții impare.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(v[i] + " ");              // Se afișează elementele șirului de la dreapta la stânga.
            }
            Console.WriteLine();

            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                    suma = suma + v[i];
            }
            Console.Write(suma);                        // Se calculează suma valorilor pare din șir.
            Console.WriteLine();

            int suma2 = 0;
            for (int i = 1; i < n; i+=2)
            {
                suma2 = suma2 + v[i];
            }
            Console.Write(suma2);                       // Se determină suma valorilor aflate pe poziții pare în șir.
            Console.WriteLine();

            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 10 == 0)
                    contor++;
            }
            Console.Write(contor);                      // Se determină numărul numerelor din șir care sunt divizibile cu 10.
            Console.WriteLine();

            int div3 = 0;
            for (int i = 0; i < n; i+=2)
            {
                if (v[i] % 3 == 0)
                    div3 = div3 + v[i];
            }
            Console.Write(div3);                        // Se determină suma numerelor divizibile cu 3 și aflate pe poziții impare.
            Console.WriteLine();
        }
    }
}