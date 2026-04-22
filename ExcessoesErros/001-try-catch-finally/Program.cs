using System.Text;

try
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;

    Console.WriteLine("## Try Catch Finally ##");

    Console.Write("\nInforme o dividendo: ");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nInforme o divisor: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    if(divisor == 0) throw new DivideByZeroException();

    int resultado = dividendo / divisor;
    Console.Write($"\n{dividendo} / {divisor} = {resultado}");

    Console.ReadKey();
}
catch(FormatException ex)
{
    string message = $"Informe um valor inteiro";
    ExceptionLogger.Log(ex, message);
}
catch(OverflowException ex)
{
    string message = $"Informe um valor inteiro entre 1 e 999999";
    ExceptionLogger.Log(ex, message);
}
catch(DivideByZeroException ex)
{
    string message = $"Não existe divisão por zero, tente novamente";
    ExceptionLogger.Log(ex, message);
}
catch (Exception ex)
{
    ExceptionLogger.Log(ex, ex.Message);
}
