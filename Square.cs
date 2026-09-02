namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    public Square (string name, double a) : base(name)
    {
        A = ValidatePositive(a, nameof(a));
    }

    public double A { get; }

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;
}
