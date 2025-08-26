// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 10;
var name = "Jesus Torres"; // C# automatically detects the type using var as data type

// using string interpolation with $ to display variables
Console.WriteLine($"Name: {name}, Age: {age}");

for (int i = 0; i <= 10; i++)
{
   Console.WriteLine($"{i} years pass... I am now {age + i} years old");
   Thread.Sleep(50);
}

