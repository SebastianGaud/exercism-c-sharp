using System;
using System.Collections.Generic;
using System.Linq;

public static class PrimeFactors
{
    public static int[] Factors(long number)
    {
        return Primes(number).ToArray();
    }

    public static IEnumerable<int> Primes(long number)
    {    
        for (int b = 2; number > 1; b++)
        {               
            while (number % b == 0)
            {
                number /= b;
                yield return b;
            }               
        }
    }
}