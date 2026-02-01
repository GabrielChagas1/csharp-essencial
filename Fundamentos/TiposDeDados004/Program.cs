Console.WriteLine("Atribuindo valores string, object e dynamic");
Console.WriteLine();

string nome = "João da Silva";
String nome2 = "Maria Oliveira";

Console.WriteLine(nome, nome2);

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";

object nota = 10;
object valor1 = 8.55m;
object ativa = true;

dynamic variavel = 10;

Console.WriteLine(valor);
Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(ativa);
Console.WriteLine(variavel);


Console.ReadLine();