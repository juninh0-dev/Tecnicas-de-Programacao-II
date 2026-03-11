
using System.Collections;


//Mesmo se eu adicionar um elemento a mais do índice ele aumenta, pois cresce dinamicamente
ArrayList lista = new ArrayList(5);
ArrayList lista2 = new(2);
lista.Add("Maria");
lista.Add(18);
lista.Add(1.85);
lista.Add(true);
lista.Add(null);
// adiciona um elemento de qualquer tipo no índice específicado
lista.Insert(3, 65);

int[] array1 = { 1, 2, 3 };

// adiciona uma coleção no final do arraylist
lista.AddRange(array1);

//adiciona uma coleção a partir do índice especificado
lista.InsertRange(0, array1);

// Remove - remove um elemento do arraylist r
lista.Remove("Maria");

// RemoveAt - remove um elemento da lista específico
lista.RemoveAt(1);

// RemoveRange - inciar o remove de um índice e a partir dele especificada 
lista.RemoveRange(2, 4);

foreach(var dado in lista)
{
    Console.WriteLine(dado);
}

var lista3  = new ArrayList() { "Maria", "Paulo", "Ana"};
lista3.Sort();

var res1 = lista3.Contains("Paulo"); // Contains serve para verificar um elemento dentro de um objeto

foreach (var dado in lista3)
{
    Console.WriteLine(dado);    
}

if (res1)
{
    Console.WriteLine("Contém");
}
else
{
    Console.WriteLine("Não contém");
}

lista3.Clear();

foreach (var dado in lista3)
{
    Console.WriteLine(dado);
}