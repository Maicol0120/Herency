namespace GeometricFigures.Backend;

public sealed class Parallelogram : Rectangle
{
    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        H = ValidatePositive(h, nameof(h));
    }

    public double H { get; }

    public override double GetArea() => B * H;
}
