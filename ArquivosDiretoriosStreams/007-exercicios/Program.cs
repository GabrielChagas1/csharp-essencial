Console.WriteLine("## Exercícios ##");

string caminhoArquivo = @"C:\Users\GabrielChagas\Desktop\poesia\txt\exercicio.txt";

Console.Write("\nCaminho do arquivo a ser criado: ");
Console.Write(caminhoArquivo);
bool executando = true;

while (executando)
{
    Console.WriteLine("\nMENU DE OPÇÕES");
    Console.WriteLine("[1] - Criar Arquivo");
    Console.WriteLine("[2] - Gravar no Arquivo");
    Console.WriteLine("[3] - Ler no arquivo");
    Console.WriteLine("[4] - Procurar no arquivo");
    Console.WriteLine("[5] - Sair");

    Console.Write("Digite sua opção: ");
    if (!int.TryParse(Console.ReadLine(), out int opcao))
    {
        Console.WriteLine("Entrada inválida!");
        continue;
    }

    switch (opcao)
    {
        case 1:
            CriarArquivo(caminhoArquivo);
            break;
        case 2:
            GravarArquivo(caminhoArquivo);
            break;
        case 3:
            LerArquivo(caminhoArquivo);
            break;
        case 4:
            ProcurarArquivo(caminhoArquivo);
            break;
        case 5:
            Console.WriteLine("Saindo do programa...");
            executando = false;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

Console.ReadKey();

static void CriarArquivo(string caminhoArquivo)
{
    try
    {
        File.Create(caminhoArquivo).Close();
        Console.WriteLine("Arquivo criado com sucesso!");
    }
    catch (IOException ex)
    {

        Console.WriteLine(ex.Message);
    }
}

static void GravarArquivo(string caminhoArquivo)
{
    Console.Write("Digite o conteúdo a ser gravado no arquivo: ");
    string conteudo = Console.ReadLine()!;
    try
    {
        File.WriteAllText(caminhoArquivo, conteudo);
        Console.WriteLine($"\n>> Texto gravado com sucesso! {caminhoArquivo}");
    }
    catch (IOException ex)
    {

        Console.WriteLine(ex.Message);
    }
}

static void LerArquivo(string caminhoArquivo)
{
    if(!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("O arquivo não existe. Por favor, crie o arquivo primeiro.");
        return;
    }

    try
    {
        string conteudoLido = File.ReadAllText(caminhoArquivo);
        Console.WriteLine("Conteúdo do arquivo:");
        Console.WriteLine(conteudoLido);
        return;
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}

static void ProcurarArquivo(string caminhoArquivo)
{
    if(File.Exists(caminhoArquivo))
    {
        Console.Write("Digite a palavra ou frase a ser procurada: ");
        string termoBusca = Console.ReadLine()!;
        string[] linhas = File.ReadAllLines(caminhoArquivo);
        bool encontrado = false;
        foreach (string linha in linhas)
        {
            if (linha.Contains(termoBusca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Encontrado: {linha}");
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Termo não encontrado no arquivo.");
        }
    }
    else
    {
        Console.WriteLine("O arquivo não existe. Por favor, crie o arquivo primeiro.");
    }
}