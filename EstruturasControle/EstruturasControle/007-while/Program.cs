Console.WriteLine("## Estrutura de repetição while ##\n");

//var i = 0;

//while (i <= 10)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//var x = 10;

//while (x >= 0)
//{
//    Console.WriteLine($"x = {x}");
//    x--;
//}

Console.Write("Digite um número: ");
var numero = Convert.ToInt32(Console.ReadLine());
var contador = 0;

if (numero < 0)
{
    Console.WriteLine("Número inválido! Digite um número maior ou igual a zero.");
}
else
{
    while (contador <= numero)
    {
        Console.WriteLine($"Contador = {contador}");
        contador++;
    }
}


Console.ReadKey();
