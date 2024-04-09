public class Swimming : Activity
{
    private double _numLaps;

    public Swimming(string date, double duration, double numLaps) : base(date, duration)
    {
        _numLaps = numLaps;

    }

    public override double GetDistance()
    {
        return Math.Round(_numLaps * 50 / 1000 * 0.62,2);
    
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance()/ (_duration/60), 2);
    }

    public override double GetPace()
    {
        return Math.Round((_duration /60) / GetDistance(), 2);
    }

}