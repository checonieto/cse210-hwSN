namespace EternalQuest.Goals
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

        public override string GetSaveString()
        {
            return $"SimpleGoal|{Name}|{Description}|{Points}";
        }

        public override int RecordEvent()
        {
            IsComplete = true;
            return Points;
        }
    }
}
