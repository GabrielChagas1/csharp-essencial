int opcao = 0;
Personagem? personagem = null;

while (opcao != 4)
{
    Console.WriteLine("Opção 1 - Criar Personagem");
    Console.WriteLine("Opção 2 - Ver Ficha");
    Console.WriteLine("Opção 3 - Atacar Inimigo");
    Console.WriteLine("Opção 4 - Sair do Jogo");
    Console.Write("Escolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao == 1)
    {
        int classe;
        do
        {
            Console.Write("\nSeleciona a classe desejada (1 - Guerreiro, 2 - Mago, 3 - Arqueiro) : ");
            classe = Convert.ToInt32(Console.ReadLine());
        } while (classe < 1 || classe > 3);

        Console.Write($"Nome do personagem: ");
        switch (classe)
        {
            case 1:
                personagem = new Guerreiro(Console.ReadLine() ?? "Sem nome");
                break;
            case 2:
                personagem = new Mago(Console.ReadLine() ?? "Sem nome");
                break;
            case 3:
                personagem = new Arqueiro(Console.ReadLine() ?? "Sem nome");
                break;
        }

    }
    if (opcao == 2)
    {
        if (personagem == null)
        {
            Console.WriteLine("\nCrie um personagem primeiro!\n");
            continue;
        }
        personagem.ExibirFicha();
    }


    if (opcao == 3)
    {
        if (personagem == null)
        {
            Console.WriteLine("\nCrie um personagem primeiro!\n");
            continue;
        }
        Goblin globin = new("Goblin");
        var resultado = personagem.Atacar(globin);

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"{resultado.NomeAtacante} atacou {resultado.NomeAlvo}");
        Console.WriteLine($"Dano base: {resultado.DanoBase}");
        Console.WriteLine($"{resultado.NomeAlvo} bloqueou {resultado.Bloqueado}");
        Console.WriteLine($"Dano final: {resultado.DanoFinal}");

        if (resultado.AlvoMorreu)
        {
            Console.WriteLine($"{resultado.NomeAlvo} foi derrotado!");
        }
        else
        {
            Console.WriteLine($"{resultado.NomeAlvo} agora tem {resultado.VidaRestante} de vida.");
        }
        Console.WriteLine("---------------------------------");
    }
    Console.WriteLine();
}

Console.WriteLine("Finalizado, aperte uma tecla para sair!");
Console.ReadKey();


class Personagem(string nome, int pontosDeVida, int ataque, int defesa)
{
    public string? Nome { get; set; } = nome;
    public int PontosDeVida { get; set; } = pontosDeVida < 0 ? 0 : pontosDeVida;
    public int Ataque { get; set; } = ataque;
    public int Defesa { get; set; } = defesa;

    protected static Random random = new();

    public virtual ResultadoAtaque Atacar(Personagem alvo)
    {
        int danoBase = RecuperarDano();
        int bloqueado = Math.Min(danoBase, alvo.Defesa);
        int danoFinal = Math.Max(0, danoBase - bloqueado);

        alvo.PontosDeVida -= danoFinal;

        bool morreu = alvo.PontosDeVida <= 0;
        if (morreu) alvo.PontosDeVida = 0;

        return new ResultadoAtaque
        {
            NomeAtacante = Nome ?? "",
            NomeAlvo = alvo.Nome ?? "",
            DanoBase = danoBase,
            Bloqueado = bloqueado,
            DanoFinal = danoFinal,
            VidaRestante = alvo.PontosDeVida,
            AlvoMorreu = morreu
        };
    }

    public virtual void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome}, Pontos de Vida: {PontosDeVida}, Ataque: {Ataque}, Defesa: {Defesa}");
    }

    public virtual int RecuperarDano()
    {
        return Ataque;
    }
}

class Guerreiro(string nome) : Personagem(nome, 120, 20, 15)
{
    public override ResultadoAtaque Atacar(Personagem alvo)
    {
        var resultado = base.Atacar(alvo);
        resultado.NomeAtacante = $"[GUERREIRO] {resultado.NomeAtacante}";
        return resultado;
    }

    public override void ExibirFicha()
    {
        base.ExibirFicha();
        Console.WriteLine("Classe: Guerreiro");
    }

    public override int RecuperarDano()
    {
        return Ataque + 5;
    }
}

class Mago(string nome): Personagem(nome, 70, 30, 8)
{
    public override ResultadoAtaque Atacar(Personagem alvo)
    {
        var resultado = base.Atacar(alvo);
        resultado.NomeAtacante = $"[GUERREIRO] {resultado.NomeAtacante}";
        return resultado;
    }
    public override void ExibirFicha()
    {
        base.ExibirFicha();
        Console.WriteLine("Classe: Mago");
    }

    public override int RecuperarDano()
    {
        return Ataque + 10;
    }
}

class Arqueiro(string nome) : Personagem(nome, 90, 22, 12)
{
    public override ResultadoAtaque Atacar(Personagem alvo)
    {
        var resultado = base.Atacar(alvo);
        resultado.NomeAtacante = $"[ARQUEIRO] {resultado.NomeAtacante}";
        return resultado;
    }
    public override void ExibirFicha()
    {
        base.ExibirFicha();
        Console.WriteLine("Classe: Arqueiro");
    }

    public override int RecuperarDano()
    {
        return Ataque + random.Next(0, 10);
    }
}

class Goblin(string nome) : Personagem(nome, 50, 0, 10) { }

class ResultadoAtaque
{
    public string NomeAtacante { get; set; } = "";
    public string NomeAlvo { get; set; } = "";
    public int DanoBase { get; set; }
    public int Bloqueado { get; set; }
    public int DanoFinal { get; set; }
    public int VidaRestante { get; set; }
    public bool AlvoMorreu { get; set; }
}
