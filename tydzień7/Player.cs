public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int Promotion { get; }
    public int Damage { get; }

    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = 0;
        Experience = 0;
        Promotion = 10;
        Damage = 10;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"Nie otrzymałeś żadnych obrażeń\nLiczba {damage} jest niepoprawna");
            return;
        }

        Health -= damage;
        Console.WriteLine($"Otrzymałeś {damage} obrażeń");
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"Nie zostałeś uleczony | Liczba {amount} jest niepoprawna");
            return;
        }
        if (!IsAlive())
        {
            Console.WriteLine($"Nie zostałeś uleczony | Gracz nie żyje");
            return;
        }
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public void AddExperience(int amount)
    {
        if (Experience+amount > Promotion)
        {
            int promotedLevels = (Experience+amount)/Promotion;
            Experience = (Experience+amount)%Promotion;
            for(int i=0; i < promotedLevels; i++)
            {
                Level++;
                MaxHealth+=20;
                Health = MaxHealth;
            }

        }

    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
