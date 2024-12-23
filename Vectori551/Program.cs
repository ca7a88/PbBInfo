using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori551
{
    // La liceul nostru sunt m clase, fiecare având n elevi.
    // Pentru fiecare elev se cunoaşte talentul artistic, exprimat printr-un număr natural.
    // Să se determine cea mai mare valoare pe care o are talentul artistic al elevilor,
    // notată cu MAX şi numărul CNT de clase din liceu în care există elevi care au talent maxim.
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data1 = Console.ReadLine().Split(' ');
            int m = int.Parse(data1[0]);
            int n = int.Parse(data1[1]);

            int[,] matrix = new int[m, n];
            string[] buffer;

            for (int i = 0; i < m; i++)
            {
                buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    matrix[i, j] = int.Parse(buffer[j]);
            }

            int max = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }

            int contor = 0;
            for (int i = 0; i < m; i++)
            {
                bool este = false;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == max)
                        este = true;                
                }
                if (este)
                    contor++;
            }

            Console.WriteLine("{0} {1}", max, contor);
        }
    }
}