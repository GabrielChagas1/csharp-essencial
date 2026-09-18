Console.WriteLine("## Propriedades Automáticas ##");

Produto produto = new() { Preco = -10.5m };

Console.WriteLine($"Preço do produto: {produto.Preco}");

Console.ReadKey();

public class Produto
{
    public decimal Preco {
        get;
        set => field = value < 0 ? throw new ArgumentException("O preço deve ser maior que zero.") : value;
    }
}