using System.Text;

Console.WriteLine("## Exercícios! ##");
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

//1) V, V, V, V, V

//2) V, V, V, F, V

//try
//{
//    Console.Write("Digite seu nome: ");
//    string nome = Console.ReadLine();

//    if (string.IsNullOrEmpty(nome)) throw new ArgumentException($"Nome não pode ser vazio ou nulo {nameof(nome)}");

//    Console.WriteLine($"Seu nome é: {nome}");

//}
//catch (ArgumentNullException ex)
//{
//	ExceptionLogger.Log(ex, "A entrada não pode ser nula");
//}
//catch (ArgumentException ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//finally
//{
//    Console.WriteLine("\n🏁 Processamento concluído");
//}


//try
//{
//    Console.Write("Digite seu nome: ");
//    string nome = Console.ReadLine();

//    if(string.IsNullOrEmpty(nome)) throw new ArgumentException("O nome não pode ser vazio ou nulo");

//    Console.Write("Digite sua idade: ");
//    if (!int.TryParse(Console.ReadLine(), out int idade))
//        throw new ArgumentException("Idade inválida");

//    if (idade < 0) throw new ArgumentException("A idade não pode ser negativa");

//    if (idade == 0) throw new NotImplementedException("A idade ainda não foi definida.");

//    Console.WriteLine($"Nome: {nome} | Idade: {idade}");
//}
//catch (ArgumentException ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//catch (NotImplementedException ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//catch(Exception ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//finally
//{
//    Console.WriteLine("\n🏁 Processamento concluído");
//}

//try
//{
//    int[] numeros = [109, 211, 313, 405, 519, 617, 711, 891, 951, 1001];

//    foreach (int i in numeros) Console.Write($"{i}, ");
//    Console.WriteLine();

//    Console.Write("Digite o valor do indice: ");
//    if (!int.TryParse(Console.ReadLine(), out int indice))
//        throw new ArgumentException("Indice inválido");

//    if (indice < 0 || indice >= numeros.Length) throw new IndexOutOfRangeException("Indice fora do range");

//    Console.WriteLine($"Valor do indice {indice} é: {numeros[indice]}");

//}
//catch (ArgumentException ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//catch (Exception ex)
//{
//    ExceptionLogger.Log(ex, ex.Message);
//}
//finally
//{
//    Console.WriteLine("\n🏁 Processamento concluído");
//}

try
{
    int saldo = 0;
    int valorSaque = 100;
    if (valorSaque > saldo)
    {
        throw new SaldoInsuficienteException("O saldo é insuficiente para este saque.");
    }
    saldo -= valorSaque;
    Console.WriteLine("Saque efetuado com sucesso. Novo saldo: " + saldo);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Erro: " + e.Message);
}

Console.ReadKey();

class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }

    public SaldoInsuficienteException(string message) : base(message) { }

    public SaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }

    public SaldoInsuficienteException(decimal saque, decimal saldo) : base($"Exception: Valor do saque {saque} é superior ao saldo {saldo}") { }
}

