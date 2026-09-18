Console.WriteLine("# Eventos #");

Botao botao = new();

botao.Clique += (sender, e) =>
{
    Console.WriteLine("Ouvinte 1");
};

botao.Clique += (sender, e) =>
{
    Console.WriteLine("Ouvinte 2");
};

botao.Clique += MostrarLog;

Console.WriteLine("Pressione uma tecla para simular o clique no botão...");
Console.ReadKey();
botao.Clicar();
Console.ReadKey();
 
static void MostrarLog(object? sender, EventArgs e)
{
    Console.WriteLine("Log: Botão clicado!");
}

public class Botao
{
    public event EventHandler? Clique;
    public void Clicar()
    {
        Console.WriteLine("Botão clicado!");
        Clique?.Invoke(this, EventArgs.Empty);
    }
}