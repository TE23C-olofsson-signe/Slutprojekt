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
    
    int skurkHp = 600;
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
        YourvapenHp=90;
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
    int 
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