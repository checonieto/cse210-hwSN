// ChecklistGoal.cs
namespace EternalQuest.Goals
{
    public class ChecklistGoal : Goal
    {
        public int Target { get; set; }
        public int Bonus { get; set; }
        public int CurrentProgress { get; set; }

        public ChecklistGoal(string name, string description, int points, int target, int bonus) 
            : base(name, description, points)
        {
            Target = target;
            Bonus = bonus;
            CurrentProgress = 0;
        }

        public override string GetProgress()
        {
            return $"{CurrentProgress}/{Target}";
        }

        public override int RecordEvent()
        {
            if (CurrentProgress < Target)
            {
                CurrentProgress++;
                return Points;
            }
            else
            {
                return Points + Bonus;
            }
        }

        public override string GetSaveString()
        {
            return $"ChecklistGoal|{Name}|{Description}|{Points}|{CurrentProgress}|{Target}|{Bonus}";
        }
    }
}
