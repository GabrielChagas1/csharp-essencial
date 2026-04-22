using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Throw");

try
{
    A.ProcessarA();
}
catch (Exception ex)
{

    ExceptionLogger.Log(ex, ex.Message);
}

Console.ReadKey();

class A
{
    public static void ProcessarA() 
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw;
            //ExceptionLogger.Log(ex, ex.Message);
        }
    }
}

class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            throw;
            //ExceptionLogger.Log(ex, ex.Message);
        }
    }
}


class C
{
    public static void ProcessarC()
    {
       throw new NotImplementedException("Método não implementado");
    }
}

