using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici770
{
    // Se dă o matrice cu n linii și m coloane și elemente numere naturale.
    // Să se permute coloanele matricei circular spre stânga cu o poziție.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    int aux = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = aux;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}