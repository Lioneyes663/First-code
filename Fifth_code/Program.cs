using System;

namespace Fifth_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string c;
            string d;
            string[] phrase = {"a", "b", "c", "d" };
            Console.Write("\nВведите палиндром из 4 слов, по словам: ");
            a = Console.ReadLine();
            Console.Write("\nВведите второе слово: ");
            b = Console.ReadLine();
            Console.Write("\nВведите третье слово: ");
            c = Console.ReadLine();
            Console.Write("\nВведите четвертое слово: ");
            d = Console.ReadLine();

            int n = phrase.Length;
            int k = n / 2;
            int temp;
            for (int i = 0; i < k; i++) ;
            {
                temp = phrase[i];
                phrase[i] = phrase[n - i - 1];
                phrase[n - i - 1] = temp;
            }
            foreach (string i in phrase)
            {
                Console.WriteLine("\nЕсли вы видите фразу перевёрнутую то вы ввели палиндром");
                Console.WriteLine($"{d} {c} {b} {a} \t");
            }


        }
    }
}
