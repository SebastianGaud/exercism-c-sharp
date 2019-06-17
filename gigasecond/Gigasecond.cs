using System;

public static class Gigasecond
{
    //We use scientific notation 1E9 for simplicity. 
    //Writing 1000000000 would be the same, without counting 300 milliseconds of execution time...


    /* 
        Other ways of writing gigaseconds:
            - 1_000_000_000
            - 1000000000
            - 1E9
            - Math.Pow(10, 9)
    
    */
    private const double scientificGigaseond = 1E9;
    public static DateTime Add(DateTime moment) 
        => moment.AddSeconds(scientificGigaseond);
}