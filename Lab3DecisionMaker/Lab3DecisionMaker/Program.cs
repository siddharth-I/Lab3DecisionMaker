using System;

namespace Lab3DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer between 1 and 100.");

            string input = Console.ReadLine();

            int parsedInput = int.Parse(input);

            int remainder = parsedInput % 2;

            if (remainder == 1)
            {
                if (parsedInput > 60)
                {
                    Console.WriteLine(parsedInput + ". Odd and greater than 60.");
                }
                else
                {
                    Console.WriteLine(parsedInput + " and odd.");
                }
            }
            else if (remainder == 0 && (2 <= parsedInput) && (parsedInput <= 25))
            {
                Console.WriteLine("Even and less than 25.");
            }
            else if (remainder == 0 && (26 <= parsedInput && parsedInput <= 60))
            {
                Console.WriteLine("Even.");
            }
            else if (remainder == 0 && (parsedInput > 60))
            {
                Console.WriteLine(parsedInput + " and even.");
            }
        }
    }
}
