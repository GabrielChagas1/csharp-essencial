Console.WriteLine("## Herança ##");

ClasseDerivada classeDerivada = new();
classeDerivada.AcessarMembros();

Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void AcessarMembros()
    {
        // Acessando membros da classe base
        PropriedadePublica = "Valor público";
        PropriedadeProtegida = "Valor protegido";
        PropriedadeInterna = "Valor interno";
        PropriedadeProtegidaInterna = "Valor protegido interno";
        MetodoPublico();
        MetodoProtegido();
        MetodoInterno();
        MetodoProtegidoInterno();
        // Não é possível acessar membros privados da classe base
        // PropriedadePrivada = "Valor privado"; // Erro de compilação
        // MetodoPrivado(); // Erro de compilação

        Console.WriteLine("Acesso ao campo private : private_var usando uma propriedade GET");
        Console.WriteLine(Private_var);
    }
}

public class ClasseBase {     
    public string? PropriedadePublica { get; set; }
    protected string? PropriedadeProtegida { get; set; }
    private string? PropriedadePrivada { get; set; }
    internal string? PropriedadeInterna { get; set; }
    protected internal string? PropriedadeProtegidaInterna { get; set; }

    private int private_var = 10;
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }

    public void MetodoPublico()
    {
        Console.WriteLine("Método público");
    }
    protected void MetodoProtegido()
    {
        Console.WriteLine("Método protegido");
    }
    private void MetodoPrivado()
    {
        Console.WriteLine("Método privado");
    }

    internal void MetodoInterno()
    {
        Console.WriteLine("Método interno");
    }

    protected internal void MetodoProtegidoInterno()
    {
        Console.WriteLine("Método protegido interno");
    }
}
