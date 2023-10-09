using System;
using System.Collections.Generic;
using System.Linq;


#region Distinct
/*
   class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5 };

        IEnumerable<int> uniqueNumbers = numbers.Distinct();

        Console.WriteLine("Unique Numbers:");

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/

#endregion

#region Skip
/*
   class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var skippedNumbers = numbers.Skip(5);

        Console.WriteLine("Skipped Numbers:");
        foreach (var number in skippedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/
#endregion

#region Take
/*
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var takenNumbers = numbers.Take(3);

        Console.WriteLine("Taken Number:");

        foreach (var number in takenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/
#endregion

#region Concat
/*
class Program
{
    static void Main()
    {
        int[] numbers1 = { 1, 2, 3 };
        int[] numbers2 = { 4, 5, 6 };

        var concatenatedNumbers = numbers1.Concat(numbers2);

        Console.WriteLine("Concatenated Numbers:");

        foreach (var number in concatenatedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/
#endregion

#region Insersect
/*
class Program
{
    static void Main()
    {
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        int[] numbers2 = { 3, 4, 5, 6, 7 };

        var commonNumbers = numbers1.Intersect(numbers2);

        Console.WriteLine("Kesişen Sayılar:");

        foreach (var number in commonNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/
#endregion

#region Last

/*
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int lastNumber = numbers.Last();

        Console.WriteLine("Last Number: " + lastNumber);
    }
}
*/

#endregion

#region Repeat
/*
class Program
{
    static void Main()
    {
        int numberToRepeat = 42;
        int repeatCount = 5;

        var repeatedNumbers = Enumerable.Repeat(numberToRepeat, repeatCount);

        Console.WriteLine("Repeated Numbers:");

        foreach (var number in repeatedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/
#endregion

#region Reverse
/*
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        var reversedNumbers = numbers.Reverse();

        Console.WriteLine("Reversed Numbers:");

        foreach (var number in reversedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/
#endregion