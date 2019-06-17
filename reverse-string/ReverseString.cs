using System;
using System.Collections;


public static class ReverseString
{
    public static string Reverse(string input){
        var arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}