using System;
using CalculadoraArquivo;

string? readResult;
bool rodando = true;

while (rodando)
{
    Console.Clear();
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine(@"or type ""exit"" to exit");
    Console.Write("\noperation: ");
    readResult = Console.ReadLine();

    if (readResult != null && readResult.ToLower() == "exit") break;

    if (readResult != null) {
        string[] input = readResult.Split();

        if (double.TryParse(input[0], out double n1) && double.TryParse(input[2], out double n2)) {

            double output = MinhaCalculadora.Calculadora(n1, n2, input[1]);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}