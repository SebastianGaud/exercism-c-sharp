using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        return numbers.SliceFor(sliceLength).ToArray();
    }

    public static IEnumerable<string> SliceFor(this string numbers, int sliceLength)
    {
        var index = 0;
        for (int i = 0; i <= numbers.Length; i += sliceLength)
        {
            ++index;
            yield return numbers.Substring(index, i);
        }
    }
}