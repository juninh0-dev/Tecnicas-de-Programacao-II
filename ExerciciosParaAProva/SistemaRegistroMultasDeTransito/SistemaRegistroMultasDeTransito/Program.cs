using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Iniciando Multador");
CentralDeMultas central = new CentralDeMultas();
// registrar as classes assinantes
central.MultaRegistrada += VerificarMulta.ChecarMultaGrave;

//Criando uma multa
Multa multa = new Multa()
{
    Placa = "GEK1234",
    TipoInfracao = "Passou sinal vermelho",
    Valor = 700,
    Data = DateTime.Now
};

//Registando a primeira multa
central.Registrar(multa);

//Criando a segunda multa
Multa multa2 = new Multa()
{
    Placa = "XYZ9999",
    TipoInfracao = "Estacionamento proibido",
    Valor = 200,
    Data = DateTime.Now
};

//Registando a segunda multa
central.Registrar(multa2);

// Filtando as multas pelo valor LINQ
var filtradas = central.FiltrarPorValor(500);

// Mostrando Resultado
foreach (var m in filtradas)
{
    Console.WriteLine($"Valor: {m.Valor}" + $"\nTipo de Infração: {m.TipoInfracao}");
}
// Salvando a multa


central.Salvar("multas.json");
public class Multa
{
    public string Placa {  get; set; }
    public string TipoInfracao {  get; set; }
    public double Valor {  get; set; }
    public DateTime Data {  get; set; }
}

public class CentralDeMultas
{
    //Lista das multas
    private List<Multa> multas = new List<Multa>();

    public delegate void MultaHandler(Multa m);

    public event MultaHandler MultaRegistrada;

    //Método para registrar as multas
    public void Registrar(Multa m)
    {
        multas.Add(m);
        Console.WriteLine("Registrando Multa!");
        //Disparando o evento
        MultaRegistrada?.Invoke(m);
    }

    public void Salvar(string caminho)
    {
        string json = JsonSerializer.Serialize(multas,
            new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(caminho, json);

        Console.WriteLine("Multas salvas com sucesso!");
    }

    public void Carregar(string caminho)
    {
        if (File.Exists(caminho))
        {
            string conteudo = File.ReadAllText(caminho);

            multas = JsonSerializer.Deserialize<List<Multa>>(conteudo) ?? new List<Multa>();

            Console.WriteLine("Lista de multas:");

            foreach (var mul in multas)
            {
                Console.WriteLine($"Tipo: {mul.TipoInfracao} - Valor: {mul.Valor}");
            }
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }

    public List<Multa> FiltrarPorValor(double valorMinimo)
    {
        return multas.Where(m => m.Valor > valorMinimo).ToList();
    }

}


// Assinante, ele vai pegar os dados que o delegate pegou no evento.
// ele só vira assinante depois que eu faço o que tá no comentário abaixo
// central.MultaRegistrada += VerificarMulta;
class VerificarMulta
{
    public static void ChecarMultaGrave(Multa m)
    {
        // m = Multa .Valor é o que eu quero puxar de valor da class Multa
        if(m.Valor > 500)
        {
            Console.WriteLine("MULTA GRAVE DETECTADA!");
        }
        else
        {
            Console.WriteLine("Não foi grave, mas multa é multa!");
        }
    }

}