using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 12, 8, 20, 3, 15, 7 };

        // a) Obter o maior número
        int maior = numeros.Max();
        Console.WriteLine($"Maior número: {maior}");

        // b) Somar todos os valores maiores que 10
        int soma = numeros.Where(n => n > 10).Sum();
        Console.WriteLine($"Soma dos maiores que 10: {soma}");
    }
}