Console.WriteLine("Podaj imię bohatera: ");
string name = Console.ReadLine();
Console.WriteLine("Podaj symbol bohatera: ");
char symbol = char.Parse(Console.ReadLine());
Console.WriteLine("Podaj poziom bohatera: ");
int poziom = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj iość sztuk złota bohatera: ");
int zloto = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj wagę plecaka w kilogramach: ");
double waga = double.Parse(Console.ReadLine());
Console.WriteLine("=====EKWIPUNEK=====");
Console.WriteLine($"Imię: {name} ");
Console.WriteLine($"symbol: {symbol} ");
Console.WriteLine($"Poziom: {poziom} ");
Console.WriteLine($"Waga: {waga} ");
Console.WriteLine($"Zloto: {zloto} ");


