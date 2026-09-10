Console.WriteLine("## Programação Assíncrona ##");

Console.WriteLine("### Café da manhã Síncrono ###");
new Sincrono().CafeDaManha();

Console.WriteLine("\n### Café da manhã Assíncrono ###");
await new CafeDaManhaAsync().CafeDaManha();

public class CafeDaManhaAsync
{
    public async Task CafeDaManha()
    {
        Console.WriteLine("Preparar cafe");
        var tarefaCafe = PrepararCafe();

        Console.WriteLine("Preparar pao");
        var tarefaPao = PrepararPao();

        var cafe = await tarefaCafe;
        var pao = await tarefaPao;

        ServirCafe(cafe, pao);
    }

    public void ServirCafe(Cafe cafe, Pao pao)
    {
        Console.WriteLine("Servindo cafe");
        Thread.Sleep(2000);
        System.Console.WriteLine("Cafe servido");
    }

    public async Task<Cafe> PrepararCafe()
    {
        Console.WriteLine("Fervendo cafe");
        await Task.Delay(2000);
        Console.WriteLine("Coando cafe");
        await Task.Delay(2500);
        Console.WriteLine("Adocando cafe");
        return new Cafe();
    }

    public async Task<Pao> PrepararPao()
    {
        Console.WriteLine("Partir pao");
        await Task.Delay(2000);
        Console.WriteLine("Passar manteiga no pao");
        await Task.Delay(2000);
        Console.WriteLine("Tostar pao");
        return new Pao();
    }
}

public class Sincrono
{
    public void CafeDaManha()
    {
        Console.WriteLine("Preparar cafe");
        var cafe = PrepararCafe();

        Console.WriteLine("Preparar pao");
        var pao = PrepararPao();

        ServirCafe(cafe, pao);
    }

    public void ServirCafe(Cafe cafe, Pao pao)
    {
        Console.WriteLine("Servindo cafe");
        Thread.Sleep(2000);
        Console.WriteLine("Cafe servido");
    }

    public Cafe PrepararCafe()
    {
        Console.WriteLine("Fervendo cafe");
        Thread.Sleep(2000);
        Console.WriteLine("Coando cafe");
        Thread.Sleep(2500);
        Console.WriteLine("Adocando cafe");
        return new Cafe();
    }

    public Pao PrepararPao()
    {
        Console.WriteLine("Partir pao");
        Thread.Sleep(2000);
        Console.WriteLine("Passar manteiga no pao");
        Thread.Sleep(2000);
        Console.WriteLine("Tostar pao");
        return new Pao();
    }
}

public class Cafe { }
public class Pao { }
