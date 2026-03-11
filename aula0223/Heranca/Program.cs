using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Aluno aluno1 = new Aluno("Paulo", "111.111.111-11", "0201392511050");
Console.WriteLine($"Nome:{aluno1.Nome}\n CPF:{aluno1.Cpf}\n" +
    $"RA:{aluno1.Ra}");

Console.WriteLine("Digite o nome do professor");
var nomeProf = Console.ReadLine();

Console.WriteLine("Digite o cpf do professor");
var cpfProf = Console.ReadLine();

Console.WriteLine("Digite o titulação do professor");
var titutalacaoProf = Console.ReadLine();

Professor prof1 = new Professor(nomeProf, cpfProf, titutalacaoProf); 
Professor.Exibir(prof1);

Console.ReadKey();

public class Pessoa {
    public Pessoa(string? nome, string? cpf) {
        Nome = nome;
        Cpf = cpf;
    }

    public string? Nome { get; set; }
    public string? Cpf { get; set; }
}



public class Aluno : Pessoa
{
    public Aluno(string? nome, string? cpf, string ra):base(nome,cpf)
    {
        Ra = ra;
    }
    public string? Ra { get; set; }
}

public class Professor : Pessoa
{
    public Professor(string? nome, string? cpf, string titulacao) : base(nome, cpf)
    {
        Titulacao = titulacao;
    }

    public static void Exibir(Professor prof) => Console.WriteLine($"{prof.Nome}\n{prof.Cpf}\n{prof.Titulacao}");

    public string? Titulacao { get; set; }
   
}

