/*
int i = 1;
Console.Write("Rosnąco: ");

while (i <= 10)
    {
    Console.Write(i + " ");
    i++;
    }
Console.WriteLine();
int j = 1;
Console.Write("Rosnąco : ");
do
{
    Console.Write(j + " ");
    j++;
} while (j<=10);
Console.WriteLine();
Console.Write("Rosnąco: ");
for (int k =1; k <= 10; k++)
{
    Console.Write(k + " ");
}
Console.WriteLine();
Console.Write("Malejąco: ");
for (int l = 10;l >= 1; l--)
{
    Console.Write(l + " ");
}
Console.WriteLine();
Console.Write("Parzyste: ");
for (int m = 0 ; m <= 20; m += 2)
{
    Console.Write(m + " ");
}
Console.WriteLine();
Console.Write("Start!");

Console.WriteLine("Ile dni trwa wyprawa? ");
int dni = int.Parse(Console.ReadLine());
int sumazlota = 0;
int udaneDni = 0;
for (int i = 1; i <= dni;  i++)
{
    Console.WriteLine($"Złoto w dniu "+i+": " );
    int zloto = int.Parse( Console.ReadLine());
    sumazlota += zloto;
    if (zloto > 10)
    {
        udaneDni++;

    }
}
Console.WriteLine();
Console.WriteLine("Łącznie znaleziono: "+sumazlota+" sztuk złota");
Console.WriteLine("Dni z wnikiem powyżej 10: "+udaneDni);

Console.WriteLine("Podaj wysokość choinki: ");
int wysokość = int.Parse(Console.ReadLine());

for (int a = 1; a <= wysokość; a++)
{
    for (int b = 1; b <= wysokość - a; b++)
    {
        Console.Write(" ");
    }

    for (int c = 1; c <= 2 * a - 1; c++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int b = 1; b <= wysokość - 1; b++)
{
    Console.Write(" ");
}
Console.WriteLine("*");


using System.Reflection.Metadata.Ecma335;

int liczbaTur;
while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    bool poprawnyFormat = int.TryParse(Console.ReadLine(), out liczbaTur);

    if (!poprawnyFormat)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (liczbaTur < 1 || liczbaTur > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    break;
}

Console.WriteLine($"Wybrano {liczbaTur} tur.");

Random losowanie = new Random();

int obrazeniaBohatera = losowanie.Next(8, 16);
int obrazeniaPrzeciwnika = losowanie.Next(4, 10);
int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool graDziala = true;

while (graDziala && zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0)
{
    Console.WriteLine();
    Console.WriteLine($"=== TURA {numerTury} ===");
    Console.WriteLine($"Zdrowie: {zdrowieBohatera} | Liczba miktura: {liczbaMikstur}");
    Console.WriteLine($"Zdrowie Przeciwnika: {zdrowiePrzeciwnika}");
    Console.WriteLine("1 - atakuj");
    Console.WriteLine("2 - Wypij miksturę");
    Console.WriteLine("3 - Ucieczka");
    Console.Write("Akcja: ");

    string akcja = Console.ReadLine()!;

    switch (akcja)
    {
        case "1":
            zdrowieBohatera -= obrazeniaPrzeciwnika;
            zdrowiePrzeciwnika -= obrazeniaBohatera;
            Console.WriteLine($"Zadałeś przeciwknikowi {obrazeniaBohatera} punktów obrażeń, ale tracisz {obrazeniaPrzeciwnika} punktów życia.");
            break;
        case "2":
            if (liczbaMikstur > 0)
            {
                zdrowieBohatera += 15;
                Console.WriteLine("Odzyskujesz 15 punktów życia.");
                liczbaMikstur--;
            }
            else
            {
                Console.WriteLine("Nie masz już mikstur.");
            }

            break;
        case "3":
            graDziala = false;
            Console.WriteLine("Ucieczka.");
            break;
        default:
            Console.WriteLine("Nieznana akcja.");
            continue;
    }

    numerTury++;
}

if (zdrowieBohatera <= 0)
{
    Console.WriteLine("Przegrałeś.");
}
else if (zdrowiePrzeciwnika <= 0)
{
    Console.WriteLine("ZWYCIĘSTWO!!.");
}
*/

   
    Console.ForegroundColor = ConsoleColor.Green;
    Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ResetColor();

