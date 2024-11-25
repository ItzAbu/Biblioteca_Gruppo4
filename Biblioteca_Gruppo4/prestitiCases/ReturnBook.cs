namespace Biblioteca_Gruppo4.prestitiCases
{
    internal class ReturnBook
    {

        public static void Menu(int pos)
        {   
            Console.WriteLine("\n");
            string[] str =
            {
                "[YES]",
                "[NO]"
            };

            Console.WriteLine("\n");

            int consoleWidth = Console.WindowWidth;

            int padding = (consoleWidth - (str[0].Length + str[1].Length + "\t".Length) / 3);
            if (padding < 0)
            {
                padding = 0;
            }

            if (pos == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.Write(new string(' ', padding/2) + $"> {str[0]}" );
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {str[1]}");
                Console.ResetColor();

            }
            else
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.Write(new string(' ', padding/2) + $"{str[0]}" );
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write($" > {str[1]}");
            }
            Console.ResetColor();
        }

        public static void returnBook(ref string[] libro_prestito, ref string[] utenti_prestito_nome,
            ref string[] utenti_prestito_cognome, ref string[] giorni_preso, ref string[] tempo_trattenuto, ref int[] codice_prestito, ref int returns)
        {
            Console.Clear();
            Console.WriteLine("Inserisci il codice del prestito da restituire");
            int codice;
            try
            {
                codice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: Inserire un numero");
                return;
            }

            int pos;
            //Flag codice non presente
            bool flag = false;
            for (pos = 0; pos < codice_prestito.Length; pos++)
            {
                if (codice_prestito[pos] == codice)
                {
                    break;
                }
                if(pos == codice_prestito.Length - 1)
                {
                    flag = true;
                }
            }

            if(flag)
            {
                Console.WriteLine("Codice non presente");
                Console.ReadKey();
                return;
            }





            //Prestito restituito si/no menu

            ConsoleKeyInfo key;
            int pos3 = 0;
            do
            {
                Console.Clear();

                string[] strings =
                {
                "Nome: " + utenti_prestito_nome[pos],
                "Cognome: " + utenti_prestito_cognome[pos],
                "Libro: " + libro_prestito[pos],
                "Giorno preso: " + giorni_preso[pos],
                "Tempo trattenuto: " + tempo_trattenuto[pos],
                "Codice prestito: " + codice_prestito[pos],
                "Confermi la restituzione? "

                };

                int consoleWidth = Console.WindowWidth;
                for (int i = 0; i < strings.Length; i++)
                {
                    int padding = (consoleWidth - strings[i].Length) / 2;
                    if (padding < 0)
                    {
                        padding = 0;
                    }
                    Console.WriteLine(new string(' ', padding) + $"  {strings[i]}");
                }
                Menu(pos3);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (pos3 == 1)
                        pos3--;
                    
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if(pos3 == 0)
                        pos3++;
                }
            } while (key.Key != ConsoleKey.Enter);


            if (pos3 == 1)
            {
                Console.WriteLine("Azione annullata");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }
            else
            {
                //Restituzione libro
                libro_prestito[pos] = null;
                utenti_prestito_nome[pos] = null;
                utenti_prestito_cognome[pos] = null;
                giorni_preso[pos] = null;
                tempo_trattenuto[pos] = null;
                codice_prestito[pos] = 0;

                for (int i = pos; i < libro_prestito.Length - 1; i++)
                {
                    libro_prestito[i] = libro_prestito[i + 1];
                    utenti_prestito_nome[i] = utenti_prestito_nome[i + 1];
                    utenti_prestito_cognome[i] = utenti_prestito_cognome[i + 1];
                    giorni_preso[i] = giorni_preso[i + 1];
                    tempo_trattenuto[i] = tempo_trattenuto[i + 1];
                    codice_prestito[i] = codice_prestito[i + 1];
                }

                Array.Resize(ref libro_prestito, libro_prestito.Length - 1);
                Array.Resize(ref utenti_prestito_nome, utenti_prestito_nome.Length - 1);
                Array.Resize(ref utenti_prestito_cognome, utenti_prestito_cognome.Length - 1);
                Array.Resize(ref giorni_preso, giorni_preso.Length - 1);
                Array.Resize(ref tempo_trattenuto, tempo_trattenuto.Length - 1);
                Array.Resize(ref codice_prestito, codice_prestito.Length - 1);
                returns++;
                Console.WriteLine("Libro restituito con successo");

            }

            Console.ReadKey();
            return;


        }
    }
}
