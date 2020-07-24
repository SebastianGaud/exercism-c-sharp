using System;
using System.Collections.Generic;
using System.Linq;


public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        // get digits from number
        var digits = GetDigitFromNumber(number);

        // fare la potenza delle cifre
        var powArr = GetArrayWithDigitsPow(digits);

        // sommare le potenze delle cifre
        var sum = powArr.Sum();

        // confrontare la potenza con il numero originale
        bool isSameNumber = number == sum;
        return isSameNumber;
    }

    public static IEnumerable<int> GetDigitFromNumber(int num)
    {
        // estrapolare dal numero le cifre es: n° 153 -> 1 - 5 - 3
        var stringNum = num.ToString();
        return stringNum.Select(item => int.Parse(item.ToString()));
    }

    public static IEnumerable<int> GetArrayWithDigitsPow(IEnumerable<int> arrNum)
    {
        // un modo per calcolare la potenza
        var pow = arrNum.ToArray().Length;
        return arrNum.Select(item => (int)Math.Pow(item, pow));
    }
}