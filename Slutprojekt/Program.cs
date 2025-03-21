// Välja vilken karaktär 
bool done = false;
string charactername = "";

List<string> character = ["Red", "Chloe"];

foreach (var item in character)
{
    Console.WriteLine(item);
}

Prompt();

while (!done)
charactername= Console.ReadLine(); 
{
    if (character.Contains(charactername))
    {
        Console.WriteLine($"nu är du {charactername}"); 
        done=true; 
    }
    else
    {
        Console.WriteLine("Skriv ett namn från listan");
    }
}

static void Red()
{
    Console.WriteLine("Du spawnar vid Merlin Academy"); 
    Console.WriteLine("Du börjar gå tills du möter Bridget hon säger att du måste välja mellan 3 vapen att köpa du har 120kr");
    
    int kr=120;
    int cost=0; 

    Console.WriteLine("Svärd (10kr)"); 
}

static void Chloe()
{

}

static void Prompt()
{
    Console.WriteLine(">");
}

static void fightning(string weapon, string characterName, string bruteName, int weaponHp, int bruteHp)
{
    Console.WriteLine($"{characterName} attackerar{bruteName} med {weapon}");

    while (bruteHp > 0)
    {
        Console.WriteLine($"\n-----==== Slå {bruteName}====----");
        Console.WriteLine($"{characterName}:{weapon}:{weaponHp} {bruteName}:{bruteHp}\n");

        int weaponDamage = weaponHp;
        bruteHp = -weaponDamage;
        bruteHp = Math.Max(0, bruteHp);
        Console.WriteLine($"{weapon} gör{weaponDamage} på {bruteName}");
        Console.ReadKey();
    }
}

static void rescuefight(string weapon, string characterName, string recsuename, string bruteName, int weaponHp2, int bruteHp2)
{
        Console.WriteLine($"{characterName} attackerar{bruteName} med {weapon}");

    while (bruteHp2 > 0)
    {
        Console.WriteLine($"\n-----==== Rädda {recsuename}====----");
        Console.WriteLine($"{characterName}:{weapon}:{weaponHp2} {bruteName}:{bruteHp2}\n");

        int weaponDamage = weaponHp2;
        bruteHp2 = -weaponDamage;
        bruteHp2 = Math.Max(0, bruteHp2);
        Console.WriteLine($"{weapon} gör{weaponDamage} på {bruteName}");
        Console.ReadKey();
    }

}
Console.ReadLine();