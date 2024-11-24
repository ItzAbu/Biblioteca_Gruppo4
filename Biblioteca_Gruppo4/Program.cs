using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Gruppo4.Cases;
using Biblioteca_Gruppo4.mainMenuWithArrows;
using Biblioteca_Gruppo4.menuPrestiti;

namespace Biblioteca_Gruppo4
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Gestione Libri

            string[] Titoli = new string[2];
            string[] Autori = new string[2];
            double[] prezzo = new double[2];
            string[] categoria = new string[2];
            string[] casa_editrice = new string[2];
            int[] copie = new int[2];

            //Gestione Prestiti

            int prestiti = 0;
            string[] libri_prestito = new string[2];
            string[] utenti_prestito_nome = new string[2];
            string[] utenti_prestito_cognome = new string[2];
            string[] giorno_preso = new string[2];
            string[] tempo_trattenuto = new string[2];
            int[] codice_prestito = new int[2];
            int retuns = 0;



            //Quanti libri abbiamo nella biblioteca
            int libri_unici = 0;
            int libri_unici_copia = 0;
            


            //Menu
            while (true)
            {
                Console.Clear();

                //Menu con le freccie
                int scelta = MenuArrow.menuArrow();

                switch (scelta)
                {
                    case 1:
                        
                        AddBook.addBook(ref Titoli, ref Autori, ref prezzo, ref categoria, ref casa_editrice, ref copie, ref libri_unici, ref libri_unici_copia);

                        break;

                    case 2:
                        
                        ShowBook.showBook(Titoli, copie);

                        break;

                    case 3:
                        
                        RemoveBook.removeBook(ref Titoli, ref Autori, ref prezzo, ref categoria, ref casa_editrice, ref copie, ref libri_unici, ref libri_unici_copia);

                        break;

                    case 4:
                        
                        SearchByAuthor.searchByAuthor(Titoli, Autori, copie);

                        break;
                    case 5:
                        
                        MostExpeBook.mostExpeBook(Titoli, prezzo);

                        break;

                    case 6:

                        Reorder.reorder(ref Titoli, ref Autori, ref prezzo, ref categoria, ref casa_editrice, ref copie);

                        break;

                    case 7:

                        PriceRange.priceRange(Titoli, prezzo, copie);

                        break;

                    case 8:
                        
                        MenuPrestiti.menuPrestiti(Titoli, Autori, prezzo, categoria, casa_editrice, copie, ref libri_unici_copia , ref prestiti, ref libri_prestito, 
                            ref utenti_prestito_nome, ref utenti_prestito_cognome, ref giorno_preso, ref tempo_trattenuto, ref codice_prestito, ref retuns);

                        break;

                    case 9:

                        Console.Clear();
                        Console.WriteLine("Arrivederci!");
                        Console.ReadKey();

                        return;
                }

            }



        }
    }
}
