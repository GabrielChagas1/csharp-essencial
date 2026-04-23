using System.Text;

Console.WriteLine("## Excessoes Personalizadas ##");
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

try
{
    Conta conta1 = new(100, "Maria", 100m);
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo: {conta1.Saldo:C}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo: {conta1.Saldo:C}");
}
catch (Exception ex)
{

    ExceptionLogger.Log(ex, ex.Message);
}
Console.ReadKey();


public class Conta(int numero, string? titular, decimal saldo)
{
    public int Numero {  get; set; } = numero;
    public string? Titular { get; set; } = titular;
    public decimal Saldo { get; set; } = saldo;

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: {valor:C}");
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        if (Saldo < valor) throw new SaldoInsuficienteException(valor, Saldo);

        Console.WriteLine($"Sacou: {valor:C}");
        Saldo -= valor;
        return Saldo;
    }

    public override string ToString()
    {
        return $"Conta: {Numero} : {Titular} - Saldo: {Saldo:C}";
    }
}
