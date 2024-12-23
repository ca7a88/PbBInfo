using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici316
{
    // Se dă o matrice cu m linii şi n coloane şi elemente numere naturale.
    // Înlocuiţi cu valoarea minimă din matrice toate elementele de pe coloanele care conţin valoarea minimă.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int m = int.Parse(t[0]);
            int n = int.Parse(t[1]);
            int[,] matrix = new int[m, n];
            int min = int.MaxValue;
            for (int i = 0; i < m; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(buffer[j]);
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }

            for (int j = 0; j < n; j++)
            {
                bool ok = false;
                for (int i = 0; i < m; i++)
                    if (matrix[i, j] == min)
                        ok = true;

                    if (ok)
                        for (int i = 0; i < m; i++)
                            matrix[i, j] = min;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}