using ShapesLibrary;

namespace ShapesUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SetNegativeValues()
        {
            IEnumerable<double> sides = new List<double>() { -1, -2, -3 };

            bool isCatched = false;
            try
            {
                Triangle triangle = new Triangle(sides);
            }
            catch
            {
                isCatched = true;
            }

            Assert.IsTrue(isCatched);
        }

        [TestMethod]
        public void TriangleArea()
        {
            IEnumerable<double> sides = new List<double>() { 3, 4, 5 };

            Triangle triangle = new Triangle(sides);

            double area = triangle.Area();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void CircleArea()
        {
            double radius = 1;

            Circle circle = new Circle(radius);

            double area = circle.Area();

            Assert.AreEqual(Math.Round(Math.PI, 2), Math.Round(area, 2));
        }
    }
}