// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter a first number: ");
int numFirst = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter a second number: ");
int numSecond = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter a third number: ");
int numThird = int.Parse(Console.ReadLine()??"0");

if (numFirst > numSecond && numFirst > numThird)
{
    Console.WriteLine("The first number is the greatest");
}

else if (numSecond > numFirst && numSecond > numThird)
{
    Console.WriteLine("The second number is the greatest");
}
else if (numThird > numFirst && numThird > numSecond)
{
    Console.WriteLine("The third number is the greatest");
}

else 
{
    Console.WriteLine("The numbers are even. Enter another numbers.");
}