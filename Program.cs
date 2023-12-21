// obliczanie x!

Console.WriteLine("Podaj liczbę do obliczenia silni");
string s = Console.ReadLine();
int.TryParse(s, out int x);


int[] liczby = new int[x];
int suma = 0;

for (int i = 0; i < liczby.Length; i++)
{
    liczby[i] = i + 1;
    Console.WriteLine(liczby[i]);
    suma = suma + liczby[i];
}

Console.WriteLine("Silnia dla " + x + "!, wynosi: " + suma);
