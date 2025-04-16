using System;

namespace EternalQuest.Goals
{
    public abstract class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }

        public Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public abstract string GetProgress();
        public abstract int RecordEvent(); 
        public abstract string GetSaveString();
    }
}
