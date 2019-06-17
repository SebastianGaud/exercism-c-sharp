using System;
using System.Collections.Generic;
using System.Linq;
public static class Pangram
{
    public static bool IsPangram(string input) => input.IsPangram();
}


public static class StringExtension 
{
    
    // convert string into char array, intersect with alphabet.  
    public static bool IsPangram(this string input) => 
                !string.IsNullOrWhiteSpace(input) &&
                !Alphabet()
                .Except(input.ToLower().ToCharArray())
                .Any();

    // Create alphabet from Enumberable range, char is converted to int. 
    public static IEnumerable<char> Alphabet() => Enumerable.Range('a', LowerAsciiCharCount()).ConvertListOfIntToAsciiChar();

    // get how much lower case letters are inside ascii table
    public static int LowerAsciiCharCount() => 'z' - 'a' + 1;
}

public static class EnumerableExtension 
{
    // every item o ienumerable is converted to the corresponding ascii character
    public static IEnumerable<char> ConvertListOfIntToAsciiChar(this IEnumerable<int> list) => list.Select(i => (char)i).ToArray(); 
}