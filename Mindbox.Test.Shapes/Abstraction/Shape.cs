namespace Mindbox.Test.Shapes.Abstraction;

/// <summary>
/// Фигура
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Получить площадь фигуры.
    /// </summary>
    /// <returns>Площадь. (округленная в меньшую сторону)</returns>
    public abstract int GetArea();
}