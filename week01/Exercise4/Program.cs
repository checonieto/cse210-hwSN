using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine(" Welcome to the *Number Wizard* program! ");
        Console.WriteLine("I'm here to help you calculate the sum, average, and max of your numbers.");
        Console.WriteLine("Enter as many numbers as you'd like, and type 0 when you're done.\n");

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (or 0 to finish): ");
            string userResponse = Console.ReadLine();

            // Check if the input is a valid number
            if (!int.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("Oops! That's not a number. Try again!\n");
                continue;
            }

            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                Console.WriteLine($"Got it! Added {userNumber} to the list.\n");
            }
        }

        // If no numbers were entered, exit the program
        if (numbers.Count == 0)
        {
            Console.WriteLine("\nYou didn't enter any numbers. Are you trying to break my magic? ");
            Console.WriteLine("Goodbye for now! ");
            return;
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"\n The sum of your numbers is: {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of your numbers is: {average:F2}");

        // Part 3: Find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($" The largest number you entered is: {max}");

        // Fun farewell message
        Console.WriteLine("\nThanks for playing with the *Number Wizard*!");
        Console.WriteLine("Until next time, keep crunching those numbers! ");
    }
}