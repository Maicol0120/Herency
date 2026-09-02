using System.Globalization;

namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return string.Format(
            CultureInfo.InvariantCulture,
            "{0,-16}=> Area.....: {1,12:N5}        Perimeter: {2,12:N5}",
            Name,
            GetArea(),
            GetPerimeter()
        );
    }
}