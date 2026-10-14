Console.WriteLine("Imię bohatera: ");
string name = Console.ReadLine();
Console.WriteLine("maksymalne punkty życia: ");
int maxhp = int.Parse(Console.ReadLine());
Console.WriteLine("aktualne punkty życia");
int hp = int.Parse(Console.ReadLine());
Console.WriteLine("podstawowe obrażenia broni: ");
int broń = int.Parse(Console.ReadLine());
Console.WriteLine("premia do ataku: ");
double premia = double.Parse(Console.ReadLine());
Console.WriteLine("premia do ataku specjalnego: ");
double premia2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ile rzeczy zabiera?: ");
int items = int.Parse(Console.ReadLine());
int WolneMiejsceWPlecaku = 10 - items;
int MiejsceWPlecaku = 10;
Console.WriteLine("Ilość złota: ");
int zloto = int.Parse(Console.ReadLine());
Console.WriteLine("Liczba członków drużyny: ");
int team = int.Parse(Console.ReadLine());
int ZłotoDlaJednejOsoby = zloto / team;
int ResztaZłota = zloto % team;
Console.WriteLine("Posiada mapę?: ");
bool mapa = bool.Parse(Console.ReadLine());
bool zyje = hp > 0;
bool MaPełneŻycie = hp == maxhp;
bool WymagaLeczenia = !MaPełneŻycie;
bool MaMiejsceWPlecaku = items < 10;
bool gotowy = mapa && zyje;
double procenthp = (double)hp / maxhp;
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
Console.WriteLine($"| Plecak: {items}/{MiejsceWPlecaku,-39}|");
Console.WriteLine($"| Złoto: {zloto,-42}|");
Console.WriteLine($"| Liczba członków: {team,-32}|");
Console.WriteLine($"| Złoto dla jednej osoby: {ZłotoDlaJednejOsoby,-25}|");
Console.WriteLine($"| Złoto pozostające w skarbcu: {ResztaZłota,-20}|");
Console.WriteLine("+==================================================+");
Console.WriteLine($"| Ma mapę: {mapa,-40}|");
Console.WriteLine($"| Żyje: {zyje,-43}|");
Console.WriteLine($"| Ma pełne zdrowie: {MaPełneŻycie,-31}|");
Console.WriteLine($"| Wymaga leczenia: {WymagaLeczenia,-32}|");
Console.WriteLine($"| Ma miejsce w plecaku: {MaMiejsceWPlecaku,-27}|");
Console.WriteLine($"| Gotowy: {gotowy,-41}|");
Console.WriteLine("+==================================================+");





