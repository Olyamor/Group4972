// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

Console.WriteLine("Enter a first number: ");
int firstNum = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Enter a second number: ");
int secondNum = int.Parse(Console.ReadLine()?? "0");

if (firstNum == Math.Pow(secondNum, 2))
{
    Console.WriteLine("First number is a square of second number");
}

else
{
    Console.WriteLine("First number is not a square of second number");
}   