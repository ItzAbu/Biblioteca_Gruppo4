using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Cases
{
    internal class RemoveBook
    {
        public static void removeBook(ref string[] Titoli, ref string[] Autori, ref double[] prezzo, ref string[] categoria, ref string[] casa_editrice, ref int[] copie, ref int libri_unici, ref int libri_unici_copia)
        {
            Console.Clear();
            Console.WriteLine("Elenco dei libri, decidi quale libro vuoi eliminare in base al numero");
            for (int i = 0; i < Titoli.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {Titoli[i]} x{copie[i]}");
            }

            Console.WriteLine("Seleziona il libro da eliminare, scegli il numero");
            int lettura;
            try
            {
                lettura = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Scelta errata");
                Console.ReadKey();
                return;
            }


            if (copie[lettura - 1] > 1)
            {
                copie[lettura - 1]--;

                Console.WriteLine("Copia eliminata con successo");
                Console.ReadKey();
                Console.Clear();
                return;

            }
            Titoli[lettura - 1] = "";
            Autori[lettura - 1] = "";
            prezzo[lettura - 1] = 0;
            categoria[lettura - 1] = "";
            casa_editrice[lettura - 1] = "";
            copie[lettura - 1] = 0;

            for (int i = lettura - 1; i < Titoli.Length - 1; i++)
            {
                string temp;
                int tempint;
                double tempdouble;

                temp = Titoli[i + 1];
                Titoli[i] = temp;

                temp = Autori[i + 1];
                Autori[i] = temp;

                tempdouble = prezzo[i + 1];
                prezzo[i] = tempdouble;

                temp = categoria[i + 1];
                categoria[i] = temp;

                temp = casa_editrice[i + 1];
                casa_editrice[i] = temp;

                tempint = copie[i + 1];
                copie[i] = tempint;
            }

            //Resize degli array
            Array.Resize(ref Titoli, Titoli.Length - 1);
            Array.Resize(ref Autori, Autori.Length - 1);
            Array.Resize(ref prezzo, prezzo.Length - 1);
            Array.Resize(ref categoria, categoria.Length - 1);
            Array.Resize(ref casa_editrice, casa_editrice.Length - 1);
            Array.Resize(ref copie, copie.Length - 1);

            libri_unici--;
            libri_unici_copia--;

            Console.Clear();
            Console.WriteLine("Il libro e stato eliminato");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
