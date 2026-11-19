using RogueArena.Core.Characters;
using RogueArena.Core.Rewards;

Hero hero = new Hero("Ada", 100);
Companion companion = new Companion("Borys");

int reward = RewardCalculator.Calculate(45);

Console.WriteLine($"Bohater: {hero.Name}");
Console.WriteLine($"Towarzysz: {companion.Name}");
Console.WriteLine($"Nagroda: {reward} szt. złota");
/*
RAPORT
Brak Reward - zły namespace - poprawiono na Rewards
Brak Companion - zły namespace - poprawiono na Characters
Brak dostępu do klasy - brak public - Dodano public
Brak typów core - brak referencji - Dodano ProjectReference
 */
