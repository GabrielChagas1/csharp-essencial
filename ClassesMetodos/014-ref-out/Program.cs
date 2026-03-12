Console.WriteLine("REF OUT");

int x = 20;
Console.WriteLine($"Valor do argumento x antes de passar por valor: {x}");

Calculo calculo = new();
calculo.Dobrar(x);
calculo.DobrarRef(ref x);

Console.WriteLine($"Valor do argumento x depois de passar por valor: {x}");


Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método dobrar: {y}");
    }

    public void DobrarRef(ref int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método dobrarRef: {y}");
    }
    // public void DobrarOut(out int y)
    //{
    //    y = 20; // O parâmetro out deve ser atribuído antes de ser usado
    //    y *= 2;
    //    Console.WriteLine($"Valor do parâmetro y no método dobrarOut: {y}");
    //}
}