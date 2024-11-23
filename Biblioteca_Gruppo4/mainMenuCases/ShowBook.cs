using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Cases
{
    internal class ShowBook
    {
        public static void showBook(string[] Titoli, int[] copie)
        {
            Console.Clear();
            Console.WriteLine("Indice Libri");
            for (int i = 0; i < Titoli.Length; i++)
            {
                //i+1 perché l`indice parte da 1 || Titoli[i] è il titolo del libro || copie[i] è il numero di copie
                Console.WriteLine($"[{i+1}] {Titoli[i]} \t x{copie[i]}");
            }
            Console.ReadKey();
            return;
        }
    }
}
