namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public double R { get; }

    public override double GetArea() => Math.PI * R * R;

    public override double GetPerimeter() => 2 * Math.PI * R;
}