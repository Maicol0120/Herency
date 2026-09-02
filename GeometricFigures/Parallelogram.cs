namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        H = h;
    }
    public double H { get; }

    public override double GetArea() => B * H;
}
