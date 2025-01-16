using ConsoleAppETA25;
using System;
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
Console.WriteLine($"The result of ADDITION is: {1 + 1}");
Console.WriteLine($"The result of SUBSTRACTION is: {3 - 1}");
Console.WriteLine($"The result of MULTIPLICATION is: {3 * 3}");
Console.WriteLine($"The result of DIVISION is: {5 / 5}");
Console.WriteLine($"The result of MODULUS is: {7 % 5}");

var x = 10;
var y = x;
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

Console.WriteLine("Please insert the number of iterations considering we start from number 0: ");
int limit = Convert.ToInt32(Console.ReadLine());

int counter = 0;
//while (counter < limit)
//{
//    Console.WriteLine($"The current value of 'counter' is: {counter}");
//    counter++;
//}
//Console.WriteLine("Exited the WHILE loop!");


do
{
    Console.WriteLine($"The current value of 'counter' is: {counter}");
    //counter++;
}
while( counter < limit );

Console.WriteLine("Exited the DO-WHILE loop!");

Console.ReadKey();
