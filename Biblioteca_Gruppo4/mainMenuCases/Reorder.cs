using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Cases
{
    internal class Reorder
    {
        public static void reorder(ref string[] Titoli, ref string[] Autori, ref double[] prezzo, ref string[] categoria, ref string[] casa_editrice, ref int[] copie)
        {
            Console.Clear();
            Console.WriteLine("Scegli come riordinare");
            Console.WriteLine("[1] Crescente \t [2] Decrescente");
            int scelta;
            try
            {
                scelta = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: Inserire un numero valido");
                Console.ReadKey();
                return;
            }

            if(scelta != 1 && scelta != 2)
            {
                Console.WriteLine("Errore: Inserire un numero valido");
                Console.ReadKey();
                return;
            }

            if (scelta == 1)
            {
                for(int i = 0; i < prezzo.Length-1; i++)
                {
                    for (int j = i + 1; j < prezzo.Length; j++)
                    {
                        if (prezzo[i] > prezzo[j])
                        {

                            string temp = Titoli[i];
                            Titoli[i] = Titoli[j];
                            Titoli[j] = temp;

                            temp = Autori[i];
                            Autori[i] = Autori[j];
                            Autori[j] = temp;

                            double temp2 = prezzo[i];
                            prezzo[i] = prezzo[j];
                            prezzo[j] = temp2;

                            temp = categoria[i];
                            categoria[i] = categoria[j];
                            categoria[j] = temp;

                            temp = casa_editrice[i];
                            casa_editrice[i] = casa_editrice[j];
                            casa_editrice[j] = temp;

                            int temp3 = copie[i];
                            copie[i] = copie[j];
                            copie[j] = temp3;
                        }
                    }
                }
            }else
            {
                for (int i = 0; i < prezzo.Length - 1; i++)
                {
                    for (int j = i + 1; j < prezzo.Length; j++)
                    {
                        if (prezzo[i] < prezzo[j])
                        {

                            string temp = Titoli[i];
                            Titoli[i] = Titoli[j];
                            Titoli[j] = temp;

                            temp = Autori[i];
                            Autori[i] = Autori[j];
                            Autori[j] = temp;

                            double temp2 = prezzo[i];
                            prezzo[i] = prezzo[j];
                            prezzo[j] = temp2;

                            temp = categoria[i];
                            categoria[i] = categoria[j];
                            categoria[j] = temp;

                            temp = casa_editrice[i];
                            casa_editrice[i] = casa_editrice[j];
                            casa_editrice[j] = temp;

                            int temp3 = copie[i];
                            copie[i] = copie[j];
                            copie[j] = temp3;
                        }
                    }
                }
            }

            Console.WriteLine("Libri riordinati con successo. Premere un tasto per continuare");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Indice  - Titolo - Autore - Prezzo - Categoria - Casa Editrice - Copie");
            for (int  i = 0;  i < Titoli.Length;  i++)
            {
                Console.WriteLine($"{i+1} - {Titoli[i]} - {Autori[i]} - {prezzo[i]} - {categoria[i]} - {casa_editrice[i]} - x{copie[i]}");
            }

            Console.ReadKey();
            return;
        }
    }
}
