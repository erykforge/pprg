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
