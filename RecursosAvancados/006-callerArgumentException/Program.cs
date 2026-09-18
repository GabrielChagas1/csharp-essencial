using System.Runtime.CompilerServices;

Console.WriteLine("CallerArgumentException");

ProdutoService service = new();

//sucesso
try
{
    service.AdicionarProduto("Produto A", 10.99m);
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Erro: {ex.Message}");
}

//nome nulo
try
{
    service.AdicionarProduto(null!, 3000.00m);
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Erro: {ex.Message}");
}

//Preço negativo
try
{
    service.AdicionarProduto("Produto B", -5.00m);
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Erro: {ex.Message}");
}

//id inválido
try
{
    service.AtualizarProduto(0, 15.00m);
}   
catch (Exception ex)
{
    Console.WriteLine($"❌ Erro: {ex.Message}");
}


Console.ReadKey();


//class ProdutoService
//{
//    public void AdicionarProduto(string nome, decimal preco)
//    {
//        ValidationHelper.ValidateNotNullOrEmpty(nome, nameof(nome));
//        ValidationHelper.ValidateGreaterThanZero(preco, nameof(preco));
//        // Lógica para adicionar o produto

//        Console.WriteLine($"Produto '{nome}' adicionado com sucesso. Preço: {preco:C}");
//    }

//    public void AtualizarProduto(int id, decimal preco)
//    {
//        ValidationHelper.ValidateGreaterThanZero(id, nameof(id));
//        ValidationHelper.ValidateGreaterThanZero(preco, nameof(preco));
//        // Lógica para atualizar o produto
//        Console.WriteLine($"Produto com ID {id} atualizado com sucesso. Novo preço: {preco:C}");
//    }
//}

//public static class ValidationHelper
//{
//    public static void ValidateNotNullOrEmpty(string value, string paramName)
//    {
//        if (string.IsNullOrWhiteSpace(value))
//        {
//            throw new ArgumentException($"O parâmetro '{paramName}' não pode ser nulo ou vazio.", paramName);
//        }
//    }
//    public static void ValidateGreaterThanZero(decimal value, string paramName)
//    {
//        if (value <= 0)
//        {
//            throw new ArgumentException($"O parâmetro '{paramName}' deve ser maior que zero.", paramName);
//        }
//    }
//    public static void ValidateGreaterThanZero(int value, string paramName)
//    {
//        if (value <= 0)
//        {
//            throw new ArgumentException($"O parâmetro '{paramName}' deve ser maior que zero.", paramName);
//        }
//    }
//}

class ProdutoService
{
    public void AdicionarProduto(string nome, decimal preco)
    {
        ValidationHelper.ValidateNotNullOrEmpty(nome);
        ValidationHelper.ValidateGreaterThanZero(preco);
        // Lógica para adicionar o produto

        Console.WriteLine($"Produto '{nome}' adicionado com sucesso. Preço: {preco:C}");
    }

    public void AtualizarProduto(int id, decimal preco)
    {
        ValidationHelper.ValidateGreaterThanZero(id);
        ValidationHelper.ValidateGreaterThanZero(preco);
        // Lógica para atualizar o produto
        Console.WriteLine($"Produto com ID {id} atualizado com sucesso. Novo preço: {preco:C}");
    }
}

public static class ValidationHelper
{
    public static void ValidateNotNullOrEmpty(string value, [CallerArgumentExpression("value")] string paramName = null!)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"O parâmetro '{paramName}' não pode ser nulo ou vazio.", paramName);
        }
    }
    public static void ValidateGreaterThanZero(decimal value, [CallerArgumentExpression("value")] string paramName = null!)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"O parâmetro '{paramName}' deve ser maior que zero.", paramName);
        }
    }
    public static void ValidateGreaterThanZero(int value, [CallerArgumentExpression("value")] string paramName = null!)
    {
        if (value <= 0)
        {
            throw new ArgumentException($"O parâmetro '{paramName}' deve ser maior que zero.", paramName);
        }
    }
}