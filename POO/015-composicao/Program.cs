Console.WriteLine("Composição");

Console.ReadKey();

public class Telhado { }
public class Alicerce { }

public class Casa
{
    private readonly Telhado _telhado;
    private readonly Alicerce _alicerce;

    public Casa()
    {
        _telhado = new Telhado();
        _alicerce = new Alicerce();
    }
}