namespace EternalQuest.Goals
{
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, string description, int points) : base(name, description, points) { }

        public override string GetSaveString()
        {
            return $"NegativeGoal|{Name}|{Description}|{Points}";
        }

        public override int RecordEvent()
        {
            return -Points; // Deduct points for negative goals
        }

        public override string GetProgress()
        {
            return "[⚠]";
        }

        public override string GetGoalType()
        {
            return "NegativeGoal";
        }
    }
}