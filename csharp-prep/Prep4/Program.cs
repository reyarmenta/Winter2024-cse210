using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    }

    List<int> numbers = new List<int>();
    int input = 8;
    
    while (input != 0)
    {
        Console.WriteLine("Please enter a number:");
        input = Console.ReadLine();
        numbers.Add(input);
    }

}   
