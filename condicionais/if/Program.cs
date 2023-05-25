
DateTime anoNascimento = new DateTime(1987, 04, 11);
DateTime hoje = DateTime.Today;

int idade = (hoje.Year - anoNascimento.Year);



if (idade < 18 || idade > 65)
{
    Console.WriteLine($"Com {idade} anos, não é permitido trabalhar aqui");
} else
{
    Console.WriteLine("Bao sorte no processo");
}