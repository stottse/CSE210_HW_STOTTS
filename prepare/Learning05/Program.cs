using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes= new List <Shapes>();

        Square square = new Square("blue", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle ("orange", 4, 2);
        shapes.Add(rectangle);

        Circle circle = new Circle ("red", 3);
        shapes.Add(circle);

        foreach (Shapes i in shapes){
            string color = i.GetColor();
            double area = i.GetArea();
            Console.WriteLine($"The color of the shape is {color}, and the area is {area}");

        }
    }
}