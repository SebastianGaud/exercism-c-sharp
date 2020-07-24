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
        var sum = SumArray(powArr);

        // confrontare la potenza con il numero originale
        bool isSameNumber = number == sum;
        return isSameNumber;

    }


    public static int SumArray(IEnumerable<int> arr)
    {
        return arr.Sum();
    }


    public static IEnumerable<int> GetDigitFromNumber(int num)
    {
        // estrapolare dal numero le cifre es: n° 153 -> 1 - 5 - 3
        var stringNum = num.ToString();

        // una lista on array dove inserire tutte le cifre
        foreach (var item in stringNum)
        {
            yield return int.Parse(item.ToString());
        }
    }

    public static IEnumerable<int> GetArrayWithDigitsPow(IEnumerable<int> arrNum)
    {
        // un modo per calcolare la potenza
        var pow = arrNum.ToArray().Length;

        foreach (var item in arrNum)
        {
            yield return (int)Math.Pow(item, pow);
        }
    }
}