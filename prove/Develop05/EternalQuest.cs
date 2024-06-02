using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EternalQuest
{
    public class EternalQuest
    {
        public List<Goal> Goals { get; set; }
        public int Score { get; set; }

        public EternalQuest()
        {
            Goals = new List<Goal>();
            Score = 0;
        }

        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }

        public void RecordGoal(string goalName)
        {
            foreach (var goal in Goals)
            {
                if (goal.Name == goalName)
                {
                    Score += goal.RecordEvent();
                    break;
                }
            }
        }

        public void DisplayGoals()
        {
            foreach (var goal in Goals)
            {
                Console.WriteLine($"{goal.GetStatus()} {goal.Name}");
            }
        }

        public void SaveProgress(string filename)
        {
            var data = new
            {
                Score,
                Goals = Goals.ConvertAll(goal => new
                {
                    Type = goal.GetType().Name,
                    goal.Name,
                    goal.Points,
                    goal.Completed,
                    RecordCount = goal is EternalGoal ? ((EternalGoal)goal).RecordCount : 0,
                    TargetCount = goal is ChecklistGoal ? ((ChecklistGoal)goal).TargetCount : (int?)null,
                    BonusPoints = goal is ChecklistGoal ? ((ChecklistGoal)goal).BonusPoints : (int?)null,
                    CurrentCount = goal is ChecklistGoal ? ((ChecklistGoal)goal).CurrentCount : 0
                })
            };

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
        }

        public void LoadProgress(string filename)
        {
            var json = File.ReadAllText(filename);
            var data = JsonSerializer.Deserialize<dynamic>(json);

            Score = data.Score;
            Goals = new List<Goal>();

            foreach (var goalData in data.Goals)
            {
                Goal goal;
                string type = goalData.Type;

                if (type == "SimpleGoal")
                {
                    goal = new SimpleGoal(goalData.Name, goalData.Points);
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(goalData.Name, goalData.Points) { RecordCount = goalData.RecordCount };
                }
                else if (type == "ChecklistGoal")
                {
                    goal = new ChecklistGoal(goalData.Name, goalData.Points, goalData.TargetCount, goalData.BonusPoints) { CurrentCount = goalData.CurrentCount };
                }
                else
                {
                    continue;
                }

                goal.Completed = goalData.Completed;
                Goals.Add(goal);
            }
        }
    }
}