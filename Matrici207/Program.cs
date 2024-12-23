using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici207
{
    // Scrieţi un program care citeşte de la tastatură un număr natural n               LABORATOR
    // şi construieşte în memorie o matrice cu n linii şi n coloane ale cărei elemente
    // vor primi valori după cum urmează:
    // - elementele aflate pe diagonala principală a matricei vor primi valoarea 0
    // - elementele de pe prima coloană, cu excepţia celui aflat pe diagonala principală vor primi valoarea n
    // - elementele de pe a doua coloană, cu excepţia celui aflat pe diagonala principală vor primi valoarea n-1
    // …
    // - elementele de pe ultima coloană, cu excepţia celui aflat pe diagonala principală vor primi valoarea 1
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = n - j;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}