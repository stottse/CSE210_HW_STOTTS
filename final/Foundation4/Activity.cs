public abstract class Activity
{
    protected string _date;
    protected double _duration;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;

    }

    public abstract double GetDistance();
    
    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";

    }
}