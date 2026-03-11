// Exemplo de ARRAY

int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] valores;
valores = new int[2] { 20, 10 };

string[] nomes = new string[5] { "Maria", "Paulo", "Pedro", "Altair", "Luis" };

//classe Array
Array.Reverse(numeros); // Inverte a ordem dos elementos do array
Array.Sort(nomes);// Sort ordena a ordem do array em ordem crescente
int indice = Array.BinarySearch(nomes, "Pedro"); // Ele procura pelo nome Pedro
Console.WriteLine($"Encontrou Pedro no índice {indice}");
//mostrar com foreach
foreach (var dado in nomes)
{
    Console.WriteLine(dado);
}
for (int x = 0; x < 2; x++)
{
    Console.WriteLine(valores[x]);
}

//Matriz de mais de uma dimesão
int[,] Mat1;
Mat1 = new int[2, 3]; // Aqui estou dizendo quantos índices tem a matriz
Mat1[0, 0] = 1; // Aqui estou atribuindo um valor para os índices 0 , 0
int[,] Mat2 = new int[3, 2] { { 1 ,2 }, { 3, 4 }, { 5, 6 } };

for (int lin = 0; lin < Mat2.GetLength(0); lin++)
{
    for(int col = 0; col < Mat2.GetLength(1); col++)
    {
        Console.WriteLine(Mat2[lin, col]);
    }
}

foreach (var dado in Mat2)
{
    Console.WriteLine(dado);
}