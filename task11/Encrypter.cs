using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    static class Encrypter
    {
        private const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string Encrypt(string str, int n)
        {
            char[] text = str.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < text.Length; k++)
                {
                    if (alphabet.Contains(text[k]))
                    {
                        if (text[k] == 'я')
                            text[k] = 'а';
                        else if (text[k] == 'Я')
                            text[k] = 'А';
                        else
                            text[k] = alphabet[Array.IndexOf(alphabet.ToCharArray(), text[k]) + 1];
                    }
                }
            }
            return new string(text);
        }
        public static string Decrypt(string str, int n)
        {
            char[] text = str.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < text.Length; k++)
                {
                    if (alphabet.Contains(text[k]))
                    {
                        if (text[k] == 'а')
                            text[k] = 'я';
                        else if (text[k] == 'А')
                            text[k] = 'Я';
                        else
                            text[k] = alphabet[Array.IndexOf(alphabet.ToCharArray(), text[k])-1];
                    }
                }
            }
            return new string(text);
        }
    }
}
