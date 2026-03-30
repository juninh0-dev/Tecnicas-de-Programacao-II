
try 
{ 
Console.WriteLine("Digite o Dividendo");
int dividendo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o divisor");
int divisor = Convert.ToInt32(Console.ReadLine());
var resultado = dividendo /  divisor;
Console.WriteLine($"o resultado de {dividendo}/{divisor} = {resultado}");

}
catch(FormatException){ // faz a mesma coisa
    Console.WriteLine("Entre com um valor inteiro");

}
catch(Exception ex) when (ex.Message.Contains("Format")){ // que esse aqui
    //mas são maneiras diferentes de ser tratadas
    Console.WriteLine("Entre com um valor inteiro");

}
catch(DivideByZeroException){
    Console.WriteLine("Divisor não pode ser zero!");
}
catch(Exception ex){
    Console.WriteLine($"Problema na divisão: {ex.Message}.");
}
finally{
    Console.WriteLine("Acabooou!");
}