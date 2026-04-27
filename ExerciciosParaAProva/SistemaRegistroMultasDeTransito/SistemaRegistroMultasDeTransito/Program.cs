using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Iniciando Multador");
CentralDeMultas central = new CentralDeMultas();
// registrar as classes assinantes
central.MultaRegistrada += VerificarMulta.ChecarMultaGrave;

//Criando uma multa
Multa multa = new Multa() { 
    Placa = "GEK1234",
    TipoInfracao = "Passou sinal vermelho",
    Valor = 700,
    Data = DateTime.Now
};
//Registando uma multa
central.Registrar(multa);

Multa multa2 = new Multa()
{
    Placa = "XYZ9999",
    TipoInfracao = "Estacionamento proibido",
    Valor = 200,
    Data = DateTime.Now
};

central.Registrar(multa2);

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