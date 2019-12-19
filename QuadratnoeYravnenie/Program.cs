using System;

namespace QuadratnoeYravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            Console.WriteLine("Введите коэффициенты квадратного уравнения: ax*x+bx+c=k");
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("k=");
            double k = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Нет решения");
                return;
            }
            if (b == 0 && c == 0 && k != 0)
            {
                x1 = Math.Sqrt(k / a);
                x2 = -Math.Sqrt(k / a);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }            
            Console.WriteLine($"{x1} , {x2}");
        }
    }
}
