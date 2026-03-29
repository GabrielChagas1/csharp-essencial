Console.WriteLine("Get Hash Code e Equals");

string a = "José";
string b = "José";

int x = 100;
int y = 100;

Pessoa p1 = new(1, "Ana", "47541012300");
Pessoa p2 = new(1, "Ana", "47541012301");
Pessoa p3 = p1;

Console.WriteLine(a.Equals(b));
Console.WriteLine(y.Equals(x));
Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());
Console.WriteLine(p3.GetHashCode());

Console.ReadKey();

public class Pessoa(int id, string? nome, int cpf)
{
    public int Id { get; set; } = id;
    public string? Nome { get; set; } = nome;
    public int CPF { get; set; } = cpf;

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if(obj is not Pessoa) return false;
        var other = (Pessoa)obj;
        return CPF.Equals(other.CPF);
    }
}