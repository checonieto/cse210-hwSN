namespace EternalQuest.Goals
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _targetCount;
        private int _bonusPoints;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonusPoints = bonusPoints;
            _timesCompleted = 0;
        }

        public override int RecordEvent()
        {
            if (!_isCompleted)
            {
                _timesCompleted++;
                
                if (_timesCompleted >= _targetCount)
                {
                    _isCompleted = true;
                    return _points + _bonusPoints;
                }
                return _points;
            }
            return 0;
        }

        public override string GetProgress()
        {
            return _isCompleted ? "[X]" : $"[ ] (Completed {_timesCompleted}/{_targetCount})";
        }

        public override string GetGoalType()
        {
            return "ChecklistGoal";
        }

        public override string GetSaveString()
        {
            return $"{GetGoalType()}|{_name}|{_description}|{_points}|{_isCompleted}|{_timesCompleted}|{_targetCount}|{_bonusPoints}";
        }
    }
}