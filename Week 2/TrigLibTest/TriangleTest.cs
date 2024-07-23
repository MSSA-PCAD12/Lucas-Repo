using TrigLib;

namespace TrigLibTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [DataRow(3,4,5)]

        public void BasicTriangleHypo()
        {
            // Arrange
            double expected = 5;
            double side1 = 4, side2 = 3;
            // Act

            double result = Triangle.GetHypo(side1, side2);
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SidesMustBePositive()
        {
            // Arrange
            //double expected = 5;
            double side1 = -4, side2 = -3;
            // Act

            double result = Triangle.GetHypo(side1, side2);
            // Assert
        }

    }
}