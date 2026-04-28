Console.WriteLine("## EventHandler ##");

Pedido pedido = new Pedido();
pedido.NotificarPedidoCriado += SMS.EnviarSMS;
pedido.NotificarPedidoCriado += Email.EnviarEmail;

pedido.CriarPedido();

Console.ReadKey();

class Pedido
{
    public event EventHandler? NotificarPedidoCriado;
    public void CriarPedido()
    {
        Console.WriteLine($"Pedido Criado");
        if (NotificarPedidoCriado != null)
        {
            NotificarPedidoCriado(this, EventArgs.Empty);
        }
    }
}

class SMS
{
    public static void EnviarSMS(object? sender, EventArgs e)
    {
        Console.WriteLine($"Enviando SMS");
    }
}

class Email
{
    public static void EnviarEmail(object? sender, EventArgs e)
    {
        Console.WriteLine($"Enviando Email");
    }
}

