using System;

internal class Program
{
    private static void Main(string[] args)
    {
        TimeSpan Christmas = DateTime.Parse($"12/24/{DateTime.Now.Year} 00:00:00") - DateTime.Now;
        Console.WriteLine($"{Christmas.Days} days left until christmas");
    }
}}