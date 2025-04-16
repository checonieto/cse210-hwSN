using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("* Welcome to the *Number Squaring Game*! *");
        Console.WriteLine("This program will take your favorite number, and tell you its square!");
        Console.WriteLine("I know a calculator can do this but I need to pass this class!\n");
    }

    static string PromptUserName()
    {
        Console.Write("First things first, what's your name? ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Mysterious Stranger"; // Default name if the user doesn't enter one
            Console.WriteLine("Hmm, no name? Alright, we'll call you 'Mysterious Stranger' for now.\n");
        }
        else
        {
            Console.WriteLine($"Nice to meet you, {name}!\n");
        }

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Now, what's your favorite number? ");
        string input = Console.ReadLine();

        int number;
        while (!int.TryParse(input, out number))
        {
            Console.WriteLine("Wait a minute... that doesn't look like a number. Try again!");
            Console.Write("What's your favorite number? ");
            input = Console.ReadLine();
        }

        Console.WriteLine($"Great choice! {number} is a fantastic number.\n");
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine{name}, the square of your number is {square}! *";
        Console.WriteLine("Thanks for playing! You're now officially a math wizard");
    }
}