using System;

namespace IsPalindrome
{
    class Program
    { 
        static void Main(string[] args)
        {
            int i;
            bool p = true;
            Console.WriteLine("\tВведите длину массива");
            int k = Convert.ToInt32 (Console.ReadLine());
            int[] aMasInt = new int[k];
            i = 0;
            Console.WriteLine("\tВведите элементы массива");
            do
            {
                aMasInt [i] = Convert.ToInt32 (Console.ReadLine());
                i = i + 1;
            }
            while (i < aMasInt.Length);
            int temp;
            int temp2;
            int o = aMasInt.Length / 2;
            for (i = 0; i <= o ; i++)
            {
                temp = aMasInt[i];
                temp2 = aMasInt[aMasInt.Length - 1 - i];
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
