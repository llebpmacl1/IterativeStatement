using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 100");

            int entry = 0;
            string input = Console.ReadLine();
            int user_input = int.Parse(input);
            while (entry < user_input)
            {
                entry += 1;
                Console.WriteLine("You have entered " + user_input + ". The current integer value in the loop:" + entry);
            }

            

            

        }
    }
}
