
//Modo tradicional

int data = new DateTime(1987, 04, 01).Month;

switch (data)
{
    case < 3:
        Console.WriteLine("Verão");
            break;
    case < 6:
        Console.WriteLine("Outono");
            break;
    case < 9:
        Console.WriteLine("Inverno");
            break;
    case < 12:
        Console.WriteLine("Verão");
            break;
    default: Console.WriteLine("Erro");
        break;
}



// ou... Usando Arrow Function (Lambda)


static string EstacaoDoAno(DateTime data) => data.Month switch
{
    >= 3 and <= 6 => "Outono",
    >= 6 and <= 9 => "inverno",
    >= 9 and <= 12 => "Primavera",
    12 or (>=1 and < 3) => "Verão",
    _ => "Erro"
};
Console.WriteLine(EstacaoDoAno(DateTime.Now));