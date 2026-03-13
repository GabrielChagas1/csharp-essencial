Console.WriteLine("## Atributos estáticos ##");

A a1 = new();
a1.x = 10;

A a2 = new();
a2.x = 20;

A.y = 30;

Console.WriteLine($"a1.x = {a1.x} a2.x = {a2.x} A.y = {A.y}");

Console.ReadKey();

public class A
{
    public int x;
    public static int y;

}

