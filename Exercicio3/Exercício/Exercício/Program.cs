using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensoes
{
    public static int SomaImpares(this List<int> lista)
    {
        return lista.Where(n => n % 2 != 0).Sum();
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

        int resultado = numeros.SomaImpares();

        Console.WriteLine(resultado);
    }
}