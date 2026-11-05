string heroName = "Ada";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"  {title.ToUpper()}  ");
    Console.ResetColor();
    Console.WriteLine();
}

void ShowStatus(string name, int health, int maxHealth, int gold)
{
    ShowPanelTitle("Status bohatera", ConsoleColor.DarkBlue);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Bohater:  ");
    Console.WriteLine(name);
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Zdrowie: ");
    Console.WriteLine($"{health}/{maxHealth} HP");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Złoto:    ");
    Console.WriteLine(gold);
    Console.ResetColor();
}

void ShowMenu()
{
    ShowPanelTitle("Menu", ConsoleColor.DarkCyan);
    Console.ResetColor();
    Console.WriteLine("[1] Atak treningowy");
    Console.WriteLine("[2] Odpoczynek");
    Console.WriteLine("[3] Koniec gry");
    Console.ResetColor();
}

int CalculateDamage(int strength, int weaponDamage)
{
    return strength + weaponDamage;
}

int Heal(int health, int amount, int maxHealth)
{
    health += 10;

    if (health > maxHealth)
    {
        health = maxHealth;
    }
    return health;
}

bool IsGameOver(int health)
{
    return health <= 0;
}


while (isRunning)
    {
        ShowStatus(heroName, health, maxHealth, gold);
        ShowMenu();
        string command = Readcommand();

        if (command == "1")
        {
            int damage = CalculateDamage(strength, weaponDamage);
            Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
        }
        else if (command == "2")
        {
            health = Heal(health, 10, maxHealth);

            Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
        }
        else if (command == "3")
        {
            if (IsGameOver(health))
            {
                Console.WriteLine("Koniec gry.");
            }

            isRunning = false;
            Console.WriteLine("Koniec gry.");
        }
        else
        {
            Console.WriteLine("Nieznana komenda.");
        }
    }

    string Readcommand()
    {
        while (true)
        {
            Console.Write("Wybór: ");
            string? command = Console.ReadLine();
        if(command == "1" || command == "2" || command == "3")
        {
            return command;
        }
        Console.WriteLine("Niepoprawna Komenda. Wpisz 1, 2 lub 3.");
        }
    }

/*
 void ShowMessage(string text)
{
    Console.WriteLine(text);
}
int AddGold(int gold, int reward)
{
    return gold + reward;
}
bool HasEnoughGold(int gold, int price) => gold >= price;

Która metoda nie zwraca wartości? ShowMessage
Jakiego typu wynik zwraca HasEnoughGold? bool
Co jest argumentem w wywołaniu AddGold(10, 5)? liczby 10 i 5
Gdzie można użyć wyniku HasEnoughGold(10, 8)? w if
 */

