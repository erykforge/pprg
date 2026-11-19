


Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Ork", 45);
int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);
Inventory inventory = new Inventory();
inventory.Add(new Item("Miecz", 40));
inventory.Add(new Item("Mikstura", 15));
Console.WriteLine("\n=== EKWIPUNEK ===");
foreach (Item item in inventory.Items)
{
    Console.WriteLine($"{item.Name}: {item.Price}");
}
Console.WriteLine($"Łączna wartość: {inventory.CalculateValue()}");
//ZAD.6
//1. NIe
//2. Ponieważ każdy projekt kompiluje się niezależnie
//3. NIe
//4. Pojedynczy plik lub określony zakres
//5. Wszystkie pliki w obrębie jednego projektu 