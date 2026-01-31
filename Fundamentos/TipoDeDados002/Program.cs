Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 3.14;
float n2 = 3.14f;
decimal n3 = 3.14m;

Console.WriteLine($"Valores => {n1} {n2} {n3}");

Console.ReadLine();

Console.WriteLine("Comparando a precisão de float, double e decimal");
float x = 1f /3f;
double y = 1d /3d;
decimal z = 1m /3m;
Console.WriteLine($"Valores => {x} {y} {z}");

Console.ReadLine();
