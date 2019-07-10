using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        return ThrowIfNotCompliant(numbers, sliceLength, @else: SliceBy).ToArray();
    }

    public static IEnumerable<string> SliceBy(string numbers, int sliceLength)
    {
        return Enumerable.Range(0, 
            (numbers.Length - (sliceLength - 1))
        )
        .Select(i => {
            return numbers.Substring(i, sliceLength);
        });
    }

    private static IEnumerable<string> ThrowIfNotCompliant(string numbers, int sliceLength, Func<string, int, IEnumerable<string>> @else)
    {
        if (numbers.Length < sliceLength || sliceLength < 1)  throw new ArgumentException();
        return @else(numbers, sliceLength);
    }
}