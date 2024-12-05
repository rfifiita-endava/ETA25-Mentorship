using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppETA25;

public static class Session5
{
    public static int x = 5;
    public static int y = 10;

    [Test]
    public static void AddXAndY()
    {
        Console.WriteLine($"The value of 'x + y' is: {x + y}");
    }

    [TestCase(5,6)]
    public static void AddTwoIntegers( int number1 , int number2 )
    {
        var result = number1 + number2;
        Console.WriteLine($"Adding '{number1}' and '{number2}' results in: {result}");
        
        var formatStr = "Adding '{0}' and '{1}' results in: {2}";
        Console.WriteLine(string.Format(formatStr, number1, number2, result));

    }
}
