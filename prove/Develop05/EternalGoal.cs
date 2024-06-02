namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public int RecordCount { get; set; }

        public EternalGoal(string name, int points) : base(name, points)
        {
            RecordCount = 0;
        }

        public override int RecordEvent()
        {
            RecordCount++;
            return Points;
        }

        public override string GetStatus()
        {
            return $"[∞] Recorded {RecordCount} times";
        }
    }
}