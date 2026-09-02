namespace GeometricFigures.Backend;

public sealed class Trapeze : Triangle
{
    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = ValidatePositive(d, nameof(d));
    }

    public double D { get; }

    public override double GetArea() => (B + D) * H / 2;
    public override double GetPerimeter() => A + B + C + D;
}
