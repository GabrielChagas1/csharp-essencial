Console.WriteLine("## Conversão de tipos ##\n");

int varInt = 100;
double varDouble = varInt;
Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;
Console.WriteLine($"{numeroInt}, {numeroLong}, {numeroFloat}, {numeroDouble}, {numeroDecimal}");


double varDouble2 = 1234.56;
int varInt2 = (int)varDouble2;
Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;

float resultadoFloat = (float)num1 / (float)num2;
Console.WriteLine(resultadoFloat);


Console.ReadLine();