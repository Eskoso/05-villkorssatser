Console.WriteLine("Skriv in temperaturen: ");

double temperature = double.Parse(Console.ReadLine());

if (temperature < 0.0d)
{
    Console.WriteLine("Det är minusgrader.");
}
else if (temperature >= 0.0d)
{
    Console.WriteLine("Det är plusgrader.");
}

Console.ReadKey();
