using System;
using System.Collections.Generic;
using GeometricFigures;
using NUnit.Framework;

namespace GeometricalFiguresTest
{
    [TestFixture]
    public class CircleTest
    {
        public static IEnumerable<TestCaseData> TestGetAreaCircleData()
        {
            yield return new TestCaseData(20).Returns(Math.Pow(20, 2.0) * Math.PI);
            yield return new TestCaseData(1).Returns(Math.Pow(1, 2.0) * Math.PI);
            yield return new TestCaseData(9).Returns(Math.Pow(9, 2.0) * Math.PI);
        }

        public static IEnumerable<TestCaseData> TestGetLengthCircleData()
        {
            yield return new TestCaseData(20).Returns(20 * 2 * Math.PI);
            yield return new TestCaseData(1).Returns(1 * 2 * Math.PI);
            yield return new TestCaseData(5).Returns(5 * 2 * Math.PI);
        }

        [Test]
        [TestCaseSource(nameof(TestGetAreaCircleData))]
        public double TestGetAreaCircle(int radius)
        {
            var circle = new Circle(radius);
            return circle.getAreaCircle();
        }

        [Test]
        [TestCaseSource(nameof(TestGetLengthCircleData))]
        public double TestGetLengthCircle(int radius)
        {
            var circle = new Circle(radius);
            return circle.getLengthCircle();
        }
    }
}
