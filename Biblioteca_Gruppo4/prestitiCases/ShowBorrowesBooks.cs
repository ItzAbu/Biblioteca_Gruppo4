using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.prestitiCases
{
    internal class ShowBorrowesBooks
    {
        public static void showBorrowedBooks(string[] libri_prestito, string[] utenti_prestito_nome, string[] utenti_prestito_cognome, string[] giorni_preso, string[] tempo_trattenuto, int[] codice_prestito, int prestiti)
        {
            Console.Clear();
            Console.WriteLine("Prestiti:");
            for (int i = 0; i < prestiti; i++)
            {
                if(libri_prestito.Length <= i)
                {
                    break;
                }
                Console.WriteLine("Codice prestito: " + codice_prestito[i]);
                Console.WriteLine($"\tLibro: {libri_prestito[i]}");
                Console.WriteLine($"\tUtente: {utenti_prestito_nome[i]} {utenti_prestito_cognome[i]}");
                Console.WriteLine($"\tGiorno preso: {giorni_preso[i]}");
                Console.WriteLine($"\tTempo trattenuto: {tempo_trattenuto[i]}");
                Console.WriteLine();
            }
            Console.WriteLine("Premi un tasto per tornare al menu");
            Console.ReadKey();
        }
    }
}
