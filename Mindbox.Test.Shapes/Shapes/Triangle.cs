using Mindbox.Test.Shapes.Abstraction;

namespace Mindbox.Test.Shapes.Shapes;

public class Triangle : Shape
{
    private readonly int _firstSideLength;
    private readonly int _secondSideLength;
    private readonly int _thirdSideLength;

    public Triangle(int firstSideLength, int secondSideLength, int thirdSideLength)
    {
        if (firstSideLength <= 0 || secondSideLength <= 0 || thirdSideLength <= 0)
        {
            throw new ArgumentException(string.Join(' ',
                nameof(firstSideLength),
                nameof(secondSideLength),
                nameof(thirdSideLength)));
        }
        _firstSideLength = firstSideLength;
        _secondSideLength = secondSideLength;
        _thirdSideLength = thirdSideLength;
    }

    /// <summary>
    /// Правильный треугольник - Истина, нет - Ложь;
    /// </summary>
    public bool IsRight => (_firstSideLength * _firstSideLength +
                           _secondSideLength * _secondSideLength ==
                           _thirdSideLength * _thirdSideLength) ||
                           (_firstSideLength * _firstSideLength +
                           _thirdSideLength * _thirdSideLength ==
                           _secondSideLength * _secondSideLength) ||
                           (_secondSideLength * _secondSideLength +
                           _thirdSideLength * _thirdSideLength ==
                           _firstSideLength * _firstSideLength);

    public override int GetArea()
    {
        var semiperimeter = GetSemiperimeter();
        return (int)Math.Sqrt(semiperimeter * (semiperimeter - _firstSideLength) *
                              (semiperimeter - _secondSideLength) *
                              (semiperimeter - _thirdSideLength));
    }

    
    /// <summary>
    /// Получить полупериметр треугольника.
    /// </summary>
    /// <returns>Полупериметр.</returns>
    private float GetSemiperimeter() =>
        (float)(_firstSideLength + _secondSideLength + _thirdSideLength) / 2;
}