Console.WriteLine("## EventHandler ##");

Pedido pedido = new Pedido();
pedido.NotificarPedidoCriado += SMS.EnviarSMS;
pedido.NotificarPedidoCriado += Email.EnviarEmail;
pedido.CriarPedido();

Pedido2 pedido2 = new Pedido2();
pedido2.NotificarPedidoCriado += SMS2.EnviarSMS;
pedido2.NotificarPedidoCriado += Email2.EnviarEmail;

pedido2.CriarPedido("gabriel.chagas@outlook.com", "11999999999");

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

class Pedido2
{
    public event EventHandler<PedidoEventArgs>? NotificarPedidoCriado;
    public void CriarPedido(string email, string telefone)
    {
        Console.WriteLine($"Pedido Criado");
        if (NotificarPedidoCriado != null)
        {
            NotificarPedidoCriado(this, new PedidoEventArgs(email, telefone));
        }
    }
}

class PedidoEventArgs(string email, string telefone) : EventArgs
{
    public string? Email { get; set; } = email;
    public string? Telefone { get; set; } = telefone;

}

class SMS
{
    public static void EnviarSMS(object? sender, EventArgs e)
    {
        Console.WriteLine($"Enviando SMS para");
    }
}

class Email
{
    public static void EnviarEmail(object? sender, EventArgs e)
    {
        Console.WriteLine($"Enviando Email");
    }
}

class SMS2
{
    public static void EnviarSMS(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando SMS {e.Telefone}");
    }
}

class Email2
{
    public static void EnviarEmail(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando Email para {e.Email}");
    }
}

