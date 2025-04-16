// Program.cs
using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            string choice = "";

            while (choice != "7")
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Display Score and Level");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.CreateNewGoal();
                        break;
                    case "2":
                        manager.ListGoals();
                        break;
                    case "3":
                        manager.SaveGoals();
                        break;
                    case "4":
                        manager.LoadGoals();
                        break;
                    case "5":
                        manager.RecordEvent();
                        break;
                    case "6":
                        manager.DisplayScore();
                        manager.DisplayLevel();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
