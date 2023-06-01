//Arrays - array (matriz), é uma variavel que contem multiplos valores. 
//Os elementos dentro de um array precisam ser todos do mesmo tipo
//Quando você cria um array, voce define o tamanho dele.
//O tamanho de um array é fixo. Não pode ser aumentado, nem diminuido.


int[] numeros = new int[5] { 9, 4, 7, 5, 2 }; //essa é a forma padrão de se criar arrays
//Para mostrar o valor contido dentro de um array, voce pricisa digitar a chave correspondente que fica dentro das []
Console.WriteLine($"O numero na primeira posição é o {numeros[0]}");
Console.WriteLine($"O numero na segunda posição é o {numeros[1]}");
Console.WriteLine($"O numero na terceira posição é o {numeros[2]}");
Console.WriteLine($"O numero na quarta posição é o {numeros[3]}");
Console.WriteLine($"O numero na quinta posição é o {numeros[4]}");

//Para mostrar todos os valores contidos dentro de uma array de uma vez só, precisamos usar um loop de repetição.
foreach(int i in numeros)//exemplo com foreach
{
    Console.WriteLine("usando o foreach : " + i);
}

for (int i = 0; i < numeros.Length; i++)//exemplo com for
{
    Console.WriteLine($"Com o for : {numeros[i]}");
}



//Como Copiar um array para outro

int[] numerosCopia = new int[5]; //primeiro voce instancia (cria) uma nova array, e determina o tamanho dela.
Array.Copy(numeros, numerosCopia, numeros.Length); //Copia os valores de numeros para numeros copia, na quantidade total do tamanho de numeros.

foreach(int i in numerosCopia)
{
    Console.WriteLine($"NumerosCopia : {i}");
}

//Ordem crescente Sort() / ordem decrescente Reverse()
Array.Sort(numeros); //Coloca em ordem numérica/alfabética.

Array.Sort(numerosCopia);
Array.Reverse(numerosCopia);//Inverte a ordem que os elementos do Array foram colocados, independente se estavam em ordem numérica/alfabética ou não.

for (int i=0;i< numerosCopia.Length; i++)
{
    Console.WriteLine($"Ordem crescente : {numeros[i]} e em ordem decrescente : {numerosCopia[i]}");
}


//Pesquisando por elementos dentro da Array

string[] nomes = new string[5] { "augusto", "dai", "bia", "bira", "paula" };

//Para ssaber o indice(chave) que o elemento esta localizado dentro da string
int indice = Array.IndexOf(nomes, "bia");
Console.WriteLine($"bia esta localizada na posição {indice}");

//Para pesquisar pelo nome
Console.WriteLine("Tente advinhar, e digite um nome que esteja dentro da Array");
string advinhaNome = Console.ReadLine();//Salva o nome em uma variavel
int local = Array.IndexOf(nomes, advinhaNome); //Salva o numero do da chave(local onde esta armazenado).

if(local == -1)//Cria uma condição para acessar o elemento buscado
{
    Console.Write("Nome não encontrado");
}
else { Console.Write($"{advinhaNome} esta na posição {local}"); };
