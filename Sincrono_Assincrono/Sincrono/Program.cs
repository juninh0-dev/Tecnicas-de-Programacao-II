using System.Reflection;

Console.WriteLine("Café da manhã sincrono");
cafeDaManha();
Console.WriteLine("Fim do Café da manhã");

static void cafeDaManha()
{
    Console.WriteLine("Preparar o café");
    var cafe = PrepararCafe();
    Console.WriteLine("\n Preparar o pão");
    var pao = PrepararPao();
    ServirCafe(cafe, pao);
}

static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\n Servindo café da manhã");
    Thread.Sleep(2000);
    Console.WriteLine("\n Café da manhã servido.");
}

static Pao PrepararPao()
{
    Console.WriteLine("\n Partir o pão");
    Thread.Sleep(2000);
    Console.WriteLine("\n Passar manteiga");
    Thread.Sleep(2000);
    return new Pao();
}

static Cafe PrepararCafe()
{
    Console.WriteLine("\n Ferver a água");
    Thread.Sleep(2000);
    Console.WriteLine("\n Coar o café");
    Thread.Sleep(2000);
    return new Cafe();
}

internal class Cafe
{

}
internal class Pao
{

}