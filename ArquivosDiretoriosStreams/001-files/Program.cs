Console.WriteLine("## FILES ##");

string caminho = @"C:\Users\GabrielChagas\Desktop\";

//Criar um arquivo
//File.Create(caminho + "arquivo.txt");

File.WriteAllText(caminho + "arquivo.txt", "Olá, mundo!");

string novoTexto = "O poeta é um fingidor." +
    "\nFinge tão completamente" +
    "\nQue chega a fingir que é dor" +
    "\nA dor que deveras sente.";

File.AppendAllText(caminho + "arquivo.txt", "\n\n" + novoTexto);

Console.WriteLine("\nConteúdo e informações do arquivo: \n");
string conteudo = File.ReadAllText(caminho + "arquivo.txt");
Console.WriteLine(conteudo);

Console.WriteLine($"Ultima modificação: {File.GetLastWriteTime(caminho + "arquivo.txt")}");
Console.WriteLine($"Ultimo acesso feito em: {File.GetLastAccessTime(caminho + "arquivo.txt")}");
Console.WriteLine($"Quantidade de linhas: {File.ReadAllLines(caminho + "arquivo.txt").Length}");
Console.WriteLine($"Quantidade de caracters: {File.ReadAllText(caminho + "arquivo.txt").Count(c => !char.IsWhiteSpace(c))}");


string[] linhas = File.ReadAllLines(caminho + "arquivo.txt");
foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}

var caminhoNovo = @"C:\Users\GabrielChagas\Desktop\arquivo_copia.txt";
Console.WriteLine($"\nCopiando de {caminho} para {caminhoNovo}");
File.Copy(caminho + "arquivo.txt", caminhoNovo, true);

string caminhoDestino = @"C:\Users\GabrielChagas\Desktop\txt\arquivo_copia.txt";
Console.WriteLine($"\nMovendo {caminhoDestino} para {caminhoDestino}");
File.Move(caminhoNovo, caminhoDestino, true);

Console.WriteLine($"\nExcluindo de {caminho + "arquivo.txt"}, {caminhoNovo}, {caminhoDestino}");
File.Delete(caminho + "arquivo.txt");
File.Delete(caminhoNovo);
File.Delete(caminhoDestino);

Console.ReadKey();