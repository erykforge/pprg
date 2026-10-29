/*int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
int numerTury = 1;
foreach (int zloto in zlotoWTurach)
{
    Console.WriteLine($"Tura {numerTury}: {zloto} sztuk złota");
    numerTury++;
}

int suma = 0;
foreach (int zloto in zlotoWTurach)
{
    suma += zloto;
}
Console.WriteLine($"Suma: {suma}");
double srednia = (double)suma / zlotoWTurach.Length;
Console.WriteLine($"Średnia na truę: {srednia:F2}");
int liczbaTur = 0;
for (int i = 0; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] > 10)
        {
        liczbaTur++;
        }
}
Console.WriteLine($"Tury z wynikiem co najmniej 10: {liczbaTur}");
Console.Write("Od końca: ");
for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
    Console.Write(zlotoWTurach[i] + " ");
}

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};
Console.WriteLine($"Plecak ({plecak.Count}/6)");
for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}
Console.WriteLine($"Co znalazł bohater?: ");
string NowyPrzedmiot = Console.ReadLine();
Console.WriteLine($"Znaleziono: {NowyPrzedmiot}");
Console.WriteLine($"Dodano: {NowyPrzedmiot}");
Console.WriteLine($"Użyto mikstury");
plecak.Remove("Mikstura");
plecak.Add(NowyPrzedmiot);
for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

List<string> lista = new List<string>
{
    "Mikstura",
    "Pochodnia",
    "Miecz"
};
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{i + 1}. {lista[i]}");
}
Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

foreach (KeyValuePair<string, int> przedmiot in ceny)
{
    Console.WriteLine($"{przedmiot.Key} - {przedmiot.Value} złota");
}
Console.Write("Podaj nazwę przedmiotu: ");
string nazwa = Console.ReadLine()!;

if (ceny.ContainsKey(nazwa))
{
    Console.WriteLine($"Cena: {ceny[nazwa]} sztuk złota");
}
else
{
    Console.WriteLine("Nie ma takiego przedmiotu.");
}
ceny["Mikstura"] = 12;
foreach (KeyValuePair<string, int> przedmiot in ceny)
{
    Console.WriteLine($"{przedmiot.Key} - {przedmiot.Value} złota");
}


Console.Write("Ile tur chcesz zapisać? ");
int liczbaTur = int.Parse(Console.ReadLine()!);
while (liczbaTur < 1 || liczbaTur > 10)
{
    Console.WriteLine("Podaj liczbę od 1 do 10: ");
    liczbaTur = int.Parse(Console.ReadLine());
}
int[] zlotoWTurach = new int[liczbaTur];

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.Write($"Złoto w turze {i + 1}: ");
    zlotoWTurach[i] = int.Parse(Console.ReadLine()!);
    while (zlotoWTurach[i] < 0)
    {
        Console.Write("Złoto nie może być ujemne. Podaj ponownie: ");
        zlotoWTurach[i] = int.Parse(Console.ReadLine()!);
    }
}
int suma = 0;
foreach (int zloto in zlotoWTurach)
{
    suma += zloto;
}
Console.WriteLine($"Suma: {suma}");
int najmniejsze = zlotoWTurach[0];
int najwieksze = zlotoWTurach[0];

for (int i = 1; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] < najmniejsze)
    {
        najmniejsze = zlotoWTurach[i];
    }

    if (zlotoWTurach[i] > najwieksze)
    {
        najwieksze = zlotoWTurach[i];
    }
}
Console.WriteLine($"Minimum: {najmniejsze}");
Console.WriteLine($"Maksimum: {najwieksze}");
int maksimum = zlotoWTurach[0];
int numerNajepszejTury = 1;
for (int i = 1; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] > maksimum)
    {
        maksimum = zlotoWTurach[i];
        numerNajepszejTury = i+1;
    }
}
Console.WriteLine($"Pierwszy najlepszy wynik: {numerNajepszejTury}");
int liczbaMaksimum = 0;
int numerturyzero = -1;
for (int i = 0; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach[i] == maksimum)
    {
        liczbaMaksimum++;
    }

    if (zlotoWTurach[i] == 0 && numerturyzero == -1)
    {
        numerturyzero = i + 1;
    }
}
Console.WriteLine($"Liczba tur z maksimum: {liczbaMaksimum}");
if (numerturyzero != -1)
{
    Console.WriteLine($"Pierwsza tura bez złota: {numerturyzero}");
}
else
{
    Console.WriteLine("Nie ma tury bez złota");
}
*/
List<string> przedmioty = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};
bool dziala = true;
while (dziala)
{
    for (int i = 0; i < przedmioty.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {przedmioty[i]}");
    }

    Console.Write("Wybierz przedmiot do usunięcia: ");
    
    
    if (int.TryParse(Console.ReadLine(), out int numer))
    {
        int indeks = numer - 1;

        if (indeks >= 0 && indeks < przedmioty.Count)
        {
            Console.WriteLine($"Wybrano: {przedmioty[indeks]}");
        }
        else
        {
            Console.WriteLine("Numer jest poza zakresem.");
        }
    }
    else
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
    }
   
    
}
