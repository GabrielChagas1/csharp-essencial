using _016_propriedades_parciais;

Console.WriteLine("## Propriedades Parciais ##");
Produto produto = new() { Preco = 10 };

Console.WriteLine($"Valor com imposto: {produto.ValorComImposto}");


Console.ReadKey();