Console.WriteLine("Ranges and Indices");

//var frutas = new[]
//{
//    "Maçã",       // 0/ ^10
//    "Banana",     // 1/ ^9
//    "Laranja",    // 2/ ^8
//    "Uva",        // 3/ ^7
//    "Morango",    // 4/ ^6
//    "Abacaxi",    // 5/ ^5
//    "Manga",      // 6/ ^4
//    "Melancia",   // 7/ ^3
//    "Kiwi",       // 8/ ^2
//    "Pera"        // 9/ ^1
//};

//1)Pera
//2)Manga
//3)Uva, Morango, Abacaxi, Manga
//4)Abacaxi, Manga, Melancia, Kiwi, Pera
//5)Maça, Banana, Laranja, Uva, Morango, Abacaxi
//6)Laranja, Uva, Morango, Abacaxi, Manga
//7)Morango, Abacaxi, Manga, Melancia

//var teste8 = frutas[2..6];
//var teste9 = frutas[^4..];
//var teste10 = frutas[..^4];

//ImprimirArray(teste10);

var numeros = new[]
{
    10, 20, 30, 40, 50,
    60, 70, 80, 90, 100,
    110, 120
};


//11)40, 50, 60, 70, 80, 90,
//12)50, 60, 70, 80, 90
//13)30, 40, 50,60, 70, 80
//14) 30,40, 50

//15) Não, pq usar o ^1 faz o ultimo ficar fora da lista
//16) Está correto, ele vai pegar os ultimos 3 elementos
//17) Não, pq esse código vai pegar tudo que vem no quinto elemento final
//18) Está correto, ele vai tudo o quem vem até o quinto elemento

var letras = new[]
{
    "A", "B", "C", "D", "E",
    "F", "G", "H", "I", "J",
    "K", "L"
};

var resultado = letras[^9..^3];

//19) D
//20) I
//21) 6 elementos
//22) D, E, F, G, H, I

Console.ReadKey();

static void ImprimirArray<T>(T[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}