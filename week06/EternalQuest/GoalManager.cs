// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;
using EternalQuest.Goals;


namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<EternalQuest.Goals.Goal>();
        private int _score = 0;

        public void CreateNewGoal()
        {
            Console.WriteLine("Which type of goal?");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Eternal");
            Console.WriteLine("3. Checklist");
            Console.WriteLine("4. Negative");
            Console.Write("Select a number: ");
            string choice = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                case "4":
                    _goals.Add(new NegativeGoal(name, description, points));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void ListGoals()
        {
            int i = 1;
            foreach (var goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetProgress()} {goal.Name} ({goal.Description})");
                i++;
            }
        }

        public void SaveGoals()
        {
            Console.Write("Filename to save: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetSaveString());
                }
            }
            Console.WriteLine("Goals saved!");
        }

        public void LoadGoals()
        {
            Console.Write("Filename to load: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[6]), int.Parse(parts[7])));
                        break;
                    case "NegativeGoal":
                        _goals.Add(new NegativeGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                }
            }

            Console.WriteLine("Goals loaded!");
        }

        public void RecordEvent()
        {
            ListGoals();
            Console.Write("Which goal did you complete? ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < _goals.Count)
            {
                int earned = _goals[index].RecordEvent();
                _score += earned;
                Console.WriteLine($"Points earned: {earned}");
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Current Score: {_score}");
        }

        public void DisplayLevel()
        {
            string level = _score switch
            {
                < 100 => "Beginner",
                < 200 => "Intermediate",
                < 500 => "Advanced",
                _ => "Master"
            };
            Console.WriteLine($"Level: {level}");
        }
    }
}
