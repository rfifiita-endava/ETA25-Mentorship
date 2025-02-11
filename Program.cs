using ConsoleAppETA25;
using System;

# region Older Sessions
//Console.WriteLine("Hello, World!");

/*int number = 10;

const double Pi = 3.14159;


int i = default; // 0
float f = default;// 0
decimal d = default;// 0
bool b = default;// false
char c = default;// ''
string str = default;
Guid guid = default;

Console.WriteLine(number);
Console.WriteLine(Pi);
Console.WriteLine();
Console.Write(i);
Console.Write(f);
Console.Write(d);
Console.Write(b);
Console.Write(c);
Console.Write(str);
Console.Write(guid);*/

//Console.WriteLine("Please input your First name:");
//string firstName = Console.ReadLine();

//Console.WriteLine("Please input your Last name:");
//string lastName = Console.ReadLine();

//Console.WriteLine("Please input your age:");
//int age = Convert.ToInt16(Console.ReadLine());
//var computedAge = age + 20;

//Console.WriteLine("Please input your gender:");
//string gender = Console.ReadLine();

//Console.WriteLine($"\n Your details are as follows:\n" +
//    $"  - First name: {firstName} \n" +
//    $"  - Last name: {lastName} \n" +
//    $"  - Gender: {gender} \n" +
//    $"You will be {computedAge} year old in 20 years!");

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine($"Your details are as follows:");
//Console.WriteLine($"  - First name: {firstName}");
//Console.WriteLine($"  - Last name: {lastName}");
//Console.WriteLine($"  - Gender: {gender}");
//Console.WriteLine($"You will be {computedAge} year old in 20 years!");



// Session - C# Basics - Operators
//Console.WriteLine($"The result of ADDITION is: {1 + 1}");
//Console.WriteLine($"The result of SUBSTRACTION is: {3 - 1}");
//Console.WriteLine($"The result of MULTIPLICATION is: {3 * 3}");
//Console.WriteLine($"The result of DIVISION is: {5 / 5}");
//Console.WriteLine($"The result of MODULUS is: {7 % 5}");

//var x = 10;
//var y = x;
//Console.WriteLine($"The var 'x' has a value of: {x}");
//Console.WriteLine();
//Console.WriteLine($"After PRE INCREMENTATION var 'x' has a value of: {++x}");
//Console.WriteLine($"After POST INCREMENTATION var 'x' has a value of: {x++}");
//Console.WriteLine();
//Console.WriteLine($"After PRE DECREMENTATION var 'x' has a value of: {--x}");
//Console.WriteLine($"After POST DECREMENTATION var 'x' has a value of: {x--}");
//Console.WriteLine();
//Console.WriteLine($"The var 'x' has a value of: {x}");

//Console.WriteLine($"The initial value of 'y' is: {y}");         // 10

//y += 5;
//Console.WriteLine($"The result of ADDITION is: {y}");           // 15

//y -= 3;
//Console.WriteLine($"The result of SUBSTRACTION is: {y}");       // 12

//y *= 2;
//Console.WriteLine($"The result of MULTIPLICATION is: {y}");     // 24

//y /= 2;
//Console.WriteLine($"The result of DIVISION is: {y}");           // 12

//y %= 5;
//Console.WriteLine($"The result of MODULUS is: {y}");            // 2
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"The result of '==' between '{x}' and '{y}' is: {x == y}");
//Console.WriteLine($"The result of '!=' between '{x}' and '{y}' is: {x != y}");
//Console.WriteLine($"The result of '>' between '{x}' and '{y}' is: {x > y}");
//Console.WriteLine($"The result of '<' between '{x}' and '{y}' is: {x < y}");
//Console.WriteLine($"The result of '>=' between '{x}' and '{y}' is: {x >= y}");
//Console.WriteLine($"The result of '<=' between '{x}' and '{y}' is: {x <= y}");


bool raspuns = false;
bool raspuns2 = true;

//Console.WriteLine($"The NEGATION of raspuns is: {!raspuns}");               // TRUE
//Console.WriteLine($"The && operation output is: {raspuns && raspuns2}");    // FALSE
//Console.WriteLine($"The || operation output is: {raspuns || raspuns2}");    // TRUE


