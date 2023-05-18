int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //vahemik 0 - 6; switch sobib selleks, et kontrollida ainult ühte kindlat väärtust ja võimalikke väärtusi on rohkem, kui 2.

switch (weekDay)//väärtus, mida kontrollitakse
{
    case 0: //case 0: tähendab sama asja, kui if(weekDay == 0)
        Console.WriteLine("It's Sunday");
        break; //kui pühapäeval programmi kasutada, siis kontrollib, kas weekDay on 0 ja kui on, siis katkestab selle blocki
    case 1:
        Console.WriteLine("It's Monday");
        break;
    case 2:
        Console.WriteLine("It's Tuesday");
        break;
    case 3:
        Console.WriteLine("It's Wednesday");
        break;
    case 4:
        Console.WriteLine("It's Thursday");
        break;
    case 5:
        Console.WriteLine("It's Friday");
        break;
    case 6:
        Console.WriteLine("It's Saturday");
        break;
    default:// kui panna switch weekDay = 10, siis kontrollib, kas võrdub 10, kui ei, siis väljastab default
        Console.WriteLine("Oops. Your calendar must be broken.");
        break;
}

Console.WriteLine("Have a nice day!");