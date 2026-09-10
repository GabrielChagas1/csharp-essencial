using _016_exercicios;
using System;

Console.WriteLine("## Exercicios ##");

//1)Considere as seguintes assertivas sobre delegates na linguagem C#. Indique se cada uma é verdadeira ou falsa:

//a)V
//b)V
//c)V
//d)V
//e)V   
//f)F
//g)F
//h)V

//2)Escreva um programa em C# que utilize um delegate para calcular a soma de dois números inteiros. O programa deve solicitar ao usuário que insira os números e, em seguida, exibir o resultado da soma.
//OperacaoMatematica? somar = new(Soma);
//Console.Write("Digite o primeiro valor: ");
//int valor1 = int.Parse(Console.ReadLine() ?? "0");

//Console.Write("Digite o segundo valor: ");
//int valor2 = int.Parse(Console.ReadLine() ?? "0");

//var resultado = somar(valor1, valor2);
//Console.WriteLine($"A soma de {valor1} e {valor2} = {resultado}");

//static int Soma(int a, int b)
//{
//    return a + b;
//}

//public delegate int OperacaoMatematica(int a, int b);

//3Implemente um programa em C# que use multicast delegates para exibir uma mensagem de boas-vindas ao usuário. O programa deve seguir as seguintes especificações:

//MensagemBoasVindas? mensagemBoasVindas = new(GerarMensagemBoasVindasPT);
//mensagemBoasVindas += GerarMensagemBoasVindasEN;

//mensagemBoasVindas.Invoke();

//static void GerarMensagemBoasVindasPT()
//{
//    Console.WriteLine("Boas-Vindas");
//}

//static void GerarMensagemBoasVindasEN()
//{
//    Console.WriteLine("Welcome");
//}

//public delegate void MensagemBoasVindas();

//4) Dado o código abaixo, assinale com verdadeiro ou falso cada afirmação sobre os delegates Action, Predicate e Func da linguagem C#
//a)V
//b)V
//c)V
//d)V
//e)V
//f)V
//g)V
//h)V

//5)5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros de 1 a 20. Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e imprima na tela apenas os números pares.
//var lista = Enumerable.Range(1, 20).ToList();
//Action<int> exibirNumero = num => 
//{
//    if (num % 2 == 0)
//    {
//        Console.WriteLine($"{num} é par");
//    }
//};
//lista.ForEach(exibirNumero);

//6)

//CalcularOperacao(10, 5, (x, y) => x + y);
//CalcularOperacao(10, 5, (x, y) => x - y);
//static void CalcularOperacao(int a, int b, Func<int, int, int> operacao)
//{
//    int resultado = operacao(a, b);
//    Console.WriteLine($"O resultado da operação é: {resultado}");
//}


//7)
//List<Planeta> planetas = new List<Planeta>
//{
//    new("Mercúrio", 4879, 3.301e23),
//    new("Vênus", 12104, 4.867e24),
//    new("Terra", 12756, 5.972e24),
//    new("Marte", 6792, 6.39e23),
//    new("Júpiter", 142984, 1.898e27),
//    new("Saturno", 120536, 5.683e26),
//    new("Urano", 51118, 8.681e25),
//    new("Netuno", 49528, 1.024e26)
//};

//// Filtrar os planetas com diâmetro maior que 10000 km 
//Predicate<Planeta> filtro = p => p.Diametro > 10000;
//List<Planeta> planetasGrandes = Filtrar(planetas, filtro);

//Console.WriteLine("Planetas com diâmetro maior que 10000 km:");
//foreach (Planeta planeta in planetasGrandes)
//{
//    Console.WriteLine(planeta.Nome);
//}
//Console.ReadKey();

//static List<Planeta> Filtrar(List<Planeta> lista, Predicate<Planeta> filtro)
//{
//    List<Planeta> resultado = new List<Planeta>();
//    foreach (Planeta planeta in lista)
//    {
//        if (filtro(planeta))
//        {
//            resultado.Add(planeta);
//        }
//    }
//    return resultado;
//}

//class Planeta
//{
//    public string Nome { get; set; }
//    public double Diametro { get; set; }
//    public double Massa { get; set; }
//    public Planeta(string nome, double diametro, double massa)
//    {
//        Nome = nome;
//        Diametro = diametro;
//        Massa = massa;
//    }
//}

//8)A

//9)

//var lista = Enumerable.Range(0, 11).ToList();
//int somaPares = lista.SomaPares();
//Console.WriteLine(somaPares);

//10)

string[] frutas = { "banana", "abacaxi", "uva", "laranja", "abacate", "Kiwi" };
int[] numeros = { 5, 2, 8, 3, 1, 7, 4, 6 };

var frutasA = frutas.Where(x => x.Contains('a'));
foreach (var fruta in frutasA)
{
    Console.WriteLine(fruta);
}

var numerosCrescente = numeros.OrderBy(x => x);
foreach (var numero in numerosCrescente)
{
    Console.WriteLine(numero);
}

var agruparTamanho = frutas.GroupBy(x => x.Length).OrderBy(x => x.Key);
foreach (var grupo in agruparTamanho)
{
    //Console.WriteLine($"Frutas com {grupo.Key} letras:");
    foreach (var fruta in grupo)
    {
        Console.WriteLine($"{fruta} - {grupo.Key} letras");
    }
}

var numeroPar = numeros.FirstOrDefault(x => x % 2 == 0);
Console.WriteLine(numeroPar);