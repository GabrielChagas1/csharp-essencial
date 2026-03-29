Console.WriteLine("## Generics ##");

Teste<int, int> teste = new();
Teste<float, float> teste2 = new();
//Teste<string, string> teste3 = new();

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

teste.Comparar(10, 10);
teste2.Comparar(f1, f2);
//teste.Comparar(s1, s2);
//teste.Comparar(s1, f1);

Console.ReadKey();

public class Teste<T1, T2> where T1 : struct where T2 : struct
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }
}
