// Välja vilken karaktär 
bool done = false;
string charactername = "";

List<string> character = ["Red", "Chloe"];

foreach (var item in character)
{
    Console.WriteLine(item);
}


while (!done)
{
    Prompt();
    charactername = Console.ReadLine();
    if (character.Contains(charactername))
    {
        Console.WriteLine($"nu är du {charactername}");
        done = true;
    }
    else
    {
        Console.WriteLine("Skriv ett namn från listan");
    }
}

if (charactername == "Red")
{
    Red();
}

static void Red()
{
    int kr = 1000;
    // Spawn punkt 
    Console.WriteLine("Du spawnar vid Merlin Academy");
    Console.WriteLine("Du börjar gå tills du möter Bridget hon säger att du måste välja mellan 3 vapen");

    List<string> vapen = ["Svärd", "Pilbåge och pilar", "Formelbok"];

    foreach (var item in vapen)
    {
        Console.WriteLine(item);
    }


    string vapenname = "";
    bool flamingo = false;

    while (!flamingo)
    {
        Prompt();
        vapenname = Console.ReadLine();
        if (vapen.Contains(vapenname))
        {
            Console.WriteLine($"Du valde {vapenname}");
            flamingo = true;
        }
        else
        {
            Console.WriteLine("Skriv ett vapen från listan"); 
        }
    }

    // Vilken skurk man slåss mot
    Console.WriteLine("Beronde på vilket vapen du valde är det en annan skurk");

    int skurkHp = 1000;
    string skurkname = "";
    int YourvapenHp = 0;

    if (vapenname == "Svärd")
    {
        YourvapenHp = 40;
        skurkname = "Queen of hearts";
    }
    else if (vapenname == "Pilbåge och pilar")
    {
        YourvapenHp = 70;
        skurkname = "Hook";
    }
    else if (vapenname == "Formelbok")
    {
        YourvapenHp = 100;
        skurkname = "Uliana";
    }

    fightning(vapenname, "Red", skurkname, YourvapenHp, skurkHp);
    
    Console.WriteLine("Du klarade fighten nu kan du köpa HPuppgraderningar till ditt vapen."); 
    (kr, YourvapenHp) = uppgradesRed(kr, YourvapenHp);

    Console.WriteLine("Du har gjort ditt köp av vapenhp uppgradering du börjar gå till du kommer till en vägkorsning du kan gå åt "); 
    List<string> direktion = ["Vänster","Framåt","Höger"]; 

    foreach (var item in direktion)
    {
        Console.WriteLine(item); 
    }

    string väljadirektion="" ;
    bool heart= false; 

    while (!heart)
    {
        Prompt();
        väljadirektion=Console.ReadLine();

        if (direktion.Contains(väljadirektion))
        {
            Console.WriteLine($"Du valde att gå{väljadirektion}");
            heart=true; 
        }
        else

        {
            Console.WriteLine("Skriv ett direktion från listan"); 
        }
    }

    Console.WriteLine("Beronde på vilket håll du valde möter du samma skurk eller en annan och deras HP har ökat med 500"); 

    int skurkHp2=1500; 
    
    if (väljadirektion=="Vänster")
    {
        vapenname= "Svärd"; 
        skurkname= "Queen of hearts"; 
    }
    else if (väljadirektion=="Framåt")
    {
        vapenname="Pilbåge och pilar";
        skurkname="Hook"; 
    }
    else if(väljadirektion=="Höger"){
        vapenname="Formelbok"; 
        skurkname="Uliana"; 
    }

    fightning(vapenname,"Red",skurkname,YourvapenHp,skurkHp2);
} 

static void Chloe()
{

}
static (int, int) uppgradesRed(int kr, int vapenHP)
{

    Console.WriteLine("1.Uppgradera vapnet HP till gånger (5) 200kr");
    Console.WriteLine("2.Uppgradera vapnet HP till gånger (2) 100kr");
    Console.WriteLine("3.Uppgradera vapnet HP till gånger (3) 90 kr");

    Prompt(); 
    string vilkenuppgradering = "";
    while (vilkenuppgradering != "1" && vilkenuppgradering != "2" && vilkenuppgradering != "3")
    {
        vilkenuppgradering = Console.ReadLine();
    

    int priceperuppgradering = 0;

    if (vilkenuppgradering == "1")
    {
        priceperuppgradering = 200;
        vapenHP *= 5;
    }
    else if (vilkenuppgradering == "2")
    {
        priceperuppgradering = 100;
        vapenHP *= 2; 
    }
    else if (vilkenuppgradering == "3")
    {
        priceperuppgradering = 90;
        vapenHP *= 3;  
    }

    kr -= priceperuppgradering;
}
     
     
    return (kr, vapenHP);
}

static void Prompt()
{
    Console.Write("> ");
}


static void fightning(string weapon, string characterName, string bruteName, int weaponHp, int bruteHp)
{
    Console.WriteLine($"{characterName} attackerar med sitt {weapon} battles {bruteName} ");

    while (bruteHp > 0)
    {
        Console.WriteLine($"\n-----==== Slå {bruteName}====----");
        Console.WriteLine($"{characterName}:{weapon}:{weaponHp} {bruteName}:{bruteHp}\n");

        int weaponDamage = weaponHp;
        bruteHp -= weaponDamage;
        bruteHp = Math.Max(0, bruteHp);
        Console.WriteLine($"{weapon} gör{weaponDamage} på {bruteName}");
        Console.ReadKey();
    }
    Console.WriteLine($"Yay du slog {bruteName}");
}

static void rescuefight(string weapon, string characterName, string recsuename, string bruteName, int weaponHp, int bruteHp)
{
    Console.WriteLine($"{characterName} attackerar{bruteName} med {weapon}");

    while (bruteHp > 0)
    {
        Console.WriteLine($"\n-----==== Rädda {recsuename}====----");
        Console.WriteLine($"{characterName}:{weapon}:{weaponHp} {bruteName}:{bruteHp}\n");

        int weaponDamage = weaponHp;
        bruteHp -= weaponDamage;
        bruteHp = Math.Max(0, bruteHp);
        Console.WriteLine($"{weapon} gör{weaponDamage} på {bruteName}");
        Console.ReadKey();
    }
    Console.WriteLine($"Yay du lyckades rädda  {recsuename} och du lyckades med äventyret");

}
Console.ReadLine();