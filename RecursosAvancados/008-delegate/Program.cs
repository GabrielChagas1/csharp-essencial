Console.WriteLine("Hello, World!");

ExibirMensagem acionador = new();

Console.WriteLine("\nPressione algo para criar o delegate");
Console.ReadKey();

Notificador notificador = acionador.MostrarNaTela;
notificador("Olá, mundo dos delegates!");
Console.WriteLine("\nPressione algo para incluir outro método e chamar ambos");
Console.ReadKey();

notificador += acionador.EnviarEmail;
notificador("Nova mensagem importante");
Console.ReadKey();

public delegate void Notificador(string mensagem);

class ExibirMensagem
{
    public void MostrarNaTela(string mensagem)
    {
        Console.WriteLine($"Mensagem na tela: {mensagem}");
    }
    public void EnviarEmail(string mensagem)
    {
        Console.WriteLine($"Mensagem enviada por e-mail: {mensagem}");
    }
}