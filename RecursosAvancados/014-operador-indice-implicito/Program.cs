Console.WriteLine("## Operador de Índice Implícito ##");

var lista = Enumerable.Range(1, 10);

var outraLista = new List<int>(lista)
{
    [9] = 15
};

Console.WriteLine(string.Join(", ", outraLista));

var inicializaArray = new InicializaArray
{
    Inteiros =
    {
        [0] = 1,
        [^4] = 20,
        [^3] = 2,
        [^2] = 3,
        [^1] = 4,
    }
};
Console.WriteLine(string.Join(", ", inicializaArray.Inteiros));


class InicializaArray 
{
    public int[] Inteiros { get; set; } = new int[5];
}