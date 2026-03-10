Console.WriteLine("## Métodos ##");


MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.MeuMetodo();
minhaClasse.Saudacao("Gabriel");
minhaClasse.ExibirDataHora();


Console.ReadKey();


class MinhaClasse
{
    public void MeuMetodo()
    {
        Console.WriteLine("Este é um método da minha classe.");
    }

    public void Saudacao(string nome)
    {
        Console.WriteLine($"Olá, {nome}!");
    }

    public void ExibirDataHora()
    {
        Console.WriteLine($"Data e hora atuais: {DateTime.Now.ToShortDateString()}");
    }
}