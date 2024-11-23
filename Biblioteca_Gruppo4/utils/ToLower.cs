using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Gruppo4.Utils
{
    internal class ToLower
    {
        public static string ToLowerString(string str)
        {
            //Converte la stringa in minuscolo
            string lower = "";
            for(int i = 0; i < str.Length; i++)
            {
                //Se è una lettera maiuscola e solo in caso positivo la trasforma in minuscolo
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    lower += str[i].ToString().ToLower();
                }
                else
                {
                    lower += str[i];
                }
                
            }
            return lower;
        }
    }
}
