using Biblioteca_Gruppo4.prestitiCases;

namespace Biblioteca_Gruppo4.menuPrestiti
{
    internal class MenuPrestiti
    {

        static public void Menu(int pos)
        {
            string[] strings = {
                "Prendi in prestito un libro",
                "Riconsegna libro",
                "Stampa tutti i libri in prestito",
                "Esci"
            };

            Console.WriteLine("\n");

            // Calcola la larghezza della console

            int consoleWidth = Console.WindowWidth;

            for (int i = 0; i < strings.Length; i++)
            {
                // Calcola il numero di spazi iniziali per centrare la stringa
                int padding = (consoleWidth - strings[i].Length) / 2;

                // Assicurati che il padding sia almeno 0
                if (padding < 0)
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

        static public void menuPrestiti(string[] Titoli, string[] Autori, double[] prezzo, string[] categoria, string[] casa_editrice, int[] copie,ref int libri_unici,
                                        ref int prestiti, ref string[] libri_prestito, ref string[] utenti_prestito_nome, ref string[] utenti_prestito_cognome,
                                        ref string[] giorno_preso, ref string[] tempo_trattenuto, ref int[] codice_prestito, ref int returns)
        {
            ConsoleKeyInfo key;
            int pos = 1;
            do
            {
                Console.Clear();
                Console.WriteLine();
                LogoPrestito.logoPrestito();
                Menu(pos);
                key = Console.ReadKey();
                //Se premo freccia giú incremento la posizione quindi va all`opzione dopo
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (pos < 4)
                    {
                        pos++;
                    }
                    if(pos == 5)
                    {
                        pos = 1;
                    }
                }
                //Se premo freccia su decremento la posizione quindi va all`opzione prima
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pos > 1)
                    {
                        pos--;
                    }
                    if (pos == 0)
                    {
                        pos = 4;
                    }
                }
            } while (key.Key != ConsoleKey.Enter);

            switch (pos)
            {
                case 1:

                    TakeBorrow.takeBorrow(Titoli,copie, ref libri_prestito, ref prestiti, ref utenti_prestito_nome, ref utenti_prestito_cognome, ref giorno_preso, ref tempo_trattenuto, ref codice_prestito, ref returns);

                    break;

                case 2:

                    ReturnBook.returnBook(ref libri_prestito,ref utenti_prestito_nome, ref utenti_prestito_cognome, ref giorno_preso, ref tempo_trattenuto, ref codice_prestito, ref returns);

                    break;

                case 3:

                    ShowBorrowesBooks.showBorrowedBooks(libri_prestito, utenti_prestito_nome, utenti_prestito_cognome, giorno_preso, tempo_trattenuto, codice_prestito, prestiti);

                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("Premi per ritornare al menu principale");

                    break;

            }
        }
    }
}
