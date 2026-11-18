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
            string usuniety = przedmioty[indeks];

            przedmioty.RemoveAt(indeks);

            Console.WriteLine($"Usunięto: {usuniety}");
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
    if (przedmioty.Count == 0)
    {
        Console.WriteLine("Plecak jest pusty. Koniec programu.");
        dziala = false;
    }
}

Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};
bool działa = true;
while (działa)
{
    Console.WriteLine("1 - Pokaż magazyn");
    Console.WriteLine("2 - Przyjmij dostawę");
    Console.WriteLine("3 - Wydaj przedmiot");
    Console.WriteLine("4 - Usuń pustą pozycję");
    Console.WriteLine("5 - Zakończ");

    Console.WriteLine("Wybierz opcję: ");
    string opcja = Console.ReadLine();

switch (opcja)
{
    case "1":
    {
        foreach (var przedmiot in magazyn)
        {
            Console.WriteLine($"{przedmiot.Key}: {przedmiot.Value}");
        }
        break;
    }

    case "2":
    {
        Console.Write("Podaj nazwę przedmiotu: ");
        string nazwa = Console.ReadLine()!;

        Console.Write("Podaj ilość: ");
        int ilosc = int.Parse(Console.ReadLine()!);

        if (ilosc > 0)
        {
            if (magazyn.ContainsKey(nazwa))
            {
                magazyn[nazwa] += ilosc;
            }
            else
            {
                magazyn.Add(nazwa, ilosc);
            }

            Console.WriteLine("Dostawa przyjęta.");
        }
        else
        {
            Console.WriteLine("Ilość musi być dodatnia.");
        }

        break;
    }

    case "3":
    {
        Console.Write("Podaj nazwę przedmiotu: ");
        string nazwa = Console.ReadLine()!;

        Console.Write("Podaj ilość do wydania: ");
        int ilosc = int.Parse(Console.ReadLine()!);

        if (ilosc > 0)
        {
            if (magazyn.ContainsKey(nazwa) && magazyn[nazwa] >= ilosc)
            {
                magazyn[nazwa] -= ilosc;
                Console.WriteLine("Wydano przedmiot.");
            }
            else
            {
                Console.WriteLine("Brak przedmiotu lub niewystarczająca ilość.");
            }
        }
        else
        {
            Console.WriteLine("Ilość musi być dodatnia.");
        }

        break;
    }

    case "4":
    {
        Console.Write("Podaj nazwę przedmiotu do usunięcia: ");
        string nazwa = Console.ReadLine()!;

        if (magazyn.ContainsKey(nazwa) && magazyn[nazwa] == 0)
        {
            magazyn.Remove(nazwa);
            Console.WriteLine("Usunięto pustą pozycję.");
        }
        else
        {
            Console.WriteLine("Nie można usunąć. Pozycja musi mieć stan 0.");
        }

        break;
    }

    case "5":
    {
        działa = false;
        Console.WriteLine("Koniec programu.");
        break;
    }

    default:
    {
        Console.WriteLine("Niepoprawna opcja.");
        break;
    }
}

}

