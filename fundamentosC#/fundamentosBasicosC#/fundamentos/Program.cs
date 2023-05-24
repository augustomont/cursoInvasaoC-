// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Na programação, o programa segue uma ordem de leitura.
 * Em geral, o que aparece primeiro.
 * Poré existe exceções.
 * E para elas nos seguimos a Ordem de Precedencia. (pesquise sobre o termo)
 */

/*Aqui pode se ver a base da escrita.
 * 
 * Para Criar uma variavel, deve seguir essa ordem. tipo variavel (recebe) valor;
 * ex: int x = 5; (variavel x, do tipo numero inteiro, recebe o valor 5)
 * Em C# é obrigatório definir o tipo da variavel (string,int,float,double,bool, etc...)
 * Só pode guardar dados do mesmo tipo. Ou seja, deve guardar numeros inteiros em int, nunca em uma string, pois ela não aceita.
 * 
 * dica: Pesquise os tipos primitivos de C#, e como usa-los.
 * 
 * Casó o valor atribuido a variavel seja uma constante(Ou seja, não irar mudar durante a execução do programa), use const antes.
 * ex: const decimal Pi = 1.14m;
 * 
 * Por convensão, pára nomear variaveis usa o padrão camelCase. Para constantes PascalCase.
 */

//Digitando o IMC

Console.WriteLine("Escrevas seu nome"); //Console é o lugar onde você vai rodar. WriteLine(EscreverLinha) é a ação que será executada.
string nome = Console.ReadLine(); //ReadLine(LerLinha) é a ação de ler o que foi escrito na linha anterior. Nesse caso lemos o que foi escrito pelo usuario, e guardamos essa informação dentro da variavel nome.


Console.WriteLine("Olá " + nome);//Concatenamos (juntamos duas partes sem modifica-las). 

Console.WriteLine("Digite seu peso");
//Tudo que o usuário escreve é salvo como tipo string. Para trnsformar em numero e poder fazer calculos, precisamos passar a string para tipo compativel com a operação que iremos fazer.
double peso = double.Parse(Console.ReadLine());//Mudar o tipo string para tipo double (double.Parse()), e salvar em uma variavel com o mesmo tipo double.

Console.WriteLine("Digite sua altura");
double altura = double.Parse(Console.ReadLine());

//Você pode reutilizar os valores armazenados nas variaveis. Inclusive salvar o resultado do calculo dentro de uma nova variavel (desde que seja do mesmo tipo).
double imc = peso / (altura * altura);//Em C# a ordem de precedencia dos operadores é a mesma da Matemática
Console.WriteLine("{0} seu IMC é de {1}",nome,imc);//Essa é outra forma de fazer concatenação.

Console.ReadLine();