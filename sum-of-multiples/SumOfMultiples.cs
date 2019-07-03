using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{

    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return new SumOfMultiplesCalculator(multiples).SumTo(max);
    }


    // More Functional approach
    
    // public static int Sum(IEnumerable<int> multiples, int max)
    //     => max.SumMultiples(multiples.Where(x => x != 0));

    // public static int SumMultiples(this int max, IEnumerable<int> multiples) 
    //     => Enumerable.Range(1, max -1).Where(x => multiples.AnyIsDivisibleBy(x)).Sum();

    // public static bool AnyIsDivisibleBy(this IEnumerable<int> multiples, int dividend) 
    //     => multiples.Any(x => dividend.IsDivisibleBy(x));

    // public static bool IsDivisibleBy(this int toBeDived, int divisor) 
    //     => toBeDived % divisor == 0;
}



public class SumOfMultiplesCalculator
{
    private readonly IEnumerable<int> _multiples;

    public SumOfMultiplesCalculator(IEnumerable<int> multiples)
    {
        _multiples = multiples.Where(x => x > 0);
    }

    public bool IsDivisiblyByMultiples(int dividend)
    {
        return _multiples.Any(x => dividend % x == 0);
    }

    public int SumTo(int max) {
        return EachNumberTo(max, IsDivisiblyByMultiples).Sum();
    }

    private IEnumerable<int> EachNumberTo(int max, Func<int, bool> shouldReturn)
    {
        for (int i = 1; i < max; i++)
        {
            if (shouldReturn(i))
            {
                yield return i;
            }
        }
    }
}