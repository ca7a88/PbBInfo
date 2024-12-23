using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori495
{
    // Se dă un vector x cu n elemente, numere naturale.
    // Să se construiască un alt vector, y, care să conțină
    // elementele prime din x, în ordine inversă.
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

        static void AfisareVector(int[] vector)
        {
            foreach (int i in vector)
                Console.Write(i + " ");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] buffer = Console.ReadLine().Split(' ');
            int[] x = new int[n];

            int contor = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(buffer[i]);
                if (IsPrime(x[i]))
                    contor++;
            }
            
            int[] y = new int[contor];
            int index = 0;
            for (int i = x.Length - 1; i >= 0; i--)
            {
                if (IsPrime(x[i]))
                {
                    y[index] = x[i];
                    index++;
                }
            }

            AfisareVector(y);

            // 5 7 29 8 8 11 3 4 => 3 11 29 7 5
        }
    }
}