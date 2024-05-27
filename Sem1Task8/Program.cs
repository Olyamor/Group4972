// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter a number: ");
int numN = int.Parse(Console.ReadLine()??"0");
int evNumN = numN - (numN - 1);

if (numN == 1)
{
    Console.WriteLine("Please choose a greater number");
}

else
{
    while (evNumN < numN)
{
    if (evNumN % 2 == 0)
    {
        Console.Write(evNumN + ", ");
    evNumN++;
    }
    else
    {
        evNumN++;
    }

}
if (numN % 2 == 0)
{
    Console.Write(numN);
}

}
