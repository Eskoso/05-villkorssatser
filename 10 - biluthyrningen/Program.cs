Console.WriteLine("Välkommen till biluthyrningen!");
Console.WriteLine("Du behöver vara minst 25 år och haft körkort i minst 3 år: ");
Console.WriteLine("Hur gammal är du?");

int age = int.TryParse(Console.ReadLine() ?? "0", out int parsedAge) ? parsedAge : 0;

if (age >= 25)
{
    Console.WriteLine("Hur många år har du haft körkort?");
    int yearsWithLicense = int.TryParse(Console.ReadLine() ?? "0", out int parsedYears) ? parsedYears : 0;
    if (yearsWithLicense >= 3)
    {
        Console.WriteLine("Du är berättigad att hyra en bil.");
    }
    else
    {
        Console.WriteLine("Tyvärr, du måste ha haft körkort i minst 3 år för att hyra en bil.");
    }
}
else
{
    Console.WriteLine("Tyvärr, du uppfyller inte kraven för att hyra en bil.");
}

Console.ReadKey();