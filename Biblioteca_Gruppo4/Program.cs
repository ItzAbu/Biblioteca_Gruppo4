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
                        //Se abbiamo raggiunto il massimo
                        if (libri == Titoli.Length)
                        {
                            //Crea 5 array temporanei lunghi +1 rispetto a quelli originali
                            string[] TitoliTemp = new string[Titoli.Length + 1];
                            string[] AutoriTemp = new string[Autori.Length + 1];
                            double[] prezzoTemp = new double[prezzo.Length + 1];
                            string[] categoriaTemp = new string[categoria.Length + 1];
                            string[] casa_editriceTemp = new string[casa_editrice.Length + 1];

                            for (int i = 0; i < Titoli.Length; i++)
                            {
                                //Copia i valori degli array originali in quelli temporanei
                                TitoliTemp[i] = Titoli[i];
                                AutoriTemp[i] = Autori[i];
                                prezzoTemp[i] = prezzo[i];
                                categoriaTemp[i] = categoria[i];
                                casa_editriceTemp[i] = casa_editrice[i];

                            }
                            //Aggiungi i nuovi valori, cosi da avere una casella in piu
                            Titoli = TitoliTemp;
                            Autori = AutoriTemp;
                            prezzo = prezzoTemp;
                            categoria = categoriaTemp;
                            casa_editrice = casa_editriceTemp;

                            //Aumenta il contatore dei libri
                            libri++;
                        }


                        Console.WriteLine("Inserisci il titolo del libro");
                        Titoli[libri] = Console.ReadLine();

                        Console.WriteLine("Inserisci l'autore del libro");
                        Autori[libri] = Console.ReadLine();

                        Console.WriteLine("Inserisci il prezzo del libro");
                        prezzo[libri] = double.Parse(Console.ReadLine());

                        Console.WriteLine("Inserisci la categoria del libro");
                        categoria[libri] = Console.ReadLine();

                        Console.WriteLine("Inserisci la casa editrice del libro");
                        casa_editrice[libri] = Console.ReadLine();


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
