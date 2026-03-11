Console.WriteLine("## Métodos com retorno ##");

Email mail = new();


Console.ReadKey();

public class Email
{
    public string EnviarEmail(string destinatario, string assunto, string mensagem)
    {
        // Lógica para enviar o email
        return $"Email enviado para {destinatario} com assunto '{assunto}'";
    }
    public string EnviarEmail(string destinatario, string assunto)
    {
        // Lógica para enviar o email sem mensagem
        return $"Email enviado para {destinatario} com assunto '{assunto}' e sem mensagem";
    }

    public string EnviarEmail(decimal assunto, string destinatario)
    {
        // Lógica para enviar o email sem mensagem
        return $"Email enviado para {destinatario} com assunto '{assunto}' e sem mensagem";
    }
}