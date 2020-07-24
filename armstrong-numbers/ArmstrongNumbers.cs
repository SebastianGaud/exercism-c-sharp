using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number) =>
         number.GetDigitFromNumber().GetArrayWithDigitsPow().Sum() == number;
}

public static class IntExtenstions
{
    public static IEnumerable<int> GetDigitFromNumber(this int num)
    {
        // estrapolare dal numero le cifre es: n° 153 -> 1 - 5 - 3
        var stringNum = num.ToString();
        return stringNum.Select(item => int.Parse(item.ToString()));
    }

    public static IEnumerable<int> GetArrayWithDigitsPow(this IEnumerable<int> arrNum)
    {
        // un modo per calcolare la potenza
        var pow = arrNum.ToArray().Length;
        return arrNum.Select(item => (int)Math.Pow(item, pow));
    }
}