using System;
using System.Collections.Generic;


public static class ResistorColor
{
    public static int ColorCode(string color) => new List<string>(Colors()).IndexOf(color);
    public static string[] Colors() => new [] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
}