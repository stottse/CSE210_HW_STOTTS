using System.Runtime.CompilerServices;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;

    }

    public override double GetDistance()
    {
        return Math.Round(_duration * _speed / 60,2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60/_speed,2);
    }
}