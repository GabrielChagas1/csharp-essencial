Console.WriteLine("Herança Upcasting e Downcasting");

Circulo circulo = new Circulo(10, 20);
Forma forma = circulo; // Upcasting - Forma é a classe base de Circulo

forma.Desenhar(); // Chama o método Desenhar da classe Circulo devido ao polimorfismo

Circulo c = (Circulo)forma; // Downcasting - Forma é convertida de volta para Circulo
c.PintarCirculo(); // Agora podemos chamar o método específico de Circulo

Console.ReadKey();

public class Forma
{
    protected int xpos, ypos;
    public Forma() { }

    public Forma(int x, int y)
    {
        xpos = x;
        ypos = y;
    }

    public virtual void Desenhar()
    {
        Console.WriteLine($"Desenhar - Forma na posição: ({xpos}, {ypos})");
    }
}

public class Circulo : Forma
{
    public Circulo() { }
    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar()
    {
        Console.WriteLine($"Desenhar - Círculo na posição: ({xpos}, {ypos})");
    }

    public void PintarCirculo()
    {
        Console.WriteLine("Pintar o círculo");
    }
}
