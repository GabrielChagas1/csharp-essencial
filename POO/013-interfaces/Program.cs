using _013_interfaces;

Console.WriteLine("Interfaces");

IControle demo = new Demo();

demo.Desenhar();
//demo.Pintar();
demo.Exibir();


Console.ReadKey();

public class Demo : IControle, IGrafico
{
    public void Desenhar()
    {
        Console.WriteLine("Desenhando");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando");
    } 
}
