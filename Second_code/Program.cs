using System;

namespace Second_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваше имя: ");
            string Name = Console.ReadLine();
            Console.Write("\nВаш возраст: ");
            string Age = Console.ReadLine();
            Console.Write("\nВаше образование:");
            string Education = Console.ReadLine();
            Console.Write("\nВаш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\n{Name} \nВозраст: {Age} \nРост: {height} \nОбразование:{Education}");
            Console.ReadKey();
            Console.Write("Решите простое уровнение: 5+5= ");
            int easy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Правильный ответ 10, а ваш ответ {easy}");
            Console.Write("Теперь что нибудь посложнее например: 5*5= ");
            int mid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Правильный ответ 25, а ваш ответ {mid}");
            Console.WriteLine("А что будет если вычесть из второго ответа первый?");
            Console.ReadKey();
            int x = mid - easy;
            Console.WriteLine($"Если высветится 15 то вы молодец \n{x}");
            Console.ReadKey();
        }
    }
}
