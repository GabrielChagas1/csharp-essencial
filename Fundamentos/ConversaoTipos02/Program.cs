Console.WriteLine("## Conversão de tipos ##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 567.89M;

string str1 = valorInt.ToString();
string str2 = valorDouble.ToString();
string str3 = valorDecimal.ToString();
Console.WriteLine($"{str1}, {str2}, {str3}");

int valorInt2 = 10;
double valorDouble2 = 3.14;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt2));
Console.WriteLine(Convert.ToDouble(valorInt2));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble2));

int varInt3 = 10000;
Console.WriteLine(Convert.ToByte(varInt3));

Console.ReadLine();