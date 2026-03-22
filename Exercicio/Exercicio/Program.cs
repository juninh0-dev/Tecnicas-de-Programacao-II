using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Criando fábrica
        var fabrica = new Fabrica { Nome = "Fábrica XPTO" };

        // Criando máquinas
        var m1 = new Maquina
        {
            Nome = "Equipamento A",
            Modelo = "X1",
            DataFabricacao = new DateTime(2022, 1, 10),
            HoraOperacao = "100h"
        };

        var m2 = new Maquina
        {
            Nome = "Equipamento B",
            Modelo = "X2",
            DataFabricacao = new DateTime(2023, 5, 20),
            HoraOperacao = "200h"
        };

        // Adicionando máquinas
        fabrica.AdicionarMaquina(m1);
        fabrica.AdicionarMaquina(m2);

        // Listando máquinas
        Console.WriteLine("=== LISTA DE MÁQUINAS ===");
        fabrica.ListarMaquinas();

        // Criando operador
        var operador = new Operador { Nome = "João" };

        try
        {
            Console.WriteLine("\n=== OPERAÇÃO ===");
            await operador.OperarMaquinaAsync(fabrica, "X1");

            Console.WriteLine("\n=== TESTE ERRO ===");
            await operador.OperarMaquinaAsync(fabrica, "X99");
        }
        catch (MaquinaNaoEncontradaException ex)
        {
            Console.WriteLine($"ERRO: {ex.Message}");
        }
    }
}