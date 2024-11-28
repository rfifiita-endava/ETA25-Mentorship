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

Console.WriteLine("Please input your First name:");
string firstName = Console.ReadLine();

Console.WriteLine("Please input your Last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Please input your age:");
int age = Convert.ToInt16(Console.ReadLine());
var computedAge = age + 20;

Console.WriteLine("Please input your gender:");
string gender = Console.ReadLine();

Console.WriteLine($"\n Your details are as follows:\n" +
    $"  - First name: {firstName} \n" +
    $"  - Last name: {lastName} \n" +
    $"  - Gender: {gender} \n" +
    $"You will be {computedAge} year old in 20 years!");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Your details are as follows:");
Console.WriteLine($"  - First name: {firstName}");
Console.WriteLine($"  - Last name: {lastName}");
Console.WriteLine($"  - Gender: {gender}");
Console.WriteLine($"You will be {computedAge} year old in 20 years!");


Console.ReadKey();
