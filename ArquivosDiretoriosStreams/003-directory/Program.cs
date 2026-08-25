Console.WriteLine("Directory");

string caminhoDiretorio = @"C:\Users\GabrielChagas\Desktop\poesia\MeuDiretorio\";
string caminhoDiretorioPai = @"C:\Users\GabrielChagas\Desktop\poesia\";

//Console.WriteLine("\nCriando um novo diretório");
//try
//{
//    if(!Directory.Exists(caminhoDiretorio))
//    {
//        Directory.CreateDirectory(caminhoDiretorio);
//        Console.WriteLine($"O diretório {caminhoDiretorio} foi criado com sucesso.");
//    }
//    else
//    {
//        Console.WriteLine($"O diretório {caminhoDiretorio} já existe.");
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

//Console.WriteLine("\nDeletando um diretório");
//try
//{
//    if (Directory.Exists(caminhoDiretorio))
//    {
//        Directory.Delete(caminhoDiretorio);
//        Console.WriteLine($"O diretório {caminhoDiretorio} foi deletado com sucesso.");
//    }
//    else
//    {
//        Console.WriteLine($"O diretório {caminhoDiretorio} não existe.");
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

//Console.WriteLine("\nObtendo os subdiretórios de um diretório");

//try
//{
//    if (Directory.Exists(caminhoDiretorioPai))
//    {
//        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorioPai);
//        foreach (var subdiretorio in subdiretorios)
//        {
//            Console.WriteLine(subdiretorio);
//        }
//    }
//    else
//    {
//        Console.WriteLine($"O diretório {caminhoDiretorioPai} não existe.");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Console.WriteLine("\nObtendo os arquivos de um diretório");

//try
//{
//    if (Directory.Exists(caminhoDiretorioPai))
//    {
//        string[] arquivos = Directory.GetFiles(caminhoDiretorioPai, "p*");
//        foreach (var arquivo in arquivos)
//        {
//            Console.WriteLine(arquivo);
//        }
//    }
//    else
//    {
//        Console.WriteLine($"O diretório {caminhoDiretorioPai} não existe.");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

Console.WriteLine("\nMovendo de um diretório");
string caminhoDiretorioDestino = @"C:\Users\GabrielChagas\Desktop\poesia\MeuDiretorioNovo";

try
{
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Move(caminhoDiretorio, caminhoDiretorioDestino);
        Console.WriteLine($"O diretório {caminhoDiretorio} foi movido para {caminhoDiretorioDestino} com sucesso.");
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} não existe.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
