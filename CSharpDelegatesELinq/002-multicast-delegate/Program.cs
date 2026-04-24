Console.WriteLine("Multi Delegates");

Delegado? delegado = new(Metodo1);
delegado += Metodo2;
delegado += Metodo3;

delegado("Olá, multicast delegate!");
delegado -= Metodo3;
delegado("Olá, multicast delegate após remover o Método 3!");

Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine($"Metodo 1: {mensagem}");
}

static void Metodo2(string mensagem)
{
    Console.WriteLine($"Metodo 2: {mensagem}");
}

static void Metodo3(string mensagem)
{
    Console.WriteLine($"Metodo 3: {mensagem}");
}

public delegate void Delegado(string mensagem);
