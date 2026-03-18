Console.WriteLine("List Find");

List<string> frutas = ["Uva", "Banana", "Pera", "Maca", "Abacate", "Laranja", "Morango"];

//var frutas1 = frutas.Find(Procura);
var frutas1 = frutas.Find(x => x.ToLower().Contains("b"));
var frutas2 = frutas.Find(x => x.First() == 'M');
var frutas3 = frutas.FindIndex(x => x.First() == 'M');
var frutas4 = frutas.FindLast(x => x.First() == 'M');
var frutas5 = frutas.FindAll(x => x.Contains('M'));


Console.WriteLine(frutas1);
Console.WriteLine(frutas2);
Console.WriteLine(frutas4);
Console.WriteLine($"indice={frutas3} - item={frutas[frutas3]}");
foreach (var item in frutas5)
{
    Console.WriteLine(item);
}

Console.ReadKey();


//static bool Procura (string fruta)
//{
//    return fruta.Contains(fruta);
//}

//static bool Procura2 (string fruta)
//{
//    return fruta.StartsWith("M");
//}