// SimpleGoal.cs
namespace EternalQuest.Goals
{
    public class SimpleGoal : Goal
    {
        public bool IsCompleted { get; set; }

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            IsCompleted = false;
        }

        public override string GetProgress()
        {
            return IsCompleted ? "[X]" : "[ ]";
        }

        public override int RecordEvent()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                return Points;
            }
            return 0;
        }

        public override string GetSaveString()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}|{IsCompleted}";
        }
    }
}
