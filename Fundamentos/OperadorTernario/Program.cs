Console.WriteLine("## Operador Ternario ##\n");

//int positivo = 1;
//int resultado;
//resultado = +positivo;
//Console.WriteLine(resultado);

//Console.Write("Informe um número: ");
//int numero = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O negativo de {numero} é {-numero}");

//positivo = numero >= 0 ? numero : -numero;
//Console.WriteLine($"O valor absoluto de {numero} é {positivo}");

//Console.Write("Informa a temperatura: ");
//var temperatura = Convert.ToDouble(Console.ReadLine());

//var resultado = temperatura >= 27.0 ? "quente!" : "frio!";
//Console.WriteLine($"O tempo está {resultado}");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());
string resultado = x > y ? "x é maior que y" :
                    x < y ? "x é menor que y" : 
                    x == y ? "x é igual a y" : "Sem Resultado";

Console.WriteLine(resultado);


Console.ReadKey();