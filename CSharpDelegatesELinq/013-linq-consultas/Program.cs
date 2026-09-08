Console.WriteLine("## LINQ Consultas ##");

List<Produto> produtos = Produto.GetProdutos();

Console.WriteLine("\nProdutos eletrônicos");
var produtosEletronicos = produtos.Where(p => p.Categoria == "Eletronicos");
ExibirProdutos(produtosEletronicos);

Console.WriteLine("\nProdutos mais caros com estoque superior a 5");
var produtosCaros = produtos.Where(p => p.Preco > 1000 && p.Estoque > 5);
ExibirProdutos(produtosCaros);

Console.WriteLine("\nLista de produtos com estoque minimo de 10, ordenados pelo nome");
var produtosOrdenados = produtos.Where(p => p.Estoque >= 10).OrderBy(p => p.Nome);
ExibirProdutos(produtosOrdenados);

Console.WriteLine("\nProdutos ordernados por categoria e nome");
var produtosOrdenadosCategoria = produtos.OrderBy(p => p.Categoria).ThenBy(p => p.Nome);
ExibirProdutos(produtosOrdenadosCategoria, true);

Console.WriteLine("\nLista dos nomes dos produtos ordenados");
var nomesProdutos = produtos.Select(p => p.Nome).OrderBy(n => n);
ExibirLista(nomesProdutos);


Console.WriteLine("\nProdutos com valor menor que R$500 com aumento de 10% ordenados por nome");
var produtosComAumento = produtos.Where(p => p.Preco < 500)
                            .Select(p => new Produto
                            {
                                Id = p.Id,
                                Nome = p.Nome,
                                Preco = p.Preco * 1.10f,
                                Estoque = p.Estoque,
                                Categoria = p.Categoria
                            })
                            .OrderBy(p => p.Nome);
ExibirProdutos(produtosComAumento);


Console.WriteLine("\nProdutos com valor maior que R$2000 com desconto de 20% ordenados por nome");
var produtosComDesconto = produtos.Where(p => p.Preco > 2000)
                            .Select(p => new Produto
                            {
                                Id = p.Id,
                                Nome = p.Nome,
                                Preco = p.Preco * 0.80f,
                                Estoque = p.Estoque,
                                Categoria = p.Categoria
                            })
                            .OrderBy(p => p.Nome);
ExibirProdutos(produtosComDesconto);


Console.WriteLine("\nValor médio dos produtos eletronicos");
var valorTotal = produtos.Where(p => p.Categoria == "Eletronicos").Average(p => p.Preco);
Console.WriteLine($"{valorTotal:C2}");

Console.WriteLine("\nValor total dos produtos em estoque");
var valorTotalEstque = produtos.Where(p => p.Estoque > 0).Sum(p => p.Preco * p.Estoque);
Console.WriteLine($"{valorTotalEstque:C2}");

Console.WriteLine("\nQuantidade de produtos com estoque mínimo (< 10)");
var quantidadeProdutosBaixoEstoque = produtos.Count(p => p.Estoque < 10);
Console.WriteLine(quantidadeProdutosBaixoEstoque);


Console.ReadKey();

static void ExibirProdutos(IEnumerable<Produto> produtos, bool isCategoria = false)
{
    if (!isCategoria)
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine($"- {produto.Nome} \t({produto.Preco:C2})");
        }
        return;
    }


    string? categoriaAnterior = string.Empty;
    foreach (var produto in produtos)
    {
        if (produto.Categoria != categoriaAnterior)
        {
            Console.WriteLine($"\nCategoria: {produto.Categoria}");
            categoriaAnterior = produto.Categoria;
        }
        Console.WriteLine($"- {produto.Nome} \t({produto.Preco:C2})");
    }

}

static void ExibirLista<T>(IEnumerable<T> itens)
{
    foreach (var item in itens)
    {
        Console.WriteLine($"- {item}");
    }
}