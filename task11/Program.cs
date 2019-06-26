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
            Console.WriteLine("Задача №11 (835)\n" +
                "Зашифровать и расшифровать текст, сдвинув каждую букву на N позиций, \n" +
                "причем буква я заменяется на букву а.");
            Console.Write("Введите текст: \n");
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
