using NUnit.Framework;

namespace ConsoleAppETA25;
public static class IterationStatements
{
    [Test]
    public static void ForLoopTest()
    {
        var x = 10;
        for (var i = 0; i < x; i++)
        {
            Console.WriteLine($"For output when 'i' is: {i}");
        }
    }

    [TestCase(15)]
    public static void ForLoopTestParameter(int inputVal)
    {
        for (var i = 0; i < inputVal; i++)
        {
            Console.WriteLine($"For output when '{nameof(inputVal)}' is: {i}");
        }

        for (var i = inputVal; i > 0; i--)
        {
            Console.WriteLine($"Descending for output when '{nameof(inputVal)}' is: {i}");
        }
    }

    [Test]
    public static void ForeachLoopTest()
    {
        var lettersList = new List<string>() { "ABC", "BCD", "CDE", "DEF", "A", "B", "C"};

        for (var i = 0;i < lettersList.Count; i++)
        {
            Console.WriteLine($"The current list element is: {lettersList[i]}\n");
            //Console.WriteLine($"The current list element is (By ElementAt() ): {lettersList.ElementAt(i)}\n");
        }

        foreach (var letters in lettersList)
        {
            Console.WriteLine($"The current list element is (using foreach): {letters}");
        }

        Console.WriteLine("Exited the iteration statement!");
    }

    [Test]
    public static void ForeachLoopReversedTest()
    {
        var numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 6, 7, 8, 8, 9 };

        for (var i = numberList.Count - 1; i >= 0; i--)
        {
            Console.WriteLine($"The current in the reversed list order is: {numberList[i]}\n");
        }

        var numberListRev = numberList;
        numberListRev.Reverse();

        foreach (var number in numberListRev)
        {
            Console.WriteLine($"The current in the reversed list order is (using foreach): {number}\n");
        }

        Console.WriteLine("Exited the iteration statement!");
    }

    [Test]
    public static void NestedLoopTest()
    {
        var personList = new List<string>() { "Radu", "Marius", "Iulian", "Noemi", "Romana" };

        var favoriteFoods = new List<string>() { "Chicken", "Shawarma", "Pizza", "Fried Potatos", "Sarmale", "Mici" };

        for (int i = 0; i < personList.Count; i++)
        {
            var person = personList[i];

            if (person == "Marius")
            {
                for (int j = 0; j < favoriteFoods.Count; j++)
                {
                    var food = favoriteFoods[j];
                    if (food == "Pizza")
                    {
                        Console.Write($"{person}'s favorite foods are: ");
                        Console.Write($"{food}; ");
                        break;
                    }
                    Console.WriteLine($"The current food is: {food}");
                }
                Console.WriteLine();
                break;
            }
            Console.WriteLine($"The current person is: {person}");
        }
    }

    [Test]
    public static void ContinueTest()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine("The current number is: " + i);
        }
    }

}
