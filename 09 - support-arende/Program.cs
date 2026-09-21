Console.WriteLine("Felkods läsare (felkod 100 - 199 hårdvarufel, 200 - 299 mjukvarufel, annars okänt fel): ");

int felkod = int.Parse(Console.ReadLine() ?? "0");

switch(felkod)
{
    case int fel when (fel >= 100 && fel <= 199):
        Console.WriteLine("Hårdvarufel");
        break;
    case int fel when (fel >= 200 && fel <= 299):
        Console.WriteLine("Mjukvarufel");
        break;
    default:
        Console.WriteLine("Okänt fel");
        break;
}

Console.ReadKey();