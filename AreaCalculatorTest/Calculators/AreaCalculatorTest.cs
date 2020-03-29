using AutoFixture;
using NUnit.Framework;
using System;

namespace AreaCalculatorTest.Calculators
{
    public class AreaCalculatorTest
    {
        private static readonly Fixture _fixture = new Fixture();
        private AreaCalculator.Calculators.AreaCalculator _areaCalculator;

        [SetUp]
        public void Setup()
        {
            _areaCalculator = new AreaCalculator.Calculators.AreaCalculator();
        }

        [Test]
        public void CalculateCircleArea_Success()
        {
            var radius = _fixture.Create<double>();
            var expectedResult = Math.PI * radius;
            var result = _areaCalculator.CalculateCircleArea(radius);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculateCircleArea_ArgumentExcetion()
        {
            var ex = Assert.Throws<ArgumentException>(() => _areaCalculator.CalculateCircleArea(-1));
            Assert.AreEqual("Radius should be greater than 0", ex.Message);
        }

        [Test]
        public void CalculateTriangleArea_Success()
        {
            var aSide = _fixture.Create<double>();
            var bSide = _fixture.Create<double>();
            var cSide = _fixture.Create<double>();
            var halfP = (aSide + bSide + cSide) / 2;
            var expectedResult = Math.Sqrt(halfP * (halfP - aSide) * (halfP - bSide) * (halfP - cSide));
            var result = _areaCalculator.CalculateTriangleArea(aSide, bSide, cSide);
            
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculateTriangleArea_ArgumentExcetion()
        {
            var aSide = _fixture.Create<double>();
            var bSide = _fixture.Create<double>();
            var ex = Assert.Throws<ArgumentException>(() => _areaCalculator.CalculateTriangleArea(aSide , bSide, - 1));
            Assert.AreEqual("All sides should be greater than 0", ex.Message);
        }
        
        [Test]
        public void IsTriangleRight_Success_true()
        {
            var aSide = 3;
            var bSide = 4;
            var cSide = 5;
            var result = _areaCalculator.IsRightShape(aSide, bSide, cSide);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsTriangleRight_Success_false()
        {
            var aSide = 3;
            var bSide = 4;
            var cSide = 4;
            var result = _areaCalculator.IsRightShape(aSide, bSide, cSide);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsTriangleRight_ArgumentExcetion()
        {
            var aSide = -3;
            var bSide = 4;
            var cSide = 4;
            var ex = Assert.Throws<ArgumentException>(() => _areaCalculator.IsRightShape(aSide, bSide, cSide));
            Assert.AreEqual("All sides should be greater than 0", ex.Message);
        }
    }
}
