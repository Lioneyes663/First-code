using System;

namespace Third_code
{
    class Program
    {
        static void Main(string[] args)
        {
            bool firstPhrase;
            int testTrueOrFalse;
            Console.WriteLine("Hello! Today we got math again");
            Console.Write("Answer the question is 6>5, say true or false: ");
            firstPhrase = Convert.ToBoolean(Console.ReadLine());
            if (firstPhrase == true)
            {
                Console.WriteLine("First answer is right, good job");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I have a bad news about ur answer");
                Console.ReadKey();
            }
            if (firstPhrase == true)
            {
                testTrueOrFalse = 1;
            }
            else
            {
                testTrueOrFalse = 0;
            }
            Console.Write("So.Ok. And is 10>15?: ");
            firstPhrase = Convert.ToBoolean(Console.ReadLine());
            if (firstPhrase == false)
            {
                Console.WriteLine("Your second answer was good");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I have a bad news about ur second answer");
                Console.ReadKey();
            }
            if (firstPhrase == false)
            {
                testTrueOrFalse = testTrueOrFalse +1;
            }
            else
            {
                testTrueOrFalse = testTrueOrFalse +0;
            }
            if (testTrueOrFalse > 1)
            {
                Console.WriteLine("\nYour answers was right, сongratulations!");
                Console.WriteLine("\nCount the number of correct answers");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nTry to learn math more");
                Console.WriteLine("\nCount the number of correct answers");
                Console.ReadKey();
            }
            Console.WriteLine($"\tYou have a {testTrueOrFalse} right answers, ");
        }
    }
}