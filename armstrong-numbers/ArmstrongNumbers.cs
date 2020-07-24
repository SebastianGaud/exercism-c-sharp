using System;
using System.Collections.Generic;
using System.Linq;


/*

    An Armstrong number is a number that is the sum of its own digits each raised to the power of the number of digits.

    For example:

        9 is an Armstrong number, because 9 = 9^1 = 9
        10 is not an Armstrong number, because 10 != 1^2 + 0^2 = 1
        153 is an Armstrong number, because: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        154 is not an Armstrong number, because: 154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190

    Write some code to determine whether a number is an Armstrong number.


*/


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
        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }
        return sum;
    }


    public static IEnumerable<int> GetDigitFromNumber(int num)
    {
        // estrapolare dal numero le cifre es: n° 153 -> 1 - 5 - 3
        var stringNum = num.ToString();

        // una lista on array dove inserire tutte le cifre
        var listNum = new List<int>();

        foreach (var item in stringNum)
        {
            listNum.Add(int.Parse(item.ToString()));
        }

        return listNum;
    }

    public static IEnumerable<int> GetArrayWithDigitsPow(IEnumerable<int> arrNum)
    {
        // immagazzinare all'interno di un array le potenze
        var list = new List<int>();

        // un modo per calcolare la potenza
        var pow = arrNum.ToArray().Length;

        foreach (var item in arrNum)
        {
            list.Add((int)Math.Pow(item, pow));
        }

        return list;
    }
}