List<string> historia = new List<string>();
bool działa = true;
while (działa)
{
    Console.WriteLine("1 - Eksploruj");
    Console.WriteLine("2 - Odpocznij");
    Console.WriteLine("3 - Znajdź przedmiot");
    Console.WriteLine("4 - Pokaż całą historię");
    Console.WriteLine("5 - Pokaż ostatnie trzy wpisy");
    Console.WriteLine("6 - Policz wybraną akcję");
    Console.WriteLine("7 - Wyczyść historię");
    Console.WriteLine("8 - Zakończ");

    Console.WriteLine("Wybierz opcję: ");
    string opcja = Console.ReadLine();

    switch (opcja)
    {
        case "1":
            historia.Add("Eksploracja");
            Console.WriteLine("Eksploracja udana");
            break;
        case "2":
            historia.Add("Odpoczynek");
            Console.WriteLine("Odpoczywasz");
            break;
        case "3":
            historia.Add("Znaleziono przedmiot");
            Console.WriteLine("Znaleziono przedmiot");
            break;
        case "4":
            if (historia.Count == 0)
            {
                Console.WriteLine("Historia jest pusta");
            }
            else
            {
                foreach (string przedmioty in historia)
                {
                    Console.WriteLine(przedmioty);
                }
            }
            break;
        case "5":
            if (historia.Count == 0)
            {
                Console.WriteLine("Historia jest pusta");
            }
            else if (historia.Count > 0 && historia.Count <= 3)
            {
                foreach (string przedmioty in historia)
                {
                    Console.WriteLine(przedmioty);
                }
            }
            else
            {
                int start = historia.Count - 3;
                for (int i = start; i < historia.Count; i++)
                {
                    Console.WriteLine(historia[i]);
                }
            }
            break;
        case "6":
            Console.Write("Wpisz nazwę akcji: ");
            string akcja = Console.ReadLine();
            int licznik = 0;
            foreach (string wpis in historia)
            {
                if (wpis == akcja)
                {
                    licznik++;
                }
            }
            Console.WriteLine($"Akcja wystąpiła {licznik} razy.");
            break;
        case "7":
            Console.Write("Czy na pewno chcesz wyczyścić historię? (t/n): ");
            string czyszczenie = Console.ReadLine();
            if (czyszczenie == "t")
            {
                historia.Clear();

            }
            else if (czyszczenie == "n")
            {
                Console.WriteLine("Nie wyczyszczono historii");
            }
            else
            {
                Console.WriteLine("Nie poprawna odpowiedź");
            }
            break;
        case "8":
        {
            działa = false;
            Console.WriteLine("Koniec programu.");
            break;
        }
        default:
        {
            Console.WriteLine("Niepoprawna opcja.");
            break;
        }
    }
}
*/

Console.Write("Imię bohatera: ");
string name = Console.ReadLine() ?? "";

int punktyZycia = 80;
int maksymalneZdrowie = 100;
int zloto = 10;
int numerTury = 1;
int liczbaEksploracji = 0;
bool graDziala = true;
string powodZakonczenia = "";

string[] znaleziska =
{
    "Mikstura",
    "Klucz",
    "Pochodnia",
    "Zwój"
};

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura"
};

List<string> historia = new List<string>();
int[] zlotoZdobyteWTurach = new int[20];

