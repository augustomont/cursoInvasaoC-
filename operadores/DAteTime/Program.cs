//Criando e Manipulando Datas

using System.Data;

DateTimeExemplos();
static void DateTimeExemplos()
{

    DateTime vazia = new DateTime(); //Forma padrão para criar uma nova data vazia (01/01/0001 00:00:00) 
    Console.WriteLine(vazia);

    //Escrever uma DataHora especifica
    DateTime dataQualquer = new DateTime(2023, 05, 24, 18, 50, 35); //Formatando manualmente a data (ano,mes,dia,hora,minuto,segundo)
    Console.WriteLine("Data de Inicio" + dataQualquer);

    //Data de Hoje
    DateTime hoje = DateTime.Today;
    Console.WriteLine("Data de Hoje é " + hoje);

    //Data e Horario Atual
    DateTime agora = DateTime.Now;
    Console.WriteLine("Data e hora nesse momento é " + agora);

    //Dia da Semana
    DayOfWeek diaSemana = DateTime.Today.DayOfWeek; //Funciona também com DateTime.Now.DayOfWeek
    Console.WriteLine(diaSemana);

    DateTime incluirDias = DateTime.Now.AddDays(10).AddMonths(2).AddYears(-36); //Você pode incluir (ou diminuir) dias data atual, ou a uma outra data especifica.
                                                     //Tambem pode adicionar meses(AddMonths), horas(AddHours), anos(AddYears), Etc...
    Console.WriteLine(incluirDias);

    //Saber se é horário de verão (retorna um valor booleano - true/false)
    bool horarioDeVerao = agora.IsDaylightSavingTime(); //Usei o valor salvo em "agora". Mas pode ser qualquer data.
    Console.WriteLine(horarioDeVerao);

    //Mostrar apenas a Data (ocultar horario)
    DateOnly apenasData = new DateOnly(1987, 04, 11); //Colocando a DAta Manualmente
    Console.WriteLine(apenasData);
    DateOnly apenasDataAgora = DateOnly.FromDateTime(DateTime.Now); //Usando o DateTime.Now pra mostrar apenas a data de agora
    Console.WriteLine(apenasDataAgora);

    //Formatando DataHora para um formato especifico com o ToString
    DateTime algumDia = new DateTime(1987,04,11,14,15,35);
    //Voce pode formartar do jeito que quiser, em qualquer ordem.
    Console.WriteLine("Um dia aleatório, com formatação diferente (mes/ano/dia)  " + algumDia.ToString("MM/yyyy/dd HH:mm:ss"));


    //Exemplo prático de Cartão de ponto no trabalho

    DateTime entrada = DateTime.Now;
    Console.WriteLine("Hora de Entrada: " + entrada);
    TimeSpan horasTrabalhadas = new TimeSpan(8, 0, 0); //TimeSpan(hora,Minuto,Segundo) -> Precisa salvar esse valor dentro de uma variável do tipo TimeSpan, para poder somar ela com outra dataHora.
    Console.WriteLine("Total de Horas trabalhadas: " + horasTrabalhadas);
    DateTime saida = entrada.Add(horasTrabalhadas); //Pegou o horario salvo em "entrada", adicionou as "horasTrabalhadas" com Add
    Console.WriteLine("Horário de Saída: " + saida);
}