using System;


public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // if year is divisible by 4 and not by 100 is leap
        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        else if (year % 400 == 0)
        {
            return true;
        }

        return false;
    }
}

/*
public static class Leap
{
    public static bool IsLeapYear(int year) => 
        // maybe this approach is too much functional 
        year.NormalLeap() || year.FourHundredLeap();
    
        // The most concise solution but less readble in my honest opnion
        //year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
}

public static class LeapExtensions
{
    // i don't think extensions methods are really needed here 
    // but i in my opinion this kind of exercise are perfect to exeperiment with small pure function
    public static bool Module(this int year, int divisor) => year % divisor == 0;
    public static bool NormalLeap(this int year) => year.Module(4) && !year.Module(100);
    public static bool FourHundredLeap(this int year) => year.Module(400);
}
*/
