namespace GeometricFigures.Backend;

public class Rectangle : Square
{
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = ValidatePositive(b, nameof(b));
    }

    public double B { get; }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);
}
