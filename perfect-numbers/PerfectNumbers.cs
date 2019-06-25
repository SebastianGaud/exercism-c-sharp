using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}


public static class PerfectNumbers
{
    public static Classification Classify(int number) 
        => new NumberClassification(number).Classification;

    // public static Classification Classify(int number)         
    //     => number.SumDivisor().Classify(number);
}



public class NumberClassification
{
    private readonly int _n;
    private readonly IEnumerable<int> _divisors;

    public Classification Classification
    {
        get
        {
            var sum = _divisors.Sum();
            
            if (sum == _n)
            {
                return Classification.Perfect;
            }

            return sum > _n ? Classification.Abundant : Classification.Deficient;
        }
    }

    public NumberClassification(int n)
    {
        _n = n;
        _divisors = _n.Divisors();
    }
}

public static class PefectNumbersExtension
{
    public static IEnumerable<int> Divisors(this int n)
    {
        if  (n <= 0) throw new ArgumentOutOfRangeException();
        for (int i = 1; i < n; i++)
            if (n % i == 0) yield return i;
    }

    public static int SumDivisor(this int n)
        => Enumerable.Range(1, n <= 0 ? throw new ArgumentOutOfRangeException() : n).Aggregate((number, acc) => { 
            return n % number == 0 ? acc += n : acc += 0;
        });

    public static Classification Classify(this int n, int toCompare) 
        => n == toCompare ? Classification.Perfect : toCompare > n ? Classification.Abundant : Classification.Deficient;

}