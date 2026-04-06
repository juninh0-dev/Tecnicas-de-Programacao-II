using System.Data;

delegate void AlarmeTemperatura();
class ArCondicionado()
{
    public double temperatura { get; set; }
    public event AlarmeTemperatura? AlarmeTemperatura;
    public void alarmeDisparado()
    {
        Console.WriteLine("Iniciando a verificação de temperatura");
        if(temperatura != null)
        {
            AlarmeTemperatura();
        }
    }
    public int LimiteSuperior { get; set; }
    public int LimiteInferior { get; set; }
}

class Monitor:ArCondicionado
{
    public static void verificandoTemp(double temperatura, double superior, double inferior)
        {
        if (temperatura < inferior) 
        { 
            Console.WriteLine("A temperatura está a baixo do ideal");
        
        } else if (temperatura > superior)
        {
            Console.WriteLine("A temperatura está acima do ideal");
        }
    }
}