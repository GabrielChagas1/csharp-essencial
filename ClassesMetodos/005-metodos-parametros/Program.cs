Console.WriteLine("## Métodos ##");


MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao("Gabriel", DateTime.Now);

Console.ReadKey();


class MinhaClasse
{
    public void Saudacao(string nome, DateTime dataHora)
    {
        Console.WriteLine($"Olá, {nome}! Hoje é {dataHora.ToShortDateString()}");
    }
}