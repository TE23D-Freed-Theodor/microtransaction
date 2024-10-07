using System;
using System.Threading;

int pengar = 1000;

void loadingAnimation()
{
    Console.Clear();
    for (int i = 0; i <= 2; i++)
    {
        Console.WriteLine(".");
        Thread.Sleep(200);
        Console.Clear();
        Console.WriteLine("..");
        Thread.Sleep(200);
        Console.Clear();
        Console.WriteLine("...");
        Thread.Sleep(200);
        Console.Clear();
    }
}

void welcome()
{
    loadingAnimation();
    Thread.Sleep(1000);
    Console.WriteLine(@"
              _                          
__      _____| | ___ ___  _ __ ___   ___ 
\ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \
 \ V  V /  __/ | (_| (_) | | | | | |  __/
  \_/\_/ \___|_|\___\___/|_| |_| |_|\___|");
    Console.WriteLine("");
    Console.WriteLine(@"_________________________________________");
    Console.WriteLine();
    Console.WriteLine();

    Thread.Sleep(1000);
}

welcome();
loadingAnimation();
Console.Clear();

Console.WriteLine($"Hej, du har {pengar} kr!");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Vad vill du köpa?");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine(@"+-------------------------------------------------+
|                  Proteinpulver                  |
|                                                 |
|   Kostar 249 kr för 750 g.                      |
|                                                 |
|   ✔ Aids in muscle recovery                     |
|   ✔ Supports exercise performance               |
|   ✔ Convenient for post-workout nutrition       |
+-------------------------------------------------+

+-------------------------------------------------+
|               Kreatinmonohydrat                 |
|                                                 |
|   Kostar 99 kr för 150 g.                       |
|                                                 |
|   ✔ Förbättrar styrka och muskelväxt            |
|   ✔ Populär efter träning                       |
|   ✔ Snabb och effektiv energikälla              |
+-------------------------------------------------+

+-------------------------------------------------+
|                   Preworkout                    |
|                                                 |
|   Kostar 28 kr per flaska.                      |
|                                                 | 
|   ✔ Ökar energi och fokus                       |
|   ✔ Innehåller ofta stimulerande ämnen          |
|   ✔ Perfekt för att maximera träningspasset     |
+-------------------------------------------------+
");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine();
string num;
int price = 0;
string item = "";

do
{
    Console.WriteLine("Enter 1 för proteinpulver!");
    Console.WriteLine("Enter 2 för kreatin");
    Console.WriteLine("Enter 3 för preworkout");
    num = Console.ReadLine();

    if (num == "1")
    {
        item = "proteinpulver";
        price = 249; // Priset för proteinpulver
    }
    else if (num == "2")
    {
        item = "kreatin";
        price = 99; // Priset för kreatin
    }
    else if (num == "3")
    {
        item = "preworkout";
        price = 28; // Priset för preworkout
    }
    else
    {
        Console.WriteLine("Ogiltigt val! Försök igen.");
    }
} while (string.IsNullOrEmpty(item)); // Fortsätt tills ett giltigt val görs

while (true)
{
    loadingAnimation();
    Console.Clear();
    Console.WriteLine($"Du har valt {item}. Hur många vill du ha?");
    string amount = Console.ReadLine();

    if (int.TryParse(amount, out int amountnum) && amountnum > 0)
    {
        int totalCost = amountnum * price;

        if (totalCost <= pengar)
        {
            pengar -= totalCost; // Dra av kostnaden från tillgängliga pengar
            Console.WriteLine($"Du har köpt {amountnum} av {item} för {totalCost} kr. Du har nu {pengar} kr kvar.");
            Thread.Sleep(3000);
            break; // Avsluta loopen efter ett lyckat köp
        }
        else
        {
            Console.WriteLine("Du har inte tillräckligt med pengar! Vänligen välj en mindre mängd.");
            Thread.Sleep(1500);
        }
    }
    else
    {
        Console.WriteLine("Ogiltig mängd! Ange ett positivt heltal.");
    }
}

Console.WriteLine($"Du har {pengar} kr kvar efter köpet.");
