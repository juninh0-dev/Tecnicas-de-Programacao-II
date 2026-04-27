var caminho = @"C:\Users\0201392511042\Desktop\ManipulacaoArquivos\arquivo1.txt";
if (!File.Exists(caminho))
{
    File.WriteAllText(caminho, "Autor Desconhecido");
}

var novoTexto = "\r\n Quem canta seus males espanta" + Environment.NewLine +
    "Água mole em pedra dura tanto bate até que fura \r\n Casa de ferreiro espeto é de pau";
File.AppendAllText(caminho, novoTexto);
string conteudo = File.ReadAllText(caminho);
Console.WriteLine(conteudo);