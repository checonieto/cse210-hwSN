using System.Collections.Generic;
using EternalQuest.Goals;

namespace EternalQuest.User
{
    public class UserProfile
    {
        private List<Goal> _goals = new List<Goal>();
        private int _totalPoints = 0;

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public List<Goal> GetGoals() => _goals;

        public void AddPoints(int points)
        {
            _totalPoints += points;
        }

        public int GetTotalPoints() => _totalPoints;

        public int GetLevel()
        {
            // Bonus: Level system (1000 points per level)
            return _totalPoints / 1000;
        }

        public void Reset()
        {
            _goals.Clear();
            _totalPoints = 0;
        }
    }
}