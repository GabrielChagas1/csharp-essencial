Console.WriteLine("## Exercicios 01 ##");

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

    public void Exibir()
    {
        Console.WriteLine($"O meu carro é do modelo {modelo}, da montadora {montadora} da marca {marca}, do ano {ano} e potência de {potencia}");
    }


    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {this.marca} \n");
    }

}