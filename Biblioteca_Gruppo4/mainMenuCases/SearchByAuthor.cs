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
        static public void searchByAuthor(string[] Titoli, string[] Autori, int[] copie)
        {
            Console.Clear();
            Console.WriteLine("Autori Presenti");

            string[] autori_unici = new string[1];

            //Metto dentro l`array tutti i autori 
            for (int i = 0; i < Autori.Length; i++)
            {
                //Controllo che non ci siano doppioni
                bool flag = false;
                for (int j = 0; j < autori_unici.Length; j++)
                {
                    //Se null

                    if (autori_unici[j] == null)
                    {
                        autori_unici[j] = Autori[i];
                        flag = true;
                        break;
                    }

                    if (ToLower.ToLowerString(Autori[i]) 
						== ToLower.ToLowerString(autori_unici[j]))
                    {
                        flag = true;
                        break;
                    }
                }

                //Se non sono doppioni li aggiungo
                if (!flag)
                {
                    autori_unici[autori_unici.Length - 1] = Autori[i];
                    string[] temp = new string[autori_unici.Length + 1];
                    for (int j = 0; j < autori_unici.Length; j++)
                    {
                        temp[j] = autori_unici[j];
                    }
                    autori_unici = temp;
                }
            }

            //Stampo

            for (int i = 0; i < autori_unici.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {autori_unici[i]}");
            }

            //Scelta autore
            Console.WriteLine("Scegli l'autore");
            int scelta;
            try
            {
                scelta = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Scelta errata");
                Console.ReadKey();
                return;
            }

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
