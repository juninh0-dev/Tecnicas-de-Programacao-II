# Técnicas-de-Programação-II
This repository was created for to store files of class programing in C#
# 📘 Conceitos Básicos de C# (Programação Orientada a Objetos)

Este documento explica de forma simples e direta alguns conceitos importantes usados em C# e na programação orientada a objetos (POO).

---

## 🧠 Orientação a Objetos (POO)

A Programação Orientada a Objetos é um paradigma de programação baseado na ideia de objetos, que representam coisas do mundo real.

Um objeto possui:

- Atributos → características (ex: nome, idade)
- Métodos → ações (ex: andar, falar)

Exemplo em C#:

```csharp
class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine("Olá, meu nome é " + Nome);
    }
}
```

Uso:

```csharp
Pessoa p = new Pessoa();
p.Nome = "João";
p.Apresentar();
```

---

## 📚 List (Lista)

`List` é uma coleção dinâmica, ou seja, ela pode crescer ou diminuir durante a execução do programa.

Diferente de arrays, você não precisa definir o tamanho antes.

Exemplo:

```csharp
List<string> nomes = new List<string>();

nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Carlos");

Console.WriteLine(nomes[0]);
```

Principais métodos:

| Método | Função |
|------|------|
| Add() | Adiciona item |
| Remove() | Remove item |
| Count | Quantidade de itens |

---

## 📦 Arrays

Array é uma estrutura que armazena vários valores do mesmo tipo.

O tamanho do array é fixo, definido na criação.

Exemplo:

```csharp
int[] numeros = new int[3];

numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
```

Ou:

```csharp
int[] numeros = {10, 20, 30};
```

---

## 📦 ArrayList

ArrayList é uma coleção que pode armazenar qualquer tipo de dado.

Ela era muito usada antes do `List<T>`.

Exemplo:

```csharp
ArrayList lista = new ArrayList();

lista.Add(10);
lista.Add("João");
lista.Add(true);
```

Hoje em dia prefere-se usar `List<T>`, porque é mais seguro em relação a tipos.

---

## 🧬 Herança

Herança permite que uma classe herde características de outra classe.

Isso evita repetição de código.

Exemplo:

```csharp
class Animal
{
    public void Comer()
    {
        Console.WriteLine("O animal está comendo");
    }
}

class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("Au au");
    }
}
```

Uso:

```csharp
Cachorro dog = new Cachorro();
dog.Comer();
dog.Latir();
```

---

## 🔗 Associação

Associação é quando uma classe utiliza outra classe, mas cada uma pode existir separadamente.

Exemplo:

```csharp
class Motor
{
    public void Ligar()
    {
        Console.WriteLine("Motor ligado");
    }
}

class Carro
{
    public Motor motor;
}
```

O Carro usa um Motor, mas os dois podem existir separadamente.

---

## 🧩 Agregação

Agregação é um tipo de associação onde um objeto contém outro, mas o objeto contido pode existir sozinho.

Exemplo:

```csharp
class Jogador
{
    public string Nome;
}

class Time
{
    public List<Jogador> Jogadores = new List<Jogador>();
}
```

Se o Time for removido, os Jogadores ainda podem existir.

---

## 🧱 Composição

Composição é uma relação mais forte que agregação.

O objeto não pode existir sem o outro.

Exemplo:

```csharp
class Motor
{
}

class Carro
{
    private Motor motor;

    public Carro()
    {
        motor = new Motor();
    }
}
```

Se o Carro for destruído, o Motor também deixa de existir.

---

## 🧾 Interface

Interface define um contrato que as classes devem seguir.

Ela diz quais métodos devem existir, mas não implementa a lógica.

Exemplo:

```csharp
interface IAnimal
{
    void FazerSom();
}
```

Implementação:

```csharp
class Gato : IAnimal
{
    public void FazerSom()
    {
        Console.WriteLine("Miau");
    }
}
```

Uso:

```csharp
IAnimal animal = new Gato();
animal.FazerSom();
```

---

## 📌 Resumo

| Conceito | Explicação |
|------|------|
| POO | Organiza código usando objetos |
| List | Lista dinâmica de elementos |
| Array | Lista com tamanho fixo |
| ArrayList | Lista dinâmica de qualquer tipo |
| Herança | Uma classe herda de outra |
| Associação | Uma classe usa outra |
| Agregação | Objeto contém outro que pode existir sozinho |
| Composição | Objeto depende totalmente de outro |
| Interface | Define regras que classes devem seguir |

---

Esses conceitos são fundamentais para programar em C# e em linguagens orientadas a objetos.
