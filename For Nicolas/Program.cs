using System;

namespace For_Nicolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте, вас приветствует программа определения степени вашего погружения в игру");
            Console.Write("\n\tКак вас зовут?: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте {Name}");
            Console.ReadKey();
            Console.Write("\tСколько вам лет?: ");
            string Age = Console.ReadLine();
            Console.ReadKey();
            Console.Write("\tНравится ли вам Titan quest?: ");
            string Way = Console.ReadLine();
            Console.ReadKey();
            Console.Write("\tВо сколько вам сегодня удобно поиграть?: ");
            string Time = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Нравится ли Titan quest: {Way}");
            Console.WriteLine($"Время сегодня: {Time}");
            Console.Write("\tУуууу задрот");
        }
    }
}
