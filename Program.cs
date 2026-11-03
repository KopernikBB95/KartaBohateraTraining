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
bool injured = health < 50;
bool wealthy = gold > 500;
string status;

Console.WriteLine("============================");
Console.WriteLine("X                          X");
Console.WriteLine("X     Hello Adventurer:    X");
Console.WriteLine("X       KARTA POSTACI      X");
Console.WriteLine("X                          X");
Console.WriteLine("============================");
Console.WriteLine("X                          X");
Console.WriteLine($"X Bohater: {name,-10}  \"{mapSymbol}\" X");
Console.WriteLine($"X Poziom: {level,-7}           X");
Console.WriteLine($"X Zycie: {health,-3}/{MaxHealth} ({healthPercentage,-6:F2,-6}%) X");
Console.WriteLine($"X Plecak: {backpackSpace,-2}/{MaxBackpackSpace}            X");
Console.WriteLine($"X Plecak wolne miejsce: {MaxBackpackSpace-backpackSpace,-2} X");
Console.WriteLine($"X Czlonkowie drużyny: {teamMembers}    X");
Console.WriteLine($"X Zloto: {gold,-5}             X");
Console.WriteLine($"X Obrazenia: {strength + attack,-10}    X");
Console.WriteLine($"X Ob krytyczne: {strength + attack * 2,-10} X");
Console.WriteLine($"X Zyje: {alive,-5}              X");
Console.WriteLine($"X Potrzebuje heal: {needsHealing,-5}   X");


health -=5;
teamMembers--;
int goldAccquired = 100;
int goldLeftInTreasury= goldAccquired%teamMembers;
backpackSpace++;
gold += (goldAccquired/teamMembers);
fullHealth = health == 100;
needsHealing = !fullHealth;
healthPercentage = (double)health / MaxHealth * 100;

Console.WriteLine($"X++++++++++++++++++++++++++X");
Console.WriteLine($"X Stan po pierwszej walce: X");
Console.WriteLine($"X Bohater: {name,-10}  \"{mapSymbol}\" X");
Console.WriteLine($"X Poziom: {level,-7}           X");
Console.WriteLine($"X Zycie: {health,-3}/{MaxHealth} ({healthPercentage,-6:F2}%) X");
Console.WriteLine($"X Plecak: {backpackSpace,-2}/{MaxBackpackSpace}            X");
Console.WriteLine($"X Plecak wolne miejsce: {MaxBackpackSpace-backpackSpace,-2} X");
Console.WriteLine($"X Czlonkowie drużyny: {teamMembers}    X");
Console.WriteLine($"X Złoto: zdobyte: {goldAccquired}      X");
Console.WriteLine($"X Zloto po podziale: {gold,-5} (+{goldAccquired/teamMembers})      X");
Console.WriteLine($"X Złoto do skarbca: {goldLeftInTreasury}      X");
Console.WriteLine($"X Zyje: {alive,-5}              X");
Console.WriteLine($"X Potrzebuje heal: {needsHealing,-5}   X");