using System;
using System.IO;
using System.Collections.Generic;
using EternalQuest.Goals;
using EternalQuest.User;

namespace EternalQuest.Utilities
{
    public class FileHandler
    {
        public void SaveGoals(UserProfile userProfile, string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Save total points first
                outputFile.WriteLine(userProfile.GetTotalPoints());
                
                // Save each goal
                foreach (Goal goal in userProfile.GetGoals())
                {
                    outputFile.WriteLine(goal.GetSaveString());
                }
            }
        }

        public void LoadGoals(UserProfile userProfile, string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The specified file does not exist.");
            }

            string[] lines = File.ReadAllLines(filename);
            
            if (lines.Length == 0)
                return;

            // First line is total points
            if (int.TryParse(lines[0], out int totalPoints))
            {
                userProfile.Reset();
                userProfile.AddPoints(totalPoints);
            }

            // Remaining lines are goals
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string goalType = parts[0];
                Goal goal = null;

                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (bool.Parse(parts[4])) goal.RecordEvent();
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        for (int j = 0; j < int.Parse(parts[4]); j++) goal.RecordEvent();
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(
                            parts[1], parts[2], int.Parse(parts[3]), 
                            int.Parse(parts[6]), int.Parse(parts[7]));
                        for (int j = 0; j < int.Parse(parts[5]); j++) goal.RecordEvent();
                        break;
                    case "NegativeGoal":
                        goal = new NegativeGoal(parts[1], parts[2], int.Parse(parts[3]));
                        break;
                }

                if (goal != null)
                {
                    userProfile.AddGoal(goal);
                }
            }
        }
    }
}