using System.Text.Json;

var caminho = "pessoas.json";
List<Pessoa> listaPessoas = new List<Pessoa>
{
    new Pessoa{Nome="Isa", Idade=24},
    new Pessoa{Nome="Altair", Idade=19},
    new Pessoa{Nome="Diego", Idade=19 }
};

//serialização em arquivo
if (!File.Exists(caminho))
{
    string jsonString = JsonSerializer.Serialize(listaPessoas,
        new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(caminho, jsonString);
    Console.WriteLine("Arquivo json gravado");
}
// desserialização
if (!File.Exists(caminho))
{
    string conteudo = File.ReadAllText(caminho);
    List<Pessoa> listaConteudo = JsonSerializer.Deserialize<List<Pessoa>>(conteudo);
    Console.WriteLine("Lista de Pessoas");
    foreach(var Pes in listaConteudo)
    {
        Console.WriteLine($"Nome:{Pes.Nome} - Idade:{Pes.Idade}");
    }
}
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    //construtor padrão (sem argumentos) obrigatório para desserilização
    public Pessoa() { }


    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}