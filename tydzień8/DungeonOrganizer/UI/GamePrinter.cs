namespace DungeonOrganizer.UI;

public class GamePrinter
{
    public static void ShowHeader(string title)
    {
        Console.WriteLine($"=== {title.ToUpper()} ===");
    }

    public static void ShowCharacter(string name, int health)
    {
        Console.WriteLine($"{name}: {health} HP");
    }

    public static void ShowItem(string name, int price)
    {
        Console.WriteLine($"{name}: {price} szt. złota");
    }
    public static void ShowWeapon(string name, int Damage)
    {
        Console.WriteLine($"{name}: {Damage} obrażeń");
    }
}