Console.WriteLine("Enum");

Console.WriteLine(DiasDaSemana.Domingo);

int dia1 = (int)DiasDaSemana.Domingo;
Console.WriteLine(dia1);

Console.WriteLine((Categorias)1);

Console.ReadKey();

enum Categorias
{
    Moda, 
    Automoveis,
    Artes,
    Esportes
}


enum DiasDaSemana
{
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
}
