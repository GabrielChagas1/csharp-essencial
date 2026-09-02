Console.WriteLine("## Stream ##");

var caminhoDiretorio = @"C:\Users\GabrielChagas\Desktop\poesia\txt";

//FileStream fs = null;
//StreamReader sr = null;

//try
//{
//    fs = new FileStream(caminhoDiretorio + @"\poesia.txt", FileMode.Open, FileAccess.Read);
//    sr = new StreamReader(fs);

//    string? linha;
//    while ((linha = sr.ReadLine()) != null)
//    {
//        Console.WriteLine(linha);
//    }

//}
//catch(IOException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    sr?.Close();
//    fs?.Close();
//}

try
{
    using FileStream fs = new(caminhoDiretorio + @"\poesia.txt", FileMode.Open, FileAccess.Read);
    using StreamReader sr = new(fs);

    string? linha;
    while ((linha = sr.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

Console.ReadKey();