namespace EternalQuest.Goals
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;
        protected bool _isCompleted;

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
            _isCompleted = false;
        }

        public abstract int RecordEvent();
        public abstract string GetProgress();
        public abstract string GetGoalType();

        public bool IsCompleted() => _isCompleted;
        public string GetName() => _name;
        public string GetDescription() => _description;
        public int GetPoints() => _points;

        public virtual string GetSaveString()
        {
            return $"{GetGoalType()}|{_name}|{_description}|{_points}|{_isCompleted}";
        }
    }
}
