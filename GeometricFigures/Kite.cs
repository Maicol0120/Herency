namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    public Kite(string name, double a, double d1, double d2, double b) 
        : base(name, a, d1, d2)
    {
        B = b;
    }
    public double B { get; }

    public override double GetPerimeter() => 2 * (A + B);
}

