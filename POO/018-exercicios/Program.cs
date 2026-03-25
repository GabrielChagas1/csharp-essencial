Console.WriteLine("Exercícios");

//1- Sealed

//2- Override (o correto é new)

//3- A, C e D (o correto é apenas D)

//4- vai imprimir o número 2

//5- vai imprimir A e depois B

//6- 1, 2 e 5


//Carro carro = new(0);

//Console.WriteLine("Informe quantos litros de gasolina: ");
//int gasolina = Convert.ToInt32(Console.ReadLine());

//if (carro.Abastecer(gasolina)) carro.Dirigir();

//public interface IVeiculo
//{
//    void Dirigir();
//    bool Abastecer(int quantidade);
//}

//public class Carro(int quantidadeGasolinaInicial) : IVeiculo
//{
//    public int Gasolina { get; set; } = quantidadeGasolinaInicial;

//    public bool Abastecer(int quantidade)
//    {
//        Gasolina += quantidade;
//        return true;
//    }

//    public void Dirigir()
//    {
//        if (Gasolina != 0) 
//        {
//            Console.WriteLine("Dirigindo o carro...");
//        }
//        else
//        {
//            Console.WriteLine("Sem gasolina");
//        }
//    }
//}

//LivroFotos album1 = new LivroFotos();
//Console.WriteLine($"Álbum padrão: {album1.GetNumeroPaginas()} páginas");

//LivroFotos album2 = new LivroFotos(24);
//Console.WriteLine($"Álbum com 24 páginas: {album2.GetNumeroPaginas()} páginas");

//SuperLivroFotos album3 = new SuperLivroFotos();
//Console.WriteLine($"Super álbum: {album3.GetNumeroPaginas()} páginas");

//public class LivroFotos(int numeroPaginas)
//{
//    private int numPaginas = numeroPaginas;

//    public LivroFotos() : this(16)
//    {
//    }

//    public int GetNumeroPaginas() { return numPaginas; }

//}

//public class SuperLivroFotos : LivroFotos
//{
//    public SuperLivroFotos() : base(64)
//    {

//    }
//}



//Pessoa[] pessoas = new Pessoa[3];

//Console.WriteLine("Digite o nome do primeiro aluno:");
//pessoas[0] = new Aluno(Console.ReadLine());

//Console.WriteLine("Digite o nome do segundo aluno:");
//pessoas[1] = new Aluno(Console.ReadLine());

//Console.WriteLine("Digite o nome do professor:");
//pessoas[2] = new Professor(Console.ReadLine());

//Console.WriteLine("\nLista de pessoas:");

//foreach (var pessoa in pessoas)
//{
//    Console.WriteLine(pessoa); // chama ToString()

//    if(pessoa is Aluno aluno)
//    {
//        aluno.Estudar();
//    }

//    else if(pessoa is Professor professor)
//    {
//        professor.Explicar();
//    }
//}

//class Pessoa(string nome)
//{
//    public string? Nome { get; set; } = nome;

//    public override string ToString()
//    {
//        return $"Pessoa: {Nome}";
//    }
//}

//class Aluno(string nome) : Pessoa(nome)
//{
//    public void Estudar() 
//    {
//        Console.WriteLine($"O aluno {Nome} está estudando.");
//    }

//    public override string ToString()
//    {
//        return $"Aluno: {Nome}";
//    }
//}

//class Professor(string nome) : Pessoa(nome)
//{
//    public void Explicar()
//    {
//        Console.WriteLine($"O professor {Nome} está explicando.");
//    }

//    public override string ToString()
//    {
//        return $"Professor: {Nome}";
//    }
//}

//Pessoa[] pessoas = new Pessoa[3];

//for (int i = 0; i < pessoas.Length; i++)
//{
//    Console.Write($"Digite o nome do {i + 1}° aluno: ");
//    string nome = Console.ReadLine() ?? "Sem nome";
//    pessoas[i] = new Pessoa(nome);
//}

//foreach (var pessoa in pessoas)
//{
//    Console.WriteLine(pessoa.ToString());
//}
//class Pessoa(string nome)
//{
//    public string? Nome { get; set; } = nome;

//    public override string ToString()
//    {
//        return $"Pessoa: {Nome}";
//    }
//}

//INota1 p = new Exibir();
//p.Classificacao();
//Console.ReadKey();
//interface INota1
//{
//    void Classificacao();
//}
//interface INota2
//{
//    void Classificacao();
//}
//class Exibir : INota1, INota2
//{
//    void INota1.Classificacao()
//    {
//        Console.WriteLine("Classificacao INota1");
//    }
//    void INota2.Classificacao()
//    {
//        Console.WriteLine("Classificacao INota1");
//    }
//}

//Forma c = new Circulo(3.5);
//Console.WriteLine($"Área do círculo de raio 3.5. A = { c.Area()}");
//Forma q = new Quadrado(5.5);
//Console.WriteLine("Área do quadrado = {0}", q.Area());
//Forma t = new Triangulo(3.0, 5.0);
//Console.WriteLine("Área do triângulo = {0}", t.Area());
//Console.ReadKey();
//Console.WriteLine("\n ----Outra solução -------\n");
//var formas = new List<Forma>()
//{
//new Circulo(3.5),
//new Quadrado(5.5),
//new Triangulo(3.0,5.0)
//};
//foreach (var forma in formas)
//{
//    Console.WriteLine(forma.Area());
//}
//Console.ReadKey();

//public class Forma
//{
//    public virtual double Area()
//    {
//        return 0;
//    }
//}

//public class Circulo : Forma
//{
//    private double Raio { get; set; }
//    public Circulo(double raio)
//    {
//        Raio = raio;
//    }
//    public override double Area()
//    {
//        return (Math.PI * Raio * Raio);
//    }
//}

//public class Quadrado : Forma
//{
//    private double Lado { get; set; }
//    public Quadrado(double lado)
//    {
//        Lado = lado;
//    }
//    public override double Area()
//    {
//        return (Lado * Lado);
//    }
//}

//public class Triangulo : Forma
//{
//    private double Base { get; set; }
//    private double Altura { get; set; }
//    public Triangulo(double b, double h)
//    {
//        Base = b;
//        Altura = h;
//    }
//    public override double Area()
//    {
//        return (0.5 * Base * Altura);
//    }
//}
