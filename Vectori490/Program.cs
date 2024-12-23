using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori490
{
    // Se citește un vector cu n elemente, numere naturale distincte.
    // Să se afișeze elementele cuprinse între elementul cu valoarea minimă
    // și cel cu valoare maximă din vector, inclusiv acestea.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');
            int minim = int.Parse(data[0]), maxim = int.Parse(data[0]), indice1 = 0, indice2 = 0;

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] < minim)
                {
                    minim = v[i];
                    indice1 = i;
                }
                else if (v[i] > maxim)
                {
                    maxim = v[i];
                    indice2 = i;
                }   
            }

            if (indice1 > indice2)
            {
                int aux = indice1;
                indice1 = indice2;
                indice2 = aux;
            }
            for (int i = indice1; i <= indice2; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}