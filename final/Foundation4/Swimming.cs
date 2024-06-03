public class Swimming:Activity
{
    private int _laps;
    public Swimming(DateTime activityDate, int durationMinutes, int laps)
        : base(activityDate, durationMinutes)
    {
        _laps = laps;
    }
    public override double GetDistance() => (_laps*50)/1000.0;
    public override double GetSpeed()
    {
        double distanceKm = GetDistance();
        return (distanceKm/DurationMinutes)*60;
    }
    public override double GetPace()
    {
        double distanceKm = GetDistance();
        return DurationMinutes/distanceKm;
    }
}
