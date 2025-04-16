namespace EternalQuest.Goals
{
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, string description, int points) 
            : base(name, description, points) { }

        public override int RecordEvent()
        {
            return -_points; // Deduct points for negative habits
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