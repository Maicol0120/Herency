using System.Globalization;

namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    protected GeometricFigure(string name)
    {
        Name = string.IsNullOrWhiteSpace(name)
            ? throw new ArgumentException("El nombre es obligatorio.", nameof(name))
            : name;
    }

    public string Name { get; }

    public abstract double GetArea();
    public abstract double GetPerimeter();


    public override string ToString() => string.Format(
        CultureInfo.InvariantCulture,
        "{0,-16} => Area.....: {1,12:N5}   perimeter: {2,12:N5}",
        Name, GetArea(), GetPerimeter()));

    public static double ValidatePositive(double value, string parameterName) =>
        value > 0
            ? value
            : throw new ArgumentException(parameterName);
}