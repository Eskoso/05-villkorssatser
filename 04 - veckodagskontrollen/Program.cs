Console.WriteLine("skriv in en siffra mellan 1-7: ");

int day = int.Parse(Console.ReadLine());

switch(day)
{
    case 1:
        Console.WriteLine("Måndag");
        break;
    case 2:
        Console.WriteLine("Tisdag");
        break;
    case 3:
        Console.WriteLine("Onsdag");
        break;
    case 4:
        Console.WriteLine("Torsdag");
        break;
    case 5:
        Console.WriteLine("Fredag");
        break;
    case 6:
        Console.WriteLine("Lördag");
        break;
    case 7:
        Console.WriteLine("Söndag");
        break;
    default:
        Console.WriteLine("Felaktig siffra.");
        break;
}

Console.ReadKey();