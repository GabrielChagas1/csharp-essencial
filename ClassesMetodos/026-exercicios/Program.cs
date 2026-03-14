Console.WriteLine("## Exercícios estáticos ##");

Carro carro1 = new()
{
    Modelo = "Civic",
    Marca = "Honda",
    Ano = 2025
};

Carro.ObterValorIPVA();
Console.WriteLine($"Valor do IPVA: {Carro.valorIPVA}");
Console.WriteLine($"Ano: {carro1.Ano}");

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Marca;
    public static double valorIPVA; // 4% do valor do carro

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
        }
    }

    public static void ObterValorIPVA()
    {
        valorIPVA = 0.04;
    }

}
