using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici767
{
    // Se dă o matrice cu n linii şi m coloane şi elemente numere naturale.
    // Determinați suma valorilor pare din matrice.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[,] matrix = new int[n, m];

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(buffer[j]);
                    if (matrix[i, j] % 2 == 0)
                        sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}