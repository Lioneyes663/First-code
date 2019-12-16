using System;

namespace MasWithSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string aStartMas;
            string bAfterMas;
            int i = 0;
            bool p = true;
            Console.WriteLine("\tВведите элементы (числа) массива-палиндрома через пробел");
            string a = new string(Console.ReadLine());
            string[] b = a.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            int k = a.Length / 2;
            for (i = 0; i <= k; i++)
            {
                aStartMas = b[i];
                bAfterMas = b[b.Length - 1 - i];
                if (aStartMas != bAfterMas)
                {
                    p = false;
                    break; 
                }
            }
            Console.WriteLine($"\t{p}"); 
        }
    }
}
