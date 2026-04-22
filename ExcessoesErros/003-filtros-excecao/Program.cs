using System.Text;

try
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;

    Console.WriteLine("## Exception Filter ##");

    Console.Write("\nInforme o dividendo: ");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nInforme o divisor: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    if (divisor == 0) throw new DivideByZeroException();

    int resultado = dividendo / divisor;
    Console.Write($"\n{dividendo} / {divisor} = {resultado}");

    Console.ReadKey();
}
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("Sextouuuuuuu");
}
catch (Exception ex) when (ex.Message.Contains("Format"))
{
    Console.WriteLine(ex.StackTrace);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}