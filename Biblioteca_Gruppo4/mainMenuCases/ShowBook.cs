using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Cases
{
    internal class ShowBook
    {
        public static void Menu(int pos, string[] Titoli) 
        {
            Console.Clear();
            Console.WriteLine("Indice Libri");

            for(int i=0; i<Titoli.Length; i++)
            {
                if (i == pos-1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> [{i+1}] {Titoli[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  [{i+1}] {Titoli[i]}");
                }
            }

        }

        public static void showBook(string[] Titoli, int[] copie, string[] Autori, double[] prezzo, string[] categoria, string[] casa_editrice)
        {
            
            ConsoleKeyInfo key;
            int pos = 1;
            do{
                Menu(pos, Titoli);
                key = Console.ReadKey();

                if(key.Key == ConsoleKey.DownArrow)
                {
                    if(pos == Titoli.Length)
                    {
                        pos = 1;
                    }
                    else
                    {
                        pos++;
                    }
                }
                else if(key.Key == ConsoleKey.UpArrow)
                {
                    if(pos == 1)
                    {
                        pos = Titoli.Length;
                    }
                    else
                    {
                        pos--;
                    }
                }
            }while(key.Key != ConsoleKey.Enter);

            Console.Clear();

            //Stampa libri
            Console.WriteLine("Titolo: " + Titoli[pos-1]);
            Console.WriteLine("Autore: " + Autori[pos-1]);
            Console.WriteLine("Prezzo: " + prezzo[pos-1] + "Eur");
            Console.WriteLine("Categoria: " + categoria[pos-1]);
            Console.WriteLine("Casa Editrice: " + casa_editrice[pos-1]);
            Console.WriteLine("Copie: " + copie[pos-1]);

            Console.WriteLine("Premi un tasto per tornare al menu");
            Console.ReadKey();

            return;
        }

        
    }
}
