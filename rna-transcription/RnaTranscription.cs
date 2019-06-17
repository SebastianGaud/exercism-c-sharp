using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide) => nucleotide.ConvertToRnaList(RnaExtension.FromArrayToString);
}


public static class RnaExtension 
{
    private static Dictionary<char, char> mapping = new Dictionary<char, char>(){
        {'G' ,'C'},
        {'C', 'G'},
        {'T', 'A'},
        {'A', 'U'}
    };

    public static string ConvertToRnaList(this string dna, Func<IEnumerable<char>, string> toString) => toString(
        dna.ToCharArray().Select(ToRnaNucleotide)
    );
    public static char ToRnaNucleotide(this char nucleotide) => mapping[nucleotide];
    public static string FromArrayToString(this IEnumerable<char> chars) => string.Join("", chars);
}