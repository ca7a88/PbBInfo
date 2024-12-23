//// (0.028 sec)
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Vectori4037
//{
//    // Se dă un șir a1, a2, …, an de numere întregi.
//    // Se dau de asemenea numerele întregi x și k. Să se determine:
//    // a) Cea mai din stânga poziție p din șir cu a[p] = x
//    // b) Cea mai din dreapta poziție q din șir cu a[q] = x
//    // c) Poziția r a celei de-a k-a apariții a lui x în șir.
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] v = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                v[i] = int.Parse(Console.ReadLine());
//            }
//            int x = int.Parse(Console.ReadLine());
//            int k = int.Parse(Console.ReadLine());
//            int p, q, r, contor;
//            p = q = r = contor = 0;

//            for (int i = 0; i < n; i++)
//            {
//                if (v[i] == x)
//                {
//                    if (p == 0)
//                    {
//                        p = q = i + 1;
//                        contor++;
//                    }
//                    else
//                    {
//                        q = i + 1;
//                        contor++;
//                    }

//                    if (contor == k)
//                        r = i + 1;
//                }
//            }
//            Console.Write("{0}\n{1}\n{2}", p, q, r);
//        }
//    }
//}







// REZOLVAREA MEA (0.024 sec)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori4037
{
    // Se dă un șir a1, a2, …, an de numere întregi.
    // Se dau de asemenea numerele întregi x și k. Să se determine:
    // a) Cea mai din stânga poziție p din șir cu a[p] = x
    // b) Cea mai din dreapta poziție q din șir cu a[q] = x
    // c) Poziția r a celei de-a k-a apariții a lui x în șir.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int poz_x, poz_x2, poz_x3, contor;
            poz_x = poz_x2 = poz_x3 = contor = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            bool poz = true, poz2 = true;
            int j = n - 1;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == x && poz)
                {
                    poz_x = i + 1;
                    poz = false;
                }
                if (v[j] == x && poz2)
                {
                    poz_x2 = j + 1;
                    poz2 = false;
                }
                j--;
                if (v[i] == x && contor < k)
                {
                    poz_x3 = i + 1;
                    contor++;
                }
            }
            Console.WriteLine(poz_x);
            Console.WriteLine(poz_x2);
            if (contor == k)
                Console.WriteLine(poz_x3);
            else
                Console.WriteLine(0);
        }
    }
}