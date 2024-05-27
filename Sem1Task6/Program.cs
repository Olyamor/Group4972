// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter a number: ");

int num = int.Parse(Console.ReadLine()??"0");

if (num % 2 == 0)
{
    Console.WriteLine("The number " + num + " is even");
}

else 
{
    Console.WriteLine("The number " + num + " is odd");
}