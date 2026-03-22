using System;

public class MaquinaNaoEncontradaException : Exception
{
    public MaquinaNaoEncontradaException(string mensagem) : base(mensagem)
    {
    }
}