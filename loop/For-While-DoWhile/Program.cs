
int soma = 0;

for (int i=0; i < 10; i++) //Aqui vai colocar a logica de repetição. Ou seja, vai repetir enquanto essa logica for verdadeira
{
    //Aqui vai por o que voce quer que seja executado varias vezes
    soma += i;

    Console.WriteLine($"{soma} e {i}");
}

//Tambem é possivel escrever ttudo dentro dos (). Tanto a logica de repetição, quanto a ação que será executade. Alem de criar as variaveis dentro tambem
for (int i = 0, j = 100, soma2; i < j; i++, j--, soma2 = j - i, Console.WriteLine($"Diferença = {soma2} , i = {i}, e j = {j}")) ;

//While, Do While

int x = 0;

while (x < 10) //Enquanto isso for verdade, faça a ação descrita entre {}
{
    //Aqui entra o que sera executado varias vezes
    Console.WriteLine("Valor de x = " + x);
    x++;
}


// no "do while", ele executa primeiro, depois ele verifica a logica de repetição. Caso seja True, ele executa novamente.
do
{//Açao
    x++;
    Console.WriteLine(x + " é o valor de x Agora ");
} 
while (x < 20);//Logica de execução