Console.Write("Imię bohatera: ");
string name = Console.ReadLine();
int maxhp = 100;
int hp;
while (true)
{
    Console.Write("Aktualne punkty życia: ");

    if (int.TryParse(Console.ReadLine(), out hp) && hp > 0)
    {
        break;
    }

    Console.WriteLine("Podaj punkty życia ponownie!");
}
int bron;
while (true)
{
    Console.Write("Podstawowe obrażenia broni: ");

    if (int.TryParse(Console.ReadLine(), out bron) && bron >= 0)
    {
        break;
    }

    Console.WriteLine("Obrażenia muszą być liczbą nieujemną!");
}
double premia;
while (true)
{
    Console.Write("Premia do ataku: ");

    if (double.TryParse(Console.ReadLine(), out premia))
    {
        break;
    }

    Console.WriteLine("Wpisz poprawną liczbę!");
}
double premia2;
while (true)
{
    Console.Write("Premia do ataku specjalnego: ");

    if (double.TryParse(Console.ReadLine(), out premia2))
    {
        break;
    }

    Console.WriteLine("Wpisz poprawną liczbę!");
}
int zloto;
while (true)
{
    Console.Write("Podaj ilość złota: ");

    if (int.TryParse(Console.ReadLine(), out zloto) && zloto >= 0)
    {
        break;
    }

    Console.WriteLine("Błąd! Podaj liczbę całkowitą większą lub równą 0.");
}
    Console.WriteLine();
int liczbaMikstur = 2;
int numerTury = 1;
bool graDziala = true;

while (graDziala && hp > 0)
{
    double procenthp = (double)hp / maxhp;

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"=== TURA {numerTury} ===");
    Console.ResetColor();

    if (hp <= 50 && hp > 30)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if(hp <= 30)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    Console.WriteLine($"Zdrowie: {hp}/{maxhp} ({procenthp:P2})");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Złoto: {zloto} | Liczba mikstur: {liczbaMikstur}");
    Console.ResetColor();
    Console.WriteLine("1 - Eksploruj lochy");
    Console.WriteLine("2 - Wypij miksturę");
    Console.WriteLine("3 - Odpocznij");
    Console.WriteLine("4 - Pokaż statystyki");
    Console.WriteLine("5 - Zakończ grę");
    Console.Write("Akcja: ");

    string akcja = Console.ReadLine()!;

    switch (akcja)
    {
        case "1":
            hp -= 8;
            if (hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Przegrałeś.");
                Console.ResetColor();
                continue;
            }
            zloto += 10;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eksploracja lochów się udała!");
            Console.ResetColor();
            numerTury++;
            break;
        case "2":
            if (liczbaMikstur > 0)
            {
                hp += 20;

                if (hp > maxhp)
                {
                    hp = maxhp;
                }
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Odzyskujesz 20 punktów życia.");
                Console.ResetColor();
                liczbaMikstur--;
                numerTury++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nie masz już mikstur.");
                Console.ResetColor();
                continue;
            }

            break;
        case "3":
            if (zloto < 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nie możesz odpocząć. Masz za mało złota.");
                Console.ResetColor();
                continue;
            }

            if (hp >= maxhp)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Masz pełne zdrowie.");
                Console.ResetColor();
                continue;
            }

            hp += 8;

            if (hp > maxhp)
            {
                hp = maxhp;
            }

            zloto -= 3;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Odpocząłeś.");
            Console.ResetColor();
            numerTury++;

            break;
        case "4":
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("+==================================================+");
            Console.WriteLine("|                   STATYSTYKI                     |");
            Console.WriteLine("+==================================================+");

            Console.ResetColor();
            Console.WriteLine($"| Bohater: {name,-40}|");
            Console.WriteLine($"| Zdrowie: {hp}/{maxhp} ({procenthp:P2})".PadRight(51) + "|");
            Console.WriteLine($"| Złoto: {zloto}".PadRight(51) + "|");
            Console.WriteLine($"| Liczba mikstur: {liczbaMikstur}".PadRight(51) + "|");
            Console.WriteLine($"| Podstawowe obrażenia broni: {bron}".PadRight(51) + "|");
            Console.WriteLine($"| Premia do broni: {premia,-32}|");
            Console.WriteLine($"| Zwykłe obrażenia: {bron * premia,-31}|");
            Console.WriteLine($"| Mnożnik ataku specjalnego: {premia2,-22}|");
            Console.WriteLine($"| Obrażenia ataku specjalnego: {bron * premia * premia2,-20}|");
            Console.WriteLine("+================================================+");

            continue;
        case "5":
            graDziala = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gra zakończona.");
            Console.ResetColor();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nieznana akcja.");
            Console.ResetColor();
            continue;
    }
    
}

