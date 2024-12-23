using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmultireaMatricilor
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    // citesc a, b
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int i = 0; i < m; i++)
        //        {
        //            c[i, j] = 0
        //            for (int k = 0; k < n; k++)
        //                c[i, j] += a[i, k] * b[k, j];
        //        }
        //    }
        //    // afisez c
        //}

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a1 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    a1[i, j] = int.Parse(buffer[j]);
            }

            int[,] a2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    a2[i, j] = int.Parse(buffer[j]);
            }

            int[,] a3 = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a3[i, j] = 0;
                    for (int k = 0; k < n; k++)
                        a3[i, j] += a1[i, k] * a2[k, j];
                }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a3[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

