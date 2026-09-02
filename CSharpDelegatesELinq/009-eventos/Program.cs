Console.WriteLine("## Eventos ##");

Pedido pedido = new Pedido();
pedido.NotificarPedidoCriado += SMS.EnviarSMS;
pedido.NotificarPedidoCriado += Email.EnviarEmail;

pedido.CriarPedido();

Console.ReadKey();

delegate void EnviarNotificacao();
class Pedido
{
    public event EnviarNotificacao? NotificarPedidoCriado;
    public void CriarPedido()
    {
        Console.WriteLine($"Pedido Criado");
        if(NotificarPedidoCriado != null)
        {
            NotificarPedidoCriado();
        }

    }
}

class SMS
{
    public static void EnviarSMS()
    {
        Console.WriteLine($"Enviando SMS");
    }
}

class Email
{
    public static void EnviarEmail()
    {
        Console.WriteLine($"Enviando Email");
    }
}