while (graDziala)
{
    Console.WriteLine("\n=== HELLO ADVENTURER 5.0 ===");
    Console.WriteLine($"Tura: {numerTury}");
    Console.WriteLine($"Bohater: {name}");
    Console.WriteLine($"Zdrowie: {punktyZycia}/{maksymalneZdrowie} | Złoto: {zloto} | Plecak: {plecak.Count}/6");

    Console.WriteLine("\n=== Opcje ===");
    Console.WriteLine("1 - Eksploruj loch");
    Console.WriteLine("2 - Pokaż plecak");
    Console.WriteLine("3 - Użyj przedmiotu");
    Console.WriteLine("4 - Dodaj znalezisko");
    Console.WriteLine("5 - Wyrzuć przedmiot");
    Console.WriteLine("6 - Pokaż historię");
    Console.WriteLine("7 - Pokaż statystyki wyprawy");
    Console.WriteLine("8 - Zakończ grę");
    Console.Write("Wybierz opcję: ");

    string opcja = Console.ReadLine() ?? "";

    switch (opcja)
    {
        case "1":
        {
            punktyZycia -= 8;

            if (punktyZycia < 0)
            {
                punktyZycia = 0;
            }

            zloto += 10;
            liczbaEksploracji++;

            if (numerTury - 1 < zlotoZdobyteWTurach.Length)
            {
                zlotoZdobyteWTurach[numerTury - 1] = 10;
            }

            historia.Add($"{numerTury}: Eksploracja");

            Console.WriteLine("Eksploracja zakończona!");

            numerTury++;

            if (punktyZycia == 0)
            {
                graDziala = false;
                powodZakonczenia = "bohater stracił całe zdrowie.";
            }

            break;
        }

        case "2":
        {
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty.");
            }
            else
            {
                Console.WriteLine($"Plecak ({plecak.Count}/6):");

                for (int i = 0; i < plecak.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {plecak[i]}");
                }

                if (plecak.Contains("Mikstura"))
                {
                    Console.WriteLine("W plecaku znajduje się mikstura.");
                }
            }

            break;
        }

        case "3":
        {
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty.");
                break;
            }

            for (int i = 0; i < plecak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {plecak[i]}");
            }

            Console.Write("Podaj numer przedmiotu: ");

            bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out int numer);

            if (!poprawnaLiczba)
            {
                Console.WriteLine("Musisz wpisać liczbę!");
                break;
            }

            int indeks = numer - 1;

            if (indeks < 0 || indeks >= plecak.Count)
            {
                Console.WriteLine("Nieprawidłowy numer przedmiotu.");
                break;
            }

            string przedmiot = plecak[indeks];

            if (przedmiot == "Mikstura")
            {
                plecak.RemoveAt(indeks);

                punktyZycia += 20;

                if (punktyZycia > maksymalneZdrowie)
                {
                    punktyZycia = maksymalneZdrowie;
                }

                Console.WriteLine("Wypiłeś miksturę. Odzyskałeś zdrowie.");
                historia.Add($"{numerTury}: Wypito miksturę");
                numerTury++;
            }
            else if (przedmiot == "Pochodnia")
            {
                plecak.RemoveAt(indeks);

                Console.WriteLine("Rozświetlono korytarz.");
                historia.Add($"{numerTury}: Rozświetlono korytarz");
                numerTury++;
            }
            else if (przedmiot == "Zwój")
            {
                zloto += 15;
                plecak.RemoveAt(indeks);

                Console.WriteLine("Wykorzystałeś zwój. Zdobyłeś 15 złota.");
                historia.Add($"{numerTury}: Wykorzystano zwój");
                numerTury++;
            }
            else if (przedmiot == "Miecz" || przedmiot == "Klucz")
            {
                Console.WriteLine("Ten przedmiot nie jest zużywany.");
            }
            else
            {
                Console.WriteLine("Nieznany przedmiot. Nie można go użyć.");
            }

            break;
        }

        case "4":
        {
            Console.WriteLine("Dostępne znaleziska:");

            for (int i = 0; i < znaleziska.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {znaleziska[i]}");
            }

            Console.Write("Wybierz numer znaleziska: ");

            bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out int numer);

            if (!poprawnaLiczba)
            {
                Console.WriteLine("Musisz wpisać liczbę!");
                break;
            }

            int indeks = numer - 1;

            if (indeks < 0 || indeks >= znaleziska.Length)
            {
                Console.WriteLine("Nieprawidłowy numer znaleziska.");
                break;
            }

            if (plecak.Count >= 6)
            {
                Console.WriteLine("Plecak jest pełny!");
                break;
            }

            string znalezisko = znaleziska[indeks];

            plecak.Add(znalezisko);

            Console.WriteLine($"Dodano do plecaka: {znalezisko}");

            historia.Add($"{numerTury}: Znaleziono: {znalezisko}");

            numerTury++;

            break;
        }

        case "5":
        {
            if (plecak.Count == 0)
            {
                Console.WriteLine("Plecak jest pusty.");
                break;
            }

            for (int i = 0; i < plecak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {plecak[i]}");
            }

            Console.Write("Podaj numer przedmiotu do wyrzucenia: ");

            bool poprawnaLiczba = int.TryParse(Console.ReadLine(), out int numer);

            if (!poprawnaLiczba)
            {
                Console.WriteLine("Musisz wpisać liczbę!");
                break;
            }

            int indeks = numer - 1;

            if (indeks < 0 || indeks >= plecak.Count)
            {
                Console.WriteLine("Nieprawidłowy numer przedmiotu.");
                break;
            }

            string przedmiot = plecak[indeks];

            plecak.RemoveAt(indeks);

            Console.WriteLine($"Wyrzucono: {przedmiot}");

            historia.Add($"{numerTury}: Wyrzucono: {przedmiot}");

            numerTury++;

            break;
        }

        case "6":
        {
            if (historia.Count == 0)
            {
                Console.WriteLine("Historia jest pusta.");
            }
            else
            {
                Console.WriteLine("=== HISTORIA WYDARZEŃ ===");

                foreach (string akcja in historia)
                {
                    Console.WriteLine(akcja);
                }
            }

            break;
        }

        case "7":
        {
            int sumaZlota = 0;
            int maksymalneZloto = 0;
            int turyBezZlota = 0;

            int rozegraneTury = numerTury - 1;

            if (rozegraneTury > zlotoZdobyteWTurach.Length)
            {
                rozegraneTury = zlotoZdobyteWTurach.Length;
            }

            for (int i = 0; i < rozegraneTury; i++)
            {
                sumaZlota += zlotoZdobyteWTurach[i];

                if (zlotoZdobyteWTurach[i] > maksymalneZloto)
                {
                    maksymalneZloto = zlotoZdobyteWTurach[i];
                }

                if (zlotoZdobyteWTurach[i] == 0)
                {
                    turyBezZlota++;
                }
            }

            Console.WriteLine("=== STATYSTYKI WYPRAWY ===");
            Console.WriteLine($"Liczba eksploracji: {liczbaEksploracji}");
            Console.WriteLine($"Łączne złoto zdobyte podczas eksploracji: {sumaZlota}");
            Console.WriteLine($"Najwięcej złota w jednej turze: {maksymalneZloto}");
            Console.WriteLine($"Liczba tur bez zdobytego złota: {turyBezZlota}");

            break;
        }

        case "8":
        {
            graDziala = false;
            powodZakonczenia = "gracz wybrał wyjście.";
            break;
        }

        default:
        {
            Console.WriteLine("Niepoprawna opcja.");
            break;
        }
    }

    if (graDziala && numerTury > 20)
    {
        graDziala = false;
        powodZakonczenia = "osiągnięto limit 20 tur.";
    }
}

