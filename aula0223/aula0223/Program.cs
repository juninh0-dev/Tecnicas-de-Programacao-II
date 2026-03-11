//usando
using System.Reflection;
using OrientacaoObejto;

Produto prod1 = new Produto();
prod1.Nome = "Caderno";
prod1.Preco = 12.90;
//objeto prod1
Console.WriteLine("Nome: " + prod1.Nome);
Console.WriteLine($"Preço: {prod1.Preco}");


Produto prod2 = new Produto("Láps", 1.50);
//objeto prod2
Console.WriteLine("Nome: " + prod2.Nome);
Console.WriteLine($"Preço: {prod2.Preco}");

//objeto de Produto2

Produto2 prod3 = new("Iphone 18 PRO max", 99.90, 500); // Pode ser criado um novo objeto sem o Produto3();
prod3.Exibir();

Console.ReadKey();
//declarando

public class Produto
{
    public Produto(){}
    public Produto(string? nome, double Preco)
    {
        Nome = nome;
        this.Preco = Preco;
    }
    public string? Nome { get; set; }
    public double Preco { get; set; }
}