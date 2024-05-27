// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Enter a first number: ");
int numFirst = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter a second number: ");
int numSecond = int.Parse(Console.ReadLine()??"0");

if (numFirst > numSecond)
{
    Console.WriteLine("The first number is greated than the second");
}

else
{
    Console.WriteLine("The second number is greater than the first");
}
