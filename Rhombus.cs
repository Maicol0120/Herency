namespace GeometricFigures.Backend;

public class Rhombus : Square
{
	public Rhombus(string name, double a, double d1, double d2) 
		: base (name, a)
	{
		D1 = ValidatePositive(d1, nameof(d1));
		D2 = ValidatePositive(d2, nameof(d2)); 

	}
	public double D1 { get;}
	public double D2 { get;}

	public override double GetArea() => (D1 * D2) / 2; 
}
