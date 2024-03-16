using System;

class Program
{
    static void Main(string[] args)
    {
        // We cannot create an instance of an abstract class
        CircularWindow c = new CircularWindow();
        c._radius = 5;
        double s1 = c.ComputeSurfaceArea();
        c.SetPanes();
        Console.WriteLine(s1);
        Console.WriteLine($"Panes: {c._numPanes}");

        SquareWindow sw = new SquareWindow();
        sw._length = 6;
        sw._width = 8;
        sw.SetPanes();
        Console.WriteLine(sw.ComputeSurfaceArea());
        Console.WriteLine($"Panes: {sw._numPanes}");

    }
}