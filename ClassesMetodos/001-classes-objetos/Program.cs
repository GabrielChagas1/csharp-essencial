Console.WriteLine("## Classes e Objetos ##");


Pessoa pessoa = new Pessoa
{
    nome = "Gabriel",
    idade = 26,
    sexo = "Masculino"
};

Pessoa pessoa2 = pessoa; // Atribuição por referência

Console.WriteLine($"{pessoa.nome} tem {pessoa.idade} anos e é do sexo {pessoa.sexo}");
Console.WriteLine($"{pessoa2.nome} tem {pessoa2.idade} anos e é do sexo {pessoa2.sexo}");

Console.ReadKey();


class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;

    //public void Comer();
    //public void Respirar();
    //public void Trabalhar();
}