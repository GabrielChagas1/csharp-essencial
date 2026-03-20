using _013_indexadores;

Console.WriteLine("## Indexadores ##");

Time time = new Time();

time[0] = "São Paulo";
time[1] = "Palmeiras";
time[2] = "Santos";
time[3] = "Corinthians";


string valor = time[0];
string valor2 = time[1];
string valor3 = time[2];
string valor4 = time[3];

Console.WriteLine(valor);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);

Console.ReadKey();


