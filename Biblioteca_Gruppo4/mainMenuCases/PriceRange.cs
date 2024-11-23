using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Cases
{
    internal class PriceRange
    {
        public static void priceRange(string[] Titoli, double[] prezzo, int[] copie)
        {
            Console.Clear();
            Console.WriteLine("Inserisci la fascia di prezzo");
            double min, max;
            try
            {
                Console.WriteLine("Minimo");
                min = double.Parse(Console.ReadLine());
                Console.WriteLine("Massimo");
                max = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: Inserire un numero valido");
                Console.ReadKey();
                return;

            }

            if (min > max)
            {
                Console.WriteLine("Errore: Il minimo non puó essere maggiore del massimo");
                Console.ReadKey();
                return;
            }

            for(int i = 0; i < prezzo.Length; i++)
            {
                if (prezzo[i] >= min && prezzo[i] <= max)
                {
                    Console.WriteLine($"[{i}] {Titoli[i]} \t {copie[i]}€ \t x{copie[i]}");
                    
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
            return;

        }
        
    }
}
