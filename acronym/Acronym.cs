using System;
using System.Linq;
using System.Collections.Generic;

public static class Acronym
{
    public static string Abbreviate(string phrase) => 
        phrase.SplitAnyChar(' ', '-', '_')
        .Select(AcronymExtensions.ToAcronymChar).CharArrayToString();
}

public static class AcronymExtensions
{
    public static char ToAcronymChar(this string word) => word.ToUpper().FirstOrDefault();
    public static IEnumerable<string> WhereAnyChar(this string[] words) => words.Where(x => x.Any(Char.IsLetter));
    public static IEnumerable<string> SplitAnyChar(this string word, params char[] delimitators) => word.Split(delimitators).WhereAnyChar();
    public static string CharArrayToString(this IEnumerable<char> chars) => string.Join("", chars);
}