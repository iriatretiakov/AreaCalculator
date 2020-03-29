namespace AreaCalculator
{
    /// <summary>
    /// Area calculator interface
    /// </summary>
    public interface IAreaCalculator
    {
        /// <summary>
        /// Calculate circle area by radius
        /// </summary>
        /// <param name="radius">Radius of calculated circle</param>
        /// <returns>Calculated area</returns>
        double CalculateCircleArea(double radius);

        /// <summary>
        /// Calculate triangle area by three sides
        /// </summary>
        /// <param name="aSide">First side</param>
        /// <param name="bSide">Second side</param>
        /// <param name="cSide">Third side</param>
        /// <returns>Calculated area</returns>
        double CalculateTriangleArea(double aSide, double bSide, double cSide);

        /// <summary>
        /// Is triangle right shape
        /// </summary>
        /// <param name="aSide">First side</param>
        /// <param name="bSide">Second side</param>
        /// <param name="cSide">Third side</param>
        /// <returns>is right triangle</returns>
        bool IsRightShape(double aSide, double bSide, double cSide);
    }
}
