public class Cycling:Activity
{
    private double _speedKph;
    public Cycling(DateTime activityDate, int durationMinutes, double speedKph)
        : base(activityDate, durationMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance() => (_speedKph * DurationMinutes) / 60;
    public override double GetSpeed() => _speedKph;
    public override double GetPace() => 60 / _speedKph;
}