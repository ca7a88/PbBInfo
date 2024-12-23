using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori383
{
    // Se dă un număr natural nenul k și vector cu n numere naturale.
    // Să se înlocuiască fiecare element cu multiplul lui k cel mai apropiat de el
    // și să se afișeze elementele astfel obținute în ordine inversă.
    internal class Program
    {
        static int MultipluK(int n, int k)
        {
            int r = n % k;
            if (r <= k / 2) return n - r;
            else return n + k - r;
        }
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int k = int.Parse(data[0]);
            int n = int.Parse(data[1]);

            string[] data2 = Console.ReadLine().Split(' ');
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data2[i]);

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(MultipluK(v[i], k) + " ");
            }
        }
    }
}