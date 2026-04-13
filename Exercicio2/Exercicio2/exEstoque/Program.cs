using System;

class Program
{
    static void Main()
    {
        Estoque prod1 = new Estoque();

        prod1.EstoqueBaixo += ExibirMensagem;

        prod1.verificarminimo("Arroz", 10, 15);
    }

    static void ExibirMensagem(object? sender, EstoqueArgs e)
    {
        Console.WriteLine($"{e.Nome} possui {e.QuantidadeProduto} e está abaixo do mínimo ({e.Minimo})");
    }
}

class EstoqueArgs : EventArgs
{
    public string? Nome { get; set; }
    public int? QuantidadeProduto { get; set; }
    public int? Minimo { get; set; }
}

class Estoque
{
    public event EventHandler<EstoqueArgs>? EstoqueBaixo;

    public void verificarminimo(string nome, int quantidadeProduto, int minimo)
    {
        if (quantidadeProduto < minimo)
        {
            EstoqueBaixo?.Invoke(this, new EstoqueArgs
            {
                Nome = nome,
                QuantidadeProduto = quantidadeProduto,
                Minimo = minimo
            });
        }
    }
}