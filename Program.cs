//Vamos fazer uma troca de lugar com o que escrevermos
string variavel1, variavel2, auxiliar;

Console.WriteLine("--- Troca de Valores ---\n");

Console.Write("variavel 1..: ");
variavel1 = Console.ReadLine()!;

Console.Write("Variavel 2..: ");
variavel2 = Console.ReadLine()!;

auxiliar = variavel1;
variavel1 = variavel2;
variavel2 = auxiliar;

Console.WriteLine("\nApós trocar os valores temos:\n");

Console.WriteLine($"variavel 1 = {variavel1}");
Console.WriteLine($"variavel 2 = {variavel2}");
