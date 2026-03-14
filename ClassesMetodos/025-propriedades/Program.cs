Console.WriteLine("## Propriedades ##");

Produto p1 = new()
{
    Nome = "Notebook",
    Preco = 4,
    EstoqueMinimo = 5,
};
p1.Exibir();
Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome 
    { 
        get { return nome.ToUpper(); }
        set { nome = value; } 
    }
    private double preco;
    public double Preco 
    { 
        get { return preco; }
        set
        {
            if(value < 5.00)
                preco = 5.00;
            else
                preco = value;
        } 
    }
    private double desconto = 0.05;
    public double Desconto 
    { 
        get { return desconto; }
    }

    public double PrecoFinal 
    { 
        get { return preco - (preco * desconto); }
    }

    private int estoqueMinimo;
    public int EstoqueMinimo 
    { 
        set { estoqueMinimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco:c} \n{Desconto} \n{PrecoFinal:c}");
    }
}