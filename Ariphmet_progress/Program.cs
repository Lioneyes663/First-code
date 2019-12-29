using System;

namespace Ariphmet_progress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия будет начинаться с 1 и будет не больше 1000");
            Console.WriteLine("Введите первые два числа арифметической прогрессии и число которое нужно найти");
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = b - a;
            int z = 0;
            int[] n = new int[1000];
            n[0] = a;
            for (;n[z++] < 1000;)
            {
                n[z] = n[z] + d;
            }
            Console.WriteLine("Введите номер числа в прогрессии который вы хотите узнать");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n[c]}");
        }
    }
}
