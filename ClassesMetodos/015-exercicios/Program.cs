Console.WriteLine("## Exercicios 03 ##");

//A instrução return é usada para encerrar a execução do método e retornar o controle de volta ao método chamador retornando o valor do tipo definido no método.
//Ao utilizar este construtor os valores dos atributos Marca, Ano e Potencia definidos como campos irão receber o valor padrão atribuído pelo compilador
//passagem por valor, ele vai passar o valor, vai criar a cópia do valor para o método, e o método vai trabalhar com a cópia, ou seja, o valor original não vai ser alterado, ele vai ser mantido, e o método vai retornar o valor alterado, ou seja, a cópia do valor original.
//sobrecarga é quando eu crio o metodo com o mesmo novo e troco a assinatura do metodo, ou seja, os parametros, e o metodo vai ser chamado de acordo com a assinatura, ou seja, se eu passar o valor por valor ele vai chamar o metodo que recebe o valor por valor, se eu passar o valor por referencia ele vai chamar o metodo que recebe o valor por referencia.
//passagem por referencia, ele vai passar a referencia de onde está o valor, ao usar ele eu modifico o valor original, ou seja, o valor que está na memoria, e o método vai trabalhar com o valor original, ou seja, o valor que está na memoria, e o método não precisa retornar o valor alterado, pois ele já está alterando o valor original.


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
Console.WriteLine("Aumentando a Potencia (por valor  : + 3CV) : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado : " + chevrolet.Potencia);

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
    public string Modelo;
    public string montadora;
    public string Marca;
    public int Ano;
    public int Potencia;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
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

}
