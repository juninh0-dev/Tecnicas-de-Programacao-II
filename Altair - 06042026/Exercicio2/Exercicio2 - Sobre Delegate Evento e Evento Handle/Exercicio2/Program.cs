
Operacao somar = Somar;
Operacao sub = Sub;
Operacao mult = Mult;
Operacao div = Div;
somar(1, 2);
sub(200, 2);
mult(5, 5);
div(9, 6);

static void Somar(double x, double y)
{
    Console.WriteLine(x + y);
}

static void Sub(double x, double y)
{
    Console.WriteLine(x - y);
}

static void Mult(double x, double y)
{
    Console.WriteLine(x * y);
}

static void Div(double x, double y)
{
    Console.WriteLine(x / y);
}

Console.ReadKey();
public delegate void Operacao(double num1, double num2);