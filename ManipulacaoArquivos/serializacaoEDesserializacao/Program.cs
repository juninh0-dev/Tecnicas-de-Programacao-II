var pessoa = new Pessoa { Nome = "Maria", Idade = 21 };

// Serializar
string json = System.Text.Json.JsonSerializer.Serialize(pessoa);
Console.WriteLine(json);
// Desserilização
var jsonString = "{\"Nome\":\"João\",\"Idade\":25}";

Pessoa pessoaDess = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonString);
Console.WriteLine(pessoaDess.Nome);

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    //construtor padrão (sem argumentos) obrigatório para desserilização
    public Pessoa() { }


    public Pessoa (string nome,  int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}