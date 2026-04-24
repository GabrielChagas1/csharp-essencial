Console.WriteLine("Funções Anônimas");

Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Valor: {valor}");
};

imprimir(100);

List<string> nomes =  new List<string> { "Maria", "Miriam", "Paulo", "Carlos" };

string? resultado = nomes.Find(VerificaNomeNaLista);

string? resultado2 = nomes.Find(delegate (string nome)
{
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);
Console.WriteLine(resultado2);

Console.ReadKey();

static bool VerificaNomeNaLista(string nome)
{
    return nome.Equals("Paulo");
}

public delegate void Imprimir(int valor);
