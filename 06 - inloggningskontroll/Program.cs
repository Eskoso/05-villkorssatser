string correctUsername = "admin"; 
string correctPassword = "hemligt123"; 

Console.WriteLine("Ange användarnamn: ");
string username = Console.ReadLine();

Console.WriteLine("Ange lösenord: ");
string password = Console.ReadLine();

if (username == correctUsername && password == correctPassword)
{
    Console.WriteLine("Inloggning lyckades!");
}
else
{
    Console.WriteLine("Felaktigt användarnamn eller lösenord.");
}

Console.ReadKey();