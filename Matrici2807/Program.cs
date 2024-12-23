using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici2807
{
    // Scrieți un program care citește de la tastatură două numere naturale
    // din intervalul [2,50], n și m, și elementele unui tablou bidimensional
    // cu n linii și m coloane, numere naturale distincte din intervalul [0,104].
    // Programul interschimbă valoarea minimă din ultima coloană a tabloului
    // cu valoarea minimă din prima coloană a tabloului, apoi afișează pe ecran tabloul modificat,
    // câte o linie a tabloului pe câte o linie a ecranului, elementele fiecărei linii fiind separate prin câte un spațiu.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(buffer[j]);
                }
            }

            int min = int.MaxValue, min2 = int.MaxValue, i1 = 0, i2 = 0;
            for (int i = 0; i < n; i++)
            {
                if(matrix[i, 0] < min)
                {
                    min = matrix[i, 0];
                    i1 = i;
                }
                if (matrix[i, m - 1] < min2)
                {
                    min2 = matrix[i, m - 1];
                    i2 = i;
                }
            }
            matrix[i1, 0] = min2;
            matrix[i2, m - 1] = min;

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