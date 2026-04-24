using _001_delegates;

Console.WriteLine("## Delegates ##");

var resultado = Calculadora.Somar(10, 50);
Console.WriteLine(resultado);

OperacaoMatematica calc = new(Calculadora.Somar);
var resultado1 = calc.Invoke(20, 30);
Console.WriteLine(resultado1);

OperacaoMatematica calc2 = Calculadora.Somar;
var resultado2 = calc.Invoke(20, 30);
Console.WriteLine(resultado2);

OperacaoMatematica cal3 = (float a, float b) => Calculadora.Somar(a, b);
var resultado3 = cal3(20, 30);
Console.WriteLine(resultado3);

calc = Calculadora.Multiplicar;
var resultado4 = calc(20, 30);
Console.WriteLine($"Multiplicar = {resultado4}");

Console.ReadKey();

public delegate float OperacaoMatematica(float a, float b);