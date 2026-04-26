using System;
using System.Collections.Generic;
using System.Linq;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 17 },
            new Pessoa { Nome = "Maria", Idade = 22 },
            new Pessoa { Nome = "Carlos", Idade = 30 }
        };

        // Pessoas com idade maior que 18
        var maiores = pessoas.Where(p => p.Idade > 18);
        Console.WriteLine("Maiores de 18:");
        foreach (var p in maiores)
        {
            Console.WriteLine(p.Nome);
        }

        // Nomes ordenados alfabeticamente
        var nomesOrdenados = pessoas
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome);

        Console.WriteLine("\nNomes ordenados:");
        foreach (var nome in nomesOrdenados)
        {
            Console.WriteLine(nome);
        }
    }
}