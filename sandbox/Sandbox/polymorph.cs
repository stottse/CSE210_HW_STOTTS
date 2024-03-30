public abstract class Window {
    protected double _surfaceArea;
    public int _numPanes;
    public abstract double ComputeSurfaceArea();
    public virtual void SetPanes() {
        _numPanes = 2;
    }
}

public class CircularWindow : Window {
    public double _pi = 3.14;
    public double _radius;
    public override double ComputeSurfaceArea()
    {
        _surfaceArea = _pi * (_radius * _radius);
        return _surfaceArea;
    }
    public override void SetPanes()
    {
        _numPanes = 3;
    }
}

public class SquareWindow : Window {
    public double _length;
    public double _width;
    public override double ComputeSurfaceArea()
    {
        _surfaceArea = _length * _width;
        return _surfaceArea;
    }
}