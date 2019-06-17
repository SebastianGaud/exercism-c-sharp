using System;
using System.Linq;


public static class Grains
{
    public static ulong Square(int n) => (ulong)Math.Pow(2, (n <= 0 || n > 64 ? throw new ArgumentOutOfRangeException() : n -1));

    public static ulong Total() => Enumerable.Range(1, 64).Select(Square).Aggregate((acc, val) => acc + val);
}