//List<Pessoa> qualquer tipo

//foi tipado depois
var lista = new List<string>();
lista.Add("Laranja");

//Já está tipado
List<int> lista2 = new();

var lista3 = new List<string>() 
{ "Brasil", "Portugal", "Espanha" };

List<Carro> carros = new List<Carro>();

carros.Add(new Carro("Nissan", "SkyLine", 2005));

public class Carro
{
    public Carro(string marca, string modelo, int ano) {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int Ano { get; set; }
}