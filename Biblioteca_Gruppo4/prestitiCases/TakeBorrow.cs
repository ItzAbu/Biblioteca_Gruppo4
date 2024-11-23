using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Gruppo4.Utils;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca_Gruppo4.prestitiCases
{
    internal class TakeBorrow
    {

        static public void Menu(string[] strings,int pos)
        {
            Console.Clear();

            

            Console.WriteLine(new string(' ', 20) + "Libri Disponibili, Scegli un libro da prendere in prestito");

            Console.WriteLine("\n\n");
            // Calcola la larghezza della console
            int consoleWidth = Console.WindowWidth;
            for (int i = 0; i < strings.Length; i++)
            {
                // Calcola il numero di spazi iniziali per centrare la stringa
                if(strings[i] == null)
                {
                    continue;
                }
                int padding = (consoleWidth - strings[i].Length) / 2;
                // Assicurati che il padding sia almeno 0
                if (padding < 0)
                {
                    padding = 0;
                }


                // Colore verde per l'opzione selezionata
                if (i == pos )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', padding) + $"> {strings[i]}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', padding) + $"  {strings[i]}");
                }

                Console.ResetColor();
            }
        }


        static public void takeBorrow(string[] Titoli,int[] copie, ref string[] libri_prestito, ref int prestiti, 
            ref string[] utenti_prestito_nome, ref string[] utenti_prestito_cognome , ref string[] giorni_preso, 
            ref string[] tempo_trattenuto, ref int[] codice_prestito)
        {
            Console.Clear();
            string[] strings = Titoli;
            int[] ints = copie;
            //Controllo quali libro sono disponibili
            int count = 0;
            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == null)
                {
                    count++;
                    continue;
                }
                
            }
            if (count == strings.Length)
            {
                Console.WriteLine("Non ci sono libri disponibili");
                Console.ReadKey();
                return;
            }

            for (int i=0; i < libri_prestito.Length; i++)
            {
                for(int j = 0; j < strings.Length; j++)
                {
                    if (libri_prestito[i] == strings[j])
                    {
                        if (ints[j] > 1)
                        {
                            ints[j]--;
                        }
                        else
                        {
                            strings[j] = null;
                        }
                    }
                }
            }

            //Stampo i libri disponibili e faccio il menu per il prestito
            ConsoleKeyInfo key;
            int pos = 0;
            do
            {
                //Controllo che ci siano libri disponibili
                int count2 = 0;
                for (int i = 0; i < strings.Length; i++)
                {
                    if (strings[i] == null)
                    {
                        count2++;
                        continue;
                    }

                }
                if (count2 == strings.Length)
                {
                    Console.WriteLine("Non ci sono libri disponibili");
                    Console.ReadKey();
                    return;
                }

                Menu(strings, pos);
                key = Console.ReadKey();

                


                //Freccie
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos >= strings.Length)
                    {
                        pos = 0;
                    }
                    while (strings[pos] == null)
                    {
                        pos++;
                        if (pos >= strings.Length)
                        {
                            pos = 0;
                        }
                    }
                    
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < 0)
                    {
                        pos = strings.Length - 1;
                    }
                    while(strings[pos] == null)
                    {
                        pos--;
                        if (pos < 0)
                        {
                            pos = strings.Length - 1;
                        }
                    }

                }
            } while (key.Key != ConsoleKey.Enter);

            //Aggiungo il libro preso in prestito
            string nome, cognome, giorno_restituisci;

            Console.WriteLine("Inserisci il tuo nome");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome");
            cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il giorno in cui devi restituire il libro, Inserisci GG/MM/AAAA");
            giorno_restituisci = Console.ReadLine();



            if (prestiti >= 2)
            {
                Array.Resize(ref libri_prestito, libri_prestito.Length + 1);
                Array.Resize(ref utenti_prestito_nome, utenti_prestito_nome.Length + 1);
                Array.Resize(ref utenti_prestito_cognome, utenti_prestito_cognome.Length + 1);
                Array.Resize(ref giorni_preso, giorni_preso.Length + 1);
                Array.Resize(ref tempo_trattenuto, tempo_trattenuto.Length + 1);
                Array.Resize(ref codice_prestito, codice_prestito.Length + 1);


            }
            libri_prestito[prestiti] = strings[pos ];
            utenti_prestito_nome[prestiti] = nome;
            utenti_prestito_cognome[prestiti] = cognome;
            giorni_preso[prestiti] = DateTime.Now.ToString("dd/MM/yyyy");
            tempo_trattenuto[prestiti] = giorno_restituisci;
            codice_prestito[prestiti] = prestiti;
            prestiti++;

            Console.WriteLine("Libro preso in prestito con successo");

            Console.WriteLine("Libro : " + libri_prestito[prestiti - 1]);
            Console.WriteLine("Utente : " + utenti_prestito_nome[prestiti - 1] + " " + utenti_prestito_cognome[prestiti - 1]);
            Console.WriteLine("Giorno preso : " + giorni_preso[prestiti - 1]);
            Console.WriteLine("Giorno da restituire : " + tempo_trattenuto[prestiti - 1]);
            Console.WriteLine("Codice prestito : " + codice_prestito[prestiti - 1]);

            Console.ReadKey();

            return;


        }
    }
}
