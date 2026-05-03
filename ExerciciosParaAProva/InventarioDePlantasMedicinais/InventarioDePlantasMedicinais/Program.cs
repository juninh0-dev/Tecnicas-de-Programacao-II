using System.Text.Json;

Console.WriteLine("Iniciando Inventário de Plantas");

// Instância
InventarioDePlantas inventario = new InventarioDePlantas();

// Assinantes
inventario.PlantaEmExticao += LogPlanta.GravarLog;
inventario.PlantaEmExticao += ExibirPlanta.MostrarConsole;

// Carregar do JSON
inventario.CarregarDeArquivoJson("plantas.json");

// LINQ - Quantidade por planta
Console.WriteLine("\nQuantidade de coletas por planta:");
var quantidade = inventario.ContarPorPlanta();

foreach (var item in quantidade)
{
    Console.WriteLine($"{item.Key} - {item.Value} coletas");
}

// LINQ - Agrupar por local
Console.WriteLine("\nAgrupado por local:");
var grupos = inventario.AgruparPorLocal();

foreach (var grupo in grupos)
{
    Console.WriteLine($"\nLocal: {grupo.Key}");
    foreach (var planta in grupo)
    {
        Console.WriteLine($"- {planta.NomePopular}");
    }
}

public class Planta
{
    public string NomeCientifico { get; set; }
    public string NomePopular { get; set; }
    public string LocalColeta { get; set; }
    public bool EmExtincao { get; set; }
    public DateTime DataColeta { get; set; }
}

public class InventarioDePlantas
{
    private List<Planta> plantas = new List<Planta>();

    public delegate void PlantaHandler(Planta p);
    public event PlantaHandler PlantaEmExticao;

    public void CarregarDeArquivoJson(string caminho)
    {
        if (File.Exists(caminho))
        {
            string conteudo = File.ReadAllText(caminho);

            plantas = JsonSerializer.Deserialize<List<Planta>>(conteudo) ?? new List<Planta>();

            foreach (var p in plantas)
            {
                if (p.EmExtincao)
                {
                    PlantaEmExticao?.Invoke(p);
                }
            }
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }

    // LINQ 1 - Contar por planta
    public Dictionary<string, int> ContarPorPlanta()
    {
        return plantas
            .GroupBy(p => p.NomePopular)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    // LINQ 2 - Agrupar por local
    public List<IGrouping<string, Planta>> AgruparPorLocal()
    {
        return plantas
            .GroupBy(p => p.LocalColeta)
            .ToList();
    }
}

// Ouvinte 1 - Log
class LogPlanta
{
    public static void GravarLog(Planta p)
    {
        string mensagem = $"Alerta: Planta em perigo de extinção - {p.NomePopular} - {p.DataColeta}\n";
        File.AppendAllText("log.txt", mensagem);
    }
}

// Ouvinte 2 - Console
class ExibirPlanta
{
    public static void MostrarConsole(Planta p)
    {
        Console.WriteLine($"ALERTA: {p.NomePopular} encontrada em {p.LocalColeta}");
    }
}