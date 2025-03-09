using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message with a funny twist
        Console.WriteLine("Welcome to the *Mind-Reading Magic Number Game*!");
        Console.WriteLine("I have chosen a *secret magic number* between 1 and 100.");
        Console.WriteLine("Your mission, should you choose to accept it, is to guess the number!");
        Console.WriteLine("Don't worry, I'll give you hints like a helpful wizard. 🧙‍♂️");
        Console.WriteLine("Let's begin!\n");

        // Generate a random magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int attempts = 0; // This will track the number of guesses

        // Loop until the user guesses the correct number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess, brave adventurer? ");
            string input = Console.ReadLine();

            // Check if the input is a valid number
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Oops! That's not a number. Try again, I thought you were brave!");
                continue;
            }

            attempts++; // Increment the number of attempts

            // Provide hints
            if (magicNumber > guess)
            {
                Console.WriteLine("Nope, aim higher!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Too high! Come back down!");
            }
            else
            {
                // Celebrate when the user guesses correctly
                Console.WriteLine("\n YOU DID IT! I never doubt you");
                Console.WriteLine($"You found the magic number in {attempts} guesses!");
                Console.WriteLine("You are officially a *Number Wizard*! 🧙‍♀️✨");
            }

            // Add a funny message if the user takes too many guesses
            if (attempts > 10)
            {
                Console.WriteLine("Pro tip: Maybe try writing down your guesses? Just saying... ");
            }
        }

        // Farewell message
        Console.WriteLine("\nThanks for playing! Until next time, adventurer! ");
    }
}