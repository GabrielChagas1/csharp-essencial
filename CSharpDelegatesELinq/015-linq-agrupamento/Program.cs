Console.WriteLine("## LINQ Consultas Agrupamento ##");

List<Produto> produtos = Produto.GetProdutos();

var produtosCategoria = produtos
    .GroupBy(produtos => produtos.Categoria)
    .OrderBy(c => c.Key)
    .Select(g => new 
    {
        Categoria = g.Key,
        Count = g.Count(),
        Produtos = g.OrderBy(p => p.Nome)
        .Select(p => new 
        {
            Nome = p.Nome,
            Preco = p.Preco
        })
    });


foreach (var grupo in produtosCategoria)
{
    Console.WriteLine($"\nCategoria: {grupo.Categoria} - Total de Produtos: {grupo.Count}");
    foreach (var produto in grupo.Produtos)
    {
        Console.WriteLine($"{produto.Nome} \t{produto.Preco:C2}");
    }
}

Console.ReadKey();