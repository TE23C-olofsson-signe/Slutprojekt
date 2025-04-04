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
    int kr = 600;
    // Spawn punkt 
    Console.WriteLine("Du spawnar vid Merlin Academy");
    Console.WriteLine("Du börjar gå tills du möter Bridget hon säger att du måste välja mellan 3 vapen");

    List<string> vapen = ["Trollstav", "Pilbåge och pilar", "Formelbok"];

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

    if (vapenname == "Trollstav")
    {
        YourvapenHp = 40;
        skurkname = "Hades";
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
    
    bool merlin=false; 

    if (!merlin)
    {
        vapenname="Trollstav";
        YourvapenHp=40; 
        merlin=true;
    }
    if (!merlin)
    {
        vapenname="Pilbåge och pilar";
        YourvapenHp=70; 
        merlin=true; 
    }
    if (!merlin)
    {
        vapenname="Formelbok";
        YourvapenHp=100;
        
    }

    (kr, YourvapenHp,vapenname) = uppgradesRed(kr, YourvapenHp,vapenname);

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
        vapenname= "Trollstav"; 
        skurkname= "Hades"; 
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
    Console.WriteLine("Du klarade fighten nu kan du köpa HPuppgraderningar till ditt vapen."); 
    (kr, YourvapenHp,vapenname) = uppgradesRed(kr,YourvapenHp,vapenname); 

    Console.WriteLine("Du har gjort ditt köp av hp uppgraderingar"); 
    Console.WriteLine("Du fortsätter och gå tills du kommer fram till en mur med 3 portar som ligger åt "); 

    List<string> portar =["Vänster","Mitten","Höger"];

    foreach (var item in portar)
    {
        Console.WriteLine(item); 
    }

    string väljport = ""; 
    bool underland= false; 

    while (!underland)
    {
        Prompt(); 
        väljport=Console.ReadLine(); 

        if (portar.Contains(väljport))
        {
            Console.WriteLine($"Du valde {väljport}");
            underland=true; 
        }
        else
        {
            Console.WriteLine("skriv en port från listan");
        }
    }

    int skurkHp3=2000;

    if (väljport=="Vänster")
    {
        vapenname="Trollstav";
        skurkname="Hades"; 
    } 
    else if (väljport=="Mitten")
    {
        vapenname="Pilbåge och pilar"; 
        skurkname="Hook"; 
    }
    else if (väljport=="Höger")
    {
        vapenname="Formelbok";
        skurkname="Ulina"; 
    }

    fightning(vapenname,"Red",skurkname,YourvapenHp,skurkHp3);
    Console.WriteLine("Du klarade fighten nu kan du köpa HPuppgraderningar till ditt vapen."); 

    (kr, YourvapenHp,vapenname) = uppgradesRed(kr, YourvapenHp,vapenname);

    Console.WriteLine("Du har gjort ditt köp av hp uppgraderingar"); 
    Console.WriteLine("Du fortsätter och gå tills du kommer fram till en väg med 3 dörrar"); 

    List<string>door=["Vänster","Mitten","Höger"];

    foreach (var item in door)
    {
        Console.WriteLine(item); 
    }

    string väljadoor=""; 
    bool evilspell= false; 

    while (!evilspell)
    {
        Prompt();
        väljadoor=Console.ReadLine(); 

        if (door.Contains(väljadoor))
        {
            Console.WriteLine($"Du valde dörren till {väljadoor}");
            evilspell=true; 
        }
        else
        {
            Console.WriteLine("skriv en Dörr från listan");
        }
    }

        Console.WriteLine("Beronde på vilket port du valde möter du samma skurk eller en annan och deras HP har ökat med 500"); 

        int skurkHp4=2500; 
        string savename=""; 
        
        if(väljadoor=="Vänster")
        {   
            savename="Chloe"; 
            skurkname="Hades";  
            Console.WriteLine($"när {skurkname}fick tillbaka sin kraft tog hon{savename} och nu måste du rädda henne ");
            vapenname="Trollstav";
        }
        else if (väljadoor=="Mitten")
        {
            savename="Ella"; 
            skurkname="Hook"; 
            Console.WriteLine($"när {skurkname}fick tillbaka sin kraft tog han{savename} och nu måste du rädda henne ");
            vapenname="Pilbåge och pilar"; 
        }
        else if (väljadoor=="Höger")
        {
            savename="Bridget"; 
            skurkname="Uliana"; 
            Console.WriteLine($"när {skurkname}fick tillbaka sin kraft tog hon{savename} och nu måste du rädda henne ");
            vapenname="Formelbok"; 
        }
        rescuefight(vapenname,"Red",savename,skurkname,YourvapenHp,skurkHp4); 

} 

if (charactername =="Chloe")
{
    Chloe();
}

static void Chloe()
{ 
    Console.WriteLine("Du spawnar vid Auradon prep"); 
    Console.WriteLine("Du börjar gå tills du möter Ella hon att du måste välja ett vapen för att möta en skurk (fast olika per vapen)");

    List<string>weapons = ["Kort","Klocka","Svärd"];

    foreach (var item in weapons)
    {
        Console.WriteLine(item); 
    } 

    string weaponName=""; 
    bool fire=false; 

    while(!fire)
    {
        weaponName=Console.ReadLine(); 
        Prompt(); 

        if (weapons.Contains(weaponName))
        {
            Console.WriteLine($"Du valde{weaponName} "); 
            fire=true; 
        }
        else
        {
            Console.WriteLine("Skriv ett vapen från listan"); 
        }
    }

}


static (int, int,string) uppgradesRed(int kr, int vapenHP,string vapen)
{

    Console.WriteLine("1.Uppgradera vapnet HP till gånger (5) 200kr");
    Console.WriteLine("2.Uppgradera vapnet HP till gånger (2) 100kr");
    Console.WriteLine("3.Uppgradera vapnet HP till gånger (3) 90 kr");

    string vilkenuppgradering = "";
    while (vilkenuppgradering != "1" && vilkenuppgradering != "2" && vilkenuppgradering != "3")
    {
        Prompt(); 
        vilkenuppgradering = Console.ReadLine();
    

    int priceperuppgradering = 0;

    if (vilkenuppgradering == "1")
    {
        priceperuppgradering = 200;
      if (vapen=="Trollstav")
      {
        vapenHP *= 5;    
      }
    else  if (vapen=="Pilbåge och pilar")
      {
        vapenHP *= 5;    
      }
     else if (vapen=="Formelbok")
      {
        vapenHP *= 5;    
      }
       
    }
    else if (vilkenuppgradering == "2")
    {
        priceperuppgradering = 100;
       if (vapen=="Trollstav")
       {
        vapenHP *= 2;      
       }
      else if (vapen=="Pilbåge och pilar")
       {
        vapenHP *= 2;      
       }
      else if (vapen=="Formelbok")
       {
        vapenHP *= 2;      
       }
        
    }
    else if (vilkenuppgradering == "3")
    {
        priceperuppgradering = 90;
        
        if(vapen=="Trollstav")
        {
            vapenHP *= 3; 
        }    
       else if(vapen=="Pilbåge och pilar")
        {
            vapenHP *= 3; 
        }    
       else if(vapen=="Formelbok")
        {
            vapenHP *= 3; 
        }    
        
    }

    kr -= priceperuppgradering;
}
     
     
    return (kr, vapenHP,vapen);
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