//Console.WriteLine($"The value of 'x' from Session5 class is: {Session5.x}");
//Console.WriteLine($"The value of 'y' from Session5 class is: {Session5.y}");
//Session5.AddXAndY();
//Console.WriteLine($"The result of adding x and y is:"); // 24

//Console.WriteLine("Please input some text!");
//var inputText = Console.ReadLine();
//Console.WriteLine($"You successfully wrote to console the following text: {inputText}");

//Console.WriteLine("Please insert the number of iterations considering we start from number 0: ");
//int limit = Convert.ToInt32(Console.ReadLine());

//int counter = 0;
//while (counter < limit)
//{
//    Console.WriteLine($"The current value of 'counter' is: {counter}");
//    counter++;
//}
//Console.WriteLine("Exited the WHILE loop!");


//do
//{
//    Console.WriteLine($"The current value of 'counter' is: {counter}");
//    //counter++;
//}
//while( counter < limit );

//Console.WriteLine("Exited the DO-WHILE loop!");
#endregion

#region ETA - Session 16
int[] numbers = [1, 2, 3, 4, 5];
string[] words = { "one", "two", "three", "ten" };

string[] letters = { "A", "R", "R", "A", "Y", "S" };

string firstItem = letters[0];
string secondItem = letters[1];

Console.WriteLine($"the first item is: {firstItem}");
Console.WriteLine("the second item is: " + secondItem);

string thirdItem = letters[2];
Console.WriteLine($"the third item is: {thirdItem}");
letters[2] = "X";
Console.WriteLine($"the updated third item is: {letters[2]}");

Console.Write("The 'letters' array consists of: ");
for(int i = 0; i < letters.Length; i++)
{
    Console.Write($"{letters[i]}; ");
}
Console.WriteLine();
Console.WriteLine("Multidimensional array (2D)");

// Multidimensional array (2D)
int[,] numbersMultiDim = { {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12} };

Console.WriteLine($"The second row - third cell item is: {numbersMultiDim[1,2]}\n");
Console.WriteLine("The elements in the 2D array are:");

for(int i = 0;i < numbersMultiDim.GetLength(0); i++)
{
    Console.WriteLine("The size of the rows is: " + numbersMultiDim.GetLength(1));
    for(int j = 0;j < numbersMultiDim.GetLength(1); j++)
    {
        Console.Write($"array[{i}, {j}]: {numbersMultiDim[i, j]}   ");
    }
    Console.WriteLine("\n");
}

// Jagged array
int[][] jaggedArray =
[
    [1, 2, 3],
    [4, 5],
    [6, 7, 8, 9],
    [10]
];

Console.WriteLine("The contents of the jagged array are:");
for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine($"The current row size is: {jaggedArray[i].GetLength(0)}");
    for(int j = 0; j < jaggedArray[i].GetLength(0); j++)
    {
        Console.Write($"array[{i}][{j}]: {jaggedArray[i][j]}  ");
    }
    Console.WriteLine("\n");
}
Console.WriteLine("\n");

// Lists
List<string> letterList = new List<string>() { "L", "I", "S", "T" };

Console.WriteLine($"First item in the list: {letterList[0]}");
Console.WriteLine($"Third item in the list: {letterList.ElementAt(2)}");
letterList[2] = "Z";
Console.WriteLine($"Third item in the list: {letterList.ElementAt(2)}");

Console.WriteLine("\nThe list contains the following items: ");
foreach(string letter in letterList)
{
    Console.Write($"{letter}; ");
}
Console.WriteLine();

Console.WriteLine($"The list size and capacity are: {letterList.Count} / {letterList.Capacity}");
letterList.Add("B");
foreach (string letter in letterList)
{
    Console.Write($"{letter}; ");
}
Console.WriteLine();

Console.WriteLine($"The list size and capacity are: {letterList.Count} / {letterList.Capacity}");
letterList.Add("C");
foreach (string letter in letterList)
{
    Console.Write($"{letter}; ");
}
Console.WriteLine();

Console.WriteLine($"The list size and capacity are: {letterList.Count} / {letterList.Capacity}");
letterList.Remove("I");
foreach (string letter in letterList)
{
    Console.Write($"{letter}; ");
}
Console.WriteLine();

Console.WriteLine($"The list size and capacity are: {letterList.Count} / {letterList.Capacity}");

#endregion

Console.ReadKey();
