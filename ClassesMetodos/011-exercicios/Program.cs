Console.WriteLine("## Exercicios 01 ##");

//A instrução return é usada para encerrar a execução do método e retornar o controle de volta ao método chamador retornando o valor do tipo definido no método.
//Ao utilizar este construtor os valores dos atributos Marca, Ano e Potencia definidos como campos irão receber o valor padrão atribuído pelo compilador

Carro chevrolet = new
(
    modelo: "Sedan",
    montadora: "Chevrolet",
    marca: "Onix",
    ano: 2020,
    potencia: 100
);
chevrolet.Exibir();
chevrolet.Acelerar();
double potencia = chevrolet.VelocidadeMaxima();

Carro ford = new
(
    modelo: "Hatch",
    montadora: "Ford",
    marca: "Ka",
    ano: 2021,
    potencia: 120
);

ford.Exibir();
ford.Acelerar();
double potenciaFord = ford.VelocidadeMaxima();


public class Carro
{
    public string modelo;
    public string montadora;
    public string marca;
    public int ano;
    public int potencia;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public Carro(string modelo, string montadora)
    {
        this.modelo = modelo;
        this.montadora = montadora;
    }

    public void Exibir()
    {
        Console.WriteLine($"O meu carro é do modelo {modelo}, da montadora {montadora} da marca {marca}, do ano {ano} e potência de {potencia}");
    }


    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {this.marca} \n");
    }

    public double VelocidadeMaxima()
    {
        Console.WriteLine($"A velocidade do meu {this.marca} é de {this.potencia * 1.75} km/h");
        return this.potencia * 1.75;
    }

}