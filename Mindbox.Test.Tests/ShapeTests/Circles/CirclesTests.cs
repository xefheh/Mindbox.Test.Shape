using Mindbox.Test.Shapes.Shapes;
using NUnit.Framework.Interfaces;

namespace Mindbox.Test.Tests.ShapeTests.Circles;

public class CirclesTests
{
    [TestCase(-2)]
    [TestCase(-1)]
    [TestCase(-1)]
    [TestCase(-5)]
    
    public void Circles_ExceptionForNotCorrectArguments(int r)
    {
        Assert.Throws<ArgumentException>(() => 
            new Circle(r));
    }

    [TestCase(5, 78)]
    [TestCase(2, 12)]
    [TestCase(4, 50)]
    [TestCase(3, 28)]
    [TestCase(12, 452)]
    
    public void Circles_CorrectGetAreaResult(int r, int area)
    {
        var circle = new Circle(r);
        Assert.That(circle.GetArea(), Is.EqualTo(area));
    }
}