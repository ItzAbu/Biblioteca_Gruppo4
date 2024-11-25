using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Gruppo4.Utils;

namespace Biblioteca_Gruppo4.Cases
{
    internal class SearchByAuthor
    {
        static public void Menu(int pos, string[] Autori) {
            Console.Clear();
            Console.WriteLine("Autori Presenti");
            

            for(int i=0; i<Autori.Length; i++)
            {
                if (i == pos-1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> [{i+1}] {Autori[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  [{i+1}] {Autori[i]}");
                }
            }
        }


        static public void searchByAuthor(string[] Titoli, string[] Autori, int[] copie)
        {
            Console.Clear();
            Console.WriteLine("Autori Presenti");

            string[] autori_unici = new string[1];

            //Metto dentro l`array tutti i autori 
            for (int i = 0; i < Autori.Length; i++)
            {
                if(Autori[i] == null) {
                    continue;
                }
                //Controllo che non ci siano doppioni
                bool doppione = false;
                for (int j = 0; j < autori_unici.Length; j++)
                {
                    if (autori_unici[j] == null)
                    {
                        autori_unici[j] = Autori[i];
                        break;
                    }
                    
                    if (ToLower.ToLowerString(Autori[i]) == ToLower.ToLowerString(autori_unici[j]))
                    {
                        doppione = true;
                        break;
                    }
                }

                if (!doppione)
                {
                    Array.Resize(ref autori_unici, autori_unici.Length + 1);
                    autori_unici[autori_unici.Length - 1] = Autori[i];
                }

            }

            if(Autori[0] == null)
            {
                Console.WriteLine("Nessun autore presente");
                Console.ReadKey();
                return;
            }

            //Stampo
            ConsoleKeyInfo key;
            int scelta = 1;
            do{
                Menu(scelta, autori_unici);
                key = Console.ReadKey();

                if(key.Key == ConsoleKey.DownArrow)
                {
                    if(scelta == autori_unici.Length)
                    {
                        scelta = 1;
                    }
                    else
                    {
                        scelta++;
                    }
                }
                else if(key.Key == ConsoleKey.UpArrow)
                {
                    if(scelta == 1)
                    {
                        scelta = autori_unici.Length;
                    }
                    else
                    {
                        scelta--;
                    }
                }
            }while(key.Key != ConsoleKey.Enter);

            //Stampo i libri dell`autore scelto
            Console.Clear();
            Console.WriteLine($"Libri di {autori_unici[scelta - 1]}");
            int pos = 0;
            for (int i = 0; i < Autori.Length; i++)
            {
                if (ToLower.ToLowerString(Autori[i]) == ToLower.ToLowerString(autori_unici[scelta - 1]))
                {
                    Console.WriteLine($"[{pos + 1}] {Titoli[i]} \t x{copie[i]}");
                    pos++;
                }
                
            }

            Console.ReadKey();
            return;
        }
    }
}
