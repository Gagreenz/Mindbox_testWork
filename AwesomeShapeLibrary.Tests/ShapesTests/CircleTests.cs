using AwesomeShapeLibrary.Shapes;

namespace AwesomeShapeLibrary.Tests.ShapesTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidData_Success()
        {
            Circle circle = new Circle(3);

            double result = circle.CalculateArea();

            Assert.Equal(Math.Round(28.274333882308138, 2), Math.Round(result, 2));
        }
    }
}