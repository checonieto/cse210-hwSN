using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
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
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }

            int i = 1;
            foreach (var goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetProgress()} {goal.GetName()} ({goal.GetDescription()})");
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
                        var simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (parts.Length > 4 && bool.Parse(parts[4])) simple.RecordEvent();
                        _goals.Add(simple);
                        break;
                    case "EternalGoal":
                        var eternal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (parts.Length > 4) 
                        {
                            for (int j = 0; j < int.Parse(parts[4]); j++)
                                eternal.RecordEvent();
                        }
                        _goals.Add(eternal);
                        break;
                    case "ChecklistGoal":
                        var checklist = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), 
                            int.Parse(parts[6]), int.Parse(parts[7]));
                        if (bool.Parse(parts[4])) checklist.RecordEvent();
                        for (int j = 0; j < int.Parse(parts[5]); j++)
                            checklist.RecordEvent();
                        _goals.Add(checklist);
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
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record.");
                return;
            }

            ListGoals();
            Console.Write("Which goal did you complete? ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
            {
                int earned = _goals[index-1].RecordEvent();
                _score += earned;
                Console.WriteLine($"Points earned: {earned}");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
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
