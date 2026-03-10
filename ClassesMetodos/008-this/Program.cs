Console.WriteLine("## This ##");

//Teste t1 = new()
//{
//    num1 = 10,
//    num2 = 20
//};
//t1.Exibir();

//Teste t2 = new ()
//{
//    num1 = 88,
//    num2 = 99
//};
//t2.Exibir();

Teste t3 = new(123);


Console.ReadKey();

//public class Cliente
//{
//    public string? Nome;
//    public int Idade;

//    public Cliente(string nome, int idade)
//    {
//        this.Nome = nome;
//        this.Idade = idade;
//    }
//}

//public class Teste
//{
//    public int num1;
//    public int num2;
//    public void PassarParametro(Teste t)
//    {
//        Console.WriteLine($"this: {this}");
//        Console.WriteLine($"Num1: {num1}");
//        Console.WriteLine($"Num2: {num2}");
//    }

//    public void Exibir()
//    {
//        PassarParametro(this);
//    }
//}

public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"Construtor com dois parametros {num1} e {num2}");
    }

    public Teste(int num1): this(777, 888)
    {
        Console.WriteLine($"Construtor com um parametro {num1}");
    }
}