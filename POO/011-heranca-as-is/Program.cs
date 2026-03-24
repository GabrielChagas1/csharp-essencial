Console.WriteLine("Herança AS IS");

Object carroObj = new Carro(); // Criando um objeto do tipo Carro e armazenando em uma variável do tipo Object

var x = carroObj as string; // Tentando converter o objeto para string usando 'as'. Isso resultará em null, pois carroObj não é uma string.

if(x != null)
{
    Console.WriteLine("A conversão foi bem-sucedida.");
}
else
{
    Console.WriteLine("A conversão falhou. O objeto não é do tipo string.");
}

Circulo circulo = new Circulo();
Forma forma = circulo; // Upcasting - Forma é a classe base de Circulo

if(forma is Circulo)
{
    Console.WriteLine("A conversão usando 'is' foi bem-sucedida. O objeto é do tipo Circulo.");
    //((Circulo)forma).PintarCirculo(); 
    Circulo? c = forma as Circulo; // Usando 'as' para tentar converter Forma de volta para Circulo
    c?.PintarCirculo(); // Agora podemos chamar o método específico de Circulo
}
else
{
    Console.WriteLine("A conversão usando 'is' falhou. O objeto não é do tipo Circulo.");
}

Console.ReadKey();

class Carro
{

}

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
