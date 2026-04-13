using System.Data;
ArCondicionado ar1 = new ArCondicionado();
ar1.temperatura = 18;
ar1.superior = 25;
ar1.inferior = 10;

// Inscrevendo corretamente
ar1.AlarmeTemperaturaAlta += Monitor.tempSuperior;
ar1.AlarmeTemperaturaBaixa += Monitor.tempInferior;

ar1.temperaturaAjustada(30); // testa superior
ar1.temperaturaAjustada(5);  // testa inferior

ar1.alarmeDisparado();

delegate void AlarmeTemperatura();

class ArCondicionado()
{
    public double? temperatura { get; set; }
    public int? superior { get; set; }
    public int? inferior { get; set; }

    public event AlarmeTemperatura? AlarmeTemperaturaAlta;
    public event AlarmeTemperatura? AlarmeTemperaturaBaixa;
    public void alarmeDisparado()
    {
        Console.WriteLine("Iniciando a verificação de temperatura");
        if (temperatura > superior)
        {
            AlarmeTemperaturaAlta();
        }
        else if (temperatura < inferior)
        {
            AlarmeTemperaturaBaixa();
        }
    }
    public void temperaturaAjustada(double? novaTemp)
    {
        temperatura = novaTemp;
        alarmeDisparado();
    }

}

class Monitor
{
    public static void tempSuperior()
    {
        Console.WriteLine("A temperatura passou do limite superior!");
    }
    public static void tempInferior()
    {
        Console.WriteLine("A temperatura passou do limite inferior!");
    }
}