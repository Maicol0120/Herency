namespace GeometricFigures.Backend;

public sealed class Circle : GeometricFigure
{
    public Circle(string name, double r) : base(name)
    {
        r = ValidatePositive (r, nameof(r));)
    }

    public override double GetArea() => Math.PI * R * R;
    public override double GetPerimeter() => 2 * Math.PI * R; 
}