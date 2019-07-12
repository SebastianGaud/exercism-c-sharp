using System;
using System.Linq;
using System.Collections.Generic;

public static class DifferenceOfSquares
{

    public static int CalculateSquareOfSum(int max)
    {
        return max.SelectResultFrom(
            1, 
            @do: (list) => DifferenceOfSquaresExtension.PowByTwo(list.Sum())
        );  
        
        //return (int)Math.Pow(Enumerable.Range(1, max).Sum(), Pow);
    }

    public static int CalculateSumOfSquares(int max)
    {
        return max.SelectResultFrom(
            1,
            @do: (list) => list.Select(DifferenceOfSquaresExtension.PowByTwo).Sum()
        );
        
        //return (int)Enumerable.Range(1, max).Select(x => Math.Pow(x, Pow)).Sum();
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}


public static class DifferenceOfSquaresExtension 
{
    private const double Pow = 2;

    public static int SelectResultFrom(this int to, int from, Func<IEnumerable<int>, double> @do){
        return (int)@do(Enumerable.Range(from, to));
    }

    public static int PowByTwo(int baseNumber) => (int)Math.Pow(baseNumber, Pow); // baseNumber * baseNumber
}