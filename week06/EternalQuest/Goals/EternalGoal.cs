namespace EternalQuest.Goals
{
    public class EternalGoal : Goal
    {
        private int _timesCompleted;

        public EternalGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            _timesCompleted = 0;
        }

        public override int RecordEvent()
        {
            _timesCompleted++;
            return _points;
        }

        public override string GetProgress()
        {
            return "[∞]";
        }

        public override string GetGoalType()
        {
            return "EternalGoal";
        }

        public override string GetSaveString()
        {
            return $"{GetGoalType()}|{_name}|{_description}|{_points}|{_timesCompleted}";
        }
    }
}