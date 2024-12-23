using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici659
{
    // Gigel a găsit o matrice cu n linii și m coloane și elemente numere naturale.
    // El își propune să determine, pentru fiecare linie,
    // cea mai mică valoare care se poate obține adunând elementele de pe linie, cu excepția unuia.
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

            int sum, max;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                max = matrix[i, 1];
                for (int j = 0; j < m; j++)
                {
                    sum = sum + matrix[i, j];
                    if(matrix[i, j] > max)
                        max = matrix[i, j];
                }
                Console.Write(sum - max + " ");
            }
        }
    }
}