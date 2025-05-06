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
    (kr, YourvapenHp) = uppgradesRed(kr,YourvapenHp); 

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

    (kr, YourvapenHp) = uppgradesRed(kr, YourvapenHp);

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

    string villainName=""; 
    int villainHp=2000;
    int YourweaponHp=0; 

    if(weaponName=="Kort")
    {
        villainName="Malificent"; 
        YourweaponHp=50; 
    } 
    else if (weaponName=="Klocka")
    {
        villainName="Morgie";
        YourweaponHp=90; 
    }
    else if (weaponName=="Svärd")
    {
        villainName="Queen of hearts";
        YourweaponHp=100; 
    }

    fightning(weaponName,"Chloe",villainName,YourweaponHp,villainHp);
    Console.WriteLine("Du vann nu kan du välja att uppgradera ditt vapenhp"); 
   
    int coins=1000; 

    while (coins>0)
    {
        
        Console.WriteLine($"Du har {coins} kronor kvar"); 

        Console.WriteLine("Vilken  vapenhp uppgradering vill du köpa"); 
       
        Console.WriteLine("1. vapnets Hp gånger 5(250kr) ");
        Console.WriteLine("2. vapnets Hp gånger 3(100kr) ");
        Console.WriteLine("3. vapnets Hp gånger 2(200kr) ");

        string vilkenupgrade=""; 
        while (vilkenupgrade !="1"&& vilkenupgrade!="2"&&vilkenupgrade!="3")
        {
            Prompt();
            vilkenupgrade=Console.ReadLine(); 
        }

        int priceperupgrade=0; 
         

        if (vilkenupgrade=="1")
        {
            priceperupgrade=250;
          
        }
        else if (vilkenupgrade=="2"){
            priceperupgrade=100; 
        }
        else if (vilkenupgrade=="3")
        {
            priceperupgrade=200; 
        }

        Console.WriteLine("Hur många vill du köpa");

       int howmany=0; 

       while(howmany==0)
       {
        string antal=Console.ReadLine(); 
        bool vase =int.TryParse(antal,out howmany); 
        
        if (vase==false)
        {
            Console.WriteLine("Du måste skriva en siffra"); 
        }
       }

       int finalcost= priceperupgrade * howmany; 

       if (finalcost<=coins)
       {
        Console.WriteLine("Ja det går bra. "); 
        coins -= finalcost; 
       }
       else{
        Console.WriteLine("Nej du har för lite pengar"); 
       }
       
       if (vilkenupgrade == "1")
       {
        YourweaponHp *= 5 * howmany;     
       }
       if (vilkenupgrade == "2")
       {
         YourweaponHp *= 3 * howmany;      
      }
       
       if (vilkenupgrade == "3")
       {
       YourweaponHp *= 2 * howmany; 
       }

    }

    Console.WriteLine("Nu har du uppgraderat ditt vapenHp"); 

    Console.WriteLine("Du börjar gå tills du kommer till en korsning du kan gå "); 

    List<string>path=["Vänster","Framåt","Höger"];

    foreach (var item in path)
    {
        Console.WriteLine(item); 
    }

    string choosepath=""; 
    bool waterfountain=false;

    while (!waterfountain)
    {
        choosepath=Console.ReadLine(); 
        Prompt(); 
        if (path.Contains(choosepath))
        {
            Console.WriteLine($"Du valde {choosepath} "); 
            waterfountain=true; 
        }
        else
        {
            Console.WriteLine("Skriv ett väg från listan");
        }
    } 
    Console.WriteLine("Du får olika skurkar för varje väg och skurkenshp har ökat med +1000 (för varje fight)");

    int villainHp2=3000;

    if (choosepath=="Vänster")
    {
        weaponName="Kort"; 
        villainName="Malificent";
    }
    else if (choosepath=="Framåt")
    {
        weaponName="Klocka"; 
        villainName="Morgie"; 
    }
    else if (choosepath=="Höger")
    {
        weaponName="Svärd";
        villainName="Queen of hearts"; 
    }

    fightning(weaponName,"Chloe",villainName,YourweaponHp,villainHp2);

    Console.WriteLine("Du börjar gå tills du kommer till en mur med tre portar"); 
    
    List<string>Gate=["Vänster","Mitten","Höger",];

    foreach (var item in Gate)
    {
        Console.WriteLine(item);
    }

    string chooseGate=""; 
    bool school=false; 

    while(!school)
    {
        chooseGate=Console.ReadLine(); 
        Prompt();
        
        if (Gate.Contains(chooseGate))
        {
            Console.WriteLine($"Du valde {chooseGate}"); 
            school=true;
        }
        else
        {
            Console.WriteLine("Välj en port "); 
        }
    }

    int villainHp3=4000;

    if (chooseGate=="Vänster")
    {
        weaponName="Kort";
        villainName="Malificent"; 
    }
    else if (chooseGate=="Mitten")
    {
        weaponName="Klocka";
        villainName="Morgie";
    }
    else if (chooseGate=="Höger")
    {
        weaponName="Svärd";
        villainName="Queen of hearts"; 
    }
    fightning(weaponName,"Chloe",villainName,YourweaponHp,villainHp3);

    Console.WriteLine("Du börjar gå tills du kommer till ett rum med tre dörrar"); 

    List<string>Door=["Vänster","Mitten","Höger"]; 
    foreach (var item in Door)
    {
        Console.WriteLine(item);
    }

    string chooseDoor=""; 
    bool Merlin=false; 

    while (!Merlin)
    {
        chooseDoor=Console.ReadLine();
        Prompt();

        if (Door.Contains(chooseDoor))
        {
          Console.WriteLine($"Du valde {chooseDoor} ");
          Merlin=true;     
        }
        else
        {
            Console.WriteLine("Välj en dörr "); 
        }
    }

    Console.WriteLine("Du kommer få rädda en person som står nära dig"); 

    int villainHp4=5000; 
    string savename=""; 

    if (chooseDoor=="Höger")
    {
        weaponName="Kort";
        villainName="Malificent"; 
        savename="Red"; 
        Console.WriteLine($"när {villainName}fick tillbaka sin kraft tog hon{savename} och nu måste du rädda henne ");
    }
    else if (chooseDoor=="Mitten")
    {
        weaponName="Klocka"; 
        villainName="Morgie"; 
        savename="Ella"; 
        Console.WriteLine($"när {villainName}fick tillbaka sin kraft tog hon{savename} och nu måste du rädda henne ");
    }
    else if (chooseDoor=="Vänster")
    {
        weaponName="Svärd"; 
        villainName="Queen of hearts"; 
        savename="Cinderella"; 
        Console.WriteLine($"när {villainName}fick tillbaka sin kraft tog hon{savename} och nu måste du rädda henne ");
    }
    
    rescuefight(weaponName,"Chloe",savename,villainName,YourweaponHp,villainHp4);

}


static (int, int) uppgradesRed(int kr, int vapenHP)
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