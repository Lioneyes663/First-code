using System;

namespace Third_code
{
    class Program
    {
        static void Main(string[] args)
        {
            bool firstPhrase;
            bool secondPhrase;
            int test1TrueOrFalse;
            int test2TrueOrFalse;
            int goodAnswers;
            Console.WriteLine("Hello! Today we got math again");
            Console.Write("Answer the question is 6>5, say true or false: ");
            firstPhrase = Convert.ToBoolean(Console.ReadLine());
            Console.Write("So.Ok. And is 10>15?: ");
            secondPhrase = Convert.ToBoolean(Console.ReadLine());
            if (firstPhrase == true)
            {
                Console.WriteLine("First answer is right good job");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I have a bad news about ur answer");
                Console.ReadKey();
            }
            if (secondPhrase == false)
            {
                Console.WriteLine("Your second answer was good too");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("I have a bad news about ur second answer");
                Console.ReadKey();
            }
            if (firstPhrase == true && secondPhrase == false)
            {
                Console.WriteLine("\nYour answers was right");
                Console.WriteLine("\nCount the number of correct answers");
                Console.ReadKey();
            }
            if (firstPhrase == true)
            {
                test1TrueOrFalse = 1;
            }
            else
            {
                test1TrueOrFalse = 0;
            }
            if (secondPhrase == false)
            {
                test2TrueOrFalse = 1;
            }
            else
            {
                test2TrueOrFalse = 0;
            }
            goodAnswers = test1TrueOrFalse + test2TrueOrFalse;
            Console.WriteLine($"\tYou have a {goodAnswers} right answers, congratulations!");
        }
    }
}
