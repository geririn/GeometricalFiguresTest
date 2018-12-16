using System;
using System.Collections.Generic;
using GeometricFigures;
using NUnit.Framework;

namespace GeometricalFiguresTest
{
    [TestFixture]
    public class SquareTest
    {
        private static IEnumerable<TestCaseData> TestAreaSquareData()
        {
            yield return new TestCaseData(10).Returns(Math.Pow(10, 2));
            yield return new TestCaseData(5).Returns(Math.Pow(5, 2));
            yield return new TestCaseData(1).Returns(Math.Pow(1, 2));
        }

        private static IEnumerable<TestCaseData> TestLengthSquareData()
        {
            yield return new TestCaseData(10).Returns(10 * 4);
            yield return new TestCaseData(5).Returns(5 * 4);
            yield return new TestCaseData(1).Returns(1 * 4);
        }

        [TestCaseSource(nameof(TestAreaSquareData))]
        public double TestAreaSquare(int side)
        {
            var square = new Square(side);
            return square.getAreaSquare();
        }

        [TestCaseSource(nameof(TestLengthSquareData))]
        public double TestLengthSquare(int side)
        {
            var square = new Square(side);
            return square.getLengthSquare();
        }
    }
}
