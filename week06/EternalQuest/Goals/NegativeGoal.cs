// NegativeGoal.cs
namespace EternalQuest.Goals
{
    public class NegativeGoal : Goal
    {
        public bool IsCompleted { get; set; }

        public NegativeGoal(string name, string description, int points) : base(name, description, points)
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
                return -Points; // Deduct points
            }
            return 0;
        }

        public override string GetSaveString()
        {
            return $"NegativeGoal|{Name}|{Description}|{Points}|{IsCompleted}";
        }
    }
}
