public abstract class Activity
{
    private DateTime _activityDate;
    private int _durationMinutes;
    public Activity(DateTime activityDate, int durationMinutes)
    {
        _activityDate = activityDate;
        _durationMinutes = durationMinutes;
    }
    public DateTime ActivityDate => _activityDate;
    public int DurationMinutes => _durationMinutes;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{ActivityDate.ToString("dd MMM yyyy")} {GetType().Name} ({DurationMinutes} min): " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
