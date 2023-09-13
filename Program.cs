//Vamos fazer uma troca de lugar com o que escrevermos
string variavel1, variavel2, auxiliar;

Console.WriteLine("--- Troca de Valores ---\n");

Console.Write("variave 1..: ");
Variavel1 = Console.ReadLine()!;

Console.Write("Variavel 2..: ");
variavel2 = Console.ReadLine()!;

auxiliar = variave1;
variave1 = variave2;
variave2 = auxiliar;

Console.WriteLine("\nApós trocar os valores temos:\n");

Console.WriteLine($"variave 1 = {variave1}");
Console.WriteLine($"variave 2 = {variave2}");
