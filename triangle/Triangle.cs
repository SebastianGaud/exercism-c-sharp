using System;
using System.Collections.Generic;
using System.Linq;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        return EqualSides(side1, side2, side3) == 3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        return EqualSides(side1, side2, side3) <= 2;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        return EqualSides(side1, side2, side3) == 1;
    }


    public static int? EqualSides(params double[] sides)
    {
        return IsTriangle(sides) ?  (int?)sides.Distinct().Count() : null;
    }

    public static bool IsTriangle(params double[] sides)
    {
        return Array.TrueForAll(sides, x => x > 0) ? sides.Max() < sides.Sum() / 2 : false;
    }
}