Console.WriteLine("## LINQ Consultas 02 ##");

List<Produto> produtos = Produto.GetProdutos();

Console.WriteLine("\n First - Localiza o primeiro elemento");
var primeiroProduto = produtos.First();
Console.WriteLine($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C2}");

try
{
    var primeiroProdutoNome = produtos.First(p => p.Nome == "Cadeiras");
    Console.WriteLine($"{primeiroProdutoNome.Nome} \t{primeiroProdutoNome.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

var primeiroProdutoNome2 = produtos.FirstOrDefault(p => p.Nome == "Cadeiras");
if(primeiroProdutoNome2 != null)
{
    Console.WriteLine($"{primeiroProdutoNome2.Nome} \t{primeiroProdutoNome2.Preco:C2}");
}
else
{
    Console.WriteLine("Produto não encontrado");
}

try
{
    var ultimoProduto = produtos.Last();
    Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

var ultimoProduto2 = produtos.LastOrDefault();
if (ultimoProduto2 != null)
{
    Console.WriteLine($"{ultimoProduto2.Nome} \t{ultimoProduto2.Preco:C2}");
}
else
{
    Console.WriteLine("Produto não encontrado");
}

try
{
    var unicoProduto = produtos.Single();
    Console.WriteLine($"{unicoProduto.Nome} \t{unicoProduto.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    var unicoProduto2 = produtos.SingleOrDefault(x => x.Nome == "Cadeira");
    if (unicoProduto2 != null)
    {
        Console.WriteLine($"{unicoProduto2.Nome} \t{unicoProduto2.Preco:C2}");
    }
    else
    {
        Console.WriteLine("Produto não encontrado");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"Erro: {ex.Message}");
}




Console.ReadKey();