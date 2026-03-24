Console.WriteLine("## Herança Override ##");

Gato gato = new() { Nome = "Mia" };
gato.ExibeNome();

Cachorro cachorro = new() { Nome = "Rex" };
cachorro.ExibeNome();

Console.ReadKey();

class Animal
{
    public string Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}

class Gato : Animal
{
    //usando override para modificar o comportamento do método ExibeNome da classe base
    public override void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome} e sou um gato.");
    }
}

class Cachorro: Animal
{

}
