using Composicao;
//Composição do lado de Pessoa(Bilateral) Pessoa->Celular
Pessoa pessoa1 = new Pessoa("Altair Preto",14, "999999999");
pessoa1.SetCelular(14, "999999999");
Console.WriteLine("Composição do lado do Todo(Pessoa-Celular)");
Console.WriteLine($"Nome: {pessoa1.Nome}");
foreach (var dado in pessoa1.Celulares)
{
    Console.WriteLine($"({dado.DDD}) - {dado.Numero}");
}


//Composição do lado de Celular(Bilateral) Pessoa->Celular
Pessoa pessoa2 = new Pessoa("João");
Celular cell = new Celular(14, "858587893", pessoa2);
Console.WriteLine("Composição do lado da parte celular-pessoa");
Console.WriteLine($"Nome: {cell.ProprietarioCelular.Nome}\n Telefone: ({cell.DDD}) {cell.Numero}");

namespace Composicao
{
    internal class Pessoa
    {
        public Pessoa(string nome, int ddd, string numero) 
        {
            Nome = nome;
            Celulares.Add(new Celular(ddd, numero));
                
        }
        public Pessoa(string nome) 
        {
            Nome = nome;
        }
        public void SetCelular(int ddd, string numero)
        {
            Celulares.Add(new Celular(ddd, numero));
        }
        public string Nome { get; set; }
        public List<Celular> Celulares = new List<Celular>();
    }
    class Celular
    {
        //Construtor se tiver a pessoa
        public Celular(int ddd, string numero) 
        { 
        }

        //Contrutor se não tiver a pessoa
        public Celular(int ddd, string numero, Pessoa pessoa) 
        { 
            DDD = ddd;
            Numero = numero;
            ProprietarioCelular = pessoa;
        }

        public int DDD { get; set; }
        public string Numero { get; set; }
        public Pessoa ProprietarioCelular { get; set; }
    }
}
