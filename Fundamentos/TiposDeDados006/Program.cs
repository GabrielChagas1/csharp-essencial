Console.WriteLine("Nullable Types");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> c = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(c);


//simplicação
int? teste = null;
Console.WriteLine(teste);

int? a = null;
int b = a ?? 10;
Console.WriteLine(b);

int? value = null;
if(value.HasValue)
{
    Console.WriteLine($"O valor é {value.Value}");
}
else
{
    Console.WriteLine("O valor é nulo");
}

Console.ReadLine();
