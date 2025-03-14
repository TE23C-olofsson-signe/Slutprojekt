// Välja vilken karaktär 
bool done = false; 
string charactername=""; 

List<string>character =["Red","Chloe"];

foreach (var item in character)
{
    Console.WriteLine(item); 
}

static void Prompt()
{
    Console.WriteLine(">"); 
}

static void fightning(string weapon,string characterName,string bruteName,int weaponHp,int bruteHp)
{
    Console.WriteLine($"{characterName} attackerar{bruteName} med {weapon}"); 

    while(bruteHp>0)
    {
        Console.WriteLine($"\n-----==== Slå {bruteName}====----");
        
    }
}
Console.ReadLine(); 