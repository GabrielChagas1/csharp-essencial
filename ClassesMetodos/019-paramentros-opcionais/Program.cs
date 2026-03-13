Console.WriteLine("## Paramentros opcionais ##");

Email email = new Email();
email.EnviarEmail("teste@gmail.com");
email.EnviarEmail(destinatario: "teste@gmail.com", mensagem: "Olá, este é um email de teste.", assunto: "Urgente");

Console.ReadKey();

public class Email
{
    public void EnviarEmail(string destinatario, string assunto = "Assunto Padrão", string mensagem = "Mensagem Padrão")
    {
        Console.WriteLine($"Enviando email para: {destinatario}");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Mensagem: {mensagem} \n");
    }
}