using DungeonOrganizer.Characters;
using DungeonOrganizer.UI;
using DungeonOrganizer.Items;
using DungeonOrganizer.World;
//Aliasy
using InventoryItem = DungeonOrganizer.Items.Item;
using Item = DungeonOrganizer.World.Item;
using MapItem = DungeonOrganizer.World.Item;
Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InventoryItem item = new InventoryItem("Mikstura", 15);
MapItem mapItem = new Item("!");
Weapon bron = new Weapon("Miecz", 8);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWeapon(bron.Name, bron.Damage);
Console.WriteLine($"Symbol na mapie: {mapItem.Symbol}");
//Zad.2 Samo działanie programu się nie zmieniło
//tylko wypisaliśmy ścieżkę ręcznie
