Console.WriteLine("Exercícios Herança");

List<Conta> clientes = new()
{
    new ContaCorrente { Titular = "João", NumeroCliente = 12345 },
    new ContaInvestimento { Titular = "Maria", NumeroCliente = 67890 },
    new ContaPoupanca { Titular = "Carlos", NumeroCliente = 54321 }
};

foreach(Conta conta in clientes)
{
    conta.Depositar(1000);
    conta.Sacar(100);
    conta.ExibirInformacoes();
    Console.WriteLine();
}

Console.ReadKey();

abstract class Conta
{
    public string? Titular { get; set; }
    public int NumeroCliente { get; set; }

    protected decimal Saldo { get;  private set; } = 0.00m;

    public virtual void Depositar(decimal valor)
    {
        if(valor < 0)
        {
            Console.WriteLine("Valor inválido");
            return;
        }
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor:C} realizado. Saldo atual: {Saldo:C}");
    }

    public virtual void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {Saldo:C}");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Cliente > Nome: {Titular}, Número do Cliente: {NumeroCliente}, Saldo: {Saldo:C}");
    }
}

class ContaCorrente : Conta
{

}

class ContaPoupanca : Conta
{
    public decimal TaxaRendimento { get; set; } = 0.005m;
    public override void Depositar(decimal valor)
    {
        decimal rendimento = valor * TaxaRendimento;
        base.Depositar(valor + rendimento);
        Console.WriteLine($"Depósito de {valor:C} realizado. Rendimento de {rendimento:C} aplicados. Saldo atual: {Saldo:C}");
    }
}

class ContaInvestimento : Conta
{
    public decimal TaxaRendimento { get; set; } = 0.009m;
    public decimal TaxaJuros { get; set; } = 0.001m;
    public override void Depositar(decimal valor)
    {
        decimal rendimento = valor * TaxaRendimento;
        base.Depositar(valor + rendimento);
        Console.WriteLine($"Depósito de {valor:C} realizado. Rendimento de {rendimento:C} aplicado. Saldo atual: {Saldo:C}");
    }

    public override void Sacar(decimal valor)
    {
        decimal juros = valor * TaxaJuros;
        decimal valorTotal = valor + juros;
        if(valorTotal > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para saque, incluindo juros.");
        }
        else
        {
            base.Sacar(valorTotal);
            Console.WriteLine($"Saque de {valor:C} realizado com juros de {juros:C}. Saldo atual: {Saldo:C}");
        }
    }
}
