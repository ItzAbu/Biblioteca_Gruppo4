using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Gruppo4.logoBibleoteca;

namespace Biblioteca_Gruppo4.mainMenuWithArrows
{
    internal class MenuArrow
    {

        //Questa funzione serve per stampare un menu consultabile con le freccie 




        //Stampa il menu
        static public void Menu(int pos)
        {
            // Menu
            string[] strings =
            {
            "Inserisci un libro",
            "Consulta tutti i libri della biblioteca",
            "Rimuovi un libro",
            "Ricerca libri per autore",
            "Stampa libro più costoso",
            "Ordina i libri in base al prezzo",
            "Stampa i libri per fascia di prezzo",
            "Prestito",
            "Esci"
            };

            // Calcola la larghezza della console

            int consoleWidth = Console.WindowWidth; 

            for (int i = 0; i < strings.Length; i++)
            {
                // Calcola il numero di spazi iniziali per centrare la stringa
                int padding = (consoleWidth - strings[i].Length) / 2;

                // Assicurati che il padding sia almeno 0
                if(padding < 0)
                {
                    padding = 0;
                }


                // Colore verde per l'opzione selezionata
                if (i == pos - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string(' ', padding) + $"> {strings[i]}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', padding) + $"  {strings[i]}");
                }
            }

            // Resetta il colore
            Console.ResetColor();
        }

        //Stampa il menu con la freccia

        static public int menuArrow()
        {
            //Leggo il tasto premuto
            ConsoleKeyInfo key;
            int pos = 1;
            do
            {
                Console.Clear();
                Bibleoteca.Logo();
                Menu(pos);
                key = Console.ReadKey();
                //Se premo freccia giú incremento la posizione quindi va all`opzione dopo
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (pos < 9)
                    {
                        pos++;
                    }
                }
                //Se premo freccia su decremento la posizione quindi va all`opzione prima
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pos > 1)
                    {
                        pos--;
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }



    }
}
