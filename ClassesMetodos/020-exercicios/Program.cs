Console.WriteLine("## Exercicios 04 ##");

//A instrução return é usada para encerrar a execução do método e retornar o controle de volta ao método chamador retornando o valor do tipo definido no método.
//Ao utilizar este construtor os valores dos atributos Marca, Ano e Potencia definidos como campos irão receber o valor padrão atribuído pelo compilador
//passagem por valor, ele vai passar o valor, vai criar a cópia do valor para o método, e o método vai trabalhar com a cópia, ou seja, o valor original não vai ser alterado, ele vai ser mantido, e o método vai retornar o valor alterado, ou seja, a cópia do valor original.
//sobrecarga é quando eu crio o metodo com o mesmo novo e troco a assinatura do metodo, ou seja, os parametros, e o metodo vai ser chamado de acordo com a assinatura, ou seja, se eu passar o valor por valor ele vai chamar o metodo que recebe o valor por valor, se eu passar o valor por referencia ele vai chamar o metodo que recebe o valor por referencia.
//passagem por referencia, ele vai passar a referencia de onde está o valor, ao usar ele eu modifico o valor original, ou seja, o valor que está na memoria, e o método vai trabalhar com o valor original, ou seja, o valor que está na memoria, e o método não precisa retornar o valor alterado, pois ele já está alterando o valor original.

//O parametro opcional é um recurso que permite que eu tenha um método que não precise receber todos os valores dos parametros, argumentos nomeados é um recurso que permite que eu chame um método passando os valores dos parametros de forma nomeada, ou seja, eu posso passar os valores dos parametros em qualquer ordem, e o método vai reconhecer qual valor é para qual parametro.


Carro chevrolet = new
(
    modelo: "Sedan",
    montadora: "Chevrolet",
    marca: "Onix",
    ano: 2022,
    potencia: 100
);
chevrolet.ExibirInfo(chevrolet.Ano);
chevrolet.ExibirInfo();


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
    }

}
