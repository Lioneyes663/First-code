using System;

namespace Second_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string education;
            double height;
            int easy;
            int mid;
            int x;
            Console.Write("Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("\nВаш возраст: ");
            age = Console.ReadLine();
            Console.Write("\nВаше образование:");
            education = Console.ReadLine();
            Console.Write("\nВаш рост: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\n{name} \nВозраст: {age} \nРост: {height} \nОбразование:{education}");
            Console.ReadKey();
            Console.Write("Решите простое уровнение: 5+5= ");
            easy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Правильный ответ 10, а ваш ответ {easy}");
            Console.Write("Теперь что нибудь посложнее например: 5*5= ");
            mid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Правильный ответ 25, а ваш ответ {mid}");
            Console.WriteLine("А что будет если вычесть из второго ответа первый?");
            Console.ReadKey();
            x = mid - easy;
            Console.WriteLine($"Если высветится 15 то вы молодец \n{x}");
            Console.ReadKey();
        }
    }
}
