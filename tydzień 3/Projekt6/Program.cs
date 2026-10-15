/*Console.WriteLine("Podaj punkty życia: ");
int punktyż = int.Parse(Console.ReadLine());
string stan = punktyż > 0 ? "żyje" : "nie żyje";
Console.WriteLine("Podaj ilość złota: ");
int gold = int.Parse(Console.ReadLine());
string informacja = gold > 30 ? "Możesz kupić miksturę" : "Brakuje złota";
Console.WriteLine($"Bohater {stan}.");
Console.WriteLine($"{informacja}.");

Console.WriteLine("Podaj punkty życia");
int punktyż = int.Parse(Console.ReadLine());
Console.WriteLine("Podstawowe obrażenia broni: ");
int bron =  int.Parse(Console.ReadLine());
Console.WriteLine("Czy bohater ma miksturę: ");
bool mikstura = bool.Parse(Console.ReadLine());
if (punktyż <= 0)
{
    Console.WriteLine("Przegrałeś");
}
else
{
    if (punktyż < 20)
    {
        Console.WriteLine("Bohater ma mało punktów życia");
    }

    Console.WriteLine("Wybierz opcje: 1- atak, 2 - leczenie, 3 - ucieczka.");
    int opcje = int.Parse(Console.ReadLine());
    switch (opcje)
    {
        case 1:
            Console.WriteLine($"Zadane obrażenia: {bron}");
            break;
        case 2:
            Console.WriteLine($"Uleczono: {mikstura}");
            break;
        case 3:Console.WriteLine($"Uciekłeś");
            break;
        default:
            Console.WriteLine($"Nie ma takiej opcji.");
            break;
    }

}
*/
Console.WriteLine("Imię bohatera: ");
string name = Console.ReadLine();
int maxhp = 100;
Console.WriteLine("aktualne punkty życia");
int hp = int.Parse(Console.ReadLine());
Console.WriteLine("podstawowe obrażenia broni: ");
int broń = int.Parse(Console.ReadLine());
Console.WriteLine("premia do ataku: ");
double premia = double.Parse(Console.ReadLine());
Console.WriteLine("premia do ataku specjalnego: ");
double premia2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ilość złota: ");
int zloto = int.Parse(Console.ReadLine());
Console.WriteLine("Posiada mapę?: ");
bool mapa = bool.Parse(Console.ReadLine());
Console.WriteLine("Posiada miksturę?: ");
bool mikstura = bool.Parse(Console.ReadLine());
bool gotowy = mapa && mikstura;
double procenthp = (double)hp / maxhp;
string bogaty = zloto > 100 ? "Bohater Jest bogaty" : "Bohater nie jest bogaty";
if (hp <= 0)
{
    Console.WriteLine("Bohater nie żyje");
}
else if (hp < 30)
{

    Console.WriteLine("+==================================================+");
    Console.WriteLine("|                  KARTA BOHATERA                  |");
    Console.WriteLine("+==================================================+");
    Console.WriteLine($"| Bohater: {name,-40}|");
    Console.WriteLine($"| Zdrowie: {hp}/{maxhp} ({procenthp:P2}".PadRight(51) + "|");
    Console.WriteLine($"| Podstawowe obrażenia broni: {broń,-21}|");
    Console.WriteLine($"| Premia do broni: {premia,-32}|");
    Console.WriteLine($"| Zwykłe obrażenia: {broń * premia,-31}|");
    Console.WriteLine($"| Mnożnik ataku specjalnego: {premia2,-22}|");
    Console.WriteLine($"| Obrażenia ataku specjalnego: {broń * premia * premia2,-20}|");
    Console.WriteLine($"+==================================================+");
    Console.WriteLine($"| Złoto: {zloto}".PadRight(51) +"|");
    Console.WriteLine($"| {bogaty}".PadRight(51) +"|");
    Console.WriteLine($"| Ma mapę: {mapa}".PadRight(51) +"|");
    Console.WriteLine($"| Ma miksturę: {mikstura}".PadRight(51) +"|");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"| Bohater jest ranny                               |");
    Console.ResetColor();
    Console.WriteLine($"+==================================================+");
    Console.WriteLine("1 - Sprawdź stan");
    Console.WriteLine("2 - Rozpocznij wyprawę");
    Console.WriteLine("3 - Wypij miksturę");
    Console.WriteLine("4 - odpocznij");
    Console.Write("Wybierz opcję: ");
    int opcja = int.Parse(Console.ReadLine()!);
    switch (opcja)
    {
        case 1:
            Console.WriteLine($"Punkty życia: {hp}.");
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie możesz rozpocząć wyprawy!");
            Console.WriteLine("Jesteś ranny");
            Console.ResetColor();
            break;
        case 3:
            if (mikstura)
            {
                Console.WriteLine("Wypito miksturę");
            }
            else
            {
                Console.WriteLine("Nie masz mikstury");  
            }
            break;
        case 4:
            Console.WriteLine("Odpoczywasz.");
            break;
        default:
            Console.WriteLine("Nie ma takiej opcji");
            break;
    }
}
else if (hp >= 90)
{
    Console.WriteLine("+==================================================+");
    Console.WriteLine("|                  KARTA BOHATERA                  |");
    Console.WriteLine("+==================================================+");
    Console.WriteLine($"| Bohater: {name,-40}|");
    Console.WriteLine($"| Zdrowie: {hp}/{maxhp} ({procenthp:P2}".PadRight(51) + "|");
    Console.WriteLine($"| Podstawowe obrażenia broni: {broń,-21}|");
    Console.WriteLine($"| Premia do broni: {premia,-32}|");
    Console.WriteLine($"| Zwykłe obrażenia: {broń * premia,-31}|");
    Console.WriteLine($"| Mnożnik ataku specjalnego: {premia2,-22}|");
    Console.WriteLine($"| Obrażenia ataku specjalnego: {broń * premia * premia2,-20}|");
    Console.WriteLine("+==================================================+");
    Console.WriteLine($"| Złoto: {zloto}".PadRight(51) +"|");
    Console.WriteLine($"|{bogaty}".PadRight(51) +"|");
    Console.WriteLine($"| Ma mapę: {mapa}".PadRight(51) +"|");
    Console.WriteLine($"| Ma miksturę: {mikstura}".PadRight(51) +"|");
    Console.WriteLine($"| gotowy: {gotowy}".PadRight(51) +"|");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"| Bohater jest w świetnej formie".PadRight(51) +"|");
    Console.ResetColor();
    Console.WriteLine("+==================================================+");
    Console.WriteLine("1 - Sprawdź stan");
    Console.WriteLine("2 - Rozpocznij wyprawę");
    Console.WriteLine("3 - Wypij miksturę");
    Console.WriteLine("4 - odpocznij");
    Console.Write("Wybierz opcję: ");
    int opcja = int.Parse(Console.ReadLine()!);
    switch (opcja)
    {
        case 1:
            Console.WriteLine($"Punkty życia: {hp}.");
            break;
        case 2:
            Console.WriteLine("Wyruszono w podróż");
            break;
        case 3:
            if (mikstura)
            {
                Console.WriteLine("Wypito miksturę");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz mikstury");  
                Console.ResetColor();
            }
            break;
        case 4:
            Console.WriteLine("Odpoczywasz.");
            break;
        default:
            Console.WriteLine("Nie ma takiej opcji");
            break;
    }
}

