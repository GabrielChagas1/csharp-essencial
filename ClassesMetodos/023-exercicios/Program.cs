Console.WriteLine("## Exercícios estáticos ##");

//ContaCorrente conta1 = new()
//{
//    Conta = 123,
//    Titular = "João",
//};

//ContaCorrente conta2 = new()
//{
//    Conta = 456,
//    Titular = "Maria",
//};
//ContaCorrente.Juros = 0.01f; // 1% ao mês

//Console.WriteLine($"Conta: {conta1.Conta}, Titular: {conta1.Titular}, Juros Anual: {conta1.JurosAnual() * 100}%");
//Console.WriteLine($"Conta: {conta2.Conta}, Titular: {conta2.Titular}, Juros Anual: {conta2.JurosAnual() * 100}%");

Carro carro1 = new()
{
    Modelo = "Civic",
    Marca = "Honda"
};

Carro.ObterValorIPVA();
Console.WriteLine($"Valor do IPVA: {Carro.valorIPVA}");

Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Titular;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}

public class Carro
{
    public string? Modelo;
    public string? Marca;
    public static double valorIPVA; // 4% do valor do carro

    public static void ObterValorIPVA()
    {
       valorIPVA = 0.04;
    }

}
