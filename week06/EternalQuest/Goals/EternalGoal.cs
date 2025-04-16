// EternalGoal.cs
namespace EternalQuest.Goals
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override string GetProgress()
        {
            return "[ ]"; // Eternal goals are never "completed"
        }

        public override int RecordEvent()
        {
            return Points;
        }

        public override string GetSaveString()
        {
            return $"EternalGoal|{Name}|{Description}|{Points}";
        }
    }
}
