using System;

namespace AreaCalculator.Calculators
{
    /// <summary>
    /// Implementation for area calculator
    /// </summary>
    public class AreaCalculator : IAreaCalculator
    {
        /// <inheritdoc/>
        public double CalculateCircleArea(double radius)
        {
            //do not sure that dll should throw this kind of exception
            if (radius < 0)
            {
                throw new ArgumentException("Radius should be greater than 0");
            }
            return Math.PI * radius;
        }

        /// <inheritdoc/>
        public double CalculateTriangleArea(double aSide, double bSide, double cSide)
        {
            if (aSide < 0 || bSide < 0 || cSide < 0)
            {
                throw new ArgumentException("All sides should be greater than 0");
            }
            var halfP = (aSide + bSide + cSide) / 2;
            return Math.Sqrt(halfP * (halfP - aSide) * (halfP - bSide) * (halfP - cSide));
        }

        /// <inheritdoc/>
        public bool IsRightShape(double aSide, double bSide, double cSide)
        {
            if (aSide < 0 || bSide < 0 || cSide < 0)
            {
                throw new ArgumentException("All sides should be greater than 0");
            }
            if (Math.Pow(aSide, 2) + Math.Pow(bSide, 2) == Math.Pow(cSide, 2)
                || Math.Pow(bSide, 2) + Math.Pow(cSide, 2) == Math.Pow(aSide, 2)
                || Math.Pow(aSide, 2) + Math.Pow(cSide, 2) == Math.Pow(bSide, 2))
            {
                return true;
            }
            return true;
        }
    }
}
