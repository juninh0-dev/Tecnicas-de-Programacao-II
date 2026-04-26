using System;
using System.Collections.Generic;
using System.Linq;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
}

class Pedido
{
    public int Quantidade { get; set; }
    public DateTime DataPedido { get; set; }
    public Produto Produto { get; set; }
    public Cliente Cliente { get; set; }
}

class Program
{
    static void Main()
    {
        var cliente1 = new Cliente { Nome = "João", Cpf = "111" };
        var cliente2 = new Cliente { Nome = "Maria", Cpf = "222" };

        var produto1 = new Produto { Nome = "Notebook", Preco = 3000 };
        var produto2 = new Produto { Nome = "Mouse", Preco = 100 };
        var produto3 = new Produto { Nome = "Monitor", Preco = 800 };

        var pedidos = new List<Pedido>
        {
            new Pedido { Cliente = cliente1, Produto = produto1, Quantidade = 1, DataPedido = DateTime.Now },
            new Pedido { Cliente = cliente1, Produto = produto2, Quantidade = 2, DataPedido = DateTime.Now },
            new Pedido { Cliente = cliente2, Produto = produto3, Quantidade = 1, DataPedido = DateTime.Now },
            new Pedido { Cliente = cliente2, Produto = produto2, Quantidade = 5, DataPedido = DateTime.Now }
        };

        // a) Pedidos agrupados por cliente
        var agrupados = pedidos.GroupBy(p => p.Cliente.Nome);

        Console.WriteLine("Pedidos por cliente:");
        foreach (var grupo in agrupados)
        {
            Console.WriteLine($"Cliente: {grupo.Key}");
            foreach (var p in grupo)
            {
                Console.WriteLine($" - {p.Produto.Nome} | Qtd: {p.Quantidade}");
            }
        }

        Console.WriteLine("\n--------------------------");

        // b) Clientes com pedidos acima de R$ 500
        var clientesAcima500 = pedidos
            .Where(p => p.Quantidade * p.Produto.Preco > 500)
            .Select(p => p.Cliente.Nome)
            .Distinct();

        Console.WriteLine("Clientes com pedidos acima de R$ 500:");
        foreach (var nome in clientesAcima500)
        {
            Console.WriteLine(nome);
        }

        Console.WriteLine("\n--------------------------");

        // c) Valor total de pedidos por cliente
        var totalPorCliente = pedidos
            .GroupBy(p => p.Cliente.Nome)
            .Select(g => new
            {
                Cliente = g.Key,
                Total = g.Sum(p => p.Quantidade * p.Produto.Preco)
            });

        Console.WriteLine("Total por cliente:");
        foreach (var item in totalPorCliente)
        {
            Console.WriteLine($"{item.Cliente} - R$ {item.Total}");
        }
    }
}