// PODSUMOWANIE

Console.WriteLine("\n=== PODSUMOWANIE ===");
Console.WriteLine($"Bohater: {name}");
Console.WriteLine($"Rozegrane tury: {numerTury - 1}");
Console.WriteLine($"Eksploracje: {liczbaEksploracji}");
Console.WriteLine($"Zdrowie: {punktyZycia}/{maksymalneZdrowie}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"Przedmioty w plecaku: {plecak.Count}");
Console.WriteLine($"Wpisy w historii: {historia.Count}");
Console.WriteLine($"Powód zakończenia: {powodZakonczenia}");

Console.WriteLine("\n=== KOŃCOWA ZAWARTOŚĆ PLECAKA ===");

if (plecak.Count == 0)
{
    Console.WriteLine("Plecak jest pusty.");
}
else
{
    for (int i = 0; i < plecak.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {plecak[i]}");
    }
}

Console.WriteLine("\n=== OSTATNIE TRZY WPISY HISTORII ===");

if (historia.Count == 0)
{
    Console.WriteLine("Historia jest pusta.");
}
else
{
    int poczatek = historia.Count - 3;

    if (poczatek < 0)
    {
        poczatek = 0;
    }

    for (int i = poczatek; i < historia.Count; i++)
    {
        Console.WriteLine(historia[i]);
    }
}
