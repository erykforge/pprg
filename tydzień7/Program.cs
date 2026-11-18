List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Goblin", 30, 8),
    new Enemy("Nietoperz", 20, 5),
    new Enemy("Ork", 70, 15),
    new Enemy("Golem", 90, 20),
    new Enemy("Wilk", 40, 18)
};

Player player = new Player("Maciuś", 100, 25);
Player player2 = new Player("Kuba", 100, 25);

Enemy goblin = enemies[0];
Enemy ork = enemies[2];

int sumEnemyHealth = 0;
// Enemy highestHpEnemy;
foreach (Enemy enemy in enemies)
{
    if (enemy.IsAlive())
    {
        Console.WriteLine($"{enemy.Name}");
        sumEnemyHealth += enemy.Health;
        // if (highestHpEnemy.Health < enemy.Health)
        // {
        //     highestHpEnemy = enemy;
        // }

        
    }
    enemy.IsAlive();
}

Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

if (goblin.IsAlive())
{
    player.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player.Name} ma {player.Health} HP.");
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
}

if (player2.IsAlive())
{
    ork.TakeDamage(player2.Damage);
    Console.WriteLine($"{ork.Name} ma {ork.Health} HP.");
}
else
{
    Console.WriteLine("Gracz 2 został pokonany.");
}



// foreach (Enemy enemy in enemies)
// {
//     Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
// }