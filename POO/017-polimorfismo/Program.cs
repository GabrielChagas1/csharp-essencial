Console.WriteLine("Polimorfismo");

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo(),
};

foreach (var figura in figuras) figura.Desenhar();

Calcular cal = new();
Console.WriteLine(cal.Somar(30, 40));
Console.WriteLine(cal.Somar(30, 40, 50));

Console.ReadKey();

public class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Executando Desehar na classe base");
    }
}

public class Circulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um Círculo");
        base.Desenhar();
    }
}

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um Triângulo");
        base.Desenhar();
    }
}

class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}