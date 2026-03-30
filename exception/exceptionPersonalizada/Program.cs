ContaBancaria conta = new ContaBancaria(300.00m);

try
{
    conta.Sacar("100");
}
catch(SaldoInsuficienteExecption ex)
{
    Console.WriteLine("Erro de saldo: " + ex.Message);
}
try
{
    conta.Sacar("800");
}
catch (SaldoInsuficienteExecption ex)
{
    Console.WriteLine("Erro  de Saldo: " + ex.Message);
}
try
{
    conta.Sacar("saasjsakj");
}
catch (SaldoInsuficienteExecption ex)
{
    Console.WriteLine(ex.Message);
}
public class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(string valorTexto)
    {
        try
        {
            decimal valor = decimal.Parse(valorTexto);
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteExecption($"Saldo Insuficiente. Saldo Atual: R${Saldo} Tentativa de saque no vlaor de R${valor}");
            }
            Saldo -= valor;
            Console.WriteLine($"Saldo Atual: R${Saldo}");
        }
        catch (FormatException fe)
        {
            throw new ApplicationException("Erro ao converter o valor de saque", fe);
        }
        finally 
        { 
            Console.WriteLine("Fim do saque.");
        }
    } // fim do método sacar
}// fim da classe

public class SaldoInsuficienteExecption : Exception
{

public SaldoInsuficienteExecption () { }

public SaldoInsuficienteExecption(string mensagem) : base(mensagem){ }

public SaldoInsuficienteExecption(string mensagem, Exception innerException) : base(mensagem, innerException){ }
}