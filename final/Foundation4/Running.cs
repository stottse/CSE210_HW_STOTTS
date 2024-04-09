public class Running: Activity
{
    private double _distance;

    public Running(string date, double duration, double distance) : base (date, duration)
    {
        _distance = distance;

    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        //found the math.round online
        return Math.Round(_distance/_duration,2) *60;
    }

    public override double GetPace()
    {
        return Math.Round(_duration/_distance,2);
    }


}