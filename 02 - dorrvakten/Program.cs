Console.WriteLine("Skriv in din ålder: ");

int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Du är minderårig.");
} else if (age >= 18)
{
    Console.WriteLine("Välkommen in!");
}

Console.ReadKey();