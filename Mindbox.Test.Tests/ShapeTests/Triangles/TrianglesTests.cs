using Mindbox.Test.Shapes.Shapes;

namespace Mindbox.Test.Tests.ShapeTests.Triangles;

public class TrianglesTests
{
    [TestCase(3, 4, 5, true)]
    [TestCase(5, 12, 13, true)]
    [TestCase(1, 1, 1, false)]
    [TestCase(5, 12, 14, false)]
    [TestCase(13, 84, 85, true)]
    
    public void Triangles_IsRight(int a, int b, int c, bool isRight)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRight, Is.EqualTo(isRight));
    }

    [TestCase(1, 1, -1)]
    [TestCase(-1, 4, -25)]
    [TestCase(0, 15, 24)]
    [TestCase(-1, 24, 25)]
    [TestCase(-5, -5, 0)]
    
    public void Triangles_ExceptionForNotCorrectArguments(int a, int b, int c)
    {
        Assert.Throws<ArgumentException>(() => 
            new Triangle(a, b, c));
    }
    
    [TestCase(3, 4, 5, 6)]
    [TestCase(5, 4, 5, 9)]
    [TestCase(5, 8, 5, 12)]
    [TestCase(1, 1, 1, 0)]
    [TestCase(2, 3, 4, 2)]
    
    public void Triangles_CorrectGetAreaResult(int a, int b, int c, int area)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.GetArea(), Is.EqualTo(area));
    }
}