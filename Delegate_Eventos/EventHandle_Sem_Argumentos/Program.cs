Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();
//registrar as classes assinantes
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;
pedido.criarPedido();

class Pedido
{
    public event EventHandler? OnCriarPedido;

    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (OnCriarPedido != null)
        {
            //mesmo que não tenha parametros é obrigatório ter (this,EventArgs.Empty)
            OnCriarPedido(this,EventArgs.Empty);
        }
    }
}

class EnviarEmail
{
    public static void email(Object? sender, EventArgs e)
    {
        Console.WriteLine("Email enviado");
    }
}

class EnviarSMS
{
    public static void sms(Object? sender, EventArgs e)
    {
        Console.WriteLine("SMS enviado");
    }
}
