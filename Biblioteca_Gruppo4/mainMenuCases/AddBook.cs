﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Gruppo4.Utils;

namespace Biblioteca_Gruppo4.Cases
{
    internal class AddBook
    {
        static public void addBook(ref string[] Titoli, ref string[] Autori, ref double[] prezzo, ref string[] categoria, ref string[] casa_editrice, ref int[] copie, ref int libri_unici, ref int libri_unici_copia)
        {
            Console.Clear();
            //Se abbiamo raggiunto il massimo
            if (libri_unici == Titoli.Length)
            {
                //Resize degli array

                Array.Resize(ref Titoli, Titoli.Length + 1);
                Array.Resize(ref Autori, Autori.Length + 1);
                Array.Resize(ref prezzo, prezzo.Length + 1);
                Array.Resize(ref categoria, categoria.Length + 1);
                Array.Resize(ref casa_editrice, casa_editrice.Length + 1);
                Array.Resize(ref copie, copie.Length + 1);


            }


            Console.WriteLine("Inserisci il titolo del libro");
            string titolo = Console.ReadLine();

            //Libro gia presente o meno

            for (int i = 0; i < Titoli.Length; i++)
            {
                if (Titoli[i] == null)
                {
                    continue;
                }
                if (ToLower.ToLowerString(Titoli[i]) == ToLower.ToLowerString(titolo))
                {
                    copie[i]++;
                    Console.WriteLine("Il libro é gia presente nei nostri archivi, non servono le altre informazioni");
                    Console.ReadKey();
                    return;
                }
            }

            try{
                Titoli[libri_unici] = titolo;

                Console.WriteLine("Inserisci l'autore del libro");
                Autori[libri_unici] = Console.ReadLine();

                Console.WriteLine("Inserisci il prezzo");
                prezzo[libri_unici] = double.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci la categoria");
                categoria[libri_unici] = Console.ReadLine();

                Console.WriteLine("Inserisci la casa editrice");
                casa_editrice[libri_unici] = Console.ReadLine();

                copie[libri_unici] = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore, Qualcosa é andato storto");
                Console.ReadKey();
                Array.Resize(ref Titoli, Titoli.Length - 1);
                Array.Resize(ref Autori, Autori.Length - 1);
                Array.Resize(ref prezzo, prezzo.Length - 1);
                Array.Resize(ref categoria, categoria.Length - 1);
                Array.Resize(ref casa_editrice, casa_editrice.Length - 1);
                Array.Resize(ref copie, copie.Length - 1);
                return;
            }

            


            


            Console.WriteLine("Libro aggiunto con successo");
            Console.ReadKey();

            string[] strings =
            {
                $"Libro: ",
                Titoli[libri_unici],
                $"Autore: ",
                Autori[libri_unici],
                $"Prezzo: ",
                prezzo[libri_unici].ToString(),
                $"Categoria: ",
                categoria[libri_unici],
                $"Casa Editrice",
                casa_editrice [libri_unici],
                
            };

            Console.Clear();
            int padding = 15;

            for(int i=0; i < strings.Length; i+=2)
            {
                
                Console.Write(new string(' ', padding) + strings[i]);
                int padding2 = Console.WindowHeight - (padding - strings[i].Length)/2;

                Console.Write(new string(' ', padding2-i) + strings[i+1]);

                if(i == 4)
                {
                    Console.Write(" Eur");
                }
                Console.WriteLine();
            }

            //Aumento libri unici
            libri_unici++;
            libri_unici_copia++;

            Console.ReadKey();
            return;
        }
    }
}
