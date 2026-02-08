Console.WriteLine("## Estruturas IF ##");

//Console.Write("Cliente especial (S/N): ");
//string clienteEspecial = Console.ReadLine();

//if(clienteEspecial == "S" || clienteEspecial == "s")
//{
//    Console.WriteLine("Desconto de 10% aplicado!");
//}

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("X é maior que Y");
}
if(x < y)
{
    Console.WriteLine("Y é maior que X");
}
if(x == y)
{
    Console.WriteLine("X é igual a Y");
}


Console.ReadKey();