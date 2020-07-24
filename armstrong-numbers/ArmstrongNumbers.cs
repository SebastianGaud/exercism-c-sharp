using System;


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
        // un modo per determinare la potenza
        var sNum = number.ToString();
        var pow = sNum.Length;

        var digits = GetDigitFromNumber(number);

        // fare la potenza delle cifre
        var powArr = GetArrayWithDigitsPow(digits, pow);

        // sommare le potenze delle cifre
        var sum = SumArray(powArr);

        // confrontare la potenza con il numero originale
        // var isSameNumber = number == sum;
        // return isSameNumber;

        if (number == sum)
        {
            return true;
        }
        else {
            return false;
        }
    }


    public static int SumArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        return sum;
    }


    public static int[] GetDigitFromNumber(int num)
    {
        // estrapolare dal numero le cifre es: n° 153 -> 1 - 5 - 3
        var stringNum = num.ToString();

        // una lista on array dove inserire tutte le cifre
        int[] arrNum = new int[stringNum.Length];

        for (int i = 0; i < stringNum.Length; i++)
        {
            arrNum[i] = int.Parse(stringNum[i].ToString());
        }

        return arrNum;
    }

    public static int[] GetArrayWithDigitsPow(int[] arrNum, int pow)
    {
        // immagazzinare all'interno di un array le potenze
        int[] powNums = new int[arrNum.Length];

        // fare la potenza delle cifre all'interno dell'array
        for (int i = 0; i < arrNum.Length; i++)
        {
            powNums[i] = (int)Math.Pow(arrNum[i], pow);
        }

        return powNums;
    }
}