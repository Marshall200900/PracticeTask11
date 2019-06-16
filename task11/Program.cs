using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            int n = Inputs.Int("Введите количество сдвигов: ", 0);
            string encoded = Encrypter.Encrypt(text, n);
            Console.WriteLine("Закодированная строка: " + encoded);
            string decoded = Encrypter.Decrypt(encoded, n);
            Console.WriteLine("Раскодированная строка: " + decoded);
            Console.ReadKey();
        }
    }
}
