public class Carro
{
    public string? Modelo;
    public string? Marca;
    internal static double valorIPVA; // 4% do valor do carro

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

    public Carro()
    {
        valorIPVA = 0.04;
    }

    //public static void ObterValorIPVA()
    //{
    //    valorIPVA = 0.04;
    //}

}
