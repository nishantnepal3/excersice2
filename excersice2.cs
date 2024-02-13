using System;

class Program
{
    static void Main()
    {
        Console.Write(" Please enter a whole number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            // Checking if the number is positive, negative, or zero
            if (number > 0)
            {
                Console.Write("The given number is positive");
            }
            else if (number < 0)
            {
                Console.Write("The given number is negative");
            }
            else
            {
                Console.Write("The given number is zero");
            }

            // Check if the number is odd or even
            if (number % 2 == 0)
            {
                Console.WriteLine(" and even.");
            }
            else
            {
                Console.WriteLine(" and odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
