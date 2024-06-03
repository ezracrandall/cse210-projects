public class Running:Activity
{
    private double _distanceKm;
    public Running(DateTime activityDate, int durationMinutes, double distanceKm)
        : base(activityDate, durationMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (_distanceKm/DurationMinutes) * 60;
    public override double GetPace() => DurationMinutes/_distanceKm;
}
