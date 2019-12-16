using System;

namespace MasWithSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string aStartMas;
            string bAfterMas;
            string temp;
            string temp2;
            int i = 0;
            bool p = true;
            Console.WriteLine("\tВведите длину массива");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tВведите элементы массива через пробел");
            string a = new string(Console.ReadLine());
            string[] b = a.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            int k = d / 2;
            for (i = 0; i <= k; i++)
            {
                temp = b[i];
                temp2 = b[b.Length - 1 - i];
                if (temp != temp2)
                {
                    p = false;
                    break; 
                }
            }
            Console.WriteLine($"\t{p}"); 
        }
    }
}
