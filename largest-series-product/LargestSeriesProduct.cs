using System;
using System.Linq;
using System.Collections.Generic;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        // ideally throw exception should be encapsulated in a method who check data
        var onlyDigits = digits.Where(Char.IsDigit);
        if (
            digits.Length != onlyDigits.Count()
            || digits.Length < span
            || span < 0
        )
        {
            throw new ArgumentException();
        }

        return digits.SliceBy(span)
            .Select(seq => 
                seq
                .ToCharArray()
                .Select(x => Convert.ToInt32(x.ToString()))
                .Aggregate(1, (num, acc) => num * acc)
            ).Max();
    }


    // Method already used inside "series" exercise
    public static IEnumerable<string> SliceBy(this string numbers, int sliceLength)
    {
        return Enumerable.Range(0, 
            (numbers.Length - (sliceLength - 1))
        )
        .Select(i => {
            return numbers.Substring(i, sliceLength);
        });
    }
}