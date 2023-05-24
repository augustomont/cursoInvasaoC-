//Operadores Aritméticos na programação seguem a mesma ordem tradicional da matemática

OperadoresAritmeticos();
static void OperadoresAritmeticos()
{
    int a =5, b =10, c = 15;

  
    Console.WriteLine("a + b = " + (a + b)); //Soma
    Console.WriteLine("a - b = " + (a - b)); //Diminui
    Console.WriteLine("a * b = " + (a * b)); //Multiplica
    Console.WriteLine("a / b = " + (a / b)); //Divide
    Console.WriteLine("a % b = " + (a % b)); //Resto da divisão (ou seja, quando você divide 7 por 2, o resultado é 3, mas o resto é 1)

    Console.WriteLine("a + b * c = " + (a + b * c)); //Aqui é feita a multiplicação primeiro
    Console.WriteLine("(a + b) * c = " + ((a + b) * c)); //Aqui primeiro se resolve o que esta dentro de (), e só depois multiplica com o de fora.

    //Operadores Aritméticos com Atribuição Reduzida

    int mes = 5;
    mes += 1; //é o mesmo que mes = mes + 1;
    Console.WriteLine(mes); 
    
    //Incremento / Decremento => quando usamos ++ ou -- para adicionar (ou subtrair) uma unidade.
    Console.WriteLine(++mes); //Nessa operação, primeiro se adiciona 1, depois escreve o valor do mes
    Console.WriteLine(mes++); //Nessa operação, primeiro escreve o valor de mes, depois adiciona 1
    Console.WriteLine(mes); //Valor atual de mes, depois da ultima operação

}
