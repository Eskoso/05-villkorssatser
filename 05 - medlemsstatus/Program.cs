Console.WriteLine("Skriv in din medlemsnivå (Basic/Standard/Premium): ");

string medlemsnivå = Console.ReadLine() ?? "";

switch (medlemsnivå.ToLower())
{
    case "basic":
        Console.WriteLine("Basic: 99 kr");
        break;
    case "standard":
        Console.WriteLine("Standard: 149 kr");
        break;
    case "premium":
        Console.WriteLine("Premium: 199 kr");
        break;
    default:
        Console.WriteLine("Ogiltig medlemsnivå. Vänligen välj Basic, Standard eller Premium.");
        break;
}

Console.ReadKey();
