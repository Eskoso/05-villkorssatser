Console.WriteLine("är du en student? (ja/nej): ");
string student = Console.ReadLine() ?? "";

if (student.ToLower() == "ja")
{
    Console.WriteLine("Har du ett giltigt studentkort? (ja/nej): ");

    string studentkort = Console.ReadLine() ?? "";

    if (studentkort.ToLower() == "ja")
    {
        Console.WriteLine("Du får 20% rabatt!");
    }
    else
    {
        Console.WriteLine("Tyvärr, då kan du bara få 10% rabatt.");
    }
}
else if (student.ToLower() == "nej")
{
    Console.WriteLine("Tyvärr, ingen rabatt för dig.");
}
else
{
    Console.WriteLine("Ogiltigt svar. Vänligen svara med 'ja' eller 'nej'.");
}

Console.ReadKey();
