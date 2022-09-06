using AwesomeShapeLibrary.Shapes;

namespace AwesomeShapeLibrary.Tests.ShapesTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidData_Success()
        {
            Triangle triangle = new Triangle(1, 3, 3);

            double result = triangle.CalculateArea();

            Assert.Equal(Math.Round(1.479019945774904, 2), Math.Round(result, 2));
        }
        [Fact]
        public void IsRightTriangle_ValidData_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool result = triangle.IsRightTriangle();

            Assert.True(result);
        }
        [Fact]
        public void IsRightTriangle_InvalidData_False()
        {
            Triangle triangle = new Triangle(4, 4, 5);

            bool result = triangle.IsRightTriangle();

            Assert.False(result);
        }
    }
}
