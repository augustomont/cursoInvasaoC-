using System.Text; //Pacote que permite usar o StringBuilder

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string nome = "augusto";

//Formas de Concatenar string
string concatenacao1 = ("Olá "+ nome);
Console.WriteLine(concatenacao1);

string concatenacao2 = string.Concat("Olá ", nome, "!");
Console.WriteLine(concatenacao2);

string concatenacao3 = $"Olá {nome}!";
Console.WriteLine(concatenacao3);

string concatenacao4 = string.Format("Olá {0}!", nome);
Console.WriteLine(concatenacao4);

//Cada vez que você faz a concatenação, e valva em nova variável, você esta criando mais copias, e alocando mais espaço na memoria
//
//Quando for concatenar uma string que varias vezes, ou ela seja muito grande. Use o StringBuilder.
StringBuilder concatBuilder = new StringBuilder();//Caso não tenha adicionado o pacote no topo desse programa, Aqui vai te pedir para adcionar o pacote System.Text. só clicar na lampada, depois em using System.Text
concatBuilder.Append("Olá ").Append(nome).Append("!").Append("kkkkk").Append(concatenacao2);
concatBuilder.ToString();
Console.WriteLine(concatBuilder);


string maiusculo = ("Passar todas as Letras para o Maiúsculo").ToUpper();
Console.WriteLine(maiusculo);

string minusculo = ("Passar TODAS as Letras para o Minúsculo").ToLower();
Console.WriteLine(minusculo);

string mostrarUmaParte = ("Mostrar apenas uma parte especifica!");
Console.WriteLine(mostrarUmaParte.Substring(3, 9)); //Substring(inicio, quantidade de caracteres)
int tamanho = (mostrarUmaParte.Length); //guardei o tamanho de caracteres da string em outra variável
Console.WriteLine(mostrarUmaParte.Substring(0, tamanho-5));

//Criando um Array de string
string[] carros = new string[] { "fusca", "gol", "palio", "celta" }; 

//metodo para mostrar todos os itens dentro de um Array.
foreach(string carroX in carros)
{
    Console.WriteLine(carroX);
}


