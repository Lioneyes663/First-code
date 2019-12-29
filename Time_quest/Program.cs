using System;

namespace Time_quest
{
    class Program
    {
        static void Main(string[] args)
        {
            int chPribitie;
            int minPribitie;
            Console.WriteLine("Введите время отправления и время в пути по форме xx , yy где хх часы а yy минуты для отправления и времени в пути");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            int min1 = Convert.ToInt32(Console.ReadLine());
            int ch2 = Convert.ToInt32(Console.ReadLine());
            int min2 = Convert.ToInt32(Console.ReadLine());
            for (;ch1 > 23 & ch2 > 23;)
            {
                Console.WriteLine("Часы можно указывать только в формате от 00 до 23");
                return;
            }
            for (; min1 > 59 & min2 > 59;)
            {
                Console.WriteLine("Минуты можно указывать только в формате от 00 до 59");
                return;
            }
            chPribitie = ch1 + ch2;
            if (chPribitie > 23)
            {
                chPribitie = chPribitie - 24;
            }
            minPribitie = min1 + min2;
            if (minPribitie > 59)
            {
                minPribitie = minPribitie - 60;
            }
            Console.WriteLine($"Время вашего прибытия {chPribitie}ч:{minPribitie}мин");
        }
    }
}
