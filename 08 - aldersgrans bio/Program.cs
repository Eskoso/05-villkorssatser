Console.WriteLine("Hur gammal är du?");

int ålder = int.Parse(Console.ReadLine() ?? "0");

if (ålder < 6)
{
    Console.WriteLine("Barntillåten film");
}
else if (ålder >= 6 && ålder <= 10)
{
    Console.WriteLine("från 7 år");
}
else if (ålder > 10 && ålder <= 14)
{
    Console.WriteLine("från 11 år");
}
else
{
    Console.WriteLine("från 15 år");
}

Console.ReadKey();
