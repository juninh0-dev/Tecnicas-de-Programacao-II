Console.WriteLine("Usando evento");
Pedido pedido = new Pedido();
//registrar as classes assinantes
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;
pedido.criarPedido("joao.justo@email.com", "(14) 99898-0093");

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    public event EventHandler<PedidoEventArgs>? OnCriarPedido;

    public void criarPedido(string email, string telefone)
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (OnCriarPedido != null)
        {
            //mesmo que não tenha parametros é obrigatório ter (this,EventArgs.Empty)
            OnCriarPedido(this, new PedidoEventArgs
            {
                Email = email,
                Telefone = telefone
            });
        }
    }
}

class EnviarEmail
{
    public static void email(Object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Email enviado para: {e.Email}");
    }
}

class EnviarSMS
{
    public static void sms(Object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"SMS enviado para: {e.Telefone}");
    }
}
