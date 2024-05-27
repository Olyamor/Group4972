// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

Console.WriteLine("Enter day of week: ");
int day = int.Parse(Console.ReadLine()??"0");
string[] dayOfWeek = new string[7];

dayOfWeek[0] = "Monday";
dayOfWeek[1] = "Tuesday";
dayOfWeek[2] = "Wednesday";
dayOfWeek[3] = "Thursday";
dayOfWeek[4] = "Friday";
dayOfWeek[5] = "Saturday";
dayOfWeek[6] = "Sunday";

if (day <=7)
{
    Console.WriteLine(dayOfWeek [day - 1]);
}

else if (day == 0)
{
    Console.WriteLine("Choose a number from 1 to 7");
}

else
{
    Console.WriteLine("Choose a number from 1 to 7");
}

// Console.WriteLine("Enter day of week");
// int dayNum = int.Parse(Console.ReadLine());

// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("kr-Kr").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1));

// Console.WriteLine(outDayOfWeek);