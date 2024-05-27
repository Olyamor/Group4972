// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

Console.WriteLine("Enter a three-digit number: ");

int num = int.Parse(Console.ReadLine()??"0");
if (num > 100 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine("The last digit of " + num + " is " + lastDigit);
}

else
{
    Console.WriteLine("The number should be three-digit");
}