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
{
    charactername= Console.ReadLine(); 
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

if (charactername=="Red")
{
    Red(); 
}

static void Red()
{
    // Spawn punkt 
    Console.WriteLine("Du spawnar vid Merlin Academy"); 
    Console.WriteLine("Du börjar gå tills du möter Bridget hon säger att du måste välja mellan 3 vapen");

    List<string> vapen= ["Svärd","Pilbåge och pilar","Formelbok"];

    foreach (var item in vapen)
    {
        Console.WriteLine(item); 
    }

    Prompt(); 

    string vapenname=""; 
    bool flamingo= false; 

    while (!flamingo)
    {
        vapenname=Console.ReadLine(); 
        if (vapen.Contains(vapenname))
        {
            Console.WriteLine($"Du valde {vapenname}"); 
            flamingo= true; 
        }
    }

    // Vilken skurk man slåss mot
    Console.WriteLine("Beronde på vilket vapen du valde är det en annan skurk"); 
    
    int skurkHp = 1000;
    string skurkname=""; 
    int YourvapenHp=0;  
    

    if (vapenname=="Svärd")
    {
        YourvapenHp=40; 
        skurkname="Queen of hearts"; 
    }
    else if (vapenname=="Pilbåge och pilar")
    {
        YourvapenHp=70; 
        skurkname="Hook"; 
    }
    else if (vapenname=="Formelbok")
    {
        YourvapenHp=100;
        skurkname="Uliana"; 
    }

    fightning(vapenname,"Red",skurkname,YourvapenHp,skurkHp);

}

static void Chloe()
{

}

static void Prompt()
{
    Console.Write("> ");
}

static void uppgradesRed()
{
    int kr= 600;

    Console.WriteLine("1.Uppgradera vapnet HP till gånger 5 200kr");
    Console.WriteLine("2.Uppgradera vapnet HP till gånger 2 100kr");
    Console.WriteLine("3.Uppgradera vapnet HP till gånger 3 90 kr");

    string vilkenuppgradering=""; 
    while (vilkenuppgradering !="1" && vilkenuppgradering !="2" && vilkenuppgradering !="3" )
    {
        vilkenuppgradering=Console.ReadLine(); 
    }
    
    int priceperuppgradering=0; 

    if (vilkenuppgradering=="1")
    {
        priceperuppgradering=200; 
    }
    else if (vilkenuppgradering=="2")
    {
        priceperuppgradering=100; 
    }
    else if (vilkenuppgradering=="3")
    {
        priceperuppgradering=90; 
    }

    
    
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
    Console.WriteLine($"Yay du slog {bruteName}");
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
    Console.WriteLine($"Yay du lyckades rädda  {recsuename} och du lyckades med äventyret");

}
Console.ReadLine();