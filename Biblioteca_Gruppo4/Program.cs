using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4
{
    internal class Program
    {

        public static void Menu()
        {
            //Menu
            Console.WriteLine("[1] Inserisci un libro");
            Console.WriteLine("[2] Consulta tutti i libri della biblioteca");
            Console.WriteLine("[3] Rimuovi un libro");
            Console.WriteLine("[4] Ricerca libri per autore");
            Console.WriteLine("[5] Stampa libro piú costoso");
            Console.WriteLine("[6] Ordina i libri in base al prezzo");
            Console.WriteLine("[7] Stampa i libri per fascia di prezzo");
            Console.WriteLine("[8] Esci");
        }

        static void Main(string[] args)
        {

            string[] Titoli = new string[2];
            string[] Autori = new string[2];
            double[] prezzo = new double[2];
            string[] categoria = new string[2];
            string[] casa_editrice = new string[2];


            //Quanti libri abbiamo nella biblioteca
            int libri = 0;


            //Menu
            while(true)
            {
                Console.Clear();
                Menu();

                //Scelta
                int scelta = int.Parse(Console.ReadLine());

                switch(scelta)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;
                }

            }



        }
    }
}
