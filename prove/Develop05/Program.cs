using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            EternalQuest quest = new EternalQuest();

            quest.AddGoal(new SimpleGoal("Run a marathon", 1000));
            quest.AddGoal(new EternalGoal("Read scriptures", 100));
            quest.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));

            quest.RecordGoal("Read scriptures");
            quest.RecordGoal("Attend temple");
            quest.RecordGoal("Attend temple");
            quest.RecordGoal("Run a marathon");

            quest.DisplayGoals();
            Console.WriteLine($"Total Score: {quest.Score}");

            quest.SaveProgress("progress.json");

        
            EternalQuest newQuest = new EternalQuest();
            newQuest.LoadProgress("progress.json");
            newQuest.DisplayGoals();
            Console.WriteLine($"Total Score: {newQuest.Score}");
        }
    }
}
