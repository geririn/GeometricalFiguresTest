using System;
using System.Collections.Generic;
using GeometricFigures;
using NUnit.Framework;

namespace GeometricalFiguresTest
{
    [TestFixture]
    public class TriangleTest
    {
        private static IEnumerable<TestCaseData> TestTriangleAreaData()
        {
            yield return new TestCaseData(2, 2, 2).Returns(Math.Sqrt(SemiPerimeter(2, 2, 2) * (SemiPerimeter(2, 2, 2) - 2.0) * (SemiPerimeter(2, 2, 2) - 2.0) * (SemiPerimeter(2, 2, 2) - 2.0)));
            yield return new TestCaseData(4, 4, 4).Returns(Math.Sqrt(SemiPerimeter(4, 4, 4) * (SemiPerimeter(4, 4, 4) - 4.0) * (SemiPerimeter(4, 4, 4) - 4.0) * (SemiPerimeter(4, 4, 4) - 4.0)));
            yield return new TestCaseData(5, 8, 10).Returns(Math.Sqrt(SemiPerimeter(5, 8, 10) * (SemiPerimeter(5, 8, 10) - 5.0) * (SemiPerimeter(5, 8, 10) - 8.0) * (SemiPerimeter(5, 8, 10) - 10.0)));
        }

        private static IEnumerable<TestCaseData> TestTriangleLengthData()
        {
            yield return new TestCaseData(2, 2, 2).Returns(2 + 2 + 2);
            yield return new TestCaseData(3, 3, 3).Returns(3 + 3 + 3);
            yield return new TestCaseData(4, 4, 4).Returns(4 + 4 + 4);
        }

        private static double SemiPerimeter(int side1, int side2, int side3)
        {
            return (side1 + side2 + side3) / 2.0;
        }

        [TestCaseSource(nameof(TestTriangleAreaData))]
        public double TestAreaTriangle(int side1, int side2, int side3)
        {
            var triangle = new Triangle(side1, side1, side3);
            return triangle.getAreaTriangle();
        }

        [TestCaseSource(nameof(TestTriangleLengthData))]
        public double TestLengthTriangle(int side1, int side2, int side3)
        {
            var triangle = new Triangle(side1, side1, side3);
            return triangle.getLengthTriangle();
        }

        [Test]
        public void TestAreaTriangleException()
        {
            var triangle = new Triangle(1, 2, 3);
            Assert.Throws<Exception>(() => triangle.getAreaTriangle());
        }

        [Test]
        public void TestLengthTriangleException()
        {
            var triangle = new Triangle(1, 2, 3);
            Assert.Throws<Exception>(() => triangle.getLengthTriangle());
        }
    }
}
