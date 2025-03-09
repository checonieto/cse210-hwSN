using System;

class Program
{
    static void Main()
    {
        // Prompt your first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt your last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the James Bond Format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
