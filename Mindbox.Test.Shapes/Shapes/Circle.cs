using Mindbox.Test.Shapes.Abstraction;

namespace Mindbox.Test.Shapes.Shapes;

/// <summary>
/// Круг
/// </summary>
public class Circle : Shape
{
    
    /// <summary>
    /// Радиус круга.
    /// </summary>
    private readonly int _radius;

    public Circle(int radius)
    {
        if (radius <= 0) throw new ArgumentException(nameof(radius));
        _radius = radius;
    }


    public override int GetArea() =>
        (int)(Math.PI * (_radius * _radius));
}