using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori658
{
    // Se dă o matrice cu n linii și m coloane și elemente numere naturale.             LABORATOR
    // Să se determine suma elementelor de pe fiecare linie.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linie = Console.ReadLine().Split(' ');
            int n = int.Parse(linie[0]);
            int m = int.Parse(linie[1]);
            int[,] matrix = new int[n, m];
            string[] buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    matrix[i, j] = int.Parse(buffer[j]);
            }

            for (int i = 0; i < n; i++)
            {
                int suma = 0;
                for (int j = 0; j < m; j++)
                    suma += matrix[i, j];
                Console.Write(suma + " ");
            }
        }
    }
}