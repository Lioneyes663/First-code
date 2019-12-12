using System;

namespace Fifth_code
{
    class Program
    {
        static bool IsPolindrome(string phrase)
        {
            int n = phrase.Length-1;
            string temp = "";
            for (; n >= 0; n--)
            {
                temp = temp + phrase[n];
            }
            return phrase == temp;
        }
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            Console.WriteLine(IsPolindrome(a));
        }
    }
}
