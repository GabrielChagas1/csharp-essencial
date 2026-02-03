Console.WriteLine("## Constantes ##\n");

//const int ANO = 2024;
//const int MES = 12, SEMANA = 13, QUINZENA = 2;

//const int MESES_ANO = 12;
//const int DIAS_ANO = 365;

//const float DIAS_POR_MES = (float)DIAS_ANO / MESES_ANO;
//Console.WriteLine(DIAS_POR_MES);

double raio, perimetro, area;
//const double PI = 3.14159;

Console.Write("Digite o valor do raio: ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"Perimetro: {perimetro}, Raio: {area}");




Console.ReadKey();

