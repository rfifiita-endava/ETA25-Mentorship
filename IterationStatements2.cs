﻿using NUnit.Framework;

namespace ConsoleAppETA25;
public static class IterationStatements2
{
    [Test]
    public static void WhileLoopTest()
    {
        var limit = 5;
        while (limit < 10)
        {
            Console.WriteLine($"The current limit is: {limit}");
            limit++;
        }
        Console.WriteLine("Exited the WHILE loop!");
    }

    [TestCase(20)]
    public static void WhileLoopTestParams(int limit)
    {
        int counter = 0;
        while (counter < limit)
        {
            Console.WriteLine($"The current counter value is: {counter}");
            counter++;
        }
        Console.WriteLine("Exited the WHILE loop!");
    }

    [Test]
    public static void DoWhileLoopTest()
    {
        int counter = 1;
        do
        {
            Console.WriteLine($"The current value of counter is: {counter}");
            counter++;
        }
        while (counter <= 10);

        Console.WriteLine("Exited the DO-WHILE loop!");
    }

    [Test]
    public static void DoWhileLoopBreakTest()
    {
        int counter = 1;
        do
        {
            Console.WriteLine($"The current value of the counter is: {counter}");

            if (counter == 5)
            {
                Console.WriteLine("Exiting the LOOP using BREAK!");
                break;
            }
            counter++;
        }
        while (counter <= 10);

        Console.WriteLine("Exited the DO-WHILE loop.");
    }

    [Test]
    public static void DoWhileBreakTest2()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 6, 7 };

        int i = 0;
        do
        {
            Console.WriteLine($"The value for list[i] is: {list[i]}");

            if (list[i] == 6)
            {
                Console.WriteLine("Breaking the loop!");
                break;
            }
            i++;
        }
        while (i < list.Count);

        Console.WriteLine("EXITED the DO-WHILE loop!");
    }


    [Test]
    public static void DoWhileContinueTest()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 6, 7 };

        int i = 0;
        do
        {
            Console.WriteLine($"The value for list[i] is: {list[i]}");

            if (list[i] == 6)
            {
                i++;
                Console.WriteLine("Skipping the list item");
                continue;
            }
            i++;
        }
        while (i < list.Count);

        Console.WriteLine("EXITED the DO-WHILE loop!");
    }


    [Test]
    public static void WhileContinueTest()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 6, 7 };

        int i = 0;
        while (i < list.Count)
        {
            Console.WriteLine($"The value for list[i] is: {list[i]}");

            if (list[i] == 6)
            {
                i++;
                Console.WriteLine("Skipping the list item");
                continue;
            }
            i++;
        }

        Console.WriteLine("EXITED the DO-WHILE loop!");
    }
}
