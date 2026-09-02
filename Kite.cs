namespace GeometricFigures.Backend;

public sealed class Kite : Rhombus
{
    public Kite(string name, double a, double d1, double d2, double b)
        : base(name, a, d1, d2)
    {
        B = ValidatePositive(b, nameof(b));
    }

    public double B { get; }

    public override double GetPerimeter() => 2 * (A + B);
}