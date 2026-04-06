//segunda etapa

MeuDelegate del1 = new MeuDelegate(MeuMetodo);
MeuDelegate del2 = MeuMetodo;
MeuDelegate del3 = (msg) => Console.WriteLine(msg);

del1.Invoke("Minha Mensagem 1");
del2("Minha Mensagem 2");
del1("Minha Mensagem 3");

static void MeuMetodo(string mensagem)
{
    Console.WriteLine(mensagem);
}

Console.ReadKey();
//primeira etapa
public delegate void MeuDelegate(string msg);
