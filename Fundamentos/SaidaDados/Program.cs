Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "João";

Console.WriteLine(nome);
Console.WriteLine(idade);

//escreve na mesma linha
Console.WriteLine(nome + " tem " + idade + " anos");

//usa a interpolação de strings: $ => a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");

//usar placeholders : usa {} com numeração com inicio em 0
Console.WriteLine("{0} tem {1} anos", nome, idade);


Console.ReadLine();