using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            int[] copie = new int[2];


            //Quanti libri abbiamo nella biblioteca
            int libri_unici = 0;


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
                        if (libri_unici == Titoli.Length)
                        {
                            //Crea 5 array temporanei lunghi +1 rispetto a quelli originali
                            string[] TitoliTemp = new string[Titoli.Length + 1];
                            string[] AutoriTemp = new string[Autori.Length + 1];
                            double[] prezzoTemp = new double[prezzo.Length + 1];
                            string[] categoriaTemp = new string[categoria.Length + 1];
                            string[] casa_editriceTemp = new string[casa_editrice.Length + 1];
                            int[] copie_temp = new int[copie.Length + 1];

                            for (int i = 0; i < Titoli.Length; i++)
                            {
                                //Copia i valori degli array originali in quelli temporanei
                                TitoliTemp[i] = Titoli[i];
                                AutoriTemp[i] = Autori[i];
                                prezzoTemp[i] = prezzo[i];
                                categoriaTemp[i] = categoria[i];
                                casa_editriceTemp[i] = casa_editrice[i];
                                copie_temp[i] = copie[i];

                            }
                            //Aggiungi i nuovi valori, cosi da avere una casella in piu
                            Titoli = TitoliTemp;
                            Autori = AutoriTemp;
                            prezzo = prezzoTemp;
                            categoria = categoriaTemp;
                            casa_editrice = casa_editriceTemp;
                            copie = copie_temp;


                        }


                        Console.WriteLine("Inserisci il titolo del libro");
                        string titolo = Console.ReadLine();

                        //Bool per vedere se il libro é presente o meno
                        bool pres = false;

                        for(int i =0; i < Titoli.Length; i++)
                        {
                            if (Titoli[i] == null)
                            {
                                continue;
                            }
                            if (Titoli[i].ToLower() == titolo.ToLower())
                            {
                                copie[i]++;
                                Console.WriteLine("Il libro é gia presente nei nostri archivi, non servono le altre informazioni");
                                pres = true;
                                Console.ReadKey();
                                break;
                            }
                        }
                        
                        if(pres)
                        {
                            break;
                        }

                        Titoli[libri_unici] = titolo;

                        Console.WriteLine("Inserisci l'autore del libro");
                        Autori[libri_unici] = Console.ReadLine();

                        Console.WriteLine("Inserisci il prezzo");
                        prezzo[libri_unici] = double.Parse(Console.ReadLine());

                        Console.WriteLine("Inserisci la categoria");
                        categoria[libri_unici] = Console.ReadLine();

                        Console.WriteLine("Inserisci la casa editrice");
                        casa_editrice[libri_unici] = Console.ReadLine();

                        //Aumento libri unici
                        libri_unici++;

                        Console.WriteLine("Libro aggiunto con successo");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("i libri presenti nella biblioteca sono");
                        for (int i = 0;i < Titoli.Length;i++)
                        {
                            Console.WriteLine($"il titolo del libro è:{Titoli[i] + "\t" + copie[i]}");
                            Console.WriteLine($"L'autore/i del libro sono/è:{Autori[i]}");
                            Console.WriteLine($"il prezzo del libro è:{prezzo[i]}");
                            Console.WriteLine($"la categoria del libro è:{categoria[i]}");
                            Console.WriteLine($"la casa editrice del libro è:{casa_editrice[i]}");                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        break;

                    case 4:
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
                                if (Autori[i].ToLower() == autori_unici[j].ToLower())
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
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(autori_unici[i]);
                            }
                            else
                            {
                                Console.Write("\t" + autori_unici[i]);
                            }

                        }

                        Console.ReadKey();

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
