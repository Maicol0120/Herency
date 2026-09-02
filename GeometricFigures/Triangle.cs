namespace GeometricFigures.Backend;

public class Triangle : Rectangle 
{
    public Triangle(string name, double a, double b, double c, double h) 
        : base(name, a, b)
    {
        C = c;
        H = h;
    }
    public double C { get; }
    public double H { get; }
    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;
  
    
}
