//aega loetakse alates aastast 1970 millisekundites (UTC); nädalapäeva saame kätte numbrites kuni 6'ni, pühapäev on 0
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if(weekDay == 0)
{
    Console.WriteLine("It's Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("It's Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("It's Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("It's Wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("It's Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("It's Friday!");
}
else
{
    Console.WriteLine("It's Saturday!");
}

Console.WriteLine("Have a nice day!");