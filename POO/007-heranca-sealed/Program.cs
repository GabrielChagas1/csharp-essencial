Console.WriteLine("Herança Sealed");

//Cliente cliente = new();
//cliente.Apresentar();

Console.ReadKey();

//sealed class Pessoa 
//{
//    public string? Nome { get; set; }
//    public int Idade { get; set; }
//    public void Apresentar()
//    {
//        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
//    }
//}

//class Cliente : Pessoa
//{
//    public new void Apresentar()
//    {
//        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um cliente.");
//    }
//}

class classeBase
{
    public virtual void MetodoVirtual()
    {
        Console.WriteLine("Método virtual na classe base");
    }
}

class classeDerivada : classeBase
{
    public sealed override void MetodoVirtual()
    {
        Console.WriteLine("Método virtual sobrescrito e selado na classe derivada");
    }
}

class Classe2 : classeDerivada
{
    // Não é possível sobrescrever o método MetodoVirtual aqui, pois ele foi selado na classeDerivada
    // public override void MetodoVirtual() // Erro de compilação
    // {
    //     Console.WriteLine("Tentativa de sobrescrever um método selado");
    // }
}
