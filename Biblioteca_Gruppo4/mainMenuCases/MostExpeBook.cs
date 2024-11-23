using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Cases
{
    internal class MostExpeBook
    {
        public static void mostExpeBook(string[] Titoli, double[] prezzo)
        {
            Console.Clear();
            double max = -1;
            int pos = 0;

            for (int i = 0; i < prezzo.Length; i++)
            {
                if (prezzo[i] > max)
                {
                    max = prezzo[i];
                    pos = i;
                }
            }

            Console.WriteLine($"Il libro piu costoso: {Titoli[pos]} \t {prezzo[pos]}€");
            Console.ReadKey();
            return;
        }
    }
}
