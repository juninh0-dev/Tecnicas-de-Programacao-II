Botao btn = new Botao();
btn.Clique += ContadorCliques.clicou;
btn.simularClique();
btn.simularClique();
btn.simularClique();
btn.simularClique();
btn.simularClique();
btn.simularClique();
btn.simularClique();
btn.simularClique();
btn.simularClique();


class Botao()
{
    public event EventHandler? Clique;
    public void simularClique()
    {
        Clique?.Invoke(this, EventArgs.Empty);
    }
}

class ContadorCliques()
{
    static int contador = 0;
    public static void clicou(Object? sender, EventArgs e)
    {
        contador++;           
        Console.WriteLine($"Clicou! {contador}");
        
    }
}