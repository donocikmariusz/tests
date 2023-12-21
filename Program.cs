Console.WriteLine("Wprowadź number: ");
string number = Console.ReadLine();
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
Console.WriteLine("");

for (int i = number.Length - 1; i >= 0; i--)
{    Console.Write(number[i]);
}

Console.WriteLine("");