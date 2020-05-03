using System;

namespace Fun_With_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int counter = 5;

            while(counter < 25)
            {
                counter++;
                userInput = Console.ReadLine();
            }
        }
    }
}
