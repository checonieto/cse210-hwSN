namespace EternalQuest.Goals
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        // Implement GetProgress
        public override string GetProgress()
        {
            return _isCompleted ? "Completed" : "Not completed";
        }

        // Implement GetGoalType
        public override string GetGoalType()
        {
            return "Simple";
        }

        // Implement RecordEvent
        public override int RecordEvent()
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                return _points; // Return points when the goal is completed
            }
            return 0; // No points if already completed
        }
    }
}
