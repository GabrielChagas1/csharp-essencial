using _030_exercicios;

Console.WriteLine("Exercícios");

Console.WriteLine("1 - Branco \n2 - Vermelho \n3 - Preto \n4 - Cinza \n5 - Azul");
Console.Write("Escolha a cor do carro: ");
int cor = Convert.ToInt32(Console.ReadLine());

Carro chevrolet = new
(
    modelo: "Sedan",
    montadora: "Chevrolet",
    marca: "Onix",
    ano: 2022,
    potencia: 100,
    cor: cor
);



chevrolet.Cor = cor;
chevrolet.ExibirInfo(chevrolet.Ano);

Console.ReadKey();


public class Carro
{
    public string Modelo;
    public string montadora;
    public string Marca;
    public int Ano;
    public int Potencia;
    public int Cor;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia, int cor)
    {
        this.Modelo = modelo;
        this.montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
        Cor = cor;
    }

    public Carro(string modelo, string montadora)
    {
        this.Modelo = modelo;
        this.montadora = montadora;
    }

    public void Exibir()
    {
        Console.WriteLine($"O meu carro é do modelo {Modelo}, da montadora {montadora} da marca {Marca}, do ano {Ano} e potência de {Potencia}");
    }


    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {this.Marca} \n");
    }

    public double VelocidadeMaxima()
    {
        Console.WriteLine($"A velocidade do meu {this.Marca} é de {this.Potencia * 1.75} km/h");
        return this.Potencia * 1.75;
    }

    public int AumentarPotencia(int valor)
    {
        return valor += 3;
    }

    public int AumentarPotencia(ref int valor)
    {
        return valor += 3;
    }

    public int AumentarPotenciaVelocidade(out double velocidade)
    {
        velocidade = this.Potencia * 1.75;
        return this.Potencia += 7;
    }

    public void ExibirInfo(int ano = 2020)
    {
        Console.WriteLine($"Modelo: {this.Modelo}");
        Console.WriteLine($"Montadora: {this.montadora}");
        Console.WriteLine($"Marca: ${this.Marca}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Potência: {this.Potencia}");
        Console.WriteLine($"Cor: {(Cores)this.Cor}");
    }

}