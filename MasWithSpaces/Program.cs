using System;

namespace MasWithSpaces
{
    class Program
    {
        static bool isPalindrome1(string[] array)
        {
            bool answer = true;
            int k = array.Length / 2;
            for (int i = 0; i <= k; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    answer = false;
                    break;
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            string array;
            Console.WriteLine("\tВведите элементы (числа) массива-палиндрома через пробел");
            array = new string(Console.ReadLine());
            string[] b = array.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(isPalindrome1(b));
        }
    }
}
