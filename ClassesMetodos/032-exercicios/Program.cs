Console.WriteLine("## Exercícios estáticos ##");

Carro carro1 = new()
{
    Modelo = "Civic",
    Marca = "Honda",
    Ano = 2025
};

//Carro.ObterValorIPVA();
Console.WriteLine($"Valor do IPVA: {Carro.valorIPVA}");
Console.WriteLine($"Ano: {carro1.Ano}");

Console.ReadKey();
