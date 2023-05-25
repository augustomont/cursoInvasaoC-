//Boolean , && , || , > , < , == , != , =

//Operadores Relacionais comparam um valor com outro. Ou seja, fazem uma relação entre dois valores e retornam um bool (Booleano)

//Booleanos retorna apenas True ou False. Analisa uma expressão e retorna se ela é Verdadeira ou Falsa


/* > (maior que) -> 10 > 5
 * < (menor que) -> 5 < 10
 * = (recebe) -> Quando tem apenas um sinal de = , deve ser ler RECEBE. Ou seja, uma variável recebe um valor.Ex: X = 5 (X recebe, e armazena, o valor de 5).
 * == (igual) -> 10 == 10
 * != (não-igual / diferente) -> 10 != 5 -> Na programação em C# o sinal de exclamação (!) significa uma negação do que virá a seguir.
 */

int idade = 39;

    bool a = (idade == 41);
Console.WriteLine("Idade é igual a 41? " + a);

    bool b = (idade != 41);
 
Console.WriteLine("Idade é não-igual (diferente) a 41? " + b);

    bool c = (idade > 41);
Console.WriteLine("Idade é Maior que 41? " + c);

    bool d = (idade < 41);
Console.WriteLine("Idade é Menor que 41? " + d);

/* && (e) -> as duas afirmações precisão ser verdadeiras para retornar um True (a primeira e a segunda). caso uma seja falsa, mesmo que a outra seja verdadeira, no final retorna False
 * || (ou) -> apenas uma das opções precisa ser verdadeira (primeira ou a segunda). Mesmo que uma seja verdadeira, e a outra falsa, no final retorna True. apenas retorna False se as duas forem falsas
 * >= (Maior ou igual)
 * <= (Menor ou igual)
 */

    bool e = (idade >= 18) && (idade <= 50);
Console.WriteLine("(A idade é maior ou igual a 18) e (menor ou igual a 50) ? " + e);

    bool f = (idade >= 18) || (idade <= 50);
Console.WriteLine("(A idade é maior ou igual a 18) ou (menor ou igual a 50) ? " + f);