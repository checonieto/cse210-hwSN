//Memorizing my favorite scripture
using System;

class Program
{
    static void Main(string[] args)
    {
        // Challenge
        
        Reference reference = new Reference("Alma", 37, 33);
        Scripture scripture = new Scripture(reference, "Preach unto them repentance, and faith on the Lord Jesus Christ; teach them to humble themselves and to be meek and lowly in heart; teach them to withstand every temptation of the devil, with their faith on the Lord Jesus Christ.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("Hello, This is Sergio Nieto, I challenge you to memorize my favorite scripture\n");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}