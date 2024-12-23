using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici666
{
    // Se dă o matrice cu n linii și m coloane și elemente numere naturale.
    // Să se determine câte dintre elementele situate pe linii cu indici pari sunt prime.
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i*i <= n; i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string[] linie = Console.ReadLine().Split(' ');
            int n = int.Parse(linie[0]);
            int m = int.Parse(linie[1]);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    matrix[i, j] = int.Parse(buffer[j]);
            }

            int contor = 0;
            for (int i = 1; i < n; i+=2)
            {
                for (int j = 0; j < m; j++)
                {
                    if (IsPrime(matrix[i, j]))
                        contor++;
                }
            }
            Console.WriteLine(contor);
        }
    }
}