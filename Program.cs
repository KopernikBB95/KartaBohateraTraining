Console.WriteLine("============================");
Console.WriteLine("X                          X");
Console.WriteLine("X       Witaj w Grze:      X");
Console.WriteLine("X     Hello Adventurer     X");
Console.WriteLine("X                          X");
Console.WriteLine("============================");

Console.WriteLine("Podaj imie swojego bohatera: ");
string name = Console.ReadLine()!;
char mapSymbol = '@';

Console.WriteLine("Podaj poziom swojego bohatera (1-10): ");
int level = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj ilosc zycia (0-100): ");
int health = int.Parse(Console.ReadLine()!);
const int MaxHealth = 100;
double healthPercentage = (double)health / MaxHealth * 100;

Console.WriteLine("Podaj startową ilość złota (0-1000): ");
decimal gold = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj ilosc sily: ");
int strength = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj ilosc ataku twojej broni: ");
int attack = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj ilosc mikstur(1-5): ");
int healthPotions = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy bohater posiada mape? (Wpisz True or False)");
bool map = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj ilosc czlonków drużyny łącznie z Twoim bohaterem (1-4) : ");
int teamMembers = int.Parse(Console.ReadLine()!);

const int MaxBackpackSpace = 20;
int backpackSpace = 10;
bool alive = health > 0;
bool fullHealth = health == 100;
bool needsHealing = !fullHealth;
bool injured = health < 50 && alive;
string wealthy = gold > 500 ? "Wealthy" : "Not wealthy";
string status;

if (alive)
{
    if (injured)
    {
        if (healthPotions > 0)
            status= "You're injured, use some potions.";
        else
        {
            status = "You're injured, get some potions.";
        }
    }
    else
    {
        if(map)
        {
            if(healthPotions > 0)
            {
                status = "You're ready for adventure!";
            }
            else
            {
                status = "You've got the map but get some potions before setting off.";
            }
        }
        else
        {
            status = "You're not ready, get the map.";
        }
    }
}
else
{
    status = "Dead";
}

/*
if (!alive)
{
    status = "You're dead.";
}
else if (injured && healthPotions > 0)
{
    status = "You're injured use some potions.";
}
else if  (injured)
{
    status = "You're injured and out of potions, get some";
}
else if (!map)
{
    status = "You're not ready, get the map";
}
else if (healthPotions < 1)
{
    status = "You've got the map but get some potions before setting out";
}
else
{
    status = "You're ready for adventure";
}
*/

Console.WriteLine("============================");
Console.WriteLine("X                          X");
Console.WriteLine("X     Hello Adventurer:    X");
Console.WriteLine("X       KARTA POSTACI      X");
Console.WriteLine("X                          X");
Console.WriteLine("============================");
Console.WriteLine("X                          X");
Console.WriteLine($"X Bohater: {name,-10}  \"{mapSymbol}\" X");
Console.WriteLine($"X Poziom: {level,-7}           X");
Console.WriteLine($"X Zycie: {health,-3}/{MaxHealth} ({healthPercentage:F2}%) X");
Console.WriteLine($"X Plecak: {backpackSpace,-2}/{MaxBackpackSpace}            X");
Console.WriteLine($"X Plecak wolne miejsce: {MaxBackpackSpace-backpackSpace,-2} X");
Console.WriteLine($"X Czlonkowie drużyny: {teamMembers}    X");
Console.WriteLine($"X Zloto: {gold,-5}             X");
Console.WriteLine($"X Obrazenia: {strength + attack,-10}    X");
Console.WriteLine($"X Ob krytyczne: {strength + attack * 2,-10} X");
Console.WriteLine($"X Zyje: {alive,-5}              X");
Console.WriteLine($"X Potrzebuje heal: {needsHealing,-5}   X");
Console.WriteLine($"X Stan: {status,-7}           X");
Console.WriteLine("");
Console.WriteLine("Choose action: ");
Console.WriteLine("1. Print short hero's card (hp, gold,status)");
Console.WriteLine("2. Begin journey");
Console.WriteLine("3. Buy a potion");
Console.WriteLine("4. Buy a map");
Console.WriteLine("5. Rest (Recovers 50% of total HP)");
int option = int.Parse(Console.ReadLine()!);

switch (option)
{
    case 1:
        Console.WriteLine($"X Bohater: {name,-10}  \"{mapSymbol}\" X");
        Console.WriteLine($"X Zycie: {health,-3}/{MaxHealth} ({healthPercentage,-6:F2,-6}%) X");
        Console.WriteLine($"X Zloto: {gold,-5}             X");
        Console.WriteLine($"X Stan: {status,-7}           X");
        break;
    case 2:
            if (alive && !injured && (healthPotions >0) && map)
            {
                Console.WriteLine("You're setting off for adventure.");
            }
            else
            {
                Console.WriteLine($"You're not ready. Check your status: {status}");
            }
            break;
        case 3:
            if (gold >= 30)
            {
                gold -= 30;
                healthPotions ++;
                Console.WriteLine($"You've bought a health potion, for 30 gold. You have {gold} gold left and {healthPotions} health potions left");
            }
            else
            {
                Console.WriteLine($"You don't have enough gold, you need another {30 - gold} gold");
            }
            break;
        case 4:
            if (gold >= 60)
            {
                gold -= 60;
                map = true;
                Console.WriteLine($"You've bought a map, for 60 gold. You have {gold} gold left.");
            }
            else
            {
                Console.WriteLine($"You don't have enough gold, you need another {60 - gold} gold");
            }
            break;
        case 5:
            if (health == 100)
            {
                Console.WriteLine($"You rest but don't recover any health as it is already full.");
            }
            else if (health > 66 && health < 100)
            {
                health = 100;
                Console.WriteLine($"You have rested, your health is now full");
            }
            else if (health > 0 && health < 67)
             {
                double healthRestBonus = health * 0.5;
                health = health + (int)healthRestBonus;
                Console.WriteLine($"You have rested, your health is now {health} HP");
             }
            else
            {
                Console.WriteLine("You cannot rest, you're dead!");
            }
        break;
        default:
        Console.WriteLine("Wrong option selected.");
        break;
}