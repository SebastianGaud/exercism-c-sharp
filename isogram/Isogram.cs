using System;
using System.Linq;
using System.Collections.Generic;


public static class Isogram
{
    public static bool IsIsogram(string word) => word.CountComparable() == word.WithoutSpecialChar().Count();
    public static int CountComparable(this string word) => word.ToLower().WithoutSpecialChar().Distinct().Count();
    public static IEnumerable<char> WithoutSpecialChar(this string word) => word.Where(char.IsLetter);
}
